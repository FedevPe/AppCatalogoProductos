namespace Presentacion
{
    partial class frmProductos
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
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.logo = new FontAwesome.Sharp.IconButton();
            this.btnAudio = new FontAwesome.Sharp.IconButton();
            this.btnMedia = new FontAwesome.Sharp.IconButton();
            this.btnTelevisores = new FontAwesome.Sharp.IconButton();
            this.btnCelulares = new FontAwesome.Sharp.IconButton();
            this.btnTodos = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlContenedorProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.btnPrecioDown = new FontAwesome.Sharp.IconButton();
            this.btnPrecioUp = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnBusqueda = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new Guna.UI2.WinForms.Guna2TextBox();
            this.elipseBtnTodos = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseBtnCelulares = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseBtnTelevisores = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseBtnMedia = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseBtnAudio = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseBtnPrecioUp = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseBtnPrecioDown = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseBtnAgregar = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.bordeFormulario = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.pnlTop.Controls.Add(this.btnMenu);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1163, 42);
            this.pnlTop.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(54)))), ((int)(((byte)(78)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(12, 9);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 23);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Catálogo de Productos";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.Location = new System.Drawing.Point(1075, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BotonesPnlTop_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.BotonesPnlTop_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.BotonesPnlTop_MouseLeave);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.Location = new System.Drawing.Point(1102, 9);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.BotonesPnlTop_Click);
            this.btnMaximize.MouseEnter += new System.EventHandler(this.BotonesPnlTop_MouseEnter);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.BotonesPnlTop_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(1129, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BotonesPnlTop_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BotonesPnlTop_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BotonesPnlTop_MouseLeave);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.pnlLeft.Controls.Add(this.logo);
            this.pnlLeft.Controls.Add(this.btnAudio);
            this.pnlLeft.Controls.Add(this.btnMedia);
            this.pnlLeft.Controls.Add(this.btnTelevisores);
            this.pnlLeft.Controls.Add(this.btnCelulares);
            this.pnlLeft.Controls.Add(this.btnTodos);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 42);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(226, 576);
            this.pnlLeft.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.logo.FlatAppearance.BorderSize = 0;
            this.logo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.logo.IconColor = System.Drawing.Color.White;
            this.logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logo.IconSize = 180;
            this.logo.Location = new System.Drawing.Point(29, 22);
            this.logo.Name = "logo";
            this.logo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logo.Size = new System.Drawing.Size(172, 162);
            this.logo.TabIndex = 16;
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logo.UseVisualStyleBackColor = false;
            // 
            // btnAudio
            // 
            this.btnAudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnAudio.FlatAppearance.BorderSize = 0;
            this.btnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.ForeColor = System.Drawing.Color.White;
            this.btnAudio.IconChar = FontAwesome.Sharp.IconChar.Headphones;
            this.btnAudio.IconColor = System.Drawing.Color.White;
            this.btnAudio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAudio.IconSize = 35;
            this.btnAudio.Location = new System.Drawing.Point(12, 422);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAudio.Size = new System.Drawing.Size(228, 50);
            this.btnAudio.TabIndex = 15;
            this.btnAudio.Text = "Audio";
            this.btnAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAudio.UseVisualStyleBackColor = false;
            this.btnAudio.Click += new System.EventHandler(this.BotonesFiltro_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.White;
            this.btnMedia.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnMedia.IconColor = System.Drawing.Color.White;
            this.btnMedia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedia.IconSize = 35;
            this.btnMedia.Location = new System.Drawing.Point(12, 364);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(228, 50);
            this.btnMedia.TabIndex = 14;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.BotonesFiltro_Click);
            // 
            // btnTelevisores
            // 
            this.btnTelevisores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnTelevisores.FlatAppearance.BorderSize = 0;
            this.btnTelevisores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelevisores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelevisores.ForeColor = System.Drawing.Color.White;
            this.btnTelevisores.IconChar = FontAwesome.Sharp.IconChar.Television;
            this.btnTelevisores.IconColor = System.Drawing.Color.White;
            this.btnTelevisores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTelevisores.IconSize = 35;
            this.btnTelevisores.Location = new System.Drawing.Point(12, 306);
            this.btnTelevisores.Name = "btnTelevisores";
            this.btnTelevisores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTelevisores.Size = new System.Drawing.Size(228, 50);
            this.btnTelevisores.TabIndex = 13;
            this.btnTelevisores.Text = "Televisores";
            this.btnTelevisores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelevisores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelevisores.UseVisualStyleBackColor = false;
            this.btnTelevisores.Click += new System.EventHandler(this.BotonesFiltro_Click);
            // 
            // btnCelulares
            // 
            this.btnCelulares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnCelulares.FlatAppearance.BorderSize = 0;
            this.btnCelulares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCelulares.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelulares.ForeColor = System.Drawing.Color.White;
            this.btnCelulares.IconChar = FontAwesome.Sharp.IconChar.MobileScreenButton;
            this.btnCelulares.IconColor = System.Drawing.Color.White;
            this.btnCelulares.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCelulares.IconSize = 35;
            this.btnCelulares.Location = new System.Drawing.Point(12, 248);
            this.btnCelulares.Name = "btnCelulares";
            this.btnCelulares.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCelulares.Size = new System.Drawing.Size(228, 50);
            this.btnCelulares.TabIndex = 12;
            this.btnCelulares.Text = "Celulares";
            this.btnCelulares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCelulares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCelulares.UseVisualStyleBackColor = false;
            this.btnCelulares.Click += new System.EventHandler(this.BotonesFiltro_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnTodos.FlatAppearance.BorderSize = 0;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.White;
            this.btnTodos.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnTodos.IconColor = System.Drawing.Color.White;
            this.btnTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTodos.IconSize = 35;
            this.btnTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodos.Location = new System.Drawing.Point(12, 190);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(228, 50);
            this.btnTodos.TabIndex = 11;
            this.btnTodos.Text = "Todos los productos";
            this.btnTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.BotonesFiltro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlContenedorProductos);
            this.panel1.Controls.Add(this.pnlBusqueda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(226, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 576);
            this.panel1.TabIndex = 5;
            // 
            // pnlContenedorProductos
            // 
            this.pnlContenedorProductos.AutoScroll = true;
            this.pnlContenedorProductos.BackColor = System.Drawing.Color.White;
            this.pnlContenedorProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorProductos.Location = new System.Drawing.Point(0, 61);
            this.pnlContenedorProductos.Name = "pnlContenedorProductos";
            this.pnlContenedorProductos.Size = new System.Drawing.Size(937, 515);
            this.pnlContenedorProductos.TabIndex = 2;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Controls.Add(this.btnPrecioDown);
            this.pnlBusqueda.Controls.Add(this.btnPrecioUp);
            this.pnlBusqueda.Controls.Add(this.btnAgregar);
            this.pnlBusqueda.Controls.Add(this.btnBusqueda);
            this.pnlBusqueda.Controls.Add(this.label1);
            this.pnlBusqueda.Controls.Add(this.txtBusqueda);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 0);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(937, 61);
            this.pnlBusqueda.TabIndex = 1;
            // 
            // btnPrecioDown
            // 
            this.btnPrecioDown.AutoEllipsis = true;
            this.btnPrecioDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnPrecioDown.FlatAppearance.BorderSize = 0;
            this.btnPrecioDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioDown.ForeColor = System.Drawing.Color.White;
            this.btnPrecioDown.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            this.btnPrecioDown.IconColor = System.Drawing.Color.White;
            this.btnPrecioDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrecioDown.IconSize = 35;
            this.btnPrecioDown.Location = new System.Drawing.Point(640, 11);
            this.btnPrecioDown.Name = "btnPrecioDown";
            this.btnPrecioDown.Size = new System.Drawing.Size(43, 43);
            this.btnPrecioDown.TabIndex = 12;
            this.btnPrecioDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrecioDown.UseVisualStyleBackColor = false;
            this.btnPrecioDown.Click += new System.EventHandler(this.btnPrecioDown_Click);
            // 
            // btnPrecioUp
            // 
            this.btnPrecioUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnPrecioUp.FlatAppearance.BorderSize = 0;
            this.btnPrecioUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioUp.ForeColor = System.Drawing.Color.White;
            this.btnPrecioUp.IconChar = FontAwesome.Sharp.IconChar.ArrowDownShortWide;
            this.btnPrecioUp.IconColor = System.Drawing.Color.White;
            this.btnPrecioUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrecioUp.IconSize = 35;
            this.btnPrecioUp.Location = new System.Drawing.Point(591, 11);
            this.btnPrecioUp.Name = "btnPrecioUp";
            this.btnPrecioUp.Size = new System.Drawing.Size(43, 43);
            this.btnPrecioUp.TabIndex = 11;
            this.btnPrecioUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrecioUp.UseVisualStyleBackColor = false;
            this.btnPrecioUp.Click += new System.EventHandler(this.btnPrecioUp_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.Location = new System.Drawing.Point(752, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(182, 43);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusqueda.IconColor = System.Drawing.Color.Black;
            this.btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusqueda.IconSize = 28;
            this.btnBusqueda.Location = new System.Drawing.Point(480, 18);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(32, 29);
            this.btnBusqueda.TabIndex = 10;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(530, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.txtBusqueda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.txtBusqueda.BorderRadius = 6;
            this.txtBusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusqueda.DefaultText = "";
            this.txtBusqueda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusqueda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusqueda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusqueda.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtBusqueda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtBusqueda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.txtBusqueda.Location = new System.Drawing.Point(16, 14);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.PasswordChar = '\0';
            this.txtBusqueda.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBusqueda.PlaceholderText = "Busqueda por nombre";
            this.txtBusqueda.SelectedText = "";
            this.txtBusqueda.ShadowDecoration.Enabled = true;
            this.txtBusqueda.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.txtBusqueda.Size = new System.Drawing.Size(500, 36);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // elipseBtnTodos
            // 
            this.elipseBtnTodos.BorderRadius = 15;
            this.elipseBtnTodos.TargetControl = this.btnTodos;
            // 
            // elipseBtnCelulares
            // 
            this.elipseBtnCelulares.BorderRadius = 15;
            this.elipseBtnCelulares.TargetControl = this.btnCelulares;
            // 
            // elipseBtnTelevisores
            // 
            this.elipseBtnTelevisores.BorderRadius = 15;
            this.elipseBtnTelevisores.TargetControl = this.btnTelevisores;
            // 
            // elipseBtnMedia
            // 
            this.elipseBtnMedia.BorderRadius = 15;
            this.elipseBtnMedia.TargetControl = this.btnMedia;
            // 
            // elipseBtnAudio
            // 
            this.elipseBtnAudio.BorderRadius = 15;
            this.elipseBtnAudio.TargetControl = this.btnAudio;
            // 
            // elipseBtnPrecioUp
            // 
            this.elipseBtnPrecioUp.TargetControl = this.btnPrecioUp;
            // 
            // elipseBtnPrecioDown
            // 
            this.elipseBtnPrecioDown.TargetControl = this.btnPrecioDown;
            // 
            // elipseBtnAgregar
            // 
            this.elipseBtnAgregar.TargetControl = this.btnAgregar;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.pnlTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // bordeFormulario
            // 
            this.bordeFormulario.ContainerControl = this;
            this.bordeFormulario.DockIndicatorTransparencyValue = 0.6D;
            this.bordeFormulario.DragForm = false;
            this.bordeFormulario.DragStartTransparencyValue = 1D;
            this.bordeFormulario.TransparentWhileDrag = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1163, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogoProductos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private FontAwesome.Sharp.IconButton btnAudio;
        private FontAwesome.Sharp.IconButton btnMedia;
        private FontAwesome.Sharp.IconButton btnTelevisores;
        private FontAwesome.Sharp.IconButton btnCelulares;
        private FontAwesome.Sharp.IconButton btnTodos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlContenedorProductos;
        private System.Windows.Forms.Panel pnlBusqueda;
        private FontAwesome.Sharp.IconButton btnPrecioDown;
        private FontAwesome.Sharp.IconButton btnPrecioUp;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBusqueda;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnTodos;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnCelulares;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnTelevisores;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnMedia;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnAudio;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnPrecioUp;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnPrecioDown;
        private Guna.UI2.WinForms.Guna2Elipse elipseBtnAgregar;
        private FontAwesome.Sharp.IconButton logo;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm bordeFormulario;
    }
}

