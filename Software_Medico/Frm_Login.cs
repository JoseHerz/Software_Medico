using Software_Medico.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Medico.Modelo;
using Software_Medico.Vistas;

namespace Software_Medico
{
    public partial class Frm_Login : Form
    {

        UsuarioModel Modelo;
        public Frm_Login()
        {
            InitializeComponent();
        }

        void Validando()
        {
            if (string.IsNullOrEmpty(Txt_Usuario.Text))
            {
                MessageBox.Show("Debe de Ingresar el usuario..!!");
            }
            else
            {
                if (string.IsNullOrEmpty(Txt_Contraseña.Text))
                {
                    MessageBox.Show("Debe de Ingresar la Contraseña..!!");
                }
                else
                {
                    Modelo = new UsuarioControl().ConsultaUsuario(int.Parse(Txt_Usuario.Text));
                    if (Txt_Contraseña.Text != Modelo.Clave)
                    {
                        MessageBox.Show("El passwor no es correcto");
                    }
                    else
                    {
                        if (Modelo.Estatus == true)
                        {
                            MessageBox.Show("Usuario Bloqueado comunicarse con TI");
                        }
                        else
                        {
                           Frm_Menu Formu = new Frm_Menu();
                            Formu.Show();
                        }
                    }

                }
            }
        }

        void VerificandoHuella()
        {
            ValidandoHuella Formu = new ValidandoHuella();
            Formu.Logueando = this;
            Formu.ShowDialog();
            Validando();
        }

        public void AsignandoValoresDeHuella(string Usuario, string Password)
        {
            Txt_Usuario.Text = Usuario;
            Txt_Contraseña.Text = Password;
        }



        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Validando();
            
          
        }
        //Funcionalidad de la ventana
        private void Ptb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ptb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //movilidad de la ventana
        int m, mx, my;
        private void Pnl_Barra_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Huella_Click(object sender, EventArgs e)
        {
            VerificandoHuella();
        }

        private void Pnl_Barra_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Pnl_Barra_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
    }
}
