namespace Software_Medico.Vistas
{
    partial class Aux_Paciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ptb_Cerrar = new System.Windows.Forms.PictureBox();
            this.Ptb_Min = new System.Windows.Forms.PictureBox();
            this.Pnl_Barra = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new System.Windows.Forms.TextBox();
            this.Cmb_Gsanguineo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Alergias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_Edad = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_Hmedica = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_EnfCronica = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Chk_TSMedico = new System.Windows.Forms.CheckBox();
            this.Cmb_Seguro = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_NSmedico = new System.Windows.Forms.TextBox();
            this.Txt_Expediente = new System.Windows.Forms.TextBox();
            this.Pnl_Formulario = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).BeginInit();
            this.Pnl_Barra.SuspendLayout();
            this.Pnl_Formulario.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Paciente";
            // 
            // Ptb_Cerrar
            // 
            this.Ptb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Cerrar.Image = global::Software_Medico.Properties.Resources.cerrar_sesion__1_;
            this.Ptb_Cerrar.Location = new System.Drawing.Point(719, 2);
            this.Ptb_Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ptb_Cerrar.Name = "Ptb_Cerrar";
            this.Ptb_Cerrar.Size = new System.Drawing.Size(34, 32);
            this.Ptb_Cerrar.TabIndex = 1;
            this.Ptb_Cerrar.TabStop = false;
            this.Ptb_Cerrar.Click += new System.EventHandler(this.Ptb_Cerrar_Click);
            // 
            // Ptb_Min
            // 
            this.Ptb_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Min.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Min.Image = global::Software_Medico.Properties.Resources.minimizar__3___1_;
            this.Ptb_Min.Location = new System.Drawing.Point(681, 2);
            this.Ptb_Min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ptb_Min.Name = "Ptb_Min";
            this.Ptb_Min.Size = new System.Drawing.Size(34, 32);
            this.Ptb_Min.TabIndex = 3;
            this.Ptb_Min.TabStop = false;
            this.Ptb_Min.Click += new System.EventHandler(this.Ptb_Min_Click);
            // 
            // Pnl_Barra
            // 
            this.Pnl_Barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.Pnl_Barra.Controls.Add(this.Ptb_Min);
            this.Pnl_Barra.Controls.Add(this.Ptb_Cerrar);
            this.Pnl_Barra.Controls.Add(this.label1);
            this.Pnl_Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Barra.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Barra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Barra.Name = "Pnl_Barra";
            this.Pnl_Barra.Size = new System.Drawing.Size(756, 32);
            this.Pnl_Barra.TabIndex = 7;
            this.Pnl_Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseDown);
            this.Pnl_Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseMove);
            this.Pnl_Barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(101, 55);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(204, 26);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar.Location = new System.Drawing.Point(457, 358);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(116, 41);
            this.Btn_Guardar.TabIndex = 18;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Cancelar.Location = new System.Drawing.Point(577, 358);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(116, 41);
            this.Btn_Cancelar.TabIndex = 19;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Datos Personales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Apellido:";
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Apellido.Location = new System.Drawing.Point(101, 84);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Size = new System.Drawing.Size(204, 26);
            this.Txt_Apellido.TabIndex = 24;
            // 
            // Cmb_Gsanguineo
            // 
            this.Cmb_Gsanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Gsanguineo.FormattingEnabled = true;
            this.Cmb_Gsanguineo.Location = new System.Drawing.Point(613, 68);
            this.Cmb_Gsanguineo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cmb_Gsanguineo.Name = "Cmb_Gsanguineo";
            this.Cmb_Gsanguineo.Size = new System.Drawing.Size(77, 28);
            this.Cmb_Gsanguineo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Grupo Sanguineo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Alergias:";
            // 
            // Txt_Alergias
            // 
            this.Txt_Alergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Alergias.Location = new System.Drawing.Point(532, 110);
            this.Txt_Alergias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Alergias.Name = "Txt_Alergias";
            this.Txt_Alergias.Size = new System.Drawing.Size(204, 26);
            this.Txt_Alergias.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Telefono:";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Telefono.Location = new System.Drawing.Point(101, 209);
            this.Txt_Telefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(159, 26);
            this.Txt_Telefono.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(531, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "Datos Medicos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(456, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Expediente:";
            // 
            // Cmb_Sexo
            // 
            this.Cmb_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Sexo.FormattingEnabled = true;
            this.Cmb_Sexo.Location = new System.Drawing.Point(79, 147);
            this.Cmb_Sexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cmb_Sexo.Name = "Cmb_Sexo";
            this.Cmb_Sexo.Size = new System.Drawing.Size(116, 28);
            this.Cmb_Sexo.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // Dtp_Edad
            // 
            this.Dtp_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_Edad.Location = new System.Drawing.Point(198, 118);
            this.Dtp_Edad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dtp_Edad.Name = "Dtp_Edad";
            this.Dtp_Edad.Size = new System.Drawing.Size(246, 23);
            this.Dtp_Edad.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Direccion:";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Direccion.Location = new System.Drawing.Point(101, 179);
            this.Txt_Direccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(204, 26);
            this.Txt_Direccion.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 243);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "E-mail:";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Email.Location = new System.Drawing.Point(88, 240);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(225, 26);
            this.Txt_Email.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(454, 206);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Historia Medica:";
            // 
            // Txt_Hmedica
            // 
            this.Txt_Hmedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Hmedica.Location = new System.Drawing.Point(458, 232);
            this.Txt_Hmedica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Hmedica.Name = "Txt_Hmedica";
            this.Txt_Hmedica.Size = new System.Drawing.Size(278, 26);
            this.Txt_Hmedica.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(454, 145);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(206, 20);
            this.label15.TabIndex = 46;
            this.label15.Text = "Enfermedades Cronicas:";
            // 
            // Txt_EnfCronica
            // 
            this.Txt_EnfCronica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EnfCronica.Location = new System.Drawing.Point(458, 171);
            this.Txt_EnfCronica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_EnfCronica.Name = "Txt_EnfCronica";
            this.Txt_EnfCronica.Size = new System.Drawing.Size(278, 26);
            this.Txt_EnfCronica.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 318);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "Seguro Medico:";
            // 
            // Chk_TSMedico
            // 
            this.Chk_TSMedico.AutoSize = true;
            this.Chk_TSMedico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Chk_TSMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_TSMedico.Location = new System.Drawing.Point(22, 280);
            this.Chk_TSMedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chk_TSMedico.Name = "Chk_TSMedico";
            this.Chk_TSMedico.Size = new System.Drawing.Size(197, 24);
            this.Chk_TSMedico.TabIndex = 50;
            this.Chk_TSMedico.Text = "Tiene Seguro Medico";
            this.Chk_TSMedico.UseVisualStyleBackColor = true;
            this.Chk_TSMedico.CheckedChanged += new System.EventHandler(this.Chk_TSMedico_CheckedChanged);
            // 
            // Cmb_Seguro
            // 
            this.Cmb_Seguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Seguro.FormattingEnabled = true;
            this.Cmb_Seguro.Location = new System.Drawing.Point(154, 316);
            this.Cmb_Seguro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cmb_Seguro.Name = "Cmb_Seguro";
            this.Cmb_Seguro.Size = new System.Drawing.Size(159, 28);
            this.Cmb_Seguro.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 358);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(226, 20);
            this.label17.TabIndex = 52;
            this.label17.Text = "Numero de Seguro Medico:";
            // 
            // Txt_NSmedico
            // 
            this.Txt_NSmedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NSmedico.Location = new System.Drawing.Point(30, 380);
            this.Txt_NSmedico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_NSmedico.Name = "Txt_NSmedico";
            this.Txt_NSmedico.Size = new System.Drawing.Size(319, 26);
            this.Txt_NSmedico.TabIndex = 53;
            // 
            // Txt_Expediente
            // 
            this.Txt_Expediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Expediente.Location = new System.Drawing.Point(564, 276);
            this.Txt_Expediente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Expediente.Name = "Txt_Expediente";
            this.Txt_Expediente.Size = new System.Drawing.Size(181, 26);
            this.Txt_Expediente.TabIndex = 54;
            // 
            // Pnl_Formulario
            // 
            this.Pnl_Formulario.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_Formulario.Controls.Add(this.Txt_Expediente);
            this.Pnl_Formulario.Controls.Add(this.Txt_NSmedico);
            this.Pnl_Formulario.Controls.Add(this.label17);
            this.Pnl_Formulario.Controls.Add(this.Cmb_Seguro);
            this.Pnl_Formulario.Controls.Add(this.Chk_TSMedico);
            this.Pnl_Formulario.Controls.Add(this.label16);
            this.Pnl_Formulario.Controls.Add(this.Txt_EnfCronica);
            this.Pnl_Formulario.Controls.Add(this.label15);
            this.Pnl_Formulario.Controls.Add(this.Txt_Hmedica);
            this.Pnl_Formulario.Controls.Add(this.label14);
            this.Pnl_Formulario.Controls.Add(this.Txt_Email);
            this.Pnl_Formulario.Controls.Add(this.label13);
            this.Pnl_Formulario.Controls.Add(this.Txt_Direccion);
            this.Pnl_Formulario.Controls.Add(this.label6);
            this.Pnl_Formulario.Controls.Add(this.Dtp_Edad);
            this.Pnl_Formulario.Controls.Add(this.label4);
            this.Pnl_Formulario.Controls.Add(this.label3);
            this.Pnl_Formulario.Controls.Add(this.Cmb_Sexo);
            this.Pnl_Formulario.Controls.Add(this.label12);
            this.Pnl_Formulario.Controls.Add(this.label11);
            this.Pnl_Formulario.Controls.Add(this.Txt_Telefono);
            this.Pnl_Formulario.Controls.Add(this.label10);
            this.Pnl_Formulario.Controls.Add(this.Txt_Alergias);
            this.Pnl_Formulario.Controls.Add(this.label9);
            this.Pnl_Formulario.Controls.Add(this.label8);
            this.Pnl_Formulario.Controls.Add(this.Cmb_Gsanguineo);
            this.Pnl_Formulario.Controls.Add(this.Txt_Apellido);
            this.Pnl_Formulario.Controls.Add(this.label7);
            this.Pnl_Formulario.Controls.Add(this.label5);
            this.Pnl_Formulario.Controls.Add(this.Btn_Cancelar);
            this.Pnl_Formulario.Controls.Add(this.Btn_Guardar);
            this.Pnl_Formulario.Controls.Add(this.Txt_Nombre);
            this.Pnl_Formulario.Controls.Add(this.label2);
            this.Pnl_Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Formulario.Location = new System.Drawing.Point(0, 32);
            this.Pnl_Formulario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_Formulario.Name = "Pnl_Formulario";
            this.Pnl_Formulario.Size = new System.Drawing.Size(756, 446);
            this.Pnl_Formulario.TabIndex = 8;
            // 
            // Aux_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 478);
            this.Controls.Add(this.Pnl_Formulario);
            this.Controls.Add(this.Pnl_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Aux_Paciente";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ptb_Min)).EndInit();
            this.Pnl_Barra.ResumeLayout(false);
            this.Pnl_Barra.PerformLayout();
            this.Pnl_Formulario.ResumeLayout(false);
            this.Pnl_Formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Ptb_Cerrar;
        private System.Windows.Forms.PictureBox Ptb_Min;
        private System.Windows.Forms.Panel Pnl_Barra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Apellido;
        private System.Windows.Forms.ComboBox Cmb_Gsanguineo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Alergias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Cmb_Sexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_Edad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Txt_Hmedica;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Txt_EnfCronica;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox Chk_TSMedico;
        private System.Windows.Forms.ComboBox Cmb_Seguro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Txt_NSmedico;
        private System.Windows.Forms.TextBox Txt_Expediente;
        private System.Windows.Forms.Panel Pnl_Formulario;
    }
}