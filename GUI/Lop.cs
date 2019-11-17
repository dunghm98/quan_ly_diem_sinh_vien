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
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        LopHocBUL myLopbul = new LopHocBUL();
        KhoaBUL myKhoabul = new KhoaBUL();

        private void Lop_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            comboBox1.DataSource = myKhoabul.LayDanhSachKhoa();
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "MaKhoa";
            dataGridView1.DataSource = myLopbul.LayDanhSachLop();
            dataGridView1.Columns[0].HeaderText = "Mã Lớp";
            dataGridView1.Columns[1].HeaderText = "Tên Lớp";
            dataGridView1.Columns[2].HeaderText = "Tên Khoa";
        }
        private void hienthi()
        {
            dataGridView1.DataSource = myLopbul.LayDanhSachLop();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cout = 0;
            cout = dataGridView1.Rows.Count;// đếm tất cả các dòng trong datagridview
            String chuoi = "";
            int chuoi2 = 0;
            chuoi = Convert.ToString(dataGridView1.Rows[cout - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));//bỏ đi 3 ký tự bắt đầu từ vị trí 0;
            if (chuoi2 + 1 < 10)
            {
                textBox1.Text = "LOP000" + (chuoi2 + 1).ToString();
            }
            else if (chuoi2 + 1 >= 10 && chuoi2 + 1 < 100)
            {
                textBox1.Text = "LOP00" + (chuoi2 + 1).ToString();
            }
            LopHocDTO a = new LopHocDTO(textBox1.Text, textBox3.Text, comboBox1.SelectedValue.ToString());
            myLopbul.themmotLop(a);
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LopHocDTO a = new LopHocDTO(textBox1.Text, textBox3.Text, comboBox1.SelectedValue.ToString());
            myLopbul.suamotLop(a);
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myLopbul.xoamotLop(textBox1.Text);
            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = myLopbul.timmotLop(textBox4.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ko tim thấy Lớp vừa nhập");
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = myLopbul.timmotLop(textBox4.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ko tim thấy Lớp vừa nhập");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            dataGridView1.DataSource = myLopbul.LayDanhSachLop();
            dataGridView1.Columns[0].HeaderText = "Mã Lớp";
            dataGridView1.Columns[1].HeaderText = "Tên Lớp";
        }
    }
}
