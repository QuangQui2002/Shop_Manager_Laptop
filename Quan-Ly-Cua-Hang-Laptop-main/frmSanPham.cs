using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _174_182_QLCHLAPTOP
{
    public partial class frmSanPham : Form
    {
        clsCuaHangLapTop c = new clsCuaHangLapTop();

        int vt = 0;
        DataSet ds = new DataSet();
        DataSet dsncc = new DataSet();
        DataSet dsloai = new DataSet();
        DataSet dsctsp = new DataSet();
        DataSet dsmau = new DataSet();
        DataSet dskichthuoc = new DataSet();
        DataSet dsHangSX = new DataSet();

        public frmSanPham()
        {
            InitializeComponent();
            xulytextbox(true);
            xulybutton(true);
        }

        string Maphatsinh(DataSet ds)
        {
            String MaSP = "";
            if (ds.Tables[0].Rows.Count < 9)
            {
                MaSP = "SP00" + (ds.Tables[0].Rows.Count + 1).ToString();
            }
            else
                MaSP = "SP0" + (ds.Tables[0].Rows.Count + 1).ToString();
            return MaSP;
        }
        void xulytextbox(Boolean t)
        {

            txtTenSP.ReadOnly = t;
            cboMaLoai.Enabled = !t;
            cboMaNCC.Enabled = !t;
            cboTrangThai.Enabled = !t;
            cboHangSX.Enabled = !t;
           
            txtMaSP.ReadOnly = t;
            txtGiaNhap.ReadOnly = t;
            txtGiaBan.ReadOnly = t;
            txtSoLuong.ReadOnly = t;

            cboThoiGianBH.Enabled = !t;
            cboMaMau.Enabled = !t;
            cboLoaiRam.Enabled = !t;
            cboMaSize.Enabled = !t;
            cboOCung.Enabled = !t;
            cboDungLuongRam.Enabled= !t;
            cboDungLuongOCung.Enabled = !t;
            cboTheHe.Enabled = !t;
            cboHeDieuHanh.Enabled = !t;

            rtbMoTa.Enabled = !t;
        }
        void xulybutton(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
            btnLuu.Enabled = !t;
            btnUp1Hinh.Enabled = !t;
            //btnUpNhieuHinh.Enabled = !t;
        }

        
        
        void LoadDuLieu_datagrid(DataGridView d, string sql)
        {
            ds = c.LayDuLieu(sql);
            d.DataSource = ds.Tables[0];
        }
        void LoadDuLieu_datagridctsp(DataGridView d, string sql)
        {
            dsctsp = c.LayDuLieu(sql);
            d.DataSource = dsctsp.Tables[0];
        }
        void GiuViTRi()
        {
            for(int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
               
                
            }    
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
            txtMaSP.Text = dt.Rows[vt][0].ToString();
            txtTenSP.Text = dt.Rows[vt]["TENSP"].ToString();
            txtGiaNhap.Text = dt.Rows[vt]["GIANHAP"].ToString();
            txtGiaBan.Text = dt.Rows[vt]["GIABAN"].ToString();
            cboThoiGianBH.Text = dt.Rows[vt]["THOIGIANBH"].ToString();
            txtSoLuong.Text = dt.Rows[vt]["SOLUONG"].ToString();

            

            string MaNCC, MaLoai, MaHangSX;
            MaNCC = dt.Rows[vt]["MANCC"].ToString();
            MaLoai = dt.Rows[vt]["MALOAI"].ToString();
            MaHangSX = dt.Rows[vt]["MAHANGSX"].ToString();

            //Hien Thi
            DataView dvNhaCungCap = new DataView();
            DataView dvLoai = new DataView();
            DataView dvMaHangSX = new DataView();

            dvNhaCungCap.Table = dsncc.Tables[0];
            dvLoai.Table = dsloai.Tables[0];
            dvMaHangSX.Table = dsHangSX.Tables[0];

            cboMaNCC.DataSource = dvNhaCungCap;
            cboMaLoai.DataSource = dvLoai;
            cboHangSX.DataSource = dvMaHangSX;

            cboMaNCC.DisplayMember = "TENNCC";
            cboMaNCC.ValueMember = "MANCC";

            cboMaLoai.DisplayMember = "TENLOAI";
            cboMaLoai.ValueMember = "MALOAI";

            cboHangSX.DisplayMember = "TENHANGSX";
            cboHangSX.ValueMember = "MAHANGSX";

            dvNhaCungCap.RowFilter = "MANCC='" + MaNCC + "'";
            dvLoai.RowFilter = "MALOAI='" + MaLoai + "'";
            //dvMaHangSX.RowFilter = "MAHANGSX='" + MaHangSX + "'";
            dvMaHangSX.RowFilter = "MAHANGSX='" + MaHangSX + "'";

            if (dt.Rows[vt]["TRANGTHAI"].ToString() == "0")
                cboTrangThai.SelectedIndex = 0;
            else
                cboTrangThai.SelectedIndex = 1;

            //tenfile += TenSP;
            //Bitmap a = new Bitmap(filename);
            //p.Image = a;
            //p.SizeMode = PictureBoxSizeMode.StretchImage;
            

        }
        void hienthitextboxCTSP(DataTable dt, int vt)
        {
        
            string MaMau, MaSize;
            MaMau = dt.Rows[vt]["MAMAU"].ToString();
            MaSize = dt.Rows[vt]["MASIZE"].ToString();

            DataView dvMau = new DataView();
            DataView dvKichThuoc = new DataView();

            dvMau.Table = dsmau.Tables[0];
            dvKichThuoc.Table = dskichthuoc.Tables[0];

            cboMaMau.DataSource = dvMau;
            cboMaSize.DataSource = dvKichThuoc;

            cboMaMau.DisplayMember = "TENMAU";
            cboMaMau.ValueMember = "MAMAU";

            cboMaSize.DisplayMember = "TENSIZE";
            cboMaSize.ValueMember = "MASIZE";

            dvMau.RowFilter = "MAMAU='" + MaMau + "'";
            dvKichThuoc.RowFilter = "MASIZE='" + MaSize + "'";
        }

        void hienthicombobox(DataSet ds, ComboBox cb, string ma, string ten)
        {
            cb.DataSource = ds.Tables[0];
            cb.DisplayMember = ten;
            cb.ValueMember = ma;
            cb.SelectedIndex = -1;
        }

        private void dgvDSCTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
                vtctsp = dgvDSCTSP.CurrentCell.RowIndex;
                hienthitextboxCTSP(dsctsp.Tables[0], vtctsp);
                xulychuoicbo(dgvDSCTSP.Rows[0].Cells["MOTA"].Value.ToString());
                dgvDSCTSP.Enabled = true;

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadDuLieu_datagrid(dgvDanhSachSP, "select MASP,TENSP,MALOAI,MAHANGSX,MANCC,THOIGIANBH,GIANHAP,GIABAN,SOLUONG,TRANGTHAI,HINH from SANPHAM");
           
           
            dsncc = c.LayDuLieu("select * from NHACUNGCAP where TRANGTHAI='1'");
            dsloai = c.LayDuLieu("select * from LOAISP where TRANGTHAI='1'");
            dsmau = c.LayDuLieu("select * from MAUSP where TRANGTHAI='1'");
            dskichthuoc = c.LayDuLieu("select * from KICHTHUOC where TRANGTHAI='1'");
            dsHangSX = c.LayDuLieu("select * from HANGSX where TRANGTHAI='1'");

            dgvDSCTSP.Columns.Clear();
            hienthicombobox(dsncc, cboMaNCC, "MANCC", "TENNCC");
            hienthicombobox(dsloai, cboMaLoai, "MALOAI", "TENLOAI");
            hienthicombobox(dsmau, cboMaMau, "MAMAU", "TENMAU");
            hienthicombobox(dskichthuoc, cboMaSize, "MASIZE", "TENSIZE");
            hienthicombobox(dsHangSX, cboHangSX, "MAHANGSX", "TENHANGSX");

            dgvDSCTSP.Enabled = false;
            //hienthitextbox(ds.Tables[0], vt);

            f = true;

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {

            xulytextbox(false);
            xulybutton(false);

            txtMaSP.Text = Maphatsinh(ds);
            txtMaSP.Enabled = false;
            hienthicombobox(dsncc, cboMaNCC, "MANCC", "TENNCC");
            hienthicombobox(dsloai, cboMaLoai, "MALOAI", "TENLOAI");
            hienthicombobox(dsHangSX, cboHangSX, "MAHANGSX", "TENHANGSX");
            hienthicombobox(dsmau, cboMaMau, "MAMAU", "TENMAU");
            hienthicombobox(dskichthuoc, cboMaSize, "MASIZE", "TENSIZE");

            dgvDanhSachSP.Enabled = false;
            txtTenSP.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            cboThoiGianBH.Text = "";
            picHinhSP.Image = null;
            txtSoLuong.Text = "0";
            txtSoLuong.Enabled = false;
            cboTrangThai.Enabled = false;
            cboTrangThai.Text = "Hoạt động";
            
            cboLoaiRam.Text = "";
            cboDungLuongRam.Text = "";
            cboOCung.Text = "";
            cboTheHe.Text = "";
            cboHeDieuHanh.Text = "";
            cboDungLuongOCung.Text = "";

            flag = 1;
            TaoCotSP();

            dgvDanhSachSP.Enabled = false;
            dgvDSCTSP.Enabled = false;

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            xulytextbox(false);
            xulybutton(false);
            dgvDanhSachSP.Enabled = true;

            flag = 2;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            cboMaNCC.Text=cboMaNCC.Items.Count.ToString();
            xulytextbox(false);
            dgvDanhSachSP.Enabled = true;
            txtMaSP.ReadOnly = true;
            xulybutton(false);
            //LoadDuLieu_cbo(cboMaLoai, "select*from LOAISP ", "MALOAI", "TENLOAI");
            //LoadDuLieu_cbo(cboMaNCC, "select*from NHACUNGCAP ", "MANCC", "TENNCC");

            flag = 3;

        }
        int flag = 0;




        private void btnHuy_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            xulytextbox(true);
            dgvDanhSachSP.Enabled = true;
            dgvDSCTSP.Columns.Clear();
        }

        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            xulybutton(true);
            
            string sql = "";
            string sqlctsp = "";


            if (flag == 1)
            {
                
                        string chuoi = txtTenSP.Text + " | " + cboMaMau.Text + " | " + cboMaSize.Text + " | " + cboTheHe.Text + " | " + cboLoaiRam.Text + " | " + cboDungLuongRam.Text + " |" + cboOCung.Text + " |" + cboDungLuongOCung.Text + " |" + cboHeDieuHanh.Text;
                        string mactsp = txtMaSP.Text + "_" + cboMaMau.SelectedValue.ToString();
                   
                    sql = "INSERT INTO SANPHAM VALUES('" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + cboMaLoai.SelectedValue + "','" +
                            cboHangSX.SelectedValue + "','" + cboMaNCC.SelectedValue + "','" + cboThoiGianBH.Text + "','" + txtGiaNhap.Text + "','" + txtGiaBan.Text + "','" + txtSoLuong.Text + "','" +
                            cboTrangThai.SelectedIndex + "','" + rtbMoTa.Text + "')";
                    //MessageBox.Show(sql);
                    sqlctsp = "insert into  CHITIETSANPHAM(MACTSP,MASP,MASIZE,MAMAU,MALOAI,MOTA) values(N'" + mactsp + "','" + txtMaSP.Text + "','" + cboMaMau.SelectedValue.ToString() + "','" + cboMaSize.SelectedValue.ToString() + "','" + cboMaLoai.SelectedValue + "',N'" + chuoi + "')";
                    //MessageBox.Show(sqlctsp);
         
                if (c.CapNhatDuLieu(sql) > 0 && c.CapNhatDuLieu(sqlctsp) > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                        frmSanPham_Load(sender, e);
                    }
               

            }
            if (flag == 2)
            {//xoa

                sql = "update  SANPHAM set TRANGTHAI='0' where MASP='" + txtMaSP.Text + "'";

                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                    frmSanPham_Load(sender, e);

                }
            }
            if (flag == 3)
            {//sua

                sql = "update SANPHAM set TrangThai='" + cboTrangThai.SelectedIndex + "', TENSP='" + txtTenSP.Text + "', HINH='" + rtbMoTa.Text +"', MANCC='" + cboMaNCC.SelectedValue  + "' where MASP='" + txtMaSP.Text + "'";


                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
                    frmSanPham_Load(sender, e);

                }
            }
            
        
            dgvDanhSachSP.Enabled = true;
        flag = 0;
        }
        int vtctsp=0;
        void load_ctsptheomasp(string masp)
        {
            string s = "select MACTSP,MASP,MASIZE,MAMAU,MALOAI,MOTA from CHITIETSANPHAM WHERE MASP='" + masp + "'";
            dsctsp = c.LayDuLieu(s);
            dgvDSCTSP.DataSource = null;
            dgvDSCTSP.DataSource = dsctsp.Tables[0];
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void btnUp1Hinh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.InitialDirectory = Path.GetFullPath("HinhAnh") + @"\";
                if (o.ShowDialog() == DialogResult.Cancel)

                    o.ShowDialog();
                string TenHinh = o.FileName;
                rtbMoTa.Text = TenHinh;

                Bitmap a = new Bitmap(TenHinh);
                picHinhSP.Image = a;
                picHinhSP.SizeMode = PictureBoxSizeMode.StretchImage;

                string[] ten = TenHinh.Split('\\');

                rtbMoTa.Text =/* ten[ten.Length - 2] + "\\" +*/ ten[ten.Length - 1];
            }
            catch { }
        }

        private void btnUpNhieuHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Path.GetFullPath("HinhAnh") + @"\";
            o.Multiselect = true;

            if (o.ShowDialog() == DialogResult.Cancel)
                o.ShowDialog();
            string[] ChuoiTen = o.FileNames;
            foreach (string TenAnh in ChuoiTen)
            {
                PictureBox p = new PictureBox();
                p.Height = 100;
                p.Width = 100;

                Bitmap z = new Bitmap(TenAnh);
                p.Image = z;
                p.SizeMode = PictureBoxSizeMode.StretchImage;

                //flpTapAnh.Controls.Add(p);

            }
        }
        

        
        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }
        void TaoCotSP()
        {

            dgvDSCTSP.Columns.Clear();
           
                dgvDSCTSP.Columns.Add("MACTSP", "Mã CTSP");
                dgvDSCTSP.Columns.Add("MASP", "Mã Sản Phẩm");
               
                dgvDSCTSP.Columns.Add("MAMAU", "Mã Màu");
                dgvDSCTSP.Columns.Add("MASIZE", "Kích Thước");
                dgvDSCTSP.Columns.Add("MALOAI", "Mã Loại");
                dgvDSCTSP.Columns.Add("MOTA", "Mô Tả");
            
           
         }
            private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        Boolean f = false;
        private void dgvDSCTSP_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 10)
            {
                sql = "update CHITIETSANPHAM set MOTA=N'" + dgvDSCTSP.CurrentRow.Cells[5].Value.ToString() +
                    //"',MASP='" + dgvDSCTSP.CurrentRow.Cells[1].Value.ToString() +
                    //"',MASIZE='" + dgvDSCTSP.CurrentRow.Cells[2].Value.ToString() +
                    //"',MAMAU='" + dgvDSCTSP.CurrentRow.Cells[3].Value.ToString() +              
                    //"',MALOAI='" + dgvDSCTSP.CurrentRow.Cells[4].Value.ToString() + 
                    "' where MACTSP='" + dgvDSCTSP.CurrentRow.Cells[0].Value.ToString() + "'";
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }

            }
        }

        private void txtGiaNhap_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    double GiaNhap = double.Parse(txtGiaNhap.Text);
                    txtGiaBan.Text = (GiaNhap * 2).ToString();

                }
            }
            catch { }
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dlgThoat;
            //dlgThoat = MessageBox.Show("Bạn có muốn thoát không ", " Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlgThoat == DialogResult.No)
            //    e.Cancel = true;
        }


        void hienthianh(string ten)
        {
            if (ten != "")
            {
                picHinhSP.Image = Image.FromFile(@"HinhAnh\" + ten);
                picHinhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                picHinhSP.Visible = true;
            }
            else if (ten == "") picHinhSP.Visible = false;
        }
        private void dgvDanhSachSP_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vt = dgvDanhSachSP.CurrentCell.RowIndex;
            hienthitextbox(ds.Tables[0], vt);
            LoadDuLieu_datagridctsp(dgvDSCTSP, "select MACTSP,MASP,MASIZE,MAMAU,MALOAI,MOTA from CHITIETSANPHAM where MASP ='" + txtMaSP.Text+"'");
            //load_ctsptheomasp(txtMaSP.Text);
            //hienthitextboxCTSP(dsctsp.Tables[0], vt);
            string ten = ds.Tables[0].Rows[vt]["HINH"].ToString();
            hienthianh(ten);
            dgvDSCTSP_CellClick(sender, e);
            

        }
        void xulychuoicbo(string chuoi)
        {
            string[] subs = chuoi.Split('|');

            cboMaMau.Text = subs[1].Trim();
            cboMaSize.Text = subs[2].Trim();
            cboTheHe.Text = subs[3].Trim();
            cboLoaiRam.Text = subs[4].Trim();
            cboDungLuongRam.Text = subs[5].Trim();
            cboOCung.Text = subs[6].Trim();
            cboDungLuongOCung.Text = subs[7].Trim();
            cboHeDieuHanh.Text = subs[8].Trim();

        }
        
        private void dgvDanhSachSP_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {

            string sql = "";
            if (f == true && e.ColumnIndex > 0 && e.ColumnIndex <= 8)
            {
                sql = "update SANPHAM set TENSP=N'" + dgvDanhSachSP.CurrentRow.Cells[1].Value.ToString() +
                        "',MALOAI='" + dgvDanhSachSP.CurrentRow.Cells[2].Value.ToString() +
                        "',MAHANGSX='" + dgvDanhSachSP.CurrentRow.Cells[3].Value.ToString() +
                        "',MANCC='" + dgvDanhSachSP.CurrentRow.Cells[4].Value.ToString() +
                        "',THOIGIANBH='" + dgvDanhSachSP.CurrentRow.Cells[5].Value.ToString() +
                        "',GIANHAP='" + dgvDanhSachSP.CurrentRow.Cells[6].Value.ToString() +
                        "',GIABAN='" + dgvDanhSachSP.CurrentRow.Cells[7].Value.ToString() +
                        "',SOLUONG='" + dgvDanhSachSP.CurrentRow.Cells[8].Value.ToString() +
                        "',TrangThai='" + dgvDanhSachSP.CurrentRow.Cells[9].Value.ToString() +
                        "' where MaSP='" + dgvDanhSachSP.CurrentRow.Cells[10].Value.ToString() + "'";
                if (c.CapNhatDuLieu(sql) > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    frmSanPham_Load(sender, e);
                }

            }
        }
        //string hinh = "";
        //string xulyfikeanh(string filename)
        //{
        //    string[] ten = filename.Split('\\');
        //    return ten[ten.Length - 2] + @"\" + ten[ten.Length - 1];
        //}
        void taoanh_tufileanh(PictureBox p, string filename)
        {
            Bitmap a = new Bitmap(filename);
            p.Image = a;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
       

        private void dgvDanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachSP_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDanhSachSP.ClearSelection();
        }
    }
}
