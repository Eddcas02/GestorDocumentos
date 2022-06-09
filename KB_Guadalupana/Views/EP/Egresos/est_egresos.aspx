<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="est_egresos.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_egresos" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="../Estaticos/bloqueo.js"></script>
    <title></title>
</head>

<body>
   
    <form id="form1" runat="server">
      <asp:ScriptManager ID="scriptman1" runat="server"> </asp:ScriptManager>

                <asp:Label ID="blk" Visible="true"  runat="server" />
             <div>
           
            <h1 id="titulop" runat="server">Egresos Mensuales</h1>

        

        </div>

               <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                   <div class="col-lg-2">
                        <label>Alimentación</label>
                                           <asp:Label ID="lblcomida" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                     <asp:TextBox CssClass="form-control" style="color:black" falseplaceholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoAlimentacion" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" required="true" >  </asp:TextBox>    </div>
                    <div class="col-lg-3">
                        <label>Transporte y/o Gasolina</label>
                                            <asp:Label ID="lblgaso" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                   <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoTransporte" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" required="true"  >  </asp:TextBox>   

                    </div>
                         <div class="col-lg-2">
                      <label  id="Label4" runat="server" >Pago de Estudios</label>
                                                 <asp:Label ID="lblestudios" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoEstudio" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>  

                         </div>
                        <div class="col-lg-4">
                      <label  id="Label11" runat="server" >Amortización de Préstamos</label>
                                                <asp:Label ID="lblprestamos" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoPrestamo" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>  

                         </div>
                
              
              



      </div>
            </div>
        </div>
      <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
             <div class="col-lg-4">
                      <label  id="Label12" runat="server" >Amortización de extra financiamientos y/o visacuotas </label>
                                     <asp:Label ID="lblamorti" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoExtraFin" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server" AutoPostBack="false" >  </asp:TextBox>  

                         </div>
                     
                <div class="col-lg-2">
                      <label  id="Label122" runat="server" >Vestuario</label>
                                        <asp:Label ID="lblvestuario" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoVestuario" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" required="true" >  </asp:TextBox>  

                         </div>
                <div class="col-lg-2">
                      <label  id="Lab2el1" runat="server" >Recreación </label>
                                        <asp:Label ID="lblrecrea" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoRecreacion" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" required="true" >  </asp:TextBox>  

                         </div>
                <div class="col-lg-2">
                      <label  id="Label1" runat="server" >Otros Egresos </label>
                                        <asp:Label ID="lblotros" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
    
                <asp:TextBox CssClass="form-control" style="color:black" placeholder="0.00" 
                        type="text" name="email" id="ColaboradorEgresoOtros" onkeyup="format(this)"
                        onchange="format(this);" maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>  

                         </div>
              
                <div class="col-lg-2" style="text-align:center">
                                <label id="lb" runat="server">Guardar Datos</label>
                               <br />
                                 
                       <asp:Button ID="btnegresos"  Font-Names=" 'Rubik', sans-serif" runat="server" Width="100%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnegresos_Click" />
 <asp:Label ID="lblSuccessMessage1" Text="Datos Almacenados" runat="server" Visible="false" ForeColor="Green" />
                <asp:Label ID="lblerror" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />
 
                    </div>

                    <%--  <div class="col-lg-6" style="text-align:center">
                                  <label></label>
                                  <br />
                                 
                       <asp:Button ID="btnfinalizar"  Font-Names=" 'Rubik', sans-serif" runat="server" Width="100%" Height="40px" CssClass="btn1" Text="Finalizar" OnClick="btnfinalizar_Click"
                           OnClientClick="return confirm('¿Seguro que desea finalizar su Estado Patrimonial?')" CausesValidation="False"/>
 <asp:Label ID="Label2" Text="Estado Patrimonial Finalizado" runat="server" Visible="false" ForeColor="Green" />
                <asp:Label ID="Label3" Text="Aún falta completar datos para finalizar" runat="server" Visible="false" ForeColor="Red" />
 
                    </div>--%>

      </div>
            </div>
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

         var texto1 = document.querySelector('#ColaboradorEgresoAlimentacion');

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

         var texto2 = document.querySelector('#ColaboradorEgresoTransporte');

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
         var texto3 = document.querySelector('#ColaboradorEgresoEstudio');

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

         var texto4 = document.querySelector('#ColaboradorEgresoPrestamo');

         texto4.addEventListener('keypress', function (e) {
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

         var texto5 = document.querySelector('#ColaboradorEgresoExtraFin');

         texto5.addEventListener('keypress', function (e) {
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

         var texto6 = document.querySelector('#ColaboradorEgresoVestuario');

         texto6.addEventListener('keypress', function (e) {
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

         var texto7 = document.querySelector('#ColaboradorEgresoRecreacion');

         texto7.addEventListener('keypress', function (e) {
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

         var texto8 = document.querySelector('#ColaboradorEgresoOtros');

         texto8.addEventListener('keypress', function (e) {
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
