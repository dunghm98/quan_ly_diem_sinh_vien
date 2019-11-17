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
    public partial class GiangVienGUI : Form
    {
        public GiangVienGUI()
        {
            InitializeComponent();
        }
        GiangVienBUL mygiangvienbul = new GiangVienBUL();
        KhoaBUL myKhoa = new KhoaBUL();
        LoaiGiangVienBUL myloai = new LoaiGiangVienBUL();
        private void GiangVien_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            try
            {
                comboBox1.DataSource = myloai.LayDanhSachLoai();
                comboBox1.DisplayMember = "TenLoai1";
                comboBox1.ValueMember = "MaLoai1";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
            cbKhoa.DataSource = myKhoa.LayDanhSachKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            hien();
        }

        private void hien()
        {
            dataGridView1.DataSource = mygiangvienbul.laydsGiangVien();
            dataGridView1.Columns[0].HeaderText = "Mã giảng viên";
            dataGridView1.Columns[1].HeaderText = "Tên giảng viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Điện thoại";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Loại GV";
            dataGridView1.Columns[6].HeaderText = "Khoa";
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int cout = 0;
            cout = dataGridView1.Rows.Count;// đếm tất cả các dòng trong datagridview
            String chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView1.Rows[cout - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));//bỏ đi 3 ký tự bắt đầu từ vị trí 0;
            if (chuoi2 + 1 < 10)
            {
                textBox1.Text = "GV000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 >= 10 && chuoi2 + 1 < 100)
            {
                textBox1.Text = "GV00" + (chuoi2 + 1).ToString();
            }
            GiangVien a = new GiangVien();
            a.Magiangvien = textBox1.Text;
            a.Tengiangvien = textBox2.Text;
            if (radioButton1.Checked)
            {
                a.Gioitinh = radioButton1.Text;
            }
            else
            {
                a.Gioitinh = radioButton2.Text;
            }
            a.Dienthoai = textBox3.Text;
            a.Email = textBox5.Text;
            a.Phanloaigiaovien = comboBox1.SelectedValue.ToString();
            a.Makhoa = cbKhoa.SelectedValue.ToString();
            mygiangvienbul.themmotGiangVien(a);
            hien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiangVien a = new GiangVien();
            a.Magiangvien = textBox1.Text;
            a.Tengiangvien = textBox2.Text;
            if (radioButton1.Checked)
            {
                a.Gioitinh = radioButton1.Text;
            }
            else
            {
                a.Gioitinh = radioButton2.Text;
            }
            a.Dienthoai = textBox3.Text;
            a.Email = textBox5.Text;
            a.Phanloaigiaovien = comboBox1.SelectedValue.ToString();
            a.Makhoa = cbKhoa.SelectedValue.ToString();
            mygiangvienbul.suamotGiangVien(a);
            hien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                mygiangvienbul.xoamotGiangVien(textBox1.Text);
                hien();
            }
            catch (Exception)
            {
                MessageBox.Show("ko thấy mã nhập");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();

            if (dataGridView1.Rows[index].Cells[2].Value.ToString().Equals("Nam"))
            {
                radioButton1.Checked = true;
            }
            if (dataGridView1.Rows[index].Cells[2].Value.ToString().Equals("Nữ"))
            {
                radioButton2.Checked = true;
            }


            textBox3.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            cbKhoa.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = mygiangvienbul.timmotGiangVien(textBox6.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("ko tìm thấy thấy ");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            comboBox1.DataSource = mygiangvienbul.laydsGiangVien();
            comboBox1.DisplayMember = "Phanloaigiaovien";
            cbKhoa.DataSource = myKhoa.LayDanhSachKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            hien();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
