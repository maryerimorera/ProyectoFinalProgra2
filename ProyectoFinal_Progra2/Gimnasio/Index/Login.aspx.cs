using Gimnasio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gimnasio.Index
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Clave_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Bingresar_Click(object sender, EventArgs e)
        {
            int tipousuario = Clases.Usuario.ValidarUsuario(Usuario.Text, Clave.Text);

            if (tipousuario == 1)
            {
                Response.Redirect("InicioAdmin.aspx");
            }
            else if (tipousuario == 4)
            {
                Response.Redirect("InicioCliente.aspx");
            }
            else
            {
                Page.RegisterStartupScript("UserMsg", "<script>alert('El usuario o la clave no son correctos'); if (alert) { windows.location = 'Login.aspx';} </script>");
            }
        }
    }
}