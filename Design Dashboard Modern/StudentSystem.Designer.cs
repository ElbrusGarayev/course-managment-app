namespace Design_Dashboard_Modern
{
    partial class StudentSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSystem));
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
            this.mySubs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.todo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.marks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.attendance = new Bunifu.Framework.UI.BunifuFlatButton();
            this.courseReg = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.register = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cprice = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.info = new System.Windows.Forms.Label();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
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
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Information System";
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
            this.Sidebar.Controls.Add(this.mySubs);
            this.Sidebar.Controls.Add(this.logout);
            this.Sidebar.Controls.Add(this.pay);
            this.Sidebar.Controls.Add(this.todo);
            this.Sidebar.Controls.Add(this.marks);
            this.Sidebar.Controls.Add(this.attendance);
            this.Sidebar.Controls.Add(this.courseReg);
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
            this.Sidebar.Size = new System.Drawing.Size(278, 519);
            this.Sidebar.TabIndex = 0;
            // 
            // mySubs
            // 
            this.mySubs.Activecolor = System.Drawing.Color.Transparent;
            this.mySubs.BackColor = System.Drawing.Color.Transparent;
            this.mySubs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mySubs.BorderRadius = 0;
            this.mySubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mySubs.ButtonText = "MY SUBSCRIPTIONS";
            this.mySubs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.mySubs, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.mySubs, BunifuAnimatorNS.DecorationType.None);
            this.mySubs.DisabledColor = System.Drawing.Color.Gray;
            this.mySubs.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mySubs.ForeColor = System.Drawing.Color.Black;
            this.mySubs.Iconcolor = System.Drawing.Color.Transparent;
            this.mySubs.Iconimage = null;
            this.mySubs.Iconimage_right = null;
            this.mySubs.Iconimage_right_Selected = null;
            this.mySubs.Iconimage_Selected = null;
            this.mySubs.IconMarginLeft = 0;
            this.mySubs.IconMarginRight = 0;
            this.mySubs.IconRightVisible = true;
            this.mySubs.IconRightZoom = 0D;
            this.mySubs.IconVisible = true;
            this.mySubs.IconZoom = 50D;
            this.mySubs.IsTab = false;
            this.mySubs.Location = new System.Drawing.Point(9, 383);
            this.mySubs.Name = "mySubs";
            this.mySubs.Normalcolor = System.Drawing.Color.Transparent;
            this.mySubs.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.mySubs.OnHoverTextColor = System.Drawing.Color.Black;
            this.mySubs.selected = false;
            this.mySubs.Size = new System.Drawing.Size(252, 51);
            this.mySubs.TabIndex = 14;
            this.mySubs.Text = "MY SUBSCRIPTIONS";
            this.mySubs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mySubs.Textcolor = System.Drawing.Color.Black;
            this.mySubs.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mySubs.Click += new System.EventHandler(this.MySubs_Click);
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
            this.logout.ForeColor = System.Drawing.Color.Black;
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
            this.logout.Location = new System.Drawing.Point(9, 452);
            this.logout.Name = "logout";
            this.logout.Normalcolor = System.Drawing.Color.Transparent;
            this.logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.logout.OnHoverTextColor = System.Drawing.Color.Black;
            this.logout.selected = false;
            this.logout.Size = new System.Drawing.Size(252, 51);
            this.logout.TabIndex = 13;
            this.logout.Text = "LOG OUT";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.Textcolor = System.Drawing.Color.Black;
            this.logout.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // pay
            // 
            this.pay.Activecolor = System.Drawing.Color.Transparent;
            this.pay.BackColor = System.Drawing.Color.Transparent;
            this.pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay.BorderRadius = 0;
            this.pay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pay.ButtonText = "PAYMENT";
            this.pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.pay, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pay, BunifuAnimatorNS.DecorationType.None);
            this.pay.DisabledColor = System.Drawing.Color.Gray;
            this.pay.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pay.ForeColor = System.Drawing.Color.Black;
            this.pay.Iconcolor = System.Drawing.Color.Transparent;
            this.pay.Iconimage = null;
            this.pay.Iconimage_right = null;
            this.pay.Iconimage_right_Selected = null;
            this.pay.Iconimage_Selected = null;
            this.pay.IconMarginLeft = 0;
            this.pay.IconMarginRight = 0;
            this.pay.IconRightVisible = true;
            this.pay.IconRightZoom = 0D;
            this.pay.IconVisible = true;
            this.pay.IconZoom = 50D;
            this.pay.IsTab = false;
            this.pay.Location = new System.Drawing.Point(9, 323);
            this.pay.Name = "pay";
            this.pay.Normalcolor = System.Drawing.Color.Transparent;
            this.pay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.pay.OnHoverTextColor = System.Drawing.Color.Black;
            this.pay.selected = false;
            this.pay.Size = new System.Drawing.Size(252, 51);
            this.pay.TabIndex = 12;
            this.pay.Text = "PAYMENT";
            this.pay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pay.Textcolor = System.Drawing.Color.Black;
            this.pay.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // todo
            // 
            this.todo.Activecolor = System.Drawing.Color.Transparent;
            this.todo.BackColor = System.Drawing.Color.Transparent;
            this.todo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.todo.BorderRadius = 0;
            this.todo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todo.ButtonText = "TODO";
            this.todo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.todo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.todo, BunifuAnimatorNS.DecorationType.None);
            this.todo.DisabledColor = System.Drawing.Color.Gray;
            this.todo.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.todo.ForeColor = System.Drawing.Color.Black;
            this.todo.Iconcolor = System.Drawing.Color.Transparent;
            this.todo.Iconimage = null;
            this.todo.Iconimage_right = null;
            this.todo.Iconimage_right_Selected = null;
            this.todo.Iconimage_Selected = null;
            this.todo.IconMarginLeft = 0;
            this.todo.IconMarginRight = 0;
            this.todo.IconRightVisible = true;
            this.todo.IconRightZoom = 0D;
            this.todo.IconVisible = true;
            this.todo.IconZoom = 50D;
            this.todo.IsTab = false;
            this.todo.Location = new System.Drawing.Point(7, 266);
            this.todo.Name = "todo";
            this.todo.Normalcolor = System.Drawing.Color.Transparent;
            this.todo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.todo.OnHoverTextColor = System.Drawing.Color.Black;
            this.todo.selected = false;
            this.todo.Size = new System.Drawing.Size(252, 51);
            this.todo.TabIndex = 11;
            this.todo.Text = "TODO";
            this.todo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.todo.Textcolor = System.Drawing.Color.Black;
            this.todo.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todo.Click += new System.EventHandler(this.Todo_Click);
            // 
            // marks
            // 
            this.marks.Activecolor = System.Drawing.Color.Transparent;
            this.marks.BackColor = System.Drawing.Color.Transparent;
            this.marks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.marks.BorderRadius = 0;
            this.marks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marks.ButtonText = "MARKS";
            this.marks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.marks, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.marks, BunifuAnimatorNS.DecorationType.None);
            this.marks.DisabledColor = System.Drawing.Color.Gray;
            this.marks.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marks.ForeColor = System.Drawing.Color.Black;
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
            this.marks.Location = new System.Drawing.Point(9, 209);
            this.marks.Name = "marks";
            this.marks.Normalcolor = System.Drawing.Color.Transparent;
            this.marks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.marks.OnHoverTextColor = System.Drawing.Color.Black;
            this.marks.selected = false;
            this.marks.Size = new System.Drawing.Size(252, 51);
            this.marks.TabIndex = 10;
            this.marks.Text = "MARKS";
            this.marks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.marks.Textcolor = System.Drawing.Color.Black;
            this.marks.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks.Click += new System.EventHandler(this.Marks_Click);
            // 
            // attendance
            // 
            this.attendance.Activecolor = System.Drawing.Color.Transparent;
            this.attendance.BackColor = System.Drawing.Color.Transparent;
            this.attendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attendance.BorderRadius = 0;
            this.attendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attendance.ButtonText = "ATTENDANCE";
            this.attendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.attendance, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.attendance, BunifuAnimatorNS.DecorationType.None);
            this.attendance.DisabledColor = System.Drawing.Color.Gray;
            this.attendance.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.attendance.ForeColor = System.Drawing.Color.Black;
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
            this.attendance.Location = new System.Drawing.Point(7, 143);
            this.attendance.Name = "attendance";
            this.attendance.Normalcolor = System.Drawing.Color.Transparent;
            this.attendance.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.attendance.OnHoverTextColor = System.Drawing.Color.Black;
            this.attendance.selected = false;
            this.attendance.Size = new System.Drawing.Size(252, 51);
            this.attendance.TabIndex = 9;
            this.attendance.Text = "ATTENDANCE";
            this.attendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attendance.Textcolor = System.Drawing.Color.Black;
            this.attendance.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // courseReg
            // 
            this.courseReg.Activecolor = System.Drawing.Color.Transparent;
            this.courseReg.BackColor = System.Drawing.Color.Transparent;
            this.courseReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.courseReg.BorderRadius = 0;
            this.courseReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseReg.ButtonText = "COURSE REGISTRATION";
            this.courseReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.courseReg, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.courseReg, BunifuAnimatorNS.DecorationType.None);
            this.courseReg.DisabledColor = System.Drawing.Color.Gray;
            this.courseReg.Font = new System.Drawing.Font("Bauhaus 93", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseReg.ForeColor = System.Drawing.Color.Black;
            this.courseReg.Iconcolor = System.Drawing.Color.Transparent;
            this.courseReg.Iconimage = null;
            this.courseReg.Iconimage_right = null;
            this.courseReg.Iconimage_right_Selected = null;
            this.courseReg.Iconimage_Selected = null;
            this.courseReg.IconMarginLeft = 0;
            this.courseReg.IconMarginRight = 0;
            this.courseReg.IconRightVisible = true;
            this.courseReg.IconRightZoom = 0D;
            this.courseReg.IconVisible = true;
            this.courseReg.IconZoom = 50D;
            this.courseReg.IsTab = false;
            this.courseReg.Location = new System.Drawing.Point(9, 86);
            this.courseReg.Name = "courseReg";
            this.courseReg.Normalcolor = System.Drawing.Color.Transparent;
            this.courseReg.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.courseReg.OnHoverTextColor = System.Drawing.Color.Black;
            this.courseReg.selected = false;
            this.courseReg.Size = new System.Drawing.Size(252, 51);
            this.courseReg.TabIndex = 8;
            this.courseReg.Text = "COURSE REGISTRATION";
            this.courseReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.courseReg.Textcolor = System.Drawing.Color.Black;
            this.courseReg.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseReg.Click += new System.EventHandler(this.CourseReg_Click);
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
            this.label2.Location = new System.Drawing.Point(66, 23);
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
            this.Wrapper.Controls.Add(this.register);
            this.Wrapper.Controls.Add(this.cprice);
            this.Wrapper.Controls.Add(this.cname);
            this.Wrapper.Controls.Add(this.dgv);
            this.Wrapper.Controls.Add(this.info);
            this.AnimacionSidebarBack.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Wrapper, BunifuAnimatorNS.DecorationType.None);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(300, 80);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(625, 555);
            this.Wrapper.TabIndex = 2;
            // 
            // register
            // 
            this.register.Activecolor = System.Drawing.Color.Transparent;
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.register.BorderRadius = 5;
            this.register.ButtonText = "REGISTER";
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.register, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.register, BunifuAnimatorNS.DecorationType.None);
            this.register.DisabledColor = System.Drawing.Color.Gray;
            this.register.Font = new System.Drawing.Font("Banjax Notched", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.Iconcolor = System.Drawing.Color.Transparent;
            this.register.Iconimage = null;
            this.register.Iconimage_right = null;
            this.register.Iconimage_right_Selected = null;
            this.register.Iconimage_Selected = null;
            this.register.IconMarginLeft = 0;
            this.register.IconMarginRight = 0;
            this.register.IconRightVisible = true;
            this.register.IconRightZoom = 0D;
            this.register.IconVisible = true;
            this.register.IconZoom = 50D;
            this.register.IsTab = false;
            this.register.Location = new System.Drawing.Point(422, 347);
            this.register.Name = "register";
            this.register.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.register.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.register.OnHoverTextColor = System.Drawing.Color.Black;
            this.register.selected = false;
            this.register.Size = new System.Drawing.Size(146, 51);
            this.register.TabIndex = 15;
            this.register.Text = "REGISTER";
            this.register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.register.Textcolor = System.Drawing.Color.Black;
            this.register.TextFont = new System.Drawing.Font("Cera Stencil", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Click += new System.EventHandler(this.Register_Click);
            // 
            // cprice
            // 
            this.cprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.AnimacionSidebar.SetDecoration(this.cprice, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.cprice, BunifuAnimatorNS.DecorationType.None);
            this.cprice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cprice.Location = new System.Drawing.Point(393, 272);
            this.cprice.Name = "cprice";
            this.cprice.Size = new System.Drawing.Size(197, 30);
            this.cprice.TabIndex = 3;
            // 
            // cname
            // 
            this.cname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.AnimacionSidebar.SetDecoration(this.cname, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.cname, BunifuAnimatorNS.DecorationType.None);
            this.cname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cname.Location = new System.Drawing.Point(393, 216);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(197, 30);
            this.cname.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimacionSidebarBack.SetDecoration(this.dgv, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.dgv, BunifuAnimatorNS.DecorationType.None);
            this.dgv.Location = new System.Drawing.Point(19, 92);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(350, 450);
            this.dgv.TabIndex = 0;
            this.dgv.Click += new System.EventHandler(this.Dgv_Click);
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
            // StudentSystem
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
            this.Name = "StudentSystem";
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
        private Bunifu.Framework.UI.BunifuFlatButton pay;
        private Bunifu.Framework.UI.BunifuFlatButton todo;
        private Bunifu.Framework.UI.BunifuFlatButton marks;
        private Bunifu.Framework.UI.BunifuFlatButton attendance;
        private Bunifu.Framework.UI.BunifuFlatButton courseReg;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.DataGridView dgv;
        private Bunifu.Framework.UI.BunifuFlatButton register;
        private System.Windows.Forms.TextBox cprice;
        private System.Windows.Forms.TextBox cname;
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private Bunifu.Framework.UI.BunifuFlatButton mySubs;
    }
}

