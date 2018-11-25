<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ProyectoIntegracionContinua.login" %>

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
    <!-- CTRL + K + D -->
    <div class="container">
        <h3>Inicio de sesión</h3>
        <div class="row">

            <div class="col-md-6">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <label for="exampleInputEmail1">Username</label>
                        <asp:TextBox ID="txtUser" 
                            runat="server"
                            CssClass="form-control"
                            placeholder="Usuario"
                            ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Password</label>
                        <asp:TextBox ID="txtPass"
                            TextMode="Password" 
                            runat="server"
                            CssClass="form-control"
                            placeholder="Password"
                            ></asp:TextBox>
                    </div>              
                    <asp:Button ID="btnEnviar" 
                        runat="server"
                        CssClass="btn btn-default" 
                        Text="Enviar" OnClick="btnEnviar_Click" />
                    <asp:HyperLink ID="lnkOlvido" 
                        runat="server"
                        Text="Forgot your password?"
                        NavigateUrl="">
                    </asp:HyperLink>
                                <div class="col-md-6">
                <img src="images/devops.png" class="img-responsive" />
            </div>
                </form>
                <asp:Panel ID="Panel1" runat="server">  
                    <div class="alert alert-danger alert-dismissible fade in" role="alert"> <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">×</span></button> <h4>Oh snap! You got an error!</h4> <p>Change this and that and try again. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum.</p> <p> <button type="button" class="btn btn-danger">Take this action</button> <button type="button" class="btn btn-default">Or do this</button> </p> </div>
           
        
    
    <script src="js/bootstrap.min.js"
        type="text/javascript"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
                    <script>window.jQuery || document.write('<script src="../assets/js/vendor/jquery.min.js"><\/script>');</script>

                </asp:Panel>
                 </div>
        </div>
    </div>

   
</body>
</html>
