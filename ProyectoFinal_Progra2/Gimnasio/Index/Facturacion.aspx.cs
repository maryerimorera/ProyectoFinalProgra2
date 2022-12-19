using Gimnasio.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gimnasio.Index
{
    public partial class Facturacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Codigo"), new DataColumn("Nombre"), new DataColumn("cantidad"), new DataColumn("Precio"), new DataColumn("Subtotal") });
                ViewState["Factura"] = dt;
                this.BindGrid();

            }

        }

        protected void Bfacturar_Click(object sender, EventArgs e)
        {
            ClsFacturacion.total = float.Parse(LTOTAL.Text);
            ClsFacturacion.cliente = int.Parse(tcodigocliente.Text);

            if (ClsFacturacion.AgregarMaestroFactura() > 0)
            {
                int linea = 0;
                foreach (GridViewRow item in GridView1.Rows)
                {

                    int codigo = int.Parse(item.Cells[0].Text);
                    int cantidad = int.Parse(item.Cells[2].Text);
                    float precio = float.Parse(item.Cells[3].Text);
                    linea++;
                    if (ClsFacturacion.AgregarDetalleFactura(linea, codigo, cantidad, precio) > 0)
                    {

                    }

                }
                DataTable ds = new DataTable();
                ds = null;
                GridView1.DataSource = ds;
                GridView1.DataBind();

            }

        }


        protected void BindGrid()
        {
            GridView1.DataSource = (DataTable)ViewState["Factura"];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)ViewState["Factura"];
                float sb = (float.Parse(tcantidad.Text) * float.Parse(tprecio.Text));
                ViewState["Subtotal"] = (float.Parse(tcantidad.Text) * float.Parse(tprecio.Text));
                dt.Rows.Add(tcodigo.Text.Trim(), tnombre.Text.Trim(), tcantidad.Text.Trim(), tprecio.Text.Trim(), ViewState["Subtotal"]);
                ViewState["Factura"] = dt;
                this.BindGrid();

                ViewState["subtotal"] = (float.Parse(LSB.Text) + sb);
                LSB.Text = (ViewState["subtotal"]).ToString();
                ViewState["IVA"] = (float.Parse(LSB.Text) * 0.13);
                LIVA.Text = (ViewState["IVA"]).ToString();
                ViewState["total"] = (float.Parse(LSB.Text) + float.Parse(LIVA.Text));
                LTOTAL.Text = (ViewState["total"]).ToString();

                tcodigo.Focus();
                tcodigo.Text = "";
                tnombre.Text = "";
                tcantidad.Text = "";
                tprecio.Text = "";


            }
            catch (Exception)
            {


            }


            finally
            {


            }
        }

        

        protected void tcodigo_TextChanged(object sender, EventArgs e)
        {

            if (ClsProducto.BuscarProducto(tcodigo.Text) > 0)
            {
                tnombre.Text = ClsProducto.nombre;
                tprecio.Text = ClsProducto.precio.ToString();
                tcantidad.Focus();

            }


        }

        protected void Bregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioAdmin.aspx");
        }

        protected void tnombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tfecha_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tnumerofactura_TextChanged(object sender, EventArgs e)
        {

        }
    }

}