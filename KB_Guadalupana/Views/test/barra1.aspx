<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="barra1.aspx.cs" Inherits="KB_Guadalupana.Views.test.barra1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../../estatico/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../../estatico/css/bootstrap.min.js"></script>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   
    <div class="completo">


    <link href="../../../estatico/css/barra.css" rel="stylesheet" />
    <nav class="navbar navbar-expand-lg navbar-light bg-light">

       <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="../../Home/Index.aspx">Home <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" href="#" id="conf" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        Configuración
                    </a>
                    <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                        <a class="dropdown-item" href="../resolver/editarusuario">Mi perfil</a>
                        <div class="dropdown-divider"></div>
                        
                    </div>
                </li>
            </ul>
            <form class="form-inline my-2 my-lg-0">
                <a href="../Home/Index.aspx" class="btn btn-link"><img src="../../../estatico/imagenes/salir.png" class="logo" style="max-width:30px; " /></a>
            </form>
        </div>
    </nav>



</div>

</body>
</html>
