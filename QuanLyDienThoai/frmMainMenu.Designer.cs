namespace QuanLyDienThoai
{
    partial class frmMainMenu
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.btnThongKe = new System.Windows.Forms.Button();
			this.btnKhoHang = new System.Windows.Forms.Button();
			this.btnDonHang = new System.Windows.Forms.Button();
			this.btnNhacc = new System.Windows.Forms.Button();
			this.btnSanPham = new System.Windows.Forms.Button();
			this.btnTrangchu = new System.Windows.Forms.Button();
			this.panelMenu.SuspendLayout();
			this.panelTitleBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panelMenu.Controls.Add(this.btnThongKe);
			this.panelMenu.Controls.Add(this.btnKhoHang);
			this.panelMenu.Controls.Add(this.btnDonHang);
			this.panelMenu.Controls.Add(this.btnNhacc);
			this.panelMenu.Controls.Add(this.btnSanPham);
			this.panelMenu.Controls.Add(this.btnTrangchu);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(200, 684);
			this.panelMenu.TabIndex = 0;
			// 
			// panelLogo
			// 
			this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(200, 56);
			this.panelLogo.TabIndex = 0;
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
			this.panelTitleBar.Controls.Add(this.lblTitle);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(909, 56);
			this.panelTitleBar.TabIndex = 1;
			this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblTitle.Location = new System.Drawing.Point(360, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(81, 29);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Home";
			// 
			// panelDesktop
			// 
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(200, 56);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(909, 628);
			this.panelDesktop.TabIndex = 2;
			// 
			// btnThongKe
			// 
			this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnThongKe.FlatAppearance.BorderSize = 0;
			this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongKe.ForeColor = System.Drawing.Color.White;
			this.btnThongKe.Image = global::QuanLyDienThoai.Properties.Resources.icons8_graphic_48;
			this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThongKe.Location = new System.Drawing.Point(0, 376);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new System.Drawing.Size(200, 64);
			this.btnThongKe.TabIndex = 6;
			this.btnThongKe.Text = "        Thống kê";
			this.btnThongKe.UseVisualStyleBackColor = true;
			this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
			// 
			// btnKhoHang
			// 
			this.btnKhoHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnKhoHang.FlatAppearance.BorderSize = 0;
			this.btnKhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnKhoHang.ForeColor = System.Drawing.Color.White;
			this.btnKhoHang.Image = global::QuanLyDienThoai.Properties.Resources.icons8_warehouse_481;
			this.btnKhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnKhoHang.Location = new System.Drawing.Point(0, 312);
			this.btnKhoHang.Name = "btnKhoHang";
			this.btnKhoHang.Size = new System.Drawing.Size(200, 64);
			this.btnKhoHang.TabIndex = 5;
			this.btnKhoHang.Text = "       Kho hàng";
			this.btnKhoHang.UseVisualStyleBackColor = true;
			this.btnKhoHang.Click += new System.EventHandler(this.btnKhoHang_Click);
			// 
			// btnDonHang
			// 
			this.btnDonHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDonHang.FlatAppearance.BorderSize = 0;
			this.btnDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDonHang.ForeColor = System.Drawing.Color.White;
			this.btnDonHang.Image = global::QuanLyDienThoai.Properties.Resources.icons8_bill_48;
			this.btnDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDonHang.Location = new System.Drawing.Point(0, 248);
			this.btnDonHang.Name = "btnDonHang";
			this.btnDonHang.Size = new System.Drawing.Size(200, 64);
			this.btnDonHang.TabIndex = 4;
			this.btnDonHang.Text = "        Đơn hàng";
			this.btnDonHang.UseVisualStyleBackColor = true;
			this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
			// 
			// btnNhacc
			// 
			this.btnNhacc.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNhacc.FlatAppearance.BorderSize = 0;
			this.btnNhacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNhacc.ForeColor = System.Drawing.Color.White;
			this.btnNhacc.Image = global::QuanLyDienThoai.Properties.Resources.icons8_staff_48;
			this.btnNhacc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhacc.Location = new System.Drawing.Point(0, 184);
			this.btnNhacc.Name = "btnNhacc";
			this.btnNhacc.Size = new System.Drawing.Size(200, 64);
			this.btnNhacc.TabIndex = 3;
			this.btnNhacc.Text = "        Khách Hàng";
			this.btnNhacc.UseVisualStyleBackColor = true;
			this.btnNhacc.Click += new System.EventHandler(this.btnNhacc_Click);
			// 
			// btnSanPham
			// 
			this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSanPham.FlatAppearance.BorderSize = 0;
			this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSanPham.ForeColor = System.Drawing.Color.White;
			this.btnSanPham.Image = global::QuanLyDienThoai.Properties.Resources.icons8_smartphone_50;
			this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSanPham.Location = new System.Drawing.Point(0, 120);
			this.btnSanPham.Name = "btnSanPham";
			this.btnSanPham.Size = new System.Drawing.Size(200, 64);
			this.btnSanPham.TabIndex = 2;
			this.btnSanPham.Text = "        Sản phẩm";
			this.btnSanPham.UseVisualStyleBackColor = true;
			this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
			// 
			// btnTrangchu
			// 
			this.btnTrangchu.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTrangchu.FlatAppearance.BorderSize = 0;
			this.btnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrangchu.ForeColor = System.Drawing.Color.White;
			this.btnTrangchu.Image = global::QuanLyDienThoai.Properties.Resources.icons8_home_50;
			this.btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTrangchu.Location = new System.Drawing.Point(0, 56);
			this.btnTrangchu.Name = "btnTrangchu";
			this.btnTrangchu.Size = new System.Drawing.Size(200, 64);
			this.btnTrangchu.TabIndex = 1;
			this.btnTrangchu.Text = "         Trang chủ";
			this.btnTrangchu.UseVisualStyleBackColor = true;
			this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
			// 
			// frmMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 684);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.Name = "frmMainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMainMenu";
			this.panelMenu.ResumeLayout(false);
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnTrangchu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnKhoHang;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Button btnNhacc;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}