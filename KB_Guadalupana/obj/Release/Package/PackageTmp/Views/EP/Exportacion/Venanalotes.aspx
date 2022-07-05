<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Venanalotes.aspx.cs" Inherits="KB_Guadalupana.Views.EP.Venanalotes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
       <script src="../Estaticos/validacionletrasnum.js"></script>
      <title></title>
</head>
    <body> 
    <form id="form1" runat="server">
       <div class="container main">
             

        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Crear Lote</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                        <div class="col-lg-2">
                      <asp:CheckBox ID="habil" Text="" AutoPostBack="true" runat="server" OnCheckedChanged="habil_CheckedChanged" /> <label  id="Label1" runat="server" >Modificar Lote Existente</label>
                      
               <asp:DropDownList  ID="lotes" Visible="false" runat="server" CssClass="form-control" AutoPostBack="true"  Width="100%" OnSelectedIndexChanged="lotes_SelectedIndexChanged"  ></asp:DropDownList><br/>
                          </div> 
                 
                    <div class="col-lg-2">
                      <label  id="Label2" runat="server" >Descripción del Lote</label>
               <asp:TextBox runat="server" Width="100%" ID="LoteDescripcion" TextMode="SingleLine" placeholder="Lote 2022" CssClass="form-control" />
                          </div>
                
                    <div class="col-lg-2">
                        <label>Fecha de Inicio</label>
                        <asp:TextBox runat="server" ID="LoteFecInicio" Width="100%" TextMode="Date"  CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                        <label>Fecha Fin</label>
           <asp:TextBox runat="server" ID="LoteFecFin" Width="100%" TextMode="Date" CssClass="form-control" />
                    </div>
                      <div class="col-lg-2">
                        <label>Tipo de Cambio</label>
           <asp:TextBox runat="server" ID="LoteTipoCambio" Width="100%" TextMode="SingleLine" onkeypress="return numeros(event);"  CssClass="form-control" />
                    </div>
                       <div class="col-lg-2">
                        <label>Fecha de corte</label>
           <asp:TextBox runat="server" ID="LoteFecData" Width="100%"  TextMode="Date"   CssClass="form-control" />
                    </div>
                  <div class="col-lg-2">
                        <label>Estado</label>
            <asp:DropDownList  ID="LoteEstado" runat="server" CssClass="form-control"   Width="100%"  >
                         <asp:ListItem Text="[Estado]" Value="0" />       
                   <asp:ListItem Text="Activo" Value="True" />
                                        <asp:ListItem Text="Inactivo" Value ="False"/>


               </asp:DropDownList>          </div>
                 
    

                </div>
            </div>
        </div>
            <center>
                 <asp:Label ID="lblSuccessMessage1" Text="Datos Guardados" Visible="false" runat="server" ForeColor="Green" /> <br />
      <asp:Label ID="lblerror" Text="Completar los datos" Visible="false" runat="server" ForeColor="Red" /> <br />
     
             <asp:Button ID="btncrearlote" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" 
                 Height="40px" CssClass="btn1" Text="Crear" OnClick="btncrearlote_Click" />
                  <asp:Button ID="ModificarLote" Visible="false" Font-Names=" 'Rubik', sans-serif" runat="server" Width="80%" 
                 Height="40px" CssClass="btn1" Text="Modificar" OnClick="ModificarLote_Click" />
                   </center>
                </div>
    </form>

</body>
</html>
