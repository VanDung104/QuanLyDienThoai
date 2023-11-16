namespace QuanLyDienThoai.Forms
{
    partial class frmSanPham
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
			this.dgvSanPham = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLamMoi = new System.Windows.Forms.Button();
			this.cbmLocHang = new System.Windows.Forms.ComboBox();
			this.cbmLocGia = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLocTheoTen = new System.Windows.Forms.TextBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSanPham
			// 
			this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSanPham.BackgroundColor = System.Drawing.Color.Coral;
			this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSanPham.Location = new System.Drawing.Point(2, 108);
			this.dgvSanPham.Name = "dgvSanPham";
			this.dgvSanPham.RowHeadersWidth = 51;
			this.dgvSanPham.RowTemplate.Height = 24;
			this.dgvSanPham.Size = new System.Drawing.Size(695, 410);
			this.dgvSanPham.TabIndex = 0;
			this.dgvSanPham.Click += new System.EventHandler(this.dgvSanPham_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.SandyBrown;
			this.panel1.Controls.Add(this.btnLamMoi);
			this.panel1.Controls.Add(this.cbmLocHang);
			this.panel1.Controls.Add(this.cbmLocGia);
			this.panel1.Controls.Add(this.btnTimKiem);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtLocTheoTen);
			this.panel1.Location = new System.Drawing.Point(2, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(694, 108);
			this.panel1.TabIndex = 1;
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLamMoi.Location = new System.Drawing.Point(489, 65);
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(75, 25);
			this.btnLamMoi.TabIndex = 4;
			this.btnLamMoi.Text = "Làm Mới";
			this.btnLamMoi.UseVisualStyleBackColor = true;
			this.btnLamMoi.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbmLocHang
			// 
			this.cbmLocHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbmLocHang.FormattingEnabled = true;
			this.cbmLocHang.Items.AddRange(new object[] {
            "Apple",
            "Oppo",
            "Xiaomi",
            "Sam Sung",
            "Sony"});
			this.cbmLocHang.Location = new System.Drawing.Point(319, 65);
			this.cbmLocHang.Name = "cbmLocHang";
			this.cbmLocHang.Size = new System.Drawing.Size(137, 25);
			this.cbmLocHang.TabIndex = 3;
			this.cbmLocHang.SelectedValueChanged += new System.EventHandler(this.cbmLocGia_SelectedValueChanged);
			// 
			// cbmLocGia
			// 
			this.cbmLocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbmLocGia.FormattingEnabled = true;
			this.cbmLocGia.Items.AddRange(new object[] {
            "0<=2.500.000",
            "2.500.000<=5.000.000",
            "5.000.000<=10.000.000",
            ">10.000.000"});
			this.cbmLocGia.Location = new System.Drawing.Point(93, 65);
			this.cbmLocGia.Name = "cbmLocGia";
			this.cbmLocGia.Size = new System.Drawing.Size(137, 25);
			this.cbmLocGia.TabIndex = 3;
			this.cbmLocGia.SelectedValueChanged += new System.EventHandler(this.cbmLocGia_SelectedValueChanged);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(247, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Hãng:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Giá:";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên sản phẩm: ";
			// 
			// txtLocTheoTen
			// 
			this.txtLocTheoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtLocTheoTen.Location = new System.Drawing.Point(134, 12);
			this.txtLocTheoTen.Name = "txtLocTheoTen";
			this.txtLocTheoTen.Size = new System.Drawing.Size(187, 25);
			this.txtLocTheoTen.TabIndex = 0;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnTimKiem.BackColor = System.Drawing.Color.White;
			this.btnTimKiem.Image = global::QuanLyDienThoai.Properties.Resources.icons8_search__1_;
			this.btnTimKiem.Location = new System.Drawing.Point(339, 6);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(48, 44);
			this.btnTimKiem.TabIndex = 2;
			this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.UseVisualStyleBackColor = false;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// frmSanPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(699, 520);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvSanPham);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmSanPham";
			this.Text = "Danh sách sản phẩm";
			this.Load += new System.EventHandler(this.frmSanPham_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocTheoTen;
        private System.Windows.Forms.ComboBox cbmLocGia;
        private System.Windows.Forms.ComboBox cbmLocHang;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLamMoi;
	}
}