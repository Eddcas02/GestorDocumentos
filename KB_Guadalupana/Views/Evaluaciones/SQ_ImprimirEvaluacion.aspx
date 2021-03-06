<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SQ_ImprimirEvaluacion.aspx.cs" Inherits="KB_Guadalupana.Views.Evaluaciones.SQ_ImprimirEvaluacion" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css'>
    <title>Imprimir Evaluación</title>
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
</head>
<body>
    <form id="form1" runat="server">
        <div class="general" style="margin-top:500px">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            
            <label class="titulo"><b>Evaluación de Desempeño</b></label>
            <br /><br />
            <asp:Button runat="server" ID="Imprimir" Text="Imprimir Evaluación" CssClass="boton" OnClick="Imprimir_Click" />
            <asp:Button runat="server" ID="Button1" Text="Imprimir Preguntas" CssClass="boton" OnClick="Button1_Click" /><br /><br />

            <%-- <div class="formato" style="margin-left:500px">
                <rsweb:reportviewer id="ReportViewer1" runat="server" CssClass="reporte" style="min-width: 80%; max-width: 80%; width: 80%; display:flex; justify-content:center;justify-items:center;align-content:center" showbackbutton="False" showrefreshbutton="False" showzoomcontrol="False" ShowPrintButton="True" ShowExportControls="False"></rsweb:reportviewer>
             </div>--%>


            <div class="row">

          
            <div class="row"> 
                                <div class="col-lg-6">
                                            <div class="formato">
                <rsweb:reportviewer id="ReportViewer1" runat="server" CssClass="reporte" style="min-width: 80%; max-width: 100%; width: 100%; display:flex; justify-content:center;justify-items:center;align-content:center" showbackbutton="False" showrefreshbutton="False" showzoomcontrol="False" ShowPrintButton="false" ShowExportControls="False"></rsweb:reportviewer>
             </div>
                                </div>
                                <div class="col-lg-6">
                     <div class="formato" >
                <rsweb:reportviewer id="ReportViewer2" runat="server" CssClass="reporte" style="min-width: 80%; max-width: 100%; width: 100%; display:flex; justify-content:center;justify-items:center;align-content:center" showbackbutton="False" showrefreshbutton="False" showzoomcontrol="False" ShowPrintButton="True" ShowExportControls="False"></rsweb:reportviewer>
             </div>
                                </div>
                            </div>
            <div class="row">
                <div class="col-lg-3">

                </div>
                <div class="col-lg-6">
                      <rsweb:reportviewer id="ReportViewer3" runat="server" CssClass="reporte" style="min-width: 10%; max-width: 100%; width: 80%; display:flex; justify-content:center;justify-items:center;align-content:center" showbackbutton="False" showrefreshbutton="False" showzoomcontrol="False" ShowPrintButton="False" ShowExportControls="False"></rsweb:reportviewer>
      
                </div>
                <div class="col-lg-3">

                </div>


            </div>
                  </div>
        </div>
    </form>
</body>
</html>
