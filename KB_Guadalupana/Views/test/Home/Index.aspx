<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="KB_Guadalupana.Views.test.Home.Index" %>
<head>

    <link href="../../../estatico/css/login.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <link href="../../../estatico/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../../estatico/css/bootstrap.min.js"></script>
    <script src="../../../estatico/js/jquery-1.11.0.min.js"></script>    
<script src="../../../estatico/js/jquery-1.11.0.min.js"></script>

 
</head>
<div class="container-fluid px-1 px-md-5 px-lg-1 px-xl-5 py-5 mx-auto">


    <div class="card card0 border-0">
        <div class="row d-flex">
            <div class="col-lg-6 azul">
                <div class="card1 pb-5">
                    <div class="row">
                        <img src="../../../estatico/imagenes/logocope.png" class="logo" />
                    </div>
                    <div class="row px-3 justify-content-center mt-4 mb-5 border-line">
                        <img src="../../../estatico/imagenes/Logotipo.png" class="img-fluid" />
                    </div>

                    <div class="row mb-4 px-3">
                        <!-- Add font awesome icons -->
                        <a href="https://www.facebook.com/GuadalupanaesMICOOPE/" class="fa fa-facebook"></a>
                        <a href="https://twitter.com/GMicoope" class="fa fa-twitter"></a>
                        <a href="https://www.instagram.com/guadalupanaesmicoope/" class="fa fa-instagram"></a>

                    </div>
                </div>
            </div>
            <div class="col-lg-6">
          
                <div class="card2 card border-0 px-4 py-5">
                  
                    <div class="row px-3 mb-4">
                        <div class="line"></div> 
                        <div class="line"></div>
                    </div>
                    <div class="row px-3">
                            <h6 class="mb-0 text-sm">Usuario</h6>
                        <br />
                         <input class="mb-4" type="text" name="usuario" id="usuario" placeholder="Ingrese su usuario">
                    </div>
                    <div class="row px-3">
                            <h6 class="mb-0 text-sm">Contraseña</h6>
                            <br />
                        <input type="password" id="pass" name="password" placeholder="Ingrese su Contraseña">
                    </div>

                    <div class="row mb-3 px-3"> <button class="btn btn-blue text-center" onclick="validar();">Ingresar</button> </div>
                    
                </div>
            </div>
        </div>

    </div>
</div>



<script>


    function validar() {

        alert("entra");
        
        var operacionx = 2;
        var items = [

            {

                operacion: operacionx,
                nom_usu: document.getElementById("usuario").value,
                usu_pas: document.getElementById("pass").value,

            }
        ];



        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '/KB_Guadalupana/Home/vistausuario',
            data: things,
            success: function (response) {

                if (response.success) {
                    alert("pasa");
                    window.location = "inicio.aspx";

                } else {
                    // server returns false
                    //alert(response.ex); // alert error message
                    alert("Usuario o contraseña incorrecta"); // alert error message
                }
            }
        });

        alert("sale");

    }


</script>