using Software_Medico.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Medico.Controlador
{
    internal class ExpedienteControl
    {
        public bool CrearExpediente(ExpedienteModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into EXPEDIENTE_CLINICO(" +
                        "ID_EXPEDIENTE," +
                        "ID_CITA," +
                        "ID_PACIENTE," +
                        "ID_MEDICO," +
                        "FECHA_INGRESO," +
                        "DESCRIPCION," +
                        "ID_PATOLOGIA," +
                        "DIAGNOSTICO," +
                        "ID_EXAMENES," +
                        "RESULTADO_EXAMEN," +
                        "ID_PRODUCTO," +
                        "CANTIDAD," +
                        "INSTRUCCIONES," +
                        "ID_USUARIO" +
                        ") select" +
                        " '" + Modelo.Id_Expediente + "'," +
                        " '" + Modelo.Id_Cita + "'," +
                        " '" + Modelo.Id_Paciente + "'," +
                        " '" + Modelo.Id_Medico + "'," +
                        " '" + Modelo.Fecha_Ingreso + "'," +
                        " '" + Modelo.Descripcion + "'," +
                        " '" + Modelo.Id_Patologia + "'," +
                        " '" + Modelo.Diagnostico + "'," +
                        " '" + Modelo.Id_Examenes + "'," +
                        " '" + Modelo.Resultado_Examen + "'," +
                        " '" + Modelo.Id_Producto + "'," +
                        " '" + Modelo.Cantidad + "'," +
                        " '" + Modelo.Instrucciones + "'," +
                        " '" + Modelo.Id_Usuario + "'";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }
 
                       
        public bool UpdateExpediente(ExpedienteModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE EXPEDIENTE_CLINICO SET " +
                        "ID_CITA =                  '" + Modelo.Id_Cita + "'," +
                        "ID_PACIENTE =              '" + Modelo.Id_Paciente + "', " +
                        "ID_MEDICO =                '" + Modelo.Id_Medico + "'" +
                        "FECHA_INGRESO =            '" + Modelo.Fecha_Ingreso + "'" +
                        "DESCRIPCION =              '" + Modelo.Descripcion + "'" +
                        "ID_PATOLOGIA =             '" + Modelo.Id_Patologia + "'" +
                        "DIAGNOSTICO =              '" + Modelo.Diagnostico + "'" +
                        "ID_EXAMENES =              '" + Modelo.Id_Examenes + "'" +
                        "RESULTADO_EXAMEN =         '" + Modelo.Resultado_Examen + "'" +
                        "ID_PRODUCTO =              '" + Modelo.Id_Producto + "'" +
                        "CANTIDAD =                 '" + Modelo.Cantidad + "'" +
                        "INSTRUCCIONES =            '" + Modelo.Instrucciones + "'" +
                        "ID_USUARIO =               '" + Modelo.Id_Usuario + "'" +
                        " WHERE ID_EXPEDIENTE =     '" + Modelo.Id_Expediente + "';";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }

        public void ListarExpediente(ExpedienteModel Modelo)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from EXPEDIENTE_CLINICO WHERE ID_PACIENTE ='" + Modelo.Id_Paciente + "';";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ExpedienteModel.GetExpediente = dt;

        }
        public bool EliminarExpediente(ExpedienteModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM EXPEDIENTE_CLINICO WHERE ID_EXPEDIENTE = '" + Modelo.Id_Expediente + "';";


                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {

                        cmd.ExecuteNonQuery();
                    }

                    Con.Close();


                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }





    }
}
