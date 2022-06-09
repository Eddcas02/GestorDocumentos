<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentanaTelefonos.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.VentanaTelefonos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
    <script src="../Estaticos/validacionletrasnum.js"></script>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title>Teléfonos</title>
</head>
<body>
    <form id="form1" runat="server">
      <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Teléfonos</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                      <div class="col-lg-2">
                      <label  id="Label1" runat="server" >Tipo</label>
               <asp:DropDownList  ID="tipotel" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                          </div>
                     <div class="col-lg-2">
                      <label  id="encabasignados" runat="server" >Número de teléfono</label>
             <asp:TextBox runat="server" TextMode="SingleLine" onkeypress="return numeros(event);" MaxLength="8" ID="txtnumerotel" placeholder="Teléfono" CssClass="form-control" required="true" />
                          </div>
                      
                 
          



                </div>
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="agregartelefono" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="agregartelefono_Click" />
                   </center>
                </div>
    </form>
</body>
</html>
