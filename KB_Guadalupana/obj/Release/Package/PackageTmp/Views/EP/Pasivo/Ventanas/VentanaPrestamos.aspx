﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentanaPrestamos.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.VentanaPrestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    <link href="../../Estaticos/cssContene.css" rel="stylesheet" />
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
      <script src="https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js" type="text/javascript"></script>
        
    <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet"/>
    <title>Tarjetas de Credito</title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Préstamos</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                     <div class="col-lg-4">
                      <label  id="encabasignados" runat="server" >Tipo de Préstamo</label>
                         <br />

             
                         <asp:DropDownList ID="TipoPrestamoID" CssClass="form-control" AutoPostBack="false"  runat="server" Width="100%">
                       
                         </asp:DropDownList>
                </div>
                     
                    
                    <div class="col-lg-4">
                      <label  id="ent" runat="server" >Institución o Entidad</label>
                         <br />

                   
                         <asp:DropDownList ID="EntidadFinCodigo" CssClass="form-control" AutoPostBack="false"  runat="server" Width="100%">
                       
                         </asp:DropDownList>
              
                          </div>

                    <div class="col-lg-2">
                      <label  id="Label2" runat="server" >Monto</label>
             <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorPasivoPrestMontoIni" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  >  </asp:TextBox>
  
                        
                    </div>
                
                    <div class="col-lg-2">
                        <label>Saldo Actual</label>
                
                         <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorPasivoPrestSaldo" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  >  </asp:TextBox>
  
                        </div>
                     <div class="col-lg-2">
                        <label>Destino</label>
                         <asp:TextBox runat="server" CssClass="form-control" ID="ColaboradorPasivoPrestDestino" TextMode="SingleLine" Width="100%" />
                    
      
                     </div>
                  <div class="col-lg-2">
                        <label>Fecha de Desembolso</label>
           
                    <asp:TextBox runat="server" ID="ColaboradorPasivoPrestFecDesem"  CssClass="form-control" TextMode="Date" Width="100%" />
                    
      
                  </div>
                  
             <div class="col-lg-2">
                        <label>Fehca de Finalización</label>
           
                    <asp:TextBox runat="server" ID="ColaboradorPasivoPrestFecFinal"  CssClass="form-control" TextMode="Date" Width="100%" />
      
                  </div>
    

                </div>
   
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="btntc" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" 
                 Height="40px" CssClass="btn1" Text="Guardar" OnClick="btntc_Click" />
                   </center>
                </div>
    </form>
        <script>
            $('#<%=EntidadFinCodigo.ClientID%>').chosen();
            $('#<%=TipoPrestamoID.ClientID%>').chosen();
        </script>
     <script>
        function format(input) {
            var num = input.value.replace(/\,/g, '');
            if (!isNaN(num)) {
                num = num.toString().split('').reverse().join('').replace(/(?=\d*\,?)(\d{3})/g, '$1,');
                num = num.split('').reverse().join('').replace(/^[\,]/, '');
                input.value = num;
            }

            else {
                alert('Solo se permiten numeros');
                input.value = input.value.replace(/[^\d\,]*/g, '');
            }
        }

         var texto1 = document.querySelector('#ColaboradorPasivoTCLimiteQ');

        texto1.addEventListener('keypress', function (e) {
            // keyCode del punto decimal, también se puede cambiar por la coma que sería el 44
            const decimalCode = 46;
            // chequeo que el keyCode corresponda a las teclas de los números y al punto decimal
            if ((e.keyCode < 48 || e.keyCode > 57) && e.keyCode != decimalCode) {
                e.preventDefault();
            }
            // chequeo que sólo exista un punto decimal
            else if (e.keyCode == decimalCode && /\./.test(this.value)) {
                event.preventDefault();
            }
        }, true)

         var texto2 = document.querySelector('#ColaboradorPasivoTCLimiteUS');

         texto2.addEventListener('keypress', function (e) {
             // keyCode del punto decimal, también se puede cambiar por la coma que sería el 44
             const decimalCode = 46;
             // chequeo que el keyCode corresponda a las teclas de los números y al punto decimal
             if ((e.keyCode < 48 || e.keyCode > 57) && e.keyCode != decimalCode) {
                 e.preventDefault();
             }
             // chequeo que sólo exista un punto decimal
             else if (e.keyCode == decimalCode && /\./.test(this.value)) {
                 event.preventDefault();
             }
         }, true)


         var texto3 = document.querySelector('#ColaboradorPasivoTCSaldoQ');

         texto3.addEventListener('keypress', function (e) {
             // keyCode del punto decimal, también se puede cambiar por la coma que sería el 44
             const decimalCode = 46;
             // chequeo que el keyCode corresponda a las teclas de los números y al punto decimal
             if ((e.keyCode < 48 || e.keyCode > 57) && e.keyCode != decimalCode) {
                 e.preventDefault();
             }
             // chequeo que sólo exista un punto decimal
             else if (e.keyCode == decimalCode && /\./.test(this.value)) {
                 event.preventDefault();
             }
         }, true)

         var texto4 = document.querySelector('#ColaboradorPasivoTCSaldoUS');

         texto1.addEventListener('keypress', function (e) {
             // keyCode del punto decimal, también se puede cambiar por la coma que sería el 44
             const decimalCode = 46;
             // chequeo que el keyCode corresponda a las teclas de los números y al punto decimal
             if ((e.keyCode < 48 || e.keyCode > 57) && e.keyCode != decimalCode) {
                 e.preventDefault();
             }
             // chequeo que sólo exista un punto decimal
             else if (e.keyCode == decimalCode && /\./.test(this.value)) {
                 event.preventDefault();
             }
         }, true)


     </script>


    </body>
</html>
