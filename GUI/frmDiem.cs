using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BULs;
using DTOs;
namespace GUI
{
    public partial class frmDiem : Form
    {
        KhoaBUL khoabul = new KhoaBUL();
        LopHocBUL lopbul = new LopHocBUL();
        MonHocBUL monbul = new MonHocBUL();
        SinhVienBUL sinhvienbul = new SinhVienBUL();
        DiemBUL diembul = new DiemBUL();
        public frmDiem()
        {
            InitializeComponent();
            foreach (KhoaDTO ele in khoabul.LayDanhSachKhoa())
            {
                cmbKhoa.Items.Add(ele.TenKhoa);
            }
            foreach (LopHocDTO ele in lopbul.LayDanhSachLop())
            {
                cmbLop.Items.Add(ele.TenLop);
            }
            foreach (MonHocDTO ele in monbul.LayDanhSachMonHoc())
            {
                cmbMon.Items.Add(ele.tenMon);
            }
            dgvDiem.DataSource = diembul.LayDiem();
        }

        private void txtDiemtk_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenKhoa = cmbKhoa.SelectedItem.ToString();
            cmbLop.SelectedIndex = -1;
            cmbLop.Items.Clear();
            foreach (LopHocDTO ele in lopbul.LayDanhSachLopHocTheoKhoa(tenKhoa))
            {
                cmbLop.Items.Add(ele.TenLop);
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void dgvDSSinhVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDSSinhVien.CurrentCell.RowIndex;
            string maSV = dgvDSSinhVien.Rows[index].Cells[0].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemtb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDieml1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemtb_TextChanged_1(object sender, EventArgs e)
        {
            float d = 0;

            try
            {
                d = float.Parse(txtDiemtb.Text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("sai kieu du lieu");
                txtDiemtb.Text = "";
                return;
            }

            float c = 0;
            try
            {
                c = float.Parse(txtDieml1.Text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("sai kieu du lieu");
                txtDieml1.Text = "";
                return;
            }
            txtDiemtk.Text = Convert.ToString((c * 2 + d) / 3);
        }

        private void txtDieml1_TextChanged_1(object sender, EventArgs e)
        {
            float c = 0;

            try
            {
                c = float.Parse(txtDieml1.Text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("sai kieu du lieu");
                txtDieml1.Text = "";
                return;
            }
            float d = 0;
            try
            {
                d = float.Parse(txtDiemtb.Text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("sai kieu du lieu");
                txtDiemtb.Text = "";
                return;
            }
            txtDiemtk.Text = Convert.ToString((c * 2 + d) / 3);
        }

        private void cmbLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbLop.SelectedIndex != -1)
            {
                string tenLop = cmbLop.SelectedItem.ToString();
                dgvDSSinhVien.DataSource = null;
                dgvDSSinhVien.DataSource = sinhvienbul.LayThongTinSinhVienTheoLop(tenLop);
            }
            else dgvDSSinhVien.DataSource = null;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            int index = dgvDSSinhVien.CurrentCell.RowIndex;

            if (cmbMon.SelectedIndex == -1 || cmbKhoa.SelectedIndex == -1 || cmbLop.SelectedIndex == -1 || index == -1)
                return;
            string maSV = dgvDSSinhVien.Rows[index].Cells[0].Value.ToString();
            string tenMon = cmbMon.SelectedItem.ToString();
            string maMon = "";
            foreach (MonHocDTO ele in monbul.LayDanhSachMonHoc())
            {
                if (ele.tenMon.Equals(tenMon))
                    maMon = ele.maMon;
            }

            float diemtk = ((float)Convert.ToDouble(txtDiemtb.Text) + (float)Convert.ToDouble(txtDieml1.Text) + (float)Convert.ToDouble(txtDieml1.Text)) / 3;
            DiemDTO diem = new DiemDTO(maSV, maMon, (float)Convert.ToDouble(txtDiemtb.Text), (float)Convert.ToDouble(txtDieml1.Text), (float)Convert.ToDouble(txtDiemtk.Text));
            if (diembul.ThemDiem(diem))
            {
                dgvDiem.DataSource = diembul.LayDiem();
                txtDiemtb.Text = "";
                txtDieml1.Text = "";
                txtDiemtk.Text = "";
            }
            else
                MessageBox.Show("khong thanh cong");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int index = dgvDSSinhVien.CurrentCell.RowIndex;
            if (cmbMon.SelectedIndex == -1 || cmbKhoa.SelectedIndex == -1 || cmbLop.SelectedIndex == -1 || index == -1)
                return;
            string maSV = dgvDSSinhVien.Rows[index].Cells[0].Value.ToString();
            string tenMon = cmbMon.SelectedItem.ToString();
            string maMon = "";
            foreach (MonHocDTO ele in monbul.LayDanhSachMonHoc())
            {
                if (ele.tenMon.Equals(tenMon))
                    maMon = ele.maMon;
            }
            if (diembul.XoaDiem(maSV, maMon))
            {
                dgvDiem.DataSource = diembul.LayDiem();
                MessageBox.Show("Thanh cong ");
            }
            else MessageBox.Show("Khong Thanh Cong");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            int index = dgvDSSinhVien.CurrentCell.RowIndex;
            if (cmbMon.SelectedIndex == -1 || cmbKhoa.SelectedIndex == -1 || cmbLop.SelectedIndex == -1 || index == -1)
                return;
            string maSV = dgvDSSinhVien.Rows[index].Cells[0].Value.ToString();
            string tenMon = cmbMon.SelectedItem.ToString();
            string maMon = "";
            foreach (MonHocDTO ele in monbul.LayDanhSachMonHoc())
            {
                if (ele.tenMon.Equals(tenMon))
                    maMon = ele.maMon;
            }

            float diemtk = ((float)Convert.ToDouble(txtDiemtb.Text) + (float)Convert.ToDouble(txtDieml1.Text)) / 3;
            DiemDTO diem = new DiemDTO(maSV, maMon, (float)Convert.ToDouble(txtDiemtb.Text), (float)Convert.ToDouble(txtDieml1.Text), (float)Convert.ToDouble(txtDiemtk.Text));
            if (diembul.SuaDiem(diem))
            {
                dgvDiem.DataSource = diembul.LayDiem();
                txtDiemtb.Text = "";
                txtDieml1.Text = "";
                txtDiemtk.Text = "";
            }
            else
                MessageBox.Show("khong thanh cong");
        }
    }
}
