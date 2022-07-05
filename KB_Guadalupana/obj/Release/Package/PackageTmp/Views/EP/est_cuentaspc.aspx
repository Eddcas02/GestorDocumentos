<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_cuentaspc.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_cuentaspc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link href="Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="Estaticos/bloqueo.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:ScriptManager ID="scrr" runat="server"> </asp:ScriptManager>        <asp:Label ID="blk" Visible="true"  runat="server" />
       <div class="row">
            <div class="col-12 ">
                <h2>Cuentas por Cobrar<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btncuentasx" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btncuentasx_Click" />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">

                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="cuentasxcx" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorActivoCXCID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" OnPageIndexChanging="cuentasxcx_PageIndexChanging" OnRowEditing="cuentasxcx_RowEditing"
              OnRowDataBound="cuentasxcx_RowDataBound"
                OnRowCancelingEdit="cuentasxcx_RowCancelingEdit"
                OnRowUpdating="cuentasxcx_RowUpdating" OnRowDeleting="cuentasxcx_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolab"  Width="150px" Text='<%# Eval("ColaboradorActivoCXCID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                      


                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Persona/Entidad">
                           <ItemTemplate>
                           <asp:Label ID="origenlblb"  Width="100%" Text='<%# Eval("ColaboradorActivoCXCOrigen") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtorigen" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoCXCOrigen") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Monto">
                           <ItemTemplate>
                           <asp:Label ID="monto"  Width="100%" Text='<%# Eval("ColaboradorActivoCXCMonto") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="montotxt" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoCXCMonto") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Motivo">
                           <ItemTemplate>
                           <asp:Label ID="motivolbl"  Width="100%" Text='<%# Eval("ColaboradorActivoCXCMotivo") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtmotivo" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoCXCMotivo") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>

                              <asp:TemplateField ItemStyle-CssClass="tdstyle"  HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                            <asp:LinkButton ID="lbDelete"  Width="20px" Height="20px" runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete" ><img src="../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
                      </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="../../Imagenes/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                        </EditItemTemplate>
                   
                    </asp:TemplateField>

                   

                     </Columns>
        <HeaderStyle  Width="300px" ForeColor="White"></HeaderStyle>
        </asp:GridView>
          <br />
            <asp:Label ID="lblSuccessMessage1" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage1" Text="" runat="server" ForeColor="Red" />
        </div>    
    </div>
                </div>
            </div>

        </div>

          <div id="divh" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btncuentasx"
                                BackgroundCssClass="Background">
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                                   <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />     <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Ventanas/VentanaCPC.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="btncuentasx">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="Panl1" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0"></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>

                       
                         </div>
    </form>
</body>
</html>
