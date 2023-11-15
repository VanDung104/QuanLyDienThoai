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
			dgvSanPham.Columns[0].HeaderText = "Mã hàng";
			dgvSanPham.Columns[1].HeaderText = "Bộ nhớ";
			dgvSanPham.Columns[2].HeaderText = "Hãng";
			dgvSanPham.Columns[3].HeaderText = "Giá";
			dgvSanPham.Columns[4].HeaderText = "Loại";
			dgvSanPham.Columns[5].HeaderText = "File Ảnh";
			dgvSanPham.Columns[6].HeaderText = "Đặc Điểm";

		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtLocTheoTen.Text))
			{
				MessageBox.Show("Nhập tên hàng để thực hiện tìm kiếm!", "");
			}
			else
			{
				dgvSanPham.DataSource = db.DataReader("select TenHH, Bo_nho, Hang, GiaBan, Loai, Anh, DacDiem from HANGHOA where TenHH like '%" + txtLocTheoTen.Text + "%'");
			}
		}

		private void dgvSanPham_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(dgvSanPham.CurrentRow.Cells[0].Value.ToString()))
				{
					MessageBox.Show("Vui Lòng chọn vào sản phẩm!");
				}
				else
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
			}
			catch { }

		}
		string locgia, lochang;

		private void button1_Click(object sender, EventArgs e)
		{
			cbmLocGia.SelectedItem = null;
			cbmLocHang.SelectedItem = null;
			dgvSanPham.DataSource = db.DataReader("select TenHH, Bo_nho, Hang, GiaBan, Loai, Anh, DacDiem from HANGHOA");
		}

		private void cbmLocGia_SelectedValueChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(cbmLocGia.SelectedItem?.ToString()))
			{
				locgia = "";
			}
			else
			{
				string ktlocgia = cbmLocGia.SelectedItem.ToString();
				switch (ktlocgia)
				{
					case "0<=2.500.000":
						locgia = " GiaBan between 0 and 2500000";
						break;
					case "2.500.000<=5.000.000":
						locgia = " GiaBan between 2500000 and 5000000";
						break;
					case "5.000.000<=10.000.000":
						locgia = " GiaBan between 5000000 and 10000000";
						break;
					case ">10.000.000":
						locgia = " GiaBan > 10000000";
						break;
				}
			}

			if (string.IsNullOrEmpty(cbmLocHang.SelectedItem?.ToString()))
			{
				lochang = "";
			}
			else
			{
				string ktlochang = cbmLocHang.SelectedItem.ToString();
				switch (ktlochang)
				{
					case "Apple":
						lochang = " Hang='Apple'";
						break;
					case "Oppo":
						lochang = "Hang ='Oppo'";
						break;
					case "Xiaomi":
						lochang = " Hang ='Xiaomi'";
						break;
					case "Sam Sung":
						lochang = " Hang ='Sam Sung'";
						break;
					case "Sony":
						lochang = " Hang ='Sony'";
						break;
				}
			}
			int kt1 = 0, kt2 = 0;
			if (string.IsNullOrEmpty(cbmLocGia.SelectedItem?.ToString()))
			{
				kt1 = 0;
			}
			else
			{
				kt1 = 1;
			}
			if (string.IsNullOrEmpty(cbmLocHang.SelectedItem?.ToString()))
			{
				kt2 = 0;
			}
			else
			{
				kt2 = 1;
			}
			if (kt1 == 1 && kt2 == 0)
			{
				dgvSanPham.DataSource = db.DataReader("select TenHH, Bo_nho, Hang, GiaBan, Loai, Anh, DacDiem from HANGHOA where " + locgia);
			}
			if (kt2 == 1 && kt1 == 0)
			{
				dgvSanPham.DataSource = db.DataReader("select TenHH, Bo_nho, Hang, GiaBan, Loai, Anh, DacDiem from HANGHOA where " + lochang);
			}
			if (kt1 == 1 && kt2 == 1)
			{
				dgvSanPham.DataSource = db.DataReader("select TenHH, Bo_nho, Hang, GiaBan, Loai, Anh, DacDiem from HANGHOA where " + locgia + " and " + lochang);
			}
		}
	}
}
