namespace Software_Medico.Vistas
{
    partial class Aux_AgregarEnfermedad
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pnl_Formulario = new System.Windows.Forms.Panel();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Patologia";
            // 
            // Ptb_Cerrar
            // 
            this.Ptb_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Cerrar.Image = global::Software_Medico.Properties.Resources.cerrar_sesion__1_;
            this.Ptb_Cerrar.Location = new System.Drawing.Point(407, 3);
            this.Ptb_Cerrar.Name = "Ptb_Cerrar";
            this.Ptb_Cerrar.Size = new System.Drawing.Size(45, 40);
            this.Ptb_Cerrar.TabIndex = 1;
            this.Ptb_Cerrar.TabStop = false;
            this.Ptb_Cerrar.Click += new System.EventHandler(this.Ptb_Cerrar_Click);
            // 
            // Ptb_Min
            // 
            this.Ptb_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ptb_Min.BackColor = System.Drawing.Color.Transparent;
            this.Ptb_Min.Image = global::Software_Medico.Properties.Resources.minimizar__3___1_;
            this.Ptb_Min.Location = new System.Drawing.Point(356, 3);
            this.Ptb_Min.Name = "Ptb_Min";
            this.Ptb_Min.Size = new System.Drawing.Size(45, 40);
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
            this.Pnl_Barra.Name = "Pnl_Barra";
            this.Pnl_Barra.Size = new System.Drawing.Size(456, 40);
            this.Pnl_Barra.TabIndex = 3;
            this.Pnl_Barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseDown);
            this.Pnl_Barra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseMove);
            this.Pnl_Barra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_Barra_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de la Patologia:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(37, 88);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(378, 30);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 30);
            this.textBox1.TabIndex = 3;
            // 
            // Pnl_Formulario
            // 
            this.Pnl_Formulario.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_Formulario.Controls.Add(this.Btn_Cancelar);
            this.Pnl_Formulario.Controls.Add(this.Btn_Guardar);
            this.Pnl_Formulario.Controls.Add(this.textBox1);
            this.Pnl_Formulario.Controls.Add(this.label3);
            this.Pnl_Formulario.Controls.Add(this.Txt_Nombre);
            this.Pnl_Formulario.Controls.Add(this.label2);
            this.Pnl_Formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Formulario.Location = new System.Drawing.Point(0, 40);
            this.Pnl_Formulario.Name = "Pnl_Formulario";
            this.Pnl_Formulario.Size = new System.Drawing.Size(456, 325);
            this.Pnl_Formulario.TabIndex = 4;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Cancelar.Location = new System.Drawing.Point(261, 246);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(154, 50);
            this.Btn_Cancelar.TabIndex = 19;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Guardar.Location = new System.Drawing.Point(43, 246);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(154, 50);
            this.Btn_Guardar.TabIndex = 18;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // Aux_AgregarEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 365);
            this.Controls.Add(this.Pnl_Formulario);
            this.Controls.Add(this.Pnl_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aux_AgregarEnfermedad";
            this.Text = "Aux_AgregarEnfermedad";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Pnl_Formulario;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
    }
}