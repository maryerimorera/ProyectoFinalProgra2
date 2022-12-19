using Gimnasio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gimnasio.Index
{
    public partial class Historial : System.Web.UI.Page
    {

        ClsFacturacion facturacion = new ClsFacturacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = facturacion.ConsultarFacturas();
            GridView1.DataBind();
        }
       
        protected void Bregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioAdmin.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}