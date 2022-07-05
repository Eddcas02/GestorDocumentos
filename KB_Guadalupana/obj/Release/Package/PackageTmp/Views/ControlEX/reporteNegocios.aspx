<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reporteNegocios.aspx.cs" Inherits="KB_Guadalupana.Views.ControlEX.reporteNegocios" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Reportes Mesa</title>
     <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css'>

      <style>
           @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;400&display=swap');
        body{
            background-image:url("../../Imagenes/Imagenes_areas/fondo_blanco_liso.jpg"); 
            background-size: 100%;
            display:flex;
            align-content:center;
            align-items:center;
            justify-content:center;
            width:100%;
            height:100%;
            font-family:'Montserrat';
        }

        html{
             width:100%;
            height:100%;
        }

        .boton{
            background-color:#69A43C;
            border:0px;
            height:35px;
            width:250px;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            color:white;
            font-family:'Montserrat';
        }

        .boton:hover{
             background-color:#4D782C;
            border:0px;
        }

        .titulo{
            color:#003563;
            font-family:'Montserrat';
            font-size:25px;
        }

        .general{
            display:flex;
            flex-direction:column;
            justify-content:center;
            align-content:center;
            align-items:center;
        }

        .formato{
            display:flex;
            align-content:center;
            justify-content:center;
            align-items:center;
            width:100%;
            margin:0px;
        }

        .reporte{
            display:flex;
            align-content:center;
            justify-content:center;
            align-items:center;
            margin:0px;
        }
    </style>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" >
</head>
<body>
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
       
        <div class="general" style="margin-top:150px">
              <div class="row">

                  <div class="col-md-6">
                          <asp:Button ID="retorno" runat="server" Width="150px" Height="50px" text="Regresar" PostBackUrl="~/Views/ControlEX/Ex_Principal.aspx" /> <br />
                      <br />
                      <asp:Button ID="btnreporte" runat="server" Width="150px" Height="50px" text="Metas" OnClick="btnreporte_Click" /> <br /> <br />
                  
                      <asp:Button ID="Button2" runat="server" Width="150px" Height="50px" text="Pendientes" OnClick="repo2_Click" /> 
                  </div>

                  <div class="col-md-6">


                  </div>
                
            </div>
        <div class="row">
            <div class="col-md-6">
                  <asp:Label id="Label1" Text="Fecha Inicial" Font-Bold runat="server" />  <br />  
        <input type="date" id="date1" runat="server" name="birthday"/>
            <asp:Label id="cont" Text="0" Font-Bold runat="server" />  <br />  
            </div>
            
              <div class="col-md-6">

                    <asp:Label id="Label2" Text="Fecha Final" Font-Bold runat="server" /> <br />   
                         <input type="date" id="date2" runat="server" name="birthday"/>
                
              </div>
        </div>
            <br />
         
               <div class="row">
                   <div class="col-md-6">
                                          </div>
                   <div class="col-md-4 ">

                   </div>
                   <div class="col-md-6">
                       
                   </div>
                    
                   </div>
            <br />
            <br />

     <div class="formato" style="width:95%">


                <rsweb:reportviewer id="ReportViewer1" runat="server" CssClass="reporte" style="min-width: 80%; max-width: 80%; width: 80%; display:flex; justify-content:center;justify-items:center;align-content:center" showbackbutton="False" showrefreshbutton="False" showzoomcontrol="False" ShowPrintButton="True" ShowExportControls="True"></rsweb:reportviewer>
             </div>
            </div>
    </form>
</body>
</html>
