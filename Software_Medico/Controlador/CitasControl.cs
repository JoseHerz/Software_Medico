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
    internal class CitasControl
    {

        public bool CrearCita(CitasModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into CITAS(" +
                        "ID_CITA," +
                        "ID_MEDICO," +
                        "ID_PACIENTE," +
                        "FECHA_HORA_CITA," +
                        "FECHA_CITA," +
                        "DNI," +
                        "HORAINICIAL_CITA," +
                        "HORAFINAL_CITA," +
                        "DURACION," +
                        "ESTADO_CITA," +
                        "ID_TIPO_CITA," +
                        "ID_CLINICA," +
                        "ID_CONSULTORIO," +
                        "OBSERVACIONES," +
                        "ID_USUARIO" +
                        ") select" +
                        " '" + Modelo.Id_Cita+ "'," +
                        " '" + Modelo.Id_Medico + "'," +
                        " '" + Modelo.Id_Paciente + "'," +
                        " '" + Modelo.Fecha_Hora_Cita + "'," +
                        " '" + Modelo.Fecha_Cita + "'," +
                        " '" + Modelo.Dni + "'," +
                        " '" + Modelo.HoraIni_Cita + "'," +
                        " '" + Modelo.HoraFin_Cita + "'," +
                        " '" + Modelo.Duracion + "'," +
                        " '" + Modelo.Estado_Cita + "'," +
                        " '" + Modelo.Id_Tipo_Cita + "'," +
                        " '" + Modelo.Id_Clinica + "'," +
                        " '" + Modelo.Id_Consultorio + "'," +
                        " '" + Modelo.Observacion + "'," +
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
        public bool ValidCita(CitasModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from CITAS Where ID_CITA = @Idcita";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Idcita", Modelo.Id_Cita);
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            existeDuplicado = true;
                        }

                    }

                    Con.Close();


                }

                return existeDuplicado;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Existe duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return existeDuplicado;
            }



        }

        public bool UpdateCita(CitasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE CITAS SET " +
                        "ID_MEDICO =        '" + Modelo.Id_Medico + "'," +
                        "ID_PACIENTE =      '" + Modelo.Id_Paciente + "', " +
                        "FECHA_HORA_CITA =  '" + Modelo.Fecha_Hora_Cita + "'" +
                        "FECHA_CITA =       '" + Modelo.Fecha_Cita + "'" +
                        "DNI =              '" + Modelo.Dni + "'" +
                        "HORAINICIAL_CITA = '" + Modelo.HoraIni_Cita + "'" +
                        "HORAFINAL_CITA =   '" + Modelo.HoraFin_Cita + "'" +
                        "DURACION =         '" + Modelo.Duracion + "'" +
                        "ESTADO_CITA =      '" + Modelo.Estado_Cita + "'" +
                        "ID_TIPO_CITA =     '" + Modelo.Id_Tipo_Cita + "'" +
                        "ID_CLINICA =       '" + Modelo.Id_Clinica + "'" +
                        "ID_CONSULTORIO =   '" + Modelo.Id_Consultorio + "'" +
                        "OBSERVACIONES =    '" + Modelo.Observacion + "'" +
                        "ID_USUARIO =       '" + Modelo.Id_Usuario + "'" +
                        " WHERE ID_CITA =   '" + Modelo.Id_Cita + "';";


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

        public void ListarCita()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from CITAS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CitasModel.GetCitas = dt;

        }
        public bool EliminarCita(CitasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM CITAS WHERE ID_CITA = '" + Modelo.Id_Cita + "';";


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


        public string buscarNombre(string idpa)
        {

            using (SqlConnection Con = new Conexion().GetConexion())
            {
                Con.Open();
                string sql = "SELECT CONCAT(NOMBRE,' ',APELLIDO) AS NOMBRE_COMPLETO FROM PACIENTES WHERE ID_PACIENTE = @idpac";

                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    cmd.Parameters.AddWithValue("@idpac", idpa);
                    string nombre = (string)cmd.ExecuteScalar();
                    if (nombre != null)
                    {
                        return nombre;
                    }
                    else
                    {
                        return nombre = "Paciente no encontrado";
                    }


                }

                Con.Close();

            }
            
        }


    }
}
