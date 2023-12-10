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
    public partial class Frm_Doctores : Form
    {
        MedicoControl cc = new MedicoControl();
        MedicosModel MedicosModel = new MedicosModel();
        

        public Frm_Doctores()
        {
            InitializeComponent();
            Btn_Doctores.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }



        private void Dtg_Base_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //new MedicoControl().ListarMedico();
            //Dtg_Base.DataSource = MedicosModel.GetMedico;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            cc.ListarMedico2(int.Parse(Txt_buscar.Text));
            Dtg_Base.DataSource = MedicosModel.GetMedico;
        }



        //funcionalidad basica
        private void Frm_Doctores_Load(object sender, EventArgs e)
        {

        }

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


        //funcionalidad de la ventana
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

        //Movilidad entre formularios
        private void Btn_Enfermedades_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Enfermedades frm_Enfermedades = new Frm_Enfermedades();
            frm_Enfermedades.Show();
        }

        private void Btn_Paciente_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Paciente frm_Paciente = new Frm_Paciente();
            frm_Paciente.Show();
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

        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_LogOut frm_LogOut = new Frm_LogOut();
            frm_LogOut.Show();
        }

        
        private void Btn_Cita_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Cita frm_Cita = new Frm_Cita();
            frm_Cita.Show();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistro();
        }

        private void Dtg_Base_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Btn_Eliminar.Enabled = true;
        }

        //funcionalidad del sistema
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Aux_Doctor aux_Doctor = new Aux_Doctor();
            aux_Doctor.Show();
        }

        

        void EliminarRegistro()
        {
            if (MessageBox.Show("Esta seguro de eliminar este registro??", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MedicosModel = new MedicosModel();
                MedicosModel.Id_Medico = int.Parse(Dtg_Base.SelectedCells[0].Value.ToString());
                if (new MedicoControl().EliminarMedico(MedicosModel) == true)
                {

                    MessageBox.Show("Registro Eliminado Exitosamente...");

                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar el registro");
                }

            }
            Btn_Eliminar.Enabled = false;


        }
    }
}
