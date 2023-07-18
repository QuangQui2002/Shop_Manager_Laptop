namespace _174_182_QLCHLAPTOP
{
    partial class frmThongKeDoanhThu
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
            this.panelDestop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDoanhThuNam = new FontAwesome.Sharp.IconButton();
            this.btnDoanhThuThang = new FontAwesome.Sharp.IconButton();
            this.btnDoanhThuNgay = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDestop
            // 
            this.panelDestop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDestop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDestop.ForeColor = System.Drawing.Color.White;
            this.panelDestop.Location = new System.Drawing.Point(0, 67);
            this.panelDestop.Name = "panelDestop";
            this.panelDestop.Size = new System.Drawing.Size(1682, 841);
            this.panelDestop.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightCyan;
            this.panelMenu.Controls.Add(this.btnDoanhThuThang);
            this.panelMenu.Controls.Add(this.btnDoanhThuNam);
            this.panelMenu.Controls.Add(this.btnDoanhThuNgay);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1682, 67);
            this.panelMenu.TabIndex = 2;
            // 
            // btnDoanhThuNam
            // 
            this.btnDoanhThuNam.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDoanhThuNam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDoanhThuNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuNam.ForeColor = System.Drawing.Color.Black;
            this.btnDoanhThuNam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDoanhThuNam.IconColor = System.Drawing.Color.Black;
            this.btnDoanhThuNam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoanhThuNam.Location = new System.Drawing.Point(1122, 0);
            this.btnDoanhThuNam.Name = "btnDoanhThuNam";
            this.btnDoanhThuNam.Size = new System.Drawing.Size(560, 67);
            this.btnDoanhThuNam.TabIndex = 3;
            this.btnDoanhThuNam.Text = "DOANH THU NĂM";
            this.btnDoanhThuNam.UseVisualStyleBackColor = false;
            this.btnDoanhThuNam.Click += new System.EventHandler(this.btnDoanhThuNam_Click);
            // 
            // btnDoanhThuThang
            // 
            this.btnDoanhThuThang.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDoanhThuThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoanhThuThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuThang.ForeColor = System.Drawing.Color.Black;
            this.btnDoanhThuThang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDoanhThuThang.IconColor = System.Drawing.Color.Black;
            this.btnDoanhThuThang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoanhThuThang.Location = new System.Drawing.Point(560, 0);
            this.btnDoanhThuThang.Name = "btnDoanhThuThang";
            this.btnDoanhThuThang.Size = new System.Drawing.Size(562, 67);
            this.btnDoanhThuThang.TabIndex = 2;
            this.btnDoanhThuThang.Text = "DOANH THU THÁNG";
            this.btnDoanhThuThang.UseVisualStyleBackColor = false;
            this.btnDoanhThuThang.Click += new System.EventHandler(this.btnDoanhThuThang_Click);
            // 
            // btnDoanhThuNgay
            // 
            this.btnDoanhThuNgay.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDoanhThuNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDoanhThuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThuNgay.ForeColor = System.Drawing.Color.Black;
            this.btnDoanhThuNgay.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDoanhThuNgay.IconColor = System.Drawing.Color.Black;
            this.btnDoanhThuNgay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoanhThuNgay.Location = new System.Drawing.Point(0, 0);
            this.btnDoanhThuNgay.Name = "btnDoanhThuNgay";
            this.btnDoanhThuNgay.Size = new System.Drawing.Size(560, 67);
            this.btnDoanhThuNgay.TabIndex = 1;
            this.btnDoanhThuNgay.Text = "DOANH THU NGÀY";
            this.btnDoanhThuNgay.UseVisualStyleBackColor = false;
            this.btnDoanhThuNgay.Click += new System.EventHandler(this.btnDoanhThuNgay_Click);
            // 
            // frmThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 908);
            this.Controls.Add(this.panelDestop);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmThongKeDoanhThu";
            this.Text = "THỐNG KÊ DOANH THU";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDestop;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnDoanhThuNgay;
        private FontAwesome.Sharp.IconButton btnDoanhThuNam;
        private FontAwesome.Sharp.IconButton btnDoanhThuThang;
    }
}