using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;


namespace Software_Medico.Vistas
{
    public partial class AgregandoHuella : CaptureForm
    {
        public delegate void OnTemplateEventHandler(DPFP.Template Template);
        public event OnTemplateEventHandler OnTemplate;
        private DPFP.Processing.Enrollment Enroller;
        public AgregandoHuella()
        {
            InitializeComponent();
        }

        //Sobreescribir el metodo Init de la clase CaptureForm
        protected override void Init()
        {
            base.Init();
            base.Text = "Dar de Alta a Huella de Usuario";
            Enroller = new DPFP.Processing.Enrollment();
            UpdateStatus();
        }

        //Conteo de la colocacion de la huella
        private void UpdateStatus()
        {
            SetStatus(String.Format("Finger Print Samples Nedeed : {0}", Enroller.FeaturesNeeded));
        }

        //Sobreescribir el Metodo Process de la clase CaptureForm
        protected override void Process(Sample Sample)
        {
            base.Process(Sample);

            DPFP.FeatureSet Feature = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            try
            {
                if (Feature != null) try
                    {
                        MakeReport("The finger Print Feature set was Create");
                        Enroller.AddFeatures(Feature);
                    }
                    finally
                    {
                        UpdateStatus();
                        switch (Enroller.TemplateStatus)
                        {
                            case DPFP.Processing.Enrollment.Status.Ready:
                                OnTemplate(Enroller.Template);
                                SetPrompt("Click Close, and the Finger verification.");
                                MessageBox.Show("Huella Capturada Exitosamente");
                                Stop();
                                this.Close();
                                break;
                            case DPFP.Processing.Enrollment.Status.Failed:
                                MessageBox.Show("Error al Capturar la huella");
                                Enroller.Clear();
                                Stop();
                                UpdateStatus();
                                OnTemplate(null);
                                Start();
                                break;

                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Capturar la Huella");
            }

        }

        private void AgregandoHuella_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
