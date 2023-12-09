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

        ////validado
        //void Validando()
        //{
        //    if (string.IsNullOrEmpty(Txt_Usuario.Text))
        //    {
        //        MessageBox.Show("Debe de Ingresar el usuario..!!");
        //    }
        //    else
        //    {
        //        if (string.IsNullOrEmpty(Txt_Contraseña.Text))
        //        {
        //            MessageBox.Show("Debe de Ingresar la Contraseña..!!");
        //        }
        //        else
        //        {
        //            Modelo = new UsuarioControl().ConsultaUsuario(Txt_Usuario.Text);

        //            if (Txt_Contraseña.Text != Modelo.Clave)
        //            {
        //                MessageBox.Show("La contraseña no es correcta");
        //            }
        //            else
        //            {
        //                if (Modelo.Estatus == false)
        //                {
        //                    MessageBox.Show("Usuario Bloqueado comunicarse con TI");
        //                }
        //                else
        //                {
        //                    Aux_AgregarUsuario aux_AgregarUsuario = new Aux_AgregarUsuario();
        //                    aux_AgregarUsuario.Show(); 

        //                }
        //            }

        //        }
        //    }
        //}
        //cuando se incorpore la validacion con la base de datos se condiciona el Frm_Menu 
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            
            Frm_Menu frm_Menu = new Frm_Menu();
            frm_Menu.Show();

            this.Hide();
        }
    }
}
