namespace _174_182_QLCHLAPTOP
{
    partial class frmThongKeDoanhThuNgay
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
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.dgvDanhSachHDB = new System.Windows.Forms.DataGridView();
            this.MaHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNgayHT = new System.Windows.Forms.RadioButton();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.radKhoangTG = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.mtbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.panKhoangTG = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panKhoangTG.SuspendLayout();
            this.SuspendLayout();
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgay.ForeColor = System.Drawing.Color.Black;
            this.radNgay.Location = new System.Drawing.Point(49, 141);
            this.radNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(126, 24);
            this.radNgay.TabIndex = 4;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Trong Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            this.radNgay.CheckedChanged += new System.EventHandler(this.radNgay_CheckedChanged);
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
            this.dgvDanhSachHDB.Size = new System.Drawing.Size(1537, 268);
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
            this.groupBox1.Location = new System.Drawing.Point(49, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1543, 300);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH HÓA ĐƠN BÁN";
            // 
            // radNgayHT
            // 
            this.radNgayHT.AutoSize = true;
            this.radNgayHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgayHT.ForeColor = System.Drawing.Color.Black;
            this.radNgayHT.Location = new System.Drawing.Point(49, 83);
            this.radNgayHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNgayHT.Name = "radNgayHT";
            this.radNgayHT.Size = new System.Drawing.Size(203, 24);
            this.radNgayHT.TabIndex = 1;
            this.radNgayHT.TabStop = true;
            this.radNgayHT.Text = "Trong Ngày Hiện Tại";
            this.radNgayHT.UseVisualStyleBackColor = true;
            this.radNgayHT.CheckedChanged += new System.EventHandler(this.radNgayHT_CheckedChanged);
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.ForeColor = System.Drawing.Color.Black;
            this.radTatCa.Location = new System.Drawing.Point(49, 44);
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
            this.lblDoanhThu.Location = new System.Drawing.Point(969, 40);
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
            this.label5.Location = new System.Drawing.Point(1079, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 40);
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
            this.btnThongKe.Location = new System.Drawing.Point(1432, 37);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(160, 53);
            this.btnThongKe.TabIndex = 103;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(195, 141);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(186, 30);
            this.dtpNgay.TabIndex = 108;
            // 
            // radKhoangTG
            // 
            this.radKhoangTG.AutoSize = true;
            this.radKhoangTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhoangTG.ForeColor = System.Drawing.Color.Black;
            this.radKhoangTG.Location = new System.Drawing.Point(436, 44);
            this.radKhoangTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radKhoangTG.Name = "radKhoangTG";
            this.radKhoangTG.Size = new System.Drawing.Size(233, 24);
            this.radKhoangTG.TabIndex = 7;
            this.radKhoangTG.TabStop = true;
            this.radKhoangTG.Text = "Trong Khoảng Thời Gian";
            this.radKhoangTG.UseVisualStyleBackColor = true;
            this.radKhoangTG.CheckedChanged += new System.EventHandler(this.radKhoangTG_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày/Tháng/Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đến Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày/Tháng/Năm";
            // 
            // mtbTuNgay
            // 
            this.mtbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTuNgay.Location = new System.Drawing.Point(235, 16);
            this.mtbTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTuNgay.Mask = "00/00/0000";
            this.mtbTuNgay.Name = "mtbTuNgay";
            this.mtbTuNgay.Size = new System.Drawing.Size(141, 30);
            this.mtbTuNgay.TabIndex = 10;
            this.mtbTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDenNgay
            // 
            this.mtbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDenNgay.Location = new System.Drawing.Point(235, 88);
            this.mtbDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbDenNgay.Mask = "00/00/0000";
            this.mtbDenNgay.Name = "mtbDenNgay";
            this.mtbDenNgay.Size = new System.Drawing.Size(141, 30);
            this.mtbDenNgay.TabIndex = 11;
            this.mtbDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // panKhoangTG
            // 
            this.panKhoangTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panKhoangTG.Controls.Add(this.mtbDenNgay);
            this.panKhoangTG.Controls.Add(this.mtbTuNgay);
            this.panKhoangTG.Controls.Add(this.label3);
            this.panKhoangTG.Controls.Add(this.label4);
            this.panKhoangTG.Controls.Add(this.label2);
            this.panKhoangTG.Controls.Add(this.label1);
            this.panKhoangTG.Location = new System.Drawing.Point(436, 77);
            this.panKhoangTG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panKhoangTG.Name = "panKhoangTG";
            this.panKhoangTG.Size = new System.Drawing.Size(437, 141);
            this.panKhoangTG.TabIndex = 5;
            // 
            // frmThongKeDoanhThuNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1682, 908);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.radNgayHT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panKhoangTG);
            this.Controls.Add(this.radKhoangTG);
            this.Controls.Add(this.radNgay);
            this.Controls.Add(this.radTatCa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeDoanhThuNgay";
            this.ShowInTaskbar = false;
            this.Text = "THỐNG KÊ HÓA ĐƠN THEO NGÀY";
            this.Load += new System.EventHandler(this.frmThongKeHDTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panKhoangTG.ResumeLayout(false);
            this.panKhoangTG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.DataGridView dgvDanhSachHDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNgayHT;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.RadioButton radKhoangTG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbTuNgay;
        private System.Windows.Forms.MaskedTextBox mtbDenNgay;
        private System.Windows.Forms.Panel panKhoangTG;
    }
}