<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosMant.aspx.cs" Inherits="KB_Guadalupana.Views.Procesos.Ventanas.UsuariosMant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title> Familiares</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Mantenimiento de Usuarios</h2>
                      <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Error, Complete los campos" Visible="false" runat="server" ForeColor="Red" /> <br />
                  
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
             
                    <div class="col-lg-2">
                        <label>Nombre Completo</label>
                         <asp:TextBox runat="server" ID="gen_nombrecomp" placeholder="Nombre Completo" CssClass="form-control" />

                    </div>
                   
          
                    <div class="col-lg-2">
                        <label>Nombre de usuario</label>
                        <asp:TextBox runat="server" ID="gen_usuarionombre" placeholder="Nombre de Usuario" CssClass="form-control" />
                    </div>
                    
                    <div class="col-lg-2">
                        <label>Correo Institucional</label>
                        <asp:TextBox runat="server" ID="gen_usuariocorreo" placeholder="Correo@sion.com.gt" CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                        <label>Contraseña</label>
                          <asp:Label ID="lblcontraseñacorta" Text="La contraseña debe tener mas de 8 caracteres" Visible="false" runat="server" ForeColor="Red" /> <br />
                   <asp:TextBox runat="server" ID="gen_pass" placeholder="Contraseña"  TextMode="Password" CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                        <label>Repita su contraseña</label>
                           <asp:Label ID="lblcontraseña" Text="Las contraseñas no coinciden" Visible="false" runat="server" ForeColor="Red" /> <br />
           <asp:TextBox runat="server" ID="contra2" placeholder="Contraseña"  TextMode="Password" CssClass="form-control" />
                    </div> 
                    <div class="col-lg-2">
                        <label>Estado</label>
                          
                        <asp:DropDownList ID="gen_usuarioest" runat="server" AutoPostBack="false">
                            <asp:ListItem Text="Estado" Value="m" />
                            <asp:ListItem Text="Activo" Value="0" />
                            <asp:ListItem Text="Inactivo" Value="1" />
                        </asp:DropDownList>
                    </div>
                    



                </div>
            </div>
        </div>
            <center>
                
     
             <asp:Button ID="btnguardaruser" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnguardaruser_Click" />
                          </center>
                </div>
    </form>
</body>
</html>

