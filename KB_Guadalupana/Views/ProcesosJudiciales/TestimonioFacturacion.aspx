<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestimonioFacturacion.aspx.cs" Inherits="KB_Guadalupana.Views.ProcesosJudiciales.TestimonioFacturacion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
<link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>
    <title>Notificación al asociado</title>
     <style>
         @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;400&display=swap');

            .Background
        {
            background-color: Black;
            filter: alpha(opacity=90);
            opacity: 0.8;
        }
        .Popup
        {
            background-color: #FFFFFF;
            border-width: 3px;
            border-style: solid;
            border-color: black;
            width: 85%;
            height: 80%;
        }
        .lbl
        {
            font-size:16px;
            font-style:italic;
            font-weight:bold;
        }

        html{
            width:100%;
            height:100%;
        }

        body{
            font-family:"Montserrat";
            background-color:#34495E;
            color:white;
        }

        .general{
            display:flex;
            justify-content:center;
            align-content:center;
            align-items:flex-start;
            width:100%;
            height:auto;
            margin-top:25px;
        }

        .formularioCobros{
            display:flex;
            flex-direction:column;
            width:750px;
        }

        .encabezado{
            padding:25px;
            background-color:#435F7A;
            flex-direction:column;
            margin-top:10px;
        }

        .formato{
            display:flex;
            flex-direction:row;
            justify-content: space-between;
            width:100%;
            align-items: center;
        }

          .formato3{
            display:flex;
            flex-direction:column;
            width:100%;
        }

        .formato4{
             display:flex;
            flex-direction:row;
            justify-content: center;
        }

        .formatoinput {
            width: 46%;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            height: 30px;
            border-color: transparent;
            display: flex;
            align-items: center;
            align-content:center;
             margin-top:8px;
        }

        .formatoinput2{
            width:99%;
            margin-top:8px;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            height: 30px;
            border-color: transparent;
        }

        .formatoinput3 {
            width: 29%;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            height: 30px;
            border-color: transparent;
            display: flex;
            align-items: center;
            align-content:center;
        }

        .formatoinput4 {
            width: 21%;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            height: 30px;
            border-color: transparent;
            display: flex;
            align-items: center;
            align-content:center;
        }

        .formato2{
            display:flex;
            flex-direction:row;
            justify-content: space-around;
        }

        .boton{
            background-color: #69A43C;
            color: white;
            border:0px;
            width:45%;
            margin-top:15px;
            height: 30px;
        }

        .boton:hover {
             background-color: white; 
             color: black; 
             border: 2px solid #69A43C;
        }

         .boton2{
             background-color: white; 
             color: black; 
             border: 2px solid #69A43C;
            width:45%;
            margin-top:15px;
            height: 30px;
        }

        .boton2:hover {
            background-color: #69A43C;
            color: white;
            border:0px;
        }

         .boton3{
            background-color: #003A6E;
            color: white;
            border:0px;
             width:22%;
             display: flex;
             align-items: center;
            align-content:center;
            justify-content:center;
             height: 25px;
        }

        .boton3:hover {
             background-color: white; 
             color: black; 
             border: 2px solid #003A6E;
            
        }

         .pagina{
            display:flex;
            flex-direction:row;
        }

         .header{
             background-color:#004078;
             color:white;
         }

         .titulos{
             font-size:13px;
             display:flex;
            align-items:center;
            align-content:center;
         }

        .formatoTitulo{
            display:flex;
            flex-direction:row;
            justify-content: flex-start;
        }

        .tabla{
            width:100%;
        }

        .tabla td{
            padding:7px;
        }
           .ventana{
             display:flex;
             align-content:flex-start;
             justify-content:flex-start;
             justify-items:flex-start;
             flex-direction:column;
             margin-left:0px;
         }
                  .formatoinput5{
            width:90%;
            margin-top:8px;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            height: 30px;
            border-color: transparent;
            font-family:"Montserrat";
            max-width: 90%;
            min-width: 90%;
            max-height:30px;
            min-height:30px;
        }

        .formatocheckbox {
            width: 25px;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            height: 25px;
            border-color: transparent;
            display: flex;
            align-items: flex-start;
            align-content:flex-start;
            justify-content:flex-start;
        }

        .formatocheck{
            display:flex;
            justify-content:space-between;
            flex-direction:row;
            width:100%;
            margin-bottom: 5px;
        }

        .formatocheck2{
            display:flex;
            flex-direction:row;
            width:30%;
        }

        .header{ border-top:1px solid white;background:white; color:#333; height:0px; width:100%; font-family: 'Montserrat', cursive; text-align:center}
.menu2{visibility:hidden; height:auto; width:17%; color:white; text-align:left; padding-top:5px; left:0; margin-left:0px;margin-top:75px;background-color:#435F7A; border:2px #4B752B solid;padding-left:13px;}
.wrapper{ height:100px; width:100%; padding-top:20px}
 
.fixed{position:fixed; top:0;visibility:visible}

    </style>
</head>
    <div id="menu" runat="server" class="menu"></div>
<body>
    <form id="form1" runat="server">
        <div class="general">
            <div class="formularioCobros"> 
                <div id="Div1" runat="server" class="encabezado" style="border-color:#8DDB51; border:2px #4B752B solid">
                          <div class="formato">
                        <label style="font-size:15px" class="titulos"><b>Información principal</b></label>
                         <div style="width:20%">
                             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                             <asp:Button ID="VerBitacora" runat="server" Width="100%" Height="25px" CssClass="boton3" Text="Ver bitácora" />

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="VerBitacora"
                                CancelControlID="Button2" BackgroundCssClass="Background">
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                            <iframe style=" width: 100%; height: 100%;" id="irm1" src="Bitacora.aspx" runat="server"></iframe>
                             <br/>
                            <asp:Button ID="Button2" CssClass="boton" Width="30%" runat="server" Text="Cerrar" />
                            </asp:Panel>
                         </div>
                     </div>
                     <br /><br />

                        <div class="formatoTitulo" style="margin-bottom:5px">
                        <label class="titulos"><b>No. de préstamo</b></label>
                        <label class="titulos" style="margin-left:11%"><b>Incidente</b></label>
                        <label class="titulos" style="margin-left:16%"><b>DPI</b></label>
                        <label class="titulos" style="margin-left:23%"><b>CIF</b></label>
                    </div>

                    <div class="formato">
                        <input id="NumPrestamo" runat="server" type="text" class="formatoinput4" min="0" placeholder="No. prestamo" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                          <input id="NumIncidente" runat="server" type="text" class="formatoinput4" min="0" placeholder="No. incidente" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                        <input id="DPI" runat="server" type="text" class="formatoinput4" placeholder="DPI" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                         <input id="CodigoCliente" runat="server" type="text" min="0" class="formatoinput4" placeholder="Código cliente" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                    </div><br />

                    <div class="formato3">
                        <label class="titulos"><b>Cliente - Nombre</b></label>
                        <input id="NombreCliente" runat="server" type="text" class="formatoinput2" placeholder="Cliente - Nombre" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                    </div><br />

                      <div class="formatoTitulo" style="margin-bottom:5px">
                          <label class="titulos"><b>No. proceso</b></label>
                        <label class="titulos" style="margin-left:15%"><b>No. juzgado</b></label>
                        <label class="titulos" style="margin-left:14%"><b>Nombre juzgado</b></label>
                        <label class="titulos" style="margin-left:11%"><b>Oficial</b></label>
                    </div>

                     <div class="formato">
                        <input id="Numproceso" runat="server" type="text" min="0" class="formatoinput4" placeholder="No. Incidente" maxlength="20" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                        <input id="NumJuzgado" runat="server" type="text" class="formatoinput4" min="0" placeholder="Monto original" maxlength="20" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                        <input id="NombreJuzgado" runat="server" type="text" class="formatoinput4" min="0" placeholder="Capital desembolsado" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                        <input id="Oficial" runat="server" type="text" min="0" class="formatoinput4" placeholder="Saldo actual" maxlength="20" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                    </div><br /><br />

                      <div class="formatoTitulo" style="margin-bottom:5px">
                        <label class="titulos"><b>Monto original</b></label>
                        <label class="titulos" style="margin-left:21%"><b>Capital desembolsado</b></label>
                        <label class="titulos" style="margin-left:15%"><b>Saldo actual</b></label>
                    </div>

                    <div class="formato">
                        <input id="MontoOriginal" runat="server" type="text" class="formatoinput3" min="0" placeholder="Monto original" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                        <input id="CapitalDesem" runat="server" type="text" class="formatoinput3" min="0" placeholder="Capital desembolsado" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                        <input id="SaldoActual" runat="server" type="text" min="0" class="formatoinput3" placeholder="Saldo actual" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                    </div><br /><br />

                     <div id="divgridviewprospectos1" style="overflow: auto; height: 147px">
     <asp:GridView ID="gridview1" CssClass="container"  style="width: 692px;  text-align:center" runat="server"  HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de prestamo" Visible="True">
                           <ItemTemplate>
                           <asp:Label ID="lblcodprospeto" Text='<%# Eval("COBNUMPRODUCT") %>' runat="server" />
                        </ItemTemplate>

<ControlStyle CssClass="dise&#241;o"></ControlStyle>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre" Visible="True">
                           <ItemTemplate>
                           <asp:Label ID="lbltipotelefono" Text='<%# Eval("CIFNOMBRECLIE") %>' runat="server" />
                        </ItemTemplate>

<ControlStyle CssClass="dise&#241;o"></ControlStyle>
                    </asp:TemplateField>
                         <asp:TemplateField HeaderText="Relación">
                           <ItemTemplate>
                            <asp:Label ID="lblnombretelefono" Text='<%# Eval("COBDESRELACION") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                     </Columns>
     <HeaderStyle CssClass="prueba"  ForeColor="White"></HeaderStyle>
        </asp:GridView>
                </div>

                </div><br />

                <div id="TestimonioRGP" runat="server" visible="false">
                            <label class="titulos"><b>Testimonio inscrito en el RGP</b></label><br />
                         <div class="formato">
                            <asp:DropDownList id="Testimonio" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                            <asp:FileUpload id="FileUpload10" runat="server"></asp:FileUpload>
                            <asp:Button ID="Agregar10" OnClick="agregar10_Click" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" />
                        </div><br /><br />
                        <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 150px">
                        <asp:GridView ID="gridViewTestimonio" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedTestimonio" BorderStyle="Solid">
                             <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false" HeaderText="No. documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lblid" Text='<%# Eval("Codigo") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Tipo documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lbltipodoc" Text='<%# Eval("TipoDocumento") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombredoc" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Ver Documento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="White">
                                    <ItemStyle Width="135px" ForeColor="White"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba" Height="23px" ForeColor="White" BackColor="#0071D4"></HeaderStyle>
                        </asp:GridView>
                       </div>
                       </div><br /><br /><br />
                        </div>
                        


                        <div id="Facturacion" runat="server" visible="false">

                        <div style="display:flex; justify-content:center">
                            <label style="font-size:15px" class="titulos">Facturación</label>
                        </div><br /><br />

                      <label class="titulos" style="margin-bottom:10px"><b>Factura </b></label>
                    
                     <div class="formato">
                        <asp:DropDownList id="TDocumentoFactura" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                       <asp:FileUpload id="FileUpload11" runat="server"></asp:FileUpload>
                         <asp:Button ID="AgregarFactura" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" OnClick="AgregarFactura_Click" />
                    </div><br /><br />

                    <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 123px">
                        <asp:GridView ID="gridViewFactura" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedFactura" BorderStyle="Solid">
                             <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false" HeaderText="No. documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lblid" Text='<%# Eval("Codigo") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Tipo documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lbltipodoc" Text='<%# Eval("TipoDocumento") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                  <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre documento">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombredoc" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Ver Documento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="White">
                                    <ItemStyle Width="135px" ForeColor="White"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba" Height="23px" ForeColor="White" BackColor="#0071D4"></HeaderStyle>
                        </asp:GridView>
                       </div>
                       </div><br /><br />

                 

                       <div class="formatoTitulo" style="margin-bottom:5px">
                             <label class="titulos"><b>No. de factura</b></label>
                            <label class="titulos" style="margin-left:40%"><b>No. de serie</b></label>
                        </div>
                        <div class="formato">
                              <input id="NumFactura" runat="server" type="text" class="formatoinput" placeholder="Ingrese no. factura" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                             <input id="Serie" runat="server" type="text" class="formatoinput" placeholder="Ingrese no. serie" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        </div><br />

                      <div class="formato3">
                        <label class="titulos"><b>Descripción</b></label>
                         <input id="Descripcion2" runat="server" type="text" class="formatoinput2" placeholder="Ingrese descripcion" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                    </div><br />

                    <div class="formatoTitulo" style="margin-bottom:5px">
                        <label class="titulos"><b>Importe total</b></label>
                        <label class="titulos" style="margin-left:23%"><b>Fecha de emisión</b></label>
                        <label class="titulos" style="margin-left:18%"><b>Importe del caso</b></label>
                    </div>
                     <div class="formato">
                        Q<input id="ImporteTotal" runat="server" type="text" class="formatoinput3" min="0" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese importe total" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        <input id="FechaEmision" runat="server" type="date" class="formatoinput3"/>
                        Q<input id="ImporteCaso" runat="server" type="text" min="0" class="formatoinput3" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese importe del caso" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                    </div><br />

                        
                      <div class="formato3">
                         <label class="titulos"><b>Nombre a quién se emite el cheque</b></label>
                         <input id="NombreCheque" runat="server" type="text" class="formatoinput2" placeholder="Ingrese nombre" maxlength="60" onkeypress="return sololetras(event);" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                    </div><br />

                      <div class="formato3">
                        <label class="titulos"><b>Motivo de pago</b></label>
                        <asp:DropDownList id="MotivoPago" runat="server" Width="100%" class="formatoinput2" AutoPostBack="true" OnSelectedIndexChanged="MotivoPago_SelectedIndexChanged1"></asp:DropDownList>
                    </div><br />

                     <input id="Otro" runat="server" type="text" min="0" class="formatoinput2" placeholder="Ingrese otro motivo" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>

                            <br /><br />
                    <div id="Div2" runat="server" class="formato3">
                        <label class="titulos">Observaciones del crédito</label>
                        <input id="ObservacionesCredito" runat="server" type="text" class="formatoinput2" placeholder="Ingrese observaciones" maxlength="150" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                    </div>
                    <br />
                </div>

                <div class="formato2">
                    <asp:Button ID="Guardar" runat="server" CssClass="boton" Text="Guardar" OnClick="Guardar_Click"/>
                  </div><br />

                 <div class="menu2" id="ventana" runat="server" style="overflow: auto; height: 450px">

                    <div class="formato3">
                           <label class="titulos"><b>No. de préstamo</b></label>
                          <input id="CreditoNumero" runat="server" type="text" class="formatoinput5" min="0" placeholder="No. prestamo" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                    </div><br />

                     <div class="formato3">
                         <label class="titulos"><b>Incidente</b></label>
                        <input id="NumeroIncidente" runat="server" type="text" class="formatoinput5" min="0" placeholder="No. incidente" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                    </div><br />

                    <div class="formato3">
                         <label class="titulos"><b>CIF</b></label>
                        <input id="NumCif" runat="server" type="text" class="formatoinput5" min="0" placeholder="CIF" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"/>
                    </div><br />

                    <div class="formato3">
                        <label class="titulos"><b>Cliente - Nombre</b></label>
                        <textarea id="ClienteNombre" runat="server" type="text" class="formatoinput5" placeholder="Cliente - Nombre" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"></textarea>
                    </div><br />

                         <label class="titulos"><b>Comentarios</b></label>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <div class="formato3">
                                    <textarea id="Comentario1" runat="server" type="text" class="formatoinput5" maxlength="150" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readOnly="readOnly"> <%# Eval("Comentario") %> </textarea>
                                </div><br />
                            </ItemTemplate>
                        </asp:Repeater>
                </div>

            </div>
        </div>

          <script>
           $(document).ready(function () {
               $('.menu').load('MenuPrincipal.aspx');
           });
        </script>

        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
<script>
    posicionarMenu();

    $(window).scroll(function () {
        posicionarMenu();
    });

    function posicionarMenu() {
        var altura_del_header = $('.header').outerHeight(true);
        var altura_del_menu = $('.menu2').outerHeight(true);

        if ($(window).scrollTop() >= altura_del_header) {
            $('.menu2').addClass('fixed');
            $('.menu2').addClass('fixed');
            $('.wrapper').css('margin-top', (altura_del_menu) + 'px');
        } else {
            $('.menu2').removeClass('fixed');
            $('.wrapper').css('margin-top', '0');
        }
    }

</script>
    </form>
</body>
</html>
