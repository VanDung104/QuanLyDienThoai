using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyDienThoai.Forms
{
    public partial class FrmQuanLiNhanVien : Form
    {
        Classes.CommonFunctions functions = new Classes.CommonFunctions();
        Classes.DataBaseProcess data = new Classes.DataBaseProcess();
        Classes.CommonFunctions ft = new Classes.CommonFunctions();
        string fileAnh;
        bool them = false;
       

        public FrmQuanLiNhanVien()
        {
            InitializeComponent();
            DataTable dt = data.DataReader("select * from NHANVIEN");
            functions.FillComBox(cboSapXep , dt, "HoTen", "MaNV");
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
            functions.FillComBox(cboMaTK,dt  , "MaTK", "MaTK");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            grbTT.Enabled = false;
            LoadData();
            dtgDSNV.Columns[0].HeaderText = "Mã Nhân Viên";
            dtgDSNV.Columns[1].HeaderText = "Tên Nhân Viên";
            dtgDSNV.Columns[2].HeaderText = "Quê Quán";
            dtgDSNV.Columns[3].HeaderText = "Giới Tính";
            dtgDSNV.Columns[4].HeaderText = "SDT";
            dtgDSNV.Columns[5].HeaderText = "Ngày Sinh";
            dtgDSNV.Columns[6].HeaderText = "NgayLV";
            dtgDSNV.Columns[7].HeaderText = "HSL";
            dtgDSNV.Columns[8].HeaderText = "Ảnh";
            dtgDSNV.Columns[9].HeaderText = "MaTK";
            dtgDSNV.BackgroundColor = Color.LightBlue;
            ResetValue();
        }
        void LoadData()
        {
            string sqlSelect = "Select * from NHANVIEN";
            DataTable tblData = data.DataReader(sqlSelect);
            dtgDSNV.DataSource = tblData;
        }

        private void dtgDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgDSNV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dtgDSNV.CurrentRow.Cells[1].Value.ToString();
            txtQueQuan.Text = dtgDSNV.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinh.SelectedItem = dtgDSNV.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dtgDSNV.CurrentRow.Cells[4].Value.ToString();
            dtpNgaySinh.Value = (dtgDSNV.CurrentRow.Cells[5].Value != DBNull.Value) ? Convert.ToDateTime(dtgDSNV.CurrentRow.Cells[5].Value) : DateTime.Now;
            dtpNgayLV.Value = (dtgDSNV.CurrentRow.Cells[6].Value != DBNull.Value) ? Convert.ToDateTime(dtgDSNV.CurrentRow.Cells[6].Value) : DateTime.Now;
            txtHSL.Text = dtgDSNV.CurrentRow.Cells[7].Value.ToString();
            fileAnh = dtgDSNV.CurrentRow.Cells[8].Value.ToString();
            cboMaTK.SelectedValue = dtgDSNV.CurrentRow.Cells[9].Value.ToString();
            picAnh.Image = Image.FromFile("ImageUser\\" + dtgDSNV.CurrentRow.Cells[8].Value.ToString());
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
          

        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            dlgAnh.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif) |*.gif|All files(*.*)|*.*";
            dlgAnh.InitialDirectory = "E:\\Chong\\WebBanHoa\\Images\\AnhHoa";
            dlgAnh.FilterIndex = 3; // Quy định lọc mặc định là bộ lọc thứ 1
            dlgAnh.Title = "Chọn ảnh để hiển thị";
            if (dlgAnh.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgAnh.FileName);
                string[] str = dlgAnh.FileName.Split('\\');
                fileAnh = str[str.Length - 1].ToString();

            }
            //Lấy tên, đường dẫn ảnh khi người dùng chọn trong hộp hội thoại OpenDialog. 
            //Sau đó gán cho thuộc tính Image của PictureBox
            else
                MessageBox.Show("You clicked Cancel", "Open Dialog",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grbTT.Enabled = true;
            them = true;
            ResetValue();
            txtMaNV.Text = ft.SinhMa("NHANVIEN", "NV", "MaNV");
            txtMaTK.Text = ft.SinhMa("TAIKHOAN", "TK", "MaTK");
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        void ResetValue()
        {
            DateTime dt = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtQueQuan.Text = "";
            cboGioiTinh.SelectedItem = null;
            txtSDT.Text = "";
            dtpNgaySinh.Text = dt.ToShortDateString();
            dtpNgayLV.Text = dt.ToShortDateString();
            txtHSL.Text = "";
            picAnh.Image = null;
            fileAnh = "";
            cboMaTK.SelectedValue = "";
            txtMaNV.Focus();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false; 
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Có hay không", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    data.DataChange("delete NHANVIEN where MaNV= " + txtMaNV.Text + "'");
                    LoadData();
                    ResetValue();
                }
                catch 
                {
                    MessageBox.Show("Bạn không được xóa vì nó liên quan đến các hóa đơn.");
                }
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mặt hàng để sửa");

            }
            else
            {
                them = false;
                btnLuu.Enabled = true;
                grbTT.Enabled = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'","MaNV" ,"HoTen", "*" + txtTimKiem.Text + "*");
            (dtgDSNV.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                

                DateTime dateNgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
                DateTime dateNgayLV = Convert.ToDateTime(dtpNgayLV.Text);
                DataTable dt = data.DataReader("Select * from NHANVIEN where MaNV='" + txtMaNV.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string strInsert = "Insert into NHANVIEN values('" + txtMaNV.Text + "',N'" + txtHoTen.Text +
                        "',N'" +txtQueQuan.Text+ "' ,'" + cboGioiTinh.SelectedItem.ToString() + "', '"
                        +txtSDT.Text + "' ,'" + string.Format("{0:MM/dd/yyyy}", dateNgaySinh) + "','" + string.Format("{0:MM/dd/yyyy}", dateNgayLV) + "', '"
                        +txtHSL.Text+ "' ,'" + fileAnh + "','" + cboMaTK.SelectedValue+ "')";
                    data.DataChange(strInsert);
                    dtgDSNV.DataSource = data.DataReader("Select * From NHANVIEN");
                }
                else
                {
                    MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác");
                    txtMaNV.Focus();
                }
                them = false;
            }
            else
            {
                DateTime dateNgaySinh = Convert.ToDateTime(dtpNgaySinh.Text);
                DateTime dateNgayLV = Convert.ToDateTime(dtpNgayLV.Text);
                string sqlUpdate = "update NHANVIEN set HoTen = N'" + txtHoTen.Text +
                    "',QueQuan = N'" + txtQueQuan.Text + "' ,[Gioi Tinh] =  N'" +
                    cboGioiTinh.SelectedItem.ToString() + "', SDT = '" + txtSDT.Text +
                    "' ,NgaySinh = '" + string.Format("{0:yyyy/MM/dd}", dateNgaySinh) +
                    "', NgayLV = '" + string.Format("{0:yyyy/MM/dd}", dateNgayLV) + "', HSL = '" +
                    txtHSL.Text + "' ,Anh= '" + fileAnh + "',MaTK = '" + cboMaTK.SelectedValue.ToString() + "'" +
                    " where MaNV = '" + txtMaNV.Text + "' ";
                MessageBox.Show(sqlUpdate);
                data.DataChange(sqlUpdate);
                dtgDSNV.DataSource = data.DataReader("Select * from NHANVIEN");

            }
        }

        private void cboMaTK_Click(object sender, EventArgs e)
        {
            DataTable dt = data.DataReader("select * from NHANVIEN");
            functions.FillComBox(cboMaTK, dt, "MaTK", "MaTK");
        }

        private void btnCapPhat_Click(object sender, EventArgs e)
        {
            frmCapTaiKhoan frm2 = new frmCapTaiKhoan();
            frm2.maTK = txtMaTK.Text;
            frm2.ShowDialog();
        }
    }
}
