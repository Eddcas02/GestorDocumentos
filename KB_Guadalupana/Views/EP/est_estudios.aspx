    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_estudios.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_estudios" %>
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
        <br />
        <br />
                <asp:Label ID="blk" Visible="true"  runat="server" />
                     <div class="row">
            <div class="col-12 ">
                <h2>Estudios<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="Agregar" Font-Names=" 'Rubik', sans-serif" runat="server" Width="10%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="Agregar_Click" />
            </div>
        </div>

        <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
             
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="estudiodgv" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorEstudioUniID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" OnPageIndexChanging="estudiodgv_PageIndexChanging" OnRowEditing="estudiodgv_RowEditing"
              
                OnRowCancelingEdit="estudiodgv_RowCancelingEdit"
                OnRowUpdating="estudiodgv_RowUpdating" OnRowDeleting="estudiodgv_RowDeleting"
                OnRowDataBound="estudiodgv_RowDataBound"                    >
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolab"  Width="150px" Text='<%# Eval("ColaboradorEstudioUniID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Carrera">
                           <ItemTemplate>
                           <asp:Label ID="lblcarrera"  Width="100%" Text='<%# Eval("ColaboradorEstudioUniCarrera") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="txtcarrera" Text='<%# Eval("ColaboradorEstudioUniCarrera") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Graduado">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorEstudioUniGraduado"  Width="100%" Text='<%# Eval("ColaboradorEstudioUniGraduado").ToString()  == "True" ? "Si": "No"  %>' runat="server" />
                        </ItemTemplate>
                              <EditItemTemplate>
                                 <asp:DropDownList  ID="ColaboradorEstudioUniGraduado" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%" OnSelectedIndexChanged="ColaboradorEstudioUniGraduado_SelectedIndexChanged" >

                                      <asp:ListItem Text="Si" Value="1" />
                                        <asp:ListItem Text="No" Value ="0"/>
                                 </asp:DropDownList><br/>
                            
                                 
                            </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Último Ciclo">
                           <ItemTemplate>
                           <asp:Label ID="lblultimociclo"  Width="100%" Text='<%# Eval("ColaboradorEstudioUniUltCiclo") %>' runat="server" />
                        </ItemTemplate>
                                 <EditItemTemplate>
                            <asp:TextBox ID="txtultimociclo" TextMode="Number" Text='<%# Eval("ColaboradorEstudioUniUltCiclo") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Año">
                           <ItemTemplate>
                           <asp:Label ID="lblañouni"  Width="100%" Text='<%# Eval("ColaboradorEstudiouniAnio")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:TextBox ID="txtañouni" TextMode="Number" Text='<%# Eval("ColaboradorEstudiouniAnio") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Universidad">
                           <ItemTemplate>
                           <asp:Label ID="lbluniversidad"  Width="100%" Text='<%# Eval("UniversidadID") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:DropDownList  ID="univeredit" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                            
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


              <div class="row">
            <div class="col-12 ">
                <h2>Otros Estudios<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btnotrosestudios" Font-Names=" 'Rubik', sans-serif" runat="server" Width="10%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btnotrosestudios_Click" />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">

                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="otrosestudiosdgvx" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorEstudioOtrID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" OnPageIndexChanging="otrosestudiosdgvx_PageIndexChanging" OnRowEditing="otrosestudiosdgvx_RowEditing"
              
                OnRowCancelingEdit="otrosestudiosdgvx_RowCancelingEdit"
                OnRowUpdating="otrosestudiosdgvx_RowUpdating" OnRowDeleting="otrosestudiosdgvx_RowDeleting"
              OnRowDataBound="otrosestudiosdgvx_RowDataBound"
              >
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolab"  Width="150px" Text='<%# Eval("ColaboradorEstudioOtrID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Curso">
                           <ItemTemplate>
                           <asp:Label ID="curso"  Width="100%" Text='<%# Eval("ColaboradorEstudioOtrCurso") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="txtcurso" TextMode="SingleLine" Text='<%# Eval("ColaboradorEstudioOtrCurso") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Establecimiento">
                           <ItemTemplate>
                           <asp:Label ID="establecimiento"  Width="100%" Text='<%# Eval("ColaboradorEstudioOtrEstableci") %>' runat="server" />
                        </ItemTemplate>
                                 <EditItemTemplate>
                            <asp:TextBox ID="txtestabecimiento" TextMode="SingleLine" Text='<%# Eval("ColaboradorEstudioOtrEstableci") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Modalidad">
                           <ItemTemplate>
                           <asp:Label ID="modalidad"  Width="100%" Text='<%# Eval("ModalidadEstudioID")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                             <asp:DropDownList  ID="modalidaddrp" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>

                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Duración">
                           <ItemTemplate>
                           <asp:Label ID="duracion"  Width="100%" Text='<%# Eval("ColaboradorEstudioOtrDuracion")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:TextBox ID="txtduracion" TextMode="SingleLine" Text='<%# Eval("ColaboradorEstudioOtrDuracion") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>


                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Año">
                           <ItemTemplate>
                           <asp:Label ID="lbluniversidad"  Width="100%" Text='<%# Eval("ColaboradorEstudioOtrAnio") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtuni" TextMode="Number" Text='<%# Eval("ColaboradorEstudioOtrAnio") %>' runat="server" />
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
                   
                    </asp:TemplateField>

                   

                     </Columns>
        <HeaderStyle  Width="300px" ForeColor="White"></HeaderStyle>
        </asp:GridView>
          <br />
            <asp:Label ID="Label1" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="Label2" Text="" runat="server" ForeColor="Red" />
        </div>    
    </div>
                </div>
            </div>

        </div>

       

                <div id="divh" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="Agregar"
                                 BackgroundCssClass="Background" BehaviorID="mp11">
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                          <asp:Button ID="Button1" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />       <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Ventanas/VentanaEstudios.aspx" runat="server" ></iframe>
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

        <div id="divh2" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Pan2" TargetControlID="btnotrosestudios"
                           BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Pan2" runat="server" CssClass="Popup" align="center" style = "display:none">
                            <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />   <iframe style=" width: 100%; height: 100%;" id="Iframe1" src="~/Views/EP/Ventanas/VentanaOtrosEstudios.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="btnotrosestudios">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="Pan2" 
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
