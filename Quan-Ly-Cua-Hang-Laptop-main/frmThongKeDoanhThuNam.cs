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
    public partial class frmThongKeDoanhThuNam : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        
        public frmThongKeDoanhThuNam()
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

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV AND YEAR(H.NGAYLAP) = " + cboNam.Text + " GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ");

            }
        }

     
        string tongdoanhthu()
        {

            int kq = 0;
            if (dgvDanhSachHDB.Rows.Count == 0)
            {
                return kq.ToString();
            }
            for(int i=0;i<dgvDanhSachHDB.Rows.Count;i++)
            {

                int doanhthu = Convert.ToInt32(dgvDanhSachHDB.Rows[i].Cells[5].Value);
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
                chuoi = r.Substring(0, 1) + "." + r.Substring(1,3)+ "." + r.Substring(4,3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 8)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 2) + "." + r.Substring(2,3) + "." + r.Substring(5,3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 9)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 3) + "." + r.Substring(3, 3) + "." + r.Substring(6,3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
            if (r.Length == 10)
            {
                string chuoi = "";
                chuoi = r.Substring(0, 1) + "." + r.Substring(1,3) + "." + r.Substring(4,3) + "." + r.Substring(7,3) + " VNĐ";
                lblDoanhThu.Text = chuoi;
            }
        }
        private void radThangHT_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV and month(NGAYLAP) = month(GETDATE()) GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV ,H.TONGTIEN");
            kiemtrachuoi(r);
        }

        private void radNamHT_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV and year(NGAYLAP) = year(GETDATE()) GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN ");
            kiemtrachuoi(r);
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            xulynumericUpDown(true);
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB,H.NGAYLAP,N.HOTENNV, K.TENKH,K.DIACHI,H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN");
            kiemtrachuoi(r);
        }
        void xulynumericUpDown(Boolean t)
        {
          
            cboNam.Enabled = !t;
            cboTuNam.Enabled = !true;
            cboDenNam.Enabled = !true;

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            cboTuNam.Enabled = !true;
            cboDenNam.Enabled = !true;
            cboNam.Enabled = true;
          
           

        }

        private void frmThongKeHDTheoNgay_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB,H.NGAYLAP,N.HOTENNV, K.TENKH,K.DIACHI,H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN");
            radTatCa.Checked = true;
        }



        string r = "";
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {

            }
            if (radNamHT.Checked)
            {

            }
            if (radNam.Checked)
            {
                if (cboNam.Text == "")
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV AND YEAR(H.NGAYLAP) = '" + cboNam.Text + "' GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN ");
                    kiemtrachuoi(r);
                }
            }

           
            if (radKhoangTG.Checked)
            {
                if (cboTuNam.Text == "" || cboDenNam.Text == "")
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int tunam = int.Parse(cboTuNam.Text);
                    int dennam = int.Parse(cboDenNam.Text);

                    if (dennam <= tunam)
                    {
                        MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, SUM(C.THANHTIEN) AS 'Tổng Tiền' FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV AND H.TRANGTHAI= 1 AND YEAR(H.NGAYLAP) BETWEEN '" + cboTuNam.Text + "' AND '" + cboDenNam.Text + "' GROUP BY H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI");
                    kiemtrachuoi(r);
                }
            }

        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (radNam.Checked)
            {
                LoadDuLieu_datagrid(dgvDanhSachHDB, "SELECT H.MAHDB, H.NGAYLAP, N.HOTENNV, K.TENKH, K.DIACHI, H.TONGTIEN FROM HOADONBAN H, KHACHHANG K, CHITIETHOADONBAN C, NHANVIEN N WHERE H.TRANGTHAI='1' AND H.MAKH = K.MAKH AND H.MAHDB = C.MAHDB AND H.MANV = N.MANV AND YEAR(H.NGAYLAP) = '" + cboNam.Text + "' GROUP BY H.NGAYLAP, K.TENKH, K.DIACHI, H.MAHDB, N.HOTENNV,H.TONGTIEN ");            
            }
         
        }

        private void radKhoangTG_CheckedChanged(object sender, EventArgs e)
        {
            cboTuNam.Enabled = true;
            cboDenNam.Enabled = true;
            cboNam.Enabled = false;
        }
    }
}
