using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _174_182_QLCHLAPTOP
{
    public partial class frmTimKiemSanPham : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmTimKiemSanPham()
        {
            InitializeComponent();
           
        }

     
        DataSet dsSanPham = new DataSet();
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            dsSanPham = c.LayDuLieu(sql);
            d.DataSource = dsSanPham.Tables[0];
        }

       

        private void frmTimKiemSanPham_Load(object sender, EventArgs e)
        {
            cboCachTim.Text = "Mã Sản Phẩm";
            LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP");

        }

        private void txtTuTim_TextChanged_1(object sender, EventArgs e)
        {
            if (cboCachTim.Text == "Mã Sản Phẩm")
            {
                LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP and s.MASP Like N'%" + txtTuTim.Text + "%'");

            }
            if (cboCachTim.Text == "Tên Sản Phẩm")
            {
                LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP and TENSP Like N'%" + txtTuTim.Text + "%'");

            }
            if (cboCachTim.Text == "Loại Sản Phẩm")
            {
                LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP and TENLOAI Like N'%" + txtTuTim.Text + "%'");
            }

            if (cboCachTim.Text == "Hãng Sản Xuất")
            {
                LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP and HANGSX Like N'%" + txtTuTim.Text + "%'");

            }
            if (cboCachTim.Text == "Nhà Cung Cấp")
            {
                LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP and TENNCC Like N'%" + txtTuTim.Text + "%'");

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTuTim.Text = "";
            LoadDuLieu_datagrid(dgvDanhSachSP, "select s.MASP, TENSP , TENLOAI, n.TENNCC, h.TENHANGSX, THOIGIANBH , GIANHAP, GIABAN, SOLUONG, HINH , MOTA,s.TRANGTHAI from  SANPHAM s, LOAISP l, NHACUNGCAP n, HANGSX h,CHITIETSANPHAM c where s.MALOAI= l.MALOAI and s.MANCC = n.MANCC and h.MAHANGSX =s.MAHANGSX and s.MASP =c.MASP");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTuTim.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm", "Thông báo");
            }
            txtTuTim_TextChanged_1(sender, e);
        }

        void hienthianh(string ten)
        {
            if (ten != "")
            {
                string duongdan = Path.GetFullPath("HinhAnh") + @"\";
                picHinhSP.Image = Image.FromFile(duongdan +"\\"+ ten);
                picHinhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                picHinhSP.Visible = true;
            }
            else if (ten == "") picHinhSP.Visible = false;
        }

        private void dgvDanhSachSP_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            //string masp = c.Value.ToString();
            try
            {
                //dgvDanhSachSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
                //dgvDanhSachSP.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                hienthianh(dgvDanhSachSP.Rows[e.RowIndex].Cells["Hinh"].Value.ToString());
            }
            catch { }

        }

        private void dgvDanhSachSP_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    dgvDanhSachSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Aquamarine;
            //    dgvDanhSachSP.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            //}
            //catch { }
        }
    }
}
