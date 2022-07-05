<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_equipo.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_equipo" %>
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
      <asp:ScriptManager ID="scriptman1" runat="server"> </asp:ScriptManager>

                <asp:Label ID="blk" Visible="true"  runat="server" />
         
   


             <div class="row">
            <div class="col-12 ">
                <h2>Bienes Inmuebles<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btnbienes" Font-Names=" 'Rubik', sans-serif"
                    runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btnbienes_Click1" />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">

                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="Bienes" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorActivoBIID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10"
              
              OnPageIndexChanging="Bienes_PageIndexChanging"
              OnRowEditing="Bienes_RowEditing"
              OnRowDataBound="Bienes_RowDataBound"
                OnRowCancelingEdit="Bienes_RowCancelingEdit"
                OnRowUpdating="Bienes_RowUpdating" OnRowDeleting="Bienes_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoBIID"  Width="150px" Text='<%# Eval("ColaboradorActivoBIID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Presunción">
                           <ItemTemplate>
                           <asp:Label ID="TipoPresuncionID"  Width="100%" Text='<%# Eval("TipoPresuncionDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="TipoPresuncionID" 
                                 OnSelectedIndexChanged="listManufacturers_SelectedIndexChanged" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Inmueble">
                           <ItemTemplate>
                           <asp:Label ID="TipoInmuebleID"  Width="100%" Text='<%# Eval("TipoInmuebleDescripcion") %>' runat="server" />
                        </ItemTemplate>
                                 <EditItemTemplate>
                             <asp:DropDownList  ID="TipoInmuebleID" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    

                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Finca">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoBIFinca"  Width="100%" Text='<%# Eval("ColaboradorActivoBIFinca") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoBIFinca" TextMode="Number" Text='<%# Eval("ColaboradorActivoBIFinca") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Folio">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoBIFolio"  Width="100%" Text='<%# Eval("ColaboradorActivoBIFolio") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoBIFolio" TextMode="Number" Text='<%# Eval("ColaboradorActivoBIFolio") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Libro">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoBILibro"  Width="100%" Text='<%# Eval("ColaboradorActivoBILibro") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoBILibro" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoBILibro") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Dirección">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoBIDireccon"  Width="100%" Text='<%# Eval("ColaboradorActivoBIDireccon") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoBIDireccon" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoBIDireccon") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField> 
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Valor">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoBIValor1"  Width="100%" Text='<%# Eval("ColaboradorActivoBIValor") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                                         <asp:TextBox CssClass="form-control" style="color:black"
                             id="ColaboradorActivoBIValor"
                           onkeyup="format(this)" onchange="format(this);" maxlength="13"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                           runat="server"  Text='<%# Eval("ColaboradorActivoBIValor") %>' >  </asp:TextBox>
                        
                        </EditItemTemplate>
                    </asp:TemplateField> 
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Comentario">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoBIComentario"  Width="100%" Text='<%# Eval("ColaboradorActivoBIComentario") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoBIComentario" TextMode="MultiLine" Text='<%# Eval("ColaboradorActivoBIComentario") %>' runat="server" />
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



        <%--inversiones --%>
        
             <div class="row">
            <div class="col-12 ">
                <h2>Vehículos<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btnve" Font-Names=" 'Rubik', sans-serif" runat="server"   Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="vehiculosbtn_Click1" />
            </div>
        </div>





          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">

                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="vehiculostabla" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  
              DataKeyNames="ColaboradorActivoVehID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" 
              OnPageIndexChanging="vehiculostabla_PageIndexChanging"
              OnRowEditing="vehiculostabla_RowEditing"
              OnRowDataBound="vehiculostabla_RowDataBound"
                OnRowCancelingEdit="vehiculostabla_RowCancelingEdit"
                OnRowUpdating="vehiculostabla_RowUpdating" 
              OnRowDeleting="vehiculostabla_RowDeleting">
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehID"  Width="150px" Text='<%# Eval("ColaboradorActivoVehID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="¿Está el vehículo a su nombre?">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehPropietari"
                               Width="100%" Text='<%# Eval("ColaboradorActivoVehPropietari").ToString() 
                                   == "True" ? "Si": "No" %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                                 <asp:DropDownList  ID="ColaboradorActivoVehPropietari" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%" OnSelectedIndexChanged="ColaboradorActivoVehPropietari_SelectedIndexChanged" >

                                      <asp:ListItem Text="si" Value="1" />
                                        <asp:ListItem Text="No" Value ="0"/>
                                 </asp:DropDownList><br/>
                            
                                 
                            </EditItemTemplate>
                    </asp:TemplateField>


  
                           <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Vehículo">
                           <ItemTemplate>
                           <asp:Label ID="TipoVehiculoID"  Width="100%" Text='<%# Eval("TipoVehiculoDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                          <asp:DropDownList  ID="TipoVehiculoID" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
          
                            </EditItemTemplate>
                    </asp:TemplateField>



                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Marca">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehMarca"  Width="100%" Text='<%# Eval("ColaboradorActivoVehMarca") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoVehMarca" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoVehMarca") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Línea">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehLinea"  Width="100%" Text='<%# Eval("ColaboradorActivoVehLinea") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoVehLinea" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoVehLinea") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Modelo">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehModelo"  Width="100%" Text='<%# Eval("ColaboradorActivoVehModelo") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoVehModelo" TextMode="Number" maxlength="4"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" Text='<%# Eval("ColaboradorActivoVehModelo") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Placa">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehPlaca"  Width="100%" Text='<%# Eval("ColaboradorActivoVehPlaca") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoVehPlaca" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoVehPlaca") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                   
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="A nombre de">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehNombre"  Width="100%" Text='<%# Eval("ColaboradorActivoVehNombre") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoVehNombre" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoVehNombre") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Motivo">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehMotivo"  Width="100%" Text='<%# Eval("ColaboradorActivoVehMotivo") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoVehMotivo" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoVehMotivo") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Comentario">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehComentario"  Width="100%" Text='<%# Eval("ColaboradorActivoVehComentario") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoVehComentario" TextMode="MultiLine" Text='<%# Eval("ColaboradorActivoVehComentario") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField> 
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Valor">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoVehValor"  Width="100%" Text='<%# Eval("ColaboradorActivoVehValor2") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                        <asp:TextBox CssClass="form-control" style="color:black"
                             id="ColaboradorActivoVehValor"
                           onkeyup="format(this)" onchange="format(this);" maxlength="13"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                           runat="server"  Text='<%# Eval("ColaboradorActivoVehValor2") %>'>  </asp:TextBox>
                                 
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
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
        </div>    
    </div>
                </div>
            </div>

        </div>


        <%--Mobiliario --%>

        
             <div class="row">
            <div class="col-12 ">
                <h2>Maquinaria y Equipo<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="mobibtn" Font-Names=" 'Rubik', sans-serif" runat="server" 
                    Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="mobibtn_Click" />
            </div>
        </div>





          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">

                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="mobiliario" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  
              DataKeyNames="ColaboradorActivoEqID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" 
              OnPageIndexChanging="mobiliario_PageIndexChanging"
              OnRowEditing="mobiliario_RowEditing"
              OnRowDataBound="mobiliario_RowDataBound"
                OnRowCancelingEdit="mobiliario_RowCancelingEdit"
                OnRowUpdating="mobiliario_RowUpdating" 
              OnRowDeleting="mobiliario_RowDeleting">
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoEqID"  Width="150px" Text='<%# Eval("ColaboradorActivoEqID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                           <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo Equipo">
                           <ItemTemplate>
                           <asp:Label ID="TipoEquipoID"  Width="100%" Text='<%# Eval("TipoEquipoID") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                          <asp:TextBox ID="TipoEquipoID" TextMode="SingleLine" Text='<%# Eval("TipoEquipoID") %>' runat="server" /> 
                          
                            </EditItemTemplate>
                    </asp:TemplateField>



                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Valor del Equipo">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoEqValor"  Width="100%" Text='<%# Eval("ColaboradorActivoEqValor") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoEqValor" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoEqValor") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Descripción">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorActivoEqDescripcion"  Width="100%" Text='<%# Eval("ColaboradorActivoEqDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorActivoEqDescripcion" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoEqDescripcion") %>' runat="server" /> 
                                
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
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnbienes"
                            BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                                   <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />       <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Ventanas/VentanaBienes.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="btnbienes">
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
           
                      

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="anl" TargetControlID="btnve"
                        BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="anl" runat="server" CssClass="Popup" align="center" style = "display:none">
                               <asp:Button ID="Button1" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />    <iframe style=" width:100%; height: 100%;" id="Iframe1" src="~/Views/EP/Ventanas/VentanaVehiculos.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="btnve">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="anl" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0"></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>

                       
                         </div>
        
<div id="div2" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" PopupControlID="pnl3" TargetControlID="mobibtn"
                           BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="pnl3" runat="server" CssClass="Popup" align="center" style = "display:none">
                            <asp:Button ID="Button3" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />         <iframe style=" width:100%; height: 100%;" id="Iframe2" src="~/Views/EP/Ventanas/VentanaMobiliario.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender2" runat="server" TargetControlID="mobibtn">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="pnl3" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0"></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>

                       
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

         var texto1 = document.querySelector('#ColaboradorActivoBIValor');

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


         var texto2 = document.querySelector('#ColaboradorActivoVehValor');

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

     </script>
</body>
</html>
