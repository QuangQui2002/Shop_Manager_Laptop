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
    public partial class frmChucVu : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmChucVu()
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
            txtMaCV.ReadOnly = t;
            txtTenCV.ReadOnly = t;
            cboTrangThai.Enabled = !t;
        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }

        private void txtTenCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                e.Handled = true;
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachCV, "select * from CHUCVU");
            //hienthitextbox(ds.Tables[0], vt);

            f = true;
        }
        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaCV.Text = dt.Rows[vt][0].ToString();
            txtTenCV.Text = dt.Rows[vt]["TENCV"].ToString();
            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;
        }

        private void dgvDanhSachCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachCV.CurrentCell.RowIndex;
            hienthitextbox(ds.Tables[0], vt);
        }

        private void frmChucVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        string Maphatsinh(DataSet ds)
        {
            String MaKH = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaKH = "CV00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaKH = "CV0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaKH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            txtMaCV.Text = Maphatsinh(ds);
            txtMaCV.Enabled = false;

            txtTenCV.Text = "";
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";

            dgvDanhSachCV.Enabled = false;


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
            txtMaCV.ReadOnly = true;
            xulybutton(false);
            flag = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);
            dgvDanhSachCV.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            dgvDanhSachCV.Enabled = true;
            if (flag == 1)
            {

                sql = "INSERT INTO CHUCVU VALUES('" + txtMaCV.Text + "',N'" + txtTenCV.Text + "',N'" + cboTrangThai.SelectedIndex + "')";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    frmChucVu_Load(sender, e);
                }
            }
            
            if (flag == 3)
            {
                sql = "update CHUCVU set TENCV = N'" + txtTenCV.Text + "', TRANGTHAI ='" + cboTrangThai.SelectedIndex + "' where MACV = '" + txtMaCV.Text + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmChucVu_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                sql = "UPDATE CHUCVU SET TRANGTHAI='0' where MACV='" + txtMaCV.Text + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    frmChucVu_Load(sender, e);

                }
            }
            flag = 0;
        }

        bool f = false;
        private void dgvDanhSachCV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 2)
            {
                sql = "update CHUCVU set " +
                        "TENCV=N'" + dgvDanhSachCV.CurrentRow.Cells[1].Value.ToString() +
                        "',TRANGTHAI='" + dgvDanhSachCV.CurrentRow.Cells[2].Value.ToString() +
                        "' where MACV='" + dgvDanhSachCV.CurrentRow.Cells[0].Value.ToString() + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công","Thông báo");
                    frmChucVu_Load(sender, e);
                }

            }
        }

        private void dgvDanhSachCV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
