namespace _174_182_QLCHLAPTOP
{
    partial class frmThongKeDoanhThuNam
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
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachHDB = new System.Windows.Forms.DataGridView();
            this.MaHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNamHT = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.panKhoangTG = new System.Windows.Forms.Panel();
            this.cboDenNam = new System.Windows.Forms.ComboBox();
            this.cboTuNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radKhoangTG = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panKhoangTG.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.ForeColor = System.Drawing.Color.Black;
            this.radNam.Location = new System.Drawing.Point(82, 149);
            this.radNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(122, 24);
            this.radNam.TabIndex = 6;
            this.radNam.TabStop = true;
            this.radNam.Text = "Trong Năm";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboNam.Location = new System.Drawing.Point(211, 146);
            this.cboNam.Margin = new System.Windows.Forms.Padding(4);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(110, 30);
            this.cboNam.TabIndex = 104;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // dgvDanhSachHDB
            // 
            this.dgvDanhSachHDB.AllowUserToAddRows = false;
            this.dgvDanhSachHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachHDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDN,
            this.NhanVien,
            this.NgayLap,
            this.MaNCC,
            this.DiaChi,
            this.TONGTIEN});
            this.dgvDanhSachHDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachHDB.Location = new System.Drawing.Point(3, 30);
            this.dgvDanhSachHDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachHDB.Name = "dgvDanhSachHDB";
            this.dgvDanhSachHDB.RowHeadersWidth = 51;
            this.dgvDanhSachHDB.RowTemplate.Height = 24;
            this.dgvDanhSachHDB.Size = new System.Drawing.Size(1498, 263);
            this.dgvDanhSachHDB.TabIndex = 1;
            // 
            // MaHDN
            // 
            this.MaHDN.DataPropertyName = "MAHDB";
            this.MaHDN.HeaderText = "Mã Hóa Đơn Nhập";
            this.MaHDN.MinimumWidth = 6;
            this.MaHDN.Name = "MaHDN";
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "HOTENNV";
            this.NhanVien.HeaderText = "Nhân Viên Lập";
            this.NhanVien.MinimumWidth = 6;
            this.NhanVien.Name = "NhanVien";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NGAYLAP";
            this.NgayLap.HeaderText = "Ngày Lập ";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "TENKH";
            this.MaNCC.HeaderText = "Tên Khách Hàng";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DIACHI";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachHDB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(82, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1504, 295);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH HÓA ĐƠN BÁN";
            // 
            // radNamHT
            // 
            this.radNamHT.AutoSize = true;
            this.radNamHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNamHT.ForeColor = System.Drawing.Color.Black;
            this.radNamHT.Location = new System.Drawing.Point(82, 96);
            this.radNamHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNamHT.Name = "radNamHT";
            this.radNamHT.Size = new System.Drawing.Size(199, 24);
            this.radNamHT.TabIndex = 3;
            this.radNamHT.TabStop = true;
            this.radNamHT.Text = "Trong Năm Hiện Tại";
            this.radNamHT.UseVisualStyleBackColor = true;
            this.radNamHT.CheckedChanged += new System.EventHandler(this.radNamHT_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.ForeColor = System.Drawing.Color.Black;
            this.radTatCa.Location = new System.Drawing.Point(82, 58);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(86, 24);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lblDoanhThu.Location = new System.Drawing.Point(963, 46);
            this.lblDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(400, 150);
            this.lblDoanhThu.TabIndex = 105;
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1073, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 39);
            this.label5.TabIndex = 106;
            this.label5.Text = "DOANH THU";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.Location = new System.Drawing.Point(1426, 46);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(160, 54);
            this.btnThongKe.TabIndex = 103;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panKhoangTG
            // 
            this.panKhoangTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panKhoangTG.Controls.Add(this.cboDenNam);
            this.panKhoangTG.Controls.Add(this.cboTuNam);
            this.panKhoangTG.Controls.Add(this.label4);
            this.panKhoangTG.Controls.Add(this.label1);
            this.panKhoangTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panKhoangTG.Location = new System.Drawing.Point(367, 94);
            this.panKhoangTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panKhoangTG.Name = "panKhoangTG";
            this.panKhoangTG.Size = new System.Drawing.Size(436, 71);
            this.panKhoangTG.TabIndex = 107;
            // 
            // cboDenNam
            // 
            this.cboDenNam.FormattingEnabled = true;
            this.cboDenNam.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboDenNam.Location = new System.Drawing.Point(305, 17);
            this.cboDenNam.Margin = new System.Windows.Forms.Padding(4);
            this.cboDenNam.Name = "cboDenNam";
            this.cboDenNam.Size = new System.Drawing.Size(110, 30);
            this.cboDenNam.TabIndex = 108;
            // 
            // cboTuNam
            // 
            this.cboTuNam.FormattingEnabled = true;
            this.cboTuNam.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cboTuNam.Location = new System.Drawing.Point(96, 17);
            this.cboTuNam.Margin = new System.Windows.Forms.Padding(4);
            this.cboTuNam.Name = "cboTuNam";
            this.cboTuNam.Size = new System.Drawing.Size(110, 30);
            this.cboTuNam.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(212, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đến Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ Năm";
            // 
            // radKhoangTG
            // 
            this.radKhoangTG.AutoSize = true;
            this.radKhoangTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhoangTG.ForeColor = System.Drawing.Color.Black;
            this.radKhoangTG.Location = new System.Drawing.Point(367, 58);
            this.radKhoangTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radKhoangTG.Name = "radKhoangTG";
            this.radKhoangTG.Size = new System.Drawing.Size(233, 24);
            this.radKhoangTG.TabIndex = 108;
            this.radKhoangTG.TabStop = true;
            this.radKhoangTG.Text = "Trong Khoảng Thời Gian";
            this.radKhoangTG.UseVisualStyleBackColor = true;
            this.radKhoangTG.CheckedChanged += new System.EventHandler(this.radKhoangTG_CheckedChanged);
            // 
            // frmThongKeDoanhThuNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1682, 908);
            this.Controls.Add(this.panKhoangTG);
            this.Controls.Add(this.radKhoangTG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.radNamHT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radTatCa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeDoanhThuNam";
            this.ShowInTaskbar = false;
            this.Text = "THỐNG KÊ HÓA ĐƠN THEO NĂM";
            this.Load += new System.EventHandler(this.frmThongKeHDTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panKhoangTG.ResumeLayout(false);
            this.panKhoangTG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radNam;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.DataGridView dgvDanhSachHDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNamHT;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.Panel panKhoangTG;
        private System.Windows.Forms.ComboBox cboDenNam;
        private System.Windows.Forms.ComboBox cboTuNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radKhoangTG;
    }
}