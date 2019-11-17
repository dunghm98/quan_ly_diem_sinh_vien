namespace GUI
{
    partial class frmPrintCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintCard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMsv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barcodePic = new System.Windows.Forms.PictureBox();
            this.avatarPic = new System.Windows.Forms.PictureBox();
            this.btnPrePrint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrintCard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(133, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC THÀNH ĐÔ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(179, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "THẺ SINH VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labelClass);
            this.panel1.Controls.Add(this.labelDOB);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelMsv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.barcodePic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.avatarPic);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 252);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.BackColor = System.Drawing.Color.Transparent;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelClass.Location = new System.Drawing.Point(193, 144);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(57, 15);
            this.labelClass.TabIndex = 15;
            this.labelClass.Text = "Họ tên: ";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.BackColor = System.Drawing.Color.Transparent;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDOB.Location = new System.Drawing.Point(228, 120);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(57, 15);
            this.labelDOB.TabIndex = 14;
            this.labelDOB.Text = "Họ tên: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelName.Location = new System.Drawing.Point(211, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 15);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Họ tên: ";
            // 
            // labelMsv
            // 
            this.labelMsv.AutoSize = true;
            this.labelMsv.BackColor = System.Drawing.Color.Transparent;
            this.labelMsv.Location = new System.Drawing.Point(35, 228);
            this.labelMsv.Name = "labelMsv";
            this.labelMsv.Size = new System.Drawing.Size(13, 13);
            this.labelMsv.TabIndex = 10;
            this.labelMsv.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(43, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã SV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lớp:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(165, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // barcodePic
            // 
            this.barcodePic.BackColor = System.Drawing.Color.Transparent;
            this.barcodePic.Location = new System.Drawing.Point(151, 210);
            this.barcodePic.Name = "barcodePic";
            this.barcodePic.Size = new System.Drawing.Size(241, 31);
            this.barcodePic.TabIndex = 5;
            this.barcodePic.TabStop = false;
            // 
            // avatarPic
            // 
            this.avatarPic.BackColor = System.Drawing.Color.Transparent;
            this.avatarPic.Location = new System.Drawing.Point(24, 98);
            this.avatarPic.Name = "avatarPic";
            this.avatarPic.Size = new System.Drawing.Size(95, 109);
            this.avatarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPic.TabIndex = 3;
            this.avatarPic.TabStop = false;
            // 
            // btnPrePrint
            // 
            this.btnPrePrint.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrePrint.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPrePrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrePrint.BorderRadius = 0;
            this.btnPrePrint.ButtonText = "Xem trước";
            this.btnPrePrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrePrint.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrePrint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrePrint.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrePrint.Iconimage")));
            this.btnPrePrint.Iconimage_right = null;
            this.btnPrePrint.Iconimage_right_Selected = null;
            this.btnPrePrint.Iconimage_Selected = null;
            this.btnPrePrint.IconMarginLeft = 0;
            this.btnPrePrint.IconMarginRight = 0;
            this.btnPrePrint.IconRightVisible = true;
            this.btnPrePrint.IconRightZoom = 0D;
            this.btnPrePrint.IconVisible = true;
            this.btnPrePrint.IconZoom = 90D;
            this.btnPrePrint.IsTab = false;
            this.btnPrePrint.Location = new System.Drawing.Point(509, 22);
            this.btnPrePrint.Name = "btnPrePrint";
            this.btnPrePrint.Normalcolor = System.Drawing.Color.SandyBrown;
            this.btnPrePrint.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnPrePrint.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrePrint.selected = false;
            this.btnPrePrint.Size = new System.Drawing.Size(109, 41);
            this.btnPrePrint.TabIndex = 36;
            this.btnPrePrint.Text = "Xem trước";
            this.btnPrePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrePrint.Textcolor = System.Drawing.Color.White;
            this.btnPrePrint.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrePrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrintCard
            // 
            this.btnPrintCard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPrintCard.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPrintCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintCard.BorderRadius = 0;
            this.btnPrintCard.ButtonText = "In thẻ";
            this.btnPrintCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintCard.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintCard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintCard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintCard.Iconimage")));
            this.btnPrintCard.Iconimage_right = null;
            this.btnPrintCard.Iconimage_right_Selected = null;
            this.btnPrintCard.Iconimage_Selected = null;
            this.btnPrintCard.IconMarginLeft = 0;
            this.btnPrintCard.IconMarginRight = 0;
            this.btnPrintCard.IconRightVisible = true;
            this.btnPrintCard.IconRightZoom = 0D;
            this.btnPrintCard.IconVisible = true;
            this.btnPrintCard.IconZoom = 90D;
            this.btnPrintCard.IsTab = false;
            this.btnPrintCard.Location = new System.Drawing.Point(509, 75);
            this.btnPrintCard.Name = "btnPrintCard";
            this.btnPrintCard.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.btnPrintCard.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnPrintCard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPrintCard.selected = false;
            this.btnPrintCard.Size = new System.Drawing.Size(109, 41);
            this.btnPrintCard.TabIndex = 37;
            this.btnPrintCard.Text = "In thẻ";
            this.btnPrintCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintCard.Textcolor = System.Drawing.Color.White;
            this.btnPrintCard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCard.Click += new System.EventHandler(this.btnPrintCard_Click);
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Trở về";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 90D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(509, 130);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.LightSlateGray;
            this.btnBack.OnHovercolor = System.Drawing.Color.ForestGreen;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(109, 41);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Trở về";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPrintCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(640, 380);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintCard);
            this.Controls.Add(this.btnPrePrint);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrintCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrintCard";
            this.Load += new System.EventHandler(this.frmPrintCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox avatarPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox barcodePic;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrePrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMsv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintCard;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
    }
}