<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventanafamiliares.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.Ventanafamiliares" %>

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
                    <h2>Datos de Hijos</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
             
                    <div class="col-lg-2">
                        <label>Nombre Completo</label>
                         <asp:TextBox runat="server" ID="nombrecom" placeholder="Nombre Completo" CssClass="form-control" />

                    </div>
                   
          
                    <div class="col-lg-2">
                        <label>Ocupación u Oficio</label>
                        <asp:TextBox runat="server" ID="ocupacion" placeholder="Ocupación" CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                        <label>Fecha Nacimiento</label>
                 <asp:TextBox runat="server" ID="fechanacfm" TextMode="Date" CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                        <label>Comentarios</label>
           <asp:TextBox runat="server" ID="coment" placeholder="Comentarios"  TextMode="MultiLine" CssClass="form-control" />
                    </div>
                    



                </div>
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="btnguardarinfofam" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnguardarinfofam_Click" />
                          </center>
                </div>
    </form>
</body>
</html>
