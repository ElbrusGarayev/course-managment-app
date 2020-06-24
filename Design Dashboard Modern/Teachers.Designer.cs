namespace Design_Dashboard_Modern
{
    partial class TeachersSystem
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersSystem));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.checktask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.createtask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mark = new Bunifu.Framework.UI.BunifuFlatButton();
            this.attendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.submitMark = new Bunifu.Framework.UI.BunifuFlatButton();
            this.submit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pwdbox = new System.Windows.Forms.TextBox();
            this.infos = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panelTask = new System.Windows.Forms.Panel();
            this.tasklink = new System.Windows.Forms.RichTextBox();
            this.submitTask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panelTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(925, 80);
            this.MenuTop.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(848, 24);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 5;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(812, 24);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 4;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(848, 24);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 3;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(884, 24);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 2;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Banjax Notched", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher Information System";
            // 
            // MenuSidebar
            // 
            this.AnimacionSidebar.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.MenuSidebar, BunifuAnimatorNS.DecorationType.None);
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(34, 24);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(30, 30);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 0;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.AnimacionSidebarBack.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.SidebarWrapper, BunifuAnimatorNS.DecorationType.None);
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 80);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(300, 555);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.checktask);
            this.Sidebar.Controls.Add(this.logout);
            this.Sidebar.Controls.Add(this.createtask);
            this.Sidebar.Controls.Add(this.mark);
            this.Sidebar.Controls.Add(this.attendance);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 24);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 519);
            this.Sidebar.TabIndex = 0;
            // 
            // checktask
            // 
            this.checktask.Activecolor = System.Drawing.Color.Transparent;
            this.checktask.BackColor = System.Drawing.Color.Transparent;
            this.checktask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checktask.BorderRadius = 0;
            this.checktask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checktask.ButtonText = "Check Tasks";
            this.checktask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.checktask, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.checktask, BunifuAnimatorNS.DecorationType.None);
            this.checktask.DisabledColor = System.Drawing.Color.Gainsboro;
            this.checktask.Font = new System.Drawing.Font("Bauhaus 93", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checktask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checktask.Iconcolor = System.Drawing.Color.Transparent;
            this.checktask.Iconimage = null;
            this.checktask.Iconimage_right = null;
            this.checktask.Iconimage_right_Selected = null;
            this.checktask.Iconimage_Selected = null;
            this.checktask.IconMarginLeft = 0;
            this.checktask.IconMarginRight = 0;
            this.checktask.IconRightVisible = true;
            this.checktask.IconRightZoom = 0D;
            this.checktask.IconVisible = true;
            this.checktask.IconZoom = 50D;
            this.checktask.IsTab = false;
            this.checktask.Location = new System.Drawing.Point(7, 327);
            this.checktask.Name = "checktask";
            this.checktask.Normalcolor = System.Drawing.Color.Transparent;
            this.checktask.OnHovercolor = System.Drawing.Color.Transparent;
            this.checktask.OnHoverTextColor = System.Drawing.Color.White;
            this.checktask.selected = false;
            this.checktask.Size = new System.Drawing.Size(252, 51);
            this.checktask.TabIndex = 14;
            this.checktask.Text = "Check Tasks";
            this.checktask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checktask.Textcolor = System.Drawing.Color.Black;
            this.checktask.TextFont = new System.Drawing.Font("Cera Stencil", 13F);
            this.checktask.Click += new System.EventHandler(this.Checktask_Click);
            // 
            // logout
            // 
            this.logout.Activecolor = System.Drawing.Color.Transparent;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.BorderRadius = 0;
            this.logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logout.ButtonText = "LOG OUT";
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.DisabledColor = System.Drawing.Color.Gray;
            this.logout.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout.Iconcolor = System.Drawing.Color.Transparent;
            this.logout.Iconimage = null;
            this.logout.Iconimage_right = null;
            this.logout.Iconimage_right_Selected = null;
            this.logout.Iconimage_Selected = null;
            this.logout.IconMarginLeft = 0;
            this.logout.IconMarginRight = 0;
            this.logout.IconRightVisible = true;
            this.logout.IconRightZoom = 0D;
            this.logout.IconVisible = true;
            this.logout.IconZoom = 50D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(7, 393);
            this.logout.Name = "logout";
            this.logout.Normalcolor = System.Drawing.Color.Transparent;
            this.logout.OnHovercolor = System.Drawing.Color.Transparent;
            this.logout.OnHoverTextColor = System.Drawing.Color.White;
            this.logout.selected = false;
            this.logout.Size = new System.Drawing.Size(252, 51);
            this.logout.TabIndex = 13;
            this.logout.Text = "LOG OUT";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Textcolor = System.Drawing.Color.Black;
            this.logout.TextFont = new System.Drawing.Font("Cera Stencil", 13F);
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // createtask
            // 
            this.createtask.Activecolor = System.Drawing.Color.Transparent;
            this.createtask.BackColor = System.Drawing.Color.Transparent;
            this.createtask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createtask.BorderRadius = 0;
            this.createtask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createtask.ButtonText = "Create Task";
            this.createtask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.createtask, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.createtask, BunifuAnimatorNS.DecorationType.None);
            this.createtask.DisabledColor = System.Drawing.Color.Gray;
            this.createtask.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createtask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createtask.Iconcolor = System.Drawing.Color.Transparent;
            this.createtask.Iconimage = null;
            this.createtask.Iconimage_right = null;
            this.createtask.Iconimage_right_Selected = null;
            this.createtask.Iconimage_Selected = null;
            this.createtask.IconMarginLeft = 0;
            this.createtask.IconMarginRight = 0;
            this.createtask.IconRightVisible = true;
            this.createtask.IconRightZoom = 0D;
            this.createtask.IconVisible = true;
            this.createtask.IconZoom = 50D;
            this.createtask.IsTab = false;
            this.createtask.Location = new System.Drawing.Point(7, 255);
            this.createtask.Name = "createtask";
            this.createtask.Normalcolor = System.Drawing.Color.Transparent;
            this.createtask.OnHovercolor = System.Drawing.Color.Transparent;
            this.createtask.OnHoverTextColor = System.Drawing.Color.White;
            this.createtask.selected = false;
            this.createtask.Size = new System.Drawing.Size(252, 51);
            this.createtask.TabIndex = 10;
            this.createtask.Text = "Create Task";
            this.createtask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createtask.Textcolor = System.Drawing.Color.Black;
            this.createtask.TextFont = new System.Drawing.Font("Cera Stencil", 13F);
            this.createtask.Click += new System.EventHandler(this.Createtask_Click);
            // 
            // mark
            // 
            this.mark.Activecolor = System.Drawing.Color.Transparent;
            this.mark.BackColor = System.Drawing.Color.Transparent;
            this.mark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mark.BorderRadius = 0;
            this.mark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mark.ButtonText = "Marks";
            this.mark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.mark, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.mark, BunifuAnimatorNS.DecorationType.None);
            this.mark.DisabledColor = System.Drawing.Color.Gray;
            this.mark.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mark.Iconcolor = System.Drawing.Color.Transparent;
            this.mark.Iconimage = null;
            this.mark.Iconimage_right = null;
            this.mark.Iconimage_right_Selected = null;
            this.mark.Iconimage_Selected = null;
            this.mark.IconMarginLeft = 0;
            this.mark.IconMarginRight = 0;
            this.mark.IconRightVisible = true;
            this.mark.IconRightZoom = 0D;
            this.mark.IconVisible = true;
            this.mark.IconZoom = 50D;
            this.mark.IsTab = false;
            this.mark.Location = new System.Drawing.Point(7, 184);
            this.mark.Name = "mark";
            this.mark.Normalcolor = System.Drawing.Color.Transparent;
            this.mark.OnHovercolor = System.Drawing.Color.Transparent;
            this.mark.OnHoverTextColor = System.Drawing.Color.White;
            this.mark.selected = false;
            this.mark.Size = new System.Drawing.Size(252, 51);
            this.mark.TabIndex = 9;
            this.mark.Text = "Marks";
            this.mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mark.Textcolor = System.Drawing.Color.Black;
            this.mark.TextFont = new System.Drawing.Font("Cera Stencil", 13F);
            this.mark.Click += new System.EventHandler(this.Mark_Click);
            // 
            // attendance
            // 
            this.attendance.Activecolor = System.Drawing.Color.Transparent;
            this.attendance.BackColor = System.Drawing.Color.Transparent;
            this.attendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attendance.BorderRadius = 0;
            this.attendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendance.ButtonText = "Attendance";
            this.attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.attendance, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.attendance, BunifuAnimatorNS.DecorationType.None);
            this.attendance.DisabledColor = System.Drawing.Color.Gainsboro;
            this.attendance.Font = new System.Drawing.Font("Bauhaus 93", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.attendance.Iconcolor = System.Drawing.Color.Transparent;
            this.attendance.Iconimage = null;
            this.attendance.Iconimage_right = null;
            this.attendance.Iconimage_right_Selected = null;
            this.attendance.Iconimage_Selected = null;
            this.attendance.IconMarginLeft = 0;
            this.attendance.IconMarginRight = 0;
            this.attendance.IconRightVisible = true;
            this.attendance.IconRightZoom = 0D;
            this.attendance.IconVisible = true;
            this.attendance.IconZoom = 50D;
            this.attendance.IsTab = false;
            this.attendance.Location = new System.Drawing.Point(7, 117);
            this.attendance.Name = "attendance";
            this.attendance.Normalcolor = System.Drawing.Color.Transparent;
            this.attendance.OnHovercolor = System.Drawing.Color.Transparent;
            this.attendance.OnHoverTextColor = System.Drawing.Color.White;
            this.attendance.selected = false;
            this.attendance.Size = new System.Drawing.Size(252, 51);
            this.attendance.TabIndex = 8;
            this.attendance.Text = "Attendance";
            this.attendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attendance.Textcolor = System.Drawing.Color.Black;
            this.attendance.TextFont = new System.Drawing.Font("Cera Stencil", 13F);
            this.attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(7, 68);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(252, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Ethnocentric", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(60, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codex Academy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelAttendance.Controls.Add(this.submitMark);
            this.panelAttendance.Controls.Add(this.submit);
            this.panelAttendance.Controls.Add(this.pwdbox);
            this.panelAttendance.Controls.Add(this.infos);
            this.panelAttendance.Controls.Add(this.dgv);
            this.AnimacionSidebarBack.SetDecoration(this.panelAttendance, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panelAttendance, BunifuAnimatorNS.DecorationType.None);
            this.panelAttendance.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAttendance.Location = new System.Drawing.Point(0, 0);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(633, 555);
            this.panelAttendance.TabIndex = 2;
            // 
            // submitMark
            // 
            this.submitMark.Activecolor = System.Drawing.Color.Transparent;
            this.submitMark.BackColor = System.Drawing.Color.Transparent;
            this.submitMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitMark.BackgroundImage")));
            this.submitMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitMark.BorderRadius = 5;
            this.submitMark.ButtonText = "Submit";
            this.submitMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.submitMark, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.submitMark, BunifuAnimatorNS.DecorationType.None);
            this.submitMark.DisabledColor = System.Drawing.Color.Gray;
            this.submitMark.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitMark.ForeColor = System.Drawing.Color.Black;
            this.submitMark.Iconcolor = System.Drawing.Color.Transparent;
            this.submitMark.Iconimage = null;
            this.submitMark.Iconimage_right = null;
            this.submitMark.Iconimage_right_Selected = null;
            this.submitMark.Iconimage_Selected = null;
            this.submitMark.IconMarginLeft = 0;
            this.submitMark.IconMarginRight = 0;
            this.submitMark.IconRightVisible = true;
            this.submitMark.IconRightZoom = 0D;
            this.submitMark.IconVisible = true;
            this.submitMark.IconZoom = 50D;
            this.submitMark.IsTab = false;
            this.submitMark.Location = new System.Drawing.Point(406, 489);
            this.submitMark.Name = "submitMark";
            this.submitMark.Normalcolor = System.Drawing.Color.Transparent;
            this.submitMark.OnHovercolor = System.Drawing.Color.Transparent;
            this.submitMark.OnHoverTextColor = System.Drawing.Color.White;
            this.submitMark.selected = false;
            this.submitMark.Size = new System.Drawing.Size(159, 41);
            this.submitMark.TabIndex = 33;
            this.submitMark.Text = "Submit";
            this.submitMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitMark.Textcolor = System.Drawing.Color.White;
            this.submitMark.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitMark.Click += new System.EventHandler(this.SubmitMark_Click);
            // 
            // submit
            // 
            this.submit.Activecolor = System.Drawing.Color.Transparent;
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit.BackgroundImage")));
            this.submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit.BorderRadius = 5;
            this.submit.ButtonText = "Submit";
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.submit, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.submit, BunifuAnimatorNS.DecorationType.None);
            this.submit.DisabledColor = System.Drawing.Color.Gray;
            this.submit.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Iconcolor = System.Drawing.Color.Transparent;
            this.submit.Iconimage = null;
            this.submit.Iconimage_right = null;
            this.submit.Iconimage_right_Selected = null;
            this.submit.Iconimage_Selected = null;
            this.submit.IconMarginLeft = 0;
            this.submit.IconMarginRight = 0;
            this.submit.IconRightVisible = true;
            this.submit.IconRightZoom = 0D;
            this.submit.IconVisible = true;
            this.submit.IconZoom = 50D;
            this.submit.IsTab = false;
            this.submit.Location = new System.Drawing.Point(406, 489);
            this.submit.Name = "submit";
            this.submit.Normalcolor = System.Drawing.Color.Transparent;
            this.submit.OnHovercolor = System.Drawing.Color.Transparent;
            this.submit.OnHoverTextColor = System.Drawing.Color.White;
            this.submit.selected = false;
            this.submit.Size = new System.Drawing.Size(159, 41);
            this.submit.TabIndex = 32;
            this.submit.Text = "Submit";
            this.submit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit.Textcolor = System.Drawing.Color.White;
            this.submit.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pwdbox
            // 
            this.AnimacionSidebar.SetDecoration(this.pwdbox, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pwdbox, BunifuAnimatorNS.DecorationType.None);
            this.pwdbox.Font = new System.Drawing.Font("Cera Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwdbox.ForeColor = System.Drawing.Color.Gray;
            this.pwdbox.Location = new System.Drawing.Point(39, 501);
            this.pwdbox.Name = "pwdbox";
            this.pwdbox.PasswordChar = '•';
            this.pwdbox.Size = new System.Drawing.Size(236, 27);
            this.pwdbox.TabIndex = 31;
            this.pwdbox.Text = "Password";
            this.pwdbox.Enter += new System.EventHandler(this.Cnumber_Enter);
            this.pwdbox.Leave += new System.EventHandler(this.Cnumber_Leave);
            // 
            // infos
            // 
            this.infos.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.infos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.infos, BunifuAnimatorNS.DecorationType.None);
            this.infos.Font = new System.Drawing.Font("Ethnocentric", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.infos.Location = new System.Drawing.Point(35, 24);
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(189, 23);
            this.infos.TabIndex = 30;
            this.infos.Text = "Attendance";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimacionSidebarBack.SetDecoration(this.dgv, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.dgv, BunifuAnimatorNS.DecorationType.None);
            this.dgv.Location = new System.Drawing.Point(38, 92);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv.Size = new System.Drawing.Size(560, 376);
            this.dgv.TabIndex = 29;
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.panelAttendance);
            this.panelTask.Controls.Add(this.tasklink);
            this.panelTask.Controls.Add(this.submitTask);
            this.panelTask.Controls.Add(this.label6);
            this.panelTask.Controls.Add(this.label5);
            this.panelTask.Controls.Add(this.dtp);
            this.panelTask.Controls.Add(this.label4);
            this.AnimacionSidebarBack.SetDecoration(this.panelTask, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panelTask, BunifuAnimatorNS.DecorationType.None);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTask.Location = new System.Drawing.Point(292, 80);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(633, 555);
            this.panelTask.TabIndex = 31;
            // 
            // tasklink
            // 
            this.AnimacionSidebarBack.SetDecoration(this.tasklink, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.tasklink, BunifuAnimatorNS.DecorationType.None);
            this.tasklink.Font = new System.Drawing.Font("Cera Stencil", 13F);
            this.tasklink.Location = new System.Drawing.Point(43, 140);
            this.tasklink.Name = "tasklink";
            this.tasklink.Size = new System.Drawing.Size(306, 67);
            this.tasklink.TabIndex = 38;
            this.tasklink.Text = "";
            // 
            // submitTask
            // 
            this.submitTask.Activecolor = System.Drawing.Color.Transparent;
            this.submitTask.BackColor = System.Drawing.Color.Transparent;
            this.submitTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitTask.BackgroundImage")));
            this.submitTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitTask.BorderRadius = 5;
            this.submitTask.ButtonText = "Submit";
            this.submitTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.submitTask, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.submitTask, BunifuAnimatorNS.DecorationType.None);
            this.submitTask.DisabledColor = System.Drawing.Color.Gray;
            this.submitTask.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTask.ForeColor = System.Drawing.Color.Black;
            this.submitTask.Iconcolor = System.Drawing.Color.Transparent;
            this.submitTask.Iconimage = null;
            this.submitTask.Iconimage_right = null;
            this.submitTask.Iconimage_right_Selected = null;
            this.submitTask.Iconimage_Selected = null;
            this.submitTask.IconMarginLeft = 0;
            this.submitTask.IconMarginRight = 0;
            this.submitTask.IconRightVisible = true;
            this.submitTask.IconRightZoom = 0D;
            this.submitTask.IconVisible = true;
            this.submitTask.IconZoom = 50D;
            this.submitTask.IsTab = false;
            this.submitTask.Location = new System.Drawing.Point(43, 394);
            this.submitTask.Name = "submitTask";
            this.submitTask.Normalcolor = System.Drawing.Color.Transparent;
            this.submitTask.OnHovercolor = System.Drawing.Color.Transparent;
            this.submitTask.OnHoverTextColor = System.Drawing.Color.White;
            this.submitTask.selected = false;
            this.submitTask.Size = new System.Drawing.Size(186, 52);
            this.submitTask.TabIndex = 37;
            this.submitTask.Text = "Submit";
            this.submitTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submitTask.Textcolor = System.Drawing.Color.White;
            this.submitTask.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTask.Click += new System.EventHandler(this.SubmitTask_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Cera Stencil", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Task Link:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Cera Stencil", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Deadline:";
            // 
            // dtp
            // 
            this.dtp.CalendarMonthBackground = System.Drawing.Color.Yellow;
            this.AnimacionSidebar.SetDecoration(this.dtp, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.dtp, BunifuAnimatorNS.DecorationType.BottomMirror);
            this.dtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp.Font = new System.Drawing.Font("Cera Stencil", 14.25F);
            this.dtp.Location = new System.Drawing.Point(43, 288);
            this.dtp.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2020, 5, 28, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(332, 27);
            this.dtp.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Ethnocentric", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.label4.Location = new System.Drawing.Point(39, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Create Task";
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.AnimacionSidebarBack.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebarBack.DefaultAnimation = animation2;
            // 
            // RadioPanelChart
            // 
            this.RadioPanelChart.ElipseRadius = 7;
            this.RadioPanelChart.TargetControl = this;
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            // 
            // MoverDashboard
            // 
            this.MoverDashboard.Fixed = true;
            this.MoverDashboard.Horizontal = true;
            this.MoverDashboard.TargetControl = this.MenuTop;
            this.MoverDashboard.Vertical = true;
            // 
            // TeachersSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(925, 635);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeachersSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton createtask;
        private Bunifu.Framework.UI.BunifuFlatButton mark;
        private Bunifu.Framework.UI.BunifuFlatButton attendance;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Panel panelAttendance;
        private Bunifu.Framework.UI.BunifuFlatButton submit;
        private System.Windows.Forms.TextBox pwdbox;
        private System.Windows.Forms.Label infos;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.RichTextBox tasklink;
        private Bunifu.Framework.UI.BunifuFlatButton submitTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton submitMark;
        private Bunifu.Framework.UI.BunifuFlatButton checktask;
    }
}

