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
    public partial class frmDonHang : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.CommonFunctions ft = new Classes.CommonFunctions();
        public frmDonHang()
        {
            InitializeComponent();
        }
        private void ResetValue()
        {
            DateTime dt = new DateTime(DateTime.Today.Year, DateTime.Today.Month,DateTime.Today.Day);
            txtTenKH.Text = "";
            txtDc.Text = "";
            txtSDT.Text = "";
            cboMaKH.Text = "";
            txtMaDH.Text = "";
            cboNV.Text = "";
            txtTenNV.Text = "";
            dgvHangHoa.DataSource = "";
            cboMaHH.Text = "";
            txtTenHH.Text = "";
            txtSLcon.Text = "";
            txtSLmua.Text = "";
            txtDGban.Text = "";
            txtThanhTien.Text = "";
            txtTongGia.Text = "";

            cboTimKiem.Text = "";
        }
        private void ResetSP()
        {
            cboMaHH.SelectedValue = "";
            txtTenHH.Text = "";
            txtSLcon.Text = "";
            txtSLmua.Text = "";
            txtDGban.Text = "";
            txtThanhTien.Text = "";
        }
        private bool check()
        {
            if(cboMaHH.Text =="")
            {
                errCheck.SetError(cboMaHH, "bạn không được để trống phần này");
                return false;
            }
            else
            {
                errCheck.Clear();
            }
            if (cboNV.Text == "")
            {
                errCheck.SetError(cboNV, "bạn không được để trống phần này");
                return false;
            }
            else
            {
                errCheck.Clear();
            }
            if (txtSLmua.Text == "")
            {
                errCheck.SetError(txtSLmua, "bạn không được để trống phần này");
                return false;
            }
            else
            {
                errCheck.Clear();
            }
            if (cboMaKH.Text == "")
            {
                errCheck.SetError(cboMaKH, "bạn không được để trống phần này");
                return false;
            }
            else
            {
                errCheck.Clear();
            }
            if (Convert.ToInt32(txtSLmua.Text) > Convert.ToInt32(txtSLcon.Text))
            {
                errCheck.SetError(txtSLmua, "Số lượng hàng còn lại không đủ");
                return false;
            }
            else
            {
                errCheck.Clear();
            }
            return true;
        }
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            ft.FillComBox(cboMaHH, dtbase.DataReader("Select * from HANGHOA"), "MaHH", "MaHH");
            ft.FillComBox(cboMaKH, dtbase.DataReader("Select * from KHACHHANG"), "MaKH", "MaKH");
            ft.FillComBox(cboNV, dtbase.DataReader("Select * from NHANVIEN"), "MaNV", "MaNV");
            ResetValue();
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            cboMaHH.Enabled = false;
            cboNV.Enabled = false;
            cboMaKH.Enabled = false;
            btnTao.Enabled = true;
            btnXoaSP.Enabled = false;
            button1.Enabled = false;
            dgvHangHoa.DataSource = dtbase.DataReader("Select * from fnViewHD('" + txtMaDH.Text + "')");

            dgvHangHoa.Columns[0].HeaderText = "Mã sản phẩm";
            dgvHangHoa.Columns[1].HeaderText = "Tên sản phẩm";
            dgvHangHoa.Columns[2].HeaderText = "Số lượng";
            dgvHangHoa.Columns[3].HeaderText = "Giá bán";
            dgvHangHoa.Columns[4].HeaderText = "Thành tiền";
        }

        private void cboMaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMaKH.SelectedValue != null)
                {

                    DataTable dtKhach = dtbase.DataReader("Select * from KHACHHANG where MaKH='" +
                        cboMaKH.SelectedValue.ToString() + "'");
                    if (dtKhach.Rows.Count > 0)
                    {
                        txtTenKH.Text = dtKhach.Rows[0]["TenKH"].ToString();
                        txtDc.Text = dtKhach.Rows[0]["DiaChi"].ToString();
                        txtSDT.Text = dtKhach.Rows[0]["SDT"].ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sai");
            }
        }

        private void cboMaHH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(cboMaHH.SelectedValue != null)
                {
                    DataTable dtHang = dtbase.DataReader("select * from HANGHOA where MaHH='" +
                        cboMaHH.SelectedValue.ToString() + "'");
                    if(dtHang.Rows.Count > 0)
                    {
                        txtTenHH.Text = dtHang.Rows[0]["TenHH"].ToString() + "'";
                        txtSLcon.Text = dtHang.Rows[0]["So_luong"].ToString();
                        txtDGban.Text = dtHang.Rows[0]["GiaBan"].ToString();
                    }
                }    
            }
            catch
            {

            }
        }

        private void cboNV_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNV.SelectedValue != null)
                {
                    DataTable dtNV = dtbase.DataReader("select * from NHANVIEN where MaNV='" +
                        cboNV.SelectedValue.ToString() + "'");
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

        private void txtSLmua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double DonGia, soLuong;
                soLuong = Convert.ToDouble(txtSLmua.Text);
                DonGia = Convert.ToDouble(txtDGban.Text);
                txtThanhTien.Text = (soLuong * DonGia).ToString();
            }
            catch
            {

            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (btnThemSP.Enabled == false) return;
            if(check() == false) return;
            DateTime ngayBan = Convert.ToDateTime(dtpNgay.Text.Trim());
            // check san pham duoc chon chua
            DataTable ctHD = dtbase.DataReader("Select * from CT_HOADON where MaHD='" + txtMaDH.Text + "' and MaHH ='"
                + cboMaHH.SelectedValue.ToString() + "'");
            if(ctHD.Rows.Count > 0)
            {
                MessageBox.Show("Bạn đã chọn sản phẩm này","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = $"exec ThemCT_HOADON '{txtMaDH.Text}', '{cboMaKH.SelectedValue.ToString()}', " +
                    $"'{cboNV.SelectedValue.ToString()}', '{string.Format("{0:yyyy/MM/dd}", ngayBan)}', " +
                    $"'{cboMaHH.SelectedValue.ToString()}','{Convert.ToInt16(txtSLmua.Text)}'";
                //MessageBox.Show(sql);
                dtbase.DataChange(sql);
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );
                ResetSP();
                dgvHangHoa.DataSource = dtbase.DataReader("Select * from fnViewHD('" + txtMaDH.Text + "')");
                int TongTien = 0;
                foreach (DataGridViewRow row in dgvHangHoa.Rows)
                {
                    if (row.Cells["Thành tiền"].Value != null)
                    {
                        TongTien += Convert.ToInt32((row.Cells["Thành tiền"].Value));
                    }

                }
                txtTongGia.Text = TongTien.ToString();
            }
            //MessageBox.Show("Van vao");
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnXoaSP.Enabled = true;
            btnXoaSP.Enabled = true;
            cboMaHH.Enabled = true;
            cboNV.Enabled = true;
            cboMaKH.Enabled = true;
            btnHuy.Enabled = true;
            btnIn.Enabled = true;
            DataTable dtDH = dtbase.DataReader("select * from HOADON");
            string MaBatDau = "HD";
            txtMaDH.Text = ft.SinhMa("HOADON", MaBatDau, "MaHD");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            cboMaHH.Enabled = false;
            cboNV.Enabled = false;
            cboMaKH.Enabled = false;
            btnTao.Enabled = true;
            btnXoaSP.Enabled = false;
            button1.Enabled = false;
            cboTimKiem.DataSource = null;
        }

        private void cboTimKiem_Click(object sender, EventArgs e)
        {
            //cboTimKiem.DataSource = null;
            //ft.FillComBox(cboTimKiem, dtbase.DataReader("Select * from HOADON"), "MaHD", "MaHD");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ResetSP();

            cboMaHH.Enabled = true;
            btnHuy.Enabled = true;
            btnIn.Enabled = true;
            if(cboTimKiem.Text != "")
            {
                DataTable dtHD = dtbase.DataReader("Select * from fnViewHD_KH_NV('" + cboTimKiem.SelectedValue.ToString() + "')");
                if (dtHD.Rows.Count > 0)
                {
                    txtMaDH.Text = dtHD.Rows[0]["MaHD"].ToString();
                    cboNV.Text = dtHD.Rows[0]["MaNV"].ToString();
                    cboMaKH.Text = dtHD.Rows[0]["MaKH"].ToString();
                    txtTongGia.Text = dtHD.Rows[0]["Tong_tien"].ToString();
                    dgvHangHoa.DataSource = dtbase.DataReader("Select * from fnViewHD('" + txtMaDH.Text + "')");
                }
                else
                {
                    DataTable dtHDTrong = dtbase.DataReader("Select * from HOADON where MaHD = '" + cboTimKiem.SelectedValue.ToString() + "'");

                    txtMaDH.Text = dtHDTrong.Rows[0]["MaHD"].ToString();
                    cboNV.Text = dtHDTrong.Rows[0]["MaNV"].ToString();
                    cboMaKH.Text = dtHDTrong.Rows[0]["MaKH"].ToString();
                    dgvHangHoa.DataSource = dtbase.DataReader("Select * from fnViewHD('" + txtMaDH.Text + "')");
                }
            }    
            
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvHangHoa.Columns[0].HeaderText = "Mã sản phẩm";
            //dgvHangHoa.Columns[1].HeaderText = "Tên sản phẩm";
            //dgvHangHoa.Columns[2].HeaderText = "Số lượng";
            //dgvHangHoa.Columns[3].HeaderText = "Giá bán";
            //dgvHangHoa.Columns[4].HeaderText = "Thành tiền";

        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button1.Enabled = true;
                btnThemSP.Enabled = true;
                btnXoaSP.Enabled = true;
                cboMaHH.Text = dgvHangHoa.CurrentRow.Cells[0].Value.ToString();
                txtSLmua.Text = dgvHangHoa.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sl = txtSLmua.Text;
            if (int.TryParse(sl, out int value) && sl != "")
            {
                string sql = "Update CT_HOADON set SL = '" + sl + "' where MaHD ='" + txtMaDH.Text + "' and MaHH ='" + cboMaHH.SelectedValue.ToString()
                    + "'";
                dtbase.DataChange(sql);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset 
                ResetSP();
                dgvHangHoa.DataSource = dtbase.DataReader("Select * from fnViewHD('" + txtMaDH.Text + "')");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
             DataTable ct_hd = dtbase.DataReader("select * from CT_HOADON where MaHD = '" + txtMaDH.Text + "'");
                if(ct_hd.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            if(txtTenHH.Text != "" && MessageBox.Show("Bạn có chắc muốn xóa sản phẩm " + txtTenHH.Text + " khỏi giỏ hàng?", "Thông báo" , MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
               
                
                string sql = $"Delete CT_HOADON where MaHD = '{txtMaDH.Text}' and MaHH = '{cboMaHH.SelectedValue.ToString()}'";
                dtbase.DataChange(sql);

                MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetSP();
                dgvHangHoa.DataSource = dtbase.DataReader("Select * from fnViewHD('" + txtMaDH.Text + "')");
                 
            }

        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaHH_TextUpdate(object sender, EventArgs e)
        {
            MessageBox.Show("textChange");

        }

        private void cboMaHH_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("TextChange");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa toàn bộ hóa đơn " + txtMaDH.Text + " khỏi giỏ hàng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataTable ct_hd = dtbase.DataReader("select * from CT_HOADON where MaHD = '" + txtMaDH.Text + "'");
                if(ct_hd.Rows.Count > 0)
                {
                    MessageBox.Show("Bạn cần xóa hết chi tiết hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                string sql = $"Delete HOADON where MaHD = '{txtMaDH.Text}'";
                dtbase.DataChange(sql);

                MessageBox.Show("Xóa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetSP();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Forms.frmPrintHD frm2 = new Forms.frmPrintHD(dtbase.DataReader("Select * from fnViewHD('" + txtMaDH.Text + "')"));
            frm2.ngay = Convert.ToDateTime(dtpNgay.Text.Trim()).ToString();
            frm2.maNV = cboNV.SelectedValue.ToString();
            frm2.tenNv = txtTenNV.Text;
            frm2.khachHang = txtTenKH.Text;
            frm2.diaChi = txtDc.Text;
            frm2.soHD = txtMaDH.Text;
            frm2.soDienThoai = txtSDT.Text;
            frm2.tongTien = txtTongGia.Text;
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cboMaHH.SelectedValue != null)
            {
                DataTable dienThoai = dtbase.DataReader("Select * from HANGHOA where MaHH = '" + cboMaHH.SelectedValue.ToString() + "'");

                string fileAnh = dienThoai.Rows[0]["Anh"].ToString();
                Forms.ChiTietSP_DH frm2 = new Forms.ChiTietSP_DH();
                
                frm2.fileAnh = fileAnh;
                frm2.maSp = dienThoai.Rows[0]["MaHH"].ToString();
                frm2.tenSp = dienThoai.Rows[0]["tenHH"].ToString(); frm2.ghiChu = dienThoai.Rows[0]["DacDiem"].ToString();
                frm2.giaBan = dienThoai.Rows[0]["GiaBan"].ToString(); frm2.BoNho = dienThoai.Rows[0]["Bo_nho"].ToString(); frm2.Hang = dienThoai.Rows[0]["HangSx"].ToString();
                frm2.ShowDialog();
            }
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.frmTimKiemHoaDon frmTk= new frmTimKiemHoaDon();
            frmTk.ShowDialog();
            if(frmTk.tableHoaDon != null)
            {
                cboTimKiem.DataSource = null;
                ft.FillComBox(cboTimKiem, frmTk.tableHoaDon, "MaHD", "MaHD");
            }
            
        }
    }
}
