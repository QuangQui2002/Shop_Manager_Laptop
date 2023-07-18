namespace _174_182_QLCHLAPTOP
{
    partial class frmThongKeHDTheoNgay
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
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.radKhoangTG = new System.Windows.Forms.RadioButton();
            this.panKhoangTG = new System.Windows.Forms.Panel();
            this.mtbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.mtbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numNgay = new System.Windows.Forms.NumericUpDown();
            this.numThang = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachHDB = new System.Windows.Forms.DataGridView();
            this.MaHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.radNamHT = new System.Windows.Forms.RadioButton();
            this.radThangHT = new System.Windows.Forms.RadioButton();
            this.radNgayHT = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHomNay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.panKhoangTG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(21, 226);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(79, 22);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radTatCa_CheckedChanged);
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgay.Location = new System.Drawing.Point(338, 226);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(116, 22);
            this.radNgay.TabIndex = 4;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Trong Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            this.radNgay.CheckedChanged += new System.EventHandler(this.radNgay_CheckedChanged);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(338, 305);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(113, 22);
            this.radNam.TabIndex = 6;
            this.radNam.TabStop = true;
            this.radNam.Text = "Trong Năm";
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThang.Location = new System.Drawing.Point(338, 267);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(124, 22);
            this.radThang.TabIndex = 5;
            this.radThang.TabStop = true;
            this.radThang.Text = "Trong Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            this.radThang.CheckedChanged += new System.EventHandler(this.radThang_CheckedChanged);
            // 
            // radKhoangTG
            // 
            this.radKhoangTG.AutoSize = true;
            this.radKhoangTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKhoangTG.Location = new System.Drawing.Point(338, 343);
            this.radKhoangTG.Name = "radKhoangTG";
            this.radKhoangTG.Size = new System.Drawing.Size(213, 22);
            this.radKhoangTG.TabIndex = 7;
            this.radKhoangTG.TabStop = true;
            this.radKhoangTG.Text = "Trong Khoảng Thời Gian";
            this.radKhoangTG.UseVisualStyleBackColor = true;
            this.radKhoangTG.CheckedChanged += new System.EventHandler(this.radKhoangTG_CheckedChanged);
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
            this.panKhoangTG.Location = new System.Drawing.Point(662, 226);
            this.panKhoangTG.Name = "panKhoangTG";
            this.panKhoangTG.Size = new System.Drawing.Size(437, 111);
            this.panKhoangTG.TabIndex = 5;
            // 
            // mtbDenNgay
            // 
            this.mtbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDenNgay.Location = new System.Drawing.Point(235, 58);
            this.mtbDenNgay.Mask = "00/00/0000";
            this.mtbDenNgay.Name = "mtbDenNgay";
            this.mtbDenNgay.Size = new System.Drawing.Size(131, 27);
            this.mtbDenNgay.TabIndex = 11;
            this.mtbDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTuNgay
            // 
            this.mtbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTuNgay.Location = new System.Drawing.Point(235, 8);
            this.mtbTuNgay.Mask = "00/00/0000";
            this.mtbTuNgay.Name = "mtbTuNgay";
            this.mtbTuNgay.Size = new System.Drawing.Size(131, 27);
            this.mtbTuNgay.TabIndex = 10;
            this.mtbTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày/Tháng/Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đến Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày/Tháng/Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ Ngày";
            // 
            // numNgay
            // 
            this.numNgay.Location = new System.Drawing.Point(513, 226);
            this.numNgay.Name = "numNgay";
            this.numNgay.Size = new System.Drawing.Size(84, 22);
            this.numNgay.TabIndex = 6;
            this.numNgay.ValueChanged += new System.EventHandler(this.numNgay_ValueChanged);
            // 
            // numThang
            // 
            this.numThang.Location = new System.Drawing.Point(513, 266);
            this.numThang.Name = "numThang";
            this.numThang.Size = new System.Drawing.Size(84, 22);
            this.numThang.TabIndex = 12;
            this.numThang.ValueChanged += new System.EventHandler(this.numThang_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachHDB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(21, 392);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1078, 300);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn Bán";
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
            this.DiaChi});
            this.dgvDanhSachHDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachHDB.Location = new System.Drawing.Point(3, 30);
            this.dgvDanhSachHDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachHDB.Name = "dgvDanhSachHDB";
            this.dgvDanhSachHDB.RowHeadersWidth = 51;
            this.dgvDanhSachHDB.RowTemplate.Height = 24;
            this.dgvDanhSachHDB.Size = new System.Drawing.Size(1072, 268);
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
            // txtNam
            // 
            this.txtNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNam.Location = new System.Drawing.Point(513, 305);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(84, 22);
            this.txtNam.TabIndex = 101;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // radNamHT
            // 
            this.radNamHT.AutoSize = true;
            this.radNamHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNamHT.Location = new System.Drawing.Point(21, 343);
            this.radNamHT.Name = "radNamHT";
            this.radNamHT.Size = new System.Drawing.Size(180, 22);
            this.radNamHT.TabIndex = 3;
            this.radNamHT.TabStop = true;
            this.radNamHT.Text = "Trong Năm Hiện Tại";
            this.radNamHT.UseVisualStyleBackColor = true;
            this.radNamHT.CheckedChanged += new System.EventHandler(this.radNamHT_CheckedChanged);
            // 
            // radThangHT
            // 
            this.radThangHT.AutoSize = true;
            this.radThangHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThangHT.Location = new System.Drawing.Point(21, 305);
            this.radThangHT.Name = "radThangHT";
            this.radThangHT.Size = new System.Drawing.Size(191, 22);
            this.radThangHT.TabIndex = 2;
            this.radThangHT.TabStop = true;
            this.radThangHT.Text = "Trong Tháng Hiện Tại";
            this.radThangHT.UseVisualStyleBackColor = true;
            this.radThangHT.CheckedChanged += new System.EventHandler(this.radThangHT_CheckedChanged);
            // 
            // radNgayHT
            // 
            this.radNgayHT.AutoSize = true;
            this.radNgayHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNgayHT.Location = new System.Drawing.Point(21, 266);
            this.radNgayHT.Name = "radNgayHT";
            this.radNgayHT.Size = new System.Drawing.Size(183, 22);
            this.radNgayHT.TabIndex = 1;
            this.radNgayHT.TabStop = true;
            this.radNgayHT.Text = "Trong Ngày Hiện Tại";
            this.radNgayHT.UseVisualStyleBackColor = true;
            this.radNgayHT.CheckedChanged += new System.EventHandler(this.radNgayHT_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1102, 181);
            this.tableLayoutPanel1.TabIndex = 102;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHomNay);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 84);
            this.panel1.TabIndex = 0;
            // 
            // lblHomNay
            // 
            this.lblHomNay.AutoSize = true;
            this.lblHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomNay.Location = new System.Drawing.Point(24, 45);
            this.lblHomNay.Name = "lblHomNay";
            this.lblHomNay.Size = new System.Drawing.Size(18, 20);
            this.lblHomNay.TabIndex = 2;
            this.lblHomNay.Text = "0";
            this.lblHomNay.Click += new System.EventHandler(this.lblHomNay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "HÔM NAY";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Aquamarine;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.Location = new System.Drawing.Point(977, 343);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(119, 35);
            this.btnThongKe.TabIndex = 103;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmThongKeHDTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radNamHT);
            this.Controls.Add(this.radThangHT);
            this.Controls.Add(this.radNgayHT);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numThang);
            this.Controls.Add(this.numNgay);
            this.Controls.Add(this.panKhoangTG);
            this.Controls.Add(this.radKhoangTG);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radThang);
            this.Controls.Add(this.radNgay);
            this.Controls.Add(this.radTatCa);
            this.Name = "frmThongKeHDTheoNgay";
            this.ShowInTaskbar = false;
            this.Text = "THỐNG KÊ HÓA ĐƠN THEO NGÀY";
            this.Load += new System.EventHandler(this.frmThongKeHDTheoNgay_Load);
            this.panKhoangTG.ResumeLayout(false);
            this.panKhoangTG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHDB)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.RadioButton radKhoangTG;
        private System.Windows.Forms.Panel panKhoangTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNgay;
        private System.Windows.Forms.NumericUpDown numThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachHDB;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.RadioButton radNamHT;
        private System.Windows.Forms.RadioButton radThangHT;
        private System.Windows.Forms.RadioButton radNgayHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHomNay;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.MaskedTextBox mtbDenNgay;
        private System.Windows.Forms.MaskedTextBox mtbTuNgay;
    }
}