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
    public partial class frmTimKiemHoaDon : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.CommonFunctions ft = new Classes.CommonFunctions();
        public DataTable tableHoaDon = null;
        public frmTimKiemHoaDon()
        {
            InitializeComponent();
        }

        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            ft.FillComBox(cboNhanVien, dtbase.DataReader("Select * from NHANVIEN"), "MaNV", "MaNV");
            txtTenNV.Text = "";
        }

        bool check()
        {
            if(txtMaKhachHang.Text == "" && cboNhanVien.Text=="" && txtSDT.Text == "")
            {
                MessageBox.Show("Bạn cần nhập một trong các thông tin trên");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (check() == false) return;
            string ngayBD = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(dtpNgayBD.Text.Trim()));
            string ngayKetThuc = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(dtpNgayKetThuc.Text.Trim()));
            string sql = $"select * from HOADON hd where hd.NgayLap between '{ngayBD}' and '{ngayKetThuc}'";
            if(txtMaKhachHang.Text != "")
            {
                sql += $" and hd.MaKH = '{txtMaKhachHang.Text}'";
            }
            if (txtSDT.Text != "")
            {
                sql += $" and hd.MaKH in (select kh.MaKH from KHACHHANG kh where kh.SDT = '{txtSDT.Text}')";
            }
            if (cboNhanVien.Text != "")
            {
                sql += $" and hd.MaNV = '{cboNhanVien.Text}'";
            }
            MessageBox.Show(sql);
            DataTable dt = dtbase.DataReader(sql);
            if (dt.Rows.Count > 0)
            {
                dgvHoaDon.DataSource = dt;
                dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dgvHoaDon.Columns[1].HeaderText = "Mã khách hàng";
                dgvHoaDon.Columns[2].HeaderText = "Nhân viên";
                dgvHoaDon.Columns[3].HeaderText = "Ngày lập";
                tableHoaDon = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả bạn cần tìm");
            }
        }

        private void cboNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNhanVien.SelectedValue != null)
                {
                    DataTable dtNV = dtbase.DataReader("select * from NHANVIEN where MaNV='" +
                        cboNhanVien.SelectedValue.ToString() + "'");
                    if (dtNV.Rows.Count > 0)
                    {
                        txtTenNV.Text = dtNV.Rows[0]["HoTen"].ToString() + "";
                    }
                }
            }
            catch
            {

            }
        }
    }
}
