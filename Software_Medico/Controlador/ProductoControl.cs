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
    internal class ProductoControl
    {

        public bool CrearProducto(ProductoModel Modelo)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "Insert Into PRODUCTOS(" +
                        "ID_PRODUCTO," +
                        "NOMBRE_PRODUCTO," +
                        "CANTIDAD," +
                        "UNIDAD_MEDIDA," +
                        "FECHA_CADUCIDAD," +
                        "PRECIO_UNITARIO," +
                        "UBICACION," +
                        "ID_TIPO_INVENTARIO," +
                        "ESTATUS," +
                        "INDICACIONES" +
                        ") select" +
                        " '" + Modelo.Id_Producto + "'," +
                        " '" + Modelo.Nombre_Producto + "'," +
                        " '" + Modelo.Cantidad + "'," +
                        " '" + Modelo.Unidad_Medida + "'," +
                        " '" + Modelo.Fecha_Caducidad + "'," +
                        " '" + Modelo.Precio_Unitario + "'," +
                        " '" + Modelo.Ubicacion + "'," +
                        " '" + Modelo.Id_Tipo_Inventario + "'," +
                        " '" + Modelo.Estatus + "'," +
                        " '" + Modelo.Indicaciones + "'";

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
        public bool ValidProducto(ProductoModel Modelo)
        {
            bool existeDuplicado = false;
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "Select Count (*) from PRODUCTOS Where ID_PRODUCTO = @Idproduc";

                    using (SqlCommand cmd = new SqlCommand(sql, Con))
                    {
                        cmd.Parameters.AddWithValue("@Idproduc", Modelo.Id_Producto);
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

        public bool UpdateProducto(ProductoModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql =
                        "UPDATE PRODUCTOS SET " +
                        "NOMBRE_PRODUCTO =              '" + Modelo.Nombre_Producto + "'," +
                        "CANTIDAD =                     '" + Modelo.Cantidad + "', " +
                        "UNIDAD_MEDIDA =                '" + Modelo.Unidad_Medida + "'" +
                        "FECHA_CADUCIDAD =              '" + Modelo.Fecha_Caducidad + "'" +
                        "PRECIO_UNITARIO =              '" + Modelo.Precio_Unitario + "'" +
                        "UBICACION =                    '" + Modelo.Ubicacion + "'" +
                        "ID_TIPO_INVENTARIO =           '" + Modelo.Id_Tipo_Inventario + "'" +
                        "ESTATUS =                      '" + Modelo.Estatus + "'" +
                        "INDICACIONES =                 '" + Modelo.Indicaciones + "'" +
                        " WHERE ID_PRODUCTO =           '" + Modelo.Id_Producto + "';";


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

        public void ListarProducto()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection Con = new Conexion().GetConexion();
                Con.Open();
                string sql = "Select * from PRODUCTOS";
                SqlDataAdapter adaptador = new SqlDataAdapter(sql, Con);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProductoModel.GetProducto = dt;

        }
        public bool EliminarProducto(ProductoModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConexion())
                {
                    Con.Open();
                    string sql = "DELETE FROM PRODUCTOS WHERE ID_PRODUCTO = '" + Modelo.Id_Producto + "';";


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
