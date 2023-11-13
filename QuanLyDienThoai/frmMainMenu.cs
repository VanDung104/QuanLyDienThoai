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
    public partial class frmMainMenu : Form
    {
        public event EventHandler Logout;
        public bool isExit = true;
        public static string userName = "", quyen = "";
        private Form activeForm;
        public frmMainMenu()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            
        }
        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmTrangchu(), sender);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSanPham(), sender);
        }

        private void btnNhacc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmNhaCungCap(), sender);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmDonHang(), sender);
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmKhoHang(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Test(), sender);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            lblChucVu.Text = quyen;
            lblUsername.Text = userName;
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ThongKeDoanhThu(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
    }
}
