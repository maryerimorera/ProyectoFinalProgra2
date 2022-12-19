using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Gimnasio.Clases
{
    public class ClsCliente
    {
        private DBConn conexion = new DBConn();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void Insertar(string nombre, string apellido, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERTAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NOMBRE", nombre);
            comando.Parameters.AddWithValue("@APELLIDO", apellido);
            comando.Parameters.AddWithValue("@TELEFONO", telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(int codigo, string nombre, string apellido, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ACTUALIZAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            comando.Parameters.AddWithValue("@NOMBRE", nombre);
            comando.Parameters.AddWithValue("@APELLIDO", apellido);
            comando.Parameters.AddWithValue("@TELEFONO", telefono);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int codigo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BORRAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CODIGO", codigo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}