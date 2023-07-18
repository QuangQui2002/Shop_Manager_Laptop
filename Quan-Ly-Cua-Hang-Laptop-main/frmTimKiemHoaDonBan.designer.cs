namespace _174_182_QLCHLAPTOP
{
    partial class frmTimKiemHoaDonBan
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
            this.dgvDanhSachHDB = new System.Windows.Forms.DataGridView();
            this.MaHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCachTim = new System.Windows.Forms.ComboBox();
            this.btnLoad = new FontAwesome.Sharp.IconButton();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.mtbNgay = new System.Windows.Forms.MaskedTextBox();
            this.txtTuTim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachHDB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(34, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1611, 500);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH HÓA ĐƠN BÁN";
            // 
            // dgvDanhSachHDB
            // 
            this.dgvDanhSachHDB.AllowUserToAddRows = false;
            this.dgvDanhSachHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDB,
            this.MaKH,
            this.MaNV,
            this.NgayLapHDB,
            this.TongTien,
            this.TrangThai});
            this.dgvDanhSachHDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachHDB.Location = new System.Drawing.Point(3, 32);
            this.dgvDanhSachHDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachHDB.Name = "dgvDanhSachHDB";
            this.dgvDanhSachHDB.RowHeadersWidth = 51;
            this.dgvDanhSachHDB.RowTemplate.Height = 24;
            this.dgvDanhSachHDB.Size = new System.Drawing.Size(1605, 466);
            this.dgvDanhSachHDB.TabIndex = 1;
            // 
            // MaHDB
            // 
            this.MaHDB.DataPropertyName = "MAHDB";
            this.MaHDB.HeaderText = "Mã Hóa Đơn Bán";
            this.MaHDB.MinimumWidth = 6;
            this.MaHDB.Name = "MaHDB";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "TENKH";
            this.MaKH.HeaderText = "Tên Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "HOTENNV";
            this.MaNV.HeaderText = "Tên Nhân Viên Bán";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // NgayLapHDB
            // 
            this.NgayLapHDB.DataPropertyName = "NGAYLAP";
            this.NgayLapHDB.HeaderText = "Ngày Lập";
            this.NgayLapHDB.MinimumWidth = 6;
            this.NgayLapHDB.Name = "NgayLapHDB";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TONGTIEN";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TRANGTHAI";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MASP";
            this.MaSP.FillWeight = 106.9182F;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TENSP";
            this.TenSP.FillWeight = 107.9682F;
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 125;
            // 
            // MALOAI
            // 
            this.MALOAI.DataPropertyName = "MALOAI";
            this.MALOAI.FillWeight = 96.70437F;
            this.MALOAI.HeaderText = "Mã Loại";
            this.MALOAI.MinimumWidth = 6;
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            this.MALOAI.Width = 125;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.FillWeight = 97.73653F;
            this.MANCC.HeaderText = "Mã NCC";
            this.MANCC.MinimumWidth = 6;
            this.MANCC.Name = "MANCC";
            this.MANCC.ReadOnly = true;
            this.MANCC.Width = 125;
            // 
            // THOIGIANBH
            // 
            this.THOIGIANBH.DataPropertyName = "THOIGIANBH";
            this.THOIGIANBH.FillWeight = 107.1439F;
            this.THOIGIANBH.HeaderText = "Thời Gian BH";
            this.THOIGIANBH.MinimumWidth = 6;
            this.THOIGIANBH.Name = "THOIGIANBH";
            this.THOIGIANBH.Width = 125;
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.FillWeight = 97.47835F;
            this.GIANHAP.HeaderText = "Giá Nhập";
            this.GIANHAP.MinimumWidth = 6;
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Width = 125;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.FillWeight = 85.33076F;
            this.GIABAN.HeaderText = "Giá Bán";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TRANGTHAI";
            this.dataGridViewTextBoxColumn1.FillWeight = 100.7197F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "HINH";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 125;
            // 
            // cboCachTim
            // 
            this.cboCachTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCachTim.FormattingEnabled = true;
            this.cboCachTim.Items.AddRange(new object[] {
            "Mã Hóa Đơn",
            "Ngày Lập Hóa Đơn"});
            this.cboCachTim.Location = new System.Drawing.Point(34, 26);
            this.cboCachTim.Name = "cboCachTim";
            this.cboCachTim.Size = new System.Drawing.Size(203, 33);
            this.cboCachTim.TabIndex = 214;
            this.cboCachTim.SelectedIndexChanged += new System.EventHandler(this.cboCachTim_SelectedIndexChanged_1);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLoad.BackgroundImage = global::_174_182_QLCHLAPTOP.Properties.Resources.loading__5_;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLoad.IconColor = System.Drawing.Color.White;
            this.btnLoad.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnLoad.IconSize = 30;
            this.btnLoad.Location = new System.Drawing.Point(756, 23);
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
            this.btnTim.Location = new System.Drawing.Point(670, 24);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 38);
            this.btnTim.TabIndex = 215;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // mtbNgay
            // 
            this.mtbNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNgay.Location = new System.Drawing.Point(253, 73);
            this.mtbNgay.Mask = "00/00/0000";
            this.mtbNgay.Name = "mtbNgay";
            this.mtbNgay.Size = new System.Drawing.Size(117, 30);
            this.mtbNgay.TabIndex = 217;
            this.mtbNgay.ValidatingType = typeof(System.DateTime);
            this.mtbNgay.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNgay_MaskInputRejected);
            // 
            // txtTuTim
            // 
            this.txtTuTim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuTim.Location = new System.Drawing.Point(253, 26);
            this.txtTuTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuTim.Multiline = true;
            this.txtTuTim.Name = "txtTuTim";
            this.txtTuTim.Size = new System.Drawing.Size(400, 33);
            this.txtTuTim.TabIndex = 218;
            this.txtTuTim.TextChanged += new System.EventHandler(this.txtTuTim_TextChanged);
            // 
            // frmTimKiemHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1682, 908);
            this.Controls.Add(this.txtTuTim);
            this.Controls.Add(this.mtbNgay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboCachTim);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiemHoaDonBan";
            this.Text = "TÌM KIẾM HÓA ĐƠN BÁN";
            this.Load += new System.EventHandler(this.frmTimKiemHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private FontAwesome.Sharp.IconButton btnLoad;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.ComboBox cboCachTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.MaskedTextBox mtbNgay;
        private System.Windows.Forms.TextBox txtTuTim;
    }
}