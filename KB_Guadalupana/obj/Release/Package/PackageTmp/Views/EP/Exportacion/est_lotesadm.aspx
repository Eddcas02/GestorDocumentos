<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true"  CodeBehind="est_lotesadm.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_lotesadm" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="scriptman"> </asp:ScriptManager>
        <div class="container-fluid">
             
            <div class="row" style="margin-top:50px; margin-bottom:-50px">
                   <div class="col-4 ">
           
               
             
  <a href="../../Sesion/MenuBarra.aspx" ><i style="color:black" class="fa fa-home fa-3x"></i></a>


                    </div>
                <div class="col-lg-4">

                </div>
                 <div class="col-lg-4">

                </div>
            </div>
            <div style="margin-top: 10%;" class="row">
                <div class="col-4 ">
           
               
             


                    </div>
                <div class="col-4 ">
                    <h2 style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; text-align: center;">Mantenimiento de Lotes Registrados</h2>
                </div>
                <div class="col-4 ">
                    <h2></h2>
                </div>
            </div>

                 <div id="divh" runat="server"  style="text-align: center;" >
           
                       

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="Crear_Nuevo"
                              BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="popadm" align="center" style = "display:none">
                         <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="Refresh" />      <iframe style=" width: 100%; height: 100%;" id="irm1" src="Venanalotes.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="Crear_Nuevo">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="Panl1" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0" ></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>

                       
                         </div>


       
            <div class="container-fluid">
                   <div class="input-group mb-3">
                       
                                        <div class="col-lg-2" style="text-align: center">
                                            <label></label>
                                            <br />
                                            <asp:Button ID="Crear_Nuevo" Font-Names=" 'Rubik', sans-serif" runat="server"
                                                Width="100%" Height="40px" CssClass="btn1"
                                                Text="Modificar o Crear Lote" OnClick="Crear_Nuevo_Click" />


                                        </div>
                                       

                                    </div>
                <div class="row">


                    <div class="col-lg-12" style="text-align-last: center;">
                        <div class="table-responsive">

                            <%-- Aqui gridview --%>
                            <div class="row"> 

                                <div class="col-md-12" style="overflow-x: auto;">

                                    <asp:GridView ID="lote" CssClass="table table-striped" Style="width: 100%; text-align: center" runat="server" DataKeyNames="LoteID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
                                        AutoGenerateColumns="False"
                                        BorderStyle="Solid"
                                        ShowHeaderWhenEmpty="true"
                                        AllowPaging="true"
                                        PageSize="20"
                                        OnPageIndexChanging="lote_PageIndexChanging"
                                        OnSelectedIndexChanged="lote_SelectedIndexChanged">
                                        <Columns>
                                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                                                <ItemTemplate>
                                                    <asp:Label ID="nofam" Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Lote" Visible="true">
                                                <ItemTemplate>
                                                    <asp:Label ID="LoteID" Width="100%" Text='<%# Eval("LoteID") %>' runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Descripción Lote">
                                                <ItemTemplate>
                                                    <asp:Label ID="LoteDescripcion" Width="100%" Text='<%# Eval("LoteDescripcion") %>' runat="server" />
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Fecha Inicial">
                                                <ItemTemplate>
                                                    <asp:Label ID="LoteFecInicio" Width="100%" Text='<%# Eval("LoteFecInicio") %>' runat="server" />
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Fecha Final">
                                                <ItemTemplate>
                                                    <asp:Label ID="LoteFecFin" Width="100%" Text='<%# Eval("LoteFecFin") %>' runat="server" />
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                                  <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Cambio">
                                                <ItemTemplate>
                                                    <asp:Label ID="LoteTipoCambio" Width="100%" Text='<%# Eval("LoteTipoCambio") %>' runat="server" />
                                                </ItemTemplate>

                                            </asp:TemplateField>
                                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Estado del Lote">
                                                <ItemTemplate>
                                                    <asp:Label ID="LoteEstado" Width="100%" Text='<%# Eval("LoteEstado").ToString() == "True" ? "Abierto": "Cerrado" %>' runat="server" />
                                                </ItemTemplate>

                                            </asp:TemplateField>


                                            <asp:ButtonField Text="Abrir Lote" CommandName="Select" ItemStyle-Width="150" ItemStyle-CssClass="seleccionarregistrogridview">
                                                <ItemStyle Width="150px"></ItemStyle>

                                            </asp:ButtonField>

                                        </Columns>
                                        <HeaderStyle Width="300px" ForeColor="White"></HeaderStyle>
                                    </asp:GridView>

                                 
                                    <br />


                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
