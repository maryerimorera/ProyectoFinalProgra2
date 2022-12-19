using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.UI.WebControls;

namespace Gimnasio.Clases
{
    public class ClsFacturacion
    {
        DBConn conexion = new DBConn();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public static int codigoFactura { get; set; }
        public static float total { get; set; }
        public static int linea { get; set; }
        public static int cantidad { get; set; }
        public static float precio { get; set; }
        public static int cliente { get; set; }
        public static string fecha { get; set; }

        public static int AgregarDetalleFactura(int nfactura, int codigo_producto, int cantidad, float precio_unitario)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBConn.AbrirConexionn())
                {
                    SqlCommand cmd = new SqlCommand("DETALLE_FACTURA", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@NFACTURA", nfactura));
                    cmd.Parameters.Add(new SqlParameter("@CODIGO_PRODUCTO", codigo_producto));
                    cmd.Parameters.Add(new SqlParameter("@CANTIDAD", cantidad));
                    cmd.Parameters.Add(new SqlParameter("@PRECIO_UNITARIO", precio_unitario));


                    retorno = cmd.ExecuteNonQuery();

                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int AgregarMaestroFactura()
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();

            try
            {
                using (Conn = DBConn.AbrirConexionn())
                {
                    SqlCommand cmd = new SqlCommand("MAE_FACTURAA", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO_CLIENTE", cliente));
                    cmd.Parameters.Add(new SqlParameter("@TOTAL", total));
                    cmd.Parameters.Add(new SqlParameter("@FECHA", fecha));


                    retorno = cmd.ExecuteNonQuery();

                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public DataTable ConsultarFacturas()
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECCIONAR_FACTURAS";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}