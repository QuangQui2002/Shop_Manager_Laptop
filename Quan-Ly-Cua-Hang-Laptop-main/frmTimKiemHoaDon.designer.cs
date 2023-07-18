namespace _174_182_QLCHLAPTOP
{
    partial class frmTimKiemHoaDon
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
            this.btnHoaDonNhap = new FontAwesome.Sharp.IconButton();
            this.btnHoaDonBan = new FontAwesome.Sharp.IconButton();
            this.panelDestop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightCyan;
            this.panelMenu.Controls.Add(this.btnHoaDonNhap);
            this.panelMenu.Controls.Add(this.btnHoaDonBan);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1682, 65);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonNhap.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDonNhap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHoaDonNhap.IconColor = System.Drawing.Color.Black;
            this.btnHoaDonNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(840, 0);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(842, 65);
            this.btnHoaDonNhap.TabIndex = 1;
            this.btnHoaDonNhap.Text = "HÓA ĐƠN NHẬP";
            this.btnHoaDonNhap.UseVisualStyleBackColor = false;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnHoaDonBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonBan.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDonBan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHoaDonBan.IconColor = System.Drawing.Color.Black;
            this.btnHoaDonBan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDonBan.Location = new System.Drawing.Point(0, 0);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Size = new System.Drawing.Size(840, 65);
            this.btnHoaDonBan.TabIndex = 0;
            this.btnHoaDonBan.Text = "HÓA ĐƠN BÁN";
            this.btnHoaDonBan.UseVisualStyleBackColor = false;
            this.btnHoaDonBan.Click += new System.EventHandler(this.btnHoaDonBan_Click);
            // 
            // panelDestop
            // 
            this.panelDestop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDestop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDestop.ForeColor = System.Drawing.Color.White;
            this.panelDestop.Location = new System.Drawing.Point(0, 65);
            this.panelDestop.Name = "panelDestop";
            this.panelDestop.Size = new System.Drawing.Size(1682, 843);
            this.panelDestop.TabIndex = 1;
            // 
            // frmTimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 908);
            this.Controls.Add(this.panelDestop);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmTimKiemHoaDon";
            this.Text = "TÌM KIẾM HÓA ĐƠN";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHoaDonBan;
        private FontAwesome.Sharp.IconButton btnHoaDonNhap;
        private System.Windows.Forms.Panel panelDestop;
    }
}