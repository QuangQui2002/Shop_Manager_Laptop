namespace _174_182_QLCHLAPTOP
{
    partial class frmThongKeHoaDonBan
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
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.txtTuTK = new System.Windows.Forms.TextBox();
            this.Hinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoad = new FontAwesome.Sharp.IconButton();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboCachTK = new System.Windows.Forms.ComboBox();
            this.dgvHoaDonTK = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 30;
            this.btnThongKe.Location = new System.Drawing.Point(1010, 32);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(80, 37);
            this.btnThongKe.TabIndex = 216;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // txtTuTK
            // 
            this.txtTuTK.BackColor = System.Drawing.Color.White;
            this.txtTuTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuTK.CausesValidation = false;
            this.txtTuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuTK.ForeColor = System.Drawing.Color.Black;
            this.txtTuTK.Location = new System.Drawing.Point(703, 35);
            this.txtTuTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuTK.Multiline = true;
            this.txtTuTK.Name = "txtTuTK";
            this.txtTuTK.Size = new System.Drawing.Size(301, 30);
            this.txtTuTK.TabIndex = 214;
            this.txtTuTK.TextChanged += new System.EventHandler(this.txtTuTim_TextChanged);
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "HINH";
            this.Hinh.HeaderText = "Hình Ảnh";
            this.Hinh.MinimumWidth = 6;
            this.Hinh.Name = "Hinh";
            this.Hinh.Width = 125;
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
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.FillWeight = 85.33076F;
            this.GIABAN.HeaderText = "Giá Bán";
            this.GIABAN.MinimumWidth = 6;
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Width = 125;
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
            // THOIGIANBH
            // 
            this.THOIGIANBH.DataPropertyName = "THOIGIANBH";
            this.THOIGIANBH.FillWeight = 107.1439F;
            this.THOIGIANBH.HeaderText = "Thời Gian BH";
            this.THOIGIANBH.MinimumWidth = 6;
            this.THOIGIANBH.Name = "THOIGIANBH";
            this.THOIGIANBH.Width = 125;
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
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoad.BackgroundImage = global::_174_182_QLCHLAPTOP.Properties.Resources.loading__3_;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoad.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLoad.IconColor = System.Drawing.Color.White;
            this.btnLoad.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnLoad.IconSize = 30;
            this.btnLoad.Location = new System.Drawing.Point(1095, 32);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(47, 37);
            this.btnLoad.TabIndex = 217;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            // cboCachTK
            // 
            this.cboCachTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCachTK.FormattingEnabled = true;
            this.cboCachTK.Items.AddRange(new object[] {
            "Tổng Tiền Hóa Đơn Khách Hàng Mua",
            "Sản Phẩm Khách Hàng Mua",
            "Tổng Tiền Khách Hàng Mua"});
            this.cboCachTK.Location = new System.Drawing.Point(47, 35);
            this.cboCachTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCachTK.Name = "cboCachTK";
            this.cboCachTK.Size = new System.Drawing.Size(575, 33);
            this.cboCachTK.TabIndex = 215;
            // 
            // dgvHoaDonTK
            // 
            this.dgvHoaDonTK.AllowUserToAddRows = false;
            this.dgvHoaDonTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonTK.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDonTK.Location = new System.Drawing.Point(3, 24);
            this.dgvHoaDonTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDonTK.Name = "dgvHoaDonTK";
            this.dgvHoaDonTK.RowHeadersWidth = 51;
            this.dgvHoaDonTK.RowTemplate.Height = 24;
            this.dgvHoaDonTK.Size = new System.Drawing.Size(1579, 482);
            this.dgvHoaDonTK.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDonTK);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(47, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1585, 508);
            this.groupBox1.TabIndex = 213;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH THỐNG KÊ HÓA ĐƠN";
            // 
            // frmThongKeHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1682, 908);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.txtTuTK);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboCachTK);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThongKeHoaDonBan";
            this.Text = "THỐNG KÊ KHÁCH HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.TextBox txtTuTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private FontAwesome.Sharp.IconButton btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.ComboBox cboCachTK;
        private System.Windows.Forms.DataGridView dgvHoaDonTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}