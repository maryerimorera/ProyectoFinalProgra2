<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="Gimnasio.Index.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 570px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 335px;
        }
        .auto-style5 {
            height: 343px;
            margin-top: 92px;
        }
        .auto-style6 {
            width: 335px;
            height: 47px;
            text-align: left;
        }
        .auto-style8 {
            height: 47px;
            text-align: left;
            width: 367px;
        }
        .auto-style9 {
            width: 335px;
            height: 28px;
        }
        .auto-style11 {
            height: 28px;
            width: 367px;
        }
        .auto-style12 {
            width: 367px;
        }
        .auto-style13 {
            width: 331px;
        }
        .auto-style14 {
            width: 331px;
            height: 28px;
        }
        .auto-style15 {
            width: 331px;
            height: 47px;
            text-align: left;
        }
        .auto-style16 {
            font-weight: bold;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">

            CLIENTES<br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style4">AGREGAR</td>
                    <td class="auto-style13">MODIFICAR</td>
                    <td class="auto-style12">ELIMINAR</td>
                </tr>
                <tr>
                    <td class="auto-style4">Nombre
                        <asp:TextBox ID="NombreA" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style13">Ingrese el codigo
                        <asp:TextBox ID="CodigoM" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">Ingrese el codigo
                        <asp:TextBox ID="CodigoE" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Apellido
                        <asp:TextBox ID="ApellidoA" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style13">Nombre
                        <asp:TextBox ID="NombreM" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Telefono
                        <asp:TextBox ID="TelefonoA" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style13">Apellido
                        <asp:TextBox ID="ApellidoM" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style14">Telefono
                        <asp:TextBox ID="TelefonoM" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Button ID="Bagregar" runat="server" BackColor="#CC99FF" OnClick="Bagregar_Click" Text="Agregar" />
                    </td>
                    <td class="auto-style15">
                        <asp:Button ID="Bmodificar" runat="server" BackColor="#CC99FF" OnClick="Bmodificar_Click" Text="Modificar" />
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="Beliminar" runat="server" BackColor="#CC99FF" OnClick="Beliminar_Click" Text="Eliminar" />
                    </td>
                </tr>
            </table>
            <div class="auto-style5">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="189px" Width="474px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
                <br />
                <br />
                <br />
                <br />
                <strong>
                <asp:Button ID="Bregresar" runat="server" BackColor="#FF0066" BorderStyle="None" CssClass="auto-style16" ForeColor="White" Height="44px" OnClick="Bregresar_Click" Text="REGRESAR" Width="125px" />
                </strong>
            </div>

        </div>
    </form>
</body>
</html>
