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
    public partial class frmTimKiemHoaDonBan : Form
    {
        public frmTimKiemHoaDonBan()
        {
            InitializeComponent();
        }
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
        }

        private void cboCachTim_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                    LoadDuLieu_datagrid(dgvDanhSachHDB, "select MAHDB, TENKH, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONBAN H, KHACHHANG K, NHANVIEN N where H.MAKH = K.MAKH AND H.MANV = N.MANV AND NGAYLAP = '" + ngay + "' ");
                }
                catch
                {
                    MessageBox.Show("Thời gian không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void frmTimKiemHoaDon_Load(object sender, EventArgs e)
        {
            cboCachTim.Text = "Mã Hóa Đơn";
            LoadDuLieu_datagrid(dgvDanhSachHDB, "  select MAHDB, TENKH, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONBAN H, KHACHHANG K, NHANVIEN N  where H.MAKH = K.MAKH AND H.MANV = N.MANV");
            mtbNgay.Enabled = false;
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTuTim.Text = "";
            LoadDuLieu_datagrid(dgvDanhSachHDB, "  select MAHDB, TENKH, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONBAN H, KHACHHANG K, NHANVIEN N  where H.MAKH = K.MAKH AND H.MANV = N.MANV");

        }

        private void mtbNgay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cboCachTim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboCachTim.Text == "Ngày Lập Hóa Đơn")
            {
                txtTuTim.Enabled = false;
                mtbNgay.Enabled = true;
            }
            else {
                txtTuTim.Enabled = true;
                mtbNgay.Enabled = false;
            }
        }

        private void txtTuTim_TextChanged(object sender, EventArgs e)
        {
            if (cboCachTim.Text == "Mã Hóa Đơn")
            {
                LoadDuLieu_datagrid(dgvDanhSachHDB, "select MAHDB, TENKH, HOTENNV, NGAYLAP, TONGTIEN, H.TRANGTHAI from HOADONBAN H, KHACHHANG K, NHANVIEN N where H.MAKH = K.MAKH AND H.MANV = N.MANV AND MAHDB Like N'%" + txtTuTim.Text + "%'");
            }
        }
    }
}
