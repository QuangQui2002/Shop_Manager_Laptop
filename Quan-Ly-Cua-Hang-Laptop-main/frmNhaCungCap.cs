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
    public partial class frmNhaCungCap : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmNhaCungCap()
        {
            InitializeComponent();
            xulybutton(true);
            xulytextbox(true);
        }

        public string mancc, tenncc, dienthoai;
        void xulytextbox(Boolean t)
        {
            txtMaNCC.ReadOnly = t;
            txtTenNCC.ReadOnly = t;
            txtDienThoai.ReadOnly = t;
            txtDiaChi.ReadOnly = t;
            txtTenNH.ReadOnly = t;
            txtSoTK.ReadOnly = t;
            cboTrangThai.Enabled = !t;

        }
      
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        int vt = 0;
        DataSet dsNCC = new DataSet();
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            dsNCC = c.LayDuLieu(sql);
            d.DataSource = dsNCC.Tables[0];
        }
        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaNCC.Text = dt.Rows[vt][0].ToString();
            txtTenNCC.Text = dt.Rows[vt]["TENNCC"].ToString();
            txtDiaChi.Text = dt.Rows[vt]["DIACHI"].ToString();
            txtSoTK.Text = dt.Rows[vt]["SOTK"].ToString();
            txtTenNH.Text = dt.Rows[vt]["TENNH"].ToString();
            txtDienThoai.Text = dt.Rows[vt]["DIENTHOAI"].ToString();

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            
            txtMaNCC.Text = Maphatsinh(dsNCC);
            txtMaNCC.Enabled = false;

            txtTenNCC.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTenNH.Text = "";
            txtSoTK.Text = "";
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";

            dgvDanhSachNCC.Enabled = false;


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

            txtMaNCC.ReadOnly = true;
           
            xulybutton(false);
            flag = 3;
        }
        int flag = 0;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            dgvDanhSachNCC.Enabled = true;

            if (flag == 1)
            {
                sql = "INSERT INTO NHACUNGCAP VALUES('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "','" + txtDienThoai.Text + "','" + txtTenNH.Text + "','" + txtSoTK.Text + "',N'" + txtDiaChi.Text + "','" + cboTrangThai.SelectedIndex.ToString() + "')";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    frmNhaCungCap_Load(sender, e);
                }
            }
            if (flag == 3)
            {
                sql = "update NHACUNGCAP set TENNCC = N'"+txtTenNCC.Text+ "', DIENTHOAI ='"+txtDienThoai.Text+ "', TENNH=N'"+txtTenNH.Text+ "', SOTK ='"+txtSoTK.Text+ "', DIACHI =N'"+txtDiaChi.Text+"',TRANGTHAI=N'" + cboTrangThai.SelectedIndex + "' where MANCC= '"+ txtMaNCC.Text + "'";


                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmNhaCungCap_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                sql = "update  NHACUNGCAP set TRANGTHAI='0' where MANCC='" + txtMaNCC.Text + "'";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    frmNhaCungCap_Load(sender, e);

                }
            }
            flag = 0;
        }
     
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachNCC, "select * from NHACUNGCAP");
            //hienthitextbox(dsNCC.Tables[0], vt);
            f = true;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);

            dgvDanhSachNCC.Enabled = true;
        }

        private void dgvDanhSachNCC_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachNCC.CurrentCell.RowIndex;
            hienthitextbox(dsNCC.Tables[0], vt);
            
        }

        bool f = false;
        private void dgvDanhSachNCC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 6)
            { 
                sql = "update NHACUNGCAP set " +
                        "TENNCC=N'" + dgvDanhSachNCC.CurrentRow.Cells[1].Value.ToString() +
                        "',DIENTHOAI='" + dgvDanhSachNCC.CurrentRow.Cells[2].Value.ToString() +
                        "',TENNH='" + dgvDanhSachNCC.CurrentRow.Cells[3].Value.ToString() +
                        "',SOTK='" + dgvDanhSachNCC.CurrentRow.Cells[4].Value.ToString() +
                        "',DIACHI=N'" + dgvDanhSachNCC.CurrentRow.Cells[5].Value.ToString() +
                        "',TRANGTHAI='" + dgvDanhSachNCC.CurrentRow.Cells[6].Value.ToString() +
                        "' where MANCC='" + dgvDanhSachNCC.CurrentRow.Cells[0].Value.ToString() + "'";
                MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    frmNhaCungCap_Load(sender, e);
                }

            }
        }

        string Maphatsinh(DataSet dsNCC)
        {
            String MaNCC = "";
            if (dsNCC.Tables[0].Rows.Count < 9)
            {
                MaNCC = "NCC0" + (dsNCC.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaNCC = "NCC" + (dsNCC.Tables[0].Rows.Count + 1).ToString();
            return MaNCC;
        }

        private void frmNhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }
    }
}
