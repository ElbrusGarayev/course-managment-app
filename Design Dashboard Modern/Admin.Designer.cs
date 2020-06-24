namespace Design_Dashboard_Modern
{
    partial class AdminSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSystem));
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
            this.addCourse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.users = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.marks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.attendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.revenue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.allUsers = new System.Windows.Forms.Panel();
            this.filldgv = new Bunifu.Framework.UI.BunifuFlatButton();
            this.students = new System.Windows.Forms.RadioButton();
            this.teachers = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.usersdgv = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.searchUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.idbox = new System.Windows.Forms.TextBox();
            this.studRadio = new System.Windows.Forms.RadioButton();
            this.updatePanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.salarybox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.surnamebox = new System.Windows.Forms.TextBox();
            this.pwdbox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.teachRadio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.studentEnable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.teacherEnable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelStudent = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.student = new System.Windows.Forms.Label();
            this.addStudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emails = new System.Windows.Forms.TextBox();
            this.names = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.surnames = new System.Windows.Forms.TextBox();
            this.passwords = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelTeacher = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.teacher = new System.Windows.Forms.Label();
            this.addTeacher = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emailt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.namet = new System.Windows.Forms.TextBox();
            this.salaryt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.surnamet = new System.Windows.Forms.TextBox();
            this.passwordt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.infoAdd = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.npgsqlCommand2 = new Npgsql.NpgsqlCommand();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.main.SuspendLayout();
            this.allUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersdgv)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Information System";
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
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.Sidebar.Controls.Add(this.addCourse);
            this.Sidebar.Controls.Add(this.users);
            this.Sidebar.Controls.Add(this.logout);
            this.Sidebar.Controls.Add(this.search);
            this.Sidebar.Controls.Add(this.addUser);
            this.Sidebar.Controls.Add(this.marks);
            this.Sidebar.Controls.Add(this.attendance);
            this.Sidebar.Controls.Add(this.revenue);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Sidebar.Location = new System.Drawing.Point(16, 14);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 529);
            this.Sidebar.TabIndex = 0;
            // 
            // addCourse
            // 
            this.addCourse.Activecolor = System.Drawing.Color.Transparent;
            this.addCourse.BackColor = System.Drawing.Color.Transparent;
            this.addCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCourse.BorderRadius = 0;
            this.addCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCourse.ButtonText = "Add Course";
            this.addCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.addCourse, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.addCourse, BunifuAnimatorNS.DecorationType.None);
            this.addCourse.DisabledColor = System.Drawing.Color.Gray;
            this.addCourse.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.addCourse.Iconcolor = System.Drawing.Color.Transparent;
            this.addCourse.Iconimage = null;
            this.addCourse.Iconimage_right = null;
            this.addCourse.Iconimage_right_Selected = null;
            this.addCourse.Iconimage_Selected = null;
            this.addCourse.IconMarginLeft = 0;
            this.addCourse.IconMarginRight = 0;
            this.addCourse.IconRightVisible = true;
            this.addCourse.IconRightZoom = 0D;
            this.addCourse.IconVisible = true;
            this.addCourse.IconZoom = 50D;
            this.addCourse.IsTab = false;
            this.addCourse.Location = new System.Drawing.Point(9, 419);
            this.addCourse.Name = "addCourse";
            this.addCourse.Normalcolor = System.Drawing.Color.Transparent;
            this.addCourse.OnHovercolor = System.Drawing.Color.Transparent;
            this.addCourse.OnHoverTextColor = System.Drawing.Color.White;
            this.addCourse.selected = false;
            this.addCourse.Size = new System.Drawing.Size(252, 51);
            this.addCourse.TabIndex = 16;
            this.addCourse.Text = "Add Course";
            this.addCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCourse.Textcolor = System.Drawing.Color.Black;
            this.addCourse.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.addCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // users
            // 
            this.users.Activecolor = System.Drawing.Color.Transparent;
            this.users.BackColor = System.Drawing.Color.Transparent;
            this.users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.users.BorderRadius = 0;
            this.users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.users.ButtonText = "All Users";
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.users, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.users, BunifuAnimatorNS.DecorationType.None);
            this.users.DisabledColor = System.Drawing.Color.Gray;
            this.users.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.users.Iconcolor = System.Drawing.Color.Transparent;
            this.users.Iconimage = null;
            this.users.Iconimage_right = null;
            this.users.Iconimage_right_Selected = null;
            this.users.Iconimage_Selected = null;
            this.users.IconMarginLeft = 0;
            this.users.IconMarginRight = 0;
            this.users.IconRightVisible = true;
            this.users.IconRightZoom = 0D;
            this.users.IconVisible = true;
            this.users.IconZoom = 50D;
            this.users.IsTab = false;
            this.users.Location = new System.Drawing.Point(9, 248);
            this.users.Name = "users";
            this.users.Normalcolor = System.Drawing.Color.Transparent;
            this.users.OnHovercolor = System.Drawing.Color.Transparent;
            this.users.OnHoverTextColor = System.Drawing.Color.White;
            this.users.selected = false;
            this.users.Size = new System.Drawing.Size(252, 51);
            this.users.TabIndex = 15;
            this.users.Text = "All Users";
            this.users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.users.Textcolor = System.Drawing.Color.Black;
            this.users.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.users.Click += new System.EventHandler(this.Users_Click);
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
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
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
            this.logout.Location = new System.Drawing.Point(9, 475);
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
            this.logout.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // search
            // 
            this.search.Activecolor = System.Drawing.Color.Transparent;
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.BorderRadius = 0;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.ButtonText = "Search and Update";
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.search, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.search, BunifuAnimatorNS.DecorationType.None);
            this.search.DisabledColor = System.Drawing.Color.Gray;
            this.search.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.search.Iconcolor = System.Drawing.Color.Transparent;
            this.search.Iconimage = null;
            this.search.Iconimage_right = null;
            this.search.Iconimage_right_Selected = null;
            this.search.Iconimage_Selected = null;
            this.search.IconMarginLeft = 0;
            this.search.IconMarginRight = 0;
            this.search.IconRightVisible = true;
            this.search.IconRightZoom = 0D;
            this.search.IconVisible = true;
            this.search.IconZoom = 50D;
            this.search.IsTab = false;
            this.search.Location = new System.Drawing.Point(9, 362);
            this.search.Name = "search";
            this.search.Normalcolor = System.Drawing.Color.Transparent;
            this.search.OnHovercolor = System.Drawing.Color.Transparent;
            this.search.OnHoverTextColor = System.Drawing.Color.White;
            this.search.selected = false;
            this.search.Size = new System.Drawing.Size(252, 51);
            this.search.TabIndex = 12;
            this.search.Text = "Search and Update";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search.Textcolor = System.Drawing.Color.Black;
            this.search.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // addUser
            // 
            this.addUser.Activecolor = System.Drawing.Color.Transparent;
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUser.BorderRadius = 0;
            this.addUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addUser.ButtonText = "Add User";
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.addUser, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.addUser, BunifuAnimatorNS.DecorationType.None);
            this.addUser.DisabledColor = System.Drawing.Color.Gray;
            this.addUser.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.addUser.Iconcolor = System.Drawing.Color.Transparent;
            this.addUser.Iconimage = null;
            this.addUser.Iconimage_right = null;
            this.addUser.Iconimage_right_Selected = null;
            this.addUser.Iconimage_Selected = null;
            this.addUser.IconMarginLeft = 0;
            this.addUser.IconMarginRight = 0;
            this.addUser.IconRightVisible = true;
            this.addUser.IconRightZoom = 0D;
            this.addUser.IconVisible = true;
            this.addUser.IconZoom = 50D;
            this.addUser.IsTab = false;
            this.addUser.Location = new System.Drawing.Point(9, 305);
            this.addUser.Name = "addUser";
            this.addUser.Normalcolor = System.Drawing.Color.Transparent;
            this.addUser.OnHovercolor = System.Drawing.Color.Transparent;
            this.addUser.OnHoverTextColor = System.Drawing.Color.White;
            this.addUser.selected = false;
            this.addUser.Size = new System.Drawing.Size(252, 51);
            this.addUser.TabIndex = 11;
            this.addUser.Text = "Add User";
            this.addUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addUser.Textcolor = System.Drawing.Color.Black;
            this.addUser.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.addUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // marks
            // 
            this.marks.Activecolor = System.Drawing.Color.Transparent;
            this.marks.BackColor = System.Drawing.Color.Transparent;
            this.marks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.marks.BorderRadius = 0;
            this.marks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marks.ButtonText = "Marks";
            this.marks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.marks, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.marks, BunifuAnimatorNS.DecorationType.None);
            this.marks.DisabledColor = System.Drawing.Color.Gray;
            this.marks.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.marks.Iconcolor = System.Drawing.Color.Transparent;
            this.marks.Iconimage = null;
            this.marks.Iconimage_right = null;
            this.marks.Iconimage_right_Selected = null;
            this.marks.Iconimage_Selected = null;
            this.marks.IconMarginLeft = 0;
            this.marks.IconMarginRight = 0;
            this.marks.IconRightVisible = true;
            this.marks.IconRightZoom = 0D;
            this.marks.IconVisible = true;
            this.marks.IconZoom = 50D;
            this.marks.IsTab = false;
            this.marks.Location = new System.Drawing.Point(9, 191);
            this.marks.Name = "marks";
            this.marks.Normalcolor = System.Drawing.Color.Transparent;
            this.marks.OnHovercolor = System.Drawing.Color.Transparent;
            this.marks.OnHoverTextColor = System.Drawing.Color.White;
            this.marks.selected = false;
            this.marks.Size = new System.Drawing.Size(252, 51);
            this.marks.TabIndex = 10;
            this.marks.Text = "Marks";
            this.marks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.marks.Textcolor = System.Drawing.Color.Black;
            this.marks.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.marks.Click += new System.EventHandler(this.Marks_Click);
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
            this.attendance.DisabledColor = System.Drawing.Color.Gray;
            this.attendance.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
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
            this.attendance.Location = new System.Drawing.Point(9, 134);
            this.attendance.Name = "attendance";
            this.attendance.Normalcolor = System.Drawing.Color.Transparent;
            this.attendance.OnHovercolor = System.Drawing.Color.Transparent;
            this.attendance.OnHoverTextColor = System.Drawing.Color.White;
            this.attendance.selected = false;
            this.attendance.Size = new System.Drawing.Size(252, 51);
            this.attendance.TabIndex = 9;
            this.attendance.Text = "Attendance";
            this.attendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attendance.Textcolor = System.Drawing.Color.Black;
            this.attendance.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // revenue
            // 
            this.revenue.Activecolor = System.Drawing.Color.Transparent;
            this.revenue.BackColor = System.Drawing.Color.Transparent;
            this.revenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.revenue.BorderRadius = 0;
            this.revenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.revenue.ButtonText = "Revenue";
            this.revenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.revenue, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.revenue, BunifuAnimatorNS.DecorationType.None);
            this.revenue.DisabledColor = System.Drawing.Color.Gray;
            this.revenue.Font = new System.Drawing.Font("Bauhaus 93", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.revenue.Iconcolor = System.Drawing.Color.Transparent;
            this.revenue.Iconimage = null;
            this.revenue.Iconimage_right = null;
            this.revenue.Iconimage_right_Selected = null;
            this.revenue.Iconimage_Selected = null;
            this.revenue.IconMarginLeft = 0;
            this.revenue.IconMarginRight = 0;
            this.revenue.IconRightVisible = true;
            this.revenue.IconRightZoom = 0D;
            this.revenue.IconVisible = true;
            this.revenue.IconZoom = 50D;
            this.revenue.IsTab = false;
            this.revenue.Location = new System.Drawing.Point(9, 77);
            this.revenue.Name = "revenue";
            this.revenue.Normalcolor = System.Drawing.Color.Transparent;
            this.revenue.OnHovercolor = System.Drawing.Color.Transparent;
            this.revenue.OnHoverTextColor = System.Drawing.Color.White;
            this.revenue.selected = false;
            this.revenue.Size = new System.Drawing.Size(252, 51);
            this.revenue.TabIndex = 8;
            this.revenue.Text = "Revenue";
            this.revenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.revenue.Textcolor = System.Drawing.Color.Black;
            this.revenue.TextFont = new System.Drawing.Font("Cera Stencil", 12F);
            this.revenue.Click += new System.EventHandler(this.Revenue_Click);
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(60, 21);
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
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.main);
            this.Wrapper.Controls.Add(this.allUsers);
            this.Wrapper.Controls.Add(this.panelSearch);
            this.Wrapper.Controls.Add(this.panel);
            this.Wrapper.Controls.Add(this.info);
            this.Wrapper.Controls.Add(this.dgv);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(625, 555);
            this.Wrapper.TabIndex = 2;
            // 
            // main
            // 
            this.main.Controls.Add(this.label9);
            this.AnimacionSidebarBack.SetDecoration(this.main, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.main, BunifuAnimatorNS.DecorationType.None);
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(625, 552);
            this.main.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Ethnocentric", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.label9.Location = new System.Drawing.Point(-2, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(624, 36);
            this.label9.TabIndex = 16;
            this.label9.Text = "Welcome to Admin System";
            // 
            // allUsers
            // 
            this.allUsers.Controls.Add(this.filldgv);
            this.allUsers.Controls.Add(this.students);
            this.allUsers.Controls.Add(this.teachers);
            this.allUsers.Controls.Add(this.label14);
            this.allUsers.Controls.Add(this.usersdgv);
            this.AnimacionSidebarBack.SetDecoration(this.allUsers, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.allUsers, BunifuAnimatorNS.DecorationType.None);
            this.allUsers.Location = new System.Drawing.Point(0, 3);
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(625, 552);
            this.allUsers.TabIndex = 17;
            // 
            // filldgv
            // 
            this.filldgv.Activecolor = System.Drawing.Color.Transparent;
            this.filldgv.BackColor = System.Drawing.Color.Transparent;
            this.filldgv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("filldgv.BackgroundImage")));
            this.filldgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filldgv.BorderRadius = 5;
            this.filldgv.ButtonText = "FILL";
            this.filldgv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.filldgv, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.filldgv, BunifuAnimatorNS.DecorationType.None);
            this.filldgv.DisabledColor = System.Drawing.Color.Gray;
            this.filldgv.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filldgv.ForeColor = System.Drawing.Color.Black;
            this.filldgv.Iconcolor = System.Drawing.Color.Transparent;
            this.filldgv.Iconimage = null;
            this.filldgv.Iconimage_right = null;
            this.filldgv.Iconimage_right_Selected = null;
            this.filldgv.Iconimage_Selected = null;
            this.filldgv.IconMarginLeft = 0;
            this.filldgv.IconMarginRight = 0;
            this.filldgv.IconRightVisible = true;
            this.filldgv.IconRightZoom = 0D;
            this.filldgv.IconVisible = true;
            this.filldgv.IconZoom = 50D;
            this.filldgv.IsTab = false;
            this.filldgv.Location = new System.Drawing.Point(223, 89);
            this.filldgv.Name = "filldgv";
            this.filldgv.Normalcolor = System.Drawing.Color.Transparent;
            this.filldgv.OnHovercolor = System.Drawing.Color.Transparent;
            this.filldgv.OnHoverTextColor = System.Drawing.Color.White;
            this.filldgv.selected = false;
            this.filldgv.Size = new System.Drawing.Size(155, 45);
            this.filldgv.TabIndex = 28;
            this.filldgv.Text = "FILL";
            this.filldgv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filldgv.Textcolor = System.Drawing.Color.White;
            this.filldgv.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filldgv.Click += new System.EventHandler(this.Filldgv_Click);
            // 
            // students
            // 
            this.students.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.students, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.students, BunifuAnimatorNS.DecorationType.None);
            this.students.Font = new System.Drawing.Font("Cera Stencil", 14.25F);
            this.students.ForeColor = System.Drawing.Color.White;
            this.students.Location = new System.Drawing.Point(329, 49);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(108, 24);
            this.students.TabIndex = 18;
            this.students.TabStop = true;
            this.students.Text = "Students";
            this.students.UseVisualStyleBackColor = true;
            // 
            // teachers
            // 
            this.teachers.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.teachers, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.teachers, BunifuAnimatorNS.DecorationType.None);
            this.teachers.Font = new System.Drawing.Font("Cera Stencil", 14.25F);
            this.teachers.ForeColor = System.Drawing.Color.White;
            this.teachers.Location = new System.Drawing.Point(163, 50);
            this.teachers.Name = "teachers";
            this.teachers.Size = new System.Drawing.Size(106, 24);
            this.teachers.TabIndex = 17;
            this.teachers.TabStop = true;
            this.teachers.Text = "Teachers";
            this.teachers.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Ethnocentric", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.label14.Location = new System.Drawing.Point(201, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 26);
            this.label14.TabIndex = 16;
            this.label14.Text = "All Users";
            // 
            // usersdgv
            // 
            this.usersdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimacionSidebarBack.SetDecoration(this.usersdgv, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.usersdgv, BunifuAnimatorNS.DecorationType.None);
            this.usersdgv.Location = new System.Drawing.Point(29, 155);
            this.usersdgv.Name = "usersdgv";
            this.usersdgv.Size = new System.Drawing.Size(563, 371);
            this.usersdgv.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.searchUser);
            this.panelSearch.Controls.Add(this.idbox);
            this.panelSearch.Controls.Add(this.studRadio);
            this.panelSearch.Controls.Add(this.updatePanel);
            this.panelSearch.Controls.Add(this.teachRadio);
            this.panelSearch.Controls.Add(this.label8);
            this.AnimacionSidebarBack.SetDecoration(this.panelSearch, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panelSearch, BunifuAnimatorNS.DecorationType.None);
            this.panelSearch.Location = new System.Drawing.Point(0, 3);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(625, 552);
            this.panelSearch.TabIndex = 31;
            // 
            // searchUser
            // 
            this.searchUser.Activecolor = System.Drawing.Color.Transparent;
            this.searchUser.BackColor = System.Drawing.Color.Transparent;
            this.searchUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchUser.BackgroundImage")));
            this.searchUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchUser.BorderRadius = 5;
            this.searchUser.ButtonText = "Search";
            this.searchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.searchUser, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.searchUser, BunifuAnimatorNS.DecorationType.None);
            this.searchUser.DisabledColor = System.Drawing.Color.Gray;
            this.searchUser.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUser.ForeColor = System.Drawing.Color.Black;
            this.searchUser.Iconcolor = System.Drawing.Color.Transparent;
            this.searchUser.Iconimage = null;
            this.searchUser.Iconimage_right = null;
            this.searchUser.Iconimage_right_Selected = null;
            this.searchUser.Iconimage_Selected = null;
            this.searchUser.IconMarginLeft = 0;
            this.searchUser.IconMarginRight = 0;
            this.searchUser.IconRightVisible = true;
            this.searchUser.IconRightZoom = 0D;
            this.searchUser.IconVisible = true;
            this.searchUser.IconZoom = 50D;
            this.searchUser.IsTab = false;
            this.searchUser.Location = new System.Drawing.Point(11, 288);
            this.searchUser.Name = "searchUser";
            this.searchUser.Normalcolor = System.Drawing.Color.Transparent;
            this.searchUser.OnHovercolor = System.Drawing.Color.Transparent;
            this.searchUser.OnHoverTextColor = System.Drawing.Color.White;
            this.searchUser.selected = false;
            this.searchUser.Size = new System.Drawing.Size(158, 48);
            this.searchUser.TabIndex = 41;
            this.searchUser.Text = "Search";
            this.searchUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchUser.Textcolor = System.Drawing.Color.White;
            this.searchUser.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // idbox
            // 
            this.AnimacionSidebar.SetDecoration(this.idbox, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.idbox, BunifuAnimatorNS.DecorationType.None);
            this.idbox.Font = new System.Drawing.Font("Cera Stencil", 13F);
            this.idbox.ForeColor = System.Drawing.Color.Gray;
            this.idbox.Location = new System.Drawing.Point(11, 219);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(147, 26);
            this.idbox.TabIndex = 34;
            this.idbox.Text = "ID";
            this.idbox.Enter += new System.EventHandler(this.Idbox_Enter);
            this.idbox.Leave += new System.EventHandler(this.Idbox_Leave);
            // 
            // studRadio
            // 
            this.studRadio.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.studRadio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.studRadio, BunifuAnimatorNS.DecorationType.None);
            this.studRadio.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.studRadio.ForeColor = System.Drawing.Color.White;
            this.studRadio.Location = new System.Drawing.Point(297, 50);
            this.studRadio.Name = "studRadio";
            this.studRadio.Size = new System.Drawing.Size(92, 23);
            this.studRadio.TabIndex = 33;
            this.studRadio.TabStop = true;
            this.studRadio.Text = "Student";
            this.studRadio.UseVisualStyleBackColor = true;
            // 
            // updatePanel
            // 
            this.updatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.updatePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatePanel.BackgroundImage")));
            this.updatePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatePanel.Controls.Add(this.label21);
            this.updatePanel.Controls.Add(this.update);
            this.updatePanel.Controls.Add(this.emailbox);
            this.updatePanel.Controls.Add(this.label22);
            this.updatePanel.Controls.Add(this.namebox);
            this.updatePanel.Controls.Add(this.salarybox);
            this.updatePanel.Controls.Add(this.label23);
            this.updatePanel.Controls.Add(this.label24);
            this.updatePanel.Controls.Add(this.surnamebox);
            this.updatePanel.Controls.Add(this.pwdbox);
            this.updatePanel.Controls.Add(this.label25);
            this.updatePanel.Controls.Add(this.label26);
            this.AnimacionSidebarBack.SetDecoration(this.updatePanel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.updatePanel, BunifuAnimatorNS.DecorationType.None);
            this.updatePanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.updatePanel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.updatePanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.updatePanel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.updatePanel.Location = new System.Drawing.Point(206, 101);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Quality = 10;
            this.updatePanel.Size = new System.Drawing.Size(397, 406);
            this.updatePanel.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.label21.Font = new System.Drawing.Font("Ethnocentric", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label21.Location = new System.Drawing.Point(87, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(223, 23);
            this.label21.TabIndex = 15;
            this.label21.Text = " Informations";
            // 
            // update
            // 
            this.update.Activecolor = System.Drawing.Color.Transparent;
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update.BorderRadius = 5;
            this.update.ButtonText = "Update";
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.update, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.update, BunifuAnimatorNS.DecorationType.None);
            this.update.DisabledColor = System.Drawing.Color.Gray;
            this.update.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Iconcolor = System.Drawing.Color.Transparent;
            this.update.Iconimage = null;
            this.update.Iconimage_right = null;
            this.update.Iconimage_right_Selected = null;
            this.update.Iconimage_Selected = null;
            this.update.IconMarginLeft = 0;
            this.update.IconMarginRight = 0;
            this.update.IconRightVisible = true;
            this.update.IconRightZoom = 0D;
            this.update.IconVisible = true;
            this.update.IconZoom = 50D;
            this.update.IsTab = false;
            this.update.Location = new System.Drawing.Point(115, 345);
            this.update.Name = "update";
            this.update.Normalcolor = System.Drawing.Color.Transparent;
            this.update.OnHovercolor = System.Drawing.Color.Transparent;
            this.update.OnHoverTextColor = System.Drawing.Color.White;
            this.update.selected = false;
            this.update.Size = new System.Drawing.Size(158, 48);
            this.update.TabIndex = 28;
            this.update.Text = "Update";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.Textcolor = System.Drawing.Color.White;
            this.update.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // emailbox
            // 
            this.AnimacionSidebar.SetDecoration(this.emailbox, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.emailbox, BunifuAnimatorNS.DecorationType.None);
            this.emailbox.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.emailbox.Location = new System.Drawing.Point(106, 187);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(266, 26);
            this.emailbox.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label22, BunifuAnimatorNS.DecorationType.None);
            this.label22.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label22.Location = new System.Drawing.Point(3, 305);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 19);
            this.label22.TabIndex = 13;
            this.label22.Text = "Salary:";
            // 
            // namebox
            // 
            this.AnimacionSidebar.SetDecoration(this.namebox, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.namebox, BunifuAnimatorNS.DecorationType.None);
            this.namebox.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.namebox.Location = new System.Drawing.Point(106, 66);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(266, 26);
            this.namebox.TabIndex = 4;
            // 
            // salarybox
            // 
            this.AnimacionSidebar.SetDecoration(this.salarybox, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.salarybox, BunifuAnimatorNS.DecorationType.None);
            this.salarybox.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.salarybox.Location = new System.Drawing.Point(106, 302);
            this.salarybox.Name = "salarybox";
            this.salarybox.Size = new System.Drawing.Size(266, 26);
            this.salarybox.TabIndex = 12;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label23, BunifuAnimatorNS.DecorationType.None);
            this.label23.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label23.Location = new System.Drawing.Point(3, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 19);
            this.label23.TabIndex = 5;
            this.label23.Text = "Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label24, BunifuAnimatorNS.DecorationType.None);
            this.label24.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label24.Location = new System.Drawing.Point(3, 245);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 19);
            this.label24.TabIndex = 11;
            this.label24.Text = "Password:";
            // 
            // surnamebox
            // 
            this.AnimacionSidebar.SetDecoration(this.surnamebox, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.surnamebox, BunifuAnimatorNS.DecorationType.None);
            this.surnamebox.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.surnamebox.Location = new System.Drawing.Point(106, 127);
            this.surnamebox.Name = "surnamebox";
            this.surnamebox.Size = new System.Drawing.Size(266, 26);
            this.surnamebox.TabIndex = 6;
            // 
            // pwdbox
            // 
            this.AnimacionSidebar.SetDecoration(this.pwdbox, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pwdbox, BunifuAnimatorNS.DecorationType.None);
            this.pwdbox.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.pwdbox.Location = new System.Drawing.Point(106, 242);
            this.pwdbox.Name = "pwdbox";
            this.pwdbox.Size = new System.Drawing.Size(266, 26);
            this.pwdbox.TabIndex = 10;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label25, BunifuAnimatorNS.DecorationType.None);
            this.label25.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label25.Location = new System.Drawing.Point(3, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 19);
            this.label25.TabIndex = 7;
            this.label25.Text = "Surname:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label26, BunifuAnimatorNS.DecorationType.None);
            this.label26.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label26.Location = new System.Drawing.Point(3, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 19);
            this.label26.TabIndex = 9;
            this.label26.Text = "E-mail:";
            // 
            // teachRadio
            // 
            this.teachRadio.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.teachRadio, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.teachRadio, BunifuAnimatorNS.DecorationType.None);
            this.teachRadio.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.teachRadio.ForeColor = System.Drawing.Color.White;
            this.teachRadio.Location = new System.Drawing.Point(191, 50);
            this.teachRadio.Name = "teachRadio";
            this.teachRadio.Size = new System.Drawing.Size(93, 23);
            this.teachRadio.TabIndex = 32;
            this.teachRadio.TabStop = true;
            this.teachRadio.Text = "Teacher";
            this.teachRadio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Ethnocentric", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.label8.Location = new System.Drawing.Point(164, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Search and Look";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.studentEnable);
            this.panel.Controls.Add(this.teacherEnable);
            this.panel.Controls.Add(this.panelStudent);
            this.panel.Controls.Add(this.panelTeacher);
            this.panel.Controls.Add(this.infoAdd);
            this.AnimacionSidebarBack.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.panel.Location = new System.Drawing.Point(-17, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(642, 549);
            this.panel.TabIndex = 2;
            // 
            // studentEnable
            // 
            this.studentEnable.Activecolor = System.Drawing.Color.Transparent;
            this.studentEnable.BackColor = System.Drawing.Color.Transparent;
            this.studentEnable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("studentEnable.BackgroundImage")));
            this.studentEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.studentEnable.BorderRadius = 5;
            this.studentEnable.ButtonText = "Enable";
            this.studentEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.studentEnable, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.studentEnable, BunifuAnimatorNS.DecorationType.None);
            this.studentEnable.DisabledColor = System.Drawing.Color.Gray;
            this.studentEnable.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEnable.ForeColor = System.Drawing.Color.Black;
            this.studentEnable.Iconcolor = System.Drawing.Color.Transparent;
            this.studentEnable.Iconimage = null;
            this.studentEnable.Iconimage_right = null;
            this.studentEnable.Iconimage_right_Selected = null;
            this.studentEnable.Iconimage_Selected = null;
            this.studentEnable.IconMarginLeft = 0;
            this.studentEnable.IconMarginRight = 0;
            this.studentEnable.IconRightVisible = true;
            this.studentEnable.IconRightZoom = 0D;
            this.studentEnable.IconVisible = true;
            this.studentEnable.IconZoom = 50D;
            this.studentEnable.IsTab = false;
            this.studentEnable.Location = new System.Drawing.Point(404, 42);
            this.studentEnable.Name = "studentEnable";
            this.studentEnable.Normalcolor = System.Drawing.Color.Transparent;
            this.studentEnable.OnHovercolor = System.Drawing.Color.Transparent;
            this.studentEnable.OnHoverTextColor = System.Drawing.Color.White;
            this.studentEnable.selected = false;
            this.studentEnable.Size = new System.Drawing.Size(158, 48);
            this.studentEnable.TabIndex = 30;
            this.studentEnable.Text = "Enable";
            this.studentEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.studentEnable.Textcolor = System.Drawing.Color.White;
            this.studentEnable.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEnable.Click += new System.EventHandler(this.StudentEnable_Click);
            // 
            // teacherEnable
            // 
            this.teacherEnable.Activecolor = System.Drawing.Color.Transparent;
            this.teacherEnable.BackColor = System.Drawing.Color.Transparent;
            this.teacherEnable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teacherEnable.BackgroundImage")));
            this.teacherEnable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.teacherEnable.BorderRadius = 5;
            this.teacherEnable.ButtonText = "Enable";
            this.teacherEnable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.teacherEnable, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.teacherEnable, BunifuAnimatorNS.DecorationType.None);
            this.teacherEnable.DisabledColor = System.Drawing.Color.Gray;
            this.teacherEnable.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherEnable.ForeColor = System.Drawing.Color.Black;
            this.teacherEnable.Iconcolor = System.Drawing.Color.Transparent;
            this.teacherEnable.Iconimage = null;
            this.teacherEnable.Iconimage_right = null;
            this.teacherEnable.Iconimage_right_Selected = null;
            this.teacherEnable.Iconimage_Selected = null;
            this.teacherEnable.IconMarginLeft = 0;
            this.teacherEnable.IconMarginRight = 0;
            this.teacherEnable.IconRightVisible = true;
            this.teacherEnable.IconRightZoom = 0D;
            this.teacherEnable.IconVisible = true;
            this.teacherEnable.IconZoom = 50D;
            this.teacherEnable.IsTab = false;
            this.teacherEnable.Location = new System.Drawing.Point(85, 42);
            this.teacherEnable.Name = "teacherEnable";
            this.teacherEnable.Normalcolor = System.Drawing.Color.Transparent;
            this.teacherEnable.OnHovercolor = System.Drawing.Color.Transparent;
            this.teacherEnable.OnHoverTextColor = System.Drawing.Color.White;
            this.teacherEnable.selected = false;
            this.teacherEnable.Size = new System.Drawing.Size(158, 48);
            this.teacherEnable.TabIndex = 29;
            this.teacherEnable.Text = "Enable";
            this.teacherEnable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teacherEnable.Textcolor = System.Drawing.Color.White;
            this.teacherEnable.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherEnable.Click += new System.EventHandler(this.TeacherEnable_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStudent.BackgroundImage")));
            this.panelStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStudent.Controls.Add(this.student);
            this.panelStudent.Controls.Add(this.addStudent);
            this.panelStudent.Controls.Add(this.emails);
            this.panelStudent.Controls.Add(this.names);
            this.panelStudent.Controls.Add(this.label10);
            this.panelStudent.Controls.Add(this.label11);
            this.panelStudent.Controls.Add(this.surnames);
            this.panelStudent.Controls.Add(this.passwords);
            this.panelStudent.Controls.Add(this.label12);
            this.panelStudent.Controls.Add(this.label13);
            this.AnimacionSidebarBack.SetDecoration(this.panelStudent, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panelStudent, BunifuAnimatorNS.DecorationType.None);
            this.panelStudent.Enabled = false;
            this.panelStudent.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.panelStudent.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.panelStudent.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.panelStudent.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelStudent.Location = new System.Drawing.Point(326, 98);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Quality = 10;
            this.panelStudent.Size = new System.Drawing.Size(313, 406);
            this.panelStudent.TabIndex = 29;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.student, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.student, BunifuAnimatorNS.DecorationType.None);
            this.student.Font = new System.Drawing.Font("Ethnocentric", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.student.Location = new System.Drawing.Point(17, 20);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(281, 19);
            this.student.TabIndex = 15;
            this.student.Text = "Student Information";
            // 
            // addStudent
            // 
            this.addStudent.Activecolor = System.Drawing.Color.Transparent;
            this.addStudent.BackColor = System.Drawing.Color.Transparent;
            this.addStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addStudent.BackgroundImage")));
            this.addStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addStudent.BorderRadius = 5;
            this.addStudent.ButtonText = "Submit";
            this.addStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.addStudent, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.addStudent, BunifuAnimatorNS.DecorationType.None);
            this.addStudent.DisabledColor = System.Drawing.Color.Gray;
            this.addStudent.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.ForeColor = System.Drawing.Color.Black;
            this.addStudent.Iconcolor = System.Drawing.Color.Transparent;
            this.addStudent.Iconimage = null;
            this.addStudent.Iconimage_right = null;
            this.addStudent.Iconimage_right_Selected = null;
            this.addStudent.Iconimage_Selected = null;
            this.addStudent.IconMarginLeft = 0;
            this.addStudent.IconMarginRight = 0;
            this.addStudent.IconRightVisible = true;
            this.addStudent.IconRightZoom = 0D;
            this.addStudent.IconVisible = true;
            this.addStudent.IconZoom = 50D;
            this.addStudent.IsTab = false;
            this.addStudent.Location = new System.Drawing.Point(78, 345);
            this.addStudent.Name = "addStudent";
            this.addStudent.Normalcolor = System.Drawing.Color.Transparent;
            this.addStudent.OnHovercolor = System.Drawing.Color.Transparent;
            this.addStudent.OnHoverTextColor = System.Drawing.Color.White;
            this.addStudent.selected = false;
            this.addStudent.Size = new System.Drawing.Size(158, 48);
            this.addStudent.TabIndex = 28;
            this.addStudent.Text = "Submit";
            this.addStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addStudent.Textcolor = System.Drawing.Color.White;
            this.addStudent.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // emails
            // 
            this.AnimacionSidebar.SetDecoration(this.emails, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.emails, BunifuAnimatorNS.DecorationType.None);
            this.emails.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.emails.Location = new System.Drawing.Point(110, 185);
            this.emails.Name = "emails";
            this.emails.Size = new System.Drawing.Size(184, 26);
            this.emails.TabIndex = 8;
            // 
            // names
            // 
            this.AnimacionSidebar.SetDecoration(this.names, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.names, BunifuAnimatorNS.DecorationType.None);
            this.names.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.names.Location = new System.Drawing.Point(110, 64);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(184, 26);
            this.names.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label10.Location = new System.Drawing.Point(17, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label11.Location = new System.Drawing.Point(17, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Password:";
            // 
            // surnames
            // 
            this.AnimacionSidebar.SetDecoration(this.surnames, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.surnames, BunifuAnimatorNS.DecorationType.None);
            this.surnames.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.surnames.Location = new System.Drawing.Point(110, 125);
            this.surnames.Name = "surnames";
            this.surnames.Size = new System.Drawing.Size(184, 26);
            this.surnames.TabIndex = 6;
            // 
            // passwords
            // 
            this.AnimacionSidebar.SetDecoration(this.passwords, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.passwords, BunifuAnimatorNS.DecorationType.None);
            this.passwords.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.passwords.Location = new System.Drawing.Point(110, 240);
            this.passwords.Name = "passwords";
            this.passwords.Size = new System.Drawing.Size(184, 26);
            this.passwords.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label12.Location = new System.Drawing.Point(17, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "Surname:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label13.Location = new System.Drawing.Point(17, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "E-mail:";
            // 
            // panelTeacher
            // 
            this.panelTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTeacher.BackgroundImage")));
            this.panelTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTeacher.Controls.Add(this.teacher);
            this.panelTeacher.Controls.Add(this.addTeacher);
            this.panelTeacher.Controls.Add(this.emailt);
            this.panelTeacher.Controls.Add(this.label7);
            this.panelTeacher.Controls.Add(this.namet);
            this.panelTeacher.Controls.Add(this.salaryt);
            this.panelTeacher.Controls.Add(this.label3);
            this.panelTeacher.Controls.Add(this.label6);
            this.panelTeacher.Controls.Add(this.surnamet);
            this.panelTeacher.Controls.Add(this.passwordt);
            this.panelTeacher.Controls.Add(this.label4);
            this.panelTeacher.Controls.Add(this.label5);
            this.AnimacionSidebarBack.SetDecoration(this.panelTeacher, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.panelTeacher, BunifuAnimatorNS.DecorationType.None);
            this.panelTeacher.Enabled = false;
            this.panelTeacher.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.panelTeacher.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.panelTeacher.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.panelTeacher.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.panelTeacher.Location = new System.Drawing.Point(7, 98);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Quality = 10;
            this.panelTeacher.Size = new System.Drawing.Size(313, 406);
            this.panelTeacher.TabIndex = 14;
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.teacher, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.teacher, BunifuAnimatorNS.DecorationType.None);
            this.teacher.Font = new System.Drawing.Font("Ethnocentric", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.teacher.Location = new System.Drawing.Point(17, 20);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(281, 19);
            this.teacher.TabIndex = 15;
            this.teacher.Text = "Teacher Information";
            // 
            // addTeacher
            // 
            this.addTeacher.Activecolor = System.Drawing.Color.Transparent;
            this.addTeacher.BackColor = System.Drawing.Color.Transparent;
            this.addTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTeacher.BackgroundImage")));
            this.addTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTeacher.BorderRadius = 5;
            this.addTeacher.ButtonText = "Submit";
            this.addTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.addTeacher, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.addTeacher, BunifuAnimatorNS.DecorationType.None);
            this.addTeacher.DisabledColor = System.Drawing.Color.Gray;
            this.addTeacher.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacher.ForeColor = System.Drawing.Color.Black;
            this.addTeacher.Iconcolor = System.Drawing.Color.Transparent;
            this.addTeacher.Iconimage = null;
            this.addTeacher.Iconimage_right = null;
            this.addTeacher.Iconimage_right_Selected = null;
            this.addTeacher.Iconimage_Selected = null;
            this.addTeacher.IconMarginLeft = 0;
            this.addTeacher.IconMarginRight = 0;
            this.addTeacher.IconRightVisible = true;
            this.addTeacher.IconRightZoom = 0D;
            this.addTeacher.IconVisible = true;
            this.addTeacher.IconZoom = 50D;
            this.addTeacher.IsTab = false;
            this.addTeacher.Location = new System.Drawing.Point(78, 345);
            this.addTeacher.Name = "addTeacher";
            this.addTeacher.Normalcolor = System.Drawing.Color.Transparent;
            this.addTeacher.OnHovercolor = System.Drawing.Color.Transparent;
            this.addTeacher.OnHoverTextColor = System.Drawing.Color.White;
            this.addTeacher.selected = false;
            this.addTeacher.Size = new System.Drawing.Size(158, 48);
            this.addTeacher.TabIndex = 28;
            this.addTeacher.Text = "Submit";
            this.addTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTeacher.Textcolor = System.Drawing.Color.White;
            this.addTeacher.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // emailt
            // 
            this.AnimacionSidebar.SetDecoration(this.emailt, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.emailt, BunifuAnimatorNS.DecorationType.None);
            this.emailt.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.emailt.Location = new System.Drawing.Point(110, 185);
            this.emailt.Name = "emailt";
            this.emailt.Size = new System.Drawing.Size(184, 26);
            this.emailt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(17, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salary:";
            // 
            // namet
            // 
            this.AnimacionSidebar.SetDecoration(this.namet, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.namet, BunifuAnimatorNS.DecorationType.None);
            this.namet.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.namet.Location = new System.Drawing.Point(110, 64);
            this.namet.Name = "namet";
            this.namet.Size = new System.Drawing.Size(184, 26);
            this.namet.TabIndex = 4;
            // 
            // salaryt
            // 
            this.AnimacionSidebar.SetDecoration(this.salaryt, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.salaryt, BunifuAnimatorNS.DecorationType.None);
            this.salaryt.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.salaryt.Location = new System.Drawing.Point(110, 300);
            this.salaryt.Name = "salaryt";
            this.salaryt.Size = new System.Drawing.Size(184, 26);
            this.salaryt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(17, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // surnamet
            // 
            this.AnimacionSidebar.SetDecoration(this.surnamet, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.surnamet, BunifuAnimatorNS.DecorationType.None);
            this.surnamet.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.surnamet.Location = new System.Drawing.Point(110, 125);
            this.surnamet.Name = "surnamet";
            this.surnamet.Size = new System.Drawing.Size(184, 26);
            this.surnamet.TabIndex = 6;
            // 
            // passwordt
            // 
            this.AnimacionSidebar.SetDecoration(this.passwordt, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.passwordt, BunifuAnimatorNS.DecorationType.None);
            this.passwordt.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.passwordt.Location = new System.Drawing.Point(110, 240);
            this.passwordt.Name = "passwordt";
            this.passwordt.Size = new System.Drawing.Size(184, 26);
            this.passwordt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(17, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Cera Stencil", 13.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail:";
            // 
            // infoAdd
            // 
            this.infoAdd.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.infoAdd, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.infoAdd, BunifuAnimatorNS.DecorationType.None);
            this.infoAdd.Font = new System.Drawing.Font("Ethnocentric", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.infoAdd.Location = new System.Drawing.Point(263, 11);
            this.infoAdd.Name = "infoAdd";
            this.infoAdd.Size = new System.Drawing.Size(117, 23);
            this.infoAdd.TabIndex = 3;
            this.infoAdd.Text = "label3";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.AnimacionSidebar.SetDecoration(this.info, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.info, BunifuAnimatorNS.DecorationType.None);
            this.info.Font = new System.Drawing.Font("Ethnocentric", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.info.Location = new System.Drawing.Point(32, 24);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(117, 23);
            this.info.TabIndex = 1;
            this.info.Text = "label3";
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
            this.dgv.Location = new System.Drawing.Point(35, 92);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(560, 451);
            this.dgv.TabIndex = 0;
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this.Sidebar;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimacionSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation1;
            // 
            // AnimacionSidebarBack
            // 
            this.AnimacionSidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
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
            this.RadioPanelChart.TargetControl = this.dgv;
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
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlCommand2
            // 
            this.npgsqlCommand2.AllResultTypesAreUnknown = false;
            this.npgsqlCommand2.Transaction = null;
            this.npgsqlCommand2.UnknownResultTypeList = null;
            // 
            // AdminSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 635);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminSystem";
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
            this.Wrapper.ResumeLayout(false);
            this.Wrapper.PerformLayout();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.allUsers.ResumeLayout(false);
            this.allUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersdgv)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.Panel Wrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuFlatButton search;
        private Bunifu.Framework.UI.BunifuFlatButton addUser;
        private Bunifu.Framework.UI.BunifuFlatButton marks;
        private Bunifu.Framework.UI.BunifuFlatButton attendance;
        private Bunifu.Framework.UI.BunifuFlatButton revenue;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuGradientPanel panelTeacher;
        private System.Windows.Forms.TextBox emailt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox namet;
        private System.Windows.Forms.TextBox salaryt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surnamet;
        private System.Windows.Forms.TextBox passwordt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infoAdd;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private Bunifu.Framework.UI.BunifuFlatButton studentEnable;
        private Bunifu.Framework.UI.BunifuFlatButton teacherEnable;
        private Bunifu.Framework.UI.BunifuGradientPanel panelStudent;
        private System.Windows.Forms.Label student;
        private Bunifu.Framework.UI.BunifuFlatButton addStudent;
        private System.Windows.Forms.TextBox emails;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox surnames;
        private System.Windows.Forms.TextBox passwords;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label teacher;
        private Bunifu.Framework.UI.BunifuFlatButton addTeacher;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton searchUser;
        private Bunifu.Framework.UI.BunifuFlatButton users;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.RadioButton studRadio;
        private System.Windows.Forms.RadioButton teachRadio;
        private Bunifu.Framework.UI.BunifuGradientPanel updatePanel;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuFlatButton update;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox salarybox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox surnamebox;
        private System.Windows.Forms.TextBox pwdbox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel allUsers;
        private System.Windows.Forms.RadioButton students;
        private System.Windows.Forms.RadioButton teachers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView usersdgv;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Npgsql.NpgsqlCommand npgsqlCommand2;
        private Bunifu.Framework.UI.BunifuFlatButton filldgv;
        private Bunifu.Framework.UI.BunifuFlatButton addCourse;
    }
}

