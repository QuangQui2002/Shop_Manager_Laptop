using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace _174_182_QLCHLAPTOP
{
    public partial class frmKhachHang : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmKhachHang()
        {
            InitializeComponent();
            xulybutton(true);
            xulytextbox(true);

        }

        public string makh, tenkh, dienthoai;
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds= c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        int vt = 0;
        void xulytextbox(Boolean t)
        {
            txtMaKH.ReadOnly = t;
            txtTenKH.ReadOnly = t;
            txtDiaChi.ReadOnly = t;
            mtbDienThoai.ReadOnly = t;
            txtEmail.ReadOnly = t;
            cboTrangThai.Enabled = !t;
        }
        DataSet ds = new DataSet();
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                e.Handled = true;
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void mtbDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachKH, "select * from KHACHHANG");
            //hienthitextbox(ds.Tables[0], vt);

            f = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            
            txtMaKH.Text = Maphatsinh(ds);
            txtMaKH.Enabled = false;

            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            mtbDienThoai.Text = "";
            txtEmail.Text = "";
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";

            dgvDanhSachKH.Enabled = false;



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
            txtMaKH.ReadOnly = true;           
            xulybutton(false);
            flag = 3;
        }
        int flag = 0;
        bool kt_sdt(string sdt)
        {
            string sodau = sdt.Substring(0, 2);
            if (sodau == "03" || sodau == "05" || sodau == "07" || sodau == "08" || sodau == "09")
            {
                if (sdt.Length == 10)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            dgvDanhSachKH.Enabled = true;

            if (flag == 1)
            {
                
                sql = "INSERT INTO KHACHHANG VALUES('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + txtDiaChi.Text + "','" + mtbDienThoai.Text + "','" + txtEmail.Text + "',N'" + cboTrangThai.SelectedIndex + "')";
                MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    makh = txtMaKH.Text;
                    tenkh = txtTenKH.Text;
                    dienthoai = mtbDienThoai.Text;
                    frmKhachHang_Load(sender, e);
                }
            }
            if (flag == 3)
            {
               
                sql = "update KHACHHANG set TENKH = N'"+ txtTenKH.Text + "', DIACHI = N'" +txtDiaChi.Text + "', DIENTHOAI = '" +mtbDienThoai.Text +"', EMAIL ='" + txtEmail.Text + "', TRANGTHAI ='"+ cboTrangThai.SelectedIndex + "'where MAKH = '"+txtMaKH.Text+"'";
                MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmKhachHang_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                if (cboTrangThai.SelectedIndex == 1)
                {
                    sql = "UPDATE  KHACHHANG SET TRANGTHAI='0' where MAKH='" + txtMaKH.Text + "'";
                    MessageBox.Show(sql);
                    if (c.CapNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                        frmKhachHang_Load(sender, e);

                    }
                }
                else
                {
                    MessageBox.Show("Khách hàng đã được xóa trước đó", "Thông báo");
                }
            }
            flag = 0;
        }
        void hienthitextbox(DataTable dt,int vt)
        {
            txtMaKH.Text= dt.Rows[vt][0].ToString();
            txtTenKH.Text = dt.Rows[vt]["TENKH"].ToString();
            txtDiaChi.Text = dt.Rows[vt]["DIACHI"].ToString();
            mtbDienThoai.Text = dt.Rows[vt]["DIENTHOAI"].ToString();
            txtEmail.Text = dt.Rows[vt]["EMAIL"].ToString();
            txtDiaChi.Text = dt.Rows[vt]["DIACHI"].ToString();

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;
        }
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachKH.CurrentCell.RowIndex;
            hienthitextbox(ds.Tables[0], vt);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);

            dgvDanhSachKH.Enabled = true;
        }

        private void mtbDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                if (kt_sdt(mtbDienThoai.Text) == true)
                {
                    MessageBox.Show("Số điện thoại hợp lệ!");
                }
                else
                {
                    MessageBox.Show("sdt kh hop le");
                    mtbDienThoai.Text = "";
                    mtbDienThoai.Focus();
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isEmail(txtEmail.Text))
                {
                    //MessageBox.Show("HỢP LỆ");
                }
                else
                {
                    MessageBox.Show("KHÔNG HỢP LỆ");
                    txtEmail.Text = "";
                    txtEmail.Focus();
                }
            }
        }

        bool f = false;
        private void dgvDanhSachKH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 5)
            {
                sql = "update KHACHHANG set " +
                        "TENKH=N'" + dgvDanhSachKH.CurrentRow.Cells[1].Value.ToString() +
                        "',DIACHI=N'" + dgvDanhSachKH.CurrentRow.Cells[2].Value.ToString() +
                        "',DIENTHOAI='" + dgvDanhSachKH.CurrentRow.Cells[3].Value.ToString() +
                        "',EMAIL='" + dgvDanhSachKH.CurrentRow.Cells[4].Value.ToString() +
                        "',TRANGTHAI='" + dgvDanhSachKH.CurrentRow.Cells[5].Value.ToString() +
                        "' where MAKH='" + dgvDanhSachKH.CurrentRow.Cells[0].Value.ToString() + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    frmKhachHang_Load(sender, e);
                }

            }
        }

        string Maphatsinh(DataSet ds)
        {
            String MaKH = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaKH = "KH00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaKH = "KH0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaKH;
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }
    }
}
