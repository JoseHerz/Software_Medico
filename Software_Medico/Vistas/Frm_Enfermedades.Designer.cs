﻿namespace Software_Medico.Vistas
{
    public partial class Frm_Enfermedades
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
            this.Pnl_Formulario = new System.Windows.Forms.Panel();
            this.Dtg_Base = new System.Windows.Forms.DataGridView();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Btn_Cita = new System.Windows.Forms.Button();
            this.Btn_Facturacion = new System.Windows.Forms.Button();
            this.Btn_Inventario = new System.Windows.Forms.Button();
            this.Btn_Examenes = new System.Windows.Forms.Button();
            this.Btn_Paciente = new System.Windows.Forms.Button();
            this.Btn_Doctores = new System.Windows.Forms.Button();
            this.Btn_Enfermedades = new System.Windows.Forms.Button();
            this.Pnl_Barra = new System.Windows.Forms.Panel();
            this.Ptb_Max = new System.Windows.Forms.PictureBox();
            this.Ptb_Min = new System.Windows.Forms.PictureBox();
            this.Ptb_Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ptb_Resize = new System.Windows.Forms.PictureBox();
            this.Pnl_Formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Base)).BeginInit();
            this.Pnl_Menu.SuspendLayout();
            this.Pnl_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Resize)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Formulario
            // 
            this.Pnl_Formulario.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_Formulario.Controls.Add(this.Dtg_Base);
            this.Pnl_Formulario.Controls.Add(this.Btn_Agregar);
            this.Pnl_Formulario.Controls.Add(this.Btn_Buscar);
            this.Pnl_Formulario.Controls.Add(this.Txt_buscar);
            this.Pnl_Formulario.Controls.Add(this.Pnl_Menu);
            this.Pnl_Formulario.Controls.Add(this.Pnl_Barra);
            this.Pnl_Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Formulario.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Formulario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Formulario.Name = "Pnl_Formulario";
            this.Pnl_Formulario.Size = new System.Drawing.Size(900, 578);
            this.Pnl_Formulario.TabIndex = 11;
            // 
            // Dtg_Base
            // 
            this.Dtg_Base.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Base.Location = new System.Drawing.Point(119, 187);
            this.Dtg_Base.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtg_Base.Name = "Dtg_Base";
            this.Dtg_Base.RowHeadersWidth = 51;
            this.Dtg_Base.RowTemplate.Height = 24;
            this.Dtg_Base.Size = new System.Drawing.Size(744, 309);
            this.Dtg_Base.TabIndex = 19;
            this.Dtg_Base.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Base_CellContentClick);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Agregar.Location = new System.Drawing.Point(706, 84);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(104, 60);
            this.Btn_Agregar.TabIndex = 18;
            this.Btn_Agregar.Text = "Agregar Patologia";
            this.Btn_Agregar.UseVisualStyleBackColor = false;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Buscar.Location = new System.Drawing.Point(602, 93);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(91, 41);
            this.Btn_Buscar.TabIndex = 17;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.Location = new System.Drawing.Point(179, 101);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(408, 28);
            this.Txt_buscar.TabIndex = 16;
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Pnl_Menu.Controls.Add(this.Btn_Cita);
            this.Pnl_Menu.Controls.Add(this.Btn_Facturacion);
            this.Pnl_Menu.Controls.Add(this.Btn_Inventario);
            this.Pnl_Menu.Controls.Add(this.Btn_Examenes);
            this.Pnl_Menu.Controls.Add(this.Btn_Paciente);
            this.Pnl_Menu.Controls.Add(this.Btn_Doctores);
            this.Pnl_Menu.Controls.Add(this.Btn_Enfermedades);
            this.Pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Menu.Location = new System.Drawing.Point(0, 32);
            this.Pnl_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(76, 546);
            this.Pnl_Menu.TabIndex = 14;
            // 
            // Btn_Cita
            // 
            this.Btn_Cita.FlatAppearance.BorderSize = 0;
            this.Btn_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cita.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Cita.Image = global::Software_Medico.Properties.Resources.cita;
            this.Btn_Cita.Location = new System.Drawing.Point(9, 406);
            this.Btn_Cita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cita.Name = "Btn_Cita";
            this.Btn_Cita.Size = new System.Drawing.Size(55, 57);
            this.Btn_Cita.TabIndex = 6;
            this.Btn_Cita.UseVisualStyleBackColor = true;
            this.Btn_Cita.Click += new System.EventHandler(this.Btn_Cita_Click);
            // 
            // Btn_Facturacion
            // 
            this.Btn_Facturacion.FlatAppearance.BorderSize = 0;
            this.Btn_Facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Facturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Facturacion.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Facturacion.Image = global::Software_Medico.Properties.Resources.cuenta;
            this.Btn_Facturacion.Location = new System.Drawing.Point(9, 344);
            this.Btn_Facturacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Facturacion.Name = "Btn_Facturacion";
            this.Btn_Facturacion.Size = new System.Drawing.Size(55, 57);
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
            this.Btn_Inventario.Location = new System.Drawing.Point(9, 283);
            this.Btn_Inventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Size = new System.Drawing.Size(55, 57);
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
            this.Btn_Examenes.Location = new System.Drawing.Point(9, 221);
            this.Btn_Examenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Examenes.Name = "Btn_Examenes";
            this.Btn_Examenes.Size = new System.Drawing.Size(55, 57);
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
            this.Btn_Paciente.Location = new System.Drawing.Point(9, 154);
            this.Btn_Paciente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Paciente.Name = "Btn_Paciente";
            this.Btn_Paciente.Size = new System.Drawing.Size(55, 62);
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
            this.Btn_Doctores.Location = new System.Drawing.Point(13, 90);
            this.Btn_Doctores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Doctores.Name = "Btn_Doctores";
            this.Btn_Doctores.Size = new System.Drawing.Size(51, 59);
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
            this.Btn_Enfermedades.Location = new System.Drawing.Point(9, 25);
            this.Btn_Enfermedades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Enfermedades.Name = "Btn_Enfermedades";
            this.Btn_Enfermedades.Size = new System.Drawing.Size(55, 60);
            this.Btn_Enfermedades.TabIndex = 0;
            this.Btn_Enfermedades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Enfermedades.UseVisualStyleBackColor = true;
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
            this.Pnl_Barra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Barra.Name = "Pnl_Barra";
            this.Pnl_Barra.Size = new System.Drawing.Size(900, 32);
            this.Pnl_Barra.TabIndex = 13;
            this.Pnl_Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseDown);
            this.Pnl_Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseMove);
            this.Pnl_Barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseUp);
            // 
            // Ptb_Max
            // 
            this.Ptb_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Max.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Max.Image = global::Software_Medico.Properties.Resources.maximizar__1_;
            this.Ptb_Max.Location = new System.Drawing.Point(830, 2);
            this.Ptb_Max.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ptb_Max.Name = "Ptb_Max";
            this.Ptb_Max.Size = new System.Drawing.Size(34, 32);
            this.Ptb_Max.TabIndex = 3;
            this.Ptb_Max.TabStop = false;
            this.Ptb_Max.Click += new System.EventHandler(this.Ptb_Max_Click);
            // 
            // Ptb_Min
            // 
            this.Ptb_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Min.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Min.Image = global::Software_Medico.Properties.Resources.minimizar__3___1_;
            this.Ptb_Min.Location = new System.Drawing.Point(791, 2);
            this.Ptb_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ptb_Min.Name = "Ptb_Min";
            this.Ptb_Min.Size = new System.Drawing.Size(34, 32);
            this.Ptb_Min.TabIndex = 2;
            this.Ptb_Min.TabStop = false;
            this.Ptb_Min.Click += new System.EventHandler(this.Ptb_Min_Click);
            // 
            // Ptb_Cerrar
            // 
            this.Ptb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Cerrar.Image = global::Software_Medico.Properties.Resources.cerrar_sesion__1_;
            this.Ptb_Cerrar.Location = new System.Drawing.Point(868, 2);
            this.Ptb_Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ptb_Cerrar.Name = "Ptb_Cerrar";
            this.Ptb_Cerrar.Size = new System.Drawing.Size(34, 32);
            this.Ptb_Cerrar.TabIndex = 1;
            this.Ptb_Cerrar.TabStop = false;
            this.Ptb_Cerrar.Click += new System.EventHandler(this.Ptb_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enfermedades";
            // 
            // Ptb_Resize
            // 
            this.Ptb_Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Resize.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Resize.Image = global::Software_Medico.Properties.Resources.minimizar__1___1_;
            this.Ptb_Resize.Location = new System.Drawing.Point(830, 2);
            this.Ptb_Resize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ptb_Resize.Name = "Ptb_Resize";
            this.Ptb_Resize.Size = new System.Drawing.Size(34, 32);
            this.Ptb_Resize.TabIndex = 4;
            this.Ptb_Resize.TabStop = false;
            this.Ptb_Resize.Click += new System.EventHandler(this.Ptb_Resize_Click);
            // 
            // Frm_Enfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 578);
            this.Controls.Add(this.Pnl_Formulario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Enfermedades";
            this.Text = "Frm_Enfermedades";
            this.Pnl_Formulario.ResumeLayout(false);
            this.Pnl_Formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Base)).EndInit();
            this.Pnl_Menu.ResumeLayout(false);
            this.Pnl_Barra.ResumeLayout(false);
            this.Pnl_Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Resize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Formulario;
        private System.Windows.Forms.Panel Pnl_Menu;
        private System.Windows.Forms.Button Btn_Cita;
        private System.Windows.Forms.Button Btn_Facturacion;
        private System.Windows.Forms.Button Btn_Inventario;
        private System.Windows.Forms.Button Btn_Paciente;
        private System.Windows.Forms.Button Btn_Doctores;
        private System.Windows.Forms.Button Btn_Enfermedades;
        private System.Windows.Forms.Panel Pnl_Barra;
        private System.Windows.Forms.PictureBox Ptb_Max;
        private System.Windows.Forms.PictureBox Ptb_Min;
        private System.Windows.Forms.PictureBox Ptb_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Ptb_Resize;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Examenes;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView Dtg_Base;
    }
}