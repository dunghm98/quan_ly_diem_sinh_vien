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
using System.IO;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class frmAddSinhVien : Form
    {
        public frmAddSinhVien()
        {
            InitializeComponent();      
        }
        LopHocBUL myLopHocBul = new LopHocBUL();
        KhoaBUL myKhoaBUL = new KhoaBUL();
        SinhVienBUL mySvBUL = new SinhVienBUL();
        PictureBUL myPicBul = new PictureBUL();

        private void frmSuaSinhVien_Load(object sender, EventArgs e)
        {
            
            cbKhoa.DataSource = myKhoaBUL.LayDanhSachKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbLop.ValueMember = "MaLop";
            cbKhoa.ValueMember = "MaKhoa";
            //cbLop.DataSource = myLopHocBul.LayDanhSachLop();
            cbLop.DisplayMember = "TenLop";
           
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenKhoa = cbKhoa.Text.ToString();
            //cbLop.SelectedIndex = -1;
            //cbLop.Items.Clear();
            cbLop.DataSource = myLopHocBul.LayDanhSachLopHocTheoKhoa(tenKhoa);
          /*
            foreach (LopHocDTO ele in myLopHocBul.LayDanhSachLopHocTheoKhoa(tenKhoa))
            {
                cbLop.Items.Add(ele.TenLop);
                
            }
           */
        }

           

        private void btnXoa_Click(object sender, EventArgs e)
        {
            mySvBUL.XoaSV(txtMasv.Text);
            clear();
          
        }
        private void clear() {
            txtMasv.Clear();
            txtTen.Clear();
            txtSdt.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        private void open()
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    picName.Text = f.FileName.ToString();
                }
            }
            catch { }

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            open();
        }

        private string getMaSv(){
            string maKhoa = "";
            string maLop = "";
            string maTang = "";
            maKhoa = cbKhoa.SelectedValue.ToString().Remove(0, 6).Trim();

            maLop = cbLop.SelectedValue.ToString().Remove(0, 5).Trim();
            maTang = mySvBUL.tangMa();
            string ma = "19" + maKhoa + maLop + maTang;
            return ma;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
       
            
          //  Thêm sinh viên
            SinhVienDTO sv = new SinhVienDTO();

                sv.MaSinhVien = getMaSv();

                sv.TenSinhVien = txtTen.Text;
                sv.NgaySinh = dateTimeSv.Text;
                if (rdNam.Checked)
                {
                    sv.GioiTinh = rdNam.Text;
                }
                else
                {
                    sv.GioiTinh = rdNu.Text;
                }
                sv.DiaChi = txtDiaChi.Text;
                sv.MaLop = cbLop.SelectedValue.ToString();
                sv.MaKhoa = cbKhoa.SelectedValue.ToString();
                sv.Sdt = txtSdt.Text;
                sv.Email = txtEmail.Text;
                if (txtTen.Text == "" || txtSdt.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || rdNu.Checked == false && rdNam.Checked == false)
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else if (picName.Text == "...")
                    MessageBox.Show("Hãy chọn ảnh thẻ sinh viên");
                else
                {
                    mySvBUL.ThemMoiSinhVien(sv);
                    // Thêm ảnh
                    savepicture();

                    MessageBox.Show("Thêm Thành Công", "Program");
                }

            
           
            
        }
        private void savepicture()
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] a = ms.GetBuffer();
                ms.Close();
                double ma = double.Parse(getMaSv().ToString());
                ma = ma - 1;
                ma.ToString();
                myPicBul.SaveToImg(a, picName.Text.ToString(), ma.ToString());
                //picName.Text = "";
               // pictureBox1.Image = null;
                
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
      
        
       
        
    }
}
