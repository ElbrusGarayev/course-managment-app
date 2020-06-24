namespace Design_Dashboard_Modern
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.fill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.amount = new System.Windows.Forms.TextBox();
            this.nameS = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.cnumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.ComboBox();
            this.pay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebarBack = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RadioPanelChart = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.MoverDashboard = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.npgsqlCommand1 = new Npgsql.NpgsqlCommand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.AnimacionSidebarBack.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuTop, BunifuAnimatorNS.DecorationType.None);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(682, 78);
            this.MenuTop.TabIndex = 0;
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(605, 24);
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
            this.Minimizar.Location = new System.Drawing.Point(569, 24);
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
            this.Maximizar.Location = new System.Drawing.Point(605, 24);
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
            this.Salir.Location = new System.Drawing.Point(641, 24);
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
            this.label1.Font = new System.Drawing.Font("Banjax Notched", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(282, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment";
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.label7);
            this.Sidebar.Controls.Add(this.fill);
            this.Sidebar.Controls.Add(this.amount);
            this.Sidebar.Controls.Add(this.nameS);
            this.Sidebar.Controls.Add(this.pin);
            this.Sidebar.Controls.Add(this.cnumber);
            this.Sidebar.Controls.Add(this.label6);
            this.Sidebar.Controls.Add(this.label5);
            this.Sidebar.Controls.Add(this.label4);
            this.Sidebar.Controls.Add(this.label3);
            this.Sidebar.Controls.Add(this.box);
            this.Sidebar.Controls.Add(this.pay);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.AnimacionSidebarBack.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.Sidebar.Location = new System.Drawing.Point(0, 77);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(682, 390);
            this.Sidebar.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Cera Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(36, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Course Name:";
            // 
            // fill
            // 
            this.fill.Activecolor = System.Drawing.Color.Transparent;
            this.fill.BackColor = System.Drawing.Color.Transparent;
            this.fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fill.BackgroundImage")));
            this.fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fill.BorderRadius = 5;
            this.fill.ButtonText = "FILL";
            this.fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebar.SetDecoration(this.fill, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.fill, BunifuAnimatorNS.DecorationType.None);
            this.fill.DisabledColor = System.Drawing.Color.Gray;
            this.fill.Font = new System.Drawing.Font("Cera Stencil", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill.ForeColor = System.Drawing.Color.Black;
            this.fill.Iconcolor = System.Drawing.Color.Transparent;
            this.fill.Iconimage = null;
            this.fill.Iconimage_right = null;
            this.fill.Iconimage_right_Selected = null;
            this.fill.Iconimage_Selected = null;
            this.fill.IconMarginLeft = 0;
            this.fill.IconMarginRight = 0;
            this.fill.IconRightVisible = true;
            this.fill.IconRightZoom = 0D;
            this.fill.IconVisible = true;
            this.fill.IconZoom = 50D;
            this.fill.IsTab = false;
            this.fill.Location = new System.Drawing.Point(76, 314);
            this.fill.Name = "fill";
            this.fill.Normalcolor = System.Drawing.Color.Transparent;
            this.fill.OnHovercolor = System.Drawing.Color.Transparent;
            this.fill.OnHoverTextColor = System.Drawing.Color.White;
            this.fill.selected = false;
            this.fill.Size = new System.Drawing.Size(155, 61);
            this.fill.TabIndex = 27;
            this.fill.Text = "FILL";
            this.fill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fill.Textcolor = System.Drawing.Color.White;
            this.fill.TextFont = new System.Drawing.Font("Cera Stencil", 19.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // amount
            // 
            this.AnimacionSidebar.SetDecoration(this.amount, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.amount, BunifuAnimatorNS.DecorationType.None);
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amount.Location = new System.Drawing.Point(363, 269);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(236, 29);
            this.amount.TabIndex = 26;
            // 
            // nameS
            // 
            this.AnimacionSidebar.SetDecoration(this.nameS, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.nameS, BunifuAnimatorNS.DecorationType.None);
            this.nameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameS.Location = new System.Drawing.Point(40, 269);
            this.nameS.Name = "nameS";
            this.nameS.Size = new System.Drawing.Size(236, 29);
            this.nameS.TabIndex = 25;
            // 
            // pin
            // 
            this.AnimacionSidebar.SetDecoration(this.pin, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.pin, BunifuAnimatorNS.DecorationType.None);
            this.pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pin.Location = new System.Drawing.Point(363, 192);
            this.pin.Name = "pin";
            this.pin.PasswordChar = '•';
            this.pin.Size = new System.Drawing.Size(236, 29);
            this.pin.TabIndex = 24;
            // 
            // cnumber
            // 
            this.AnimacionSidebar.SetDecoration(this.cnumber, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.cnumber, BunifuAnimatorNS.DecorationType.None);
            this.cnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cnumber.Location = new System.Drawing.Point(363, 105);
            this.cnumber.Name = "cnumber";
            this.cnumber.Size = new System.Drawing.Size(236, 29);
            this.cnumber.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Cera Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(359, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Cera Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(359, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Card Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Cera Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name/Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarBack.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Cera Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Amount:";
            // 
            // box
            // 
            this.box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AnimacionSidebarBack.SetDecoration(this.box, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.box, BunifuAnimatorNS.DecorationType.None);
            this.box.Font = new System.Drawing.Font("Cera Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(40, 105);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(250, 28);
            this.box.TabIndex = 17;
            this.box.Text = "Course Name";
            this.box.SelectedValueChanged += new System.EventHandler(this.Box_SelectedValueChanged);
            // 
            // pay
            // 
            this.pay.Activecolor = System.Drawing.Color.Transparent;
            this.pay.BackColor = System.Drawing.Color.Transparent;
            this.pay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay.BackgroundImage")));
            this.pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pay.BorderRadius = 5;
            this.pay.ButtonText = "";
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
            this.pay.Location = new System.Drawing.Point(363, 314);
            this.pay.Name = "pay";
            this.pay.Normalcolor = System.Drawing.Color.Transparent;
            this.pay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(159)))), ((int)(((byte)(5)))));
            this.pay.OnHoverTextColor = System.Drawing.Color.White;
            this.pay.selected = false;
            this.pay.Size = new System.Drawing.Size(236, 61);
            this.pay.TabIndex = 13;
            this.pay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pay.Textcolor = System.Drawing.Color.White;
            this.pay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarBack.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.LineaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(236, 54);
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
            this.label2.Location = new System.Drawing.Point(284, 24);
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
            this.pictureBox1.Location = new System.Drawing.Point(238, 8);
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
            // npgsqlCommand1
            // 
            this.npgsqlCommand1.AllResultTypesAreUnknown = false;
            this.npgsqlCommand1.Transaction = null;
            this.npgsqlCommand1.UnknownResultTypeList = null;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 464);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.MenuTop);
            this.AnimacionSidebarBack.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label1;
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
        private Npgsql.NpgsqlCommand npgsqlCommand1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox box;
        private Bunifu.Framework.UI.BunifuFlatButton pay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox nameS;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.TextBox cnumber;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Bunifu.Framework.UI.BunifuFlatButton fill;
        private System.Windows.Forms.Label label7;
    }
}

