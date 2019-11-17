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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }
        UserBUL myUserBUL = new UserBUL();
        LoaiQuyenBUL myLoaiQuyenBUL = new LoaiQuyenBUL();
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            cbQuyen.DataSource = myLoaiQuyenBUL.LayDanhSachQuyen();
            cbQuyen.DisplayMember = "Quyen";
            cbQuyen.ValueMember = "MaQuyen";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDTO aU = new UserDTO();
            aU.TenDangNhap = txtUsername.Text;
            aU.MatKhau = txtPassword.Text;
            aU.MaQuyen = cbQuyen.SelectedValue.ToString();
            aU.HoTen = txtName.Text;
            myUserBUL.ThemMoiUser(aU);
            MessageBox.Show("Thêm thành công!");
            clear();
        }
        private void clear()
        {
            txtUsername.Clear();
            txtName.Clear();
            txtRePassword.Clear();
            txtPassword.Clear();
        }
    }
}
