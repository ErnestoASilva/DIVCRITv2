
namespace DIVCRITv2
{
    partial class frmGestionColaboradoresRH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.nudDiasVacacionesPedidos = new System.Windows.Forms.NumericUpDown();
            this.tbxCorreoJefe = new System.Windows.Forms.TextBox();
            this.cbxNombreActualizar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDiaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxDiasExtra = new System.Windows.Forms.GroupBox();
            this.nudDiasExtra = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarDias = new System.Windows.Forms.Button();
            this.cbxColaboradorExtra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasVacacionesPedidos)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbxDiasExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 340);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.nudDiasVacacionesPedidos);
            this.groupBox1.Controls.Add(this.tbxCorreoJefe);
            this.groupBox1.Controls.Add(this.cbxNombreActualizar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDiaEntrada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(487, 322);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione al Colaborador para Realizar la Modificación";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(82, 266);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 40);
            this.btnLimpiar.TabIndex = 75;
            this.btnLimpiar.Text = "CANCELAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.LightGray;
            this.btnActualizar.Location = new System.Drawing.Point(255, 266);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(142, 40);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // nudDiasVacacionesPedidos
            // 
            this.nudDiasVacacionesPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudDiasVacacionesPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.nudDiasVacacionesPedidos.ForeColor = System.Drawing.Color.White;
            this.nudDiasVacacionesPedidos.Location = new System.Drawing.Point(58, 163);
            this.nudDiasVacacionesPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDiasVacacionesPedidos.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudDiasVacacionesPedidos.Name = "nudDiasVacacionesPedidos";
            this.nudDiasVacacionesPedidos.Size = new System.Drawing.Size(371, 27);
            this.nudDiasVacacionesPedidos.TabIndex = 73;
            // 
            // tbxCorreoJefe
            // 
            this.tbxCorreoJefe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxCorreoJefe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.tbxCorreoJefe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCorreoJefe.ForeColor = System.Drawing.Color.White;
            this.tbxCorreoJefe.Location = new System.Drawing.Point(58, 224);
            this.tbxCorreoJefe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCorreoJefe.MaxLength = 50;
            this.tbxCorreoJefe.Name = "tbxCorreoJefe";
            this.tbxCorreoJefe.Size = new System.Drawing.Size(372, 27);
            this.tbxCorreoJefe.TabIndex = 72;
            // 
            // cbxNombreActualizar
            // 
            this.cbxNombreActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxNombreActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.cbxNombreActualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNombreActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxNombreActualizar.ForeColor = System.Drawing.Color.White;
            this.cbxNombreActualizar.FormattingEnabled = true;
            this.cbxNombreActualizar.Location = new System.Drawing.Point(58, 53);
            this.cbxNombreActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNombreActualizar.Name = "cbxNombreActualizar";
            this.cbxNombreActualizar.Size = new System.Drawing.Size(373, 29);
            this.cbxNombreActualizar.Sorted = true;
            this.cbxNombreActualizar.TabIndex = 71;
            this.cbxNombreActualizar.SelectedIndexChanged += new System.EventHandler(this.cbxNombreActualizar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 21);
            this.label4.TabIndex = 64;
            this.label4.Text = "Dias de Vacaciones Pedidos\r\n";
            // 
            // dtpDiaEntrada
            // 
            this.dtpDiaEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDiaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDiaEntrada.Location = new System.Drawing.Point(58, 109);
            this.dtpDiaEntrada.Name = "dtpDiaEntrada";
            this.dtpDiaEntrada.Size = new System.Drawing.Size(372, 26);
            this.dtpDiaEntrada.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Día de Entrada";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "Colaborador";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(56, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 21);
            this.label14.TabIndex = 66;
            this.label14.Text = "Correo Jefe Inmediato";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.gbxDiasExtra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 221);
            this.panel2.TabIndex = 1;
            // 
            // gbxDiasExtra
            // 
            this.gbxDiasExtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDiasExtra.BackColor = System.Drawing.Color.Transparent;
            this.gbxDiasExtra.Controls.Add(this.nudDiasExtra);
            this.gbxDiasExtra.Controls.Add(this.btnAgregarDias);
            this.gbxDiasExtra.Controls.Add(this.cbxColaboradorExtra);
            this.gbxDiasExtra.Controls.Add(this.label3);
            this.gbxDiasExtra.Controls.Add(this.label2);
            this.gbxDiasExtra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDiasExtra.ForeColor = System.Drawing.Color.White;
            this.gbxDiasExtra.Location = new System.Drawing.Point(10, 8);
            this.gbxDiasExtra.Name = "gbxDiasExtra";
            this.gbxDiasExtra.Size = new System.Drawing.Size(487, 202);
            this.gbxDiasExtra.TabIndex = 55;
            this.gbxDiasExtra.TabStop = false;
            this.gbxDiasExtra.Text = "Agregar Días de Vacaciones Extra";
            // 
            // nudDiasExtra
            // 
            this.nudDiasExtra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudDiasExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(99)))));
            this.nudDiasExtra.ForeColor = System.Drawing.Color.White;
            this.nudDiasExtra.Location = new System.Drawing.Point(58, 109);
            this.nudDiasExtra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDiasExtra.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudDiasExtra.Name = "nudDiasExtra";
            this.nudDiasExtra.Size = new System.Drawing.Size(371, 27);
            this.nudDiasExtra.TabIndex = 82;
            // 
            // btnAgregarDias
            // 
            this.btnAgregarDias.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAgregarDias.FlatAppearance.BorderSize = 0;
            this.btnAgregarDias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarDias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDias.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarDias.Location = new System.Drawing.Point(165, 145);
            this.btnAgregarDias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarDias.Name = "btnAgregarDias";
            this.btnAgregarDias.Size = new System.Drawing.Size(157, 42);
            this.btnAgregarDias.TabIndex = 81;
            this.btnAgregarDias.Text = "AGREGAR DIAS";
            this.btnAgregarDias.UseVisualStyleBackColor = false;
            this.btnAgregarDias.Click += new System.EventHandler(this.btnAgregarDias_Click);
            // 
            // cbxColaboradorExtra
            // 
            this.cbxColaboradorExtra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxColaboradorExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(1)))), ((int)(((byte)(99)))));
            this.cbxColaboradorExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColaboradorExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxColaboradorExtra.ForeColor = System.Drawing.Color.White;
            this.cbxColaboradorExtra.FormattingEnabled = true;
            this.cbxColaboradorExtra.Location = new System.Drawing.Point(58, 54);
            this.cbxColaboradorExtra.Name = "cbxColaboradorExtra";
            this.cbxColaboradorExtra.Size = new System.Drawing.Size(373, 29);
            this.cbxColaboradorExtra.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Seleccione Colaborador";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cantidad de Días";
            // 
            // frmGestionColaboradoresRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionColaboradoresRH";
            this.Text = "frmGestionColaboradoresRH";
            this.Load += new System.EventHandler(this.frmGestionColaboradoresRH_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasVacacionesPedidos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbxDiasExtra.ResumeLayout(false);
            this.gbxDiasExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasExtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDiaEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbxDiasExtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNombreActualizar;
        private System.Windows.Forms.TextBox tbxCorreoJefe;
        private System.Windows.Forms.NumericUpDown nudDiasVacacionesPedidos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxColaboradorExtra;
        private System.Windows.Forms.Button btnAgregarDias;
        private System.Windows.Forms.NumericUpDown nudDiasExtra;
    }
}