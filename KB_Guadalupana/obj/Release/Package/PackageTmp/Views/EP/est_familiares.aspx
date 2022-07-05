<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_familiares.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_familiares" %>
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
             <%-- Datos Familiares --%>
        <br />
        <br />
                <asp:Label ID="blk" Visible="true"  runat="server" />
                   <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-3">
                    
                      <label  id="Label2" runat="server" >Estado Civil</label>
               <asp:DropDownList  ID="estadocivildrp" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="estadocivildrp_SelectedIndexChanged"   ></asp:DropDownList><br/>
                          

                    </div> 
                    
                    <div class="col-lg-3">
                        <label id="ncl" runat="server">Nombre del Cónyuge</label>
                                   <asp:Label ID="lblnc" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
     
                        <br />
                       <asp:TextBox CssClass="form-control" 
                          
                           style="color:black" placeholder="Nombre del Cónyuge"
                            TextMode="SingleLine"
                           ID="ColaboradorConyugeNombre" runat="server">  </asp:TextBox>
                    
                    </div>  
                        <div class="col-lg-3">
                        <label id="ocl" runat="server">Ocupación del Cónyuge</label>
                                       <asp:Label ID="lbloc" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" /> 
     
                        <br />
                       <asp:TextBox CssClass="form-control" 
                          
                           style="color:black" placeholder="Ocupación del Cónyuge"
                            TextMode="SingleLine"
                           ID="ColaboradorConyugeOcupacion" runat="server">  </asp:TextBox>
                    
                    </div>  
                      <div class="col-lg-4">
                        <label id="fcl" runat="server">Fecha de Nacimiento del Cónyuge</label>
                                     <asp:Label ID="lblfc" Text="Revise que los datos sean correctos" max="2040-01-01" runat="server" Visible="false" ForeColor="Red" /> 
     
                        <br />
                       <asp:TextBox CssClass="form-control" 
                          
                           style="color:black" placeholder="Nombre del Conyuge"
                            TextMode="Date"
                           ID="ColaboradorConyugeFecNacimient" runat="server">  </asp:TextBox>
                    
                    </div>  
                  
                  
                   <div class="col-lg-2" style="text-align:center">
                                  <label id="lblencab" runat="server">Guardar Datos</label>
                                  <br />
                                 
                       <asp:Button ID="btnconyuge"  Font-Names=" 'Rubik', sans-serif" runat="server" Width="100%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnconyuge_Click" />
 <asp:Label ID="lblsuccesss" Text="Datos Almacenados" runat="server" Visible="false" ForeColor="Green" />
                <asp:Label ID="lblerror" Text="Revise que los datos sean correctos" runat="server" Visible="false" ForeColor="Red" />
 
                    </div>
         

                </div>
            </div>
        </div>
        
                     <div class="row">
            <div class="col-12 ">
                <h2>Datos de Hijos<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="Agregar" Font-Names=" 'Rubik', sans-serif" runat="server" Width="10%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="Agregar_Click" />
            </div>
        </div>

        <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
            
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="familiarsdgv" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorFamiliaID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" OnPageIndexChanging="DGRVWPEN_PageIndexChanging" OnRowEditing="familiarsdgv_RowEditing"
              
                OnRowCancelingEdit="familiarsdgv_RowCancelingEdit"
                OnRowUpdating="familiarsdgv_RowUpdating" OnRowDeleting="familiarsdgv_RowDeleting">
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolab"  Width="150px" Text='<%# Eval("ColaboradorFamiliaID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre">
                           <ItemTemplate>
                           <asp:Label ID="lblfamilianombre"  Width="100%" Text='<%# Eval("ColaboradorFamiliaNombre") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="txtfamiliarnom" Text='<%# Eval("ColaboradorFamiliaNombre") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Ocupación">
                           <ItemTemplate>
                           <asp:Label ID="lblocupacion"  Width="100%" Text='<%# Eval("ColaboradorFamiliaOcupacion") %>' runat="server" />
                        </ItemTemplate>
                                 <EditItemTemplate>
                            <asp:TextBox ID="txtocupacion" Text='<%# Eval("ColaboradorFamiliaOcupacion") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Comentario">
                           <ItemTemplate>
                           <asp:Label ID="lblcoment"  Width="100%" Text='<%# Eval("ColaboradorFamiliaComentario")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:TextBox ID="txtcoment" TextMode="MultiLine" Text='<%# Eval("ColaboradorFamiliaComentario") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Fecha de Nacimiento">
                           <ItemTemplate>
                           <asp:Label ID="lblfechanac"  Width="100%" Text='<%# Eval("ColaboradorFamiliaFecNacimient") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtfechanac" TextMode="Date" Text='<%# Eval("ColaboradorFamiliaFecNacimient") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>

                              <asp:TemplateField ItemStyle-CssClass="tdstyle" HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                    <asp:LinkButton ID="lbDelete"  Width="20px" Height="20px" runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete" ><img src="../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
                             </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="../../Imagenes/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/addnew.png" runat="server" CommandName="AddNew" ToolTip="Add New" Width="20px" Height="20px"/>
                        </FooterTemplate>
                    </asp:TemplateField>

                   

                     </Columns>
        <HeaderStyle  Width="300px" ForeColor="White"></HeaderStyle>
        </asp:GridView>
          <br />
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
        </div>    
    </div>
                </div>
            </div>

        </div>

       

                <div id="divh" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="Agregar"
                            BackgroundCssClass="Background">
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                           <asp:Button ID="Button1" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />       <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Ventanas/Ventanafamiliares.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="Agregar">
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
