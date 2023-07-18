namespace _174_182_QLCHLAPTOP
{
    partial class frmThongKeSanPham
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartSanPham
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartSanPham.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartSanPham.Legends.Add(legend1);
            this.ChartSanPham.Location = new System.Drawing.Point(37, 73);
            this.ChartSanPham.Name = "ChartSanPham";
            this.ChartSanPham.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Biểu Đồ Cột";
            series1.Name = "ChartSanPham";
            this.ChartSanPham.Series.Add(series1);
            this.ChartSanPham.Size = new System.Drawing.Size(965, 468);
            this.ChartSanPham.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ THỐNG KÊ HÓA ĐƠN BÁN ĐƯỢC TRONG NĂM";
            this.ChartSanPham.Titles.Add(title1);
            // 
            // frmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1182, 1055);
            this.Controls.Add(this.ChartSanPham);
            this.Name = "frmThongKeSanPham";
            this.Text = "THỐNG KÊ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSanPham;
    }
}