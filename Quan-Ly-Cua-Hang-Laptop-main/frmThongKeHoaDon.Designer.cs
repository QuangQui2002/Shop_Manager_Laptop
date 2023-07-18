namespace _174_182_QLCHLAPTOP
{
    partial class frmThongKeHoaDon
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
            this.panelDestop = new System.Windows.Forms.Panel();
            this.btnHoaDonBan = new FontAwesome.Sharp.IconButton();
            this.btnHoaDonNhap = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightCyan;
            this.panelMenu.Controls.Add(this.btnHoaDonBan);
            this.panelMenu.Controls.Add(this.btnHoaDonNhap);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1082, 50);
            this.panelMenu.TabIndex = 0;
            // 
            // panelDestop
            // 
            this.panelDestop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDestop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDestop.ForeColor = System.Drawing.Color.White;
            this.panelDestop.Location = new System.Drawing.Point(0, 50);
            this.panelDestop.Name = "panelDestop";
            this.panelDestop.Size = new System.Drawing.Size(1082, 603);
            this.panelDestop.TabIndex = 1;
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHoaDonBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDonBan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHoaDonBan.IconColor = System.Drawing.Color.Black;
            this.btnHoaDonBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDonBan.Location = new System.Drawing.Point(500, 0);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Size = new System.Drawing.Size(500, 50);
            this.btnHoaDonBan.TabIndex = 1;
            this.btnHoaDonBan.Text = "HÓA ĐƠN BÁN";
            this.btnHoaDonBan.UseVisualStyleBackColor = false;
            this.btnHoaDonBan.Click += new System.EventHandler(this.btnHoaDonBan_Click);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonNhap.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDonNhap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHoaDonNhap.IconColor = System.Drawing.Color.Black;
            this.btnHoaDonNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(0, 0);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(500, 50);
            this.btnHoaDonNhap.TabIndex = 0;
            this.btnHoaDonNhap.Text = "HÓA ĐƠN NHẬP";
            this.btnHoaDonNhap.UseVisualStyleBackColor = false;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // frmThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panelDestop);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmThongKeHoaDon";
            this.Text = "THỐNG KÊ HÓA ĐƠN";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHoaDonNhap;
        private System.Windows.Forms.Panel panelDestop;
        private FontAwesome.Sharp.IconButton btnHoaDonBan;
    }
}