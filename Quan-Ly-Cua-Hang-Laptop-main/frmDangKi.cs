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
using System.Data.SqlClient;

namespace _174_182_QLCHLAPTOP
{     

    public partial class frmDangKi : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmDangKi()
        {
            InitializeComponent();
        }

        public bool checkAccount(string ac)// Check tên tài khoản và mật khẩu 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{1,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9]{1,50}@gmail.com$"); 
        }
        private void btnDangki_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = (@"Data source= DESKTOP-U8EOD4B\SQLEXPRESS;Initial Catalog= QUANLYCUAHANGLAPTOP;integrated Security =True");

            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string xnmk = txtXacNhanMK.Text;
            string email = txtEmail.Text;
            string sql = "";

            if (!checkAccount(tentk))
            { MessageBox.Show("Vui lòng nhập tên khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa, chữ thường !", "Thông báo"); }
            else if (!checkAccount(matkhau))
            { MessageBox.Show("Vui lòng nhập tên mật khẩu dài 3-20 ký tự, với các ký tự chữ và số, chữ hoa, chữ thường ", "Thông báo" ); }
            else if(xnmk != matkhau)
            { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!", "Thông báo"); }
            else if(!checkEmail(email))
            { MessageBox.Show("Vui lòng đúng định dạng email ", "Thông báo"); }
            else try
            {

                SqlCommand cmd = new SqlCommand(sql, conn);
                sql = "INSERT INTO DANGNHAP VALUES ('" + tentk+"','" + matkhau + "','" + email + "')";                    
                MessageBox.Show(sql);
                MessageBox.Show("Đăng kí thành công!", "Thông báo");
                    if (c.CapNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    }
                        frmDangNhap f = new frmDangNhap();
                f.Show();
                this.Hide();

                }
            catch
            {
                MessageBox.Show("Đăng kí thất bại!", "Thông báo");
            }
        }

        private void btnDangki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
