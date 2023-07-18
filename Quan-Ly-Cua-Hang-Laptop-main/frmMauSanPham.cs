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
    public partial class frmMauSanPham : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        int flag = 0;
        public frmMauSanPham()
        {
            InitializeComponent();
            xulybutton(true);
            xulytextbox(true);
        }
        void xulytextbox(Boolean t)
        {
            txtMaMau.ReadOnly = t;

            cboTrangThai.Enabled = !t;

            txtTenMau.ReadOnly = t;

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
            txtMaMau.Text = dt.Rows[vt][0].ToString();
            txtTenMau.Text = dt.Rows[vt]["TENMAU"].ToString();

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;

        }

        private void frmMauSanPham_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachMauSP, "select * from MAUSP");
            //hienthitextbox(ds.Tables[0], vt);

            f = true;
        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachMauSP.CurrentCell.RowIndex;
            hienthitextbox(ds.Tables[0], vt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);

            txtMaMau.Text = Maphatsinh(ds);

            txtMaMau.Enabled = false;

            txtTenMau.Text = "";
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";
            dgvDanhSachMauSP.Enabled = false;

            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulytextbox(false);

            txtMaMau.ReadOnly = true;
            xulybutton(false);
            flag = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            dgvDanhSachMauSP.Enabled = true;

            if (flag == 1)
            {
                sql = "INSERT INTO MAUSP VALUES('" + txtMaMau.Text + "',N'" + txtTenMau.Text + "',N'" + cboTrangThai.SelectedIndex + "')";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    frmMauSanPham_Load(sender, e);
                }
            }
            if (flag == 3)
            {
                sql = "update MAUSP set TENMAU =N'" + txtTenMau.Text + "',TRANGTHAI='" + cboTrangThai.SelectedIndex + "'where MAMAU='" + txtMaMau.Text + "'";


                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmMauSanPham_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                sql = "UPDATE MAUSP SET TRANGTHAI='0' where MAMAU='" + txtMaMau.Text + "'";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    frmMauSanPham_Load(sender, e);

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

            dgvDanhSachMauSP.Enabled = true;
        }
        string Maphatsinh(DataSet ds)
        {
            String MaMau = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaMau = "M00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaMau = "M0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaMau;
        }

        private void frmMauSanPham_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = "update MAUSP set " +
                    "TENMAU=N'" + dgvDanhSachMauSP.CurrentRow.Cells[1].Value.ToString() +
                    "',TRANGTHAI='" + dgvDanhSachMauSP.CurrentRow.Cells[2].Value.ToString() +
                    "' where MAMAU='" + dgvDanhSachMauSP.CurrentRow.Cells[0].Value.ToString() + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    frmMauSanPham_Load(sender, e);
                }



            }
        }
    }
}
