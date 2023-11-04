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
            this.lsbBoNho = new System.Windows.Forms.ListBox();
            this.txtSLM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHang = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.grbChiTietNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Location = new System.Drawing.Point(12, 206);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.Size = new System.Drawing.Size(776, 287);
            this.dgvNhapHang.TabIndex = 0;
            this.dgvNhapHang.Click += new System.EventHandler(this.dgvNhapHang_Click);
            // 
            // grbChiTietNhap
            // 
            this.grbChiTietNhap.Controls.Add(this.lsbBoNho);
            this.grbChiTietNhap.Controls.Add(this.txtSLM);
            this.grbChiTietNhap.Controls.Add(this.label6);
            this.grbChiTietNhap.Controls.Add(this.label5);
            this.grbChiTietNhap.Controls.Add(this.txtHang);
            this.grbChiTietNhap.Controls.Add(this.label4);
            this.grbChiTietNhap.Controls.Add(this.txtGiaBan);
            this.grbChiTietNhap.Controls.Add(this.label3);
            this.grbChiTietNhap.Controls.Add(this.txtTenHang);
            this.grbChiTietNhap.Controls.Add(this.label2);
            this.grbChiTietNhap.Controls.Add(this.txtMaHH);
            this.grbChiTietNhap.Controls.Add(this.label1);
            this.grbChiTietNhap.Location = new System.Drawing.Point(12, 12);
            this.grbChiTietNhap.Name = "grbChiTietNhap";
            this.grbChiTietNhap.Size = new System.Drawing.Size(776, 188);
            this.grbChiTietNhap.TabIndex = 1;
            this.grbChiTietNhap.TabStop = false;
            this.grbChiTietNhap.Text = "Chi tiết nhập";
            // 
            // lsbBoNho
            // 
            this.lsbBoNho.FormattingEnabled = true;
            this.lsbBoNho.ItemHeight = 16;
            this.lsbBoNho.Items.AddRange(new object[] {
            "64GB",
            "128GB",
            "256GB",
            "512GB",
            "1TB"});
            this.lsbBoNho.Location = new System.Drawing.Point(432, 78);
            this.lsbBoNho.Name = "lsbBoNho";
            this.lsbBoNho.Size = new System.Drawing.Size(147, 20);
            this.lsbBoNho.TabIndex = 2;
            // 
            // txtSLM
            // 
            this.txtSLM.Location = new System.Drawing.Point(432, 117);
            this.txtSLM.Name = "txtSLM";
            this.txtSLM.Size = new System.Drawing.Size(147, 22);
            this.txtSLM.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bộ Nhớ:";
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(432, 36);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(147, 22);
            this.txtHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hãng:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(110, 117);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(147, 22);
            this.txtGiaBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá Bán:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(110, 78);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(147, 22);
            this.txtTenHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hàng:";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(110, 36);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(147, 22);
            this.txtMaHH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng:";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(348, 520);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(122, 43);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThemHangMoi
            // 
            this.btnThemHangMoi.Location = new System.Drawing.Point(549, 520);
            this.btnThemHangMoi.Name = "btnThemHangMoi";
            this.btnThemHangMoi.Size = new System.Drawing.Size(122, 43);
            this.btnThemHangMoi.TabIndex = 0;
            this.btnThemHangMoi.Text = "Thêm Hàng Mới";
            this.btnThemHangMoi.UseVisualStyleBackColor = true;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(123, 533);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(147, 22);
            this.txtSL.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng nhập:";
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.btnThemHangMoi);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.grbChiTietNhap);
            this.Controls.Add(this.dgvNhapHang);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label7);
            this.Name = "frmNhapHang";
            this.Text = "frmNhapHang";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.grbChiTietNhap.ResumeLayout(false);
            this.grbChiTietNhap.PerformLayout();
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
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.ListBox lsbBoNho;
        private System.Windows.Forms.Button btnThemHangMoi;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label7;
    }
}