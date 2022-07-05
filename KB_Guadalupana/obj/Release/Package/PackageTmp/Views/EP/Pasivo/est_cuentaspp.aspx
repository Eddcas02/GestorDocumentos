<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_cuentaspp.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_cuentaspp" %>
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
                <h2>Cuentas por Pagar<a data-toggle="modal" data-target="#exampleModal3"> </a></h2>
                <asp:Button ID="btncuentaspp" Font-Names=" 'Rubik', sans-serif" runat="server" Width="15%" Height="40px" CssClass="btn1" Text="Agregar Datos" OnClick="btncuentaspp_Click" />
            </div>
        </div>

          <div class="row">


            <div class="col-lg-12 ">
                <div class="table-responsive">
                      <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="cuentaspc" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server" 
              DataKeyNames="ColaboradorPasivoCXPID"
              HeaderStyle-BackColor="#404040"
              HeaderStyle-ForeColor="Black"
              AutoGenerateColumns="False" 
              BorderStyle="Solid"
              ShowHeaderWhenEmpty="true" 
              AllowPaging="true" PageSize="10"
              OnPageIndexChanging="cuentaspc_PageIndexChanging" 
              OnRowEditing="cuentaspc_RowEditing"
          
                OnRowCancelingEdit="cuentaspc_RowCancelingEdit"
                OnRowUpdating="cuentaspc_RowUpdating" OnRowDeleting="cuentaspc_RowDeleting">
                     <Columns>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="ID" Visible="false" >
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoCXPID"  Width="150px" Text='<%# Eval("ColaboradorPasivoCXPID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                
                      


                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Persona/Entidad">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoCXPOrigen"  Width="100%" Text='<%# Eval("ColaboradorPasivoCXPOrigen") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorPasivoCXPOrigen" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoCXPOrigen") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                       
                          <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Monto">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoCXPMonto"  Width="100%" Text='<%# Eval("ColaboradorPasivoCXPMonto") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorPasivoCXPMonto" TextMode="SingleLine" Text='<%# Eval("ColaboradorPasivoCXPMonto") %>' runat="server" />
                        </EditItemTemplate>
                    </asp:TemplateField>

                            <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Motivo">
                           <ItemTemplate>
                           <asp:Label ID="ColaboradorPasivoCXPDescripcio"  Width="100%" Text='<%# Eval("ColaboradorPasivoCXPDescripcio") %>' runat="server" />
                        </ItemTemplate>
                                <EditItemTemplate>
                            <asp:TextBox ID="ColaboradorPasivoCXPDescripcio" TextMode="MultiLine" Text='<%# Eval("ColaboradorPasivoCXPDescripcio") %>' runat="server" />
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















         

          <div id="divh" runat="server"  style="text-align: center;" >
           
                      

                             

                             <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panl1" TargetControlID="btncuentaspp"
                                 BackgroundCssClass="Background">
                            </cc1:ModalPopupExtender>

                             <asp:Panel ID="Panl1" runat="server" CssClass="Popup" align="center" style = "display:none">
                             <asp:Button ID="Button2" 
                                      CssClass="btn1" class="cierre" 
                                      Width="30%" runat="server"  
                                      Text="Cerrar" OnClick="cerrar_Click" />      <iframe style=" width: 100%; height: 100%;" id="irm1" src="~/Views/EP/Pasivo/Ventanas/Ventanacuentaspp.aspx" runat="server" ></iframe>
                             <br/>
                           
                            </asp:Panel>

                        <cc1:AnimationExtender ID="popupAnimation" runat="server" TargetControlID="btncuentaspp">
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

         var texto1 = document.querySelector('#ColaboradorPasivoCXPMonto');

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
