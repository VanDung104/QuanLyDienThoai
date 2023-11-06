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
    public partial class frmChiTietSanPhamL : Form
    {
        public string tendt, bonho, giathanh, dacdiem, anh, hangsx, loai;
        public frmChiTietSanPhamL()
        {
            InitializeComponent();
        }

        private void frmChiTietSanPhamL_Load(object sender, EventArgs e)
        {
            txtBoNho.Text = bonho;
            txtTenHH.Text = txtTenHH1.Text = tendt;
            txtDacDiem.Text = dacdiem;
            txtGiaBan.Text = giathanh;
            txtLoai.Text = loai;
            txtHang.Text = hangsx;
            picbAnh.Image = Image.FromFile(anh);
        }
    }
}
