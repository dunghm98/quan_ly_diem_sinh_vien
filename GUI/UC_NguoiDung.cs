using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULs;
using DTOs;

namespace GUI
{
    public partial class UC_NguoiDung : UserControl
    {
        public UC_NguoiDung()
        {
            InitializeComponent();
        }
        UserBUL myUserBUL = new UserBUL();
        LoaiQuyenBUL myLoaiQuyenBUL = new LoaiQuyenBUL();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void HienThiDuLieu()
        {
            // hiển thị dữ liệu trong datatable lên gridview
            dgvUser.DataSource = myUserBUL.LayDsUser();
            // định dạng datagridview
            dgvUser.Columns[3].HeaderText = "Tên người dùng";

            dgvUser.Columns[0].HeaderText = "Tên đăng nhập";

            dgvUser.Columns[1].HeaderText = "Mật khẩu";

            dgvUser.Columns[2].HeaderText = "Quyền";



        }

        public string AutoId()
        {
            int count = 0;
            count = dgvUser.Rows.Count;// đếm tất cả các dòng trong datagridview
            int stt = count;
            String chuoi = "";
            if (count < 10)
                chuoi = "SV00" + stt.ToString();
            else if (count < 100)
                chuoi = "SV0" + stt.ToString();
            else
                chuoi = "SV" + stt.ToString();
            return chuoi;


        }

        private void UC_NguoiDung_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                HienThiDuLieu();
                LoadDataToCollection();
                btnEditUser.Enabled = false;
                btnDeleteUser.Enabled = false;
                //string i = AutoId();
                //MessageBox.Show(i);
            }
        }

        private void LoadDataToCollection()
        {
            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            txtSearch.AutoCompleteMode = AutoCompleteMode.Append;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string[] arrayName = myUserBUL.LayDsUserName().ToArray();
            foreach (string name in arrayName)
            {
                auto1.Add(name);
            }

            txtSearch.AutoCompleteCustomSource = auto1;
            txtSearch.AutoCompleteCustomSource = auto1;
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser add = new frmAddUser();
            add.ShowDialog();
            HienThiDuLieu();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            myUserBUL.XoaUser(dgvUser.CurrentRow.Cells[0].Value.ToString());
            HienThiDuLieu();
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            btnDeleteUser.Enabled = true;
            btnEditUser.Enabled = true;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            frmEditUser fu = new frmEditUser();
            fu.txtName.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            fu.txtUsername.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            fu.txtPassword.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            fu.cbQuyen.SelectedValue = dgvUser.CurrentRow.Cells[2].Selected;
            fu.ShowDialog();
            HienThiDuLieu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = myUserBUL.TimUserTheoMa(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }





    }
}
