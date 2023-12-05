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
    internal class MedicoControl
    {

        public bool CrearMedico(MedicosModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into MEDICOS(" +
                        "ID_MEDICO," +
                        "PRIMER_NOMBRE," +
                        "SEGUNDO_NOMBRE," +
                        "PRIMER_APELLIDO," +
                        "SEGUNDO_APELLIDO," +
                        "ID_USUARIO," +
                        "CREDENCIALES," +
                        "ID_HORARIO," +
                        "TELEFONO," +
                        "ID_ESPECIALIDAD," +
                        ") select" +
                        " '" + Modelo.Id_Medico + "'," +
                        " '" + Modelo.Primer_Nombre + "'," +
                        " '" + Modelo.Segundo_Nombre + "'," +
                        " '" + Modelo.Primer_Apellido + "'," +
                        " '" + Modelo.Segundo_Apellido + "'," +
                        " '" + Modelo.Id_Usuario + "'," +
                        " '" + Modelo.Credenciales + "'," +
                        " '" + Modelo.Id_Horario + "'," +
                        " '" + Modelo.Telefono + "'," +
                        " '" + Modelo.Id_Especialidad + "'";

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


        public bool UpdateMedico(MedicosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE MEDICOS SET " +
                        "PRIMER_NOMBRE =         '" + Modelo.Primer_Nombre + "'," +
                        "SEGUNDO_NOMBRE =        '" + Modelo.Segundo_Nombre + "', " +
                        "PRIMER_APELLIDO =       '" + Modelo.Primer_Apellido + "'" +
                        "SEGUNDO_APELLIDO =      '" + Modelo.Segundo_Apellido + "'" +
                        "ID_USUARIO =            '" + Modelo.Id_Usuario + "'" +
                        "CREDENCIALES =          '" + Modelo.Credenciales + "'" +
                        "ID_HORARIO =            '" + Modelo.Id_Horario + "'" +
                        "TELEFONO =              '" + Modelo.Telefono + "'" +
                        "ID_ESPECIALIDAD =       '" + Modelo.Id_Especialidad + "'" +
                        " WHERE ID_MEDICO =      '" + Modelo.Id_Medico + "';";


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

        public void ListarMedico()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from MEDICOS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MedicosModel.GetMedico = dt;

        }
        public bool EliminarMedico(MedicosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM MEDICOS WHERE ID_MEDICO = '" + Modelo.Id_Medico + "';";


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
