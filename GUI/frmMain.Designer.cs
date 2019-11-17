namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMajor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMark = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTeacher = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảngViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐiểmSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêKếtQuảTừngKìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmTổngKếtSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHọcBổnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênThiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênHọcLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_SinhVien1 = new GUI.UC_SinhVien();
            this.uC_NguoiDung1 = new GUI.UC_NguoiDung();
            this.dashboard1 = new GUI.Dashboard();
            this.SidePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.SidePanel.Controls.Add(this.btnLogOut);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Controls.Add(this.btnUser);
            this.SidePanel.Controls.Add(this.btnClass);
            this.SidePanel.Controls.Add(this.btnMajor);
            this.SidePanel.Controls.Add(this.btnMark);
            this.SidePanel.Controls.Add(this.btnTeacher);
            this.SidePanel.Controls.Add(this.btnStudent);
            this.SidePanel.Controls.Add(this.btnHome);
            this.SidePanel.Controls.Add(this.LogoPanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(217, 671);
            this.SidePanel.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "Đăng Xuất";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 60D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(0, 389);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(217, 43);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Textcolor = System.Drawing.Color.LightGray;
            this.btnLogOut.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 109);
            this.panel1.TabIndex = 10;
            // 
            // btnUser
            // 
            this.btnUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUser.BorderRadius = 0;
            this.btnUser.ButtonText = "Người Dùng";
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUser.Iconimage")));
            this.btnUser.Iconimage_right = null;
            this.btnUser.Iconimage_right_Selected = null;
            this.btnUser.Iconimage_Selected = null;
            this.btnUser.IconMarginLeft = 0;
            this.btnUser.IconMarginRight = 0;
            this.btnUser.IconRightVisible = true;
            this.btnUser.IconRightZoom = 0D;
            this.btnUser.IconVisible = true;
            this.btnUser.IconZoom = 70D;
            this.btnUser.IsTab = false;
            this.btnUser.Location = new System.Drawing.Point(0, 346);
            this.btnUser.Name = "btnUser";
            this.btnUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnUser.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnUser.selected = false;
            this.btnUser.Size = new System.Drawing.Size(217, 43);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "Người Dùng";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUser.Textcolor = System.Drawing.Color.LightGray;
            this.btnUser.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnClass
            // 
            this.btnClass.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClass.BorderRadius = 0;
            this.btnClass.ButtonText = "Lớp";
            this.btnClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClass.DisabledColor = System.Drawing.Color.Gray;
            this.btnClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClass.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClass.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClass.Iconimage")));
            this.btnClass.Iconimage_right = null;
            this.btnClass.Iconimage_right_Selected = null;
            this.btnClass.Iconimage_Selected = null;
            this.btnClass.IconMarginLeft = 0;
            this.btnClass.IconMarginRight = 0;
            this.btnClass.IconRightVisible = true;
            this.btnClass.IconRightZoom = 0D;
            this.btnClass.IconVisible = true;
            this.btnClass.IconZoom = 50D;
            this.btnClass.IsTab = false;
            this.btnClass.Location = new System.Drawing.Point(0, 303);
            this.btnClass.Name = "btnClass";
            this.btnClass.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnClass.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnClass.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnClass.selected = false;
            this.btnClass.Size = new System.Drawing.Size(217, 43);
            this.btnClass.TabIndex = 8;
            this.btnClass.Text = "Lớp";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClass.Textcolor = System.Drawing.Color.LightGray;
            this.btnClass.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnMajor
            // 
            this.btnMajor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMajor.BorderRadius = 0;
            this.btnMajor.ButtonText = "Khoa";
            this.btnMajor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMajor.DisabledColor = System.Drawing.Color.Gray;
            this.btnMajor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMajor.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMajor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMajor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMajor.Iconimage")));
            this.btnMajor.Iconimage_right = null;
            this.btnMajor.Iconimage_right_Selected = null;
            this.btnMajor.Iconimage_Selected = null;
            this.btnMajor.IconMarginLeft = 0;
            this.btnMajor.IconMarginRight = 0;
            this.btnMajor.IconRightVisible = true;
            this.btnMajor.IconRightZoom = 0D;
            this.btnMajor.IconVisible = true;
            this.btnMajor.IconZoom = 70D;
            this.btnMajor.IsTab = false;
            this.btnMajor.Location = new System.Drawing.Point(0, 260);
            this.btnMajor.Name = "btnMajor";
            this.btnMajor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnMajor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnMajor.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnMajor.selected = false;
            this.btnMajor.Size = new System.Drawing.Size(217, 43);
            this.btnMajor.TabIndex = 7;
            this.btnMajor.Text = "Khoa";
            this.btnMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMajor.Textcolor = System.Drawing.Color.LightGray;
            this.btnMajor.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMajor.Click += new System.EventHandler(this.btnMajor_Click);
            // 
            // btnMark
            // 
            this.btnMark.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMark.BorderRadius = 0;
            this.btnMark.ButtonText = "Điểm ";
            this.btnMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMark.DisabledColor = System.Drawing.Color.Gray;
            this.btnMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMark.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMark.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMark.Iconimage")));
            this.btnMark.Iconimage_right = null;
            this.btnMark.Iconimage_right_Selected = null;
            this.btnMark.Iconimage_Selected = null;
            this.btnMark.IconMarginLeft = 0;
            this.btnMark.IconMarginRight = 0;
            this.btnMark.IconRightVisible = true;
            this.btnMark.IconRightZoom = 0D;
            this.btnMark.IconVisible = true;
            this.btnMark.IconZoom = 50D;
            this.btnMark.IsTab = false;
            this.btnMark.Location = new System.Drawing.Point(0, 217);
            this.btnMark.Name = "btnMark";
            this.btnMark.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnMark.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnMark.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnMark.selected = false;
            this.btnMark.Size = new System.Drawing.Size(217, 43);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "Điểm ";
            this.btnMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMark.Textcolor = System.Drawing.Color.LightGray;
            this.btnMark.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacher.BorderRadius = 0;
            this.btnTeacher.ButtonText = "Giảng Viên";
            this.btnTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacher.DisabledColor = System.Drawing.Color.Gray;
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTeacher.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Iconimage")));
            this.btnTeacher.Iconimage_right = null;
            this.btnTeacher.Iconimage_right_Selected = null;
            this.btnTeacher.Iconimage_Selected = null;
            this.btnTeacher.IconMarginLeft = 0;
            this.btnTeacher.IconMarginRight = 0;
            this.btnTeacher.IconRightVisible = true;
            this.btnTeacher.IconRightZoom = 0D;
            this.btnTeacher.IconVisible = true;
            this.btnTeacher.IconZoom = 50D;
            this.btnTeacher.IsTab = false;
            this.btnTeacher.Location = new System.Drawing.Point(0, 174);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTeacher.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTeacher.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnTeacher.selected = false;
            this.btnTeacher.Size = new System.Drawing.Size(217, 43);
            this.btnTeacher.TabIndex = 5;
            this.btnTeacher.Text = "Giảng Viên";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTeacher.Textcolor = System.Drawing.Color.LightGray;
            this.btnTeacher.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudent.BorderRadius = 0;
            this.btnStudent.ButtonText = "Sinh Viên";
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudent.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudent.Iconimage")));
            this.btnStudent.Iconimage_right = null;
            this.btnStudent.Iconimage_right_Selected = null;
            this.btnStudent.Iconimage_Selected = null;
            this.btnStudent.IconMarginLeft = 0;
            this.btnStudent.IconMarginRight = 0;
            this.btnStudent.IconRightVisible = true;
            this.btnStudent.IconRightZoom = 0D;
            this.btnStudent.IconVisible = true;
            this.btnStudent.IconZoom = 50D;
            this.btnStudent.IsTab = false;
            this.btnStudent.Location = new System.Drawing.Point(0, 131);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnStudent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnStudent.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnStudent.selected = false;
            this.btnStudent.Size = new System.Drawing.Size(217, 43);
            this.btnStudent.TabIndex = 4;
            this.btnStudent.Text = "Sinh Viên";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStudent.Textcolor = System.Drawing.Color.LightGray;
            this.btnStudent.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "Trang Chủ";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 40D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(0, 88);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(217, 43);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Textcolor = System.Drawing.Color.LightGray;
            this.btnHome.TextFont = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LogoPanel.Controls.Add(this.pictureBox4);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(217, 88);
            this.LogoPanel.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.HeaderPanel.Controls.Add(this.labelUser);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.pictureBox3);
            this.HeaderPanel.Controls.Add(this.pictureBox2);
            this.HeaderPanel.Controls.Add(this.menuStrip1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(217, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(977, 88);
            this.HeaderPanel.TabIndex = 1;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(792, 49);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(50, 26);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(701, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xin chào";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(68, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(977, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            this.quảnLýNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgườiDùngToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.giảngViênToolStripMenuItem,
            this.điểmToolStripMenuItem,
            this.thiLạiToolStripMenuItem,
            this.họcLạiToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sinhViênToolStripMenuItem.Text = "Sinh viên";
            // 
            // giảngViênToolStripMenuItem
            // 
            this.giảngViênToolStripMenuItem.Name = "giảngViênToolStripMenuItem";
            this.giảngViênToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.giảngViênToolStripMenuItem.Text = "Giảng viên";
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.điểmToolStripMenuItem.Text = "Điểm";
            // 
            // thiLạiToolStripMenuItem
            // 
            this.thiLạiToolStripMenuItem.Name = "thiLạiToolStripMenuItem";
            this.thiLạiToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.thiLạiToolStripMenuItem.Text = "Thi lại";
            // 
            // họcLạiToolStripMenuItem
            // 
            this.họcLạiToolStripMenuItem.Name = "họcLạiToolStripMenuItem";
            this.họcLạiToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.họcLạiToolStripMenuItem.Text = "Học lại";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinĐiểmSinhViênToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // thôngTinĐiểmSinhViênToolStripMenuItem
            // 
            this.thôngTinĐiểmSinhViênToolStripMenuItem.Name = "thôngTinĐiểmSinhViênToolStripMenuItem";
            this.thôngTinĐiểmSinhViênToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.thôngTinĐiểmSinhViênToolStripMenuItem.Text = "Thông tin điểm sinh viên";
            this.thôngTinĐiểmSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐiểmSinhViênToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêKếtQuảTừngKìToolStripMenuItem,
            this.thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem,
            this.điểmTổngKếtSinhViênToolStripMenuItem,
            this.danhSáchHọcBổnhToolStripMenuItem,
            this.danhSáchSinhViênThiLạiToolStripMenuItem,
            this.danhSáchSinhViênHọcLạiToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thốngKêKếtQuảTừngKìToolStripMenuItem
            // 
            this.thốngKêKếtQuảTừngKìToolStripMenuItem.Name = "thốngKêKếtQuảTừngKìToolStripMenuItem";
            this.thốngKêKếtQuảTừngKìToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.thốngKêKếtQuảTừngKìToolStripMenuItem.Text = "Thống kê kết quả từng kì";
            // 
            // thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem
            // 
            this.thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem.Name = "thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem";
            this.thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem.Text = "Thống kê kết quả học tập toàn khóa";
            // 
            // điểmTổngKếtSinhViênToolStripMenuItem
            // 
            this.điểmTổngKếtSinhViênToolStripMenuItem.Name = "điểmTổngKếtSinhViênToolStripMenuItem";
            this.điểmTổngKếtSinhViênToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.điểmTổngKếtSinhViênToolStripMenuItem.Text = "Điểm tổng kết sinh viên";
            // 
            // danhSáchHọcBổnhToolStripMenuItem
            // 
            this.danhSáchHọcBổnhToolStripMenuItem.Name = "danhSáchHọcBổnhToolStripMenuItem";
            this.danhSáchHọcBổnhToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.danhSáchHọcBổnhToolStripMenuItem.Text = "Danh sách học bổng";
            // 
            // danhSáchSinhViênThiLạiToolStripMenuItem
            // 
            this.danhSáchSinhViênThiLạiToolStripMenuItem.Name = "danhSáchSinhViênThiLạiToolStripMenuItem";
            this.danhSáchSinhViênThiLạiToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.danhSáchSinhViênThiLạiToolStripMenuItem.Text = "Danh sách sinh viên thi lại";
            // 
            // danhSáchSinhViênHọcLạiToolStripMenuItem
            // 
            this.danhSáchSinhViênHọcLạiToolStripMenuItem.Name = "danhSáchSinhViênHọcLạiToolStripMenuItem";
            this.danhSáchSinhViênHọcLạiToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.danhSáchSinhViênHọcLạiToolStripMenuItem.Text = "Danh sách sinh viên học lại";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_SinhVien1);
            this.panel2.Controls.Add(this.uC_NguoiDung1);
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(217, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 583);
            this.panel2.TabIndex = 2;
            // 
            // uC_SinhVien1
            // 
            this.uC_SinhVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SinhVien1.Location = new System.Drawing.Point(0, 0);
            this.uC_SinhVien1.Name = "uC_SinhVien1";
            this.uC_SinhVien1.Size = new System.Drawing.Size(977, 583);
            this.uC_SinhVien1.TabIndex = 2;
            // 
            // uC_NguoiDung1
            // 
            this.uC_NguoiDung1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_NguoiDung1.Location = new System.Drawing.Point(0, 0);
            this.uC_NguoiDung1.Name = "uC_NguoiDung1";
            this.uC_NguoiDung1.Size = new System.Drawing.Size(977, 583);
            this.uC_NguoiDung1.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.Gainsboro;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(977, 583);
            this.dashboard1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1194, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SidePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnMajor;
        private Bunifu.Framework.UI.BunifuFlatButton btnMark;
        private Bunifu.Framework.UI.BunifuFlatButton btnTeacher;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudent;
        private Bunifu.Framework.UI.BunifuFlatButton btnUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảngViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họcLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐiểmSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêKếtQuảTừngKìToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêKếtQuảHọcTậpToànKhóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmTổngKếtSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHọcBổnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênThiLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênHọcLạiToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Dashboard dashboard1;
        private UC_NguoiDung uC_NguoiDung1;
        private UC_SinhVien uC_SinhVien1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label1;

    }
}

