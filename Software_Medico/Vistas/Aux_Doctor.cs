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
    public partial class Aux_Doctor : Form
    {
        MedicosModel MedicoModel;
        MedicoControl MedicoControl;
        bool valideditar = false;

        public Aux_Doctor()
        {
            InitializeComponent();
          
        }


        private void Aux_Doctor_Load(object sender, EventArgs e)
        {
            EspecialidadControl cc = new EspecialidadControl();
            Cmb_Especialidad.DataSource = cc.CargarEspecialidadCMB();
            Cmb_Especialidad.DisplayMember = "NOMBRE_ESPECIALIDAD";
            Cmb_Especialidad.ValueMember = "ID_ESPECIALIDAD";
        }

        void Guardar()
        {
         
          
            MedicoModel.Primer_Nombre = Txt_Nombre1.Text;
            MedicoModel.Segundo_Nombre = Txt_Nombre2.Text;
            MedicoModel.Primer_Apellido = Txt_Apellido1.Text;
            MedicoModel.Segundo_Apellido = Txt_Apellido2.Text;
            MedicoModel.Id_Usuario = int.Parse(Txt_Usuario.Text);
            MedicoModel.Credenciales = int.Parse(Txt_Credenciales.Text);
            MedicoModel.Id_Horario = int.Parse(Cmb_Horario.SelectedValue.ToString());
            MedicoModel.Telefono = Txt_Telefono.Text ;
            MedicoModel.Id_Especialidad = int.Parse(Cmb_Especialidad.SelectedValue.ToString());
            MedicoModel.Sexo = Txt_Sexo.Text;



            if (valideditar == false)
            {
                if (MedicoControl.ValidMedico(MedicoModel) == false)
                {

                    if (MedicoControl.CrearMedico(MedicoModel) == true)
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
                if (MedicoControl.UpdateMedico(MedicoModel) == true)
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
         
            Txt_Nombre1.Text = string.Empty;
            Txt_Nombre2.Text = string.Empty;
            Txt_Apellido1.Text = string.Empty;
            Txt_Apellido2.Text = string.Empty;
            Txt_Usuario.Text = string.Empty;
            Txt_Credenciales.Text = string.Empty;
            Cmb_Horario.Text = string.Empty;
            Txt_Telefono.Text = string.Empty;
            Cmb_Especialidad.Text = string.Empty;
            Txt_Sexo.Text = string.Empty;

        }

        bool Validacion()
        {
            bool validacion = true;

          

            if (string.IsNullOrEmpty(Txt_Nombre1.Text))
            {
                MessageBox.Show("El Nombre no puede estar vacío");
                Txt_Nombre1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(Txt_Apellido1.Text))
            {
                MessageBox.Show("El Apellido no puede estar vacía");
                Txt_Apellido1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(Txt_Credenciales.Text))
            {
                MessageBox.Show("La Credencial no puede estar vacía");
                Txt_Credenciales.Focus();
                return false;
            }
            return validacion;
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

        private void Pnl_Formulario_Paint(object sender, PaintEventArgs e)
        {
         


        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Validacion() == true)
            {
                Guardar();
                LimpiarTextBoxes();
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
