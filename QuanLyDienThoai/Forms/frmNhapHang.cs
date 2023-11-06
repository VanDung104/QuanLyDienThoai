using QuanLyDienThoai.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai.Forms
{
    public partial class frmNhapHang : Form
    {
        DataBaseProcess db = new DataBaseProcess();
        Functions ft = new Functions();
        public frmNhapHang()
        {
            InitializeComponent();
        }
        string maHH;
        int slcon;
        int kt = 0;
        string fileNameImg;
        string fileNameImg1;
        private void dgvNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                ResetValue();
                maHH = dgvNhapHang.CurrentRow.Cells[0].Value.ToString();
                string temp = dgvNhapHang.CurrentRow.Cells[5].Value.ToString();
                slcon = Convert.ToInt32(temp);
                btnThemHangMoi.Enabled = false;
                btnNhap.Enabled = true;
                btnLuu.Enabled = true;
                txtSL.Enabled = true;
                btnEdit.Enabled = true;
                txtMaHH.Text = dgvNhapHang.CurrentRow.Cells[0].Value.ToString();
                txtTenHang.Text = dgvNhapHang.CurrentRow.Cells[1].Value.ToString();
                txtGiaBan.Text = dgvNhapHang.CurrentRow.Cells[2].Value.ToString();
                cbmHang.SelectedItem = dgvNhapHang.CurrentRow.Cells[3].Value.ToString();
                cbmBoNho.SelectedItem = dgvNhapHang.CurrentRow.Cells[4].Value.ToString();
                txtSLM.Text = dgvNhapHang.CurrentRow.Cells[5].Value.ToString();
                picbAnh.Image = Image.FromFile(dgvNhapHang.CurrentRow.Cells[6].Value.ToString());
                fileNameImg1 = dgvNhapHang.CurrentRow.Cells[6].Value.ToString();
                btnLuu.Enabled = false;
                kt = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng cần nhập!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Focus();
            }
            else
            {
                int slmoi = Convert.ToInt32(txtSL.Text);
                db.DataChange("update HANGHOA set So_Luong= " + (slcon + slmoi) + "where MaHH = '" + maHH + "'");
                dgvNhapHang.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
                btnThemHangMoi.Enabled = true;
                MessageBox.Show("Bạn đã nhập hàng thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Text = "";
                btnNhap.Enabled = false;
                txtSL.Enabled = false;
            }
        }
        void ResetValue()
        {
            txtMaHH.Text = "";
            cbmHang.SelectedItem = null;
            txtTenHang.Text = "";
            txtSLM.Text = "";
            txtGiaBan.Text = "";
            cbmBoNho.SelectedItem = null;
            picbAnh.Image = null;
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnLuu.Enabled = false;
            grbChiTietNhap.Enabled = false;
            txtSL.Enabled = false;
            btnNhap.Enabled = false;
            dgvNhapHang.DataSource = db.DataReader("select MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh from HANGHOA");
        }

        private void btnThemHangMoi_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnLuu.Enabled = true;
            btnNhap.Enabled = false;
            grbChiTietNhap.Enabled = true;
            string str = "HH" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            txtMaHH.Text = ft.SinhMaTuDong("HANGHOA", str, "MaHH");
            kt = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kt == 1)
                {
                    if (string.IsNullOrEmpty(cbmBoNho.SelectedItem?.ToString()) || string.IsNullOrEmpty(txtSLM.Text))
                    {
                        MessageBox.Show("Bạn đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string bonho = cbmBoNho.SelectedItem.ToString();
                        int sl = Convert.ToInt32(txtSLM.Text);
                        db.DataChange("insert into hanghoa (MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh)values('" + txtMaHH.Text + "','" + txtTenHang.Text + "','" + txtGiaBan.Text + "','" + cbmHang.SelectedItem.ToString() + "','" + bonho + "'," + sl + ",'" + fileNameImg + "')");
                        dgvNhapHang.DataSource = db.DataReader("select MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh from HANGHOA");
                        kt = 0;
                        ResetValue();
                    }
                }
                else if (kt == 2)
                {
                    string bonho = cbmBoNho.SelectedItem.ToString();
                    db.DataChange("update HANGHOA set TenHH = '" + txtTenHang.Text + "', GiaBan = '" + txtGiaBan.Text + "', Hang = '" + cbmHang.SelectedItem.ToString() + "', Bo_nho = '" + bonho + "', So_luong = " + Convert.ToInt32(txtSLM.Text) + ", Anh = '" + fileNameImg1 + "' where maHH ='" + txtMaHH.Text + "'");
                    dgvNhapHang.DataSource = db.DataReader("select MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh from HANGHOA");
                    kt = 0;
                    ResetValue();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("lỗi "+ex.Message.ToString(),"lỗi");
            }
        }
        private void updateImg()
        {
            try
            {
                openFileDialog1.Filter = "JPG FILES (*.jpg)|*.jpg| PNG FILES(*.png)|*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    picbAnh.Image = Image.FromFile(openFileDialog1.FileName);
                fileNameImg = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi chọn ảnh. \n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAnh_Click(object sender, EventArgs e)
        {
            updateImg();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            kt = 2;
            grbChiTietNhap.Enabled = true;
            btnLuu.Enabled = true;
            btnNhap.Enabled = false;
        }
    }
}
