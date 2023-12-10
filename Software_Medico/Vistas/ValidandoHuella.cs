using DPFP;
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
using Software_Medico.Controlador;

namespace Software_Medico.Vistas
{
    public partial class ValidandoHuella : CaptureForm
    {
        private DPFP.Verification.Verification Verificator;
        UsuarioControl Con;
        UsuarioModel Usuario = new UsuarioModel();
        public Frm_Login Logueando;
        public ValidandoHuella()
        {
            InitializeComponent();
        }

        //Sobreescribiendo el Metodo Init
        protected override void Init()
        {
            base.Init();
            base.Text = "Verificacion de Huella";
            Verificator = new DPFP.Verification.Verification();
            UpdateStatus(0);
        }

        private void UpdateStatus(int Far)
        {
            SetStatus(String.Format("False Accept Rate FAR = {0} ", Far));
        }

        //Sobreescribiendo el Metodo Process
        protected override void Process(Sample Sample)
        {
            base.Process(Sample);
            try
            {
                FeatureSet feature = new FeatureSet();

                feature = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

                if (feature != null)
                {
                    DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                    Template template = new Template();
                    Byte[] Huella = null;

                    foreach (DataRow Fila in UsuarioModel.GetUsuario.Rows)
                    {
                        if (Fila["Huella"].ToString().Length > 0)
                        {
                            Huella = (Byte[])Fila["Huella"];

                            if (Huella.Length > 100)
                            {
                                template.DeSerialize(Huella);
                                Verificator.Verify(feature, template, ref result);

                                UpdateStatus(result.FARAchieved);

                                if (result.Verified)
                                {
                                    MakeReport("Huella ha sido Verificada correctamente");
                                    //MessageBox.Show("Huella ha sido verificada Correctamente" + Fila["IdUsuario"]);
                                    Logueando.AsignandoValoresDeHuella(Fila["ID_USUARIO"].ToString(), Fila["CLAVE"].ToString());
                                    feature = null;
                                    template = null;
                                    Stop();
                                    this.Close();
                                    break;
                                }
                                /*else
                                {
                                    //MakeReport("Huella para este Usuario es incorrecta..!!");
                                    //MessageBox.Show("Huella no ha sido verificada Correctamente");

                                }*/
                            }

                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Este es el Numero de Error: " + e.HResult + "-" + e.Message);
            }
        }
    }
}
