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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            DataSet ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            cboCachTim.Text = "Mã Nhân Viên";
            LoadDuLieu_datagrid(dgvDanhSachNV, "select MANV, HOTENNV, GIOITINH, c.TENCV, NGAYSINH, DIACHI, DIENTHOAI, EMAIL, NGAYVAOLAM, TENNH, SOTK, LUONG, n.TRANGTHAI from NHANVIEN n, CHUCVU c where n.CHUCVU = c.MACV");
        }


        private void txtTuTim_TextChanged(object sender, EventArgs e)
        {
            if(cboCachTim.Text == "Mã Nhân Viên")
            {
                LoadDuLieu_datagrid(dgvDanhSachNV, "select MANV, HOTENNV, GIOITINH, c.TENCV, NGAYSINH, DIACHI, DIENTHOAI, EMAIL, NGAYVAOLAM, TENNH, SOTK, LUONG, n.TRANGTHAI from NHANVIEN n, CHUCVU c where n.CHUCVU = c.MACV and MANV like N'%" + txtTuTim.Text + "%'");
            }
            if(cboCachTim.Text == "Tên Nhân Viên")
            {
                LoadDuLieu_datagrid(dgvDanhSachNV, "select MANV, HOTENNV, GIOITINH, c.TENCV, NGAYSINH, DIACHI, DIENTHOAI, EMAIL, NGAYVAOLAM, TENNH, SOTK, LUONG, n.TRANGTHAI from NHANVIEN n, CHUCVU c where n.CHUCVU = c.MACV and HOTENNV like N'%" + txtTuTim.Text + "%'");
            }

            if (cboCachTim.Text == "Chức Vụ")
            {
                LoadDuLieu_datagrid(dgvDanhSachNV, "select MANV, HOTENNV, GIOITINH, c.TENCV, NGAYSINH, DIACHI, DIENTHOAI, EMAIL, NGAYVAOLAM, TENNH, SOTK, LUONG, n.TRANGTHAI from NHANVIEN n, CHUCVU c where n.CHUCVU = c.MACV and TENCV like N'%" + txtTuTim.Text + "%'");
            }

            if (cboCachTim.Text == "Số Điện Thoại")
            {
                LoadDuLieu_datagrid(dgvDanhSachNV, "select MANV, HOTENNV, GIOITINH, c.TENCV, NGAYSINH, DIACHI, DIENTHOAI, EMAIL, NGAYVAOLAM, TENNH, SOTK, LUONG, n.TRANGTHAI from NHANVIEN n, CHUCVU c where n.CHUCVU = c.MACV and DIENTHOAI like N'%" + txtTuTim.Text + "%'");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTuTim.Text = "";
            LoadDuLieu_datagrid(dgvDanhSachNV, "select MANV, HOTENNV, GIOITINH, c.TENCV, NGAYSINH, DIACHI, DIENTHOAI, EMAIL, NGAYVAOLAM, TENNH, SOTK, LUONG, n.TRANGTHAI from NHANVIEN n, CHUCVU c where n.CHUCVU = c.MACV");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTuTim.Text == "") 
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm", "Thông báo");
            }
            txtTuTim_TextChanged(sender, e);
        }
    }
}
