<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteVentana.aspx.cs" Inherits="KB_Guadalupana.Views.ControlEX.ReporteVentana" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css'/><link rel="stylesheet" href="../../EXDiseños/stylebarra.css"/>
    
   <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
   <link rel="stylesheet" type="text/css" href="../../EXDiseños/ExtiloExEnvio.css" />
     <link type="text/css" rel="stylesheet" href="../../EXDiseños/estilolector.css" />

      <script src="https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js" type="text/javascript"></script>
        
    <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>

     <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet"/>


    <title>Exportar Expedientes</title>
</head>
<style>

   .btn1 {
        background-color: rgba(51, 51, 51, 1);
    color: white;
    border-radius: 25px;

    }

    .btn1:hover {
     box-shadow: 0 12px 16px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(47, 255, 255, 1);
     background-color: rgba(51, 51, 51, 1);
    color: white;
    border-radius: 25px;
    
    }
</style>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      

	  <center>
               
         
           <div class="containter" id="val" runat="server" >
         <div class="row">
             
             <div class="col-md-4">

             </div>
             
             <div class="col-md-4">
                  <center>

             <h3 style=" font-size:20px; margin-left: 0%; margin-right: 0%;">Reportes del sistema</h3>
            <asp:Button ID="btnrepo" Visible="false" Text="Generar Hallazgos" CssClass="btn1" runat="server" OnClick="btnrepo_Click" Width="200px" /> <br />
                      <br />
            <asp:Button ID="btnrepo2" Text="Generar Estatus" CssClass="btn1" Visible="false" runat="server" OnClick="btnrepo2_Click" Width="200px" />
         <div id="dateencab" runat="server" visible="false" class="row">
            <div class="col-md-6">
                  <asp:Label id="Label1" Text="Fecha Inicial" Font-Bold runat="server" />  <br />  
        <input type="date" id="date1" runat="server" name="birthday"/>
           
            </div>
            
              <div class="col-md-6">

                    <asp:Label id="Label2" Text="Fecha Final" Font-Bold runat="server" /> <br />   
                         <input type="date" id="date2" runat="server" name="birthday"/>
                
              </div>
        </div>
                      </center>


             </div>

             <div class="col-md-4">


             </div>
            
           
             </div>

         
               </div>
                 
       </center>
       
         <br />     <br />  <br />     <br />

        <%--     <div class="row" style="width:100%;">

                 <div class="col-md-4">

                 </div>
                 <div class="col-md-4">
                        <rsweb:reportviewer id="ReportViewer1" runat="server"   style="min-width: 100%; max-width: 100%; display:flex; justify-content:center;justify-items:center;text-align:center;" showbackbutton="False" showrefreshbutton="False" showzoomcontrol="False" ShowPrintButton="False" ShowExportControls="True" Height="68px" ShowFindControls="False" ShowPageNavigationControls="False" ShowReportBody="True"></rsweb:reportviewer>
                 </div>
                 <div class="col-md-4">

                 </div>
             
                 </div>--%>


        <div id="reportehalldiv" runat="server" style="width:100%; margin-bottom:200px">
              <rsweb:reportviewer id="ReportViewer1" runat="server"   style="min-width: 100%; max-width: 100%; display:flex; justify-content:center;justify-items:center;text-align:center;" showbackbutton="False" showrefreshbutton="False" showzoomcontrol="False" ShowPrintButton="False" ShowExportControls="True" Height="500px" ShowFindControls="False" ShowPageNavigationControls="False" ShowReportBody="True"></rsweb:reportviewer>

        </div>
     

              <br />
 
       
       
 
        <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
        <script src="../../EXDiseños/scriptvalidar.js" type="text/javascript"></script>
		        <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js'></script><script  src="../../EXDiseños/scriptbarra.js"></script>


    </form>

    
</body>
</html>
