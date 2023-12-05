using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Medico.Modelo;

namespace Software_Medico.Controlador
{
    internal class PacienteControl
    {
        public bool CrearPaciente(PacienteModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Insert Into PACIENTES(" +
                        "ID_PACIENTE," +
                        "NOMBRE," +
                        "APELLIDO," +
                        "FECHA_NACIMIENTO," +
                        "GENERO," +
                        "DIRECCION," +
                        "TELEFONO,EMAIL," +
                        "HISTORIA_MEDICA," +
                        "GRUPO_SANGUINEO," +
                        "ALERGIAS," +
                        "ENFERMEDADES_CRONICAS," +
                        "SEGURO_MEDICO," +
                        "NUMERO_SEGURO_MEDICO," +
                        "ESTATUS," +
                        "ID_USUARIO" +
                        ") select" +
                        " '" + Modelo.Id_Paciente + "'," +
                        " '" + Modelo.Nombre + "'," +
                        " '" + Modelo.Apellido + "'," +
                        " '" + Modelo.Fecha_Nacimiento + "'," +
                        " '" + Modelo.Genero + "'," +
                        " '" + Modelo.Direccion + "'," +
                        " '" + Modelo.Telefono + "'," +
                        " '" + Modelo.Email + "'," +
                        " '" + Modelo.Historia_Medica + "'," +
                        " '" + Modelo.Grupo_Sanguineo + "'," +
                        " '" + Modelo.Alergias + "'," +
                        " '" + Modelo.Enfermedades_Cronicas + "'," +
                        " '" + Modelo.Seguro_Medico + "'," +
                        " '" + Modelo.Numero_Seguro_Medico + "'," +
                        " '" + Modelo.Estatus + "'," +
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
        public bool ValidPaciente(PacienteModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from PACIENTES Where ID_PACIENTE = @IdPaciente or NOMBRE = @NomPaciente";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@IdPaciente", Modelo.Id_Paciente);
                        cmd.Parameters.AddWithValue("@NomPaciente", Modelo.Nombre);
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

        public bool UpdatePaciente(PacienteModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "UPDATE PACIENTES SET " +
                        "NOMBRE = '" + Modelo.Nombre + "'," +
                        "APELLIDO = '" + Modelo.Apellido + "', " +
                        "FECHA_NACIMIENTO = '" + Modelo.Fecha_Nacimiento + "'," +
                        "GENERO = '" + Modelo.Genero + "'" +
                        "DIRECCION = '" + Modelo.Direccion + "'" +
                        "TELEFONO = '" + Modelo.Telefono + "'" +
                        "EMAIL = '" + Modelo.Email + "'" +
                        "HISTORIA_MEDICA = '" + Modelo.Historia_Medica + "'" +
                        "GRUPO_SANGUINEO = '" + Modelo.Grupo_Sanguineo + "'" +
                        "ALERGIAS = '" + Modelo.Alergias + "'" +
                        "ENFERMEDADES_CRONICAS = '" + Modelo.Enfermedades_Cronicas + "'" +
                        "SEGURO_MEDICO = '" + Modelo.Seguro_Medico + "'" +
                        "NUMERO_SEGURO_MEDICO = '" + Modelo.Numero_Seguro_Medico + "'" +
                        "ID_USUARIO = '" + Modelo.Id_Usuario + "'" +
                        "ESTATUS = '" + Modelo.Estatus + "'" +
                        " WHERE ID_PACIENTE = '" + Modelo.Id_Paciente + "';";


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

        public void ListarPaciente()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from PACIENTES";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PacienteModel.GetPaciente = dt;

        }
        public bool EliminarPaciente(PacienteModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM PACIENTES WHERE ID_PACIENTE = '" + Modelo.Id_Paciente + "';";


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
