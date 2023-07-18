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
    public partial class frmNhanVien : Form
    {
        clsCuaHangLapTop c =new clsCuaHangLapTop();
        public frmNhanVien()
        {
            InitializeComponent();
            xulybutton(true);
            xulytextbox(true);
        }

        public string macv;

        int vt = 0;
        void xulytextbox(Boolean t)
        {
            txtMaNV.ReadOnly = t;
            txtTenNV.ReadOnly = t;
            txtDiaChi.ReadOnly = t;
            mtbDienThoai.ReadOnly = t;
            txtEmail.ReadOnly = t;
            txtLuong.ReadOnly = t;
            txtSoTK.ReadOnly = t;
            txtTenNH.ReadOnly = t;
            cboChucVu.Enabled = !t;
            cboGioiTinh.Enabled = !t;
            cboTrangThai.Enabled = !t;
            dtpNgaySinh.Enabled = !t;
            dtpNgayVaoLam.Enabled = !t;
         


        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        DataSet ds=new DataSet();
        DataSet dscv = new DataSet();
        void LoadDuLieu_datagrid(DataGridView d,string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }
        void LoadDuLieu_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        {
            ds = c.LayDuLieu(sql);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbo.DataSource = ds.Tables[0];
                cbo.ValueMember = valMember;
                cbo.DisplayMember = disMember;
            }
        }
        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaNV.Text = dt.Rows[vt][0].ToString();
            txtTenNV.Text = dt.Rows[vt]["HOTENNV"].ToString();
            cboGioiTinh.Text = dt.Rows[vt]["GIOITINH"].ToString();
            dtpNgaySinh.Text = dt.Rows[vt]["NGAYSINH"].ToString();
            txtDiaChi.Text = dt.Rows[vt]["DIACHI"].ToString();
            mtbDienThoai.Text = dt.Rows[vt]["DIENTHOAI"].ToString();
            txtEmail.Text = dt.Rows[vt]["EMAIL"].ToString();
            
            dtpNgayVaoLam.Text = dt.Rows[vt]["NGAYVAOLAM"].ToString();
            txtTenNH.Text = dt.Rows[vt]["TENNH"].ToString();
            txtSoTK.Text = dt.Rows[vt]["SOTK"].ToString();
            txtLuong.Text = dt.Rows[vt]["LUONG"].ToString();
            //Hien Thi
            string MaCV;
            MaCV = dt.Rows[vt]["CHUCVU"].ToString();
            DataView dvChucVu = new DataView();
            dvChucVu.Table = dscv.Tables[0];
            cboChucVu.DataSource = dvChucVu;
            cboChucVu.DisplayMember = "TENCV";
            cboChucVu.ValueMember = "MACV";
            dvChucVu.RowFilter = "MACV='" + MaCV + "'";

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;

        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachNV, "select * from NHANVIEN");
            
            dscv = c.LayDuLieu("select * from CHUCVU");
            hienthicombobox(dscv, cboChucVu, "MACV", "TENCV");
            //hienthitextbox(ds.Tables[0], vt);
           
            f = true;
        }

        private void cboChucVuNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            hienthicombobox(dscv, cboChucVu, "MACV", "TENCV");
            txtMaNV.Text = Maphatsinh(ds);
            txtMaNV.Enabled = false;
          
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            mtbDienThoai.Text = "";
            txtEmail.Text = "";
            txtLuong.Text = "";
            txtSoTK.Text = "";
            txtTenNH.Text = "";
           
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";     
            dtpNgayVaoLam.Value = DateTime.Now;

            dgvDanhSachNV.Enabled = false;

            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);

            flag = 2;
        }

        int TimViTri(DataSet ds, string ma)
        {

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["MACV"].ToString() == ma)
                    return i;
            }
            return -1;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            hienthicombobox(dscv, cboChucVu, "MACV", "TENCV");
            string temp = dgvDanhSachNV.CurrentRow.Cells["ChucVu"].Value.ToString();
            cboChucVu.SelectedIndex = TimViTri(dscv, temp );
        
          
            txtMaNV.ReadOnly = true;

            xulybutton(false);
            flag = 3;
        }
        int flag = 0;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            dgvDanhSachNV.Enabled = true;

            string sql = "";
            if (flag == 1)
            {
                sql = "INSERT INTO NHANVIEN VALUES('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + cboGioiTinh.Text + "','" + dtpNgaySinh.Text + "',N'" + txtDiaChi.Text + "','" + mtbDienThoai.Text + "','" + txtEmail.Text + "',N'" + cboChucVu.SelectedValue + "','" + dtpNgayVaoLam.Text + "','" + txtTenNH.Text + "','" + txtSoTK.Text + "','" + txtLuong.Text + "','" + cboTrangThai.SelectedIndex.ToString() + "')";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", " Thông báo ");
                    frmNhanVien_Load(sender, e);
                }
            }
            if (flag == 3)
            {
               
                sql = "update NHANVIEN set HOTENNV = N'"+txtTenNV.Text+"', GIOITINH = N'"+ cboGioiTinh.Text 
                    +"', NGAYSINH = '"+dtpNgaySinh.Text+"', DIACHI = N'"+txtDiaChi.Text+"', DIENTHOAI = '"+mtbDienThoai.Text
                    +"', EMAIL = '"+txtEmail.Text+"', CHUCVU = N'"+cboChucVu.SelectedValue.ToString() + "', NGAYVAOLAM = '"+dtpNgayVaoLam.Text
                    +"', TENNH = '"+txtTenNH.Text+"', SOTK = '"+txtSoTK.Text+"', LUONG = '"+txtLuong.Text
                    +"', TRANGTHAI = '"+cboTrangThai.SelectedIndex + "' where MANV='" + txtMaNV.Text + "'";

                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmNhanVien_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                if (cboTrangThai.SelectedIndex == 1)
                {
                    sql = "UPDATE  NHANVIEN SET TRANGTHAI='0' where MANV='" + txtMaNV.Text + "'";
                    //MessageBox.Show(sql);
                    if (c.CapNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                        frmNhanVien_Load(sender, e);

                    }
                }
                else
                {
                    MessageBox.Show("Nhân viên đã được xóa trước đó", "Thông báo");
                }
            }
            flag = 0;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachNV.CurrentCell.RowIndex;
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

            dgvDanhSachNV.Enabled = true;
        }
        string Maphatsinh(DataSet ds)
        {
            String MaNV = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaNV = "NV00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaNV = "NV0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaNV;
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool f = false;
        private void dgvDanhSachNV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 12)
            {
                sql = "update NHANVIEN set " +
                        "HOTENNV=N'" + dgvDanhSachNV.CurrentRow.Cells[1].Value.ToString() +
                        "',GIOITINH=N'" + dgvDanhSachNV.CurrentRow.Cells[2].Value.ToString() +
                        "',NGAYSINH='" + dgvDanhSachNV.CurrentRow.Cells[3].Value.ToString() +
                        "',DIACHI=N'" + dgvDanhSachNV.CurrentRow.Cells[4].Value.ToString() +
                        "',DIENTHOAI='" + dgvDanhSachNV.CurrentRow.Cells[5].Value.ToString() +
                        "',EMAIL='" + dgvDanhSachNV.CurrentRow.Cells[6].Value.ToString() +
                        "',CHUCVU='" + dgvDanhSachNV.CurrentRow.Cells[7].Value.ToString() +
                        "',NGAYVAOLAM='" + dgvDanhSachNV.CurrentRow.Cells[8].Value.ToString() +
                        "',TENNH='" + dgvDanhSachNV.CurrentRow.Cells[9].Value.ToString() +
                        "',SOTK='" + dgvDanhSachNV.CurrentRow.Cells[10].Value.ToString() +
                        "',LUONG = '" + dgvDanhSachNV.CurrentRow.Cells[11].Value.ToString() +
                        "',TrangThai='" + dgvDanhSachNV.CurrentRow.Cells[12].Value.ToString() +
                        "' where MANV='" + dgvDanhSachNV.CurrentRow.Cells[0].Value.ToString() + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    frmNhanVien_Load(sender, e);
                }

            }
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
                e.Handled = true;

        }

        private void mtbDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
