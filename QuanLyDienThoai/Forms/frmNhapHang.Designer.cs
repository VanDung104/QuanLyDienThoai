namespace QuanLyDienThoai.Forms
{
    partial class frmNhapHang
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
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.grbChiTietNhap = new System.Windows.Forms.GroupBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.picbAnh = new System.Windows.Forms.PictureBox();
            this.cbmBoNho = new System.Windows.Forms.ComboBox();
            this.txtSLM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThemHangMoi = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbmHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.grbChiTietNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Location = new System.Drawing.Point(12, 217);
            this.dgvNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.Size = new System.Drawing.Size(776, 293);
            this.dgvNhapHang.TabIndex = 0;
            this.dgvNhapHang.Click += new System.EventHandler(this.dgvNhapHang_Click);
            // 
            // grbChiTietNhap
            // 
            this.grbChiTietNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTietNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbChiTietNhap.Controls.Add(this.cbmHang);
            this.grbChiTietNhap.Controls.Add(this.btnAnh);
            this.grbChiTietNhap.Controls.Add(this.picbAnh);
            this.grbChiTietNhap.Controls.Add(this.cbmBoNho);
            this.grbChiTietNhap.Controls.Add(this.txtSLM);
            this.grbChiTietNhap.Controls.Add(this.label6);
            this.grbChiTietNhap.Controls.Add(this.label5);
            this.grbChiTietNhap.Controls.Add(this.label4);
            this.grbChiTietNhap.Controls.Add(this.txtGiaBan);
            this.grbChiTietNhap.Controls.Add(this.label3);
            this.grbChiTietNhap.Controls.Add(this.txtTenHang);
            this.grbChiTietNhap.Controls.Add(this.label2);
            this.grbChiTietNhap.Controls.Add(this.txtMaHH);
            this.grbChiTietNhap.Controls.Add(this.label1);
            this.grbChiTietNhap.Location = new System.Drawing.Point(12, 13);
            this.grbChiTietNhap.Margin = new System.Windows.Forms.Padding(4);
            this.grbChiTietNhap.Name = "grbChiTietNhap";
            this.grbChiTietNhap.Padding = new System.Windows.Forms.Padding(4);
            this.grbChiTietNhap.Size = new System.Drawing.Size(776, 173);
            this.grbChiTietNhap.TabIndex = 1;
            this.grbChiTietNhap.TabStop = false;
            this.grbChiTietNhap.Text = "Chi tiết nhập";
            // 
            // btnAnh
            // 
            this.btnAnh.Location = new System.Drawing.Point(574, 133);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(153, 33);
            this.btnAnh.TabIndex = 4;
            this.btnAnh.Text = "Chọn Ảnh";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // picbAnh
            // 
            this.picbAnh.BackColor = System.Drawing.Color.White;
            this.picbAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbAnh.Location = new System.Drawing.Point(574, 39);
            this.picbAnh.Name = "picbAnh";
            this.picbAnh.Size = new System.Drawing.Size(153, 88);
            this.picbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbAnh.TabIndex = 3;
            this.picbAnh.TabStop = false;
            // 
            // cbmBoNho
            // 
            this.cbmBoNho.FormattingEnabled = true;
            this.cbmBoNho.Items.AddRange(new object[] {
            "64GB",
            "128GB",
            "256GB",
            "512GB",
            "1TB"});
            this.cbmBoNho.Location = new System.Drawing.Point(376, 78);
            this.cbmBoNho.Margin = new System.Windows.Forms.Padding(4);
            this.cbmBoNho.Name = "cbmBoNho";
            this.cbmBoNho.Size = new System.Drawing.Size(147, 25);
            this.cbmBoNho.TabIndex = 2;
            // 
            // txtSLM
            // 
            this.txtSLM.Location = new System.Drawing.Point(376, 125);
            this.txtSLM.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLM.Name = "txtSLM";
            this.txtSLM.Size = new System.Drawing.Size(147, 25);
            this.txtSLM.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bộ Nhớ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hãng:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(109, 124);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(147, 25);
            this.txtGiaBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Bán:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(109, 82);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(147, 25);
            this.txtTenHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hàng:";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(109, 38);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(147, 25);
            this.txtMaHH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng:";
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNhap.Location = new System.Drawing.Point(291, 34);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(98, 46);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThemHangMoi
            // 
            this.btnThemHangMoi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThemHangMoi.Location = new System.Drawing.Point(415, 34);
            this.btnThemHangMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHangMoi.Name = "btnThemHangMoi";
            this.btnThemHangMoi.Size = new System.Drawing.Size(98, 46);
            this.btnThemHangMoi.TabIndex = 0;
            this.btnThemHangMoi.Text = "Thêm Hàng Mới";
            this.btnThemHangMoi.UseVisualStyleBackColor = true;
            this.btnThemHangMoi.Click += new System.EventHandler(this.btnThemHangMoi_Click);
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSL.Location = new System.Drawing.Point(117, 47);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(147, 25);
            this.txtSL.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng nhập:";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Location = new System.Drawing.Point(662, 34);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 46);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnThemHangMoi);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.btnNhap);
            this.panel1.Location = new System.Drawing.Point(12, 518);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 101);
            this.panel1.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(540, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 46);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa sản phẩm";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chọn sản phẩm trong bảng cần nhập thêm";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbmHang
            // 
            this.cbmHang.FormattingEnabled = true;
            this.cbmHang.Items.AddRange(new object[] {
            "Apple",
            "Oppo",
            "Xiaomi",
            "Sam Sung",
            "Sony"});
            this.cbmHang.Location = new System.Drawing.Point(376, 34);
            this.cbmHang.Name = "cbmHang";
            this.cbmHang.Size = new System.Drawing.Size(147, 25);
            this.cbmHang.TabIndex = 5;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbChiTietNhap);
            this.Controls.Add(this.dgvNhapHang);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Sản Phẩm";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.grbChiTietNhap.ResumeLayout(false);
            this.grbChiTietNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAnh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.GroupBox grbChiTietNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Button btnThemHangMoi;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbmBoNho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picbAnh;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbmHang;
    }
}