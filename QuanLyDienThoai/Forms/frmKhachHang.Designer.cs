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
			this.btnThemAnh = new System.Windows.Forms.Button();
			this.picAnh = new System.Windows.Forms.PictureBox();
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
			this.btnThongKe = new System.Windows.Forms.Button();
			this.btnIn = new System.Windows.Forms.Button();
			this.BtnLuu = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.dlgAnh = new System.Windows.Forms.OpenFileDialog();
			this.panChiTietChung.SuspendLayout();
			this.grbChiTietChung.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
			this.panData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
			this.panChucNang.SuspendLayout();
			this.grbChucNang.SuspendLayout();
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
			this.panChiTietChung.Size = new System.Drawing.Size(703, 413);
			this.panChiTietChung.TabIndex = 0;
			// 
			// grbChiTietChung
			// 
			this.grbChiTietChung.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
			this.grbChiTietChung.Location = new System.Drawing.Point(13, 13);
			this.grbChiTietChung.Name = "grbChiTietChung";
			this.grbChiTietChung.Size = new System.Drawing.Size(657, 399);
			this.grbChiTietChung.TabIndex = 0;
			this.grbChiTietChung.TabStop = false;
			this.grbChiTietChung.Text = "Thông Tin Chi Tiết";
			// 
			// btnThemAnh
			// 
			this.btnThemAnh.Location = new System.Drawing.Point(422, 333);
			this.btnThemAnh.Name = "btnThemAnh";
			this.btnThemAnh.Size = new System.Drawing.Size(156, 45);
			this.btnThemAnh.TabIndex = 0;
			this.btnThemAnh.Text = "Chọn Ảnh";
			this.btnThemAnh.UseVisualStyleBackColor = true;
			this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
			// 
			// picAnh
			// 
			this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.picAnh.Location = new System.Drawing.Point(396, 34);
			this.picAnh.Name = "picAnh";
			this.picAnh.Size = new System.Drawing.Size(210, 284);
			this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAnh.TabIndex = 3;
			this.picAnh.TabStop = false;
			// 
			// dtbNgaySinh
			// 
			this.dtbNgaySinh.Location = new System.Drawing.Point(145, 261);
			this.dtbNgaySinh.Name = "dtbNgaySinh";
			this.dtbNgaySinh.Size = new System.Drawing.Size(222, 27);
			this.dtbNgaySinh.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 267);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ngày Sinh:";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(145, 203);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(222, 27);
			this.txtSDT.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số Điện Thoại:";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(145, 144);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(222, 27);
			this.txtDiaChi.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Địa chỉ:";
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(145, 87);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(222, 27);
			this.txtTenKH.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên Khách Hàng:";
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(145, 31);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.ReadOnly = true;
			this.txtMaKH.Size = new System.Drawing.Size(222, 27);
			this.txtMaKH.TabIndex = 1;
			// 
			// kjhgf
			// 
			this.kjhgf.AutoSize = true;
			this.kjhgf.Location = new System.Drawing.Point(14, 34);
			this.kjhgf.Name = "kjhgf";
			this.kjhgf.Size = new System.Drawing.Size(122, 19);
			this.kjhgf.TabIndex = 0;
			this.kjhgf.Text = "Mã Khách Hàng:";
			// 
			// panData
			// 
			this.panData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panData.Controls.Add(this.dgvdata);
			this.panData.Location = new System.Drawing.Point(3, 422);
			this.panData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panData.Name = "panData";
			this.panData.Size = new System.Drawing.Size(704, 286);
			this.panData.TabIndex = 1;
			// 
			// dgvdata
			// 
			this.dgvdata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdata.Location = new System.Drawing.Point(0, 13);
			this.dgvdata.Name = "dgvdata";
			this.dgvdata.RowHeadersWidth = 51;
			this.dgvdata.RowTemplate.Height = 24;
			this.dgvdata.Size = new System.Drawing.Size(701, 270);
			this.dgvdata.TabIndex = 0;
			this.dgvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellClick);
			// 
			// panChucNang
			// 
			this.panChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panChucNang.Controls.Add(this.grbChucNang);
			this.panChucNang.Location = new System.Drawing.Point(713, 1);
			this.panChucNang.Name = "panChucNang";
			this.panChucNang.Size = new System.Drawing.Size(208, 707);
			this.panChucNang.TabIndex = 2;
			// 
			// grbChucNang
			// 
			this.grbChucNang.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.grbChucNang.Controls.Add(this.btnThongKe);
			this.grbChucNang.Controls.Add(this.btnIn);
			this.grbChucNang.Controls.Add(this.BtnLuu);
			this.grbChucNang.Controls.Add(this.btnXoa);
			this.grbChucNang.Controls.Add(this.btnSua);
			this.grbChucNang.Controls.Add(this.btnThem);
			this.grbChucNang.Location = new System.Drawing.Point(12, 17);
			this.grbChucNang.Name = "grbChucNang";
			this.grbChucNang.Size = new System.Drawing.Size(189, 690);
			this.grbChucNang.TabIndex = 0;
			this.grbChucNang.TabStop = false;
			this.grbChucNang.Text = "Chức Năng";
			// 
			// btnThongKe
			// 
			this.btnThongKe.Location = new System.Drawing.Point(17, 483);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new System.Drawing.Size(156, 65);
			this.btnThongKe.TabIndex = 0;
			this.btnThongKe.Text = "Thống kê";
			this.btnThongKe.UseVisualStyleBackColor = true;
			// 
			// btnIn
			// 
			this.btnIn.Location = new System.Drawing.Point(17, 385);
			this.btnIn.Name = "btnIn";
			this.btnIn.Size = new System.Drawing.Size(156, 65);
			this.btnIn.TabIndex = 0;
			this.btnIn.Text = "In";
			this.btnIn.UseVisualStyleBackColor = true;
			// 
			// BtnLuu
			// 
			this.BtnLuu.Location = new System.Drawing.Point(17, 295);
			this.BtnLuu.Name = "BtnLuu";
			this.BtnLuu.Size = new System.Drawing.Size(156, 65);
			this.BtnLuu.TabIndex = 0;
			this.BtnLuu.Text = "Lưu";
			this.BtnLuu.UseVisualStyleBackColor = true;
			this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(17, 209);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(156, 65);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(17, 126);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(156, 65);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(17, 41);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(156, 65);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dlgAnh
			// 
			this.dlgAnh.FileName = "openFileDialog1";
			// 
			// frmKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 719);
			this.Controls.Add(this.panChucNang);
			this.Controls.Add(this.panData);
			this.Controls.Add(this.panChiTietChung);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmKhachHang";
			this.Text = "Khách Hàng";
			this.Load += new System.EventHandler(this.frmKhachHang_Load);
			this.panChiTietChung.ResumeLayout(false);
			this.grbChiTietChung.ResumeLayout(false);
			this.grbChiTietChung.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
			this.panData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
			this.panChucNang.ResumeLayout(false);
			this.grbChucNang.ResumeLayout(false);
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
		private System.Windows.Forms.Button btnThongKe;
		private System.Windows.Forms.Button btnIn;
		private System.Windows.Forms.OpenFileDialog dlgAnh;
	}
}