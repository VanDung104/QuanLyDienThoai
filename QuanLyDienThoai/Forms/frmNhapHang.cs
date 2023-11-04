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
    public partial class frmNhapHang : Form
    {
        DataBaseProcess db = new DataBaseProcess();
        Functions ft = new Functions();
        public frmNhapHang()
        {
            InitializeComponent();
        }
        string maHH;
        int slcon;
        private void dgvNhapHang_Click(object sender, EventArgs e)
        {
            maHH = dgvNhapHang.CurrentRow.Cells[0].Value.ToString();
            string temp = dgvNhapHang.CurrentRow.Cells[4].Value.ToString();
            slcon = Convert.ToInt32(temp);
            btnThemHangMoi.Enabled = false;
            grbChiTietNhap.Enabled = false;
            btnNhap.Enabled = true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtSL.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng cần nhập!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Focus();
            }
            else
            {
                int slmoi = Convert.ToInt32(txtSL.Text);
                db.DataChange("update HANGHOA set So_Luong= "+(slcon+ slmoi)+"where MaHH = '"+maHH+"'");
                dgvNhapHang.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
                btnThemHangMoi.Enabled = true;
                MessageBox.Show("Bạn đã nhập hàng thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            btnNhap.Enabled = false;
            dgvNhapHang.DataSource = db.DataReader("select HANGHOA.MaHH,HANGHOA.TenHH, HANGHOA.Hang,HANGHOA.GiaBan,HANGHOA.So_Luong from HANGHOA");
        }
    }
}
