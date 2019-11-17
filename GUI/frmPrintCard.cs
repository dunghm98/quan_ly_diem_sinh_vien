using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BULs;

namespace GUI
{
    public partial class frmPrintCard : Form
    {
        string masv;
        string hoTen;
        string Lop;
        string Dob;
        PictureBUL myPicBul = new PictureBUL();
        public frmPrintCard(string msv, string hoten, string lop, string dob)
        {
            InitializeComponent();
            this.masv = msv;
            this.hoTen = hoten;
            this.Lop = lop;
            this.Dob = dob;
        }

        private void frmPrintCard_Load(object sender, EventArgs e)
        {
            labelMsv.Text = masv;
            labelName.Text = hoTen;
            labelDOB.Text = Dob;
            labelClass.Text = Lop;
            loadBarcode();
            avatarPic.Image = Image.FromStream(myPicBul.LayImage(masv));
        }
        private void loadBarcode()
        {
            string barcode = masv;
            try
            {
                Zen.Barcode.Code128BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                barcodePic.Image = brCode.Draw(barcode, 50);
            }
            catch (Exception) { }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrintCard_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
