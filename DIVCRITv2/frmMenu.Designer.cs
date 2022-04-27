
namespace DIVCRITv2
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnAyuda = new FontAwesome.Sharp.IconButton();
            this.btnAltaColab = new FontAwesome.Sharp.IconButton();
            this.btnInventario = new FontAwesome.Sharp.IconButton();
            this.btnGestionPyV = new FontAwesome.Sharp.IconButton();
            this.btnPyV = new FontAwesome.Sharp.IconButton();
            this.btnDirectorio = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pbxDivcrit = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivcrit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(2)))), ((int)(((byte)(149)))));
            this.panelMenu.Controls.Add(this.btnAcercaDe);
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.btnAyuda);
            this.panelMenu.Controls.Add(this.btnAltaColab);
            this.panelMenu.Controls.Add(this.btnInventario);
            this.panelMenu.Controls.Add(this.btnGestionPyV);
            this.panelMenu.Controls.Add(this.btnPyV);
            this.panelMenu.Controls.Add(this.btnDirectorio);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(253, 661);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnAcercaDe.IconColor = System.Drawing.Color.White;
            this.btnAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcercaDe.IconSize = 30;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 449);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAcercaDe.Size = new System.Drawing.Size(253, 48);
            this.btnAcercaDe.TabIndex = 7;
            this.btnAcercaDe.Tag = "   ACERCA DE";
            this.btnAcercaDe.Text = "   ACERCA DE";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 30;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 627);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(253, 34);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Tag = "   CERRAR SESIÓN";
            this.btnCerrarSesion.Text = "   CERRAR SESIÓN";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnAyuda.IconColor = System.Drawing.Color.White;
            this.btnAyuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAyuda.IconSize = 30;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 401);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAyuda.Size = new System.Drawing.Size(253, 48);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.Tag = "   AYUDA";
            this.btnAyuda.Text = "   AYUDA";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAltaColab
            // 
            this.btnAltaColab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaColab.FlatAppearance.BorderSize = 0;
            this.btnAltaColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaColab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaColab.ForeColor = System.Drawing.Color.White;
            this.btnAltaColab.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnAltaColab.IconColor = System.Drawing.Color.White;
            this.btnAltaColab.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaColab.IconSize = 30;
            this.btnAltaColab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaColab.Location = new System.Drawing.Point(0, 353);
            this.btnAltaColab.Name = "btnAltaColab";
            this.btnAltaColab.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAltaColab.Size = new System.Drawing.Size(253, 48);
            this.btnAltaColab.TabIndex = 4;
            this.btnAltaColab.Tag = "    ALTA DE COLABORADORES";
            this.btnAltaColab.Text = "    ALTA DE COLABORADORES";
            this.btnAltaColab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaColab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaColab.UseVisualStyleBackColor = true;
            this.btnAltaColab.Click += new System.EventHandler(this.btnAltaColab_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnInventario.IconColor = System.Drawing.Color.White;
            this.btnInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventario.IconSize = 30;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(0, 305);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(253, 48);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Tag = "   INVENTARIO";
            this.btnInventario.Text = "   INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnGestionPyV
            // 
            this.btnGestionPyV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionPyV.FlatAppearance.BorderSize = 0;
            this.btnGestionPyV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPyV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPyV.ForeColor = System.Drawing.Color.White;
            this.btnGestionPyV.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.btnGestionPyV.IconColor = System.Drawing.Color.White;
            this.btnGestionPyV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionPyV.IconSize = 30;
            this.btnGestionPyV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPyV.Location = new System.Drawing.Point(0, 248);
            this.btnGestionPyV.Name = "btnGestionPyV";
            this.btnGestionPyV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestionPyV.Size = new System.Drawing.Size(253, 57);
            this.btnGestionPyV.TabIndex = 2;
            this.btnGestionPyV.Tag = "   GESTIÓN DE PERMISOS Y ";
            this.btnGestionPyV.Text = "   GESTIÓN DE PERMISOS Y \r\n   VACACIONES";
            this.btnGestionPyV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPyV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGestionPyV.UseVisualStyleBackColor = true;
            this.btnGestionPyV.Click += new System.EventHandler(this.btnGestionPyV_Click);
            // 
            // btnPyV
            // 
            this.btnPyV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPyV.FlatAppearance.BorderSize = 0;
            this.btnPyV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPyV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPyV.ForeColor = System.Drawing.Color.White;
            this.btnPyV.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnPyV.IconColor = System.Drawing.Color.White;
            this.btnPyV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPyV.IconSize = 30;
            this.btnPyV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPyV.Location = new System.Drawing.Point(0, 200);
            this.btnPyV.Name = "btnPyV";
            this.btnPyV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPyV.Size = new System.Drawing.Size(253, 48);
            this.btnPyV.TabIndex = 1;
            this.btnPyV.Tag = "    PERMISOS Y VACACIONES";
            this.btnPyV.Text = "    PERMISOS Y VACACIONES";
            this.btnPyV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPyV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPyV.UseVisualStyleBackColor = true;
            this.btnPyV.Click += new System.EventHandler(this.btnPyV_Click);
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirectorio.FlatAppearance.BorderSize = 0;
            this.btnDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectorio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectorio.ForeColor = System.Drawing.Color.White;
            this.btnDirectorio.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnDirectorio.IconColor = System.Drawing.Color.White;
            this.btnDirectorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDirectorio.IconSize = 30;
            this.btnDirectorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectorio.Location = new System.Drawing.Point(0, 152);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDirectorio.Size = new System.Drawing.Size(253, 48);
            this.btnDirectorio.TabIndex = 0;
            this.btnDirectorio.Tag = "   DIRECTORIO";
            this.btnDirectorio.Text = "   DIRECTORIO";
            this.btnDirectorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 152);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(36)))), ((int)(((byte)(163)))));
            this.panel2.Controls.Add(this.lblPuesto);
            this.panel2.Controls.Add(this.pbxImagen);
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 80);
            this.panel2.TabIndex = 0;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(69, 55);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(63, 17);
            this.lblPuesto.TabIndex = 2;
            this.lblPuesto.Text = "[PUESTO]";
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxImagen.BackgroundImage")));
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxImagen.InitialImage = null;
            this.pbxImagen.Location = new System.Drawing.Point(12, 6);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(51, 66);
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(69, 31);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(51, 17);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "[AREA]";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(69, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "[NOMBRE]";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(175, 9);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(99)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(253, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(831, 76);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(54, 18);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(64, 21);
            this.lblTitleChildForm.TabIndex = 4;
            this.lblTitleChildForm.Text = "INICIO";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(99)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 3;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(697, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(742, 1);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(787, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panelDesktop.Controls.Add(this.pbxDivcrit);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelDesktop.Location = new System.Drawing.Point(253, 76);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(831, 585);
            this.panelDesktop.TabIndex = 2;
            // 
            // pbxDivcrit
            // 
            this.pbxDivcrit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxDivcrit.BackgroundImage")));
            this.pbxDivcrit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxDivcrit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDivcrit.Location = new System.Drawing.Point(0, 0);
            this.pbxDivcrit.Name = "pbxDivcrit";
            this.pbxDivcrit.Size = new System.Drawing.Size(831, 585);
            this.pbxDivcrit.TabIndex = 0;
            this.pbxDivcrit.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            //this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDivcrit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnDirectorio;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnAyuda;
        private FontAwesome.Sharp.IconButton btnAltaColab;
        private FontAwesome.Sharp.IconButton btnInventario;
        private FontAwesome.Sharp.IconButton btnGestionPyV;
        private FontAwesome.Sharp.IconButton btnPyV;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnAcercaDe;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxDivcrit;
    }
}