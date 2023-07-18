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
    public partial class frmThongKeHoaDon : Form
    {
        public frmThongKeHoaDon()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
           
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
          
            panelDestop.Controls.Add(childForm);
            panelDestop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
         

        }
        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeHoaDonNhap());
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeHoaDonBan());
        }
    }
}
