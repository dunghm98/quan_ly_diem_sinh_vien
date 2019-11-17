using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULs;

namespace GUI
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

            if (!this.DesignMode)
            {
                SinhVienBUL sv = new SinhVienBUL();
                LopHocBUL lop = new LopHocBUL();
                LopHocBUL gv = new LopHocBUL();
                numSV.Text = sv.countSv();
                numLop.Text = lop.countLop();
                numGv.Text = gv.countGv();
                
        
                


            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword cps = new frmChangePassword();
            cps.ShowDialog();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            //frmAddSinhVien sv = new frmAddSinhVien();
            //sv.ShowDialog();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //frmUser user = new frmUser();
            //user.ShowDialog();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            frmDiem d = new frmDiem();
            d.ShowDialog();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Khoa k = new Khoa();
            k.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            GiangVienGUI gv = new GiangVienGUI();
            gv.ShowDialog();
        }


    }
}
