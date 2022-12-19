using Gimnasio.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gimnasio.Index
{
    public partial class Cliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        ClsCliente Clientes = new ClsCliente();

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["GIMNASIOConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CODIGO, NOMBRE, APELLIDO, TELEFONO FROM CLIENTES"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void Bregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioAdmin.aspx");
        }

        protected void Bagregar_Click(object sender, EventArgs e)
        {
            Clientes.Insertar(NombreA.Text, ApellidoA.Text, TelefonoA.Text);
        }

        protected void Bmodificar_Click(object sender, EventArgs e)
        {
            Clientes.Editar(int.Parse(CodigoM.Text), NombreM.Text, ApellidoM.Text, TelefonoM.Text);
        }

        protected void Beliminar_Click(object sender, EventArgs e)
        {
            Clientes.Eliminar(int.Parse(CodigoE.Text));
        }
    }
}