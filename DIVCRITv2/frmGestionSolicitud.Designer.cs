
namespace DIVCRITv2
{
    partial class frmGestionSolicitud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.idSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstadoLista = new System.Windows.Forms.ComboBox();
            this.gbxSolicitud = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDenegar = new System.Windows.Forms.Button();
            this.rtbMotivo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstadoJefe = new System.Windows.Forms.Label();
            this.lblEstadoRH = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblDiasPedidos = new System.Windows.Forms.Label();
            this.lblTipoPermiso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNomina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.gbxSolicitud.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSol,
            this.nombreSol,
            this.fechaSol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitudes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSolicitudes.EnableHeadersVisualStyles = false;
            this.dgvSolicitudes.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 53);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.RowTemplate.Height = 23;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(349, 544);
            this.dgvSolicitudes.TabIndex = 0;
            // 
            // idSol
            // 
            this.idSol.HeaderText = "ID";
            this.idSol.Name = "idSol";
            // 
            // nombreSol
            // 
            this.nombreSol.HeaderText = "Tipo";
            this.nombreSol.Name = "nombreSol";
            // 
            // fechaSol
            // 
            this.fechaSol.HeaderText = "Fecha";
            this.fechaSol.Name = "fechaSol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por Estado:";
            // 
            // cbxEstadoLista
            // 
            this.cbxEstadoLista.BackColor = System.Drawing.SystemColors.Window;
            this.cbxEstadoLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoLista.FormattingEnabled = true;
            this.cbxEstadoLista.Items.AddRange(new object[] {
            "PENDIENTE",
            "ACEPTADO",
            "RECHAZADO"});
            this.cbxEstadoLista.Location = new System.Drawing.Point(162, 18);
            this.cbxEstadoLista.Name = "cbxEstadoLista";
            this.cbxEstadoLista.Size = new System.Drawing.Size(199, 28);
            this.cbxEstadoLista.TabIndex = 2;
            // 
            // gbxSolicitud
            // 
            this.gbxSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSolicitud.Controls.Add(this.btnAceptar);
            this.gbxSolicitud.Controls.Add(this.btnDenegar);
            this.gbxSolicitud.Controls.Add(this.rtbMotivo);
            this.gbxSolicitud.Controls.Add(this.label3);
            this.gbxSolicitud.Controls.Add(this.label2);
            this.gbxSolicitud.Controls.Add(this.lblEstadoJefe);
            this.gbxSolicitud.Controls.Add(this.lblEstadoRH);
            this.gbxSolicitud.Controls.Add(this.lblMotivo);
            this.gbxSolicitud.Controls.Add(this.lblFechaFinal);
            this.gbxSolicitud.Controls.Add(this.lblFechaInicio);
            this.gbxSolicitud.Controls.Add(this.lblDiasPedidos);
            this.gbxSolicitud.Controls.Add(this.lblTipoPermiso);
            this.gbxSolicitud.Controls.Add(this.lblNombre);
            this.gbxSolicitud.Controls.Add(this.lblNomina);
            this.gbxSolicitud.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSolicitud.ForeColor = System.Drawing.SystemColors.Window;
            this.gbxSolicitud.Location = new System.Drawing.Point(367, 12);
            this.gbxSolicitud.Name = "gbxSolicitud";
            this.gbxSolicitud.Size = new System.Drawing.Size(428, 585);
            this.gbxSolicitud.TabIndex = 3;
            this.gbxSolicitud.TabStop = false;
            this.gbxSolicitud.Text = "Solicitud";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(223, 522);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 38);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // btnDenegar
            // 
            this.btnDenegar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDenegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDenegar.FlatAppearance.BorderSize = 0;
            this.btnDenegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenegar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDenegar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDenegar.Location = new System.Drawing.Point(80, 522);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.Size = new System.Drawing.Size(126, 38);
            this.btnDenegar.TabIndex = 2;
            this.btnDenegar.Text = "Rechazar";
            this.btnDenegar.UseVisualStyleBackColor = false;
            // 
            // rtbMotivo
            // 
            this.rtbMotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rtbMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMotivo.Enabled = false;
            this.rtbMotivo.Location = new System.Drawing.Point(6, 288);
            this.rtbMotivo.Name = "rtbMotivo";
            this.rtbMotivo.Size = new System.Drawing.Size(416, 96);
            this.rtbMotivo.TabIndex = 1;
            this.rtbMotivo.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estado de Solicitud a Jefe Directo:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado de Solicitud a Recursos Humanos:";
            // 
            // lblEstadoJefe
            // 
            this.lblEstadoJefe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoJefe.AutoSize = true;
            this.lblEstadoJefe.Location = new System.Drawing.Point(6, 481);
            this.lblEstadoJefe.Name = "lblEstadoJefe";
            this.lblEstadoJefe.Size = new System.Drawing.Size(77, 21);
            this.lblEstadoJefe.TabIndex = 0;
            this.lblEstadoJefe.Text = "[estado]";
            // 
            // lblEstadoRH
            // 
            this.lblEstadoRH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoRH.AutoSize = true;
            this.lblEstadoRH.Location = new System.Drawing.Point(6, 426);
            this.lblEstadoRH.Name = "lblEstadoRH";
            this.lblEstadoRH.Size = new System.Drawing.Size(77, 21);
            this.lblEstadoRH.TabIndex = 0;
            this.lblEstadoRH.Text = "[estado]";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(6, 264);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(69, 21);
            this.lblMotivo.TabIndex = 0;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(6, 226);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(102, 21);
            this.lblFechaFinal.TabIndex = 0;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 188);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(112, 21);
            this.lblFechaInicio.TabIndex = 0;
            this.lblFechaInicio.Text = "Fecha Inicial:";
            // 
            // lblDiasPedidos
            // 
            this.lblDiasPedidos.AutoSize = true;
            this.lblDiasPedidos.Location = new System.Drawing.Point(6, 150);
            this.lblDiasPedidos.Name = "lblDiasPedidos";
            this.lblDiasPedidos.Size = new System.Drawing.Size(110, 21);
            this.lblDiasPedidos.TabIndex = 0;
            this.lblDiasPedidos.Text = "Días Pedidos:";
            // 
            // lblTipoPermiso
            // 
            this.lblTipoPermiso.AutoSize = true;
            this.lblTipoPermiso.Location = new System.Drawing.Point(6, 112);
            this.lblTipoPermiso.Name = "lblTipoPermiso";
            this.lblTipoPermiso.Size = new System.Drawing.Size(133, 21);
            this.lblTipoPermiso.TabIndex = 0;
            this.lblTipoPermiso.Text = "Tipo de Permiso:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.Location = new System.Drawing.Point(6, 36);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(75, 21);
            this.lblNomina.TabIndex = 0;
            this.lblNomina.Text = "Nómina:";
            // 
            // frmGestionSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(807, 609);
            this.Controls.Add(this.cbxEstadoLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxSolicitud);
            this.Controls.Add(this.dgvSolicitudes);
            this.Name = "frmGestionSolicitud";
            this.Text = "frmGestionSolicitud";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.gbxSolicitud.ResumeLayout(false);
            this.gbxSolicitud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstadoLista;
        private System.Windows.Forms.GroupBox gbxSolicitud;
        private System.Windows.Forms.RichTextBox rtbMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblDiasPedidos;
        private System.Windows.Forms.Label lblTipoPermiso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstadoRH;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnDenegar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstadoJefe;
    }
}