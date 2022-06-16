<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visordocumentos.aspx.cs" Inherits="KB_Guadalupana.Views.Procesos.visordocumentos" %>

<%@ Register TagPrefix="GleamTech" Namespace="GleamTech.DocumentUltimate" Assembly="GleamTech.DocumentUltimate" %>
<%@ Register TagPrefix="GleamTech" Namespace="GleamTech.DocumentUltimate.AspNet.WebForms" Assembly="GleamTech.DocumentUltimate" %>

<!DOCTYPE html>
<html>
    <head runat="server">
        <title>Document Viewer</title>
    </head>
    <body>

        <GleamTech:DocumentViewerControl ID="visor1"  runat="server" 
            Width="100%" 
            Height="800" 
            Document="C:/Users/ecasasola/Desktop/git/GestorDocumentos/KB_Guadalupana/Views/Procesos/Subidos/2-Cuentas contables - parametrizacion nuevos sistema de pagos mar-2022.xlsx" />
          
    </body>
</html>
