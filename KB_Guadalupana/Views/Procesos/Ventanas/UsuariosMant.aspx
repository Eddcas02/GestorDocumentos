<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuariosMant.aspx.cs" Inherits="KB_Guadalupana.Views.Procesos.Ventanas.UsuariosMant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title>Mantenimiento</title>
     <style>
         @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;400&display=swap');
        html{
            width:100%;
            height:100%;
        }

        body{
            font-family:"Montserrat";
        }

        .formularioCobros{
            display:flex;
            flex-direction:column;
            width:750px;
            justify-items: center;
            align-content: center;
            justify-content: center;
            align-items: center;
        }

        .general{
            display:flex;
            justify-content:center;
            align-content:center;
            align-items:flex-start;
            width:100%;
            height:auto;
            margin-top:25px;
        }

        .encabezado{
            padding:25px;
            flex-direction:column;
            margin:15px;
            width: 80%;
        }

         .linea{
            border-bottom: 3px #32599C solid;
            height:5px;
            width:100%;
        }

         .formatoinput {
            width: 46%;
            border: 0.5px black solid;
            height: 30px;
            display: flex;
            align-items: center;
            align-content:center;
        }

        .formatoinput2{
            width:99%;
            margin-top:8px;
            border: 0.5px black solid;
            height: 30px;
        }

        .formatoinput3 {
            width: 29%;
            border: 0.5px black solid;
            height: 30px;
            display: flex;
            align-items: center;
            align-content:center;
        }

          .formatoinput4 {
            width: 21%;
            border: 0.5px black solid;
            height: 30px;
            display: flex;
            align-items: center;
            align-content:center;
        }

        .formato{
            display:flex;
            flex-direction:row;
            justify-content: space-between;
            width:100%;
        }

        .formato2{
            display:flex;
            flex-direction:row;
            justify-content: space-around;
        }

        .formato3{
            display:flex;
            flex-direction:column;
            width:100%;
        }

         .titulos{
             font-size:13px;
             display:flex;
            align-items:center;
            align-content:center;
         }

        .formatoTitulo{
            display:flex;
            flex-direction:row;
            justify-content: flex-start;
        }

                 .boton{
            background-color: #213C69;
            color: white;
            border:0px;
            width:45%;
            margin-top:15px;
            height: 30px;
        }

        .boton:hover {
             background-color: #32599C; 
             color: white; 
               border:0px;
             /*border: 2px solid #69A43C;*/
        }

         .boton2{
             background-color: #213C69; 
             color: white; 
             /*border: 2px solid #69A43C;*/
            width:45%;
            margin-top:15px;
            height: 30px;
              border:0px;
        }

        .boton2:hover {
            background-color: #32599C;
            color: white;
            border:0px;
        }

         .boton3{
            background-color: #003A6E;
            color: white;
            border:0px;
             width:22%;
             display: flex;
             align-items: center;
            align-content:center;
            justify-content:center;
             height: 25px;
        }

        .boton3:hover {
             background-color: white; 
             color: black; 
             border: 2px solid #003A6E;
            
        }

        .tabla{
            width:100%;
        }

      .tabla td{
            padding:7px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <%-- <div class="container main">--%>

        <div class="general">
            <div class="formularioCobros">
                 <div style="display:flex; justify-content:center">
                    <label style="font-size:18px" class="titulos"><b>Mantenimiento de Usuarios</b></label>
                 </div>
                 <div class="linea"></div>
                   <div class="encabezado">
                       <div class="formato3">
                        <label class="titulos"><b>Nombre Completo</b></label>
                        <asp:TextBox id="gen_nombrecomp" runat="server" class="formatoinput2" placeholder="Ingrese el nombre completo del usuario" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                    </div><br />

                       <div class="formatoTitulo" style="margin-bottom:5px">
                        <label class="titulos"><b>Nombre Usuario</b></label>
                        <label class="titulos" style="margin-left:46%"><b>Email</b></label>
                    </div>
                     <div class="formato">
                        <asp:TextBox id="gen_usuarionombre" runat="server" class="formatoinput" placeholder="Nombre usuario" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                         <asp:Textbox id="gen_usuariocorreo" runat="server" class="formatoinput" placeholder="Correo@sion.com.gt" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"></asp:Textbox>
                    </div><br />

                        
                    <div class="formato3">
                        <label class="titulos"><b>Contraseña</b></label>
                        <asp:TextBox id="gen_pass" runat="server" class="formatoinput2" placeholder="Ingrese contraseña" TextMode="Password" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        <asp:Label ID="lblcontraseñacorta" Text="La contraseña debe tener mas de 8 caracteres" Visible="false" runat="server" ForeColor="Red" />                    
                    </div><br />
                       <div class="formato3">
                        <label class="titulos"><b>Repetir Contraseña</b></label>
                        <asp:TextBox id="contra2" runat="server" class="formatoinput2" placeholder="Repita su contraseña" TextMode="Password" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        <asp:Label ID="lblcontraseña" Text="Las contraseñas no coinciden" Visible="false" runat="server" ForeColor="Red" />
                       </div><br />

                       <div class="formato3">
                           <label class="titulos"><b>Estado</b></label>
                    <asp:DropDownList ID="gen_usuarioest" runat="server" AutoPostBack="false">
                            <asp:ListItem Text="-- Elegir --" Value="m" />
                            <asp:ListItem Text=" Activo " Value="0" />
                            <asp:ListItem Text=" Inactivo " Value="1" />
                        </asp:DropDownList>
                        </div>

                       <br />
                       <div class="formato2">
                        <asp:Button ID="btnguardaruser" runat="server" CssClass="boton2" Text="Guardar" OnClick="btnguardaruser_Click"/>
                       <asp:Button ID="btnregresar" runat="server" CssClass="boton" Text="Cerrar" />
                    </div>
                       </div>
                      <div class="linea"></div>
            

                     <center>
                      <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Black" /> <br />
                    <asp:Label ID="lblerror" Text="Error, Complete los campos" Visible="false" runat="server" ForeColor="Red" /> <br />
                  </center>
                </div>
            </div>
     

        <br />
                        
<%--        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">--%>
             
                   <%-- <div class="col-lg-2">
                        <label>Nombre Completo</label>
                         <asp:TextBox runat="server" ID="gen_nombrecomp" placeholder="Nombre Completo" CssClass="form-control" />

                    </div>--%>
                   
          
                    <%--<div class="col-lg-2">
                        <label>Nombre de usuario</label>
                        <asp:TextBox runat="server" ID="gen_usuarionombre" placeholder="Nombre de Usuario" CssClass="form-control" />
                    </div>
                    
                    <div class="col-lg-2">
                        <label>Correo Institucional</label>
                        <asp:TextBox runat="server" ID="gen_usuariocorreo" placeholder="Correo@sion.com.gt" CssClass="form-control" />
                    </div>--%>
                     <%--<div class="col-lg-2">
                        <label>Contraseña</label>
                          <asp:Label ID="lblcontraseñacorta" Text="La contraseña debe tener mas de 8 caracteres" Visible="false" runat="server" ForeColor="Red" /> <br />
                   <asp:TextBox runat="server" ID="gen_pass" placeholder="Contraseña"  TextMode="Password" CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                        <label>Repita su contraseña</label>
                           <asp:Label ID="lblcontraseña" Text="Las contraseñas no coinciden" Visible="false" runat="server" ForeColor="Red" /> <br />
           <asp:TextBox runat="server" ID="contra2" placeholder="Contraseña"  TextMode="Password" CssClass="form-control" />
                    </div> --%>
                   <%-- <div class="col-lg-2">
                        <label>Estado</label>
                          
                        <asp:DropDownList ID="gen_usuarioest" runat="server" AutoPostBack="false">
                            <asp:ListItem Text="Estado" Value="m" />
                            <asp:ListItem Text="Activo" Value="0" />
                            <asp:ListItem Text="Inactivo" Value="1" />
                        </asp:DropDownList>
                    </div>
                    --%>



                <%--</div>--%>
          <%--  </div>
        </div>--%>
          <%--  <center>
                
     
             <asp:Button ID="btnguardaruser" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnguardaruser_Click" />
                          </center>
               --%>
    </form>
</body>
</html>

