using QuanLyDienThoai.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private void dgvNhapHang_Click(object sender, EventArgs e)
        {
            maHH = dgvNhapHang.CurrentRow.Cells[0].Value.ToString();
            string temp = dgvNhapHang.CurrentRow.Cells[4].Value.ToString();
            slcon = Convert.ToInt32(temp);
            btnThemHangMoi.Enabled = false;
            grbChiTietNhap.Enabled = false;
            btnNhap.Enabled = true;
            txtSL.Enabled = true;
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

            }
        }
        void ResetValue()
        {
            txtMaHH.Text = "";
            txtHang.Text = "";
            txtTenHang.Text = "";
            txtSLM.Text = "";
            txtGiaBan.Text = "";
            cbmBoNho.SelectedItem = null;
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            grbChiTietNhap.Enabled = false;
            txtSL.Enabled = false;
            btnNhap.Enabled = false;
            dgvNhapHang.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
        }

        private void btnThemHangMoi_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnNhap.Enabled = false;
            grbChiTietNhap.Enabled = true;
            string str = "HH" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            txtMaHH.Text = ft.SinhMaTuDong("HANGHOA", str, "MaHH");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbmBoNho.SelectedItem?.ToString()) || string.IsNullOrEmpty(txtSLM.Text))
            {
                MessageBox.Show("Bạn đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string bonho = cbmBoNho.SelectedItem.ToString();
                int sl = Convert.ToInt32(txtSLM.Text);
                db.DataChange("insert into hanghoa (MaHH, TenHH, GiaBan, Hang, Bo_nho, So_luong)values('" + txtMaHH.Text + "','" + txtTenHang.Text + "','" + txtGiaBan.Text + "','" + txtHang.Text + "','" + bonho + "'," + sl + ")");
                dgvNhapHang.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
            }
        }
    }
}
