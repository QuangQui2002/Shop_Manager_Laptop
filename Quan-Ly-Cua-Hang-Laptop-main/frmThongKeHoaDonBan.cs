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
    public partial class frmThongKeHoaDonBan : Form
    {
        public frmThongKeHoaDonBan()
        {
            InitializeComponent();
        }

        clsCuaHangLapTop c = new clsCuaHangLapTop();

        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        private void txtTuTim_TextChanged(object sender, EventArgs e)
        {
            if (txtTuTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm", "Thông báo");
            }

            if (cboCachTK.Text == "Tổng Tiền Hóa Đơn Khách Hàng Mua")
            {
                LoadDuLieu_datagrid(dgvHoaDonTK, "SELECT K.MAKH 'Mã Khách Hàng', TENKH 'Tên Khách Hàng' , MAHDB 'Mã Hóa Đơn Bán', TONGTIEN 'Tổng Tiền' FROM KHACHHANG k, HOADONBAN h WHERE K.MAKH = h.MAKH AND k.MAKH Like N'%" + txtTuTK.Text + "%'");
            }
            if (cboCachTK.Text == "Sản Phẩm Khách Hàng Mua")
            {
                LoadDuLieu_datagrid(dgvHoaDonTK, "SELECT C.MASP 'Mã Sản Phẩm', S.TENSP 'Tên Sản Phẩm', C.SOLUONG 'Số Lượng', THANHTIEN 'Thành Tiền' FROM CHITIETHOADONBAN C, HOADONBAN H, SANPHAM S WHERE C.MAHDB = H.MAHDB AND S.MASP = C.MASP AND h.MAKH Like N'%" + txtTuTK.Text + "%'");
            }
            if (cboCachTK.Text == "Tổng Tiền Khách Hàng Mua")
            {
                LoadDuLieu_datagrid(dgvHoaDonTK, "SELECT K.MAKH 'Mã Khách Hàng', TENKH 'Tên Khách Hàng' ,SUM(TONGTIEN) 'TỔNG TIỀN' FROM KHACHHANG k, HOADONBAN h WHERE K.MAKH = h.MAKH AND k.MAKH Like N'%" + txtTuTK.Text + "%' GROUP BY K.MAKH, K.TENKH");
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {           
            txtTuTim_TextChanged(sender, e);
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {

            LoadDuLieu_datagrid(dgvHoaDonTK, "select * from HOADONBAN ");
        }
    }
}
