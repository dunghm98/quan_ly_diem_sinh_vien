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
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        KhoaBUL mykhoabul = new KhoaBUL();

        private void Khoa_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            dataGridView1.DataSource = mykhoabul.laydskhoa();
            dataGridView1.Columns[0].HeaderText = "Mã Khoa";
            dataGridView1.Columns[1].HeaderText = "Tên Khoa";
        }
        private void hienthi()
        {
            dataGridView1.DataSource = mykhoabul.laydskhoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cout = 0;
            cout = dataGridView1.Rows.Count;// đếm tất cả các dòng trong datagridview
            String chuoi = "";
            int chuoi2=0;
            chuoi = Convert.ToString(dataGridView1.Rows[cout - 1].Cells[0].Value);
            chuoi2 = Convert.ToInt32((chuoi.Remove(0, 4)));//bỏ đi 3 ký tự bắt đầu từ vị trí 0;
            if (chuoi2 + 1 < 10)
            {
                textBox1.Text = "KHOA000" + (chuoi2+ 1).ToString();
            }
            else if (chuoi2 + 1 >= 10 && chuoi2 + 1 < 100)
            {
                textBox1.Text = "KHOA00" + (chuoi2 + 1).ToString();
            }
            KhoaDTO a = new KhoaDTO(textBox1.Text, textBox2.Text);
            mykhoabul.themmotkhoa(a);
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhoaDTO a = new KhoaDTO(textBox1.Text, textBox2.Text);
            mykhoabul.suamotkhoa(a);
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mykhoabul.xoamotkhoa(textBox1.Text);
            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = mykhoabul.timmotkhoa(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ko tìm thấy khoa vừa nhập");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = mykhoabul.timmotkhoa(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ko tìm thấy khoa vừa nhập");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = false;
            dataGridView1.DataSource = mykhoabul.laydskhoa();
            dataGridView1.Columns[0].HeaderText = "Mã Khoa";
            dataGridView1.Columns[1].HeaderText = "Tên Khoa";

        }
        

    }
}
