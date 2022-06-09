    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_telefonos.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_telefonos" %>
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
          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
             <%-- Datos Estudios --%>
                <asp:Label ID="blk" Visible="true"  runat="server" />
             <div class="row">
            <div class="col-12 ">
                <h2>Teléfonos<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                   <label></label>
                     <asp:Button ID="btntelefonos" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btnemergencias_Click" />
                      
                   </div>
        </div>
           <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
                 
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="telefoonosdgv" CssClass="table table-striped" 
              style="width: 100%;text-align:center" runat="server" 
              DataKeyNames="ColaboradorTelefonoNumero" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"
              AllowPaging="true"
              PageSize="10"
              OnPageIndexChanging="telefoonosdgv_PageIndexChanging" 
              OnRowEditing="telefoonosdgv_RowEditing"
              OnRowDataBound="telefoonosdgv_RowDataBound"
                OnRowCancelingEdit="telefoonosdgv_RowCancelingEdit"
                OnRowUpdating="telefoonosdgv_RowUpdating" OnRowDeleting="telefoonosdgv_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolabtel"  Width="150px" Text='<%# Eval("ColaboradorTelefonoNumero") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Teléfono">
                           <ItemTemplate>
                           <asp:Label ID="telefono"  Width="100%" Text='<%# Eval("ColaboradorTelefonoNumero") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtnumerotel" TextMode="Number"  maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"  Text='<%# Eval("ColaboradorTelefonoNumero") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>     
                              <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo">
                           <ItemTemplate>
                           <asp:Label ID="tipotel"  Width="100%" Text='<%# Eval("TipoTelefonoDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="tipotelefonodrp" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     
                      
                           


                    
                              <asp:TemplateField ItemStyle-CssClass="tdstyle" HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                             <asp:LinkButton ID="lbDelete"  runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete" Text=""><img src="../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
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
            <asp:Label ID="lblSuccessMessage12" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage12" Text="" runat="server" ForeColor="Red" />
        </div>    
    </div>
                </div>
            </div>

        </div>




    <div class="row">
            <div class="col-12 ">
                <h2>Contactos de Emergencia<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btnemergencias" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btnemergencias_Click" />
            </div>
        </div>
           <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
               
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="contactoemergen" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorContactoEID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" OnPageIndexChanging="contactoemergen_PageIndexChanging" OnRowEditing="contactoemergen_RowEditing"
              OnRowDataBound="contactoemergen_RowDataBound"
                OnRowCancelingEdit="contactoemergen_RowCancelingEdit"
                OnRowUpdating="contactoemergen_RowUpdating" OnRowDeleting="contactoemergen_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolab"  Width="150px" Text='<%# Eval("ColaboradorContactoEID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre">
                           <ItemTemplate>
                           <asp:Label ID="nombre"  Width="100%" Text='<%# Eval("ColaboradorContactoENombre") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtcontactonom" TextMode="SingleLine" Text='<%# Eval("ColaboradorContactoENombre") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                               <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Teléfono">
                           <ItemTemplate>
                           <asp:Label ID="tel"  Width="100%"  Text='<%# Eval("ColaboradorContactoETelefono") %>' runat="server" />
                        </ItemTemplate>
                              <EditItemTemplate>
                            <asp:TextBox ID="txttelcontacto"  maxlength="8"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"  TextMode="Number" Text='<%# Eval("ColaboradorContactoETelefono") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                      
                              <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Parentesco">
                           <ItemTemplate>
                           <asp:Label ID="parentesco"  Width="100%" Text='<%# Eval("TipoParentescoDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="tipoparentesco" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     
                      
                           


                     

                              <asp:TemplateField ItemStyle-CssClass="tdstyle" HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                            <asp:LinkButton ID="lbDelete"  Width="20px" Height="20px" runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete" Text=""><img src="../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
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
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnemergencias"
                                 BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                                    <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cargadenuevo" />                  <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Ventanas/VentanaEmergencias.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="btnemergencias">
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



     

       
         <div id="div1" runat="server"  style="text-align: center;" >
           
   
                             <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="paneli2" TargetControlID="btntelefonos"
                                BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="paneli2" runat="server" CssClass="Popup" align="center" style = "display:none">
                          <asp:Button ID="Button3" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cargadenuevo" />  
                                 <iframe style=" width: 100%; height: 100%;" id="Iframe1" src="~/Views/EP/Ventanas/VentanaTelefonos.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="btntelefonos">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="paneli2" 
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
