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
    public partial class frmHangSX : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmHangSX()
        {
            InitializeComponent();
            xulytextbox(true);
            xulybutton(true);
        }

        DataSet ds = new DataSet();
        int flag = 1;
        int vt = 0;

        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void xulytextbox(Boolean t)
        {
            txtMaHangSX.ReadOnly = t;
            txtTenHangSX.ReadOnly = t;
            cboTrangThai.Enabled = !t;
        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }

        private void frmHangSX_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachHangSX, "select * from HANGSX");
            //hienthitextbox(ds.Tables[0], vt);

            f = true;
        }

        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaHangSX.Text = dt.Rows[vt][0].ToString();
            txtTenHangSX.Text = dt.Rows[vt]["TENHANGSX"].ToString();
            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;
        }

        private void dgvDSHangSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachHangSX.CurrentCell.RowIndex;
            hienthitextbox(ds.Tables[0], vt);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        string Maphatsinh(DataSet ds)
        {
            String MaHangSX = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaHangSX = "H00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaHangSX = "H0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaHangSX;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            txtMaHangSX.Text = Maphatsinh(ds);
            txtMaHangSX.Enabled = false;

            txtTenHangSX.Text = "";
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";

            flag = 1;
            dgvDanhSachHangSX.Enabled = false;

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
            txtMaHangSX.ReadOnly = true;
            xulybutton(false);
            flag = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);

            dgvDanhSachHangSX.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            dgvDanhSachHangSX.Enabled = true;

            if (flag == 1)
            {

                sql = "INSERT INTO HANGSX VALUES('" + txtMaHangSX.Text + "',N'" + txtTenHangSX.Text + "',N'" + cboTrangThai.SelectedIndex + "')";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    frmHangSX_Load(sender, e);
                }
            }

            if (flag == 3)
            {
                sql = "update HANGSX set TENHANGSX = N'" + txtTenHangSX.Text + "', TRANGTHAI ='" + cboTrangThai.SelectedIndex + "' where MAHANGSX = '" + txtMaHangSX.Text + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmHangSX_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                sql = "UPDATE HANGSX SET TRANGTHAI='0' where MAHANGSX='" + txtMaHangSX.Text + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    frmHangSX_Load(sender, e);

                }
            }
            flag = 0;
        }
        bool f = false;
        private void dgvDSHangSX_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 2)
            {
                sql = "update HANGSX set " +
                        "TENHANGSX=N'" + dgvDanhSachHangSX.CurrentRow.Cells[1].Value.ToString() +
                        "',TRANGTHAI='" + dgvDanhSachHangSX.CurrentRow.Cells[2].Value.ToString() +
                        "' where MAHANGSX='" + dgvDanhSachHangSX.CurrentRow.Cells[0].Value.ToString() + "'";
                MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    frmHangSX_Load(sender, e);
                }

            }
        }
    }
}
