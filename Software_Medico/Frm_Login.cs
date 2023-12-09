using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Medico
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        //cuando se incorpore la validacion con la base de datos se condiciona el Frm_Menu 
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            
            Frm_Menu frm_Menu = new Frm_Menu();
            frm_Menu.Show();

            this.Hide();
        }
    }
}
