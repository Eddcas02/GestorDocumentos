<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventanausuarioshabil.aspx.cs" Inherits="KB_Guadalupana.Views.EP.ventanausuarioshabil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
    <script src="../../../EXDiseños/busqueda.js"></script>
    <link href="../../../EXDiseños/BusquedaStyle.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div style="margin-top: 10%;" class="row">
                <div class="col-4 ">
                    <h2></h2>
                </div>
                <div class="col-4 ">
                    <h2 style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; text-align: center;">Usuarios</h2>
                </div>
                <div class="col-4 ">
                    <h2></h2>
                </div>
            </div>

                    <div class="container-fluid">
                          <div class="col-lg-2" style="text-align: center">
                                                      <asp:Label ID="lblsuccess" Text="Usuarios Habilitados" runat="server" Visible="false" ForeColor="Green" />    
                                     <asp:Label ID="lblerror" Text="Usuarios asignados, Algunos usuarios seleccionados ya estan dentro del lote" runat="server" Visible="false" ForeColor="Yellow" />    
                               <asp:Label ID="lblusuarios" Text="" runat="server" Visible="false" ForeColor="Red" />  

                                            <br />
                                            <asp:Button ID="habilitarcolab" Font-Names=" 'Rubik', sans-serif" runat="server"
                                                Width="80%" Height="40px" CssClass="btn1" OnClientClick="return confirm('¿Seguro que desea Reactivar estos usuarios?')" CausesValidation="False"
                                                Text="Reactivar Usuarios" OnClick="AsignarLote_Click" />


                                        </div>
                    
                        <div class="col-lg-3">
                             <asp:CheckBox ID="habil" Text="" AutoPostBack="true" runat="server" OnCheckedChanged="habil_CheckedChanged" /> <label  id="Label1" runat="server" >Buscar Por Periodo</label>
                    
                        </div>

                            <asp:Panel ID="panel1" Visible="false" runat="server">
                                                        <div class="col-lg-3">
                            
                        <label> Fecha Inicial</label>
                   <asp:TextBox runat="server" TextMode="Date" ID="txtfechaingreso"  CssClass="form-control"   />
                    </div>


                        <div class="col-lg-3">
                        <label>Fecha Final</label>
                   <asp:TextBox runat="server" TextMode="Date" ID="TextBox1" AutoPostBack="false"  CssClass="form-control"   />
                    </div>


                                        <div class="col-lg-2" style="text-align: center">
                                            <label></label>
                                            <br />
                                            <asp:Button ID="btnbuscarperiodo" Font-Names=" 'Rubik', sans-serif" runat="server"
                                                Width="80%" Height="40px" CssClass="btn1" Text="Buscar por Periodo" OnClick="btnbuscarperiodo_Click" />


                                        </div>

                            </asp:Panel>


                        <asp:Panel ID="panel2" Visible="true" runat="server">

                                  <div class="col-lg-3">
                      <label  id="Label4" runat="server" >Gerencia</label>
               <asp:DropDownList  ID="gerenciadrp" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="gerenciadrp_SelectedIndexChanged"  ></asp:DropDownList><br/>
                          </div>
                                 <div class="col-lg-2">
                      <label  id="Label5" runat="server" >Departamento/Agencia</label>
               <asp:DropDownList  ID="deptoagedrp" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="deptoagedrp_SelectedIndexChanged"   ></asp:DropDownList><br/>
                          </div>
                            </asp:Panel>

                <div class="row"> 


                    <div class="col-lg-12 ">
                        <div class="table-responsive">
                             
                            <%-- Aqui gridview --%>
                            <div class="row">

                                <div class="col-md-12" style="overflow-x: auto;">

                                     


              <input type="text" id="buscarb" runat="server" style="height:25px" placeholder="Busca por Nombre o CIF" class="searchTerm"  />
               
              <asp:GridView ID="lote" CssClass="table table-striped" Style="width: 100%; text-align: center" runat="server" DataKeyNames="cif" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
                                         AutoGenerateColumns="False"
                                        BorderStyle="Solid"
                                        ShowHeaderWhenEmpty="true"
                                        AllowPaging="true"
                                        PageSize="500"
                                        OnPageIndexChanging="lote_PageIndexChanging"
                                        >
            <AlternatingRowStyle BackColor="White" />  
            <Columns>  
                                  <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="CIF" Visible="true" >
                           <ItemTemplate>
                           <asp:Label ID="cif"  Width="150px" Text='<%# Eval("cif") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
     
                   <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre Completo">
                           <ItemTemplate>
                           <asp:Label ID="nombrepersonal"  Width="100%" Text='<%# Eval("nombrepersonal") %>' runat="server" />
                        </ItemTemplate>
                     
                    </asp:TemplateField>
                
              <asp:TemplateField HeaderText="Seleccion">  
                       <HeaderTemplate>
                        <asp:CheckBox  ID="chkall"
                            AutoPostBack="true" OnCheckedChanged="chkall_CheckedChanged" 
                            runat="server" />
   

                   </HeaderTemplate>
                    <ItemTemplate>  
                        <asp:CheckBox ID="CheckBox1" runat="server" />  
                    </ItemTemplate>  
                
                </asp:TemplateField>  
             


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
    </form>
     <script>
              $(document).ready(function () {
                  $("#buscarb").on("keyup", function () {
                      var value = $(this).val().toLowerCase();
                      $("#lote tr").filter(function () {
                          $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                      });
                  });
              });
     </script>
</body>
</html>
