<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_ingresos.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_ingresos" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
       <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
    <title></title>    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
 <script src="../Estaticos/bloqueo.js"></script>
</head>

<body>
   
    <form id="form1" runat="server">
      <asp:ScriptManager ID="scriptman1" runat="server"> </asp:ScriptManager>


                 <asp:Label ID="blk" Visible="true"  runat="server" />
   


             <div class="row">
            <div class="col-12 ">
                <h2>Negocio Propio<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btnnegocio" Font-Names=" 'Rubik', sans-serif"
                    runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos"  />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
                 
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="negocio" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  
              DataKeyNames="ColaboradoringresoNegID" HeaderStyle-BackColor="#404040"
              HeaderStyle-ForeColor="Black"
             AutoGenerateColumns="False" BorderStyle="Solid" 
              ShowHeaderWhenEmpty="true" 
              AllowPaging="true" PageSize="10"
              
              OnPageIndexChanging="negocio_PageIndexChanging"
              OnRowEditing="negocio_RowEditing"
              OnRowDataBound="negocio_RowDataBound"
                OnRowCancelingEdit="negocio_RowCancelingEdit"
                OnRowUpdating="negocio_RowUpdating"
              OnRowDeleting="negocio_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegID"  Width="150px" Text='<%# Eval("ColaboradoringresoNegID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Presunción">
                           <ItemTemplate>
                           <asp:Label ID="TipoNegocioID"  Width="100%" Text='<%# Eval("TipoNegocioDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="TipoNegocioID" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="TipoNegocioID_SelectedIndexChanged"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
          
                    

                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre del Negocio">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegNombre"  Width="100%" Text='<%# Eval("ColaboradoringresoNegNombre") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradoringresoNegNombre" TextMode="SingleLine" Text='<%# Eval("ColaboradoringresoNegNombre") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Patente">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegPatente"  Width="100%" Text='<%# Eval("ColaboradoringresoNegPatente") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradoringresoNegPatente" TextMode="SingleLine" Text='<%# Eval("ColaboradoringresoNegPatente") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Número de Empleados">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegEmpleados"  Width="100%" Text='<%# Eval("ColaboradoringresoNegEmpleados") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradoringresoNegEmpleados" TextMode="Number" Text='<%# Eval("ColaboradoringresoNegEmpleados") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>  
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Objeto del Negocio">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegObjeto"  Width="100%" Text='<%# Eval("ColaboradoringresoNegObjeto") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradoringresoNegObjeto" TextMode="SingleLine" Text='<%# Eval("ColaboradoringresoNegObjeto") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                           <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Ingresos">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegIngresos"  Width="100%" Text='<%# Eval("ColaboradoringresoNegIngresos") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                                         <asp:TextBox CssClass="form-control" style="color:black"
                             id="ColaboradoringresoNegIngresos"
                           onkeyup="format(this)" onchange="format(this);" maxlength="13"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                           runat="server"  Text='<%# Eval("ColaboradoringresoNegIngresos") %>'>  </asp:TextBox>
                        
                        </EditItemTemplate>
                    </asp:TemplateField> 
                    
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Egresos">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegEgresos"  Width="100%" Text='<%# Eval("ColaboradoringresoNegEgresos") %>' runat="server" />
                        </ItemTemplate>
                                  <EditItemTemplate>
                                         <asp:TextBox CssClass="form-control" style="color:black"
                             id="ColaboradoringresoNegEgresos"
                           onkeyup="format(this)" onchange="format(this);" maxlength="13"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                           runat="server"  Text='<%# Eval("ColaboradoringresoNegEgresos") %>'>  </asp:TextBox>
                        
                        </EditItemTemplate>
                    </asp:TemplateField>

                             <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Dirección del Negocio">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoNegDireccion"  Width="100%" Text='<%# Eval("ColaboradoringresoNegDireccion") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradoringresoNegDireccion" TextMode="SingleLine" Text='<%# Eval("ColaboradoringresoNegDireccion") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField> 

                              <asp:TemplateField ItemStyle-CssClass="tdstyle" HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                    <asp:LinkButton ID="lbDelete"  Width="20px" Height="20px" runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete" ><img src="../../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
                              </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="../../../Imagenes/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="../../../Imagenes/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
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



        <%--Remesas --%>
        
             <div class="row">
            <div class="col-12 ">
                <h2>Remesas<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="remesasbt" Font-Names=" 'Rubik', sans-serif" runat="server"   Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos"  />
            </div>
        </div>





          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
                 
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="remesastabla" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  
              DataKeyNames="ColaboradoringresoRemesaID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" 
              OnPageIndexChanging="remesastabla_PageIndexChanging"
              OnRowEditing="remesastabla_RowEditing"
             
                OnRowCancelingEdit="remesastabla_RowCancelingEdit"
                OnRowUpdating="remesastabla_RowUpdating" 
              OnRowDeleting="remesastabla_RowDeleting">
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoRemesaID"  Width="150px" Text='<%# Eval("ColaboradoringresoRemesaID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
           


  
                           <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre del Remitente">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorIngresoRemesaRemite"  Width="100%" Text='<%# Eval("ColaboradorIngresoRemesaRemite") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                                   <asp:TextBox ID="ColaboradorIngresoRemesaRemite" TextMode="SingleLine" Text='<%# Eval("ColaboradorIngresoRemesaRemite") %>' runat="server" /> 
                       
                            </EditItemTemplate>
                    </asp:TemplateField>



                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Relación con Remitente">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorIngresoRemesaRelaci"  Width="100%" Text='<%# Eval("ColaboradorIngresoRemesaRelaci") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorIngresoRemesaRelaci" TextMode="SingleLine" Text='<%# Eval("ColaboradorIngresoRemesaRelaci") %>' runat="server" /> 
                                     
                            </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Promedio Mensual">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorIngresoRemesaPromed"  Width="100%" Text='<%# Eval("ColaboradorIngresoRemesaPromed") %>' runat="server" />
                        </ItemTemplate>
                                 <EditItemTemplate>
                                         <asp:TextBox CssClass="form-control" style="color:black"
                             id="ColaboradorIngresoRemesaPromed"
                           onkeyup="format(this)" onchange="format(this);" maxlength="13"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                           runat="server"  Text='<%# Eval("ColaboradorIngresoRemesaPromed") %>'>  </asp:TextBox>
                        
                        </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Período de Recepción">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorIngresoRemesaPeriod"  Width="100%" Text='<%# Eval("ColaboradorIngresoRemesaPeriod") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorIngresoRemesaPeriod" TextMode="SingleLine" Text='<%# Eval("ColaboradorIngresoRemesaPeriod") %>' runat="server" /> 
                                
                            </EditItemTemplate>
                    </asp:TemplateField>
                              <asp:TemplateField ItemStyle-CssClass="tdstyle" HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                       <asp:LinkButton ID="lbDelete"  Width="20px" Height="20px" runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete" ><img src="../../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
                           </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="../../../Imagenes/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="../../../Imagenes/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
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


        <%--Otros --%>

        
             <div class="row">
            <div class="col-12 ">
                <h2>Otros Ingresos<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="otrosi" Font-Names=" 'Rubik', sans-serif" runat="server" 
                    Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos"  />
            </div>
        </div>





          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
               
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="otrostabla" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  
              DataKeyNames="ColaboradoringresoOtrID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" 
              OnPageIndexChanging="otrostabla_PageIndexChanging"
              OnRowEditing="otrostabla_RowEditing"
              OnRowDataBound="otrostabla_RowDataBound"
                OnRowCancelingEdit="otrostabla_RowCancelingEdit"
                OnRowUpdating="otrostabla_RowUpdating" 
              OnRowDeleting="otrostabla_RowDeleting">
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoOtrID"  Width="150px" Text='<%# Eval("ColaboradoringresoOtrID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Ingreso">
                           <ItemTemplate>
                           <asp:Label ID="TipoOtroIngresoID"  Width="100%" Text='<%# Eval("TipoOtroIngresoDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="TipoOtroIngresoID" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                           <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Descripcón">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoOtrDescripci"  Width="100%" Text='<%# Eval("ColaboradoringresoOtrDescripci") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                          <asp:TextBox ID="ColaboradoringresoOtrDescripci" TextMode="SingleLine" Text='<%# Eval("ColaboradoringresoOtrDescripci") %>' runat="server" /> 
                          
                            </EditItemTemplate>
                    </asp:TemplateField>



                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Monto Mensual">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradoringresoOtrValor"  Width="100%" Text='<%# Eval("ColaboradoringresoOtrValor") %>' runat="server" />
                        </ItemTemplate>
                                     <EditItemTemplate>
                                         <asp:TextBox CssClass="form-control" style="color:black"
                             id="ColaboradoringresoOtrValor"
                           onkeyup="format(this)" onchange="format(this);" maxlength="13"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" 
                           runat="server"  Text='<%# Eval("ColaboradoringresoOtrValor") %>'>  </asp:TextBox>
                        
                        </EditItemTemplate>
                    </asp:TemplateField>
                              <asp:TemplateField ItemStyle-CssClass="tdstyle" HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                         <asp:LinkButton ID="lbDelete"  Width="20px" Height="20px" runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete" ><img src="../../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="../../../Imagenes/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="../../../Imagenes/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
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
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btnnegocio"
                                BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                              <asp:Button ID="Button3" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar2_Click" />
                            <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Ingresos/Ventanas/VentanaNegocios.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="btnnegocio">
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
           
                      

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="anl" TargetControlID="remesasbt"
                               BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="anl" runat="server" CssClass="Popup" align="center" style = "display:none">
                              <asp:Button ID="Button1" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar2_Click" />
                            <iframe style=" width:100%; height: 100%;" id="Iframe1" src="~/Views/EP/Ingresos/Ventanas/VentanaRemesas.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="remesasbt">
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
           
                      

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender2" runat="server" 
                                 PopupControlID="pnl3" TargetControlID="otrosi" 
                               BackgroundCssClass="Background"
                               PopupDragHandleControlID="pnl3" >
                            </cc1:ModalPopupExtender>
   
                             <asp:Panel ID="pnl3" runat="server" CssClass="Popup" align="center" style = "display:none">
                                      
                       <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar2_Click" />
                            <iframe style=" width:100%; height: 100%;" 
                                id="Iframe2" src="~/Views/EP/Ingresos/Ventanas/VentanaOrtosI.aspx" runat="server" ></iframe>
                             <br/>
                   
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender2" runat="server" TargetControlID="otrosi">
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

         var texto1 = document.querySelector('#ColaboradoringresoNegIngresos');

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

         var texto2 = document.querySelector('#ColaboradoringresoNegEgresos');

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
         var texto3 = document.querySelector('#ColaboradorIngresoRemesaPromed');

         texto3.addEventListener('keypress', function (e) {
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

         var texto4 = document.querySelector('#ColaboradoringresoOtrValor');

         texto4.addEventListener('keypress', function (e) {
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
