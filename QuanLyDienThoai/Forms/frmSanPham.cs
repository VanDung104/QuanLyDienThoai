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
    public partial class frmSanPham : Form
    {
        DataBaseProcess db = new DataBaseProcess();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = db.DataReader("select TenHH, Bo_nho, Hang, GiaBan, Loai, Anh, DacDiem from HANGHOA");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLocTheoTen.Text))
            {
                MessageBox.Show("Nhập tên hàng để thực hiện tìm kiếm!", "");
            }
            else
            {
                dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where TenHH like '%" + txtLocTheoTen.Text + "%'");
            }
        }
        private void btnLocGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbmLocGia.SelectedItem?.ToString()))
                {
                    MessageBox.Show("vui lòng chọn khoảng giá lọc", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string ktloc = cbmLocGia.SelectedItem.ToString();
                    switch (ktloc)
                    {
                        case "0<=2.500.000":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where GiaBan between 0 and 2500000");
                            break;
                        case "2.500.000<=5.000.000":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where GiaBan between 2500000 and 5000000");
                            break;
                        case "5.000.000<=10.000.000":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where GiaBan between 5000000 and 10000000");
                            break;
                        case ">10.000.000":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where GiaBan > 10000000");
                            break;
                    }
                    cbmLocGia.SelectedItem = null;
                }
            }
            catch
            {
            }
        }
        private void btnlochang_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbmLocHang.SelectedItem?.ToString()))
                {
                    MessageBox.Show("vui lòng chọn hãng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string ktloc = cbmLocHang.SelectedItem.ToString();
                    switch (ktloc)
                    {
                        case "Apple":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where Hang='Apple'");
                            break;
                        case "Oppo":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where Hang='Oppo'");
                            break;
                        case "Xiaomi":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where Hang='Xiaomi'");
                            break;
                        case "Sam Sung":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where Hang='Sam Sung'");
                            break;
                        case "Sony":
                            dgvSanPham.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where Hang='Sony'");
                            break;
                    }
                    cbmLocHang.SelectedItem = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi "+ex.Message.ToString(), "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                frmChiTietSanPhamL frmCT = new frmChiTietSanPhamL();
                frmCT.tendt = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                frmCT.giathanh = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                frmCT.hangsx = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                frmCT.bonho = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                frmCT.anh = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                frmCT.loai = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                frmCT.dacdiem = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
                frmCT.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi " + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
