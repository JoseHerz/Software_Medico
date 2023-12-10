using Software_Medico.Controlador;
using Software_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Medico.Vistas
{
    public partial class Frm_VDocPaciente : Form
    {
        ExpedienteControl cc = new ExpedienteControl();
        ExpedienteModel ExpedienteModel = new ExpedienteModel();
        public Frm_VDocPaciente()
        {
            InitializeComponent();
            Btn_Paciente.Enabled = true;
        }

        private void Frm_VDocPaciente_Load(object sender, EventArgs e)
        {
            Cmb_Examen.DataSource = cc.CargarExamenCMB();
            Cmb_Examen.DisplayMember = "NOMBRE_EXAMEN";
            Cmb_Examen.ValueMember = "ID_EXAMENES";

            Cmb_Medicamento.DataSource = cc.CargarMedicameMB();
            Cmb_Medicamento.DisplayMember = "NOMBRE_PRODUCTO";
            Cmb_Medicamento.ValueMember = "ID_PRODUCTO";

            Cmb_NPatologia.DataSource = cc.CargarPatologiaCMB();
            Cmb_NPatologia.DisplayMember = "NOMBRE_PATOLOGIA";
            Cmb_NPatologia.ValueMember = "ID_PATOLOGIA";


        }



        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            buscarinfo();
            ExpedienteControl cc = new ExpedienteControl();
            ExpedienteModel ExpedienteModel = new ExpedienteModel();


            cc.ListarExpe(int.Parse(Txt_buscar.Text));
            Dtg_Base.DataSource = ExpedienteModel.GetExpediente;

        }

        public void buscarinfo()
        {
            using (SqlConnection Con = new Conexion().GetConexion())
            {
                Con.Open();
                string sql = "select NOMBRE, APELLIDO, DIRECCION, TELEFONO, GENERO, ALERGIAS, FECHA_NACIMIENTO, NUMERO_SEGURO_MEDICO, ENFERMEDADES_CRONICAS,GRUPO_SANGUINEO FROM PACIENTES WHERE ID_PACIENTE = @idpac";

                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@idpac", Txt_buscar.Text.Trim()); // Utilizar el parámetro pasado al método, no el TextBox Txt_buscar.Text.Trim()

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader()) // Utilizar cmd en lugar de command
                        {
                            if (reader.Read())
                            {
                                // Obtener los valores de Nombre y Apellido desde el SqlDataReader
                                string nombre = reader["NOMBRE"].ToString();
                                string apellido = reader["APELLIDO"].ToString();
                                string direccion = reader["DIRECCION"].ToString();
                                string genero = reader["GENERO"].ToString();
                                string alergias = reader["ALERGIAS"].ToString();
                                string numerseguro = reader["NUMERO_SEGURO_MEDICO"].ToString();
                                string enfermedadb = reader["ENFERMEDADES_CRONICAS"].ToString();
                                string telefono = reader["TELEFONO"].ToString();
                                DateTime fechana = Convert.ToDateTime(reader["FECHA_NACIMIENTO"]);
                                string sangre = reader["GRUPO_SANGUINEO"].ToString();



                                // Mostrar la información en los TextBox correspondientes
                                Txt_Nombre.Text = nombre;
                                Txt_Apellido.Text = apellido;
                                Txt_Direccion.Text=direccion;
                                Txt_Genero.Text = genero;
                                Txt_Alergias.Text=alergias;
                                Txt_NSmedico.Text=numerseguro;
                                Rtb_Cronicas.Text = enfermedadb;
                                Txt_Telefono.Text = telefono;
                                Txt_Sangre.Text = sangre;
                                Dtp_Edad.Value = fechana;
                            }
                            else
                            {
                                MessageBox.Show("ID no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Con.Close();
            }
        }




        






            















        //Funcionalidad basica
        private void Ptb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Ptb_Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Ptb_Max.Visible = false;
            Ptb_Resize.Visible = true;
        }

        private void Ptb_Resize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Ptb_Resize.Visible = false;
            Ptb_Max.Visible = true;
        }

        private void Ptb_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }

        //funcionalidad de la barra de botones
        private void Btn_Enfermedades_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Enfermedades frm_Enfermedades = new Frm_Enfermedades();
            frm_Enfermedades.Show();
        }

        private void Btn_Doctores_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Doctores frm_Doctores = new Frm_Doctores();
            frm_Doctores.Show();
        }

        private void Btn_Examenes_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Examenes frm_Examenes = new Frm_Examenes();
            frm_Examenes.Show();
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Inventario frm_Inventario = new Frm_Inventario();
            frm_Inventario.Show();
        }

        private void Btn_Facturacion_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Facturacion frm_Facturacion = new Frm_Facturacion();
            frm_Facturacion.Show();
        }

        private void Btn_Cita_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Cita frm_Cita = new Frm_Cita();
            frm_Cita.Show();
        }

        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_LogOut frm_LogOut = new Frm_LogOut();
            frm_LogOut.Show();
        }

        //Movilidad de la ventana
        int m, mx, my;
        private void Pnl_Barra_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
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
