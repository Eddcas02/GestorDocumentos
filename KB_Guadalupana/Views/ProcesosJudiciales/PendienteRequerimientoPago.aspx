<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PendienteRequerimientoPago.aspx.cs" Inherits="KB_Guadalupana.Views.ProcesosJudiciales.PendienteRequerimientoPago" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
<link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>
    <title>Verificación requerimiento de pago</title>
         <style>
         @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;400&display=swap');

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
            width:1000px;
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
        }

        .formatoinput2{
            width:98%;
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

        .formatoBuscar {
        display: flex;
        flex-direction: row;
        justify-content: flex-start;
        width: 100%;
    }

    </style>
</head>
     <div id="menu" runat="server" class="menu"></div>
<body>
    <form id="form1" runat="server">
         <div class="general">
            <div class="formularioCobros">

                <div id="RequerimientoPago" runat="server">

                  <div style="display:flex; justify-content:center">
                    <label style="font-size:18px" class="titulos">Pendiente requerimiento de pago</label>
                 </div><br />

                <div class="formatoBuscar">
                    <input id="Buscar" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
                <br />

                    <div style="overflow: auto; height: 400px">
                        <asp:GridView ID="gridViewDemanda" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedDemanda" BorderStyle="Solid" OnRowDataBound="gridViewCertificacion_RowDataBound">
                            <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lbletapa" Text='<%# Eval("etapa") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnumcredito" Text='<%# Eval("Credito") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombre" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                    <ItemTemplate>
                                       <asp:Label ID="lblestado" Text='<%# Eval("pj_status") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. Incidente">
                                    <ItemTemplate>
                                       <asp:Label ID="lblincidente" Text='<%# Eval("Incidente") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                        <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                    <ItemTemplate>
                                       <asp:Label ID="lblfecha" Text='<%# Eval("Fecha"," {0:d}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Días transcurridos">
                                    <ItemTemplate>
                                       <asp:Label ID="lbldias" Text='<%# Eval("Dias") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Emitir requerimiento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                        </asp:GridView>
                    </div>
                <br /><br />
                    </div>

                <div id="Apremio" runat="server">

                <div style="display:flex; justify-content:center">
                    <span id="RequerimientoApremio" runat="server" style="font-size:18px" class="titulos">Pendiente requerimiento de pago (Ejecutivo en la vía de apremio)</span>
                 </div><br />

                    <div class="formatoBuscar">
                    <input id="Buscar2" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
                <br />

                 <div style="overflow: auto; height: 400px">
                        <asp:GridView ID="gridViewApremio" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedApremio" BorderStyle="Solid" OnRowDataBound="gridViewApremio_RowDataBound">
                            <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lbletapa" Text='<%# Eval("etapa") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnumcredito" Text='<%# Eval("Credito") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombre" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                    <ItemTemplate>
                                       <asp:Label ID="lblestado" Text='<%# Eval("pj_status") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. Incidente">
                                    <ItemTemplate>
                                       <asp:Label ID="lblincidente" Text='<%# Eval("Incidente") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                        <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                    <ItemTemplate>
                                       <asp:Label ID="lblfecha" Text='<%# Eval("Fecha"," {0:d}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Días transcurridos">
                                    <ItemTemplate>
                                       <asp:Label ID="lbldias" Text='<%# Eval("Dias") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Emitir requerimiento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                        </asp:GridView>
                    </div>
                <br /><br />
                    </div>

                <div id="Notificacion" runat="server">

                <div style="display:flex; justify-content:center">
                    <span id="RequerimientoNotificacion" runat="server" style="font-size:18px" class="titulos">Pendiente requerimiento de pago (Notificacion al asociado E.V.A.)</span>
                 </div><br />

                    <div class="formatoBuscar">
                    <input id="Buscar3" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
                <br />

                <div style="overflow: auto; height: 400px">
                        <asp:GridView ID="gridViewNotificacion" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black" BackColor="White"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedNotificacion" BorderStyle="Solid" OnRowDataBound="gridViewNotificacion_RowDataBound">
                            <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lbletapa" Text='<%# Eval("etapa") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnumcredito" Text='<%# Eval("Credito") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombre" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                    <ItemTemplate>
                                       <asp:Label ID="lblestado" Text='<%# Eval("pj_status") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. Incidente">
                                    <ItemTemplate>
                                       <asp:Label ID="lblincidente" Text='<%# Eval("Incidente") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                        <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                    <ItemTemplate>
                                       <asp:Label ID="lblfecha" Text='<%# Eval("Fecha"," {0:d}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Días transcurridos">
                                    <ItemTemplate>
                                       <asp:Label ID="lbldias" Text='<%# Eval("Dias") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Emitir requerimiento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                        </asp:GridView>
                    </div>
                <br /><br />
                    </div>

                <div id="Honorarios" runat="server">
                    <div style="display:flex; justify-content:center">
                    <span id="RequerimientoHonorarios" runat="server" style="font-size:18px" class="titulos">Pendiente requerimiento de pago 2 (Notificacion al asociado E.V.A.)</span>
                 </div><br />

                    <div class="formatoBuscar">
                    <input id="Buscar4" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
                <br />

                <div style="overflow: auto; height: 400px">
                        <asp:GridView ID="gridViewHonorarios" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedHonorarios" BorderStyle="Solid" OnRowDataBound="gridViewHonorarios_RowDataBound">
                            <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lbletapa" Text='<%# Eval("etapa") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnumcredito" Text='<%# Eval("Credito") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombre" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                    <ItemTemplate>
                                       <asp:Label ID="lblestado" Text='<%# Eval("pj_status") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. Incidente">
                                    <ItemTemplate>
                                       <asp:Label ID="lblincidente" Text='<%# Eval("Incidente") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                        <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                    <ItemTemplate>
                                       <asp:Label ID="lblfecha" Text='<%# Eval("Fecha"," {0:d}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Días transcurridos">
                                    <ItemTemplate>
                                       <asp:Label ID="lbldias" Text='<%# Eval("Dias") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Emitir requerimiento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                        </asp:GridView>
                    </div>
                <br /><br />
                </div>

                <div id="Desistimiento" runat="server">
                    <div style="display:flex; justify-content:center">
                    <span id="Span1" runat="server" style="font-size:18px" class="titulos">Pendiente requerimiento de pago Desistimiento</span>
                 </div><br />

                    <div class="formatoBuscar">
                    <input id="Buscar5" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
                <br />

                <div style="overflow: auto; height: 400px">
                        <asp:GridView ID="gridViewDesistimiento" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black" BackColor="White"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedDesistimiento" BorderStyle="Solid" OnRowDataBound="gridViewDesistimiento_RowDataBound">
                            <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lbletapa" Text='<%# Eval("etapa") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnumcredito" Text='<%# Eval("Credito") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombre" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                    <ItemTemplate>
                                       <asp:Label ID="lblestado" Text='<%# Eval("pj_status") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. Incidente">
                                    <ItemTemplate>
                                       <asp:Label ID="lblincidente" Text='<%# Eval("Incidente") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                        <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                    <ItemTemplate>
                                       <asp:Label ID="lblfecha" Text='<%# Eval("Fecha"," {0:d}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Días transcurridos">
                                    <ItemTemplate>
                                       <asp:Label ID="lbldias" Text='<%# Eval("Dias") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Emitir requerimiento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                        </asp:GridView>
                    </div>
                <br /><br />
                </div>

                <div id="NotificacionApremio" runat="server">
                    <div style="display:flex; justify-content:center">
                    <span id="Span2" runat="server" style="font-size:18px" class="titulos">Pendiente requerimiento de pago (E.V.A.)</span>
                 </div><br />

                    <div class="formatoBuscar">
                    <input id="Buscar6" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
                <br />

                <div style="overflow: auto; height: 400px">
                        <asp:GridView ID="gridViewNotificacionApremio" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black" BackColor="White"
                            OnSelectedIndexChanged = "OnSelectedIndexChangedNotificacionApremio" BorderStyle="Solid" OnRowDataBound="gridViewNotificacionApremio_RowDataBound">
                            <Columns>
                                <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lbletapa" Text='<%# Eval("etapa") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de crédito">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnumcredito" Text='<%# Eval("Credito") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre">
                                    <ItemTemplate>
                                       <asp:Label ID="lblnombre" Text='<%# Eval("Nombre") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                    <ItemTemplate>
                                       <asp:Label ID="lblestado" Text='<%# Eval("pj_status") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. Incidente">
                                    <ItemTemplate>
                                       <asp:Label ID="lblincidente" Text='<%# Eval("Incidente") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                        <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                    <ItemTemplate>
                                       <asp:Label ID="lblfecha" Text='<%# Eval("Fecha"," {0:d}") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Días transcurridos">
                                    <ItemTemplate>
                                       <asp:Label ID="lbldias" Text='<%# Eval("Dias") %>' runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:ButtonField   Text="Emitir requerimiento" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                    <ItemStyle Width="100px"></ItemStyle>
                                </asp:ButtonField>
                            </Columns>
                             <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                        </asp:GridView>
                    </div>
                <br /><br />
                </div>

                <div id="devueltos" runat="server">

                     <div style="display:flex; justify-content:center">
                            <span id="CreditosDevueltos" runat="server" style="font-size:18px" class="titulos">Créditos devueltos</span>
                        </div><br />

                    <div class="formatoBuscar">
                    <input id="Buscar7" runat="server" type="text" class="formatoinput3" placeholder="Buscar..." style="border:0.5px solid #DEDEDE"/>
                    <a class="fondoLupa">
                        <img src="../../Imagenes/Imagenes_procesos/lupa.png" style="height:30px"/>
                    </a>
                </div>
                <br />

                    <div id="tablaC" runat="server" style="overflow: auto; height: 300px">
                            <asp:GridView ID="gridViewCreditos" runat="server" CssClass="tabla" AutoGenerateColumns="False" ForeColor="Black" BackColor="White"
                                OnSelectedIndexChanged = "OnSelectedIndexChangedCreditos" BorderStyle="Solid">
                                <Columns>
                                     <asp:TemplateField ControlStyle-CssClass="diseño" visible="false" HeaderText="No. de crédito">
                                        <ItemTemplate>
                                           <asp:Label ID="lbletapa" Text='<%# Eval("etapa") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                      <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de crédito">
                                        <ItemTemplate>
                                           <asp:Label ID="lblnumcredito" Text='<%# Eval("Credito") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="No. de incidente">
                                        <ItemTemplate>
                                           <asp:Label ID="lblincidente" Text='<%# Eval("Incidente") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Nombre">
                                        <ItemTemplate>
                                           <asp:Label ID="lblnombre" Text='<%# Eval("Nombre") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                      <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Estado">
                                        <ItemTemplate>
                                           <asp:Label ID="lblestado" Text='<%# Eval("Estado") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                       <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Del área de">
                                        <ItemTemplate>
                                           <asp:Label ID="lbldeArea" Text='<%# Eval("DeArea") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Comentario">
                                        <ItemTemplate>
                                           <asp:Label ID="lblcomentario" Text='<%# Eval("Comentario") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Fecha">
                                        <ItemTemplate>
                                           <asp:Label ID="lblfecha" Text='<%# Eval("Fecha","{0:d}") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ControlStyle-CssClass="diseño"  HeaderText="Días transcurridos">
                                        <ItemTemplate>
                                           <asp:Label ID="lbldias" Text='<%# Eval("Dias") %>' runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:ButtonField   Text="Ver crédito" ItemStyle-CssClass="celda fas fa-angle-double-right" CommandName="Select" ItemStyle-Width="90px" ControlStyle-ForeColor="Black">
                                        <ItemStyle Width="100px" ForeColor="Black"></ItemStyle>
                                    </asp:ButtonField>
                                </Columns>
                                 <HeaderStyle CssClass="prueba"  ForeColor="White" BackColor="#0069C4"></HeaderStyle>
                            </asp:GridView>
                        </div><br /><br />

               </div>
            </div>
        </div>

        <script>
           $(document).ready(function () {
               $('.menu').load('MenuPrincipal.aspx');
           });
        </script>

        <script>
            $(document).ready(function () {
                $("#Buscar").on("keyup", function () {
                    var value = $(this).val().toLowerCase();
                    $("#gridViewDemanda tr").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });
        </script>

        <script>
            $(document).ready(function () {
                $("#Buscar2").on("keyup", function () {
                    var value = $(this).val().toLowerCase();
                    $("#gridViewApremio tr").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });
        </script>

        <script>
            $(document).ready(function () {
                $("#Buscar3").on("keyup", function () {
                    var value = $(this).val().toLowerCase();
                    $("#gridViewNotificacion tr").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });
        </script>

        <script>
            $(document).ready(function () {
                $("#Buscar4").on("keyup", function () {
                    var value = $(this).val().toLowerCase();
                    $("#gridViewHonorarios tr").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });
        </script>

        <script>
            $(document).ready(function () {
                $("#Buscar5").on("keyup", function () {
                    var value = $(this).val().toLowerCase();
                    $("#gridViewDesistimiento tr").filter(function () {
                        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                    });
                });
            });
        </script>

        <script>
             $(document).ready(function () {
                 $("#Buscar6").on("keyup", function () {
                     var value = $(this).val().toLowerCase();
                     $("#gridViewNotificacionApremio tr").filter(function () {
                         $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                     });
                 });
             });
         </script>

        <script>
             $(document).ready(function () {
                 $("#Buscar7").on("keyup", function () {
                     var value = $(this).val().toLowerCase();
                     $("#gridViewCreditos tr").filter(function () {
                         $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                     });
                 });
             });
         </script>

    </form>
</body>
</html>
