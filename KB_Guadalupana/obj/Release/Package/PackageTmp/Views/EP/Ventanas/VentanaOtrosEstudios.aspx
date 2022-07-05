<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentanaOtrosEstudios.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.VentanaOtrosEstudios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Estudios</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                   
                    <div class="col-lg-2">
                        <label>Curso</label>
                         <asp:TextBox runat="server" ID="curso" placeholder="Nombre del curso" CssClass="form-control" />

                    </div>
                   
          
                    <div class="col-lg-2">
                        <label>Establecimiento</label>
                        <asp:TextBox runat="server" ID="establecimiento" placeholder="Establecimiento" CssClass="form-control" />
                    </div>
                   
                  
                      <div class="col-lg-2">
                      <label  id="modalidad" runat="server" >Modalidad</label>
               <asp:DropDownList  ID="modalidaddrp" runat="server" CssClass="form-control"  Width="100%"  ></asp:DropDownList><br/>
                          </div>

                      <div class="col-lg-2">
                        <label>Año.</label>
           <asp:TextBox runat="server" ID="anio" placeholder="2021"  TextMode="Number" CssClass="form-control" />
                    </div>

                    
                      <div class="col-lg-2">
                        <label>Duración(semanas).</label>
           <asp:TextBox runat="server" ID="duracion" placeholder=" 4 semanas"  TextMode="SingleLine" CssClass="form-control" />
                    </div>


                </div>
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="btnotrosestudios" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnotrosestudios_Click" />
                   </center>
                </div>
    </form>
</body>
</html>
