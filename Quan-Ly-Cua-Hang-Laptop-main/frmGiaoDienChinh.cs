using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; // Thêm
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; // Thêm

namespace _174_182_QLCHLAPTOP
{
    public partial class frmGiaoDienChinh : Form
    {
        private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public frmGiaoDienChinh()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pannelMenu.Controls.Add(leftBorderBtn);
            customizedesing();

            // Căn chỉnh form
            //this.Text = String.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        private void customizedesing()
        {
            pnNhanVien.Visible = false;
            pnSanPham.Visible = false;
            pnHoaDon.Visible = false;
            pnTimKiem.Visible = false;
            pnThongKe.Visible = false;
        }

        private void TaoMenuTrong()
        {
            if (pnNhanVien.Visible == true)
                pnNhanVien.Visible = false;
            if (pnSanPham.Visible == true)
                pnSanPham.Visible = false;
            if (pnHoaDon.Visible == true)
                pnHoaDon.Visible = false;
            if (pnTimKiem.Visible == true)
                pnTimKiem.Visible = false;
            if (pnThongKe.Visible == true)
                pnThongKe.Visible = false;
        }

        private void HienMeNu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                TaoMenuTrong();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Structs;
        private struct RGBClor
        {
            public static Color color1 = Color.FromArgb(31,30,68);
            //public static Color color2 = Color.FromArgb(249, 118, 176);
            //public static Color color3 = Color.FromArgb(253, 138, 114);
            //public static Color color4 = Color.FromArgb(95, 77, 221);
            //public static Color color5 = Color.FromArgb(249, 88, 155);
            //public static Color color6 = Color.FromArgb(24, 161, 251);
            //public static Color color7 = Color.FromArgb(172, 126, 241);


        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = Color.FromArgb(224, 255, 255);
                currenBtn.ForeColor = color;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = color;
                currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;

                // Trái
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currenBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currenBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }

            btnKhachHang.ForeColor = Color.FromArgb(0, 0, 0);
            btnKhachHang.IconColor = color;

            btnNhaCungCap.ForeColor = Color.FromArgb(0, 0, 0);
            btnNhaCungCap.IconColor = color;

            mnuNhanVien.ForeColor = Color.FromArgb(0, 0, 0);
            mnuNhanVien.IconColor = color;

            mnuSanPham.ForeColor = Color.FromArgb(0, 0, 0);
            mnuSanPham.IconColor = color;

            mnuHoaDon.ForeColor = Color.FromArgb(0, 0, 0);
            mnuHoaDon.IconColor = color;

            mnuTimKiem.ForeColor = Color.FromArgb(0, 0, 0);
            mnuTimKiem.IconColor = color;

            mnuThongKe.ForeColor = Color.FromArgb(0, 0, 0);
            mnuThongKe.IconColor = color;



        }


        // Padding
        private void DisableButton()
        {
            if (currenBtn != null)
            {
                currenBtn.BackColor = Color.FromArgb(127,255,212);
                currenBtn.ForeColor = Color.Black;
                currenBtn.TextAlign = ContentAlignment.MiddleLeft;
                currenBtn.IconColor = Color.Black;
                currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form 
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle =FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            // Hien thi
            panelDestop.Controls.Add(childForm);
            panelDestop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClor.color1);
            HienMeNu(pnNhanVien);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClor.color1);
            OpenChildForm(new frmKhachHang());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClor.color1);
            OpenChildForm(new frmNhaCungCap());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClor.color1);                     
            HienMeNu(pnSanPham);
            
            
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClor.color1);
            HienMeNu(pnHoaDon);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClor.color1);
            HienMeNu(pnTimKiem);

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBClor.color1);
            HienMeNu(pnThongKe);

        }

        private void iconTitleForm_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        // Hien thi tren title
        private void Reset()
        {
            DisableButton();
            // Thay doi icon
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lblTitleChildForm.Text = "TRANG CHỦ";

        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());

        }

        private void btnThongKeNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiemNhanVien());
        }

        private void btnLoaiSP_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiSanPham());
        }

        private void btnKichThuocSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKichThuocSanPham());
        }

        private void btnMauSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMauSanPham());
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDonBan());
        }

        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDonNhap());
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiemKhachHang());
        }

        private void btnTimKiemHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiemHoaDon());
        }

        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmTimKiemNCC());
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiemNhanVien());
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiemSanPham());
        }

        private void btnThongKeNCC_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmThongKeNCC());
        }

        private void btnThongKeSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeSanPham());
        }

        private void btnThongKeKH_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmThongKeKhachHang());
        }

        private void btnThongKeHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeHoaDonBan());
        }

        private void btnNhanVien_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());

        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChucVu());
        }
       

        // Tắt thanh trên cùng
        //[DllImport("user32.DLL", EntryPoint = "RaleaseCapture")]
        //private extern static void RaleaseCapture();

        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        //{
        //    RaleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //    //}
        //}



        private void frmGiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;


        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlgThoat;
            dlgThoat = MessageBox.Show("Bạn có muốn đăng xuất không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dlgThoat == DialogResult.Yes)
            {
                frmDangNhap f = new frmDangNhap();
                f.Show();
                this.Hide();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHangSX_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHangSX());
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongKeDT_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDoanhThu());
        }
    }
}
