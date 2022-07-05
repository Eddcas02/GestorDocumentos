<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentanaEmergencias.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.VentanaEmergencias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title>Emergencias</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Contactos de emergencia</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                     <div class="col-lg-2">
                      <label  id="encabasignados" runat="server" >Nombre Completo</label>
             <asp:TextBox runat="server" TextMode="SingleLine" ID="txtnombre" placeholder="Nombres" CssClass="form-control" required="true" />
                          </div>
                        <div class="col-lg-2">
                      <label  id="Label1" runat="server" >Parentesco</label>
               <asp:DropDownList  ID="parentescodrp" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                          </div>
                    <div class="col-lg-2">
                        <label>Telefono</label>
                         <asp:TextBox runat="server" required="true"  maxlength="8"   onkeypress="return numeros(event);" 
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"  TextMode="SingleLine" ID="txttelefono" placeholder="24495478" CssClass="form-control" />

                    </div>
          



                </div>
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="agregaremergencias" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="agregaremergencias_Click" />
                   </center>
                </div>
    </form>
</body>
</html>
