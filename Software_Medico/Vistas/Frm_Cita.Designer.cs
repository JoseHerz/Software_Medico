namespace Software_Medico.Vistas
{
    partial class Frm_Cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cita));
            this.Pnl_Formulario = new System.Windows.Forms.Panel();
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Pnl_Barra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Usuario = new System.Windows.Forms.Button();
            this.Btn_Cita = new System.Windows.Forms.Button();
            this.Btn_Facturacion = new System.Windows.Forms.Button();
            this.Btn_Inventario = new System.Windows.Forms.Button();
            this.Btn_Examenes = new System.Windows.Forms.Button();
            this.Btn_Paciente = new System.Windows.Forms.Button();
            this.Btn_Doctores = new System.Windows.Forms.Button();
            this.Btn_Enfermedades = new System.Windows.Forms.Button();
            this.Ptb_Max = new System.Windows.Forms.PictureBox();
            this.Ptb_Min = new System.Windows.Forms.PictureBox();
            this.Ptb_Cerrar = new System.Windows.Forms.PictureBox();
            this.Ptb_Resize = new System.Windows.Forms.PictureBox();
            this.Dtp_Mostrar = new System.Windows.Forms.DataGridView();
            this.Dtp_Filtroa = new System.Windows.Forms.DateTimePicker();
            this.Dtp_filtrof = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Formulario.SuspendLayout();
            this.Pnl_Menu.SuspendLayout();
            this.Pnl_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Formulario
            // 
            this.Pnl_Formulario.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_Formulario.Controls.Add(this.label2);
            this.Pnl_Formulario.Controls.Add(this.Dtp_filtrof);
            this.Pnl_Formulario.Controls.Add(this.Dtp_Mostrar);
            this.Pnl_Formulario.Controls.Add(this.Dtp_Filtroa);
            this.Pnl_Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Formulario.Location = new System.Drawing.Point(101, 39);
            this.Pnl_Formulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Formulario.Name = "Pnl_Formulario";
            this.Pnl_Formulario.Size = new System.Drawing.Size(998, 660);
            this.Pnl_Formulario.TabIndex = 23;
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Pnl_Menu.Controls.Add(this.Btn_Usuario);
            this.Pnl_Menu.Controls.Add(this.Btn_Cita);
            this.Pnl_Menu.Controls.Add(this.Btn_Facturacion);
            this.Pnl_Menu.Controls.Add(this.Btn_Inventario);
            this.Pnl_Menu.Controls.Add(this.Btn_Examenes);
            this.Pnl_Menu.Controls.Add(this.Btn_Paciente);
            this.Pnl_Menu.Controls.Add(this.Btn_Doctores);
            this.Pnl_Menu.Controls.Add(this.Btn_Enfermedades);
            this.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 39);
            this.Pnl_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(101, 660);
            this.Pnl_Menu.TabIndex = 22;
            // 
            // Pnl_Barra
            // 
            this.Pnl_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Pnl_Barra.Controls.Add(this.Ptb_Max);
            this.Pnl_Barra.Controls.Add(this.Ptb_Min);
            this.Pnl_Barra.Controls.Add(this.Ptb_Cerrar);
            this.Pnl_Barra.Controls.Add(this.label1);
            this.Pnl_Barra.Controls.Add(this.Ptb_Resize);
            this.Pnl_Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Barra.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Barra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Barra.Name = "Pnl_Barra";
            this.Pnl_Barra.Size = new System.Drawing.Size(1099, 39);
            this.Pnl_Barra.TabIndex = 21;
            this.Pnl_Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseDown);
            this.Pnl_Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseMove);
            this.Pnl_Barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita";
            // 
            // Btn_Usuario
            // 
            this.Btn_Usuario.FlatAppearance.BorderSize = 0;
            this.Btn_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Usuario.Image = global::Software_Medico.Properties.Resources.programador1;
            this.Btn_Usuario.Location = new System.Drawing.Point(21, 572);
            this.Btn_Usuario.Name = "Btn_Usuario";
            this.Btn_Usuario.Size = new System.Drawing.Size(57, 74);
            this.Btn_Usuario.TabIndex = 19;
            this.Btn_Usuario.UseVisualStyleBackColor = true;
            this.Btn_Usuario.Click += new System.EventHandler(this.Btn_Usuario_Click);
            // 
            // Btn_Cita
            // 
            this.Btn_Cita.FlatAppearance.BorderSize = 0;
            this.Btn_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cita.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Cita.Image = global::Software_Medico.Properties.Resources.cita;
            this.Btn_Cita.Location = new System.Drawing.Point(12, 500);
            this.Btn_Cita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cita.Name = "Btn_Cita";
            this.Btn_Cita.Size = new System.Drawing.Size(73, 70);
            this.Btn_Cita.TabIndex = 6;
            this.Btn_Cita.UseVisualStyleBackColor = true;
            // 
            // Btn_Facturacion
            // 
            this.Btn_Facturacion.FlatAppearance.BorderSize = 0;
            this.Btn_Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Facturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Facturacion.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Facturacion.Image = global::Software_Medico.Properties.Resources.cuenta;
            this.Btn_Facturacion.Location = new System.Drawing.Point(12, 423);
            this.Btn_Facturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Facturacion.Name = "Btn_Facturacion";
            this.Btn_Facturacion.Size = new System.Drawing.Size(73, 70);
            this.Btn_Facturacion.TabIndex = 5;
            this.Btn_Facturacion.UseVisualStyleBackColor = true;
            this.Btn_Facturacion.Click += new System.EventHandler(this.Btn_Facturacion_Click);
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.FlatAppearance.BorderSize = 0;
            this.Btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Inventario.Image = global::Software_Medico.Properties.Resources.inventario;
            this.Btn_Inventario.Location = new System.Drawing.Point(12, 348);
            this.Btn_Inventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(73, 70);
            this.Btn_Inventario.TabIndex = 4;
            this.Btn_Inventario.UseVisualStyleBackColor = true;
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // Btn_Examenes
            // 
            this.Btn_Examenes.FlatAppearance.BorderSize = 0;
            this.Btn_Examenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Examenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Examenes.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Examenes.Image = global::Software_Medico.Properties.Resources.estetoscopio__1_;
            this.Btn_Examenes.Location = new System.Drawing.Point(12, 272);
            this.Btn_Examenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Examenes.Name = "Btn_Examenes";
            this.Btn_Examenes.Size = new System.Drawing.Size(73, 70);
            this.Btn_Examenes.TabIndex = 3;
            this.Btn_Examenes.UseVisualStyleBackColor = true;
            this.Btn_Examenes.Click += new System.EventHandler(this.Btn_Examenes_Click);
            // 
            // Btn_Paciente
            // 
            this.Btn_Paciente.FlatAppearance.BorderSize = 0;
            this.Btn_Paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Paciente.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Paciente.Image = global::Software_Medico.Properties.Resources.paciente;
            this.Btn_Paciente.Location = new System.Drawing.Point(12, 190);
            this.Btn_Paciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Paciente.Name = "Btn_Paciente";
            this.Btn_Paciente.Size = new System.Drawing.Size(73, 76);
            this.Btn_Paciente.TabIndex = 2;
            this.Btn_Paciente.UseVisualStyleBackColor = true;
            this.Btn_Paciente.Click += new System.EventHandler(this.Btn_Paciente_Click);
            // 
            // Btn_Doctores
            // 
            this.Btn_Doctores.FlatAppearance.BorderSize = 0;
            this.Btn_Doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Doctores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Doctores.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Doctores.Image = global::Software_Medico.Properties.Resources.doctor;
            this.Btn_Doctores.Location = new System.Drawing.Point(17, 111);
            this.Btn_Doctores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Doctores.Name = "Btn_Doctores";
            this.Btn_Doctores.Size = new System.Drawing.Size(68, 73);
            this.Btn_Doctores.TabIndex = 1;
            this.Btn_Doctores.UseVisualStyleBackColor = true;
            this.Btn_Doctores.Click += new System.EventHandler(this.Btn_Doctores_Click);
            // 
            // Btn_Enfermedades
            // 
            this.Btn_Enfermedades.FlatAppearance.BorderSize = 0;
            this.Btn_Enfermedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Enfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Enfermedades.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Enfermedades.Image = global::Software_Medico.Properties.Resources.prevencion;
            this.Btn_Enfermedades.Location = new System.Drawing.Point(12, 31);
            this.Btn_Enfermedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Enfermedades.Name = "Btn_Enfermedades";
            this.Btn_Enfermedades.Size = new System.Drawing.Size(73, 74);
            this.Btn_Enfermedades.TabIndex = 0;
            this.Btn_Enfermedades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Enfermedades.UseVisualStyleBackColor = true;
            this.Btn_Enfermedades.Click += new System.EventHandler(this.Btn_Enfermedades_Click);
            // 
            // Ptb_Max
            // 
            this.Ptb_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Max.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Max.Image = global::Software_Medico.Properties.Resources.maximizar__1_;
            this.Ptb_Max.Location = new System.Drawing.Point(986, 2);
            this.Ptb_Max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ptb_Max.Name = "Ptb_Max";
            this.Ptb_Max.Size = new System.Drawing.Size(45, 39);
            this.Ptb_Max.TabIndex = 3;
            this.Ptb_Max.TabStop = false;
            this.Ptb_Max.Click += new System.EventHandler(this.Ptb_Max_Click);
            // 
            // Ptb_Min
            // 
            this.Ptb_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Min.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Min.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Min.Image")));
            this.Ptb_Min.Location = new System.Drawing.Point(935, 2);
            this.Ptb_Min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ptb_Min.Name = "Ptb_Min";
            this.Ptb_Min.Size = new System.Drawing.Size(45, 39);
            this.Ptb_Min.TabIndex = 2;
            this.Ptb_Min.TabStop = false;
            this.Ptb_Min.Click += new System.EventHandler(this.Ptb_Min_Click);
            // 
            // Ptb_Cerrar
            // 
            this.Ptb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Ptb_Cerrar.Image")));
            this.Ptb_Cerrar.Location = new System.Drawing.Point(1037, 2);
            this.Ptb_Cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ptb_Cerrar.Name = "Ptb_Cerrar";
            this.Ptb_Cerrar.Size = new System.Drawing.Size(45, 39);
            this.Ptb_Cerrar.TabIndex = 1;
            this.Ptb_Cerrar.TabStop = false;
            this.Ptb_Cerrar.Click += new System.EventHandler(this.Ptb_Cerrar_Click);
            // 
            // Ptb_Resize
            // 
            this.Ptb_Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Resize.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Resize.Image = global::Software_Medico.Properties.Resources.minimizar__1___1_;
            this.Ptb_Resize.Location = new System.Drawing.Point(986, 2);
            this.Ptb_Resize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ptb_Resize.Name = "Ptb_Resize";
            this.Ptb_Resize.Size = new System.Drawing.Size(45, 39);
            this.Ptb_Resize.TabIndex = 4;
            this.Ptb_Resize.TabStop = false;
            this.Ptb_Resize.Click += new System.EventHandler(this.Ptb_Resize_Click);
            // 
            // Dtp_Mostrar
            // 
            this.Dtp_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtp_Mostrar.Location = new System.Drawing.Point(19, 145);
            this.Dtp_Mostrar.Name = "Dtp_Mostrar";
            this.Dtp_Mostrar.RowHeadersWidth = 51;
            this.Dtp_Mostrar.RowTemplate.Height = 24;
            this.Dtp_Mostrar.Size = new System.Drawing.Size(958, 496);
            this.Dtp_Mostrar.TabIndex = 26;
            // 
            // Dtp_Filtroa
            // 
            this.Dtp_Filtroa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Filtroa.Location = new System.Drawing.Point(40, 71);
            this.Dtp_Filtroa.Name = "Dtp_Filtroa";
            this.Dtp_Filtroa.Size = new System.Drawing.Size(430, 34);
            this.Dtp_Filtroa.TabIndex = 25;
            // 
            // Dtp_filtrof
            // 
            this.Dtp_filtrof.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_filtrof.Location = new System.Drawing.Point(514, 71);
            this.Dtp_filtrof.Name = "Dtp_filtrof";
            this.Dtp_filtrof.Size = new System.Drawing.Size(430, 34);
            this.Dtp_filtrof.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Filtrar:";
            // 
            // Frm_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 699);
            this.Controls.Add(this.Pnl_Formulario);
            this.Controls.Add(this.Pnl_Menu);
            this.Controls.Add(this.Pnl_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cita";
            this.Text = "Frm_Cita";
            this.Pnl_Formulario.ResumeLayout(false);
            this.Pnl_Formulario.PerformLayout();
            this.Pnl_Menu.ResumeLayout(false);
            this.Pnl_Barra.ResumeLayout(false);
            this.Pnl_Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Mostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Formulario;
        private System.Windows.Forms.Panel Pnl_Menu;
        private System.Windows.Forms.Button Btn_Usuario;
        private System.Windows.Forms.Button Btn_Cita;
        private System.Windows.Forms.Button Btn_Facturacion;
        private System.Windows.Forms.Button Btn_Inventario;
        private System.Windows.Forms.Button Btn_Examenes;
        private System.Windows.Forms.Button Btn_Paciente;
        private System.Windows.Forms.Button Btn_Doctores;
        private System.Windows.Forms.Button Btn_Enfermedades;
        private System.Windows.Forms.Panel Pnl_Barra;
        private System.Windows.Forms.PictureBox Ptb_Max;
        private System.Windows.Forms.PictureBox Ptb_Min;
        private System.Windows.Forms.PictureBox Ptb_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Ptb_Resize;
        private System.Windows.Forms.DateTimePicker Dtp_filtrof;
        private System.Windows.Forms.DataGridView Dtp_Mostrar;
        private System.Windows.Forms.DateTimePicker Dtp_Filtroa;
        private System.Windows.Forms.Label label2;
    }
}