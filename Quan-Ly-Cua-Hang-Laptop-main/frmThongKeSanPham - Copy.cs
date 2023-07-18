using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _174_182_QLCHLAPTOP
{
    public partial class frmThongKeSanPham : Form
    {
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            //ChartSanPham.Series["ChartSanPham"].Points.AddXY("Tháng 1", 1000);
            //ChartSanPham.Series["ChartSanPham"].Points.AddXY("Tháng 2", 2000);
            //ChartSanPham.Series["ChartSanPham"].Points.AddXY("Tháng 3", 3000);
            //ChartSanPham.Series["ChartSanPham"].Points.AddXY("Tháng 4", 4000);
            //ChartSanPham.Series["ChartSanPham"].Points.AddXY("Tháng 5", 5000);
            //ChartSanPham.Series["ChartSanPham"].Points.AddXY("Tháng 6", 6000);
            //ChartSanPham.Series["ChartSanPham"].Points.AddXY("Tháng 7", 7000);

            ChartSanPham.Series["ChartSanPham"].Points.Add(7000);
            ChartSanPham.Series["ChartSanPham"].Points[0].Label = "7000";
            ChartSanPham.Series["ChartSanPham"].Points[0].Color = Color.Blue;
            ChartSanPham.Series["ChartSanPham"].Points[0].AxisLabel = "Tháng 1";

            ChartSanPham.Series["ChartSanPham"].Points.Add(4000);
            ChartSanPham.Series["ChartSanPham"].Points[0].Label = "4000";
            ChartSanPham.Series["ChartSanPham"].Points[0].Color = Color.Blue;
            ChartSanPham.Series["ChartSanPham"].Points[0].AxisLabel = "Tháng 2";

            ChartSanPham.Series["ChartSanPham"].Points.Add(6000);
            ChartSanPham.Series["ChartSanPham"].Points[0].Label = "6000";
            ChartSanPham.Series["ChartSanPham"].Points[0].Color = Color.Blue;
            ChartSanPham.Series["ChartSanPham"].Points[0].AxisLabel = "Tháng 3";

            ChartSanPham.Series["ChartSanPham"].Points.Add(2000);
            ChartSanPham.Series["ChartSanPham"].Points[0].Label = "2000";
            ChartSanPham.Series["ChartSanPham"].Points[0].Color = Color.Blue;
            ChartSanPham.Series["ChartSanPham"].Points[0].AxisLabel = "Tháng 4";



        }
    }
}
