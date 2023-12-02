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
        public Aux_Paciente()
        {
            InitializeComponent();
        }

        //condicion de si hay seguro medico
        private void Chk_TSMedico_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TSMedico.Checked)
            {
                // Si el CheckBox está marcado, bloquear el TextBox y el ComboBox
                Cmb_Seguro.Enabled = false; 
                Txt_NSmedico.Enabled = false;
            }
            else
            {
                // Si el CheckBox no está marcado, desbloquear el TextBox y el ComboBox
                Cmb_Seguro.Enabled = true;
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
