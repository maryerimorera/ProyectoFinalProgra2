<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cuenta.aspx.cs" Inherits="Gimnasio.Index.Cuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #FFFFFF;
        }
        .auto-style2 {
            background-color: #CCCCFF;
        }
        .auto-style3 {
            font-family: Forte;
            font-size: xx-large;
        }
        .auto-style4 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            background-color: #CCCCFF;
        }
        .auto-style6 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <span class="auto-style3">CUENTA PERSONAL</span><br />
        <br />
        <span class="auto-style4"><strong>Correo: </strong></span><strong>
        <asp:TextBox ID="Tusuario" runat="server" CssClass="auto-style5" Width="128px"></asp:TextBox>
        <br class="auto-style4" />
        </strong><span class="auto-style4"><strong>Clave: </strong></span>
        <asp:TextBox ID="TClave" runat="server" CssClass="auto-style2"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Bcuenta" runat="server" BackColor="#009999" CssClass="auto-style1" Height="46px" OnClick="Bcuenta_Click" Text="Consultar Cuenta" Width="175px" />
        <br />
        <p>
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="auto-style6" Height="173px" Width="568px">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Bregresar" runat="server" BackColor="#6699FF" BorderColor="#3399FF" CssClass="auto-style1" Height="49px" OnClick="Bregresar_Click" Text="Regresar" Width="133px" />
        </p>
    </form>
</body>
</html>
