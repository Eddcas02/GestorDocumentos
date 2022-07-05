<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventanacuentaspp.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.Ventanacuentaspp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link href="../../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
            <title>Cuentas</title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Cuentas Por Pagar</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
             
                   
                
                    <div class="col-lg-2">
                        <label>Persona/Entidad</label>
                        <asp:TextBox runat="server" ID="ColaboradorActivoCXCOrigen" placeholder="Persona/Entidad" TextMode="SingleLine" CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                        <label>Descripción</label>

           <asp:TextBox runat="server" ID="ColaboradorPasivoCXPDescripcio" placeholder="Motivo"  TextMode="SingleLine" CssClass="form-control" />
                     </div>
                  <div class="col-lg-2">
                        <label>Monto</label>
            <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" type="text" name="email" ID="ColaboradorPasivoCXPMonto" onkeyup="format(this)" onchange="format(this);" maxlength="13" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" >  </asp:TextBox>
                      
                  </div>
                  



                </div>
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="btnguardarcuentas" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnguardarcuentas_Click" />
                   </center>
                </div>
    </form>

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

         var texto1 = document.querySelector('#ColaboradorPasivoCXPMonto');

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
