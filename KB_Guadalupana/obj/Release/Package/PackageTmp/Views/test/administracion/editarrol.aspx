﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarrol.aspx.cs" Inherits="KB_Guadalupana.Views.test.administracion.editarrol" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <link href="~/estatico/css/barra.css" rel="stylesheet" />
<script src="../../../estatico/js/jquery-1.11.0.min.js"></script>    
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
<link href="../../../estatico/css/completo.css" rel="stylesheet" />

    
</head>


    <div id="menu" class="manu"></div>


<body>
     

    <div class="container main">
        <div class="row">
            <div class="col-md-12">
                <h2>Crear Rol</h2>
                <form action="/empleados00/pruebaajax.php">
                    <label for="inputdefault">Nombre Rol</label>
                    <input class="form-control" id="rolnom" type="text" placeholder="Rol...">
                    <div class="form-group">
                        <label for="inputdefault">Observaciones</label>
                        <input class="form-control" id="rolobs" type="text" placeholder="Obs...">
                    </div>
                </form>
                <button type="button" class="btn btn-outline-primary" onclick="operaciones(3)">Actualizar</button>
                <button type="button" class="btn btn-danger" onclick="operaciones(4)">Eliminar</button>
            </div>
        </div>
    </div>

</body>
</html>


<script>


    var scodigo = 0;
    const valores = window.location.search;
    console.log(valores);
    const urlParams = new URLSearchParams(valores);
    var xcodigo = urlParams.get('codigo');
    scodigo = xcodigo;

    var d = '';

    window.addEventListener("load", function (event) {

        vistaroles();


    });


    function vistaroles() {


        var d = '';
        var operacionx = 2;
        var items = [

            {
                operacion: operacionx,
                id_rol: scodigo
            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/vistaroles',
            data: things,
            success: function (response) {

                $.each(response, function (i, item) {
                    document.getElementById("rolnom").value = item.rol_nom;
                    document.getElementById("rolobs").value = item.rol_obs;
                });
            }
        });
    }



    function operaciones(valor) {

        var operacionx = valor;


        var items = [

            {

                operacion: operacionx,
                rol_nom:document.getElementById("rolnom").value ,
                rol_obs:document.getElementById("rolobs").value ,
                id_rol: scodigo
            }
        ];



        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/operacionesrol',
            data: things,
            success: function (response) {

                if (response.success) {
                    // server returns true
                    alert("Listo");

                    window.location = "../administracion/agregarroles/";

                } else {
                    // server returns false
                    //alert(response.ex); // alert error message
                    alert("Hubo un error al operar"); // alert error message
                }
            }
        });

    }



</script>


<script>


    $('#menu').load('../barra.aspx');

</script>
