using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai.Forms
{
    public partial class ChiTietSP_DH : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.CommonFunctions ft = new Classes.CommonFunctions();

        public string fileAnh, maSp, tenSp, ghiChu, giaBan, BoNho, Hang;
        public ChiTietSP_DH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietSP_DH_Load(object sender, EventArgs e)
        {
            lblMaSp.Text = maSp;
            lblTenSp.Text = tenSp;
            lblGhiChu.Text = ghiChu;
            lblGiaBan.Text = giaBan;
            lblBoNho.Text = BoNho; 
            lblHang.Text = Hang;
            try
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\ImagePhone\\" + fileAnh);
            }
            catch
            {
                picAnh.Image = null;
            }
        }
    }
}
