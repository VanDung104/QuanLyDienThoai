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
            OpenChildForm(new Forms.frmThongKe(), sender);
        }
    }
}
