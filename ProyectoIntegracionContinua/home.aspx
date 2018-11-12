<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="EjercicioResponsive.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css/bootstrap.min.css"
        rel="stylesheet"
        type="text/css" />
</head>

<body>



    <form id="form1" runat="server">
    <div style="height: 325px">
        Lista productos
        <br />
        <br />

        <br />
         <label >Nombre</label><asp:TextBox ID="nombre" runat="server" CssClass="form-control" Width="179px"></asp:TextBox>
        &nbsp;
        <br />
        <br />
      <label >Marca</label><asp:TextBox ID="marca" runat="server" CssClass="form-control" Width="179px"></asp:TextBox>
        <br />
        <br />
        <label>Precio</label>
        <asp:TextBox CssClass="form-control" ID="precio" runat="server" Width="181px"></asp:TextBox>
        <br />
        <br />
        <label >Descripcion</label>
        <asp:TextBox CssClass="form-control" ID="descripcion" runat="server" Width="173px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Insertar" runat="server" Text="Insertar" CssClass="btn btn-default" OnClick="Insertar_Click"  />

        <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="btn btn-default"  OnClick="Modificar_Click" />

        <asp:Button ID="Eliminar" runat="server" Text="Eliminar" CssClass="btn btn-default"  OnClick="Eliminar_Click" />

        <asp:Button ID="Consultar" runat="server" Text="Consultar" CssClass="btn btn-default"  OnClick="Consultar_Click" />
    </div>
    </form>
</body>
</html>
