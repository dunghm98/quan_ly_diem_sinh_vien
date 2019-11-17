using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTOs;
using BULs;

namespace GUI
{
    public partial class UC_SinhVien : UserControl
    {
        public UC_SinhVien()
        {
            InitializeComponent();
        }
        SinhVienBUL mySvBUL = new SinhVienBUL();
        LopHocBUL myLopHocBul = new LopHocBUL();
        KhoaBUL myKhoaBUL = new KhoaBUL();
        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                HienThiDuLieu();
                LoadDataToCollection();
                btnEditStudent.Enabled = false;
                btnDeleteStudent.Enabled = false;
             
                
            }
        }
        private void HienThiDuLieu()
        {

            // hiển thị dữ liệu trong datatable lên gridview
            dgvStudent.DataSource = mySvBUL.LayDsSv();
            // định dạng datagridview
            dgvStudent.Columns[0].HeaderText = "Mã sinh viên";

            dgvStudent.Columns[1].HeaderText = "Tên sinh viên";

            dgvStudent.Columns[2].HeaderText = "Ngày sinh";

            dgvStudent.Columns[3].HeaderText = "Giới tính";
            dgvStudent.Columns[3].Width = 70;

            dgvStudent.Columns[4].HeaderText = "Địa chỉ";

            dgvStudent.Columns[5].HeaderText = "Điện thoại";

            dgvStudent.Columns[6].HeaderText = "Email";

            dgvStudent.Columns[7].HeaderText = "Tên Lớp";

            dgvStudent.Columns[8].HeaderText = "Tên Khoa";
            


        }
        private void LoadDataToCollection()
        {
            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            txtSearch.AutoCompleteMode = AutoCompleteMode.Append;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string[] arrayName = mySvBUL.LayDsIDSv().ToArray();
            foreach (string name in arrayName)
            {
                auto1.Add(name);
            }

            txtSearch.AutoCompleteCustomSource = auto1;
            txtSearch.AutoCompleteCustomSource = auto1;
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddSinhVien Asv = new frmAddSinhVien();
            Asv.ShowDialog();
            HienThiDuLieu();


        }

        private void dgvStudent_Click(object sender, EventArgs e)
        {
            btnDeleteStudent.Enabled = true;
            btnEditStudent.Enabled = true;
         

        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            int index = dgvStudent.CurrentRow.Index;
            string Tenlop = dgvStudent.Rows[index].Cells[7].Value.ToString();
            string Tenkhoa = dgvStudent.Rows[index].Cells[8].Value.ToString();

            frmEditSinhVien fsv = new frmEditSinhVien(Tenlop,Tenkhoa);

            
            
            

            fsv.txtMasv.Text = dgvStudent.Rows[index].Cells[0].Value.ToString();
            fsv.dateTimeSv.Text = dgvStudent.Rows[index].Cells[2].Value.ToString();
            fsv.txtTen.Text = dgvStudent.Rows[index].Cells[1].Value.ToString();
            //fsv.cbLop.Text = dgvStudent.Rows[index].Cells[7].Value.ToString();
           // fsv.cbKhoa.Text = dgvStudent.Rows[index].Cells[8].Value.ToString();
           
            if (dgvStudent.Rows[index].Cells[3].Value.ToString().Equals("Nam"))
            {
                fsv.rdNam.Checked = true;
            }
            else
                fsv.rdNu.Checked = true;

            fsv.txtDiaChi.Text = dgvStudent.Rows[index].Cells[4].Value.ToString();

            fsv.txtSdt.Text = dgvStudent.CurrentRow.Cells[5].Value.ToString();

            fsv.txtEmail.Text = dgvStudent.CurrentRow.Cells[6].Value.ToString();

            fsv.ShowDialog();
            HienThiDuLieu();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            mySvBUL.XoaSV(dgvStudent.CurrentRow.Cells[0].Value.ToString());
            HienThiDuLieu();
        }

        private void btnAddStudent_Leave(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }



        private void panel1_MouseHover(object sender, EventArgs e)
        {
            //HienThiDuLieu();
        }

        private void panel1_BindingContextChanged(object sender, EventArgs e)
        {
            //HienThiDuLieu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = mySvBUL.TimSinhVienTheoMa(txtSearch.Text);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }




    }
}
