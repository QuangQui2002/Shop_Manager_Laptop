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
    public partial class frmKichThuocSanPham : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmKichThuocSanPham()
        {
            InitializeComponent();
            xulybutton(true);
            xulytextbox(true);
        }
        void xulytextbox(Boolean t)
        {
            txtMaSize.ReadOnly = t;
            txtTenSize.ReadOnly = t;
            cboTrangThai.Enabled = !t;                    

        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        
        DataSet ds = new DataSet();

        int vt = 0;
        int flag = 0;
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaSize.Text = dt.Rows[vt][0].ToString();
            txtTenSize.Text = dt.Rows[vt]["TENSIZE"].ToString();

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;

        }
        private void frmSizeSanPham_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachSizeSP, "select * from KICHTHUOC");
            //hienthitextbox(ds.Tables[0], vt);

            f = true;
        }

        private void dgvDanhSachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachSizeSP.CurrentCell.RowIndex;
            hienthitextbox(ds.Tables[0], vt);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);          
            txtMaSize.Text = Maphatsinh(ds);

            txtTenSize.Text = "";
            txtMaSize.Enabled = false;

            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";

            dgvDanhSachSizeSP.Enabled = false;

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
            txtMaSize.ReadOnly = true;
            xulybutton(false);
            flag = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            dgvDanhSachSizeSP.Enabled = true;

            if (flag == 1)
            {
                
                sql = "INSERT INTO KICHTHUOC VALUES('" + txtMaSize.Text + "','" + txtTenSize.Text +  "','" + cboTrangThai.SelectedIndex + "')";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", " Thông báo ");
                    frmSizeSanPham_Load(sender, e);
                }
            }
            if (flag == 3)
            {
                sql = "update KICHTHUOC set TENSIZE = N'" + txtTenSize.Text + "',TRANGTHAI='" + cboTrangThai.SelectedIndex + "'where MASIZE='" + txtMaSize.Text + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", " Thông báo ");
                    frmSizeSanPham_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                sql = "UPDATE KICHTHUOC SET TRANGTHAI='0' where MASIZE='" + txtMaSize.Text + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", " Thông báo ");
                    frmSizeSanPham_Load(sender, e);

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

            dgvDanhSachSizeSP.Enabled = true;
        }
        string Maphatsinh(DataSet ds)
        {
            String MaSize = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaSize = "S00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaSize = "S0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaSize;
        }

        private void frmKichThuocSanPham_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = "update KICHTHUOC set " +
                        "TENSIZE=N'" + dgvDanhSachSizeSP.CurrentRow.Cells[1].Value.ToString() +
                        "',TRANGTHAI='" + dgvDanhSachSizeSP.CurrentRow.Cells[2].Value.ToString() +
                        "' where MASIZE='" + dgvDanhSachSizeSP.CurrentRow.Cells[0].Value.ToString() + "'";
                MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    frmSizeSanPham_Load(sender, e);
                }

            }
        }
    }
}
