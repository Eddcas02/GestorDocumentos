<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DiligenciamientoMedidas.aspx.cs" Inherits="KB_Guadalupana.Views.ProcesosJudiciales.DiligenciamientoMedidas" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
<link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>
    <title>Diligenciamiento Medidas Precautorias</title>
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

                 <div style="display:flex; justify-content:center">
                    <label style="font-size:18px" class="titulos">Diligenciamiento a medidas precautorias</label>
                 </div><br />

                 <div class="header"></div>
                
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

                <div class="encabezado">
                     <label style="font-size:15px" class="titulos"><b>Diligenciamiento a medidas precautorias</b></label><br /><br />

                                              <label class="titulos"><b>Seleccione las medidas precautorias diligenciadas</b></label><br /><br />
                           <div class="formatocheck">
                             <div class="formatocheck2">
                                <input id="MedidasPre1" runat="server" type="checkbox" class="formatocheckbox" value="1" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                                <label for="MedidasPre1" class="titulos">&nbsp;&nbsp;<b>Embargo de Salario</b></label>
                             </div>
                              <div class="formatocheck2">
                                <input id="MedidasPre2" runat="server" type="checkbox" class="formatocheckbox" value="2" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                                <label for="MedidasPre2" class="titulos">&nbsp;&nbsp;<b>Embargo de cuentas bancarias</b></label>
                              </div>
                         </div>

                         <div class="formatocheck">
                             <div class="formatocheck2">
                                 <input id="MedidasPre3" runat="server" type="checkbox" class="formatocheckbox" value="3" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                              <label for="MedidasPre3" class="titulos">&nbsp;&nbsp;<b>Arraigo</b></label>
                             </div>
                             <div class="formatocheck2">
                                <input id="MedidasPre4" runat="server" type="checkbox" class="formatocheckbox" value="4" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                                <label for="MedidasPre4" class="titulos">&nbsp;&nbsp;<b>Embargo en cooperativas</b></label>
                             </div>
                         </div>

                         <div class="formatocheck">
                              <div class="formatocheck2">
                                <input id="MedidasPre5" runat="server" type="checkbox" class="formatocheckbox" value="4" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                                <label for="MedidasPre5" class="titulos">&nbsp;&nbsp;<b>Embargo de bienes</b></label>
                             </div>
                             <div class="formatocheck2">
                                <input id="MedidasPre6" runat="server" type="checkbox" class="formatocheckbox" value="5" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                                <label for="MedidasPre6" class="titulos">&nbsp;&nbsp;<b>Otra</b></label>
                             </div>
                         </div>
                        <input id="OtrasMedidas" runat="server" type="text" class="formatoinput2" placeholder="Ingrese nombre de otra medida" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" />
                        <br /><br /><br />

                    <div id="documento" runat="server">
                        <div class="formato">
                            <asp:DropDownList id="OficiosDiligenciados" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                            <asp:FileUpload id="FileUpload7" runat="server"></asp:FileUpload>
                            <asp:Button ID="Agregar7" OnClick="agregar7_Click" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" />
                        </div><br /><br />
                        <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 123px">
                        <asp:GridView ID="gridViewOficios" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedOficios" BorderStyle="Solid">
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
                                    <ItemStyle Width="135px"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba" Height="23px" ForeColor="White" BackColor="#0071D4"></HeaderStyle>
                        </asp:GridView>
                       </div>
                       </div><br /><br />

                           <div id="infoBanco2" runat="server">
                            <div class="formatoTitulo" style="margin-bottom:5px">
                                <label class="titulos"><b>Banco</b></label>
                                <label class="titulos" style="margin-left:47%"><b>Monto embargado</b></label>
                            </div>
                            <div class="formato">
                                 <asp:DropDownList id="Banco" runat="server" class="formatoinput" AutoPostBack="false"></asp:DropDownList>
                                 <input id="MontoEmbargado" runat="server" type="text" class="formatoinput" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese monto embargado" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            </div>
                            <br />
                        </div>

                        <div id="infoCooperativa" runat="server">
                            <div class="formatoTitulo" style="margin-bottom:5px">
                                <span id="TituloCooperativa" runat="server" class="titulos"><b>Cooperativa</b></span>
                                <label class="titulos" style="margin-left:42%"><b>Monto embargado</b></label>
                            </div>
                            <div class="formato">
                                 <asp:DropDownList id="Cooperativa" runat="server" class="formatoinput" AutoPostBack="false"></asp:DropDownList>
                                 <input id="MontoEmbargado2" runat="server" type="text" class="formatoinput" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese monto embargado" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            </div><br />
                        </div>


                        <div id="LugarTrabajoInfo" runat="server" class="formato3" >
                            <span id="TituloTrabajo" runat="server" class="titulos"><b>Lugar de trabajo</b></span>
                            <input id="LugarTrabajo" runat="server" type="text" class="formatoinput2" placeholder="Ingrese lugar de trabajo" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        </div><br />

                   
                        <div id="arraigoInfo" runat="server" class="formato3">
                            <span id="TituloArraigo" runat="server" class="titulos"><b>Fecha presentación de oficio a migración</b></span>
                            <input id="Arraigo" runat="server" type="date" class="formatoinput2" />
                        </div><br />

                         <div id="OficioTrabajoInfo" runat="server" class="formato3">
                            <span id="OficioTrabajo" runat="server" class="titulos"><b>Fecha presentación de oficio al lugar de trabajo</b></span>
                            <input id="OficioTrabajo2" runat="server" type="date" class="formatoinput2" />
                        </div>

                        <br /><br />
                    </div>

                     <div class="formato3">
                        <label class="titulos"><b>¿Son efectivas?</b></label>
                        <asp:DropDownList id="SonEfectivas" runat="server" Width="100%" class="formatoinput2" AutoPostBack="true" OnSelectedIndexChanged="SonEfectivas_SelectedIndexChanged"></asp:DropDownList>
                    </div><br /><br />

                    <div id="SiEfectivas" runat="server">
                        <br />
                         <label class="titulos"><b>Informe de la efectividad de las medidas precautorias (Opcional)</b></label><br />
                        <div class="formato">
                            <asp:DropDownList id="PTipoDocumento" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                            <asp:FileUpload id="FileUpload1" runat="server"></asp:FileUpload>
                            <asp:Button ID="Agregar" OnClick="agregar_Click" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" />
                        </div><br /><br />

                          <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 150px">
                        <asp:GridView ID="gridViewDocumentos" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedDocumento" BorderStyle="Solid">
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

                        <div class="formato3" >
                            <label class="titulos"><b>Fecha de informe</b></label>
                            <input id="FechaInforme" runat="server" type="date" class="formatoinput2" />
                        </div><br />


                        <div id="infoBanco3" runat="server">
                            <div class="formatoTitulo" style="margin-bottom:5px">
                                <label class="titulos"><b>Banco</b></label>
                                <label class="titulos" style="margin-left:47%"><b>Monto embargado</b></label>
                            </div>
                            <div class="formato">
                                 <asp:DropDownList id="Banco3" runat="server" class="formatoinput" AutoPostBack="false"></asp:DropDownList>
                                 <input id="MontoEmbargado5" runat="server" type="text" class="formatoinput" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese monto embargado" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            </div>
                            <br />
                        </div>

                        <div id="infoCooperativa3" runat="server">
                            <div class="formatoTitulo" style="margin-bottom:5px">
                                <span id="TituloCooperativa3" runat="server" class="titulos"><b>Cooperativa</b></span>
                                <label class="titulos" style="margin-left:42%"><b>Monto embargado</b></label>
                            </div>
                            <div class="formato">
                                 <asp:DropDownList id="Cooperativa3" runat="server" class="formatoinput" AutoPostBack="false"></asp:DropDownList>
                                 <input id="MontoEmbargado6" runat="server" type="text" class="formatoinput" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese monto embargado" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            </div><br />
                        </div>


                        <div id="infoLugarTrabajo3" runat="server" class="formato3">
                            <span id="TituloTrabajo3" runat="server" class="titulos"><b>Lugar de trabajo</b></span>
                            <input id="LugarTrabajo3" runat="server" type="text" class="formatoinput2" placeholder="Ingrese lugar de trabajo" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        </div><br />

                   
                        <div id="infoArraigo3" runat="server" class="formato3">
                            <span id="TituloArraigo3" runat="server" class="titulos"><b>Fecha presentación de oficio a migración</b></span>
                            <input id="Arraigo3" runat="server" type="date" class="formatoinput2" />
                        </div><br />

                         <div id="infoOficioTrabajo3" runat="server" class="formato3">
                            <span id="OficioTrabajo4" runat="server" class="titulos"><b>Fecha presentación de oficio al lugar de trabajo</b></span>
                            <input id="OficioTrabajo5" runat="server" type="date" class="formatoinput2" />
                        </div>

                        <br /><br />
                    </div>

                    <div class="formato3" id="Suficientes" runat ="server">
                        <label class="titulos"><b>¿Son suficientes?</b></label>
                        <asp:DropDownList id="SonSuficientes" runat="server" Width="100%" class="formatoinput2" AutoPostBack="true" OnSelectedIndexChanged="SonSuficientes_SelectedIndexChanged"></asp:DropDownList>
                    <br /><br />
                     </div>

                      <div id="SiSuficiente" runat="server">
                         <div class="formato3">
                            <label class="titulos"><b>Comentario</b></label>
                            <input id="Comentario2" runat="server" type="text" class="formatoinput2" placeholder="Ingrese comentario" maxlength="150" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        </div><br />

                          <div class="formato" style="align-content:center;justify-content:center;align-items:center">
                            <asp:Button ID="SolicitudCobros" runat="server" Width="35%" Height="30px" CssClass="boton3" Text="Enviar Solicitud a Cobros" OnClick="SolicitudCobros_Click" />
                        </div><br />
                    </div>

                    <div id="NoEfectivas" runat="server">
                         <div class="formato3">
                            <label class="titulos"><b>Comentario</b></label>
                            <input id="Comentario" runat="server" type="text" class="formatoinput2" placeholder="Ingrese comentario" maxlength="150" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        </div><br />

                        <div class="formatoTitulo" style="margin-bottom:5px">
                            <label class="titulos"><b>Días de mora</b></label>
                        </div>
                          <div class="formato">
                            <input id="DiasMora" runat="server" type="text" class="formatoinput" placeholder="Días de mora" maxlength="15" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" readonly="readonly"/>
                            <asp:Button ID="EnviarSolicitud" runat="server" Width="35%" Height="30px" CssClass="boton3" Text="Enviar Solicitud" OnClick="EnviarSolicitud_Click" />
                        </div><br />
                    </div>

                    
                    
                    <div class="formato3" id="HayResultado" runat="server">
                        <br /><br />
                        <label class="titulos"><b>¿Hay Resultados?</b></label>
                        <asp:DropDownList id="Resultado" runat="server" Width="100%" class="formatoinput2" AutoPostBack="true" OnSelectedIndexChanged="Resultado_SelectedIndexChanged"></asp:DropDownList>
                    <br /><br />
                    </div>

                     <div id="SiResultados" runat="server">
                          <label class="titulos"><b>Documentación de soporte</b></label><br />
                        <div class="formato">
                            <asp:DropDownList id="TipoDocumentacion" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                            <asp:FileUpload id="FileUpload4" runat="server"></asp:FileUpload>
                            <asp:Button ID="Agregar4" OnClick="agregar4_Click" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" />
                        </div><br /><br />

                      <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 150px">
                        <asp:GridView ID="gridViewDocumentacion" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedDocumentacion" BorderStyle="Solid">
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

                          <div class="formato3" id="Empresa" runat="server">
                            <label class="titulos"><b>Empresa donde labora</b></label>
                            <input id="EmpresaLabora" runat="server" type="text" class="formatoinput2" placeholder="Ingrese empresa donde labora" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        </div><br />

                        <div id="Vehiculos" runat="server">
                            <label style="font-size:13px" class="titulos"><b>Vehículo(s)</b></label><br /><br />

                            <div class="formato" style="align-items:center">
                                <div style="width:100%">
                                    <div class="formatoTitulo" style="margin-bottom:5px">
                                        <label class="titulos"><b>NIT</b></label>
                                        <label class="titulos" style="margin-left:46%"><b>Placa</b></label>
                                    </div>
                                    <div class="formato">
                                        <input id="NIT" runat="server" type="text" class="formatoinput" placeholder="Ingrese NIT" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                                        <input id="Placa" runat="server" type="text" class="formatoinput" placeholder="Ingrese Placa" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                                    </div><br />

                                    <div class="formatoTitulo" style="margin-bottom:5px">
                                        <label class="titulos"><b>Modelo</b></label>
                                        <label class="titulos" style="margin-left:38%"><b>Marca</b></label>
                                    </div>
                                    <div class="formato">
                                        <input id="Modelo" runat="server" type="text" class="formatoinput" placeholder="Ingrese Marca" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                                        <input id="Marca" runat="server" type="text" class="formatoinput" placeholder="Ingrese Modelo" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                                    </div><br />
                                </div>
                                <div class="formato3" style="justify-content:center;width:100%;display:flex;align-items:center;align-content:center">
                                 <asp:Button ID="AgregarVehiculo" runat="server" Width="50%" Height="30px" CssClass="boton3" Text="Agregar Vehículo" OnClick="AgregarVehiculo_Click" /><br />
                                 <asp:Button ID="ActualizarVehiculo" runat="server" Width="50%" Height="30px" CssClass="boton3" Text="Actualizar Vehículo" OnClick="ActualizarVehiculo_Click" /><br />
                                 <asp:Button ID="Cancelar" runat="server" Width="50%" Height="30px" CssClass="boton3" Text="Cancelar" OnClick="CancelarVehiculo_Click" />
                                </div>
                             </div><br /><br />

                            <div style="justify-content: center;display:flex" class="formato">
                            <div style="overflow: auto; height: 150px; width:100%">
                            <asp:GridView ID="gridViewVehiculo" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                                OnSelectedIndexChanged = "OnSelectedIndexChangedVehiculo" BorderStyle="Solid">
                                 <Columns>
                                    <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false" HeaderText="Codigo">
                                        <ItemTemplate>
                                           <asp:Label ID="lblid" Text='<%# Eval("Codigo") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nit">
                                        <ItemTemplate>
                                           <asp:Label ID="lblnit" Text='<%# Eval("Nit") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Placa">
                                        <ItemTemplate>
                                           <asp:Label ID="lblplaca" Text='<%# Eval("Placa") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Modelo">
                                        <ItemTemplate>
                                           <asp:Label ID="lblmodelo" Text='<%# Eval("Modelo") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Marca">
                                        <ItemTemplate>
                                           <asp:Label ID="lblmarca" Text='<%# Eval("Marca") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:ButtonField Text="Editar" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="20%" ControlStyle-ForeColor="White">
                                        <ItemStyle Width="90%" ForeColor="White"></ItemStyle>
                                    </asp:ButtonField>
                                </Columns>
                                 <HeaderStyle CssClass="prueba" Height="23px" ForeColor="White" Width="20%" BackColor="#0071D4"></HeaderStyle>
                            </asp:GridView>
                           </div>
                           </div><br /><br />
                        </div>

                         <div id="Bienes" runat="server">
                             <label style="font-size:13px" class="titulos"><b>Bienes Inmuebles</b></label><br /><br />

                             <div class="formato" style="align-items:center">
                                <div style="width:100%">
                                     <div class="formatoTitulo" style="margin-bottom:5px">
                                        <label class="titulos"><b>Finca</b></label>
                                        <label class="titulos" style="margin-left:39%"><b>Folio</b></label>
                                    </div>
                                     <div class="formato">
                                        <input id="Finca" runat="server" type="text" class="formatoinput" placeholder="Ingrese Finca" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                                        <input id="Folio" runat="server" type="text" class="formatoinput" placeholder="Ingrese Folio" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                                    </div><br />

                                    <div class="formato3">
                                        <label class="titulos"><b>Libro</b></label>
                                        <input id="Libro" runat="server" type="text" class="formatoinput2" placeholder="Ingrese Libro" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                                    </div><br />
                                </div>
                                <div class="formato3" style="justify-content:center;width:100%;display:flex;align-items:center;align-content:center">
                                    <asp:Button ID="AgregarBienes" runat="server" Width="50%" Height="30px" CssClass="boton3" Text="Agregar Bien Inmueble" OnClick="AgregarBienes_Click" /><br />
                                    <asp:Button ID="ActualizarBienes" runat="server" Width="50%" Height="30px" CssClass="boton3" Text="Actualizar Bien Inmueble" OnClick="ActualizarBienes_Click" /><br />
                                    <asp:Button ID="Cancelar2" runat="server" Width="50%" Height="30px" CssClass="boton3" Text="Cancelar" OnClick="Cancelar2_Click" />
                                </div>
                                </div>

                             <div style="justify-content: center;display:flex" class="formato">
                            <div style="overflow: auto; height: 150px; width:100%">
                            <asp:GridView ID="gridViewBienes" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                                OnSelectedIndexChanged = "OnSelectedIndexChangedBienes" BorderStyle="Solid">
                                 <Columns>
                                    <asp:TemplateField ControlStyle-CssClass="diseño" Visible="false" HeaderText="No. documento">
                                        <ItemTemplate>
                                           <asp:Label ID="lblid" Text='<%# Eval("Codigo") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Finca">
                                        <ItemTemplate>
                                           <asp:Label ID="lblfinca" Text='<%# Eval("Finca") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Folio">
                                        <ItemTemplate>
                                           <asp:Label ID="lblfolio" Text='<%# Eval("Folio") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Libro">
                                        <ItemTemplate>
                                           <asp:Label ID="lbllibro" Text='<%# Eval("Libro") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:ButtonField   Text="Editar" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="25%" ControlStyle-ForeColor="White">
                                        <ItemStyle Width="90%" ForeColor="White"></ItemStyle>
                                    </asp:ButtonField>
                                </Columns>
                                 <HeaderStyle CssClass="prueba" Height="23px" Width="25%" ForeColor="White" BackColor="#0071D4"></HeaderStyle>
                            </asp:GridView>
                           </div>
                           </div><br /><br />
                         </div>
                         
                          <label class="titulos"><b>Memorial de Medidas Precautorias</b></label><br />
                        <div class="formato">
                            <asp:DropDownList id="TipoMemorial" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                            <asp:FileUpload id="FileUpload5" runat="server"></asp:FileUpload>
                            <asp:Button ID="Agregar5" OnClick="agregar5_Click" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" />
                        </div><br /><br />

                          <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 150px">
                        <asp:GridView ID="gridViewMemorial" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedMemorial" BorderStyle="Solid">
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

                         <label style="font-size:13px" class="titulos"><b>Gestión realizada para cada medida precautoria otorgada</b></label><br /><br />

                        <div class="formato">
                             <label class="titulos"><b>Embargo de Salario</b></label>
                             <asp:DropDownList id="Gestion1" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                        </div><br />

                        <div class="formato">
                            <label class="titulos"><b>Embargo de cuentas bancarias</b></label>
                            <asp:DropDownList id="Gestion2" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                        </div><br />

                        <div class="formato">
                            <label class="titulos"><b>Arraigo</b></label>
                            <asp:DropDownList id="Gestion3" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                        </div><br />

                        <div class="formato">
                            <label class="titulos"><b>Embargo en cooperativas</b></label>
                            <asp:DropDownList id="Gestion4" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                        </div><br />

                         <div class="formato">
                            <label class="titulos"><b>Embargo de bienes</b></label>
                            <asp:DropDownList id="Gestion5" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                        </div><br /><br /><br />

                         <div class="formato3">
                            <label class="titulos"><b>Fecha de presentación del memorial</b></label>
                            <input id="FechaMemorial" runat="server" type="date" class="formatoinput2"/>
                         </div><br /><br />

                         <div class="formatoTitulo" style="margin-bottom:5px">
                            <label class="titulos"><b>Fecha de solicitud de sentencia</b></label>
                            <label class="titulos" style="margin-left:28%"><b>Fecha de presentación de demanda en vía de apremio</b></label>
                         </div>
                         <div class="formato">
                            <input id="FechaSolicitud" runat="server" type="date" class="formatoinput"/>
                            <input id="FechaPresentacionApremio" runat="server" type="date" class="formatoinput"/>
                         </div><br />

                    </div>

                     <div class="formato3" id="EsVoluntaria" runat="server">
                        <label class="titulos"><b>¿La transacción es voluntaria?</b></label>
                        <asp:DropDownList id="Voluntaria" runat="server" Width="100%" class="formatoinput2" AutoPostBack="true" OnSelectedIndexChanged="Voluntaria_SelectedIndexChanged"></asp:DropDownList>
                    </div><br /><br />

                    <div id="TransaccionVoluntaria" runat="server"><br />
                        <div class="formato3" id="fechaPresentacionMemorial" runat="server">
                            <label class="titulos"><b>Fecha de presentación de memorial de transacción</b></label>
                            <input id="FechaPresentacion" runat="server" type="date" class="formatoinput2"/>
                        </div><br />

                        <div id="InfoMonto" runat="server" class="formato3">
                             <label class="titulos"><b>Monto a transar</b></label>
                             <input id="MontoTransar" runat="server" type="text" class="formatoinput2" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese monto a transar" maxlength="15" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            <br /><br />
                        </div>

                         <div id="InfoTrabajo" runat="server" class="formato3">
                            <label class="titulos"><b>Lugar de trabajo</b></label>
                            <input id="LugarTrabajo2" runat="server" type="text" class="formatoinput2" placeholder="Ingrese lugar de trabajo" maxlength="100" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            <br />
                         </div>

                        <div id="infoBanco" runat="server">
                            <div class="formatoTitulo" style="margin-bottom:5px">
                                <label class="titulos"><b>Banco</b></label>
                                <label class="titulos" style="margin-left:47%"><b>Monto embargado</b></label>
                            </div>
                            <div class="formato">
                                <asp:DropDownList id="Banco2" runat="server" class="formatoinput" AutoPostBack="false"></asp:DropDownList>
                                <input id="MontoEmbargado3" runat="server" type="text" class="formatoinput" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese monto embargado" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            </div><br />
                        </div>

                        <div id="infoCooperativa2" runat="server">
                             <div class="formatoTitulo" style="margin-bottom:5px">
                                    <span id="Span1" runat="server" class="titulos"><b>Cooperativa</b></span>
                                    <label class="titulos" style="margin-left:42%"><b>Monto embargado</b></label>
                            </div>
                            <div class="formato">
                                 <asp:DropDownList id="Cooperativa2" runat="server" class="formatoinput" AutoPostBack="false"></asp:DropDownList>
                                 <input id="MontoEmbargado4" runat="server" type="text" class="formatoinput" onkeyup="format(this)" onchange="format(this);" placeholder="Ingrese monto embargado" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                            </div><br /><br />
                        </div>

                        <div id="MemorialTransaccion" runat="server">

                        <label class="titulos"><b>Memorial de transacción</b></label><br />
                         <div class="formato">
                            <asp:DropDownList id="TipoDocumentoMemorial" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                            <asp:FileUpload id="FileUpload2" runat="server"></asp:FileUpload>
                            <asp:Button ID="Agregar2" OnClick="agregar2_Click" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" />
                        </div><br /><br />

                         <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 150px">
                        <asp:GridView ID="gridViewDocumentoMemorial" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedDocumentoMemorial" BorderStyle="Solid">
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

                       </div>
                    </div>


                    <div id="ResolucionTransaccion" runat="server">
                        <br />
                         <label class="titulos"><b>Resolución de transacción</b></label><br />
                        <div class="formato">
                            <asp:DropDownList id="TipoDocumentoResolucion" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                            <asp:FileUpload id="FileUpload3" runat="server"></asp:FileUpload>
                            <asp:Button ID="Agregar3" OnClick="agregar3_Click" runat="server" Width="20%" Height="30px" CssClass="boton3" Text="Agregar" />
                        </div><br /><br />
                          <div style="justify-content: center;display:flex" class="formato">
                        <div style="overflow: auto; height: 150px">
                        <asp:GridView ID="gridViewDocumentoResolucion" runat="server" AutoGenerateColumns="False" CssClass="tabla"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedDocumentoResolucion" BorderStyle="Solid">
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
                            <label class="titulos"><b>Fecha de resolución de transaciión</b></label>
                            <label class="titulos" style="margin-left:35%"><b>Fecha de notificación</b></label>
                        </div>
                        <div class="formato">
                            <input id="FechaResolucion" runat="server" type="date" class="formatoinput"/>
                            <input id="FechaNotificacion" runat="server" type="date" class="formatoinput"/>
                        </div><br />

                       <div class="formato3">
                            <label class="titulos"><b>Observaciones</b></label>
                            <input id="Observaciones" runat="server" type="text" class="formatoinput2" placeholder="Ingrese observaciones" maxlength="150" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                        </div><br />

                          <div id="Facturacion" runat="server">

                        <div style="display:flex; justify-content:center">
                            <label style="font-size:15px" class="titulos">Facturación</label>
                        </div><br /><br />

                      <label class="titulos" style="margin-bottom:10px"><b>Factura </b></label>
                    
                     <div class="formato">
                        <asp:DropDownList id="TDocumentoFactura" runat="server" class="formatoinput3" AutoPostBack="false"></asp:DropDownList>
                       <asp:FileUpload id="FileUpload6" runat="server"></asp:FileUpload>
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
                         <input id="Descripcion" runat="server" type="text" class="formatoinput2" placeholder="Ingrese descripcion" maxlength="50" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
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

                        
                 <%--     <div class="formato3">
                         <label class="titulos"><b>Nombre a quién se emite el cheque</b></label>
                         <input id="NombreCheque" runat="server" type="text" class="formatoinput2" placeholder="Ingrese nombre" maxlength="60" onkeypress="return sololetras(event);" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>
                    </div><br />--%>

                      <div class="formato3">
                        <label class="titulos"><b>Motivo de pago</b></label>
                        <asp:DropDownList id="MotivoPago" runat="server" Width="100%" class="formatoinput2" AutoPostBack="true" OnSelectedIndexChanged="MotivoPago_SelectedIndexChanged1"></asp:DropDownList>
                    </div><br />

                     <input id="Otro" runat="server" type="text" min="0" class="formatoinput2" placeholder="Ingrese otro motivo" maxlength="11" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"/>

                        
                    <br />
                </div>

                    </div>


                </div>

                <div class="formato2">
                    <asp:Button ID="Guardar" runat="server" CssClass="boton" Text="Guardar" Visible="false" OnClick="Guardar_Click"/>
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
            document.getElementById('OtrasMedidas').style.visibility = "hidden";

            function on() {
                //alert("Hemos pulsado en on");
                document.getElementById('OtrasMedidas').style.visibility = "visible";
            }

            function off() {
                //alert("Hemos pulsado en off");
                document.getElementById('OtrasMedidas').style.visibility = "hidden";
            }

            var checkbox6 = document.getElementById('MedidasPre6');
            checkbox6.addEventListener("change", comprueba, false);

            function comprueba() {
                if (checkbox6.checked) {
                    on();
                } else {
                    off();
                }
            }

        </script>

        <script>
            document.getElementById('infoBanco2').style.visibility = "hidden";

            function on2() {
                //alert("Hemos pulsado en on");
                document.getElementById('infoBanco2').style.visibility = "visible";
            }

            function off2() {
                //alert("Hemos pulsado en off");
                document.getElementById('infoBanco2').style.visibility = "hidden";
            }

            var checkbox7 = document.getElementById('MedidasPre2');
            checkbox7.addEventListener("change", comprueba2, false);

            function comprueba2() {
                if (checkbox7.checked) {
                    on2();
                } else {
                    off2();
                }
            }

        </script>

       


        <script>
            document.getElementById('infoCooperativa').style.visibility = "hidden";

            function on3() {
                //alert("Hemos pulsado en on");
                document.getElementById('infoCooperativa').style.visibility = "visible";
            }

            function off3() {
                //alert("Hemos pulsado en off");
                document.getElementById('infoCooperativa').style.visibility = "hidden";
            }

            var checkbox8 = document.getElementById('MedidasPre4');
            checkbox8.addEventListener("change", comprueba3, false);

            function comprueba3() {
                if (checkbox8.checked) {
                    on3();
                } else {
                    off3();
                }
            }

        </script>

        <script>
            document.getElementById('LugarTrabajoInfo').style.visibility = "hidden";

            function on4() {
                //alert("Hemos pulsado en on");
                document.getElementById('LugarTrabajoInfo').style.visibility = "visible";
            }

            function off4() {
                //alert("Hemos pulsado en off");
                document.getElementById('LugarTrabajoInfo').style.visibility = "hidden";
            }

            var checkbox9 = document.getElementById('MedidasPre1');
            checkbox9.addEventListener("change", comprueba4, false);

            function comprueba4() {
                if (checkbox9.checked) {
                    on4();
                } else {
                    off4();
                }
            }

        </script>

        <script>
            document.getElementById('arraigoInfo').style.visibility = "hidden";
            document.getElementById('OficioTrabajoInfo').style.visibility = "hidden";

            function on5() {
                //alert("Hemos pulsado en on");
                document.getElementById('arraigoInfo').style.visibility = "visible";
                document.getElementById('OficioTrabajoInfo').style.visibility = "visible";
            }

            function off5() {
                //alert("Hemos pulsado en off");
                document.getElementById('arraigoInfo').style.visibility = "hidden";
                document.getElementById('OficioTrabajoInfo').style.visibility = "hidden";
            }

            var checkbox10 = document.getElementById('MedidasPre3');
            checkbox10.addEventListener("change", comprueba5, false);

            function comprueba5() {
                if (checkbox10.checked) {
                    on5();
                } else {
                    off5();
                }
            }

        </script>

    <%--    <script>
            document.getElementById('LugarTrabajo').style.visibility = "hidden";
            document.getElementById('TituloTrabajo').style.visibility = "hidden";
            document.getElementById('Banco').style.visibility = "hidden";
            document.getElementById('TituloBanco').style.visibility = "hidden";
            document.getElementById('Cooperativa').style.visibility = "hidden";
            document.getElementById('TituloCooperativa').style.visibility = "hidden";
            document.getElementById('Arraigo').style.visibility = "hidden";
            document.getElementById('TituloArraigo').style.visibility = "hidden";
            document.getElementById('Monto').style.visibility = "hidden";
            document.getElementById('TituloMonto').style.visibility = "hidden";

            function on() {
                //alert("Hemos pulsado en on");
                document.getElementById('LugarTrabajo').style.visibility = "visible";
                document.getElementById('TituloTrabajo').style.visibility = "visible";
            }

            function off() {
                //alert("Hemos pulsado en off");
                document.getElementById('LugarTrabajo').style.visibility = "hidden";
                document.getElementById('TituloTrabajo').style.visibility = "hidden";
            }

            function on2() {
                //alert("Hemos pulsado en on");
                document.getElementById('Banco').style.visibility = "visible";
                document.getElementById('TituloBanco').style.visibility = "visible";
                document.getElementById('Monto').style.visibility = "visible";
                document.getElementById('TituloMonto').style.visibility = "visible";
            }

            function off2() {
                //alert("Hemos pulsado en off");
                document.getElementById('Banco').style.visibility = "hidden";
                document.getElementById('TituloBanco').style.visibility = "hidden";
                document.getElementById('Monto').style.visibility = "hidden";
                document.getElementById('TituloMonto').style.visibility = "hidden";
            }

            function on3() {
                //alert("Hemos pulsado en on");
                document.getElementById('Arraigo').style.visibility = "visible";
                document.getElementById('TituloArraigo').style.visibility = "visible";
            }

            function off3() {
                //alert("Hemos pulsado en off");
                document.getElementById('Arraigo').style.visibility = "hidden";
                document.getElementById('TituloArraigo').style.visibility = "hidden";
            }

            function on4() {
                //alert("Hemos pulsado en on");
                document.getElementById('Cooperativa').style.visibility = "visible";
                document.getElementById('TituloCooperativa').style.visibility = "visible";
                document.getElementById('Monto').style.visibility = "visible";
                document.getElementById('TituloMonto').style.visibility = "visible";
            }

            function off4() {
                //alert("Hemos pulsado en off");
                document.getElementById('Cooperativa').style.visibility = "hidden";
                document.getElementById('TituloCooperativa').style.visibility = "hidden";
                document.getElementById('Monto').style.visibility = "hidden";
                document.getElementById('TituloMonto').style.visibility = "hidden";
            }

            function on5() {
                
            }

            function off5() {
                
            }

            var checkbox = document.getElementById('MedidasPre1');
            var checkbox2 = document.getElementById('MedidasPre2');
            var checkbox3 = document.getElementById('MedidasPre3');
            var checkbox4 = document.getElementById('MedidasPre4');
            var checkbox5 = document.getElementById('MedidasPre5');
            var checkbox6 = document.getElementById('MedidasPre6');

            checkbox.addEventListener("change", comprueba, false);
            checkbox2.addEventListener("change", comprueba2, false);
            checkbox3.addEventListener("change", comprueba3, false);
            checkbox4.addEventListener("change", comprueba4, false);
            checkbox5.addEventListener("change", comprueba5, false);
            checkbox6.addEventListener("change", comprueba6, false);

            function comprueba() {
                if (checkbox.checked) {
                    on();
                } else {
                    off();
                }
            }

            function comprueba2() {
                if (checkbox2.checked) {
                    on2();
                } else {
                    off2();
                }
            }

            function comprueba3() {
                if (checkbox3.checked) {
                    on3();
                } else {
                    off3();
                }
            }

            function comprueba4() {
                if (checkbox4.checked) {
                    on4();
                } else {
                    off4();
                }
            }

            function comprueba5() {
                if (checkbox5.checked) {
                    on5();
                } else {
                    off5();
                }
            }
        </script>--%>

         <script>
           $(document).ready(function () {
               $('.menu').load('MenuPrincipal.aspx');
           });
         </script>

                <script type="text/javascript">
                    function sololetras(evt) {
                        var charCode = (evt.which) ? evt.which : event.keyCode
                        if (charCode > 31 && (charCode < 48 || charCode > 57))
                            return true;

                        return false;
                    }
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

              $('#OtrosGastos').mask('000,000,000.00', { reverse: true });

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
