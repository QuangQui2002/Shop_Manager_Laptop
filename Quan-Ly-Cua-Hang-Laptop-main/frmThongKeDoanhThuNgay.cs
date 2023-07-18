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
    public partial class frmThongKeDoanhThuNgay : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();

        public frmThongKeDoanhThuNgay()
        {
            InitializeComponent();
            xulynumericUpDown(true);


        }
        DataSet ds = new DataSet();



        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];


        }
        private void radKhoangTG_CheckedChanged(object sender, EventArgs e)
        {

            mtbTuNgay.ReadOnly = false;
            mtbDenNgay.ReadOnly = false;
            dtpNgay.Enabled = false;




        }
        string tongdoanhthu()
        {

            int kq = 0;
            if (dgvDanhSachHDB.Rows.Count == 0)
            {
                return kq.ToString();
            }
            for (int i = 0; i < dgvDanhSachHDB.Rows.Count; i++)
            {

                int doanhthu = Convert.ToInt32(dgvDanhSachHDB.Rows[i].Cells[5].Value.ToString());
                kq += doanhthu;

            }
            return kq.ToString();
        }
        private void radNgayHT_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI,H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV and day(NGAYLAP) = day(GETDATE()) GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN");
            //r = tongdoanhthu();
            kiemtrachuoi(r);
            //lblDoanhThu.Text = r + " VNĐ";


        }
        void kiemtrachuoi(string r)
        {
            r = tongdoanhthu();

            if (r.Length == 1)
            {               
                lblDoanhThu.Text = "0";
            }
            if (r.Length == 5)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 2) + "." + r.Substring(2) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 6)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 3) + "." + r.Substring(3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 7)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 1) + "." + r.Substring(1, 3) + "." + r.Substring(4, 3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 8)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 2) + "." + r.Substring(2, 3) + "." + r.Substring(5, 3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 9)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 3) + "." + r.Substring(3, 3) + "." + r.Substring(6, 3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 10)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 1) + "." + r.Substring(1, 3) + "." + r.Substring(4, 3) + "." + r.Substring(7, 3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
        } 
         

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB,H.NGAYLAP,N.HOTENNV, K.TENKH,K.DIACHI,H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN");
            kiemtrachuoi(r);
        }
        void xulynumericUpDown(Boolean t)
        {
           dtpNgay.Enabled = !t;

            mtbTuNgay.ReadOnly = t;
            mtbDenNgay.ReadOnly = t;
        }

        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgay.Enabled = true;

            mtbTuNgay.ReadOnly = true;
            mtbDenNgay.ReadOnly = true;
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            //dtpNgay.ReadOnly = true;

            mtbTuNgay.ReadOnly = true;
            mtbDenNgay.ReadOnly = true;

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            //dtpNgay.ReadOnly = true;

            mtbTuNgay.ReadOnly = true;
            mtbDenNgay.ReadOnly = true;

        }


        private void frmThongKeHDTheoNgay_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB,H.NGAYLAP,N.HOTENNV, K.TENKH,K.DIACHI,H.TONGTIEN  FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN ");
            radTatCa.Checked = true;
        }



        string r="";
        private void btnThongKe_Click(object sender, EventArgs e)
        {

            //else if (r.Length == 6) 
            //{ string chuoi = ""; 
            //    chuoi = r.Substring(0, 3) + "." + r.Substring(3) + " vnđ"; 
            //    lblTong.Text = chuoi; }
            //else if (r.Length == 7)

            if (radNgay.Checked)
            {
                string[] date = dtpNgay.Text.Split('/');
                string ngay = date[1];
                string thang = date[0];
                string nam = date[2];

                //try
                //{
                LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, H.TONGTIEN  FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV AND DAY(H.NGAYLAP) = '" + ngay + "' and MONTH(H.NGAYLAP) = '" + thang + "' and  YEAR(H.NGAYLAP) = '" + nam + "' GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN  ");
                kiemtrachuoi(r);
                //}
                //catch
                //{
                //    MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }

            DateTime tuNgay, denNgay;
            if (radKhoangTG.Checked)
            {

                try
                {
                    tuNgay = DateTime.ParseExact(mtbTuNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    denNgay = DateTime.ParseExact(mtbDenNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    if (denNgay <= tuNgay)
                    {
                        MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI,H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV and H.NGAYLAP BETWEEN CAST('" + tuNgay + "' AS DATE) AND CAST('" + denNgay + "' AS DATE)  GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN");

                }
                catch
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
