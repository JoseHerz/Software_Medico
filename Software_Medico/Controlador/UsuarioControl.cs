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
    internal class UsuarioControl
    {


        public bool CrearUser(UsuarioModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into USUARIOS(" +
                 
                        "NOMBRE," +
                        "APELLIDO," +
                        "CORREO_ELECTRONICO," +
                        "CLAVE," +
                        "ID_USUARIO_ROL," +
                        "ESTATUS," +
                        "HUELLA" +
                        ") select" +
                     
                        " '" + Modelo.Nombre + "'," +
                        " '" + Modelo.Apellido + "'," +
                        " '" + Modelo.Correo_Electronico + "'," +
                        " '" + Modelo.Clave + "'," +
                        " '" + Modelo.Id_Usuario_Rol + "'," +
                        " '" + Modelo.Estatus + "'," +
                        " '" + Modelo.Huella + "'";

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
        public bool ValidUser(UsuarioModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from USUARIOS Where ID_USUARIO = @Iduser";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Iduser", Modelo.Id_Usuario);
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

        public bool UpdateUser(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE USUARIOS SET " +
                        "NOMBRE =                      '" + Modelo.Nombre + "'," +
                        "APELLIDO =                    '" + Modelo.Apellido + "', " +
                        "CORREO_ELECTRONICO =          '" + Modelo.Correo_Electronico + "'" +
                        "CLAVE =                       '" + Modelo.Clave + "'" +
                        "ID_USUARIO_ROL =              '" + Modelo.Id_Usuario_Rol + "'" +
                        "ESTATUS =                     '" + Modelo.Estatus + "'" +
                        "HUELLA =                      '" + Modelo.Huella + "'" +
                        " WHERE ID_USUARIO =           '" + Modelo.Id_Usuario + "';";


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

        public void ListarUser()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from USUARIOS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UsuarioModel.GetUsuario = dt;

        }
        public bool EliminarUser(UsuarioModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM USUARIOS WHERE ID_USUARIO = '" + Modelo.Id_Usuario + "';";


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


        public DataTable CargarRolCMB()
        {
            DataTable dt = new DataTable();
            SqlConnection Con = new Conexion().GetConexion();
            Con.Open();
            string sql = "Select ID_USUARIO_ROL,DESCRIPCION from USUARIO_ROL ";


            SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
            adaptador.Fill(dt);

            return dt;


        }







        public Boolean ActualizaHuellaUsuarios(string IdUsuario, DPFP.Template Huella)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();

                    byte[] ImagenHuella = Huella.Bytes;

                    string Qry = "update Usuarios set HUELLA = @HUELLA where ID_USUARIO = '" + IdUsuario + "'";
                    using (SqlCommand cmd = new SqlCommand(Qry, Con))
                    {
                        cmd.Parameters.Add("@Huella", SqlDbType.VarBinary).Value = ImagenHuella;
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }



        public UsuarioModel ConsultaUsuario(int IdUsuario)
        {
            try
            {
                UsuarioModel Modelo = new UsuarioModel();
                Modelo.Id_Usuario = IdUsuario;

                using (SqlConnection Con = new Conexion().GetConexion())
                {

                    Con.Open();

                    string qry = "select * from Usuario where ID_USUARIO =" + IdUsuario;
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataReader Datos = cmd.ExecuteReader();
                        if (Datos.HasRows)
                        {
                            while (Datos.Read())
                            {
                                Modelo.Nombre = Datos.GetString(Datos.GetOrdinal("NOMBRE"));
                                Modelo.Apellido = Datos.GetString(Datos.GetOrdinal("APELLIDO"));
                                Modelo.Clave = Datos.GetString(Datos.GetOrdinal("CLAVE"));
                                Modelo.Id_Usuario_Rol = Datos.GetInt32(Datos.GetOrdinal("ID_USUARIO_ROL"));
                                Modelo.Correo_Electronico = Datos.GetString(Datos.GetOrdinal("CORREO_ELECTRONICO"));
                                Modelo.Estatus = Datos.GetBoolean(Datos.GetOrdinal("ESTATUS"));
                              

                            }
                        }



                        //Datos.Fill(dt);

                    }
                    Con.Close();
                    return Modelo;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
