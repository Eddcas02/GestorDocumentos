<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="VentanaInversiones.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Ventanas.VentanaInversiones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js" type="text/javascript"></script>
        
    <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet"/>
    <title>Inversiones</title>
</head>
<body>
    <form id="form1" runat="server">
       <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Inversiones (Plazos fijos, Acciones, Bonos)</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                     <div class="col-lg-2">
                         
                      <label  id="encabasignados" runat="server" >Entidad</label>
  <asp:DropDownList  ID="fropentidad" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                       </div>
                      <script>
                          $('#<%=fropentidad.ClientID%>').chosen();
                      </script>
                        <div class="col-lg-2">
                      <label  id="Label1" runat="server" >Plazo en años</label>
             <asp:TextBox runat="server" required="true"  MaxLength ="8" TextMode="number" ID="txtplazo" placeholder="2" CssClass="form-control" />
              </div>
                  

                      <div class="col-lg-2">
                      <label  id="Label2" runat="server" > Moneda</label>
  <asp:DropDownList  ID="monedadrp" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                       </div>
           <div class="col-lg-2">
                        <label>Monto</label>
                        <asp:TextBox CssClass="form-control" style="color:black" placeholder="10000" type="text" name="email" ID="montocaja" onkeyup="format(this)" onchange="format(this);" maxlength="13" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" >  </asp:TextBox>

                    </div>
                      <div class="col-lg-2">
                        <label>Origen de los fondos</label>
                         <asp:TextBox runat="server" required="true"  TextMode="SingleLine" ID="txtorigen" placeholder="Origen" CssClass="form-control" />

                    </div>
                       <div class="col-lg-2">
                        <label>Cuenta</label>
                           <asp:TextBox CssClass="form-control" ID="txtcuenta" TextMode="SingleLine" style="color:black" placeholder="10000" runat="server" >  </asp:TextBox>

                    </div>
                       <div class="col-lg-2">
                        <label>Fecha de apertura</label>
                        <asp:TextBox CssClass="form-control" ID="fechainv" TextMode="Date" style="color:black" placeholder="10000" runat="server" >  </asp:TextBox>

                    </div>




                </div>
            </div>
        </div>
            <center>
                  <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="agregarinversiones" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="guardarinversiones" />
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

        var texto1 = document.querySelector('#montocaja');

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
