using QuanLyDienThoai.Classes;
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
    public partial class frmKhoHang : Form
    {
        DataBaseProcess db = new DataBaseProcess();
        public frmKhoHang()
        {
            InitializeComponent();
        }
        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            dgvSanPhamKho.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.frmNhapHang frmNhap = new Forms.frmNhapHang();
            frmNhap.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSanPhamKho.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
        }
    }
}
