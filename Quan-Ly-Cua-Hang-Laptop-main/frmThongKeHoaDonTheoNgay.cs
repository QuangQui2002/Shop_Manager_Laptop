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
    public partial class frmThongKeHDTheoNgay : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        
        public frmThongKeHDTheoNgay()
        {
            InitializeComponent();
            xulynumericUpDown(true);
           

        }
        DataSet ds =new DataSet();
       
       

        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

            
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void numNgay_ValueChanged(object sender, EventArgs e)
        {
            if (radNgay.Checked)
            {
                LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV  AND DAY(H.NGAYLAP) = " + numNgay.Text + " GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");
            }
        }

        private void numThang_ValueChanged(object sender, EventArgs e)
        {
            if (radThang.Checked)
            {
                LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV AND MONTH(H.NGAYLAP) = " + numThang.Text + " GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");
            }
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV AND YEAR(H.NGAYLAP) like N'%" + txtNam.Text + "%' GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");

            }
        }

        private void radKhoangTG_CheckedChanged(object sender, EventArgs e)
        {
            if (radKhoangTG.Checked)
            {
                mtbTuNgay.ReadOnly = false;
                mtbDenNgay.ReadOnly = false;
                numNgay.ReadOnly = true;
                numThang.ReadOnly = true;
                txtNam.ReadOnly = true;

            }

        }

        private void radNgayHT_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV and day(NGAYLAP) = day(GETDATE()) GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");

        }
        private void radThangHT_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV and month(NGAYLAP) = month(GETDATE()) GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");

        }

        private void radNamHT_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV and year(NGAYLAP) = year(GETDATE()) GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");

        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB,H.NGAYLAP,N.HOTENNV, K.TENKH,K.DIACHI,SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV");

        }
        void xulynumericUpDown(Boolean t)
        {
            numNgay.ReadOnly = t;
            numThang.ReadOnly = t;
            txtNam.ReadOnly = t;
            mtbTuNgay.ReadOnly = t;
            mtbDenNgay.ReadOnly = t;
        }

        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {
            numNgay.ReadOnly = false;
            numThang.ReadOnly = true;
            txtNam.ReadOnly = true;
            mtbTuNgay.ReadOnly = true;
            mtbDenNgay.ReadOnly = true;
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            numNgay.ReadOnly = true;
            numThang.ReadOnly = false;
            txtNam.ReadOnly = true;
            mtbTuNgay.ReadOnly = true;
            mtbDenNgay.ReadOnly = true;

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            numNgay.ReadOnly = true;
            numThang.ReadOnly = true;
            txtNam.ReadOnly = false;
            mtbTuNgay.ReadOnly = true;
            mtbDenNgay.ReadOnly = true;

        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmThongKeHDTheoNgay_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB,H.NGAYLAP,N.HOTENNV, K.TENKH,K.DIACHI,SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV");
          
        }

     
        private void lblHomNay_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime tuNgay, denNgay;
            try
            {
                tuNgay = DateTime.ParseExact(mtbTuNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                denNgay = DateTime.ParseExact(mtbDenNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (denNgay <= tuNgay)
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB and n.MANV = h.MANV and H.NGAYLAP BETWEEN CAST('" + tuNgay + "' AS DATE) AND CAST('" + denNgay + "' AS DATE) GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");

            }
            catch
            {
                MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
