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

namespace GUI
{
    public partial class frmEditSinhVien : Form
    {
        string Lop;
        string Khoa;
        public frmEditSinhVien(string lop, string khoa)
        {
            InitializeComponent();
            this.Khoa = khoa;
            this.Lop = lop;
        }
        PictureBUL myPicBul = new PictureBUL();
        LopHocBUL myLopHocBul = new LopHocBUL();
        KhoaBUL myKhoaBUL = new KhoaBUL();
        SinhVienBUL mySvBUL = new SinhVienBUL();

        private void frmEditSinhVien_Load(object sender, EventArgs e)
        {
            cbKhoa.DataSource = myKhoaBUL.LayDanhSachKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbLop.ValueMember = "MaLop";
            cbKhoa.ValueMember = "MaKhoa";
            //cbLop.DataSource = myLopHocBul.LayDanhSachLop();
            cbLop.DisplayMember = "TenLop";
            loadBarcode();
            pictureBox1.Image = Image.FromStream(myPicBul.LayImage(txtMasv.Text));

           
            cbKhoa.Text = Khoa;
            cbLop.Text = Lop;
           // picName.Text = 
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SinhVienDTO sv = new SinhVienDTO();
            sv.MaSinhVien = txtMasv.Text;
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
                MessageBox.Show("Hãy nhập đầy đủ thông tin","Thông báo");
            else
            {
                mySvBUL.SuaThongTinSinhVien(sv);
                // Sửa ảnh
                savepicture();

                MessageBox.Show("Lưu Thành Công", "Program");
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
                
                myPicBul.UpdateImage(a, picName.Text.ToString(),txtMasv.Text);
                //picName.Text = "";
                // pictureBox1.Image = null;
               
            }
        }
        private void loadBarcode() {
            string barcode = txtMasv.Text;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                barcodePic.Image = brCode.Draw(barcode, 50);
            }
            catch(Exception) {  }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bntChoseFile_Click(object sender, EventArgs e)
        {
            open();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string lop = cbLop.Text;
            string dob = dateTimeSv.Text;
            frmPrintCard pr = new frmPrintCard(txtMasv.Text, txtTen.Text, lop, dob);
            pr.ShowDialog();
            
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenKhoa = cbKhoa.Text.ToString();
            
            cbLop.DataSource = myLopHocBul.LayDanhSachLopHocTheoKhoa(tenKhoa);
        }
    }
}
