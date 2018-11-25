<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="ProyectoIntegracionContinua.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link href="css/bootstrap.min.css"
        rel="stylesheet"
        type="text/css" />
<link rel="stylesheet" type="text/css" href="css/site.css">
     <title>Integraciòn Continua</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <style>

            /* Remove the navbar's default margin-bottom and rounded borders */
    .navbar {
      margin-bottom: 0;
      border-radius: 0;
    }

    /* Set height of the grid so .sidenav can be 100% (adjust as needed) */
    .row.content {height: 450px}

    /* Set gray background color and 100% height */
    .sidenav {
      padding-top: 20px;
      background-color: #f1f1f1;
      height: 100%;
    }

    /* Set black background color, white text and some padding */
    footer {
      background-color: #555;
      color: white;
      padding: 15px;
    }

    /* On small screens, set height to 'auto' for sidenav and grid */
    @media screen and (max-width: 767px) {
      .sidenav {
        height: auto;
        padding: 15px;
      }
      .row.content {height:auto;}
    }

    .header {
    color: #36A0FF;
    font-size: 27px;
    padding: 10px;
}

.bigicon {
    font-size: 35px;
    color: #36A0FF;
}

    </style>

</head>




<body>
    <nav class="navbar navbar-inverse navbar-fixed-top">
  <div class="container-fluid">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="#">Logo</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav">
        <li><a href="home.aspx">Home</a></li>
        <li><a href="Clientes.aspx">Clientes</a></li>
        <li class="active"><a href="Productos.aspx">Productos</a></li>
        <li><a href="Factura.aspx">Factura</a></li>
          <li><a href="Usuarios.aspx">Usuarios</a></li>
      </ul>
      <ul class="nav navbar-nav navbar-right">
        <li><a href="login.aspx"><span class="glyphicon glyphicon-log-in"></span> Login</a></li>
      </ul>
    </div>
  </div>
</nav>


       <div class="container">
    <div class="row">
        <div class="col-md-12">
            <div class="well well-sm">
                <form id="form1" runat="server">
                    <fieldset>
                        <legend class="text-center header">Productos</legend>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-user bigicon"></i></span>
                            <div class="col-md-8">
                              <asp:TextBox ID="nombre" runat="server" type="text" placeholder="Nombre" class="form-control"></asp:TextBox> 
                            </div>
                        </div>
                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-user bigicon"></i></span>
                            <div class="col-md-8">
                               <asp:TextBox ID="marca" runat="server" type="text" placeholder="Marca" class="form-control"></asp:TextBox> 
                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-envelope-o bigicon"></i></span>
                            <div class="col-md-8">
                              <asp:TextBox ID="precio" runat="server" type="text" placeholder="Precio" class="form-control"></asp:TextBox> 
                            </div>
                        </div>

                        <div class="form-group">
                            <span class="col-md-1 col-md-offset-2 text-center"><i class="fa fa-phone-square bigicon"></i></span>
                            <div class="col-md-8">

                                <asp:TextBox ID="descripcion" runat="server" type="text" placeholder="Descripciòn" class="form-control"></asp:TextBox> 
                            
                            </div>
                        </div>



                        <div class="form-group">
                            <div class="col-md-12 text-center">
                        
                       <asp:Button ID="Insertar" runat="server" Text="Insertar" CssClass="btn btn btn-primary" OnClick="Insertar_Click"  />

        <asp:Button ID="Modificar" runat="server" Text="Modificar" CssClass="btn btn btn-primary"  OnClick="Modificar_Click" />

        <asp:Button ID="Eliminar" runat="server" Text="Eliminar" CssClass="btn btn btn-primary"  OnClick="Eliminar_Click" />

        <asp:Button ID="Consultar" runat="server" Text="Consultar" CssClass="btn btn btn-primary"  OnClick="Consultar_Click" />
                        
                                 <br />
                            </div>
                        </div>
                    </fieldset>
                </form>
            </div>
        </div>
    </div>
</div>
  
    <p>
        &nbsp;</p>
  
</body>
</html>
