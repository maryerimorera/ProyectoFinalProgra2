using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Gimnasio.Clases;
using System.Configuration;

namespace Gimnasio.Index
{
    public partial class Cuenta : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        Usuario usuario = new Usuario();
       
        protected void Bcuenta_Click(object sender, EventArgs e)
        {
           
            GridView1.DataSource = usuario.ConsultarCuenta(Tusuario.Text, TClave.Text);
            GridView1.DataBind();
        }

        protected void Bregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioCliente.aspx");
        }
    }
}