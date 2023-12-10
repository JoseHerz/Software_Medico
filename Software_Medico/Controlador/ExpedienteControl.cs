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

        public void ListarExpe(int idpac)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    string sql = "select ex.ID_EXPEDIENTE,c.FECHA_CITA AS FECHA, CONCAT(p.NOMBRE,' ',p.APELLIDO) AS NOMBRE_PACIENTE,CONCAT(d.PRIMER_NOMBRE,' ',d.PRIMER_APELLIDO) as NOMBRE_MEDICO,ex.DESCRIPCION,pa.NOMBRE_PATOLOGIA as ENFERMEDAD,ex.DIAGNOSTICO,exx.NOMBRE_EXAMEN as EXAMENES,ex.RESULTADO_EXAMEN as RESULTADO,m.NOMBRE_PRODUCTO as MEDICAMENTO,ex.CANTIDAD,ex.INSTRUCCIONES,CONCAT(us.NOMBRE,' ',us.APELLIDO) AS REGISTRO_USUARIO from EXPEDIENTE_CLINICO ex INNER JOIN PACIENTES p ON ex.ID_PACIENTE = p.ID_PACIENTE INNER JOIN MEDICOS d ON ex.ID_MEDICO = d.ID_MEDICO INNER JOIN PATOLOGIAS pa ON ex.ID_PATOLOGIA = pa.ID_PATOLOGIA INNER JOIN EXAMENES exx ON ex.ID_EXAMENES = exx.ID_EXAMENES INNER JOIN USUARIOS us ON ex.ID_USUARIO = us.ID_USUARIO INNER JOIN PRODUCTOS m ON ex.ID_PRODUCTO = m.ID_PRODUCTO INNER JOIN CITAS c ON ex.ID_CITA = c.ID_CITA where ex.ID_PACIENTE = @idpac";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@idpac", idpac);

                        SqlDataAdapter adaptador = new SqlDataAdapter(cmd); // Utiliza el comando cmd en lugar de la cadena sql
                        adaptador.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ExpedienteModel.GetExpediente = dt;

        }


        public DataTable CargarPatologiaCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "Select ID_PATOLOGIA,NOMBRE_PATOLOGIA from PATOLOGIAS ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }


        public DataTable CargarExamenCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "Select ID_EXAMENES,NOMBRE_EXAMEN from EXAMENES ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }


        public DataTable CargarMedicameMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "SELECT ID_PRODUCTO,NOMBRE_PRODUCTO FROM PRODUCTOS WHERE ID_TIPO_INVENTARIO =1 ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }




    }
}
