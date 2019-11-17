using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTOs;
using BULs;
namespace GUI
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        DiemBUL diembul = new DiemBUL();
        LopHocBUL lopbul = new LopHocBUL();
        private void dgvTimkiemDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTimkiemSV_Click(object sender, EventArgs e)
        {
            dgvTimkiemDiem.DataSource = diembul.LayDiemTheoSinhVien(txtmaSV.Text);
        }

        private void btnTimKiemMonHoc_Click(object sender, EventArgs e)
        {
            dgvTimkiemDiem.DataSource = diembul.LayDiemTheoMonHoc(txtMaMon.Text);
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenlop = cmbTenLop.SelectedItem.ToString();
            string malop = "";
            foreach (LopHocDTO ele in lopbul.LayDanhSachLop())
            {
                if (ele.TenLop.Equals(tenlop))
                    malop = ele.MaLop;
            }

            dgvTimkiemDiem.DataSource = diembul.LayDiemTheoLop(malop);
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            foreach (LopHocDTO ele in lopbul.LayDanhSachLop())
            {
                cmbTenLop.Items.Add(ele.TenLop);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmTimKiem_Load_1(object sender, EventArgs e)
        {
            foreach (LopHocDTO ele in lopbul.LayDanhSachLop())
            {
                cmbTenLop.Items.Add(ele.TenLop);
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbTenLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string tenlop = cmbTenLop.SelectedItem.ToString();
            string malop = "";
            foreach (LopHocDTO ele in lopbul.LayDanhSachLop())
            {
                if (ele.TenLop.Equals(tenlop))
                    malop = ele.MaLop;
            }

            dgvTimkiemDiem.DataSource = diembul.LayDiemTheoLop(malop);
        }

        private void txtmaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiemSV_Click_1(object sender, EventArgs e)
        {
            dgvTimkiemDiem.DataSource = diembul.LayDiemTheoSinhVien(txtmaSV.Text);
        }

        private void btnTimKiemMonHoc_Click_1(object sender, EventArgs e)
        {
            dgvTimkiemDiem.DataSource = diembul.LayDiemTheoMonHoc(txtMaMon.Text);
        }
    }
}
