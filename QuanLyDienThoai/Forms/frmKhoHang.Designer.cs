namespace QuanLyDienThoai.Forms
{
    partial class frmKhoHang
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgvSanPhamKho = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnXoaSanPham = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnIn = new System.Windows.Forms.Button();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.btnNhapHang = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamKho)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sản phẩm có trong kho hàng";
			// 
			// dgvSanPhamKho
			// 
			this.dgvSanPhamKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSanPhamKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSanPhamKho.BackgroundColor = System.Drawing.Color.LightSlateGray;
			this.dgvSanPhamKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPhamKho.Location = new System.Drawing.Point(13, 118);
			this.dgvSanPhamKho.Name = "dgvSanPhamKho";
			this.dgvSanPhamKho.RowHeadersWidth = 51;
			this.dgvSanPhamKho.RowTemplate.Height = 24;
			this.dgvSanPhamKho.Size = new System.Drawing.Size(674, 274);
			this.dgvSanPhamKho.TabIndex = 1;
			this.dgvSanPhamKho.Click += new System.EventHandler(this.dgvSanPhamKho_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nhập tên hàng:";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTimKiem.Location = new System.Drawing.Point(375, 20);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(66, 22);
			this.btnTimKiem.TabIndex = 1;
			this.btnTimKiem.Text = "Tìm Kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTimKiem.Location = new System.Drawing.Point(136, 21);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(211, 22);
			this.txtTimKiem.TabIndex = 2;
			this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
			this.txtTimKiem.TextChanged += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.btnTimKiem);
			this.panel1.Controls.Add(this.txtTimKiem);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(13, 11);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(674, 63);
			this.panel1.TabIndex = 3;
			// 
			// btnXoaSanPham
			// 
			this.btnXoaSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnXoaSanPham.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoaSanPham.Image = global::QuanLyDienThoai.Properties.Resources.icons8_delete;
			this.btnXoaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoaSanPham.Location = new System.Drawing.Point(520, 23);
			this.btnXoaSanPham.Name = "btnXoaSanPham";
			this.btnXoaSanPham.Size = new System.Drawing.Size(131, 57);
			this.btnXoaSanPham.TabIndex = 0;
			this.btnXoaSanPham.Text = "      Xóa";
			this.btnXoaSanPham.UseVisualStyleBackColor = true;
			this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.panel2.Controls.Add(this.btnXoaSanPham);
			this.panel2.Controls.Add(this.btnIn);
			this.panel2.Controls.Add(this.btnLamMoi);
			this.panel2.Controls.Add(this.btnNhapHang);
			this.panel2.Location = new System.Drawing.Point(16, 398);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(674, 91);
			this.panel2.TabIndex = 4;
			// 
			// btnIn
			// 
			this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnIn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIn.Image = global::QuanLyDienThoai.Properties.Resources.icons8_export_excel_48;
			this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIn.Location = new System.Drawing.Point(357, 23);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(131, 57);
			this.btnIn.TabIndex = 0;
			this.btnIn.Text = "         Xuất Excel";
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Image = global::QuanLyDienThoai.Properties.Resources.icons8_refresh;
			this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLamMoi.Location = new System.Drawing.Point(34, 23);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(131, 57);
			this.btnLamMoi.TabIndex = 0;
			this.btnLamMoi.Text = "       Làm mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnNhapHang
			// 
			this.btnNhapHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNhapHang.Image = global::QuanLyDienThoai.Properties.Resources.icons8_import_48;
			this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhapHang.Location = new System.Drawing.Point(194, 23);
			this.btnNhapHang.Name = "btnNhapHang";
			this.btnNhapHang.Size = new System.Drawing.Size(131, 57);
			this.btnNhapHang.TabIndex = 0;
			this.btnNhapHang.Text = "          Nhập Hàng";
			this.btnNhapHang.UseVisualStyleBackColor = true;
			this.btnNhapHang.Click += new System.EventHandler(this.button2_Click);
			// 
			// frmKhoHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(700, 490);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvSanPhamKho);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmKhoHang";
			this.Text = "Kho Hàng";
			this.Load += new System.EventHandler(this.frmKhoHang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamKho)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPhamKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Panel panel2;
    }
}