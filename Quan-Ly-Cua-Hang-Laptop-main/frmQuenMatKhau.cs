﻿using System;
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
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string email =txtEmail.Text;
            if(email.Trim() =="")
            {
                MessageBox.Show(" Vui lòng nhập email", "Thông báo");
            }
            else
            {
                string sql = "select * from DANGNHAP where Email ='" + email + "'";
                
               
            }
        }
    }
}
