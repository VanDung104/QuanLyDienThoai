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
    public partial class frmPrintHD : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.CommonFunctions ft = new Classes.CommonFunctions();
        public string ngay;
        public string soHD, khachHang, diaChi, soDienThoai, maNV, tenNv, tongTien;
        private DataTable Luu;
        private void Print(Panel pn1)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pn1;
            getprintarea(pn1);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Bitmap memorying;
        private void getprintarea(Panel pn1)
        {

            memorying = new Bitmap(pn1.Width, pn1.Height);
            pn1.DrawToBitmap(memorying, new Rectangle(0, 0, pn1.Width, pn1.Height));
        }
        public frmPrintHD(DataTable dt)
        {
            Luu = dt;
            InitializeComponent();
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmPrintHD_Load(object sender, EventArgs e)
        {
            lblDc.Text = diaChi;
            lblKH.Text = khachHang;
            lblMaHD.Text = soHD;
            lblMaNv.Text = maNV;
            lblNgay.Text = ngay;
            lblSdt.Text = soDienThoai;
            lblTongTien.Text = tongTien;
            lblTenNv.Text = tenNv;
            string text = "";
            for (int i = 0; i < Luu.Rows.Count; i++)
            {
                txtChiTiet.Text += $"{Luu.Rows[i]["Tên sản phẩm"].ToString()} ({Luu.Rows[i]["GiaBan"].ToString()} VND) x {Luu.Rows[i]["Số lượng"].ToString()} (cái) : {Luu.Rows[i]["Thành tiền"].ToString()} VND" +
                    Environment.NewLine;
            }
            
        }
    }
}
