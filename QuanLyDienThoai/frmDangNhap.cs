using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{

    public partial class frmDangNhap : Form
    {
        private bool isClosedByUser = false;
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }


        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from TAIKHOAN";
            if (txtTenDangNhap.Text.Trim() != "")
            {
                sql += " where TenDN = '" + txtTenDangNhap.Text + "'";
            }
            if (txtMatKhau.Text.Trim() != "")
            {
                sql += "and MatKhau = '" + txtMatKhau.Text + "'";
            }
            DataTable tai_khoan = dtbase.DataReader(sql);
            if (tai_khoan.Rows.Count > 0 && tai_khoan.Rows[0]["MatKhau"].ToString() == txtMatKhau.Text)
            {
                frmMainMenu.userName = tai_khoan.Rows[0]["TenDN"].ToString();
                frmMainMenu.quyen = tai_khoan.Rows[0]["Quyen"].ToString();
                frmMainMenu f = new frmMainMenu();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else

            {
                MessageBox.Show("Tai khan khong dung", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Text = "";
                txtMatKhau.Focus();

            }
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as frmMainMenu).isExit = false;
            (sender as frmMainMenu).Close();
            this.Show();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
