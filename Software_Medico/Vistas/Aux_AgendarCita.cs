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
    public partial class Aux_AgendarCita : Form
    {
        CitasControl cc = new CitasControl();
        CitasModel CitasModel = new CitasModel();
        bool valideditar = false;
        public Aux_AgendarCita()
        {
            InitializeComponent();

          
        }


        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            CitasControl citasControl = new CitasControl();
            CitasModel citasModel = new CitasModel();


            Txt_Paciente.Text = citasControl.buscarNombre(Txt_IDPaciente.Text);



        }
        private void Aux_AgendarCita_Load(object sender, EventArgs e)
        {
           
           
            Cmb_Clinica.DataSource = cc.CargarClinicaCMB();
            Cmb_Clinica.DisplayMember = "NOMBRE_CLINICA";
            Cmb_Clinica.ValueMember = "ID_CLINICA";

            Cmb_Consultorio.DataSource = cc.CargarConsultorioCMB();
            Cmb_Consultorio.DisplayMember = "NOMBRE_CONSULTORIO";
            Cmb_Consultorio.ValueMember = "ID_CONSULTORIO";

            Cmb_Doctor.DataSource = cc.CargarDoctorCMB();
            Cmb_Doctor.DisplayMember = "NOMBRE_MEDICO";
            Cmb_Doctor.ValueMember = "ID_MEDICO";

           // obtenerCity();

          

        }

        public void obtenerCity()
        {
            new CitasControl().ListarCita();
            Dtp_Mostrar.DataSource = CitasModel.GetCitas;

        }


     

        private void Btn_Agendar_Click(object sender, EventArgs e)
        {
            if (Validacion() == true)
            {
                Guardar();
                LimpiarTextBoxes();
            }

        }

        void Guardar()
        {


            CitasModel.Id_Paciente = int.Parse(Txt_IDPaciente.Text);
            CitasModel.Id_Medico = int.Parse(Cmb_Doctor.SelectedValue.ToString());
            CitasModel.Id_Clinica = int.Parse(Cmb_Clinica.SelectedValue.ToString());
            CitasModel.Id_Consultorio = int.Parse(Cmb_Consultorio.SelectedValue.ToString());
            CitasModel.Fecha_Cita = DTP_Fecha.Value;
            CitasModel.HoraIni_Cita = Dtp_Inicio.Value;
            CitasModel.HoraFin_Cita=Dtp_Final.Value;
            TimeSpan duracion = Dtp_Final.Value-Dtp_Inicio.Value ;
            CitasModel.Duracion = (int)duracion.TotalHours;
            CitasModel.Estado_Cita = "True";
            CitasModel.Observacion = "ss";
            CitasModel.Id_Tipo_Cita = 1;
            CitasModel.Id_Usuario = 3;
           




            if (valideditar == false)
            {
                if (cc.ValidCita(CitasModel) == false)
                {

                    if (cc.CrearCita(CitasModel) == true)
                    {
                        MessageBox.Show("Registro Guardado", "Info Sistem");
                        //padre.obtenerCity();
                        //  this.Close();
                        cc.ListarCita2(int.Parse(Txt_IDPaciente.Text));
                        Dtp_Mostrar.DataSource = CitasModel.GetCitas;
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
                if (cc.UpdateCita(CitasModel) == true)
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

            Txt_IDPaciente.Text = string.Empty;
            Txt_Paciente.Text = string.Empty;
            Cmb_Clinica.Text = string.Empty;
            Cmb_Consultorio.Text = string.Empty;
            Cmb_Doctor.Text = string.Empty;
        }

        bool Validacion()
        {
            bool validacion = true;


        
            if (string.IsNullOrEmpty(Txt_IDPaciente.Text))
            {
                MessageBox.Show("El id no puede estar vacía");
                Txt_IDPaciente.Focus();
                return false;
            }

            return validacion;
        }














        //funcionaliodad de la ventana
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

        //movilidad de la ventana
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
