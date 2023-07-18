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
    public partial class frmTimKiemHoaDonNhap : Form
    {
        public frmTimKiemHoaDonNhap()
        {
            InitializeComponent();
        }
        clsCuaHangLapTop c = new clsCuaHangLapTop();

        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTuTim.Text = "";
            LoadDuLieu_datagrid(dgvDanhSachHDN, "select H.MAHDN, TENNCC, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONNHAP H, NHACUNGCAP N, NHANVIEN V where H.MANV = V.MANV AND N.MANCC = H.MANCC");

        }

        private void txtTuTim_TextChanged(object sender, EventArgs e)
        {
            if (cboCachTim.Text == "Mã Hóa Đơn")
            {
                LoadDuLieu_datagrid(dgvDanhSachHDN, "select H.MAHDN, TENNCC, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONNHAP H, NHACUNGCAP N, NHANVIEN V where H.MANV = V.MANV AND N.MANCC = H.MANCC AND MAHDN Like N'%" + txtTuTim.Text + "%'");
            }
            //if (cboCachTim.Text == "Ngày Lập Hóa Đơn")
            //{
            //    LoadDuLieu_datagrid(dgvDanhSachHDB, "  select * from  HOADONBAN,KHACHHANG,NHANVIEN where MAHDB Like N'%" + txtTuTim.Text + "%' AND HOADONBAN.MAKH=KHACHHANG.MAKH AND HOADONBAN.MANV=NHANVIEN.MANV");

            //}
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtTuTim_TextChanged(sender, e);
            if (txtTuTim.Text == "" && cboCachTim.Text == "Mã Hóa Đơn")
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm", "Thông báo");
            if (cboCachTim.Text == "Ngày Lập Hóa Đơn")
            {
                try
                {
                    DateTime ngay;
                    ngay = DateTime.ParseExact(mtbNgay.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    LoadDuLieu_datagrid(dgvDanhSachHDN, "select H.MAHDN, TENNCC, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONNHAP H, NHACUNGCAP N, NHANVIEN V where H.MANV = V.MANV AND N.MANCC = H.MANCC AND NGAYLAP = '" + ngay + "' ");
                }
                catch
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void frmTimKiemHoaDonNhap_Load(object sender, EventArgs e)
        {
            cboCachTim.Text = "Mã Hóa Đơn";
            LoadDuLieu_datagrid(dgvDanhSachHDN, "select H.MAHDN, TENNCC, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONNHAP H, NHACUNGCAP N, NHANVIEN V where H.MANV = V.MANV AND N.MANCC = H.MANCC");

        }

        private void cboCachTim_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCachTim.Text == "Ngày Lập Hóa Đơn")
            {
                txtTuTim.Enabled = false;
                mtbNgay.Enabled = true;
            }
            else
            {
                txtTuTim.Enabled = true;
                mtbNgay.Enabled = false;
            }
        }
    }
}
