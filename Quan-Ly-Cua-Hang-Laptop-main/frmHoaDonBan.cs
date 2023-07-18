using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _174_182_QLCHLAPTOP
{
    public partial class frmHoaDonBan : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();
        public frmHoaDonBan()
        {
            InitializeComponent();
            xulytextbox(true);
            xulybutton(true);

        }
        void xulytextbox(Boolean t)
        {
            txtMaHDB.ReadOnly = t;
            mtbDienThoai.ReadOnly = t;
            lblTenKH.Enabled = !t;
            cboMaNV.Enabled = !t;
            dtpNgayLap.Enabled = !t;
            cboTrangThai.Enabled = !t;
        }
        void xulytextboxCTHD(Boolean t)
        {
            txtMaSP.ReadOnly = t;
            lblTenSP.Enabled = !t;
            txtGiaBan.ReadOnly = t;
            txtSoLuong.ReadOnly = t;
            lblThanhTien.Enabled = !t;

        }
        void xulycombobox(Boolean t)
        {

        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;

            //btnTimKH.Enabled = t;
            //btnThemKH.Enabled= t;
            //btnThemSP.Enabled= t;

        }
        int vt = 0;
        DataSet ds = new DataSet();
        //DataSet dskh = new DataSet();
        DataSet dsnv = new DataSet();
        DataSet dscthd = new DataSet();


        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }

        void LoadDuLieu_datagridcthd(DataGridView d, string sql)
        {
            dscthd = c.LayDuLieu(sql);
            d.DataSource = dscthd.Tables[0];
        }

        //void LoadDuLieu_cbo(ComboBox cbo, string sql, string valMember, string disMember)
        //{
        //    ds = c.LayDuLieu(sql);
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        cbo.DataSource = ds.Tables[0];
        //        cbo.ValueMember = valMember;
        //        cbo.DisplayMember = disMember;
        //    }
        //}
        void hienthitextbox(DataTable dt, int vt)
        {
            txtMaHDB.Text = dt.Rows[vt][0].ToString();
            lblTenKH.Text = dt.Rows[vt]["MAKH"].ToString();
            //mtbDienThoai.Text= dt.Rows[vt]["DIENTHOAI"].ToString();
            dtpNgayLap.Text = dt.Rows[vt]["NGAYLAP"].ToString();
            lblTongTien.Text = dt.Rows[vt]["TONGTIEN"].ToString();

            string MaNV;
            MaNV = dt.Rows[vt]["MANV"].ToString();
            DataView dvNhanVien = new DataView();
            dvNhanVien.Table = dsnv.Tables[0];
            cboMaNV.DataSource = dvNhanVien;
            cboMaNV.DisplayMember = "TENNV";
            cboMaNV.ValueMember = "MANV";
            dvNhanVien.RowFilter = "MANV='" + MaNV + "'";

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;
            load_cthdtheomasp(dt.Rows[vt][0].ToString());
        }
        void load_cthdtheomasp(string mahdb)
        {
            string s = "select MAHDB,MASP,DONGIA,SOLUONG,THANHTIEN from CHITIETHOADONBAN WHERE MAHDB='" + mahdb + "'";
            DataSet dscthd = c.LayDuLieu(s);
            dgvCTHDB.DataSource = null;
            dgvCTHDB.DataSource = dscthd.Tables[0];
        }
        void hienthitextboxcthd(DataTable dt, int vt)
        {



        }
        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            flag = 2;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dgvCTHDB.DataSource = null;
            xulytextbox(false);
            xulybutton(false);
            hienthicombobox(dsnv, cboMaNV, "MANV", "TENNV");
            txtMaHDB.Text = Maphatsinh(ds);
            txtMaHDB.Enabled = false;
            txtSoLuong.Clear();
            lblTenKH.Text = "";
            btnLuu.Enabled = false;
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";

            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Enabled = false;


            tongtien = 0;
            mtbDienThoai.Text = "";
            lblTongTien.Text = "";
            txtMaSP.Text = "";
            lblThanhTien.Text = "";
            txtGiaBan.Text = "";
            lblTenSP.Text = "";
            flag = 1;
            TaoCotHDB();
            dgvDanhSachHDB.Enabled = false;

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            xulytextbox(false);
            hienthicombobox(dsnv, cboMaNV, "MANV", "TENNV");
            txtMaHDB.ReadOnly = true;
            xulybutton(false);
            flag = 3;
        }
        int flag = 0;
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            xulybutton(true);
            string sql = "";
            string sqlcthd = "";
            dgvDanhSachHDB.Enabled = true;
            if (flag == 1)
            {
                try
                {
                    sql = "INSERT INTO HOADONBAN(MAHDB,MAKH,MANV,NGAYLAP,TONGTIEN,TRANGTHAI) VALUES('"
                        + txtMaHDB.Text + "','"
                        + makh + "','"
                        + cboMaNV.SelectedValue + "','"
                        + dtpNgayLap.Text + "','"
                        + tongtien + "','"
                        + cboTrangThai.SelectedIndex.ToString() + "')";
                    //MessageBox.Show(sql);
                    if (c.CapNhatDuLieu(sql) > 0)
                    {
                        for (int i = 0; i < dgvCTHDB.Rows.Count; i++)
                        {
                            sqlcthd = "INSERT INTO CHITIETHOADONBAN VALUES ('";
                            sqlcthd += dgvCTHDB.Rows[i].Cells[0].Value.ToString() + "','" +
                                    dgvCTHDB.Rows[i].Cells[1].Value.ToString() + "','" +
                                    dgvCTHDB.Rows[i].Cells[2].Value.ToString() + "','" +
                                    dgvCTHDB.Rows[i].Cells[3].Value.ToString() + "','" +
                                    dgvCTHDB.Rows[i].Cells[4].Value.ToString() + "')";
                            if (c.CapNhatDuLieu(sqlcthd) > 0)
                            {
                                string masp = dgvCTHDB.Rows[i].Cells["MASP"].Value.ToString();
                                DataSet getsoluong = c.LayDuLieu("Select SOLUONG from SanPham where MaSP = '" + masp + "'");
                                string soluong = getsoluong.Tables[0].Rows[0]["SOLUONG"].ToString();

                                int sl1 = int.Parse(soluong);
                                int sl = int.Parse(dgvCTHDB.Rows[i].Cells[3].Value.ToString());
                                sl1 = sl1 - sl;

                                if (c.CapNhatDuLieu("update SANPHAM SET SOLUONG=" + sl1 + " where masp='" + masp + "'") > 0)
                                {

                                }
                            }
                        }
                    }
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");

                    dgvCTHDB.Rows.Clear();
                }
                catch { }

            }
            if (flag == 3)
            {
                sql = "update HOADONBAN set TRANGTHAI='" + cboTrangThai.SelectedIndex.ToString() + "'where MAHDB='" + txtMaHDB.Text + "'";

                if (cboTrangThai.SelectedIndex == 0) {

                    if (c.CapNhatDuLieu(sql) > 0)
                    {
                        frmHoaDonBan_Load(sender, e);
                        for (int i = 0; i < dgvCTHDB.Rows.Count; i++)
                        {
                            string masp = dgvCTHDB.Rows[i].Cells["MASP"].Value.ToString();
                            DataSet getsoluong = c.LayDuLieu("Select SOLUONG from SanPham where MaSP = '" + masp + "'");
                            string soluong = getsoluong.Tables[0].Rows[0]["SOLUONG"].ToString();

                            int sl1 = int.Parse(soluong);
                            int sl = int.Parse(dgvCTHDB.Rows[i].Cells[3].Value.ToString());
                            sl1 += sl;

                            if (c.CapNhatDuLieu("update SANPHAM SET SOLUONG=" + sl1 + " where masp='" + masp + "'") > 0)
                            {

                            }
                        }

                    }
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");


                }
                else
                {

                    if (c.CapNhatDuLieu(sql) > 0)
                    {
                        MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                        frmHoaDonBan_Load(sender, e);
                        for (int i = 0; i < dgvCTHDB.Rows.Count; i++)
                        {
                            string masp = dgvCTHDB.Rows[i].Cells["MASP"].Value.ToString();
                            DataSet getsoluong = c.LayDuLieu("Select SOLUONG from SanPham where MaSP = '" + masp + "'");
                            string soluong = getsoluong.Tables[0].Rows[0]["SOLUONG"].ToString();

                            int sl1 = int.Parse(soluong);
                            int sl = int.Parse(dgvCTHDB.Rows[i].Cells[3].Value.ToString());
                            sl1 -= sl;

                            if (c.CapNhatDuLieu("update SANPHAM SET SOLUONG=" + sl1 + " where masp='" + masp + "'") > 0)
                            {

                            }
                        }

                    }


                }
            }
            if (flag == 2)
            {
                sql = "update HOADONBAN set TRANGTHAI='0' where MAHDB='" + txtMaHDB.Text + "'";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                    frmHoaDonBan_Load(sender, e);

                }
            }

            frmHoaDonBan_Load(sender, e);
            flag = 0;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);
            dgvDanhSachHDB.Enabled = true;
            dgvCTHDB.Columns.Clear();
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {

            LoadDuLieu_datagrid(dgvDanhSachHDB, "select * from HOADONBAN");

            //LoadDuLieu_datagrid(dvgDanhSachChiTietHDB, "select * from CHITIETHOADONBAN");
            dsnv = c.LayDuLieu("select * from NHANVIEN where CHUCVU = 'CV004' ");
            //dskh = c.LayDuLieu("select * from KHACHHANG");
            hienthicombobox(dsnv, cboMaNV, "MANV", "HOTENNV");
            //hienthicombobox(dskh, cboMaKH, "MAKH", "TENKH"); /*where MAHDB ='" + txtMaHDB.Text + */
            //hienthitextbox(ds.Tables[0], vt);


        }
        private void dgvDanhSachHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dgvCTHDB.Columns.Clear();
                vt = dgvDanhSachHDB.CurrentCell.RowIndex;
                //load_cthdtheomasp(txtMaHDB.Text);
                //load_ctsptheomasp(txtMaSP.Text);
                hienthitextbox(ds.Tables[0], vt);
                //LoadDuLieu_datagridcthd(dgvCTHDB, "select MAHDB,MASP,DONGIA,SOLUONG,THANHTIEN from CHITIETHOADONBAN where MAHDB ='" + txtMaHDB.Text + "'");

            }
            catch
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        string Maphatsinh(DataSet ds)
        {
            String MaHDB = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaHDB = "HDB00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaHDB = "HDB0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaHDB;
        }


        private void dvgDanhSachChiTietHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvCTHDB.CurrentCell.RowIndex;
            hienthitextboxcthd(ds.Tables[0], vt);
        }

        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }


        string makh, tenkh;
        Boolean timkh()
        {
            DataSet ds = new DataSet();
            ds = c.LayDuLieu("select * from KHACHHANG where DIENTHOAI = '" + mtbDienThoai.Text + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                makh = ds.Tables[0].Rows[0]["MAKH"].ToString();
                lblTenKH.Text = tenkh = ds.Tables[0].Rows[0]["TENKH"].ToString();
                return true;
            }
            return false;
        }

        private void btnKHMoi_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.Show();
            makh = f.makh;
            lblTenKH.Text = f.tenkh;
            mtbDienThoai.Text = f.dienthoai;
        }

        void taoanh_tufileanh(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        DataSet dssp = new DataSet();
        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            string masp = txtMaSP.Text;



            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    dssp = c.LayDuLieu("select * from SANPHAM where MASP ='" + masp + "' and TRANGTHAI ='1'");

                    lblTenSP.Text = dssp.Tables[0].Rows[0]["TENSP"].ToString();
                    txtGiaBan.Text = dssp.Tables[0].Rows[0]["GIABAN"].ToString();
                    string hinh = dssp.Tables[0].Rows[0]["HINH"].ToString();
                    string duongdan = Path.GetFullPath("HinhAnh") + @"\";

                    taoanh_tufileanh(picHinhSP, duongdan + hinh);
                }
                catch
                {
                    MessageBox.Show("Sản phẩm không tồn tại.");
                }
            }

        }
        double tongtien = 0;
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                btnLuu.Enabled = true;
                string mahd = txtMaHDB.Text;
                string masp = txtMaSP.Text;
                int dongia = int.Parse(txtGiaBan.Text);
                int soluong = int.Parse(txtSoLuong.Text);
                double thanhtien = 0;
                thanhtien = soluong * dongia;

                object[] d = { mahd, masp, dongia, soluong, thanhtien };

                //lblTongTien.Text = tongtien.ToString();
                if (KiemtraSP(d, dgvCTHDB) == false)
                {
                    dgvCTHDB.DataSource = null;
                    dgvCTHDB.Rows.Add(d);

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
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }

        } 
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
        
        private void mtbDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

        }


        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            DataSet getsoluong = c.LayDuLieu("Select SOLUONG from SanPham where MaSP = '" + txtMaSP.Text + "'");
            string soluong = getsoluong.Tables[0].Rows[0]["SOLUONG"].ToString();
            
            int sl1 = int.Parse(soluong);
            if (e.KeyCode == Keys.Enter)
            {
                int sl = int.Parse(txtSoLuong.Text);
                int dongia = int.Parse(txtGiaBan.Text);
                if (sl1 >= sl)
                {
               
                    double thanhtien = (sl * dongia);

                    lblThanhTien.Text = thanhtien.ToString();
                    lblTongTien.Text = tongtien.ToString();
                    
                    
                }
                else
                {
                    MessageBox.Show("Sản Phẩm Trong Kho Không Đủ Yêu Cầu!!!");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cboMaNVB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //frmNhanVien f = new frmNhanVien();
            //f.Show();
            //if (macv == "CV004")
            //{

            //}
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            if (mtbDienThoai.Text != "")// kiểm tra độ dài sđt dư 1
                if (!timkh())
                    MessageBox.Show("Không tìm thấy số điện thoại Khách Hàng");
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;

        }

        private void dgvDanhSachHDB_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachHDB.ClearSelection();
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("CÔNG TY CỔ PHẦN THƯƠNG MẠI - DỊCH VỤ RJ ADVANCE LAPTOP", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(60, 10));
            
            e.Graphics.DrawString("www.rjadvance.vn", new Font("Arial", 14, FontStyle.Regular), Brushes.Blue, new Point(300, 40));
            //e.Graphics.DrawImage(Image.FromFile("C:\\Users\\LAPTOP QUI\\Desktop\\DOAN\\174_182_QLCHLAPTOP\\174_182_QLCHLAPTOP\\Resources\\avata.jpg"), 10, 80, 150, 100);
            e.Graphics.DrawString("RJ LAPTOP", new Font("Arial", 30, FontStyle.Regular), Brushes.Red, new Point(260, 80));
            
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(260, 130));
            
            e.Graphics.DrawString("Ngày: " + DateTime.Now, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(260, 170));

            DataSet getKH = c.LayDuLieu("Select TENKH from KHACHHANG where MaKH = '" + dgvDanhSachHDB.Rows[0].Cells["KH"].Value.ToString() + "'");
            string KH = getKH.Tables[0].Rows[0][0].ToString();

            e.Graphics.DrawString("NV Lập: " + cboMaNV.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(450, 200));
           
            e.Graphics.DrawString("Tên KH: " + KH, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 200));

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 220));
             e.Graphics.DrawString("Mã SP", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("Tên Sản Phẩm", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(90, 240));
           
            e.Graphics.DrawString("SL", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, 240));
            e.Graphics.DrawString("Bảo Hành",new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(430, 240));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(550, 240));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(680, 240));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 260));
            int yPos = 280;

            for (int i = 0; i < dgvCTHDB.Rows.Count; i++)
            {
                DataSet GETMOTA = c.LayDuLieu("Select * from CHITIETSANPHAM where MASP = '" + dgvCTHDB.Rows[i].Cells["MASP"].Value.ToString() + "'");
                DataSet getbaohanh = c.LayDuLieu("Select * from sanpham where MASP = '" + dgvCTHDB.Rows[i].Cells["MASP"].Value.ToString() + "'");
                DataSet getTenSanPham = c.LayDuLieu("Select * from SanPham where MaSP = '" + dgvCTHDB.Rows[i].Cells["MASP"].Value.ToString() + "'");
                string baohanh = getbaohanh.Tables[0].Rows[0]["THOIGIANBH"].ToString();
                string MOTA = GETMOTA.Tables[0].Rows[0]["MOTA"].ToString();
                string TENSP = getTenSanPham.Tables[0].Rows[0]["TENSP"].ToString();
                e.Graphics.DrawString(dgvCTHDB.Rows[i].Cells["MASP"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(TENSP, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(90, yPos));
                e.Graphics.DrawString(dgvCTHDB.Rows[i].Cells["SOLUONG"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, yPos));
                e.Graphics.DrawString(baohanh, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(430, yPos));
                e.Graphics.DrawString(dgvCTHDB.Rows[i].Cells["DONGIA"].Value.ToString(),new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(550, yPos));
                e.Graphics.DrawString(dgvCTHDB.Rows[i].Cells["THANHTIEN"].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(680, yPos));
                yPos += 30;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Tổng phải trả: " + lblTongTien.Text + " VNĐ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, yPos + 30));
             e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 900));
            e.Graphics.DrawString("Xin Cảm Ơn Quý Khách Và Hẹn Gặp Lại !!!", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(200, 950));
            e.Graphics.DrawString("Mọi Chi Tiết Xin Liên Hệ!!!", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(250, 1000));
            //e.Graphics.DrawImage(Image.FromFile("C:\\Users\\LAPTOP QUI\\Desktop\\DOAN\\174_182_QLCHLAPTOP\\174_182_QLCHLAPTOP\\Resources\\qr.png"), 530, 970, 100, 100);
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            frmHoaDonBan_Load(sender, e);
        }

        private void mtbDienThoai_KeyDown(object sender, KeyEventArgs e)
        {

        }

        void TaoCotHDB()
        {
            dgvCTHDB.Columns.Clear();
            dgvCTHDB.Columns.Add("MAHD", "Mã Hóa Đơn");
            dgvCTHDB.Columns.Add("MASP", "Mã Sản Phẩm");
            dgvCTHDB.Columns.Add("DONGIA", "Đơn Giá");
            dgvCTHDB.Columns.Add("SOLUONG", "Số Lượng");
            
            dgvCTHDB.Columns.Add("THANHTIEN", "Thành Tiền");

        }

    }
}

