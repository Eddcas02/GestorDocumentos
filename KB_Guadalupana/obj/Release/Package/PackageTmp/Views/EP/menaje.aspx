<%@ Page Language="C#" AutoEventWireup="true"  MaintainScrollPositionOnPostback="true" CodeBehind="menaje.aspx.cs" Inherits="KB_Guadalupana.Views.EP.menaje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
      <link href="Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="Estaticos/bloqueo.js"></script>
    <title>Menaje</title>
</head>
<body>
    <form id="form1" runat="server">

                <asp:Label ID="blk" Visible="true"  runat="server" />
               <center>
          <h3>Menaje y Otros Activos<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
            </center>


           <div class="row">
            <div class="col-12 ">
                <h3>Equipo de computo<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblcompu" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" ID="ColaboradorActivoMenEQCant" TabIndex="1" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" style="color:black" TabIndex="2" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenEQVAlor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server" AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>










             <div class="row">
            <div class="col-12">
                <h3>Amueblado de sala<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblsala" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" TabIndex="3" ID="ColaboradorActivoMenSalaCant" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" TabIndex="4" style="color:black" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenSalaValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false"  >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>



             <div class="row">
            <div class="col-12">
                <h3>Amueblado de comedor<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblcomedor" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />        
                </div>
        </div>
           <div class="row">
            <div class="col-lg-12">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                       
                        <br />
                     <asp:TextBox CssClass="form-control" TabIndex="4" ID="ColaboradorActivoMenComeCant" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" TabIndex="5" style="color:black" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenComeValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Televisor<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lbltv" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" TabIndex="6" ID="ColaboradorActivoMenTVCant" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" TabIndex="7" style="color:black" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenTVValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Equipo de Sonido<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblsonido" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" ID="ColaboradorActivoMenSonCant" TabIndex="8" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" style="color:black"  TabIndex="9" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenSonValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Lavadora<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lbllavadora" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" ID="ColaboradorActivoMenLavCant" TabIndex="10" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" style="color:black" TabIndex="11" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenLavValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server" AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Secadora<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblsecadora" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" ID="ColaboradorActivoMenSecCant" TabIndex="12" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false"   >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" style="color:black" TabIndex="13" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenSecValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Estufa<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblestufa" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" TabIndex="14" ID="ColaboradorActivoMenEstCant" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server" AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" style="color:black" TabIndex="15" placeholder="10,000" 
                        type="text" name="email" id="ColaboradorActivoMenEstValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server" AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Refrigeradora<a data-toggle="modal" tabindex="16" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblrefri" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" TabIndex="17" ID="ColaboradorActivoMenRefCant" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" TabIndex="18" style="color:black" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenRefValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server" AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Teléfono móvil<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lbltelefono" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Cantidad</label>
                        <br />
                     <asp:TextBox CssClass="form-control" TabIndex="19" ID="ColaboradorActivoMenCelCant" MaxLength="4" 
                      placeholde="Descripción"  TextMode="Number" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" TabIndex="20" style="color:black" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenCelValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server"  AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         

                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-12 ">
                <h3>Otros Activos<a data-toggle="modal" data-target="#exampleModal3"> </a></h3>
                 <asp:Label ID="lblotros" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />       
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                     <div class="col-lg-2">
                        <label>Descripción</label>
                        <br />
                     <asp:TextBox CssClass="form-control" TabIndex="21" ID="ColaboradorActivoMenOtrDesc" MaxLength="500" 
                      placeholde="Descripción"  TextMode="MultiLine" runat="server"  AutoPostBack="false" >  </asp:TextBox>

                    </div>  
                     <div class="col-lg-2">
                        <label>Valor</label>
                        <asp:TextBox CssClass="form-control" TabIndex="22" style="color:black" placeholder="Valor actual en Q." 
                        type="text" name="email" id="ColaboradorActivoMenOtrValor" onkeyup="format(this)"
                        onchange="format(this);" maxlength="13"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                        runat="server" AutoPostBack="false" >  </asp:TextBox>
  
                    </div>
         
            <div class="col-lg-2" style="text-align:center">
                                <label id="lb" runat="server">Guardar Datos</label>
                                <br />
                                 
                       <asp:Button ID="btnmenajeguardar"  Font-Names=" 'Rubik', sans-serif" runat="server" Width="100%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnmenajeguardar_Click" />
 <asp:Label ID="lblSuccessMessage1" Text="Datos Almacenados" runat="server" Visible="false" ForeColor="Green" />
                <asp:Label ID="lblerror" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />
 
                    </div>

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

                 var texto1 = document.querySelector('#ColaboradorActivoMenEQVAlor');

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

                 var texto2 = document.querySelector('#ColaboradorActivoMenSalaValor');

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

                 var texto3 = document.querySelector('#ColaboradorActivoMenComeValor');

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

                 var texto4 = document.querySelector('#ColaboradorActivoMenTVValor');

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

                 var texto5 = document.querySelector('#ColaboradorActivoMenSonValor');

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

                 var texto6 = document.querySelector('#ColaboradorActivoMenLavValor');

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

                 var texto7 = document.querySelector('#ColaboradorActivoMenSecValor');

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

                 var texto8 = document.querySelector('#ColaboradorActivoMenEstValor');

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

                 var texto9 = document.querySelector('#ColaboradorActivoMenRefValor');

                 texto9.addEventListener('keypress', function (e) {
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

                 var texto10 = document.querySelector('#ColaboradorActivoMenCelValor');

                 texto10.addEventListener('keypress', function (e) {
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
                 var texto11 = document.querySelector('#ColaboradorActivoMenOtrValor');

                 texto11.addEventListener('keypress', function (e) {
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
