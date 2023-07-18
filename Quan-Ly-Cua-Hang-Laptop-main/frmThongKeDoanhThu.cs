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
    public partial class frmThongKeDoanhThu : Form
    {
        public frmThongKeDoanhThu()
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

        private void btnDoanhThuNgay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDoanhThuNgay());
        }

        private void btnDoanhThuThang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDoanhThuThang());
        }

        private void btnDoanhThuNam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDoanhThuNam());
        }
    }
}
