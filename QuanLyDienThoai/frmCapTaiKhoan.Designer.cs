namespace QuanLyDienThoai
{
    partial class frmCapTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnQuyen = new System.Windows.Forms.Label();
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaTk = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.Location = new System.Drawing.Point(12, 94);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(105, 18);
            this.lblDN.TabIndex = 0;
            this.lblDN.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(126, 94);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(241, 24);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(126, 162);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(241, 24);
            this.txtMatKhau.TabIndex = 2;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(15, 308);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(114, 42);
            this.btnTao.TabIndex = 3;
            this.btnTao.Text = "Tạo tài khoản";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnQuyen
            // 
            this.btnQuyen.AutoSize = true;
            this.btnQuyen.Location = new System.Drawing.Point(12, 212);
            this.btnQuyen.Name = "btnQuyen";
            this.btnQuyen.Size = new System.Drawing.Size(51, 18);
            this.btnQuyen.TabIndex = 4;
            this.btnQuyen.Text = "Quyền";
            // 
            // cboQuyen
            // 
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cboQuyen.Location = new System.Drawing.Point(126, 212);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(121, 26);
            this.cboQuyen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã tài khoản";
            // 
            // lblMaTk
            // 
            this.lblMaTk.AutoSize = true;
            this.lblMaTk.Location = new System.Drawing.Point(126, 61);
            this.lblMaTk.Name = "lblMaTk";
            this.lblMaTk.Size = new System.Drawing.Size(46, 18);
            this.lblMaTk.TabIndex = 7;
            this.lblMaTk.Text = "label3";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(170, 308);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(114, 42);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmCapTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 462);
            this.Controls.Add(this.lblMaTk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.btnQuyen);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCapTaiKhoan";
            this.Text = "Cấp tài khoản";
            this.Load += new System.EventHandler(this.frmCapTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label btnQuyen;
        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaTk;
        private System.Windows.Forms.Button btnCapNhat;
    }
}