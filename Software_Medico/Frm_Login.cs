﻿using Software_Medico.Controlador;
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

        
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            
            Frm_Menu frm_Menu = new Frm_Menu();
            frm_Menu.Show();

            this.Hide();
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
