<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="Gimnasio.Index.Facturacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="/css/gridview.css"/>
    <link rel="stylesheet" href="/css/boton.css"/>
    <title>Facturacion</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
            height: 15px;
        }
        .auto-style3 {
            text-align: center;
            height: 15px;
            width: 315px;
        }
        .auto-style4 {
            text-align: center;
            width: 315px;
            height: 27px;
        }
        .auto-style5 {
            text-align: center;
            height: 27px;
        }
        .auto-style6 {
            color: #FFFFFF;
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;" border="2">
                <tr>
                    <td class="auto-style3">Codigo</td>
                    <td class="auto-style2"><strong>Producto</strong></td>
                    <td class="auto-style2"><strong>Cantidad</strong></td>
                    <td class="auto-style2"><strong>Precio</strong></td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        <asp:TextBox ID="tcodigo" runat="server" OnTextChanged="tcodigo_TextChanged" TextMode="Number"></asp:TextBox></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tcantidad" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tprecio" runat="server"></asp:TextBox>
                    </td>
                </tr>


                 <tr>
                    <td class="auto-style3">Codigo cliente</td>
                    <td class="auto-style2"><strong>Nombre Cliente</strong></td>
                    <td class="auto-style2"><strong>Fecha</strong></td>
                    <td class="auto-style2"><strong>Numero factura</strong></td>
                </tr>
                 <tr>
                    <td class="auto-style4">
                        <asp:TextBox ID="tcodigocliente" runat="server" OnTextChanged="tcodigo_TextChanged" TextMode="Number"></asp:TextBox>&nbsp;&nbsp;
                        </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="nombrecliente" runat="server"></asp:TextBox>
                     </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tfecha" runat="server" TextMode="Number" OnTextChanged="tfecha_TextChanged"></asp:TextBox></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tnumerofactura" runat="server"></asp:TextBox>
                     </td>
                </tr>

               
                
                
            </table>
        </div>
        
        <asp:Button ID="Button1" CssClass="button button2" runat="server" Text="INGRESAR" OnClick="Button1_Click" />
        <div> 
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" GridLines="None"
                AllowPaging="true" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt"
                PageSize="7" >
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                    <asp:BoundField DataField="Precio" HeaderText="Precio" />
                    <asp:BoundField DataField="Subtotal" HeaderText="Subtotal" />
                </Columns>
            </asp:GridView>
        </div>

        <div>
            <table style="width: 100%;" border="1">
                <tr>
                    <td class="auto-style1"><strong>SUBTOTAL</strong></td>
                    <td class="auto-style1"><strong>IVA</strong></td>
                    <td class="auto-style1"><strong>TOTAL</strong></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="LSB" runat="server" Font-Size="Large" Text="0"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="LIVA" runat="server" Font-Size="Large" Text="0"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="LTOTAL" runat="server" Font-Size="Large" Text="0"></asp:Label>
                    </td>
                    
                </tr>
                
            </table>
        </div>

        <asp:Button ID="Bfacturar" CssClass="button button3" runat="server" Text="FACTURAR" OnClick="Bfacturar_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="Bregresar" runat="server" BackColor="#009933" BorderColor="#009933" BorderStyle="None" CssClass="auto-style6" Height="51px" OnClick="Bregresar_Click" Text="REGRESAR" Width="148px" />
        <br />
        <br />

      
    </form>
</body>
</html>