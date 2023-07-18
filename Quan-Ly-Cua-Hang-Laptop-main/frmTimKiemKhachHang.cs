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
    public partial class frmTimKiemKhachHang : Form
    {
        public frmTimKiemKhachHang()
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
            if(cboCachTim.Text =="Mã Khách Hàng")
            {
                LoadDuLieu_datagrid(dgvDanhSachKH, "select * from  KHACHHANG where MAKH Like N'%" + txtTuTim.Text + "%'");

            }
            if (cboCachTim.Text == "Tên Khách Hàng")
            {
                LoadDuLieu_datagrid(dgvDanhSachKH, "select * from  KHACHHANG where TENKH Like N'%" + txtTuTim.Text + "%'");

            }
            if (cboCachTim.Text == "Số Điện Thoại")
            {
                LoadDuLieu_datagrid(dgvDanhSachKH, "select * from  KHACHHANG where DIENTHOAI Like N'%" + txtTuTim.Text + "%'");

            }

        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            cboCachTim.Text = "Mã Khách Hàng";
            LoadDuLieu_datagrid(dgvDanhSachKH, "select * from  KHACHHANG ");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTuTim.Text = "";
            LoadDuLieu_datagrid(dgvDanhSachKH, "select * from  KHACHHANG ");

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
