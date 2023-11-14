using Microsoft.Office.Interop.Excel;
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
		string maHH;
		int slcon;
		int kt = 0;
		string strAnh;
		public frmNhapHang()
        {
            InitializeComponent();
        }
		private void dgvNhapHang_Click(object sender, EventArgs e)
        {
            try
            {
                ResetValue();
                maHH = dgvNhapHang.CurrentRow.Cells[0].Value.ToString();
                string temp = dgvNhapHang.CurrentRow.Cells[5].Value.ToString();
                slcon = Convert.ToInt32(temp);
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
                picAnh.Image = Image.FromFile("ImagePhone\\"+dgvNhapHang.CurrentRow.Cells[6].Value.ToString());
				strAnh = dgvNhapHang.CurrentRow.Cells[6].Value.ToString();
				cmbLoai.SelectedItem = dgvNhapHang.CurrentRow.Cells[7].Value.ToString();
                txtDacDiem.Text = dgvNhapHang.CurrentRow.Cells[8].Value.ToString();
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
                dgvNhapHang.DataSource = db.DataReader("select MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh, Loai, DacDiem from HANGHOA");
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
            picAnh.Image = null;
            txtDacDiem.Text = "";
            cmbLoai.SelectedItem = null;
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            dgvNhapHang.DataSource = db.DataReader("select MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh, Loai, DacDiem from HANGHOA");
			dgvNhapHang.Columns[0].HeaderText = "Mã hàng";
			dgvNhapHang.Columns[1].HeaderText = "Tên hàng";
			dgvNhapHang.Columns[2].HeaderText = "Giá Bán";
			dgvNhapHang.Columns[3].HeaderText = "Hãng";
			dgvNhapHang.Columns[4].HeaderText = "Bộ Nhớ";
			dgvNhapHang.Columns[5].HeaderText = "Số Lượng";
			dgvNhapHang.Columns[6].HeaderText = "File ảnh";
			dgvNhapHang.Columns[7].HeaderText = "Loại";
			dgvNhapHang.Columns[8].HeaderText = "Đặc Điểm";
		}

        private void btnThemHangMoi_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnNhap.Enabled = false;
            grbChiTietNhap.Enabled = true;
            string str = "HH" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            txtMaHH.Text = ft.SinhMaTuDong("HANGHOA", str, "MaHH");
            btnEdit.Enabled = false;
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
                        int sl = Convert.ToInt32(txtSLM.Text);
                        db.DataChange("insert into hanghoa (MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh, DacDiem, Loai)values('" + txtMaHH.Text + "','" + txtTenHang.Text + "','" + txtGiaBan.Text + "','" + cbmHang.SelectedItem.ToString() + "','" + cbmBoNho.SelectedItem.ToString() + "'," + sl + ",'" + strAnh +"', N'"+txtDacDiem.Text + "',N'" + cmbLoai.SelectedItem.ToString() + "')");
                        dgvNhapHang.DataSource = db.DataReader("select MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh, Loai, DacDiem from HANGHOA");
                        kt = 0;
                        ResetValue();
                    }
                }
                else if (kt == 2)
                {
                    string bonho = cbmBoNho.SelectedItem.ToString();
                    db.DataChange("update HANGHOA set TenHH = '" + txtTenHang.Text + "', GiaBan = '" + txtGiaBan.Text + "', Hang = '" + cbmHang.SelectedItem.ToString() + "', Bo_nho = '" + bonho + "', So_luong = " + Convert.ToInt32(txtSLM.Text) + ", Anh = '" + strAnh + "',DacDiem= N'" + txtDacDiem.Text + "', Loai = N'" + cmbLoai.SelectedItem.ToString() + "' where maHH ='" + txtMaHH.Text + "'");
                    dgvNhapHang.DataSource = db.DataReader("select MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong, Anh, Loai, DacDiem from HANGHOA");
                    kt = 0;
                    ResetValue();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("lỗi "+ex.Message.ToString(),"lỗi");
            }
        }
        private void btnAnh_Click(object sender, EventArgs e)
        {
			dlgAnh.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif) |*.gif|All files(*.*)|*.*";
			dlgAnh.InitialDirectory = "D:\\workspace\\github\\QuanLyDienThoai\\QuanLyDienThoai\\bin\\Debug\\ImagePhone";
			dlgAnh.FilterIndex = 3;
			dlgAnh.Title = "Chọn ảnh để hiển thị";
			if (dlgAnh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				picAnh.Image = Image.FromFile(dlgAnh.FileName);
				string[] str = dlgAnh.FileName.Split('\\');
				strAnh = str[str.Length - 1].ToString();

			}
			else
				MessageBox.Show("You clicked Cancel", "Open Dialog",
								 MessageBoxButtons.OK, MessageBoxIcon.Information);
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
