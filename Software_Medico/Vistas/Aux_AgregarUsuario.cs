using DPFP;
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
    public partial class Aux_AgregarUsuario : Form
    {
        UsuarioModel UsuarioModel = new UsuarioModel();
        UsuarioControl UsuarioControl = new UsuarioControl();
        bool valideditar = false;

        public Aux_AgregarUsuario()
        {
            InitializeComponent();
        }
        void Guardar()
        {

         
            UsuarioModel.Nombre = Txt_Nombre.Text;
            UsuarioModel.Apellido = Txt_Apellido.Text;
            UsuarioModel.Correo_Electronico = Txt_Correo.Text;
            UsuarioModel.Clave = Txt_Clave.Text;
            UsuarioModel.Id_Usuario_Rol = int.Parse(Cmb_rol.SelectedValue.ToString());
            UsuarioModel.Estatus = Chk_Activo.Checked;
            UsuarioModel.Huella = Txt_Clave.Text;
         



            if (valideditar == false)
            {
                if (UsuarioControl.ValidUser(UsuarioModel) == false)
                {

                    if (UsuarioControl.CrearUser(UsuarioModel) == true)
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
                if (UsuarioControl.UpdateUser(UsuarioModel) == true)
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
            Txt_Correo.Text = string.Empty;
            Txt_Clave.Text = string.Empty;
            Chk_Activo.Checked =  false;
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

            if (string.IsNullOrEmpty(Txt_Correo.Text))
            {
                MessageBox.Show("La Credencial no puede estar vacía");
                Txt_Correo.Focus();
                return false;
            }
            return validacion;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Validacion() == true)
            {
                Guardar();
                LimpiarTextBoxes();
            }
        }

        private void Aux_AgregarUsuario_Load(object sender, EventArgs e)
        {
            UsuarioControl cc = new UsuarioControl();
            Cmb_rol.DataSource = cc.CargarRolCMB();
            Cmb_rol.DisplayMember = "DESCRIPCION";
            Cmb_rol.ValueMember = "ID_USUARIO_ROL";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ptb_Min_Click(object sender, EventArgs e)
        {

        }

        private DPFP.Template Template;
        
        string Modo = "";
        void AgregarHuella()
        {
            AgregandoHuella Reg = new AgregandoHuella();
            Reg.OnTemplate += this.OnTemplate;
            Reg.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;

                if (Template != null)
                {
                    lblMensaje.Text = "Huella Capturada Exitosamente";
                    lblMensaje.ForeColor = Color.Green;

                    new UsuarioControl().ActualizaHuellaUsuarios(Txt_Nombre.Text, Template);

                }
                else
                {
                    lblMensaje.Text = "Huella no Capturada";
                    lblMensaje.ForeColor = Color.Red;
                }

            }));
        }

        private void Btn_Huella_Click(object sender, EventArgs e)
        {
            AgregarHuella();
        }
    }
}
