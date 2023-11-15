using QuanLyDienThoai.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai.Forms
{
	public partial class frmInKhachHangPDF : Form
	{
		string date;
		public string ten, maHK, sdt, diachi, ngaysinh, fileAnh;
		DataBaseProcess db = new DataBaseProcess();
		public frmInKhachHangPDF()
		{
			InitializeComponent();
			date = DateTime.Now.ToString("dd/MM/yyyy");
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			Rectangle pagearea = e.PageBounds;
			e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2)-(this.panelPrint.Width / 2), this.panelPrint.Location.Y);
		}

		private void picIn_Click(object sender, EventArgs e)
		{
			Print(this.panelPrint);
		}

		private void picIn_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(picIn,"In KHách Hàng");
		}

		private void frmInKhachHangPDF_Load(object sender, EventArgs e)
		{
			string tmp;
			DataTable ctHD = db.DataReader("select *from HOADON where MaKH = '" + maHK + "'");
			if (ctHD.Rows.Count == 0)
			{
				tmp = "Khách hàng chưa mua sản phẩm nào!";
			}
			else
			{
				tmp = string.Format("{0:N0} VNĐ", db.Thongke(maHK));
			}
			lblNgay.Text = date;
			lblNgaySinh.Text = ngaysinh;
			lblMaKH.Text = maHK;
			lblSDT.Text = sdt;
			lblDiaChi.Text = diachi;
			picAnh.Image = Image.FromFile("ImagePhone\\" + fileAnh);
			lblTen.Text = ten;
			lblTien.Text = tmp;
		}
		private void Print(Panel pnl)
		{
			PrinterSettings ps = new PrinterSettings();
			panelPrint = pnl;
			getprintarea(pnl);
			printPreviewDialog1.Document = printDocument1;
			printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
			printPreviewDialog1.ShowDialog();
		}
		private Bitmap memoryimg;
		private void getprintarea(Panel pnl)
		{
			memoryimg = new Bitmap(pnl.Width, pnl.Height);
			pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
		}
	}
}
