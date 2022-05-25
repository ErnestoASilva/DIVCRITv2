
namespace DIVCRITv2
{
    partial class frmInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.cbxCampos = new System.Windows.Forms.ComboBox();
            this.tbxCampos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAsteriscoTipoProd = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAsteriscoMarProd = new System.Windows.Forms.Label();
            this.lblAsteriscoColaborador = new System.Windows.Forms.Label();
            this.lblAsteriscoNomProd = new System.Windows.Forms.Label();
            this.lblAsteriscoNoOficina = new System.Windows.Forms.Label();
            this.lblAsteriscoNoSerie = new System.Windows.Forms.Label();
            this.lblAsteriscoAreaOficina = new System.Windows.Forms.Label();
            this.cbxColaborador = new System.Windows.Forms.ComboBox();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tbxNoSerie = new System.Windows.Forms.TextBox();
            this.tbxNoOficina = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInventario.Location = new System.Drawing.Point(16, 117);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(851, 639);
            this.dgvInventario.TabIndex = 0;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            // 
            // cbxCampos
            // 
            this.cbxCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.cbxCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCampos.ForeColor = System.Drawing.Color.LightGray;
            this.cbxCampos.FormattingEnabled = true;
            this.cbxCampos.Items.AddRange(new object[] {
            "Número Oficina",
            "Área Oficina",
            "Colaborador",
            "Tipo Producto",
            "Número Serie",
            "Nombre Producto",
            "Marca Producto"});
            this.cbxCampos.Location = new System.Drawing.Point(8, 31);
            this.cbxCampos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCampos.Name = "cbxCampos";
            this.cbxCampos.Size = new System.Drawing.Size(329, 31);
            this.cbxCampos.TabIndex = 2;
            this.cbxCampos.SelectedIndexChanged += new System.EventHandler(this.cbxCampos_SelectedIndexChanged);
            // 
            // tbxCampos
            // 
            this.tbxCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCampos.ForeColor = System.Drawing.Color.LightGray;
            this.tbxCampos.Location = new System.Drawing.Point(347, 31);
            this.tbxCampos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCampos.MaxLength = 50;
            this.tbxCampos.Name = "tbxCampos";
            this.tbxCampos.Size = new System.Drawing.Size(423, 32);
            this.tbxCampos.TabIndex = 3;
            this.tbxCampos.TextChanged += new System.EventHandler(this.tbxCampos_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblAsteriscoTipoProd);
            this.groupBox1.Controls.Add(this.cbxTipo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAsteriscoMarProd);
            this.groupBox1.Controls.Add(this.lblAsteriscoColaborador);
            this.groupBox1.Controls.Add(this.lblAsteriscoNomProd);
            this.groupBox1.Controls.Add(this.lblAsteriscoNoOficina);
            this.groupBox1.Controls.Add(this.lblAsteriscoNoSerie);
            this.groupBox1.Controls.Add(this.lblAsteriscoAreaOficina);
            this.groupBox1.Controls.Add(this.cbxColaborador);
            this.groupBox1.Controls.Add(this.cbxArea);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.tbxNoSerie);
            this.groupBox1.Controls.Add(this.tbxNoOficina);
            this.groupBox1.Controls.Add(this.tbxNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxMarca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(875, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 741);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblAsteriscoTipoProd
            // 
            this.lblAsteriscoTipoProd.AutoSize = true;
            this.lblAsteriscoTipoProd.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoTipoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoTipoProd.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoTipoProd.Location = new System.Drawing.Point(56, 218);
            this.lblAsteriscoTipoProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsteriscoTipoProd.Name = "lblAsteriscoTipoProd";
            this.lblAsteriscoTipoProd.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoTipoProd.TabIndex = 84;
            this.lblAsteriscoTipoProd.Text = "*";
            // 
            // cbxTipo
            // 
            this.cbxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbxTipo.ForeColor = System.Drawing.Color.LightGray;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "COMPUTADORA",
            "MONITOR",
            "MOUSE",
            "IMPRESORA",
            "TECLADO",
            "MODEM"});
            this.cbxTipo.Location = new System.Drawing.Point(9, 244);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(355, 29);
            this.cbxTipo.TabIndex = 83;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(8, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 82;
            this.label5.Text = "Tipo";
            // 
            // lblAsteriscoMarProd
            // 
            this.lblAsteriscoMarProd.AutoSize = true;
            this.lblAsteriscoMarProd.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoMarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoMarProd.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoMarProd.Location = new System.Drawing.Point(79, 154);
            this.lblAsteriscoMarProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsteriscoMarProd.Name = "lblAsteriscoMarProd";
            this.lblAsteriscoMarProd.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoMarProd.TabIndex = 81;
            this.lblAsteriscoMarProd.Text = "*";
            // 
            // lblAsteriscoColaborador
            // 
            this.lblAsteriscoColaborador.AutoSize = true;
            this.lblAsteriscoColaborador.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoColaborador.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoColaborador.Location = new System.Drawing.Point(135, 279);
            this.lblAsteriscoColaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsteriscoColaborador.Name = "lblAsteriscoColaborador";
            this.lblAsteriscoColaborador.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoColaborador.TabIndex = 81;
            this.lblAsteriscoColaborador.Text = "*";
            // 
            // lblAsteriscoNomProd
            // 
            this.lblAsteriscoNomProd.AutoSize = true;
            this.lblAsteriscoNomProd.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoNomProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNomProd.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoNomProd.Location = new System.Drawing.Point(92, 92);
            this.lblAsteriscoNomProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsteriscoNomProd.Name = "lblAsteriscoNomProd";
            this.lblAsteriscoNomProd.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoNomProd.TabIndex = 81;
            this.lblAsteriscoNomProd.Text = "*";
            // 
            // lblAsteriscoNoOficina
            // 
            this.lblAsteriscoNoOficina.AutoSize = true;
            this.lblAsteriscoNoOficina.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoNoOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNoOficina.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoNoOficina.Location = new System.Drawing.Point(119, 409);
            this.lblAsteriscoNoOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsteriscoNoOficina.Name = "lblAsteriscoNoOficina";
            this.lblAsteriscoNoOficina.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoNoOficina.TabIndex = 81;
            this.lblAsteriscoNoOficina.Text = "*";
            // 
            // lblAsteriscoNoSerie
            // 
            this.lblAsteriscoNoSerie.AutoSize = true;
            this.lblAsteriscoNoSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoNoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNoSerie.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoNoSerie.Location = new System.Drawing.Point(92, 28);
            this.lblAsteriscoNoSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsteriscoNoSerie.Name = "lblAsteriscoNoSerie";
            this.lblAsteriscoNoSerie.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoNoSerie.TabIndex = 81;
            this.lblAsteriscoNoSerie.Text = "*";
            // 
            // lblAsteriscoAreaOficina
            // 
            this.lblAsteriscoAreaOficina.AutoSize = true;
            this.lblAsteriscoAreaOficina.BackColor = System.Drawing.Color.Transparent;
            this.lblAsteriscoAreaOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoAreaOficina.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoAreaOficina.Location = new System.Drawing.Point(61, 342);
            this.lblAsteriscoAreaOficina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsteriscoAreaOficina.Name = "lblAsteriscoAreaOficina";
            this.lblAsteriscoAreaOficina.Size = new System.Drawing.Size(20, 25);
            this.lblAsteriscoAreaOficina.TabIndex = 81;
            this.lblAsteriscoAreaOficina.Text = "*";
            // 
            // cbxColaborador
            // 
            this.cbxColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.cbxColaborador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxColaborador.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbxColaborador.ForeColor = System.Drawing.Color.LightGray;
            this.cbxColaborador.FormattingEnabled = true;
            this.cbxColaborador.Location = new System.Drawing.Point(9, 308);
            this.cbxColaborador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxColaborador.Name = "cbxColaborador";
            this.cbxColaborador.Size = new System.Drawing.Size(355, 29);
            this.cbxColaborador.TabIndex = 20;
            this.cbxColaborador.SelectedIndexChanged += new System.EventHandler(this.cbxColaborador_SelectedIndexChanged);
            this.cbxColaborador.TextChanged += new System.EventHandler(this.cbxColaborador_TextChanged);
            // 
            // cbxArea
            // 
            this.cbxArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.cbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxArea.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbxArea.ForeColor = System.Drawing.Color.LightGray;
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Location = new System.Drawing.Point(9, 372);
            this.cbxArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(355, 29);
            this.cbxArea.TabIndex = 4;
            this.cbxArea.SelectedIndexChanged += new System.EventHandler(this.cbxArea_SelectedIndexChanged);
            this.cbxArea.TextChanged += new System.EventHandler(this.cbxArea_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(8, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "No. Serie";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(117, 511);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 59);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(8, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(117, 658);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 59);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(8, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Marca";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnActualizar.Location = new System.Drawing.Point(117, 585);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 59);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tbxNoSerie
            // 
            this.tbxNoSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxNoSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNoSerie.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbxNoSerie.ForeColor = System.Drawing.Color.LightGray;
            this.tbxNoSerie.Location = new System.Drawing.Point(9, 55);
            this.tbxNoSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNoSerie.MaxLength = 50;
            this.tbxNoSerie.Name = "tbxNoSerie";
            this.tbxNoSerie.Size = new System.Drawing.Size(355, 28);
            this.tbxNoSerie.TabIndex = 13;
            this.tbxNoSerie.TextChanged += new System.EventHandler(this.cbxNoSerie_TextChanged);
            // 
            // tbxNoOficina
            // 
            this.tbxNoOficina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxNoOficina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNoOficina.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbxNoOficina.ForeColor = System.Drawing.Color.LightGray;
            this.tbxNoOficina.Location = new System.Drawing.Point(9, 436);
            this.tbxNoOficina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNoOficina.MaxLength = 50;
            this.tbxNoOficina.Name = "tbxNoOficina";
            this.tbxNoOficina.Size = new System.Drawing.Size(355, 28);
            this.tbxNoOficina.TabIndex = 10;
            this.tbxNoOficina.TextChanged += new System.EventHandler(this.tbxNoOficina_TextChanged);
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbxNombre.ForeColor = System.Drawing.Color.LightGray;
            this.tbxNombre.Location = new System.Drawing.Point(9, 118);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNombre.MaxLength = 50;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(355, 28);
            this.tbxNombre.TabIndex = 14;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(8, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Colaborador";
            // 
            // tbxMarca
            // 
            this.tbxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMarca.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbxMarca.ForeColor = System.Drawing.Color.LightGray;
            this.tbxMarca.Location = new System.Drawing.Point(9, 181);
            this.tbxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMarca.MaxLength = 50;
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.Size = new System.Drawing.Size(355, 28);
            this.tbxMarca.TabIndex = 15;
            this.tbxMarca.TextChanged += new System.EventHandler(this.tbxMarca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(8, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(8, 409);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "No. Oficina";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbxCampos);
            this.groupBox2.Controls.Add(this.tbxCampos);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(851, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por campo";
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1261, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventario";
            this.Text = "frmInventario";
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.ComboBox cbxCampos;
        private System.Windows.Forms.TextBox tbxCampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxNoSerie;
        private System.Windows.Forms.TextBox tbxNoOficina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.ComboBox cbxColaborador;
        private System.Windows.Forms.Label lblAsteriscoMarProd;
        private System.Windows.Forms.Label lblAsteriscoNomProd;
        private System.Windows.Forms.Label lblAsteriscoNoSerie;
        private System.Windows.Forms.Label lblAsteriscoColaborador;
        private System.Windows.Forms.Label lblAsteriscoNoOficina;
        private System.Windows.Forms.Label lblAsteriscoAreaOficina;
        private System.Windows.Forms.Label lblAsteriscoTipoProd;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label5;
    }
}