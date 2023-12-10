namespace Software_Medico.Vistas
{
    partial class Aux_AgendarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aux_AgendarCita));
            this.Pnl_Barra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Ptb_Max = new System.Windows.Forms.PictureBox();
            this.Ptb_Min = new System.Windows.Forms.PictureBox();
            this.Ptb_Cerrar = new System.Windows.Forms.PictureBox();
            this.Ptb_Resize = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Paciente = new System.Windows.Forms.TextBox();
            this.Cmb_Consultorio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Agendar = new System.Windows.Forms.Button();
            this.DTP_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Mostrar = new System.Windows.Forms.DataGridView();
            this.Cmb_Clinica = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Cmb_Doctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Dtp_Final = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.Pnl_Formulario = new System.Windows.Forms.Panel();
            this.Txt_IDPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Mostrar)).BeginInit();
            this.Pnl_Formulario.SuspendLayout();
            this.SuspendLayout();
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
            this.Pnl_Barra.Size = new System.Drawing.Size(963, 39);
            this.Pnl_Barra.TabIndex = 27;
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
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agendar Cita";
            // 
            // Ptb_Max
            // 
            this.Ptb_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Max.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Max.Image = global::Software_Medico.Properties.Resources.maximizar__1_;
            this.Ptb_Max.Location = new System.Drawing.Point(850, 2);
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
            this.Ptb_Min.Location = new System.Drawing.Point(799, 2);
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
            this.Ptb_Cerrar.Location = new System.Drawing.Point(901, 2);
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
            this.Ptb_Resize.Location = new System.Drawing.Point(850, 2);
            this.Ptb_Resize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ptb_Resize.Name = "Ptb_Resize";
            this.Ptb_Resize.Size = new System.Drawing.Size(45, 39);
            this.Ptb_Resize.TabIndex = 4;
            this.Ptb_Resize.TabStop = false;
            this.Ptb_Resize.Click += new System.EventHandler(this.Ptb_Resize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Paciente:";
            // 
            // Txt_Paciente
            // 
            this.Txt_Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Paciente.Location = new System.Drawing.Point(178, 67);
            this.Txt_Paciente.Name = "Txt_Paciente";
            this.Txt_Paciente.Size = new System.Drawing.Size(470, 34);
            this.Txt_Paciente.TabIndex = 16;
            // 
            // Cmb_Consultorio
            // 
            this.Cmb_Consultorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Consultorio.FormattingEnabled = true;
            this.Cmb_Consultorio.Location = new System.Drawing.Point(178, 154);
            this.Cmb_Consultorio.Name = "Cmb_Consultorio";
            this.Cmb_Consultorio.Size = new System.Drawing.Size(228, 37);
            this.Cmb_Consultorio.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Clinica:";
            // 
            // Btn_Agendar
            // 
            this.Btn_Agendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Btn_Agendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agendar.ForeColor = System.Drawing.Color.White;
            this.Btn_Agendar.Location = new System.Drawing.Point(776, 177);
            this.Btn_Agendar.Name = "Btn_Agendar";
            this.Btn_Agendar.Size = new System.Drawing.Size(160, 74);
            this.Btn_Agendar.TabIndex = 22;
            this.Btn_Agendar.Text = "Agendar";
            this.Btn_Agendar.UseVisualStyleBackColor = false;
            // 
            // DTP_Fecha
            // 
            this.DTP_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Fecha.Location = new System.Drawing.Point(508, 132);
            this.DTP_Fecha.Name = "DTP_Fecha";
            this.DTP_Fecha.Size = new System.Drawing.Size(430, 34);
            this.DTP_Fecha.TabIndex = 23;
            // 
            // Dtp_Mostrar
            // 
            this.Dtp_Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtp_Mostrar.Location = new System.Drawing.Point(30, 271);
            this.Dtp_Mostrar.Name = "Dtp_Mostrar";
            this.Dtp_Mostrar.RowHeadersWidth = 51;
            this.Dtp_Mostrar.RowTemplate.Height = 24;
            this.Dtp_Mostrar.Size = new System.Drawing.Size(906, 313);
            this.Dtp_Mostrar.TabIndex = 24;
            // 
            // Cmb_Clinica
            // 
            this.Cmb_Clinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Clinica.FormattingEnabled = true;
            this.Cmb_Clinica.Location = new System.Drawing.Point(178, 111);
            this.Cmb_Clinica.Name = "Cmb_Clinica";
            this.Cmb_Clinica.Size = new System.Drawing.Size(228, 37);
            this.Cmb_Clinica.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Consultorio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(666, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hora Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(671, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Hora Final:";
            // 
            // Cmb_Doctor
            // 
            this.Cmb_Doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Doctor.FormattingEnabled = true;
            this.Cmb_Doctor.Location = new System.Drawing.Point(178, 197);
            this.Cmb_Doctor.Name = "Cmb_Doctor";
            this.Cmb_Doctor.Size = new System.Drawing.Size(228, 37);
            this.Cmb_Doctor.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 29);
            this.label9.TabIndex = 33;
            this.label9.Text = "Doctor:";
            // 
            // Dtp_Final
            // 
            this.Dtp_Final.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Final.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Final.Location = new System.Drawing.Point(818, 72);
            this.Dtp_Final.Name = "Dtp_Final";
            this.Dtp_Final.Size = new System.Drawing.Size(118, 30);
            this.Dtp_Final.TabIndex = 35;
            // 
            // Dtp_Inicio
            // 
            this.Dtp_Inicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Dtp_Inicio.Location = new System.Drawing.Point(818, 24);
            this.Dtp_Inicio.Name = "Dtp_Inicio";
            this.Dtp_Inicio.Size = new System.Drawing.Size(118, 30);
            this.Dtp_Inicio.TabIndex = 36;
            // 
            // Pnl_Formulario
            // 
            this.Pnl_Formulario.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_Formulario.Controls.Add(this.Txt_IDPaciente);
            this.Pnl_Formulario.Controls.Add(this.label2);
            this.Pnl_Formulario.Controls.Add(this.Dtp_Inicio);
            this.Pnl_Formulario.Controls.Add(this.Dtp_Final);
            this.Pnl_Formulario.Controls.Add(this.label9);
            this.Pnl_Formulario.Controls.Add(this.Cmb_Doctor);
            this.Pnl_Formulario.Controls.Add(this.label8);
            this.Pnl_Formulario.Controls.Add(this.label7);
            this.Pnl_Formulario.Controls.Add(this.label6);
            this.Pnl_Formulario.Controls.Add(this.Cmb_Clinica);
            this.Pnl_Formulario.Controls.Add(this.Dtp_Mostrar);
            this.Pnl_Formulario.Controls.Add(this.DTP_Fecha);
            this.Pnl_Formulario.Controls.Add(this.Btn_Agendar);
            this.Pnl_Formulario.Controls.Add(this.label4);
            this.Pnl_Formulario.Controls.Add(this.Cmb_Consultorio);
            this.Pnl_Formulario.Controls.Add(this.Txt_Paciente);
            this.Pnl_Formulario.Controls.Add(this.label3);
            this.Pnl_Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Formulario.Location = new System.Drawing.Point(0, 39);
            this.Pnl_Formulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_Formulario.Name = "Pnl_Formulario";
            this.Pnl_Formulario.Size = new System.Drawing.Size(963, 611);
            this.Pnl_Formulario.TabIndex = 28;
            // 
            // Txt_IDPaciente
            // 
            this.Txt_IDPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IDPaciente.Location = new System.Drawing.Point(178, 27);
            this.Txt_IDPaciente.Name = "Txt_IDPaciente";
            this.Txt_IDPaciente.Size = new System.Drawing.Size(228, 34);
            this.Txt_IDPaciente.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "ID Paciente:";
            // 
            // Aux_AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 650);
            this.Controls.Add(this.Pnl_Formulario);
            this.Controls.Add(this.Pnl_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aux_AgendarCita";
            this.Text = "Aux_AgendarCita";
            this.Pnl_Barra.ResumeLayout(false);
            this.Pnl_Barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtp_Mostrar)).EndInit();
            this.Pnl_Formulario.ResumeLayout(false);
            this.Pnl_Formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_Barra;
        private System.Windows.Forms.PictureBox Ptb_Max;
        private System.Windows.Forms.PictureBox Ptb_Min;
        private System.Windows.Forms.PictureBox Ptb_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Ptb_Resize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Paciente;
        private System.Windows.Forms.ComboBox Cmb_Consultorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Agendar;
        private System.Windows.Forms.DateTimePicker DTP_Fecha;
        private System.Windows.Forms.DataGridView Dtp_Mostrar;
        private System.Windows.Forms.ComboBox Cmb_Clinica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cmb_Doctor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Dtp_Final;
        private System.Windows.Forms.DateTimePicker Dtp_Inicio;
        private System.Windows.Forms.Panel Pnl_Formulario;
        private System.Windows.Forms.TextBox Txt_IDPaciente;
        private System.Windows.Forms.Label label2;
    }
}