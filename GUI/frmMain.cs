using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Bunifu;
using BULs;

namespace GUI
{
    public partial class frmMain : Form
    {
        private string userName;
        UserBUL userBul = new UserBUL();
        public frmMain(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            dashboard1.BringToFront();
    
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            labelUser.Text = userBul.getTenNgDung(userName);
            if (userBul.checkQuyenUser(userName) == 0)
            {
                btnUser.Enabled = false;
                btnTeacher.Enabled = false;
                btnMajor.Enabled = false;
                btnClass.Enabled = false;
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //frmSinhVien sv = new frmSinhVien();
            //sv.ShowDialog();
            uC_SinhVien1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            dashboard1.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //frmUser us = new frmUser();
            //us.ShowDialog();
            uC_NguoiDung1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            GiangVienGUI a = new GiangVienGUI();
            a.ShowDialog();
            //uC_GiangVien1.BringToFront();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser us = new frmUser();
            us.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMajor_Click(object sender, EventArgs e)
        {
            Khoa a = new Khoa();
            a.ShowDialog();
            //uC_Khoa1.BringToFront();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Lop a = new Lop();
            a.ShowDialog();
            //uC_Lop1.BringToFront();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            frmDiem d = new frmDiem();
            d.ShowDialog();
          
        }

        private void thôngTinĐiểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem t = new frmTimKiem();
            t.ShowDialog();
            
           
        }

    

      
  
    }
}
