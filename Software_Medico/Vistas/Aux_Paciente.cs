using Software_Medico.Controlador;
using Software_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Medico.Vistas
{
    public partial class Aux_Paciente : Form
    {
        PacienteModel PacienteModel = new PacienteModel();
        PacienteControl PacienteControl = new PacienteControl();
        bool valideditar = false;


        public Aux_Paciente()
        {
            InitializeComponent();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Validacion() == true)
            {
                Guardar();
                LimpiarTextBoxes();
            }
        }


        void Guardar()
        {


            PacienteModel.Nombre = Txt_Nombre.Text;
            PacienteModel.Apellido = Txt_Apellido.Text;
            PacienteModel.Fecha_Nacimiento = Dtp_Edad.Value;
            PacienteModel.Genero = txt_genero.Text;
            PacienteModel.Direccion = Txt_Direccion.Text;
            PacienteModel.Telefono = Txt_Telefono.Text;
            PacienteModel.Email = Txt_Email.Text;
            PacienteModel.Seguro_Medico = Txt_Seguro.Text;
            PacienteModel.Numero_Seguro_Medico = Txt_NSmedico.Text;
            PacienteModel.Grupo_Sanguineo = Txt_Sangre.Text;
            PacienteModel.Alergias = Txt_Alergias.Text;
            PacienteModel.Enfermedades_Cronicas = Txt_EnfCronica.Text;
            PacienteModel.Historia_Medica = Txt_Hmedica.Text;
            PacienteModel.Id_Usuario = int.Parse(Txt_User.Text);



            if (valideditar == false)
            {
                if (PacienteControl.ValidPaciente(PacienteModel) == false)
                {

                    if (PacienteControl.CrearPaciente(PacienteModel) == true)
                    {
                        MessageBox.Show("Registro Guardado", "Info Sistem");
                        //padre.obtenerCity();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El Registro No se Puedo Guardar", "Info Sistem");
                    }
                }
                else
                {
                    MessageBox.Show("El Registro No se Puedo Guardar debido a que es un duplicado.", "Info Sistem");
                }
            }
            else
            {
                if (PacienteControl.UpdatePaciente(PacienteModel) == true)
                {
                    MessageBox.Show("Registro Actualizado", "Info Sistem");
                    //padre.obtenerCity();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Registro No se Puedo Guardar", "Info Sistem");
                }

            }




        }
        void LimpiarTextBoxes()
        {

            Txt_Nombre.Text = string.Empty;
            Txt_Apellido.Text = string.Empty;
            Txt_User.Text = string.Empty;
            txt_genero.Text = string.Empty;
            Txt_Alergias.Text = string.Empty;
            txt_genero.Text = string.Empty;
            Txt_Direccion.Text = string.Empty;
            Txt_Email.Text = string.Empty;
            Txt_EnfCronica.Text = string.Empty;
            Txt_Expediente.Text = string.Empty;
            Txt_Hmedica.Text = string.Empty;
            Txt_NSmedico.Text = string.Empty;
            Txt_Sangre.Text = string.Empty;
            Txt_Seguro.Text = string.Empty;
            Txt_Telefono.Text = string.Empty;
            

        }

        bool Validacion()
        {
            bool validacion = true;



            if (string.IsNullOrEmpty(Txt_Nombre.Text))
            {
                MessageBox.Show("El Nombre no puede estar vacío");
                Txt_Nombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(Txt_Apellido.Text))
            {
                MessageBox.Show("El Apellido no puede estar vacía");
                Txt_Apellido.Focus();
                return false;
            }

         
            return validacion;
        }
























        //condicion de si hay seguro medico
        private void Chk_TSMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TSMedico.Checked)
            {
                // Si el CheckBox está marcado, bloquear el TextBox y el ComboBox
               // Cmb_Seguro.Enabled = false; 
                Txt_NSmedico.Enabled = false;
            }
            else
            {
                // Si el CheckBox no está marcado, desbloquear el TextBox y el ComboBox
              //  Cmb_Seguro.Enabled = true;
                Txt_NSmedico.Enabled = true;
            }
        }

        //Funcionalidad de la ventana
        private void Ptb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Ptb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Movilidad de la ventana
        int m, mx, my;
        private void Pnl_Barra_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

      

        private void Pnl_Barra_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Pnl_Barra_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
