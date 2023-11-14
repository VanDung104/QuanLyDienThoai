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
using Excel = Microsoft.Office.Interop.Excel;

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
            btnXoaSanPham.Enabled = false;
            dgvSanPhamKho.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
			dgvSanPhamKho.Columns[0].HeaderText = "Mã hàng";
			dgvSanPhamKho.Columns[1].HeaderText = "Tên hàng";
			dgvSanPhamKho.Columns[2].HeaderText = "Hãng";
			dgvSanPhamKho.Columns[3].HeaderText = "Giá";
			dgvSanPhamKho.Columns[4].HeaderText = "Số Lượng";
		}

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.frmNhapHang frmNhap = new Forms.frmNhapHang();
            frmNhap.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnNhapHang.Enabled = true;
            btnIn.Enabled = true;
            btnXoaSanPham.Enabled = false;
            dgvSanPhamKho.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                MessageBox.Show("Nhập tên hàng để thực hiện tìm kiếm!", "");
            }
            else
            {
                dgvSanPhamKho.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA where TenHH like '%" + txtTimKiem.Text + "%'");
            }
            btnIn.Enabled = true;
            btnNhapHang.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1];
            //in ten cty hàng a1
            tenTruong.Font.Size = 13;
            tenTruong.Font.Color = Color.Blue;
            tenTruong.Value = "CỦA HÀNG ĐIỆN THOẠI SỐ 1 VIỆT NAM";

            //in dc
            exSheet.Range["A2"].Font.Size = 13;
            exSheet.Range["A2"].Font.Color = Color.Blue;
            exSheet.Range["A2"].Value = "So3 Cầu Giấy Hà Nội";
            exSheet.Range["A3"].Font.Size = 13;
            exSheet.Range["A3"].Font.Color = Color.Black;
            exSheet.Range["A3"].Value = "holine: 0356276789";
            //in hoa đơn bán
            exSheet.Range["D4"].Font.Size = 20;
            exSheet.Range["D4"].Font.Color = Color.Red;
            exSheet.Range["D4"].Font.Bold = true;
            exSheet.Range["D4"].Value = "DANH SÁCH SẢN PHẨM TRONG KHO";

            //in bảng hóa đơn
            exSheet.Range["A6:F6"].Font.Size = 13;
            exSheet.Range["A6:E6"].Font.Bold = true;
            exSheet.Range["A6"].Value = "STT";
            exSheet.Range["B6"].Value = "Mã Hàng";
            exSheet.Range["C6"].Value = "Tên Sản Phẩm";
            exSheet.Range["D6"].Value = "Hãng";
            exSheet.Range["E6"].Value = "Giá Bán";
            exSheet.Range["F6"].Value = "Số Lượng";

            //in data
            int dong = 7;
            for (int i = 0; i < dgvSanPhamKho.Rows.Count - 1; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvSanPhamKho.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvSanPhamKho.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvSanPhamKho.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvSanPhamKho.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvSanPhamKho.Rows[i].Cells[4].Value.ToString();
            }
            exSheet.Name = "Hàng còn trong kho";
            exBook.Activate();

            //luu file
            SaveFileDialog saveHang = new SaveFileDialog();
            if (saveHang.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(saveHang.FileName.ToLower());
            }
            exApp.Quit();
        }
        string maHH;
        private void dgvSanPhamKho_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoaSanPham.Enabled = true;
                btnNhapHang.Enabled = false;
                btnTimKiem.Enabled = false;
                btnIn.Enabled = false;
                maHH = dgvSanPhamKho.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ctHD = db.DataReader("select *from CT_HOADON where MaHH = '" + maHH + "'");
                if (ctHD.Rows.Count != 0)
                {
                    MessageBox.Show("Sản phẩm này không thể xóa được!", "Thông Báo");
                }
                else
                {
                    db.DataChange("delete HANGHOA where MaHH = '" + maHH + "'");
                    dgvSanPhamKho.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
                }
                btnNhapHang.Enabled = true;
                btnTimKiem.Enabled=true; 
                btnIn.Enabled = true;
            }
            catch
            {
                // Xử lý lỗi và hiển thị thông báo lỗi nếu có
                MessageBox.Show("Sản phẩm này không thể xóa được!", "Thông Báo");
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
            btnXoaSanPham.Enabled = false;
        }
    }
}
