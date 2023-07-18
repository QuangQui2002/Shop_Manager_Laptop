namespace _174_182_QLCHLAPTOP
{
    partial class frmTimKiemSanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachSP = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCachTim = new System.Windows.Forms.ComboBox();
            this.txtTuTim = new System.Windows.Forms.TextBox();
            this.picHinhSP = new System.Windows.Forms.PictureBox();
            this.btnLoad = new FontAwesome.Sharp.IconButton();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachSP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(38, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1595, 322);
            this.groupBox1.TabIndex = 206;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // dgvDanhSachSP
            // 
            this.dgvDanhSachSP.AllowUserToAddRows = false;
            this.dgvDanhSachSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDanhSachSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachSP.ColumnHeadersHeight = 29;
            this.dgvDanhSachSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.TENLOAI,
            this.TENNCC,
            this.HANGSX,
            this.MoTa,
            this.Hinh,
            this.GIANHAP,
            this.GIABAN,
            this.SoLuong,
            this.THOIGIANBH,
            this.TRANGTHAI});
            this.dgvDanhSachSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachSP.Location = new System.Drawing.Point(3, 38);
            this.dgvDanhSachSP.Name = "dgvDanhSachSP";
            this.dgvDanhSachSP.RowHeadersWidth = 51;
            this.dgvDanhSachSP.Size = new System.Drawing.Size(1589, 282);
            this.dgvDanhSachSP.TabIndex = 0;
            this.dgvDanhSachSP.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSP_CellMouseLeave);
            this.dgvDanhSachSP.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDanhSachSP_CellMouseMove);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MASP";
            this.MaSP.FillWeight = 106.9182F;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 88;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TENSP";
            this.TenSP.FillWeight = 107.9682F;
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 93;
            // 
            // TENLOAI
            // 
            this.TENLOAI.DataPropertyName = "TENLOAI";
            this.TENLOAI.HeaderText = "Tên Loại";
            this.TENLOAI.MinimumWidth = 6;
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.Width = 103;
            // 
            // TENNCC
            // 
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Tên NCC";
            this.TENNCC.MinimumWidth = 6;
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Width = 107;
            // 
            // HANGSX
            // 
            this.HANGSX.DataPropertyName = "TENHANGSX";
            this.HANGSX.HeaderText = "Hãng Sản Xuất";
            this.HANGSX.MinimumWidth = 6;
            this.HANGSX.Name = "HANGSX";
            this.HANGSX.Width = 151;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MOTA";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 85;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "HINH";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 107;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.FillWeight = 97.47835F;
            this.GIANHAP.HeaderText = "Giá Nhập";
            this.GIANHAP.MinimumWidth = 6;
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Width = 108;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.FillWeight = 85.33076F;
            this.GIABAN.HeaderText = "Giá Bán";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Width = 99;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            this.SoLuong.HeaderText = "Số Lượng Tồn";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 142;
            // 
            // THOIGIANBH
            // 
            this.THOIGIANBH.DataPropertyName = "THOIGIANBH";
            this.THOIGIANBH.FillWeight = 107.1439F;
            this.THOIGIANBH.HeaderText = "Thời Gian BH";
            this.THOIGIANBH.MinimumWidth = 6;
            this.THOIGIANBH.Name = "THOIGIANBH";
            this.THOIGIANBH.Width = 140;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.FillWeight = 100.7197F;
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Width = 118;
            // 
            // cboCachTim
            // 
            this.cboCachTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCachTim.FormattingEnabled = true;
            this.cboCachTim.Items.AddRange(new object[] {
            "Mã Sản Phẩm",
            "Tên Sản Phẩm",
            "Loại Sản Phẩm",
            "Hãng Sản Xuất",
            "Nhà Cung Cấp"});
            this.cboCachTim.Location = new System.Drawing.Point(38, 40);
            this.cboCachTim.Name = "cboCachTim";
            this.cboCachTim.Size = new System.Drawing.Size(203, 33);
            this.cboCachTim.TabIndex = 214;
            // 
            // txtTuTim
            // 
            this.txtTuTim.BackColor = System.Drawing.Color.White;
            this.txtTuTim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuTim.CausesValidation = false;
            this.txtTuTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuTim.ForeColor = System.Drawing.Color.Black;
            this.txtTuTim.Location = new System.Drawing.Point(255, 39);
            this.txtTuTim.Multiline = true;
            this.txtTuTim.Name = "txtTuTim";
            this.txtTuTim.Size = new System.Drawing.Size(400, 35);
            this.txtTuTim.TabIndex = 213;
            this.txtTuTim.TextChanged += new System.EventHandler(this.txtTuTim_TextChanged_1);
            // 
            // picHinhSP
            // 
            this.picHinhSP.Location = new System.Drawing.Point(923, 436);
            this.picHinhSP.Name = "picHinhSP";
            this.picHinhSP.Size = new System.Drawing.Size(350, 350);
            this.picHinhSP.TabIndex = 217;
            this.picHinhSP.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLoad.BackgroundImage = global::_174_182_QLCHLAPTOP.Properties.Resources.loading__5_;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLoad.IconColor = System.Drawing.Color.Black;
            this.btnLoad.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnLoad.IconSize = 30;
            this.btnLoad.Location = new System.Drawing.Point(763, 36);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(47, 38);
            this.btnLoad.TabIndex = 216;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Aquamarine;
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTim.IconColor = System.Drawing.Color.Black;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 30;
            this.btnTim.Location = new System.Drawing.Point(677, 36);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 38);
            this.btnTim.TabIndex = 215;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1682, 908);
            this.Controls.Add(this.picHinhSP);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboCachTim);
            this.Controls.Add(this.txtTuTim);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTimKiemSanPham";
            this.Text = "TÌM KIẾM SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmTimKiemSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachSP;
        private FontAwesome.Sharp.IconButton btnLoad;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.ComboBox cboCachTim;
        private System.Windows.Forms.TextBox txtTuTim;
        private System.Windows.Forms.PictureBox picHinhSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
    }
}