<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventanaUsuarios.aspx.cs" Inherits="KB_Guadalupana.Views.EP.ventanaUsuarios" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="scriptman"> </asp:ScriptManager>
        <div class="container-fluid">
               
            <div style="margin-top: 10%;" class="row">
                <div class="col-4 ">
                    <h2></h2>
                </div>
                <div class="col-4 ">
                    <h2 id="loteestoy" runat="server" style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; text-align: center;">Lotes </h2>
                </div>
                <div class="col-4 ">
                    <h2></h2>
                </div>
            </div>

              <div class="row">
                      <div class="col-lg-4" style="text-align: center">
                                            <label>Asignados</label>
                                            <br />
                           <asp:Label ID="asignados" Text="text" runat="server" />


                                        </div>
                               <div class="col-lg-4" style="text-align: center">
                                            <label>Pendientes</label>
                                            <br />
                                   <asp:Label ID="pendientes" Text="text" runat="server" />

                                        </div>
                     <div class="col-lg-4" style="text-align: center">
                                            <label>Finalizados</label>
                                            <br />
                                   <asp:Label ID="finalizados" Text="text" runat="server" />

                                        </div>
                </div>
            <div class="container-fluid">
                <div class="row">
                       <div class="col-lg-4" style="text-align: center">
                                            <label></label>
                                            <br />
                                            <asp:Button ID="AgregarColaboradorLote" Font-Names=" 'Rubik', sans-serif" runat="server"
                                                Width="100%" Height="40px" CssClass="btn1"
                                                Text="Agregar Colaborador a Lote" OnClick="AgregarColaboradorLote_Click" />


                                        </div>
                     <div class="col-lg-4" style="text-align: center">
                                            <label></label>
                                            <br />
                                            <asp:Button ID="Button2" Font-Names=" 'Rubik', sans-serif" runat="server"
                                                Width="100%" Height="40px" CssClass="btn1"
                                                Text="Regresa a Lotes" PostBackUrl="~/Views/EP/Exportacion/est_lotesadm.aspx"  />


                                        </div>
                     <div class="col-lg-4" style="text-align: center">
                                            <label></label>
                                            <br />
                                            <asp:Button ID="btnlotesindep" Font-Names=" 'Rubik', sans-serif" runat="server"
                                                Width="100%" Height="40px" CssClass="btn1"
                                                Text="Habilitar Colaborador" />


                                        </div>
                                         


                    </div>
           
                <div class="row">

                     
                    <div class="col-lg-12 ">
                        <div class="table-responsive">

                            <%-- Aqui gridview --%>
                            <div class="row">

                                <div class="col-md-12" style="overflow-x: auto;">

                                    <br />
      <asp:GridView ID="lote" CssClass="table table-striped" Style="width: 100%; text-align: center" runat="server" DataKeyNames="ColaboradorID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
                                        AutoGenerateColumns="False"
                                        BorderStyle="Solid"
                                        ShowHeaderWhenEmpty="true"
                                        AllowPaging="true"
                                        PageSize="20"
                                        OnPageIndexChanging="lote_PageIndexChanging"
          OnSelectedIndexChanged="lote_SelectedIndexChanged"
                                        >
            <AlternatingRowStyle BackColor="White" />  
            <Columns>  
             
                    <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorID1"  Width="150px" Text='<%# Eval("ColaboradorID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                   <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="CIF">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorID"  Width="100%" Text='<%# Eval("ColaboradorID") %>' runat="server" />
                        </ItemTemplate>
                     
                    </asp:TemplateField>
                   <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre Completo">
                           <ItemTemplate>
                           <asp:Label ID="nombrepersonal"  Width="100%" Text='<%# Eval("nombrepersonal") %>' runat="server" />
                        </ItemTemplate>
                   
                    </asp:TemplateField>
                 <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Estado">
                           <ItemTemplate>
                           <asp:Label ID="est"  Width="100%" Text='<%# Eval("ColaboradorEstado").ToString() == "True" ? "Finalizado": "Pendiente"  %>' runat="server" />
                        </ItemTemplate>
                   
                    </asp:TemplateField>
                  <asp:ButtonField ControlStyle-Height="20" ButtonType="Image" HeaderText="Reporte" ImageUrl="../../../Imagenes/lupa.png" CommandName="Select" ItemStyle-Width="10" ItemStyle-CssClass="seleccionarregistrogridview">
                            
                            <ItemStyle Width="100px" >

                            </ItemStyle>

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


                 <div id="div1" runat="server"  style="text-align: center;" >
           
                       

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="pan2" TargetControlID="AgregarColaboradorLote"
                              BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="pan2" runat="server" CssClass="popadm" align="center" style = "display:none">
                         <asp:Button ID="Button1" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="Button1_Click" />      <iframe style=" width: 100%; height: 100%;" id="Iframe1" src="est_detalleLotes.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="AgregarColaboradorLote">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="pan2" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0" ></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>

                       
                         </div>
    
          <div id="div2" runat="server"  style="text-align: center;" >
           
                       

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" PopupControlID="Panel1" TargetControlID="btnlotesindep"
                              BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panel1" runat="server" CssClass="popadm" align="center" style = "display:none">
                         <asp:Button ID="Button3" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="Button1_Click" />      <iframe style=" width: 100%; height: 100%;" id="Iframe2" src="ventanausuarioshabil.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender2" runat="server" TargetControlID="btnlotesindep">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="Panel1" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0" ></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>

                       
                         </div>
    
    </form>
</body>
</html>
