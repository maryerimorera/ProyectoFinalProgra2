<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InicioAdmin.aspx.cs" Inherits="Gimnasio.Index.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="/Css/Menu.css"/>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style type="text/css">
         .auto-style1 {
             font-family: Candara;
             font-size: 60px;
         }
         .auto-style2 {
             font-size: x-large;
         }
         .auto-style3 {
             left: 0px;
             top: 0px;
             width: 628px;
         }
     </style>
</head>
<body>

    <p class="auto-style2">
        <span lang="EN-US">Gimnasio PowerFitness<o:p></o:p></span></p>

    <h1 class="auto-style1">Gimnasio Power Fitness</h1>
    <form id="form1" runat="server" />
    <nav class="auto-style3">

        <asp:HyperLink ID="Linicio" runat="server" NavigateUrl="InicioAdmin.aspx" Text="INICIO" />
        <asp:HyperLink ID="Lclientes" runat="server" NavigateUrl="Cliente.aspx" Text="CLIENTES" />
        <asp:HyperLink ID="Lfacturacion" runat="server" NavigateUrl="Facturacion.aspx" Text="FACTURACION" />
        <asp:HyperLink ID="Lhistorial" runat="server" NavigateUrl="Historial.aspx" Text="HISTORIAL" />
        <asp:HyperLink ID="Lsalir" runat="server" NavigateUrl="Login.aspx" Text="SALIR" />
        <div class="animation start-home"></div>
    </nav>

    <p>
        &nbsp;</p>
    </form>
    <p>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </p>
    <p>
</body>
</html>
