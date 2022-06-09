<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_activoscaja.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_activoscaja" %>
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
    <script>
        function bloqueado(e) {

            var texto = $("#txtnrocuenta").text();

            if (texto == "") {
              
      
                $('#txtnrocuenta').prop("required",true);
            }

        }

    </script>

<body>
   
    <form id="form1" runat="server">
      <asp:ScriptManager ID="scriptman1" runat="server"> </asp:ScriptManager>
                <asp:Label ID="blk" Visible="true"  runat="server" />
               <div id="divh" runat="server"  style="text-align: center;" >
           
                       

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btncuentas"
                              BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                         <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />      <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Ventanas/VentanaActivosCaja.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="btncuentas">
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


          <div id="div1" runat="server"  style="text-align: center; " >
           
                      

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="pnl2" TargetControlID="inversionesbtn"
                                BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="pnl2" runat="server" CssClass="Popup" align="center" style = "display:none;">
                       <asp:Button ID="Button1" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />       <iframe style=" width: 100%; height: 100%;" id="Iframe1" src="~/Views/EP/Ventanas/VentanaInversiones.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="inversionesbtn">
        <Animations>
                <OnClick>
                    <Parallel AnimationTarget="pnl2" 
                    Duration="0.3" Fps="60">
                    <FadeIn />                                        
                    <Move Horizontal="0" Vertical="0"></Move>
                    </Parallel>                   
                </OnClick>
        </Animations>
    </cc1:AnimationExtender>

                       
                         </div>

            <div class="row">
            <div class="col-12 ">
                <h2>Activos<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                         </div>
        </div>
           <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Caja</label>
                        <br />
                       <asp:TextBox CssClass="form-control" 
                           OnTextChanged="montocaja_TextChanged" 
                           style="color:black" placeholder="0.00"
                           type="text" name="email" id="montocaja" 
                           onkeyup="format(this)" onchange="format(this);" 
                           maxlength="13"
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" AutoPostBack="true" >  </asp:TextBox>
                    
                    </div>  
                    <div class="col-lg-3">
                        <label>Fenafore(Fondo de Retiro)</label>
                        <br />
                     <asp:TextBox CssClass="form-control" OnTextChanged="ColaboradorInversionFenarore_TextChanged" style="color:black" placeholder="0.00" type="text" name="email" id="ColaboradorInversionFenarore" onkeyup="format(this)" onchange="format(this);" maxlength="9" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" AutoPostBack="true" >  </asp:TextBox>
                    
                    </div>
                 
         

                </div>
            </div>
        </div>


             <div class="row">
            <div class="col-12 ">
                <h2>Cuentas<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btncuentas" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btncuentas_Click" />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
                   
                    <%-- Aqui gridview --%>
               <div class="row"> 
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="cuentas" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorActivoCBID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" OnPageIndexChanging="cuentas_PageIndexChanging" OnRowEditing="cuentas_RowEditing"
              OnRowDataBound="cuentas_RowDataBound"
                OnRowCancelingEdit="cuentas_RowCancelingEdit"
                OnRowUpdating="cuentas_RowUpdating" OnRowDeleting="cuentas_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolab"  Width="150px" Text='<%# Eval("ColaboradorActivoCBID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Cuenta">
                           <ItemTemplate>
                           <asp:Label ID="curso"  Width="100%" Text='<%# Eval("TipoCuentaFinDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="tipoctadrp" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Entidad">
                           <ItemTemplate>
                           <asp:Label ID="establecimiento"  Width="100%" Text='<%# Eval("EntidadFinDescripcion") %>' runat="server" />
                        </ItemTemplate>
                                 <EditItemTemplate>
                             <asp:DropDownList  ID="entidaddrp" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Estado">
                           <ItemTemplate>
                           <asp:Label ID="modalidad"  Width="100%" Text='<%# Eval("ColaboradorActivoCBActiva").ToString() == "True" ? "Activa":"Inactiva" %>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                <asp:DropDownList  ID="Estadodrp" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  >
                     
                        <asp:ListItem Text="Activa" Value="True" />
                        <asp:ListItem Text="Inactiva" Value ="False"/>

                </asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>

                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Moneda">
                           <ItemTemplate>
                           <asp:Label ID="duracion"  Width="100%" Text='<%# Eval("MonedaNombre")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:DropDownList  ID="monedadrp" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>


                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Número de Cuenta">
                           <ItemTemplate>
                           <asp:Label ID="nmrocuenta"  Width="100%" Text='<%# Eval("ColaboradorActivoCBNumero") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtnumerocta"  TextMode="SingleLine" onkeypress="return bloqueo(event);" Text='<%# Eval("ColaboradorActivoCBNumero") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Saldo">
                           <ItemTemplate>
                           <asp:Label ID="saldo"  Width="100%" Text='<%# Eval("ColaboradorActivoCBSaldo") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtsaldo" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoCBSaldo") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Origen de los fondos">
                           <ItemTemplate>
                           <asp:Label ID="origenlbl"  Width="100%" Text='<%# Eval("ColaboradorActivoCBOrigen") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtorigen" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoCBOrigen") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>

                              <asp:TemplateField ItemStyle-CssClass="tdstyle" HeaderText="Opciones">
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="../../Imagenes/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                       <asp:LinkButton ID="lbDelete"  Width="20px" Height="20px" runat="server" OnClientClick="return confirm('¿Seguro que desea eliminar el registro?')" CausesValidation="False"
                                           CommandName="Delete"><img src="../../Imagenes/delete.png" style=" width:20px; height:20px;" alt="delete group" /></asp:LinkButton>
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
                <h2>Inversiones(Plazos fijos, Acciones, Bonos)<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="inversionesbtn" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="inversionesbtn_Click" />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
             
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="inversionestabla" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorActivoInverID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10" OnPageIndexChanging="inversionestabla_PageIndexChanging" OnRowEditing="inversionestabla_RowEditing"
              OnRowDataBound="inversionestabla_RowDataBound"
                OnRowCancelingEdit="inversionestabla_RowCancelingEdit"
                OnRowUpdating="inversionestabla_RowUpdating" OnRowDeleting="inversionestabla_RowDeleting">
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="lblidcolab"  Width="150px" Text='<%# Eval("ColaboradorActivoInverID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Institución ">
                           <ItemTemplate>
                           <asp:Label ID="entidadlbl"  Width="100%" Text='<%# Eval("EntidadFinDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="entidaddrp" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Plazo en meses">
                           <ItemTemplate>
                           <asp:Label ID="plazo"  Width="100%" Text='<%# Eval("ColaboradorActivoInverPlazo") %>' runat="server" />
                        </ItemTemplate>
                                    <EditItemTemplate>
                            <asp:TextBox ID="txtplazo" TextMode="Number" Text='<%# Eval("ColaboradorActivoInverPlazo") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Moneda">
                           <ItemTemplate>
                           <asp:Label ID="modalidad"  Width="100%" Text='<%# Eval("MonedaNombre")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                <asp:DropDownList  ID="monedadrpinv" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>

                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Monto">
                           <ItemTemplate>
                           <asp:Label ID="monto"  Width="100%" Text='<%# Eval("ColaboradorActivoInverMonto")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:TextBox ID="montotxt" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoInverMonto") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>


                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Origen de fondos">
                           <ItemTemplate>
                           <asp:Label ID="origenes"  Width="100%" Text='<%# Eval("ColaboradorActivoInverOrigen") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtorigen" TextMode="SingleLine" Text='<%# Eval("ColaboradorActivoInverOrigen") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No cuenta">
                           <ItemTemplate>
                           <asp:Label ID="nocuenta"  Width="100%" Text='<%# Eval("ColaboradorActivoInverCuenta") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtnrocuenta" TextMode="Number" Text='<%# Eval("ColaboradorActivoInverCuenta") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Fecha de apertura">
                           <ItemTemplate>
                           <asp:Label ID="fechainv"  Width="100%" Text='<%# Eval("ColaboradorActivoInverFechaApe") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="txtfecha" TextMode="Date" Text='<%# Eval("ColaboradorActivoInverFechaApe") %>' runat="server" />
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
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
        </div>    
    </div>
                </div>
            </div>

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

        var texto1 = document.querySelector('#montocaja');

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
         var texto2 = document.querySelector('#ColaboradorInversionFenarore');

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
