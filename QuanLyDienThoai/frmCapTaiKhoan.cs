using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienThoai
{
    public partial class frmCapTaiKhoan : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.CommonFunctions ft = new Classes.CommonFunctions();
        public string maTK = "";
        public frmCapTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmCapTaiKhoan_Load(object sender, EventArgs e)
        {
            lblMaTk.Text = maTK;
            if(maTK != "")
            {
                DataTable checkMaTk = dtbase.DataReader($"Select * from TAIKHOAN where MaTK = '{lblMaTk.Text}'");
                if (checkMaTk.Rows.Count > 0)
                {
                    if (MessageBox.Show("Mã tài khoản đã tồn tại. Bạn muốn cập nhật mật khẩu không?", "Cập nhật", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtTenDangNhap.Text = checkMaTk.Rows[0]["TenDN"].ToString();
                        txtMatKhau.Text = checkMaTk.Rows[0]["Matkhau"].ToString();
                        cboQuyen.SelectedItem = checkMaTk.Rows[0]["Quyen"].ToString();
                        txtTenDangNhap.ReadOnly = true;
                        btnTao.Enabled = false;
                        btnCapNhat.Enabled = true;
                    }
                }    
                

            }
            else
            {
                btnCapNhat.Enabled = false;
                btnTao.Enabled = true;
            }
            

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text != "" && txtTenDangNhap.Text != "" && lblMaTk.Text != "" && cboQuyen.Text != "")
            {
                
                DataTable checkTenDN = dtbase.DataReader($"Select * from TAIKHOAN where TenDN = '{txtTenDangNhap.Text}'");
                if(checkTenDN.Rows.Count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                }
                else
                {
                    string sql = $"insert into TAIKHOAN values ('{lblMaTk.Text}','{txtTenDangNhap.Text}', '{txtMatKhau.Text}','{cboQuyen.Text}')";
                    dtbase.DataChange(sql);
                    MessageBox.Show("Cấp phát tài khoản thành công");
                    this.Close();
                }    
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text!="" && cboQuyen.Text !="")
            {
                string sql = $"update TAIKHOAN set Matkhau = '{txtMatKhau.Text}', Quyen = '{cboQuyen.Text}' where MaTK = '{lblMaTk.Text}'";
                dtbase.DataChange(sql);
                MessageBox.Show("Cập nhật tài khoản thành công");
                this.Close();
            }
        }
    }
}
