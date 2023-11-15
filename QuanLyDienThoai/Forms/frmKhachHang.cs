using QuanLyDienThoai.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai.Forms
{
	public partial class frmKhachHang : Form
	{
		DataBaseProcess db = new DataBaseProcess();
		string strAnh;
		Functions ft = new Functions();
		int kt = 0;
		public frmKhachHang()
		{
			InitializeComponent();
		}

		private void btnThemAnh_Click(object sender, EventArgs e)
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
		public void ResetValue()
		{
			DateTime dt = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
			txtMaKH.Text = null;
			txtDiaChi.Text = null;
			txtSDT.Text = null;
			txtTenKH.Text = null;
			dtbNgaySinh.Text = dt.ToShortDateString();
			picAnh.Image = null;

		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			ResetValue();
			btnSua.Enabled = false;
			grbChiTietChung.Enabled = true;
			string str = "KH" + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
			txtMaKH.Text = ft.SinhMaTuDong("KHACHHANG", str, "MaKH");
			btnXoa.Enabled = false;
			kt = 1;
		}

		private void frmKhachHang_Load(object sender, EventArgs e)
		{
			dgvdata.DataSource = db.DataReader("select *from KHACHHANG");
			grbChiTietChung.Enabled = false;
			dgvdata.Columns[0].HeaderText = "Mã Khách Hàng";
			dgvdata.Columns[1].HeaderText = "Tên Khách Hàng";
			dgvdata.Columns[2].HeaderText = "Địa Chỉ";
			dgvdata.Columns[3].HeaderText = "Số Điện Thoại";
			dgvdata.Columns[4].HeaderText = "Ngày Sinh";
			dgvdata.Columns[5].HeaderText = "File Ảnh";
			btnXoa.Enabled = false;
			btnSua.Enabled = false;
			btnIn.Enabled = false;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Khách Hàng này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if ((result == DialogResult.No))
			{
				return;
			}
			else
			{
				DataTable ctHD = db.DataReader("select *from HOADON where MaKH = '" + txtMaKH.Text + "'");
				if (ctHD.Rows.Count != 0)
				{
					MessageBox.Show("Khách Hàng này không thể xóa được!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					db.DataChange("delete KHACHHANG where maKH = '" + txtMaKH.Text + "'");
					dgvdata.DataSource = db.DataReader("select *from KHACHHANG");
				}
			}
			btnXoa.Enabled = false;
		}

		private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(dgvdata.CurrentRow.Cells[0].Value.ToString()))
				{
					MessageBox.Show("Vui Lòng chọn vào hàng có dữ liệu!");
				}
				else
				{
					ResetValue();
					btnXoa.Enabled = true;
					btnSua.Enabled = true;
					txtMaKH.Text = dgvdata.CurrentRow.Cells[0].Value.ToString();
					txtTenKH.Text = dgvdata.CurrentRow.Cells[1].Value.ToString();
					txtDiaChi.Text = dgvdata.CurrentRow.Cells[2].Value.ToString();
					txtSDT.Text = dgvdata.CurrentRow.Cells[3].Value.ToString();
					dtbNgaySinh.Text = Convert.ToDateTime(dgvdata.CurrentRow.Cells[4].Value.ToString().ToString()).ToShortDateString();
					picAnh.Image = Image.FromFile("ImagePhone\\" + dgvdata.CurrentRow.Cells[5].Value.ToString());
					strAnh = dgvdata.CurrentRow.Cells[5].Value.ToString();
					btnSua.Enabled = true;
					btnXoa.Enabled = true;
					btnIn.Enabled = true;
					grbChiTietChung.Enabled = false;
				}
			}
			catch { }
		}

		private void BtnLuu_Click(object sender, EventArgs e)
		{
			if (kt == 1)
			{
				if (string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtSDT.Text))
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtTenKH.Focus();
				}
				else
				{
					DateTime dtNgaySinh = Convert.ToDateTime(dtbNgaySinh.Text.Trim());
					db.DataChange("insert into KHACHHANG values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + string.Format("{0:yyyy/MM/dd}", dtNgaySinh) + "','" + strAnh + "')");
					kt = 0;
					dgvdata.DataSource = db.DataReader("select *from KHACHHANG");
					ResetValue();
					grbChiTietChung.Enabled = false;
				}
			}
			else
			{
				if(kt == 2)
				{
					DateTime dtNgaySinh = Convert.ToDateTime(dtbNgaySinh.Text.Trim());
					db.DataChange("update KHACHHANG set TenKH = N'"+txtTenKH.Text+"',DiaChi=N'"+txtDiaChi.Text+"',SDT='"+txtSDT.Text+"',NgaySinh='"+ string.Format("{0:yyyy/MM/dd}", dtNgaySinh)+"', Anh='"+ strAnh+ "' where maKH = '"+txtMaKH.Text+"'");
					kt = 0;
					dgvdata.DataSource = db.DataReader("select *from KHACHHANG");
					ResetValue();
					grbChiTietChung.Enabled = false;
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			kt = 2;
			grbChiTietChung.Enabled = true;
		}

		private void btnIn_Click(object sender, EventArgs e)
		{
			frmInKhachHangPDF frmIn = new frmInKhachHangPDF();
			frmIn.maHK =txtMaKH.Text = dgvdata.CurrentRow.Cells[0].Value.ToString();
			frmIn.ten = dgvdata.CurrentRow.Cells[1].Value.ToString();
			frmIn.diachi = dgvdata.CurrentRow.Cells[2].Value.ToString();
			frmIn.sdt = dgvdata.CurrentRow.Cells[3].Value.ToString();
			frmIn.ngaysinh = Convert.ToDateTime(dgvdata.CurrentRow.Cells[4].Value.ToString().ToString()).ToShortDateString();
			frmIn.fileAnh = dgvdata.CurrentRow.Cells[5].Value.ToString();
			frmIn.ShowDialog();
			btnIn.Enabled = false;
		}
	}
}
