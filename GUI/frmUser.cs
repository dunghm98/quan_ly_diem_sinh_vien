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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        UserBUL myUserBUL = new UserBUL();
        LoaiQuyenBUL myLoaiQuyenBUL = new LoaiQuyenBUL();
        private void frmUser_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            cbQuyen.DataSource = myLoaiQuyenBUL.LayDanhSachQuyen();
            cbQuyen.DisplayMember = "Quyen";
            cbQuyen.ValueMember = "MaQuyen";
            btnEdit.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void HienThiDuLieu()
        {
            // hiển thị dữ liệu trong datatable lên gridview
            dgvUser.DataSource = myUserBUL.LayDsUser();
            // định dạng datagridview
            dgvUser.Columns[0].HeaderText = "Tên đăng nhập";
            dgvUser.Columns[0].Width = 100;
            dgvUser.Columns[1].HeaderText = "Mật khẩu";
            dgvUser.Columns[1].Width = 100;
            dgvUser.Columns[2].HeaderText = "Quyền";
            dgvUser.Columns[2].Width = 100;
          
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnXoa.Enabled = true;
            int index = dgvUser.CurrentRow.Index;
            txtUsername.Text = dgvUser.Rows[index].Cells[0].Value.ToString();
            txtPassword.Text = dgvUser.Rows[index].Cells[1].Value.ToString();
            cbQuyen.Text = dgvUser.Rows[index].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserDTO aU = new UserDTO();
            aU.TenDangNhap = txtUsername.Text;
            aU.MatKhau = txtPassword.Text;
            aU.MaQuyen = cbQuyen.SelectedValue.ToString();
            myUserBUL.ThemMoiUser(aU);
            HienThiDuLieu();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserDTO aU = new UserDTO();
            aU.TenDangNhap = txtUsername.Text;
            aU.MatKhau = txtPassword.Text;
            aU.MaQuyen = cbQuyen.SelectedValue.ToString();
            myUserBUL.SuaThongTinUser(aU);
            HienThiDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            myUserBUL.XoaUser(txtUsername.Text);
            clear();
            HienThiDuLieu();
        }
        private void clear() {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
