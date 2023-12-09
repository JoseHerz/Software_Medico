using Software_Medico.Controlador;
using Software_Medico.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Medico
{
    public partial class Frm_Menu : Form
    {
        private Conexion conexion = new Conexion();


        public Frm_Menu()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.Pnl_Contenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //funcionalidad de los botones minimizar, maximizar y cerrar.
        private void Ptb_Cerrar_Click(object sender, EventArgs e)
        {
                // Cierra la ventana actual
                this.Close();
        }

        //private void Ptb_Resize_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    Ptb_Resize.Visible = false;
        //    Ptb_Max.Visible = true;
        //}


        //private void Ptb_Max_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //    Ptb_Max.Visible = false;
        //    Ptb_Resize.Visible = true;
        //}

        private void Ptb_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //funcionalidad de los botones principales
        private void Btn_Enfermedades_Click(object sender, EventArgs e)
        {
            Frm_Enfermedades frmEnfermedades = new Frm_Enfermedades();
            frmEnfermedades.Show();
        }
        private void Btn_Doctores_Click(object sender, EventArgs e)
        {
            Frm_Doctores frm_Doctores = new Frm_Doctores();
            frm_Doctores.Show();
        }

        private void Btn_Paciente_Click(object sender, EventArgs e)
        {
            Frm_Paciente frm_Paciente = new Frm_Paciente();
            frm_Paciente.Show();
        }

        private void Btn_Examenes_Click(object sender, EventArgs e)
        {
            Frm_Examenes frm_Examenes = new Frm_Examenes();
            frm_Examenes.Show();
        }
        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            Frm_Inventario frm_Inventariocs = new Frm_Inventario();
            frm_Inventariocs.Show();
        }
        private void Btn_Facturacion_Click(object sender, EventArgs e)
        {
            Frm_Facturacion frm_Facturacion = new Frm_Facturacion();
            frm_Facturacion.Show();
        }

        private void Btn_Cita_Click(object sender, EventArgs e)
        {
            Frm_Cita frm_Cita = new Frm_Cita();
            frm_Cita.Show();
        }

        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            Frm_LogOut frm_LogOut = new Frm_LogOut();
            frm_LogOut.Show();
        }

        //Funcionalidad de la ventana
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
        
        
            //Prueba de conexion, esta solo se genera un boton y se pone dicho codigo
            //instancia de clase conexion
            //SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString); 
            
            //conexion.Open();

            //MessageBox.Show("Conexion exitosa");

            //conexion.Close();
        
    }
}
