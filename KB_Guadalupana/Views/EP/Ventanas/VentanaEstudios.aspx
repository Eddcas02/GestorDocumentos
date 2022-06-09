<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentanaEstudios.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.VentanaEstudios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title>Estudios</title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Estudios Universitarios</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                     <div class="col-lg-2">
                      <label  id="encabasignados" runat="server" >Universidad</label>
               <asp:DropDownList  ID="universidaddrp" runat="server" CssClass="form-control" OnSelectedIndexChanged="universidaddrp_SelectedIndexChanged" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                          </div>
                    <div class="col-lg-2">
                        <label>Carrera</label>
                         <asp:TextBox runat="server" ID="carrera" placeholder="Carrera" CssClass="form-control" />

                    </div>
                    <div class="col-lg-2">
                      <label  id="Label1" runat="server" >¿Es Graduado?</label>
               
               <asp:DropDownList  ID="ColaboradorEstudioUniGraduado" runat="server" CssClass="form-control" OnSelectedIndexChanged="ColaboradorEstudioUniGraduado_SelectedIndexChanged" AutoPostBack="true"  Width="100%"  >
                        <asp:ListItem Text="[Seleccione]"  />
                   <asp:ListItem Text="No" Value="0" />
                            <asp:ListItem Text="Si" Value="1" />

               </asp:DropDownList><br/>
                          </div>
          
                    <div class="col-md-2">
                        <label>Ciclo</label>
                         
                        <asp:TextBox runat="server" Width="50%" TextMode="Number" ID="ciclo" placeholder="3" CssClass="form-control" />
                 
                        </div>
                    <div class="col-lg-2"> <asp:TextBox runat="server" Width="50%" TextMode="SingleLine" ID="UniversidadCiclo" Enabled="false" placeholder="Ciclo" CssClass="form-control" />
           </div>
                     <div class="col-md-2">
                        <label>Año.</label>
           <asp:TextBox runat="server" ID="anio" placeholder="2001"  TextMode="Number" CssClass="form-control" />
                    </div>
                  



                </div>
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="btnguardarestudios" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnguardarestudios_Click" />
                   </center>
                </div>
    </form>
</body>
</html>
