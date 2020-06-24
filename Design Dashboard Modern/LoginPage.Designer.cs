namespace Design_Dashboard_Modern
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.student = new System.Windows.Forms.RadioButton();
            this.teacher = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.login = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Controls.Add(this.label1);
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(525, 80);
            this.MenuTop.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(484, 24);
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
            this.label1.Font = new System.Drawing.Font("Banjax Notched", 22.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN ";
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
            this.SidebarWrapper.Size = new System.Drawing.Size(525, 392);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.student);
            this.Sidebar.Controls.Add(this.teacher);
            this.Sidebar.Controls.Add(this.admin);
            this.Sidebar.Controls.Add(this.login);
            this.Sidebar.Controls.Add(this.password);
            this.Sidebar.Controls.Add(this.email);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Sidebar.Location = new System.Drawing.Point(85, 24);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(357, 343);
            this.Sidebar.TabIndex = 0;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.student, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.student, BunifuAnimatorNS.DecorationType.None);
            this.student.Font = new System.Drawing.Font("Banjax Notched", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.student.Location = new System.Drawing.Point(242, 135);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(100, 27);
            this.student.TabIndex = 15;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = false;
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.teacher, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.teacher, BunifuAnimatorNS.DecorationType.None);
            this.teacher.Font = new System.Drawing.Font("Banjax Notched", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacher.Location = new System.Drawing.Point(127, 135);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(99, 27);
            this.teacher.TabIndex = 14;
            this.teacher.Text = "Teacher";
            this.teacher.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Checked = true;
            this.AnimacionSidebar.SetDecoration(this.admin, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.admin, BunifuAnimatorNS.DecorationType.None);
            this.admin.Font = new System.Drawing.Font("Banjax Notched", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin.Location = new System.Drawing.Point(12, 135);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(87, 27);
            this.admin.TabIndex = 13;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.login, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.login, BunifuAnimatorNS.DecorationType.None);
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("Ethnocentric", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.login.Location = new System.Drawing.Point(97, 277);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(158, 44);
            this.login.TabIndex = 12;
            this.login.Text = "Log in";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.Login_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.password, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.password, BunifuAnimatorNS.DecorationType.None);
            this.password.Font = new System.Drawing.Font("Banjax Notched", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(74, 232);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(200, 27);
            this.password.TabIndex = 11;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.Password_Enter);
            this.password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacionSidebar.SetDecoration(this.email, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.email, BunifuAnimatorNS.DecorationType.None);
            this.email.Font = new System.Drawing.Font("Banjax Notched", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email.ForeColor = System.Drawing.Color.Gray;
            this.email.Location = new System.Drawing.Point(74, 180);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 27);
            this.email.TabIndex = 8;
            this.email.Text = "E-mail";
            this.email.Enter += new System.EventHandler(this.Email_Enter);
            this.email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(47, 128);
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
            this.label2.Font = new System.Drawing.Font("Ethnocentric", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(108, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codex Academy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 92);
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
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 472);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidebarWrapper;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarBack;
        private Bunifu.Framework.UI.BunifuElipse RadioPanelChart;
        private System.Windows.Forms.Timer Temporizador;
        private Bunifu.Framework.UI.BunifuDragControl MoverDashboard;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.RadioButton teacher;
        private System.Windows.Forms.RadioButton admin;
    }
}

