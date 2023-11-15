namespace QuanLyDienThoai.Forms
{
    partial class frmKhachHang
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
			this.panChiTietChung = new System.Windows.Forms.Panel();
			this.grbChiTietChung = new System.Windows.Forms.GroupBox();
			this.dtbNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.kjhgf = new System.Windows.Forms.Label();
			this.panData = new System.Windows.Forms.Panel();
			this.dgvdata = new System.Windows.Forms.DataGridView();
			this.panChucNang = new System.Windows.Forms.Panel();
			this.grbChucNang = new System.Windows.Forms.GroupBox();
			this.dlgAnh = new System.Windows.Forms.OpenFileDialog();
			this.btnIn = new System.Windows.Forms.Button();
			this.BtnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnThemAnh = new System.Windows.Forms.Button();
			this.picAnh = new System.Windows.Forms.PictureBox();
			this.panChiTietChung.SuspendLayout();
			this.grbChiTietChung.SuspendLayout();
			this.panData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.panChucNang.SuspendLayout();
			this.grbChucNang.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
			this.SuspendLayout();
			// 
			// panChiTietChung
			// 
			this.panChiTietChung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panChiTietChung.Controls.Add(this.grbChiTietChung);
			this.panChiTietChung.Location = new System.Drawing.Point(4, 1);
			this.panChiTietChung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panChiTietChung.Name = "panChiTietChung";
			this.panChiTietChung.Size = new System.Drawing.Size(625, 370);
			this.panChiTietChung.TabIndex = 0;
			// 
			// grbChiTietChung
			// 
			this.grbChiTietChung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grbChiTietChung.BackColor = System.Drawing.Color.PaleTurquoise;
			this.grbChiTietChung.Controls.Add(this.btnThemAnh);
			this.grbChiTietChung.Controls.Add(this.picAnh);
			this.grbChiTietChung.Controls.Add(this.dtbNgaySinh);
			this.grbChiTietChung.Controls.Add(this.label5);
			this.grbChiTietChung.Controls.Add(this.txtSDT);
			this.grbChiTietChung.Controls.Add(this.label4);
			this.grbChiTietChung.Controls.Add(this.txtDiaChi);
			this.grbChiTietChung.Controls.Add(this.label3);
			this.grbChiTietChung.Controls.Add(this.txtTenKH);
			this.grbChiTietChung.Controls.Add(this.label2);
			this.grbChiTietChung.Controls.Add(this.txtMaKH);
			this.grbChiTietChung.Controls.Add(this.kjhgf);
			this.grbChiTietChung.Location = new System.Drawing.Point(12, 12);
			this.grbChiTietChung.Name = "grbChiTietChung";
			this.grbChiTietChung.Size = new System.Drawing.Size(584, 357);
			this.grbChiTietChung.TabIndex = 0;
			this.grbChiTietChung.TabStop = false;
			this.grbChiTietChung.Text = "Thông Tin Chi Tiết";
			// 
			// dtbNgaySinh
			// 
			this.dtbNgaySinh.Location = new System.Drawing.Point(129, 234);
			this.dtbNgaySinh.Name = "dtbNgaySinh";
			this.dtbNgaySinh.Size = new System.Drawing.Size(198, 25);
			this.dtbNgaySinh.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ngày Sinh:";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(129, 182);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(198, 25);
			this.txtSDT.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số Điện Thoại:";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(129, 129);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(198, 25);
			this.txtDiaChi.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Địa chỉ:";
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(129, 78);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(198, 25);
			this.txtTenKH.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên Khách Hàng:";
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(129, 28);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.ReadOnly = true;
			this.txtMaKH.Size = new System.Drawing.Size(198, 25);
			this.txtMaKH.TabIndex = 1;
			// 
			// kjhgf
			// 
			this.kjhgf.AutoSize = true;
			this.kjhgf.Location = new System.Drawing.Point(12, 30);
			this.kjhgf.Name = "kjhgf";
			this.kjhgf.Size = new System.Drawing.Size(110, 17);
			this.kjhgf.TabIndex = 0;
			this.kjhgf.Text = "Mã Khách Hàng:";
			// 
			// panData
			// 
			this.panData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panData.Controls.Add(this.dgvdata);
			this.panData.Location = new System.Drawing.Point(3, 378);
			this.panData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panData.Name = "panData";
			this.panData.Size = new System.Drawing.Size(626, 256);
			this.panData.TabIndex = 1;
			// 
			// dgvdata
			// 
			this.dgvdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvdata.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Location = new System.Drawing.Point(0, 12);
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.RowHeadersWidth = 51;
			this.dgvdata.RowTemplate.Height = 24;
			this.dgvdata.Size = new System.Drawing.Size(623, 242);
			this.dgvdata.TabIndex = 0;
			this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
			// 
			// panChucNang
			// 
			this.panChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panChucNang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panChucNang.Controls.Add(this.grbChucNang);
			this.panChucNang.Location = new System.Drawing.Point(634, 1);
			this.panChucNang.Name = "panChucNang";
			this.panChucNang.Size = new System.Drawing.Size(185, 633);
			this.panChucNang.TabIndex = 2;
			// 
			// grbChucNang
			// 
			this.grbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grbChucNang.Controls.Add(this.btnIn);
			this.grbChucNang.Controls.Add(this.BtnLuu);
			this.grbChucNang.Controls.Add(this.btnXoa);
			this.grbChucNang.Controls.Add(this.btnSua);
			this.grbChucNang.Controls.Add(this.btnThem);
			this.grbChucNang.Location = new System.Drawing.Point(11, 15);
			this.grbChucNang.Name = "grbChucNang";
			this.grbChucNang.Size = new System.Drawing.Size(168, 617);
			this.grbChucNang.TabIndex = 0;
			this.grbChucNang.TabStop = false;
			this.grbChucNang.Text = "Chức Năng";
			// 
			// dlgAnh
			// 
			this.dlgAnh.FileName = "openFileDialog1";
			// 
			// btnIn
			// 
			this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIn.Image = global::QuanLyDienThoai.Properties.Resources.icons8_print;
			this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIn.Location = new System.Drawing.Point(15, 344);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(139, 58);
			this.btnIn.TabIndex = 0;
			this.btnIn.Text = "In";
			this.btnIn.UseVisualStyleBackColor = true;
			this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
			// 
			// BtnLuu
			// 
			this.BtnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnLuu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLuu.Image = global::QuanLyDienThoai.Properties.Resources.icons8_save__1_;
			this.BtnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BtnLuu.Location = new System.Drawing.Point(15, 264);
			this.BtnLuu.Name = "BtnLuu";
			this.BtnLuu.Size = new System.Drawing.Size(139, 58);
			this.BtnLuu.TabIndex = 0;
			this.BtnLuu.Text = "   Lưu";
			this.BtnLuu.UseVisualStyleBackColor = true;
			this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Image = global::QuanLyDienThoai.Properties.Resources.icons8_delete;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(15, 187);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(139, 58);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Image = global::QuanLyDienThoai.Properties.Resources.icons8_edit_profile_48;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(15, 113);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(139, 58);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = global::QuanLyDienThoai.Properties.Resources.icons8_add_user_male_skin_type_7_48;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(15, 37);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(139, 58);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "    Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnThemAnh
			// 
			this.btnThemAnh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemAnh.Image = global::QuanLyDienThoai.Properties.Resources.printer;
			this.btnThemAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemAnh.Location = new System.Drawing.Point(375, 298);
			this.btnThemAnh.Name = "btnThemAnh";
			this.btnThemAnh.Size = new System.Drawing.Size(139, 53);
			this.btnThemAnh.TabIndex = 0;
			this.btnThemAnh.Text = "          Chọn Ảnh";
			this.btnThemAnh.UseVisualStyleBackColor = true;
			this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
			// 
			// picAnh
			// 
			this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picAnh.Location = new System.Drawing.Point(352, 30);
			this.picAnh.Name = "picAnh";
			this.picAnh.Size = new System.Drawing.Size(187, 255);
			this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAnh.TabIndex = 3;
			this.picAnh.TabStop = false;
			// 
			// frmKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(821, 643);
			this.Controls.Add(this.panChucNang);
			this.Controls.Add(this.panData);
			this.Controls.Add(this.panChiTietChung);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmKhachHang";
			this.Text = "Khách Hàng";
			this.Load += new System.EventHandler(this.frmKhachHang_Load);
			this.panChiTietChung.ResumeLayout(false);
			this.grbChiTietChung.ResumeLayout(false);
			this.grbChiTietChung.PerformLayout();
			this.panData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.panChucNang.ResumeLayout(false);
			this.grbChucNang.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panChiTietChung;
		private System.Windows.Forms.GroupBox grbChiTietChung;
		private System.Windows.Forms.Panel panData;
		private System.Windows.Forms.DataGridView dgvdata;
		private System.Windows.Forms.Panel panChucNang;
		private System.Windows.Forms.GroupBox grbChucNang;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTenKH;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.Label kjhgf;
		private System.Windows.Forms.Button BtnLuu;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnThemAnh;
		private System.Windows.Forms.PictureBox picAnh;
		private System.Windows.Forms.DateTimePicker dtbNgaySinh;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.OpenFileDialog dlgAnh;
	}
}