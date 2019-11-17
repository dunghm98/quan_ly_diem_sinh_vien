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
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }
        UserBUL myUserBUL = new UserBUL();
        LoaiQuyenBUL myLoaiQuyenBUL = new LoaiQuyenBUL();
        private void frmEditUser_Load(object sender, EventArgs e)
        {
            cbQuyen.DataSource = myLoaiQuyenBUL.LayDanhSachQuyen();
            cbQuyen.DisplayMember = "Quyen";
            cbQuyen.ValueMember = "MaQuyen";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserDTO aU = new UserDTO();
            aU.TenDangNhap = txtUsername.Text;
            aU.MatKhau = txtPassword.Text;
            aU.MaQuyen = cbQuyen.SelectedValue.ToString();
            aU.HoTen = txtName.Text;
            myUserBUL.SuaThongTinUser(aU);
            MessageBox.Show("Sửa thành công");
        }
    }
}
