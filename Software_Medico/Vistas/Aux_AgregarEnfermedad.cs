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
    public partial class Aux_AgregarEnfermedad : Form
    {
        PatologiasModel PatologiasModel;
        bool valideditar = false;
        public Aux_AgregarEnfermedad()
        {
            InitializeComponent();
        }





        void Guardad()
        {
            PatologiasModel = new PatologiasModel();
            PatologiasModel.Id_Patologia = int.Parse(Txt_Id.Text);
            PatologiasModel.Nombre_Patologia = Txt_Nombre.Text;
            PatologiasModel.Descripcion_Patologia = Txt_Descripcion.Text;

            if (valideditar == false)
            {

                if (new PatologiaControl().ValidPatologia(PatologiasModel) == false)
                {
                    if (new PatologiaControl().CrearPatologia(PatologiasModel) == true)
                    {
                        MessageBox.Show("Registro Guardado", "Info Sistem");
                        //padre.obtenerPais();
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
                if (new PatologiaControl().UpdatePatologia(PatologiasModel) == true)
                {
                    MessageBox.Show("Registro Actualizado", "Info Sistem");
                    //padre.obtenerPais();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Registro No se Puedo Guardar", "Info Sistem");
                }

            }




        }

        bool Validacion()
        {
            bool validacion = true;

            if (string.IsNullOrEmpty(Txt_Id.Text))
            {
                MessageBox.Show("El Id no puede estar vacío");
                Txt_Id.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(Txt_Nombre.Text))
            {
                MessageBox.Show("El Nombre no puede estar vacío");
                Txt_Nombre.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(Txt_Descripcion.Text))
            {
                MessageBox.Show("La Decripcion no puede estar vacío");
                Txt_Descripcion.Focus();
                return false;
            }


            return validacion;
        }

        void LimpiarTextBoxes()
        {
            Txt_Id.Text = string.Empty;
            Txt_Nombre.Text = string.Empty;
            Txt_Descripcion.Text = string.Empty;
        }






        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Validacion() == true)
            {
                Guardad();
                LimpiarTextBoxes();

            }
        }














        //Movilidad de la Ventana
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

        private void Pnl_Formulario_Paint(object sender, PaintEventArgs e)
        {

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

    }
}
