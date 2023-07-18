using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _174_182_QLCHLAPTOP
{
    public partial class frmDangNhap : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void picNenTren_Click(object sender, EventArgs e)
        {

        }


        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgThoat;
            dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgThoat == DialogResult.No)                                                
                e.Cancel = true;
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /// LAPTOP-I13TGSE2\SQLEXPRESS
            //  DESKTOP-U8EOD4B\SQLEXPRESS
            SqlConnection conn = new SqlConnection(@"Data source= LAPTOP-I13TGSE2\SQLEXPRESS;Initial Catalog= QUANLYCUAHANGLAPTOP;integrated Security =True");
            try
            {
                conn.Open();
                string tatkhoan = txtTaiKhoan.Text;
                string matkhau = txtMatKhau.Text;
                string sql = "select * from DANGNHAP where TAIKHOAN = '" + tatkhoan + "' and MATKHAU = '" + matkhau + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader(); // đọc dữ liệu có tuần tự
                if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtMatKhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (data.Read() == true) // đọc 1 hàm trong bản ghi
                    {
                        frmGiaoDienChinh f = new frmGiaoDienChinh();
                        f.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai tên hoặc mật khẩu", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void lkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKi f = new frmDangKi();
            f.Show();
            this.Hide();
        }

        private void lkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.Show();
            this.Hide();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtMatKhau_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                /// LAPTOP-I13TGSE2\SQLEXPRESS
                //  DESKTOP-U8EOD4B\SQLEXPRESS
                SqlConnection conn = new SqlConnection(@"Data source= DESKTOP-U8EOD4B\SQLEXPRESS;Initial Catalog= QUANLYCUAHANGLAPTOP;integrated Security =True");
                try
                {
                    conn.Open();
                    string tatkhoan = txtTaiKhoan.Text;
                    string matkhau = txtMatKhau.Text;
                    string sql = "select * from DANGNHAP where TAIKHOAN = '" + tatkhoan + "' and MATKHAU = '" + matkhau + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader data = cmd.ExecuteReader(); // đọc dữ liệu có tuần tự
                    if (txtTaiKhoan.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo");
                    }
                    else if (txtMatKhau.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo");
                    }
                    else
                    {
                        if (data.Read() == true) // đọc 1 hàm trong bản ghi
                        {
                            frmGiaoDienChinh f = new frmGiaoDienChinh();
                            f.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Bạn đã nhập sai tên hoặc mật khẩu", "Thông báo");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lkQuenMK_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.Show();
            this.Hide();
        }

        private void lkDangKy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKi f = new frmDangKi();
            f.Show();
            this.Hide();
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau f = new frmQuenMatKhau();
            f.Show();
            this.Hide();
        }
    }
}
