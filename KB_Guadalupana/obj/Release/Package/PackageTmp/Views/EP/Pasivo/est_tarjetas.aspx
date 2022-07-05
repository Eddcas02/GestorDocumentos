<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_tarjetas.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_tarjetas" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
 <script src="../Estaticos/bloqueo.js"></script>
    <title></title>
</head>


<body>
   
    <form id="form1" runat="server">
      <asp:ScriptManager ID="scriptman1" runat="server"> </asp:ScriptManager>

                <asp:Label ID="blk" Visible="true"  runat="server" />


             <div class="row">
            <div class="col-12 ">
                <h2>Tarjetas de Crédito<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btntarjetas" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btntarjetas_Click" />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">

                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="tarjetastabla" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorPasivoTCID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  
              AllowPaging="true" PageSize="10"
              OnPageIndexChanging="tarjetastabla_PageIndexChanging"
              OnRowEditing="tarjetastabla_RowEditing"
              OnRowDataBound="tarjetastabla_RowDataBound"
                OnRowCancelingEdit="tarjetastabla_RowCancelingEdit"
                OnRowUpdating="tarjetastabla_RowUpdating" OnRowDeleting="tarjetastabla_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoTCID"  Width="150px" Text='<%# Eval("ColaboradorPasivoTCID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Cuenta">
                           <ItemTemplate>
                           <asp:Label ID="EntidadFinCodigo"  Width="100%" Text='<%# Eval("EntidadFinDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="EntidadFinCodigo" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
  
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Límite en Quetzales">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoTCLimiteQ"  Width="100%" Text='<%# Eval("ColaboradorPasivoTCLimiteQ") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                           
                                      <asp:TextBox CssClass="form-control" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoTCLimiteQ") %>' style="color:black" placeholder="10,000" type="text" name="email" ID="ColaboradorPasivoTCLimiteQ" onkeyup="format(this)" onchange="format(this);" maxlength="13" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" >  </asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Límite en Dólares">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoTCLimiteUS"  Width="100%" Text='<%# Eval("ColaboradorPasivoTCLimiteUS") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                           <asp:TextBox CssClass="form-control" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoTCLimiteUS") %>' style="color:black" placeholder="10,000" type="text" name="email" ID="ColaboradorPasivoTCLimiteUS" onkeyup="format(this)" onchange="format(this);" maxlength="13" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" >  </asp:TextBox>     </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Saldo en  Quetzales">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoTCSaldoQ"  Width="100%" Text='<%# Eval("ColaboradorPasivoTCSaldoQ") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                                 <asp:TextBox CssClass="form-control" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoTCSaldoQ") %>' style="color:black" placeholder="10,000" type="text" name="email" ID="ColaboradorPasivoTCSaldoQ" onkeyup="format(this)" onchange="format(this);" maxlength="13" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" >  </asp:TextBox>        </EditItemTemplate>
                    </asp:TemplateField>

                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Saldo en Dólares">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoTCSaldoUS"  Width="100%" Text='<%# Eval("ColaboradorPasivoTCSaldoUS") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                                 <asp:TextBox CssClass="form-control" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoTCSaldoUS") %>' style="color:black" placeholder="10,000" type="text" name="email" ID="ColaboradorPasivoTCSaldoUS" onkeyup="format(this)" onchange="format(this);" maxlength="13" oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"   runat="server" >  </asp:TextBox>        </EditItemTemplate>
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



        <%--inversiones --%>
        
             <div class="row">
            <div class="col-12 ">
                <h2>Préstamos<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="prestamos" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos"  />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">

                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="prestamostabla" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="ColaboradorPasivoPrestID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="10"
              OnPageIndexChanging="prestamostabla_PageIndexChanging"
              OnRowEditing="prestamostabla_RowEditing"
              OnRowDataBound="prestamostabla_RowDataBound"
                OnRowCancelingEdit="prestamostabla_RowCancelingEdit"
                OnRowUpdating="prestamostabla_RowUpdating" OnRowDeleting="prestamostabla_RowDeleting">
                    <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoPrestID"  Width="150px" Text='<%# Eval("ColaboradorPasivoPrestID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Tipo de Préstamo">
                           <ItemTemplate>
                           <asp:Label ID="TipoPrestamoID"  Width="100%" Text='<%# Eval("TipoPrestamoDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="TipoPrestamoID" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>
                               <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Institución">
                           <ItemTemplate>
                           <asp:Label ID="EntidadFinCodigo"  Width="100%" Text='<%# Eval("EntidadFinDescripcion") %>' runat="server" />
                        </ItemTemplate>
                            <EditItemTemplate>
                             <asp:DropDownList  ID="EntidadFinCodigo" runat="server" CssClass="form-control" AutoPostBack="false"  Width="100%"  ></asp:DropDownList><br/>
                        </EditItemTemplate>
                    </asp:TemplateField>


                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Monto Inicial">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoPrestMontoIni"  Width="100%" Text='<%# Eval("ColaboradorPasivoPrestMontoIni") %>' runat="server" />
                        </ItemTemplate>
                                    <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorPasivoPrestMontoIni" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoPrestMontoIni") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Saldo Actual">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoPrestSaldo"  Width="100%" Text='<%# Eval("ColaboradorPasivoPrestSaldo") %>' runat="server" />
                        </ItemTemplate>
                                    <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorPasivoPrestSaldo" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoPrestSaldo") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                      

                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Destino">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoPrestDestino"  Width="100%" Text='<%# Eval("ColaboradorPasivoPrestDestino")%>' runat="server" />
                        </ItemTemplate>
                               <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorPasivoPrestDestino" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoPrestDestino") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>


                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Fecha Desembolso">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoPrestFecDesem"  Width="100%" Text='<%# Eval("ColaboradorPasivoPrestFecDesem") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                      

                        <asp:TextBox CssClass="form-control" style="color:black" TextMode="Date" Text='<%# Eval("ColaboradorPasivoPrestFecDesem") %>'   id="ColaboradorPasivoPrestFecDesem"  runat="server" /> 
                    
      

                        </EditItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Fecha Finalización">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoPrestFecFinal"  Width="100%" Text='<%# Eval("ColaboradorPasivoPrestFecFinal") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorPasivoPrestFecFinal" TextMode="Date" Text='<%# Eval("ColaboradorPasivoPrestFecFinal") %>' runat="server" />
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













         

          <div id="divh" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btntarjetas"
                                BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                        <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />             <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Pasivo/Ventanas/VentanaTC.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="btntarjetas">
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
           
                      

                             

                             <cc1:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="pnl2" TargetControlID="prestamos"
                                BackgroundCssClass="Background" >
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="pnl2" runat="server" CssClass="Popup" align="center" style = "display:none">
                             <asp:Button ID="Button1" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />      <iframe style=" width: 100%; height: 100%;" id="Iframe1" src="~/Views/EP/Pasivo/Ventanas/VentanaPrestamos.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="AnimationExtender1" runat="server" TargetControlID="prestamos">
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

     </script>
</body>
</html>
