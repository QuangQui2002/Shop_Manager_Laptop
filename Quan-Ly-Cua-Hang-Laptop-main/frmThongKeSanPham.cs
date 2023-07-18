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
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataSet dsSanPham = new DataSet();
        string r="";
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }

        void hienthitextbox(DataTable dt, int vt)
        {
            string MaSP;
            MaSP = dt.Rows[vt]["MASP"].ToString();

            DataView dvSanPham = new DataView();
            dvSanPham.Table = dsSanPham.Tables[0];
            cboSanPham.DataSource = dvSanPham;
            cboSanPham.DisplayMember = "TENSP";
            cboSanPham.ValueMember = "MASP";
            dvSanPham.RowFilter = "MASP='" + MaSP + "'";

        }
        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            //LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP");

            dsSanPham = c.LayDuLieu("select * from SANPHAM");
            hienthicombobox(dsSanPham, cboSanPham, "MASP", "TENSP");
            lblDoanhThu.Text = "";
        }

        void kiemtrachuoi(string r)
        {
            r = tongdoanhthu();
          
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

        string tongdoanhthu()
        {

            int kq = 0;
            if (dgvDanhSachSP.Rows.Count == 0)
            {
                return kq.ToString();
            }
            for (int i = 0; i < dgvDanhSachSP.Rows.Count; i++)
            {

                int doanhthu = Convert.ToInt32(dgvDanhSachSP.Rows[i].Cells[4].Value.ToString());
                kq += doanhthu;

            }
            return kq.ToString();
        }

        string l="";
        void tongsoluong(string l)
        {
            l = tongsoluongsp();
           
            lblSoLuong.Text = l;
        }
        string tongsoluongsp()
        {

            int kq = 0;
            if (dgvDanhSachSP.Rows.Count == 0)
            {
                return kq.ToString();
            }
            for (int i = 0; i < dgvDanhSachSP.Rows.Count; i++)
            {

                int soluong = Convert.ToInt32(dgvDanhSachSP.Rows[i].Cells[2].Value.ToString());
                kq += soluong;

            }
            return kq.ToString();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

            LoadDuLieu_datagrid(dgvDanhSachSP, "SELECT H.MAHDB as 'Mã Hóa Đơn', K.TENKH 'Tên Khách Hàng',C.SOLUONG 'Số Lượng', H.NGAYLAP 'Ngày Mua', C.THANHTIEN 'Thành Tiền' FROM CHITIETHOADONBAN C, HOADONBAN H, SANPHAM S, KHACHHANG K WHERE C.MAHDB = H.MAHDB AND K.MAKH = h.MAKH AND S.MASP = C.MASP AND S.TRANGTHAI = '1' AND S.TENSP = '" + cboSanPham.Text + "' and year(h.NGAYLAP)='" + cboNam.Text + "'");
            tongsoluong(l);

            if (int.Parse(lblSoLuong.Text.ToString()) == 0)
            {
                lblDoanhThu.Text = "0";
            }
            else
            {
                kiemtrachuoi(r);

            }
        }
    }
}
