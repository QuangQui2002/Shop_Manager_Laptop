using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _174_182_QLCHLAPTOP
{
    public partial class frmHoaDonNhap : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmHoaDonNhap()
        {
            InitializeComponent();
            xulytextbox(true);
            xulybutton(true);
            btnThemSP.Enabled = false;
        }
        void xulytextbox(Boolean t)
        {
            txtMaHDN.ReadOnly = t;

            cboHangSX.Enabled = !t;
            cboTenNCC.Enabled = !t;
            cboTenNV.Enabled = !t;
            cboTrangThai.Enabled = !t;
            cboTenNV.Enabled = !t;
            dtpNgayLap.Enabled = !t;
            cboSanPham.Enabled = !t;

            lblTenSP.Enabled = !t;
            lblGiaNhap.Enabled = !t;
            txtSoLuong.ReadOnly = t;
            lblThanhTien.Enabled = !t;
            lblTongTien.Enabled = !t;
        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
        }
        int vt = 0;
        DataSet ds = new DataSet();
        DataSet dsnv = new DataSet();
        DataSet dshangsx = new DataSet();
        DataSet dsncc = new DataSet();
        DataSet dscthd = new DataSet();
        DataSet dssp = new DataSet();

        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];

        }
        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaHDN.Text = dt.Rows[vt][0].ToString();
            cboTenNV.Text = dt.Rows[vt]["MANV"].ToString();
            cboTenNCC.Text = dt.Rows[vt]["MANCC"].ToString();
            lblTongTien.Text = dt.Rows[vt]["TONGTIEN"].ToString();
            dtpNgayLap.Text = dt.Rows[vt]["NGAYLAP"].ToString();

            string MaNV, NhaCungCap;
            MaNV = dt.Rows[vt]["MANV"].ToString();
            //MaHangSX = dt.Rows[vt]["MAHANGSX"].ToString();
            NhaCungCap = dt.Rows[vt]["MANCC"].ToString();

            DataView dvNhanVien = new DataView();
            //DataView dvHangSX = new DataView();
            DataView dvNhaCungCap = new DataView();

            dvNhanVien.Table = dsnv.Tables[0];
            //dvHangSX.Table = dshangsx.Tables[0];
            dvNhaCungCap.Table = dsncc.Tables[0];

            cboTenNV.DataSource = dvNhanVien;
            //cboHangSX.DataSource = dvHangSX;
            cboTenNCC.DataSource = dvNhaCungCap;

            cboTenNV.DisplayMember = "TENNV";
            cboTenNV.ValueMember = "MANV";

            //cboHangSX.DisplayMember = "TENHANGSX";
            //cboHangSX.ValueMember = "MAHANGSX";

            cboTenNCC.DisplayMember = "TENNCC";
            cboTenNCC.ValueMember = "MANCC";

            dvNhanVien.RowFilter = "MANV='" + MaNV + "'";
            //dvHangSX.RowFilter = "MAHANGSX='" + MaHangSX + "'";
            dvNhaCungCap.RowFilter = "MANCC='" + NhaCungCap + "'";

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;

            load_cthdtheomasp(dt.Rows[vt][0].ToString());

        }

        void load_cthdtheomasp(string mahdn)
        {
            string s = "select * from CHITIETHOADONNHAP WHERE MAHDN='" + mahdn + "'";
            DataSet dscthd = c.LayDuLieu(s);
            dgvCTHDN.DataSource = null;
            dgvCTHDN.DataSource = dscthd.Tables[0];
        }

        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }
        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 2;
        }

        private void txtMaHDN_TextChanged(object sender, EventArgs e)
        {

        }

        void TaoCotHDN()
        {
            dgvCTHDN.Columns.Clear();
            dgvCTHDN.Columns.Add("MAHDN", "Mã HĐ");
            dgvCTHDN.Columns.Add("MASP", "Mã SP");
            dgvCTHDN.Columns.Add("DONGIA", "Đơn Giá");
            dgvCTHDN.Columns.Add("SOLUONG", "Số Lượng");
            dgvCTHDN.Columns.Add("THANHTIEN", "Thành Tiền");

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThemSP.Enabled = true;
            
            xulytextbox(false);
            xulybutton(false);
            btnLuu.Enabled = false;
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";
            cboTenNCC.Text = "";
            hienthicombobox(dsnv, cboTenNV, "MANV", "TENNV");
            hienthicombobox(dshangsx, cboHangSX, "MAHANGSX", "TENHANGSX");
            //hienthicombobox(dsncc, cboTenNCC, "MANCC", "TENNCC");

            txtMaHDN.Text = Maphatsinh(ds);
            txtMaHDN.Enabled = false;

            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Enabled = false;
            TaoCotHDN();
            flag = 1;

            dgvDanhSachHDN.Enabled = false;

        }
        int flag = 0;
        string mancc;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            string sqlcthd = "";


            dgvDanhSachHDN.Enabled = true;

            if (flag == 1)
            {
                ds = c.LayDuLieu("select * from NHACUNGCAP where TENNCC = '" + cboTenNCC.Text + "'");
                mancc = ds.Tables[0].Rows[0]["MANCC"].ToString();

                sql = "INSERT INTO HOADONNHAP VALUES('"
                    + txtMaHDN.Text + "','"
                    + mancc + "','"
                    + cboTenNV.SelectedValue + "','"
                    + dtpNgayLap.Text + "','" + tongtien + "','"
                    + cboTrangThai.SelectedIndex.ToString() + "')";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    for (int i = 0; i < dgvCTHDN.Rows.Count; i++)
                    {
                        sqlcthd = "INSERT INTO CHITIETHOADONNHAP VALUES ('";
                        sqlcthd += dgvCTHDN.Rows[i].Cells[0].Value.ToString() + "','" +
                                   dgvCTHDN.Rows[i].Cells[1].Value.ToString() + "','" +
                                   dgvCTHDN.Rows[i].Cells[2].Value.ToString() + "','" +
                                   dgvCTHDN.Rows[i].Cells[3].Value.ToString() + "','" +
                                   dgvCTHDN.Rows[i].Cells[4].Value.ToString() + "')";
                        //MessageBox.Show(sqlcthd);
                        
                        if (c.CapNhatDuLieu(sqlcthd) > 0)
                        {
                            string masp = dgvCTHDN.Rows[i].Cells[1].Value.ToString();
                            DataSet getsoluong = c.LayDuLieu("Select SOLUONG from SanPham where MaSP = '" + masp + "'");
                            string soluong = getsoluong.Tables[0].Rows[0]["SOLUONG"].ToString();

                            int sl1 = int.Parse(soluong);
                            int sl = int.Parse(dgvCTHDN.Rows[i].Cells[3].Value.ToString());
                            sl1 = sl1 + sl;

                            if (c.CapNhatDuLieu("update SANPHAM SET SOLUONG=" + sl1 + " where masp='" + masp + "'") > 0)
                            {

                            }
                        }
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");

                }
            }

                 
            if (flag == 3)
            {
                sql = "update HOADONNHAP set TRANGTHAI=N'" + cboTrangThai.Text + "' where MAHDN='" + txtMaHDN.Text + "'";
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmHoaDonNhap_Load(sender, e);

                }
            }
            if (flag == 2)
            {
                sql = "UPDATE HOADONNHAP set TRANGTHAI='0' where MAHDN='" + txtMaHDN.Text + "'";
                //MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    frmHoaDonNhap_Load(sender, e);

                }

            }
        
            //dgvCTHDN.Rows.Clear();
            frmHoaDonNhap_Load(sender, e);

            flag = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulytextbox(false);

            txtMaHDN.ReadOnly = true;

            hienthicombobox(dsnv, cboTenNV, "MANV", "TENNV");
            hienthicombobox(dsncc, cboTenNCC, "MANCC", "TENNCC");
            xulybutton(false);
            flag = 3;
        }

        void LoadDuLieu_datagridcthd(DataGridView d, string sql)
        {
            dscthd = c.LayDuLieu(sql);
            d.DataSource = dscthd.Tables[0];
        }

        private void dgvDanSachHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                dgvCTHDN.Columns.Clear();
                vt = dgvDanhSachHDN.CurrentCell.RowIndex;
                hienthitextbox(ds.Tables[0], vt);
                //LoadDuLieu_datagridcthd(dgvCTHDN, "select MAHDN,MASP,DONGIA,SOLUONG,THANHTIEN from CHITIETHOADONNHAP where MAHDN ='" + txtMaHDN.Text + "'");
           
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachHDN, "select * from HOADONNHAP");

            dsnv = c.LayDuLieu("select * from NHANVIEN where CHUCVU = 'CV005'");
            dshangsx = c.LayDuLieu("select * from HANGSX where TRANGTHAI ='1'");
            dsncc = c.LayDuLieu("select * from NHACUNGCAP where TRANGTHAI ='1'");
            dssp = c.LayDuLieu("select * from SANPHAM ");

            hienthicombobox(dsnv, cboTenNV, "MANV", "HOTENNV");
            hienthicombobox(dshangsx, cboHangSX, "MAHANGSX", "TENHANGSX");
            hienthicombobox(dsncc, cboTenNCC, "MANCC", "TENNCC");
            f = true;
            fa = true;

           

           


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);

            dgvDanhSachHDN.Enabled = true;
        }
        string Maphatsinh(DataSet ds)
        {
            String MaNCC = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaNCC = "HDN00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaNCC = "HDN0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaNCC;
        }

        private void frmHoaDonNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblTenSP_TextChanged(object sender, EventArgs e)
        {

        }


        //private void btnTimNCC_Click(object sender, EventArgs e)
        //{
        //    if (txtDienThoai.Text != "")// kiểm tra độ dài sđt dư 1
        //        if (!timncc())
        //            MessageBox.Show("Không tìm thấy số điện thoại Nhà Cung Cấp");
        //}

        //string mancc, tenncc;
        //Boolean timncc()
        //{
        //    DataSet ds = new DataSet();
        //    ds = c.LayDuLieu("select * from NHACUNGCAP where DIENTHOAI = '" + txtDienThoai.Text + "'");
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        mancc = ds.Tables[0].Rows[0]["MANCC"].ToString();
        //        lblTenNCC.Text = tenncc = ds.Tables[0].Rows[0]["TENNCC"].ToString();
        //        return true;
        //    }
        //    return false;
        //}
        //private void btnThemNCC_Click(object sender, EventArgs e)
        //{
        //    frmNhaCungCap f = new frmNhaCungCap();
        //    f.Show();
        //    mancc = f.mancc;
        //    lblTenNCC.Text = f.tenncc;
        //    txtDienThoai.Text = f.dienthoai;
        //}

        void taoanh_tufileanh(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int sl = int.Parse(txtSoLuong.Text);

                    string masp = cboSanPham.Text;
                    DataSet getsoluong = c.LayDuLieu("Select SOLUONG from SanPham where MaSP = '" + masp + "'");
                    string soluong = getsoluong.Tables[0].Rows[0]["SOLUONG"].ToString(); //soluong ben sp
                    int sl1 = int.Parse(soluong);
                    sl1 += sl;                 
                   
                        int dongia = int.Parse(lblGiaNhap.Text);
                        double thanhtien = (sl * dongia);

                        lblThanhTien.Text = thanhtien.ToString();
                        lblTongTien.Text = tongtien.ToString();
                    
                }
                catch { }
                

            }
        }
        double tongtien = 0;

        private bool KiemtraSP(object[] ct, DataGridView dv)
        {
            for (int i = 0; i < dv.Rows.Count; i++)
            {
                if (ct[1].ToString() == dv.Rows[i].Cells[1].Value.ToString())
                {
                    int slmoi = int.Parse(ct[3].ToString());
                    string slcu = dv.Rows[i].Cells[3].Value.ToString();
                    int slcu1 = int.Parse(slcu);
                    int sl = slmoi + slcu1;
                    ct[3] = sl;

                    int thanhtiencu = int.Parse(dv.Rows[i].Cells[4].Value.ToString());
                    ct[4] = int.Parse(ct[4].ToString()) + thanhtiencu;
                    tongtien -= thanhtiencu;
                    tongtien += int.Parse(ct[4].ToString());
                    dv.Rows.Add(ct);
                    dv.Rows.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try {
                btnLuu.Enabled = true;
                string mahd = txtMaHDN.Text;
                string masp = cboSanPham.Text;
                
                int dongia = int.Parse(lblGiaNhap.Text);
                int soluong = int.Parse(txtSoLuong.Text);
                double thanhtien = 0;
                thanhtien = soluong * dongia;             
                object[] d = { mahd, masp, dongia, soluong, thanhtien };
                if (KiemtraSP(d, dgvCTHDN) == false)
                {
                    dgvCTHDN.DataSource = null;
                    dgvCTHDN.Rows.Add(d);

                    tongtien += thanhtien;
                    lblTongTien.Text = tongtien.ToString();

                }
                else
                {
                    lblTongTien.Text = tongtien.ToString();

                }
            }
            catch
            {
                btnLuu.Enabled = false;
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboHangSX_KeyDown(object sender, KeyEventArgs e)
        {
            dsncc = c.LayDuLieu("select DISTINCT TENNCC, N.MANCC, N.TENNCC from SANPHAM S, NHACUNGCAP N, HANGSX H where S.MAHANGSX = H.MAHANGSX AND S.MANCC = N.MANCC AND TENHANGSX = '" + cboHangSX.Text + "' ");
            hienthicombobox(dsncc, cboTenNCC, "MANCC", "TENNCC");
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            string masp = cboSanPham.Text;
            DataSet dssp = new DataSet();
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    dssp = c.LayDuLieu("select * from SANPHAM S, HANGSX H, NHACUNGCAP N where H.MAHANGSX = S.MAHANGSX AND S.MANCC = N.MANCC AND MASP ='" + masp + "'AND TENNCC ='" + cboTenNCC.Text + "' AND TENHANGSX = '" + cboHangSX.Text + "'");
                    //dssp = c.LayDuLieu("select * from SANPHAM where TENSP like '%" + sp + "%' or MASP like '%" + sp + "%' and TRANGTHAI = '1'");
                    lblTenSP.Text = dssp.Tables[0].Rows[0]["TENSP"].ToString();
                    lblGiaNhap.Text = dssp.Tables[0].Rows[0]["GIANHAP"].ToString();
                    string hinh = dssp.Tables[0].Rows[0]["HINH"].ToString();
                    string duongdan = Path.GetFullPath("HinhAnh") + @"\";

                    taoanh_tufileanh(picHinhSP, duongdan + hinh);
                }
                catch
                {

                    MessageBox.Show("Sản phẩm không tồn tại", "Thông báo");

                }
            }
        }
        int vtct = 0;
        private void dgvCTHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //dgvCTHDN.Columns.Clear();
            vtct = dgvCTHDN.CurrentCell.RowIndex;
            hienthitextboxcthd(ds.Tables[0], vtct);
        }

        void hienthitextboxcthd(DataTable dt, int vt)
        {
            //txtMaSP.Text = dt.Rows[vtct][0].ToString();
            //lblTenSP.Text = dt.Rows[vtct][1].ToString();
            //lblGiaNhap.Text = dt.Rows[vtct][2].ToString();
            //txtSoLuong.Text = dt.Rows[vtct][3].ToString();
            //lblThanhTien.Text = dt.Rows[vtct][4].ToString();


        }

        private void dgvDanhSachHDN_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachHDN.ClearSelection();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            frmHoaDonNhap_Load(sender, e);
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RJ ADVANCE LAPTOP", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString("Ngày Lập: " + DateTime.Now, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 65));
            e.Graphics.DrawString("Nhân Viên Lập: " + cboTenNV.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 85));
            
            e.Graphics.DrawString("HÓA ĐƠN NHẬP HÀNG", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(250, 130));

            e.Graphics.DrawString("Mã Hóa Đơn Nhập: " + txtMaHDN.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("Tên Nhà Cung Cấp: " + cboTenNCC.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 210));

            //DataSet getdiachi = c.LayDuLieu("Select * from NHACUNGCAP where DIACHI = '" + dgvCTHDN.Rows[5].Cells["DIACHI"].Value.ToString() + "'");
            //string diachi = getdiachi.Tables[0].Rows[0]["DIACHI"].ToString();
            //e.Graphics.DrawString(diachi, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 850));


            int yPos2 = 255;
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 230));
            e.Graphics.DrawString("STT", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, yPos2));
            e.Graphics.DrawString("Mã SP", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(70, yPos2));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(170, yPos2));
            e.Graphics.DrawString("SL", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(470, yPos2));
            e.Graphics.DrawString("Bảo Hành", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(510, yPos2));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(630, yPos2));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(740, yPos2));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            int yPos = 300;

            for (int i = 0; i < dgvCTHDN.Rows.Count; i++)
            {
                //DataSet GETMOTA = c.LayDuLieu("Select * from CHITIETSANPHAM where MASP = '" + dgvCTHDN.Rows[i].Cells["MASP"].Value.ToString() + "'");
                DataSet getbaohanh = c.LayDuLieu("Select * from sanpham where MASP = '" + dgvCTHDN.Rows[i].Cells["MASP"].Value.ToString() + "'");
                DataSet getTenSanPham = c.LayDuLieu("Select * from SanPham where MaSP = '" + dgvCTHDN.Rows[i].Cells["MASP"].Value.ToString() + "'");
                string baohanh = getbaohanh.Tables[0].Rows[0]["THOIGIANBH"].ToString();
                //string MOTA = GETMOTA.Tables[0].Rows[0]["MOTA"].ToString();
                string TENSP = getTenSanPham.Tables[0].Rows[0]["TENSP"].ToString();

                e.Graphics.DrawString((i+1).ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, yPos));
                e.Graphics.DrawString(dgvCTHDN.Rows[i].Cells["MASP"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(60, yPos));
                e.Graphics.DrawString(TENSP, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(170, yPos));
                e.Graphics.DrawString(dgvCTHDN.Rows[i].Cells["SOLUONG"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(475, yPos));
                e.Graphics.DrawString(baohanh, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(540, yPos));
                e.Graphics.DrawString(dgvCTHDN.Rows[i].Cells["DONGIA"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(630, yPos));
                e.Graphics.DrawString(dgvCTHDN.Rows[i].Cells["THANHTIEN"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(740, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(20, yPos));
            e.Graphics.DrawString("Tổng tiền: " + lblTongTien.Text + " VNĐ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(570, yPos + 30));
            //e.Graphics.DrawString("Tiền nhận từ khách: " + txt_TienKhachGui.Text + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(500, yPos + 60));
            //e.Graphics.DrawString("Tiền trả khách: " + txt_TienGuiLai.Text + " VNĐ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(500, yPos + 90));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {
        }

        bool f = false;
        private void dgvDanhSachHDN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 5)
            {
                sql = "update HOADONNHAP set " +
                        "MANCC='" + dgvDanhSachHDN.CurrentRow.Cells[1].Value.ToString() +
                        "',MANV='" + dgvDanhSachHDN.CurrentRow.Cells[2].Value.ToString() +
                        "',NGAYLAP='" + dgvDanhSachHDN.CurrentRow.Cells[3].Value.ToString() +
                        "',TONGTIEN='" + dgvDanhSachHDN.CurrentRow.Cells[4].Value.ToString() +
                        "',TRANGTHAI='" + dgvDanhSachHDN.CurrentRow.Cells[5].Value.ToString() +
                        "' where MAHDN='" + dgvDanhSachHDN.CurrentRow.Cells[0].Value.ToString() + "'";
                MessageBox.Show(sql);
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo");
                    frmHoaDonNhap_Load(sender, e);
                }

            }
        }

        private void dgvCTHDN_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void dgvCTHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool fa;
        private void dgvCTHDN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //string sqlct = "";
            //if (btnSua.Enabled == false)
            //{
            //    string mahdn = dgvCTHDN.CurrentRow.Cells[0].Value.ToString();
            //    string masp = dgvCTHDN.CurrentRow.Cells[1].Value.ToString();
            //    int dongia = int.Parse(dgvCTHDN.CurrentRow.Cells[2].Value.ToString());
            //    int soluong = int.Parse(dgvCTHDN.CurrentRow.Cells[3].Value.ToString());
            //    int thanhtien = soluong * dongia;

            //    if (fa == true && e.ColumnIndex > 0 && e.ColumnIndex <= 4)
            //    {
            //        sqlct = "update CHITIETHOADONNHAP set THANHTIEN =SOLUONG *DONGIA, SOLUONG = '" + soluong + "' where MAHDN= '" + mahdn + "' AND MASP = '" + masp + "' ";
            //        MessageBox.Show(sqlct);
            //        if (c.CapNhatDuLieu(sqlct) > 0)
            //        {
            //            MessageBox.Show("Cập nhật thành công", "Thông báo");
            //            frmHoaDonNhap_Load(sender, e);
            //        }

            //    }
            //}        
        }

        private void cboSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            string masp = cboSanPham.Text;
            DataSet dssp = new DataSet();
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    dssp = c.LayDuLieu("select * from SANPHAM S, HANGSX H, NHACUNGCAP N where H.MAHANGSX = S.MAHANGSX AND S.MANCC = N.MANCC AND MASP ='" + masp + "'AND TENNCC ='" + cboTenNCC.Text + "' AND TENHANGSX = '" + cboHangSX.Text + "'");
                    //dssp = c.LayDuLieu("select * from SANPHAM where TENSP like '%" + sp + "%' or MASP like '%" + sp + "%' and TRANGTHAI = '1'");
                    lblTenSP.Text = dssp.Tables[0].Rows[0]["TENSP"].ToString();
                    lblGiaNhap.Text = dssp.Tables[0].Rows[0]["GIANHAP"].ToString();
                    string hinh = dssp.Tables[0].Rows[0]["HINH"].ToString();
                    string duongdan = Path.GetFullPath("HinhAnh") + @"\";

                    taoanh_tufileanh(picHinhSP, duongdan + hinh);
                }
                catch
                {

                    MessageBox.Show("Sản phẩm không tồn tại\n", "Thông báo");

                }
            }
        }

        private void cboTenNCC_KeyDown(object sender, KeyEventArgs e)
        {
            dssp = c.LayDuLieu("select * from SANPHAM S, HANGSX H, NHACUNGCAP N where H.MAHANGSX = S.MAHANGSX AND S.MANCC = N.MANCC AND TENNCC ='" + cboTenNCC.Text + "' AND TENHANGSX = '" + cboHangSX.Text + "'");
            hienthicombobox(dssp, cboSanPham, "MASP", "MASP");
        }
    }
}

