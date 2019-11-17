namespace GUI
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTimkiemDiem = new System.Windows.Forms.DataGridView();
            this.MaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThiLan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiemMonHoc = new System.Windows.Forms.Button();
            this.btnTimkiemSV = new System.Windows.Forms.Button();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtmaSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // DiemTongKet
            // 
            this.DiemTongKet.DataPropertyName = "DiemTongKet";
            this.DiemTongKet.HeaderText = "DiemTongKet";
            this.DiemTongKet.Name = "DiemTongKet";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 44);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tìm Kiếm Điểm Sinh Viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // dgvTimkiemDiem
            // 
            this.dgvTimkiemDiem.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvTimkiemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiemDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSinhVien,
            this.MaMonHoc,
            this.DiemTB,
            this.DiemThiLan1,
            this.DiemTongKet});
            this.dgvTimkiemDiem.Location = new System.Drawing.Point(248, 73);
            this.dgvTimkiemDiem.Name = "dgvTimkiemDiem";
            this.dgvTimkiemDiem.Size = new System.Drawing.Size(532, 304);
            this.dgvTimkiemDiem.TabIndex = 37;
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.DataPropertyName = "maSV";
            this.MaSinhVien.HeaderText = "MaSinhVien";
            this.MaSinhVien.Name = "MaSinhVien";
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "maMon";
            this.MaMonHoc.HeaderText = "MaMonHoc";
            this.MaMonHoc.Name = "MaMonHoc";
            // 
            // DiemTB
            // 
            this.DiemTB.DataPropertyName = "DiemTB";
            this.DiemTB.HeaderText = "DiemTB";
            this.DiemTB.Name = "DiemTB";
            // 
            // DiemThiLan1
            // 
            this.DiemThiLan1.DataPropertyName = "DiemThiLan1";
            this.DiemThiLan1.HeaderText = "DiemThiLan1";
            this.DiemThiLan1.Name = "DiemThiLan1";
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(107, 97);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(112, 21);
            this.cmbTenLop.TabIndex = 39;
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tên Lớp";
            // 
            // btnTimKiemMonHoc
            // 
            this.btnTimKiemMonHoc.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiemMonHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimKiemMonHoc.Location = new System.Drawing.Point(51, 309);
            this.btnTimKiemMonHoc.Name = "btnTimKiemMonHoc";
            this.btnTimKiemMonHoc.Size = new System.Drawing.Size(156, 23);
            this.btnTimKiemMonHoc.TabIndex = 36;
            this.btnTimKiemMonHoc.Text = "Tìm kiếm theo Môn học";
            this.btnTimKiemMonHoc.UseVisualStyleBackColor = false;
            this.btnTimKiemMonHoc.Click += new System.EventHandler(this.btnTimKiemMonHoc_Click_1);
            // 
            // btnTimkiemSV
            // 
            this.btnTimkiemSV.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimkiemSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimkiemSV.Location = new System.Drawing.Point(45, 216);
            this.btnTimkiemSV.Name = "btnTimkiemSV";
            this.btnTimkiemSV.Size = new System.Drawing.Size(156, 23);
            this.btnTimkiemSV.TabIndex = 35;
            this.btnTimkiemSV.Text = "Tìm kiếm theo SV";
            this.btnTimkiemSV.UseVisualStyleBackColor = false;
            this.btnTimkiemSV.Click += new System.EventHandler(this.btnTimkiemSV_Click_1);
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(107, 269);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(100, 20);
            this.txtMaMon.TabIndex = 34;
            // 
            // txtmaSV
            // 
            this.txtmaSV.Location = new System.Drawing.Point(107, 179);
            this.txtmaSV.Name = "txtmaSV";
            this.txtmaSV.Size = new System.Drawing.Size(100, 20);
            this.txtmaSV.TabIndex = 33;
            this.txtmaSV.TextChanged += new System.EventHandler(this.txtmaSV_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(17, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã sinh viên";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTimkiemDiem);
            this.Controls.Add(this.cmbTenLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiemMonHoc);
            this.Controls.Add(this.btnTimkiemSV);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.txtmaSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmTimKiem";
            this.Text = "TimKiemDiemSinhVien";
            this.Load += new System.EventHandler(this.frmTimKiem_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiemDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongKet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTimkiemDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThiLan1;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiemMonHoc;
        private System.Windows.Forms.Button btnTimkiemSV;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtmaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}