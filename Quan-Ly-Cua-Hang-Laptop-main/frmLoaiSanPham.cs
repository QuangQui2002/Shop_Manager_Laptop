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
    public partial class frmLoaiSanPham : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        int flag = 0;
        public frmLoaiSanPham()
        {
            InitializeComponent();
            xulybutton(true);
            xulytextbox(true);
        }
        void xulytextbox(Boolean t)
        {
            txtTenLoai.ReadOnly = t;
           
            cboTrangThai.Enabled =! t;
           
            txtMaLoai.ReadOnly = t;

        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        int vt = 0;
        DataSet ds = new DataSet();
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaLoai.Text = dt.Rows[vt][0].ToString();
            txtTenLoai.Text = dt.Rows[vt]["TENLOAI"].ToString();
            cboTrangThai.Text = dt.Rows[vt]["TRANGTHAI"].ToString();

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;

        }
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachLoaiSP, "select * from LOAISP");
            //hienthitextbox(ds.Tables[0], vt);

            f = true;
        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachLoaiSP.CurrentCell.RowIndex;
            hienthitextbox(ds.Tables[0], vt);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
           
            txtMaLoai.Text = Maphatsinh(ds);
            txtMaLoai.Enabled = false;
            txtTenLoai.Text = "";

            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";

            dgvDanhSachLoaiSP.Enabled = false;

            flag = 1;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 2;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            xulytextbox(false);

            txtMaLoai.ReadOnly = true;
            xulybutton(false);
            flag = 3;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            dgvDanhSachLoaiSP.Enabled = true;

            if (flag == 1)
            {
                sql = "INSERT INTO LOAISP VALUES('" + txtMaLoai.Text + "','" + txtTenLoai.Text +"','" + cboTrangThai.Text + "')";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật  dữ liệu thành công", "Thông báo");
                    frmLoaiSanPham_Load(sender, e);
                }
            }
            if (flag == 3)
            {
                sql = "update LOAISP set TRANGTHAI='" + cboTrangThai.Text + "'where MALOAI='" + txtMaLoai.Text + "'";


                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công" , "Thông báo");
                    frmLoaiSanPham_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                sql = "UPDATE LOAISP SET TRANGTHAI='0' where MALOAI='" + txtMaLoai.Text + "'";
               
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    frmLoaiSanPham_Load(sender, e);

                }
            }
            //txtMaloaiSP.ReadOnly = true;
            flag = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulytextbox(true);
            xulybutton(true);

            dgvDanhSachLoaiSP.Enabled = true;
        }
        string Maphatsinh(DataSet ds)
        {
            String MaLoai = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaLoai = "L00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaLoai = "L0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaLoai;
        }

        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }
        bool f = false;
        private void dgvDanhSachSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 2)
            {
                sql = "update LOAISP set " +
                        "TENLOAI=N'" + dgvDanhSachLoaiSP.CurrentRow.Cells[1].Value.ToString() +
                        "',TRANGTHAI='" + dgvDanhSachLoaiSP.CurrentRow.Cells[2].Value.ToString() +
                        "' where MALOAI='" + dgvDanhSachLoaiSP.CurrentRow.Cells[0].Value.ToString() + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    frmLoaiSanPham_Load(sender, e);
                }

            }
        }
    }
}
