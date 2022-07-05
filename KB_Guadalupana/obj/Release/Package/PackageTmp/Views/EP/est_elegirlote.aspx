<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_elegirlote.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_elegirlote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
      <title></title>
</head>
<script>


</script>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
              <div class="row" style="margin-top:50px; margin-bottom:-50px">
                   <div class="col-4 ">
           
               
             
  <a href="../Sesion/MenuBarra.aspx" ><i style="color:black" class="fa fa-home fa-3x"></i></a>


                    </div>
                <div class="col-lg-4">

                </div>
                 <div class="col-lg-4">

                </div>
            </div>
                   <div style="margin-top:10%;" class="row">
            <div class="col-4 ">
                <h2></h2>
                            </div>
                           <div class="col-4 ">
                <h2 style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; text-align:center;">Lotes Registrados</h2>
                            </div>
                           <div class="col-4 ">
                <h2></h2>
                            </div>
        </div>
        <div class="container-fluid">     <div class="row">


            <div class="col-lg-12" style="text-align-last: center;">
                <div class="table-responsive">
      
                    <%-- Aqui gridview --%>
               <div class="row">
        
    <div class="col-md-12" style="overflow-x: auto;" >
      
          <asp:GridView ID="lote" CssClass="table table-striped" style="width: 100%;text-align:center" runat="server"  DataKeyNames="LoteID" HeaderStyle-BackColor="#404040" HeaderStyle-ForeColor="Black"
    AutoGenerateColumns="False" BorderStyle="Solid" ShowHeaderWhenEmpty="true"  AllowPaging="true" PageSize="20" OnPageIndexChanging="lote_PageIndexChanging" OnSelectedIndexChanged="lote_SelectedIndexChanged"  >
                    <Columns>
                   <%--      <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="No">
                           <ItemTemplate>
                           <asp:Label ID="nofam"  Width="30px" Text='<%# Container.DataItemIndex + 1 %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                             
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Lote" Visible="true" >
                           <ItemTemplate>
                           <asp:Label ID="LoteID"  Width="100%" Text='<%# Eval("LoteID") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre">
                           <ItemTemplate>
                           <asp:Label ID="nombrepersonal"  Width="100%" Text='<%# Eval("nombrepersonal") %>' runat="server" />
                        </ItemTemplate>
                         
                    </asp:TemplateField>
                        <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Nombre Lote">
                           <ItemTemplate>
                           <asp:Label ID="LoteDescripcion"  Width="100%" Text='<%# Eval("LoteDescripcion") %>' runat="server" />
                        </ItemTemplate>
                         
                    </asp:TemplateField>
                         <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Estado de Lote">
                           <ItemTemplate>
                           <asp:Label ID="LoteEstado"  Width="100%" Text='<%# Eval("LoteEstado").ToString() == "True" ? "Abierto": "Cerrado" %>' runat="server" />
                        </ItemTemplate>
                          
                    </asp:TemplateField>
                  <asp:TemplateField ControlStyle-CssClass="diseño" HeaderText="Estado Patrimonial">
                           <ItemTemplate>
                           <asp:Label ID="EstadoColab"  Width="100%" Text='<%# Eval("ColaboradorEstado").ToString() == "True" ? "Finalizado": "Pendiente" %>' runat="server" />
                        </ItemTemplate>
                          
                    </asp:TemplateField>
          
                       
                        <asp:ButtonField ControlStyle-Height="20" ButtonType="Image" HeaderText="Ver estado patrimonial" ImageUrl="../../Imagenes/lupa.png" CommandName="Select" ItemStyle-Width="10" ItemStyle-CssClass="seleccionarregistrogridview">
                            
                            <ItemStyle Width="100px" >

                            </ItemStyle>

                            </asp:ButtonField>

                     </Columns>
        <HeaderStyle  Width="300px" ForeColor="White"></HeaderStyle>
        </asp:GridView>
          <br />
           
        </div>    
    </div>
                </div>
            </div>

        </div></div>
   </div>
    </form>
</body>
</html>
