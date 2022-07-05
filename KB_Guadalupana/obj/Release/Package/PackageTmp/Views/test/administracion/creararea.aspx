﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="creararea.aspx.cs" Inherits="KB_Guadalupana.Views.test.administracion.creararea" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>Registro</title>
    
  
<script src="../../../estatico/js/jquery-1.11.0.min.js"></script>    
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
    <link href="../../../estatico/css/barra.css" rel="stylesheet" />
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
</head>


    <div id="menu" class="manu"></div>

<body>
    <div class="container main">
        <div class="row">
            <div class="col-md-12">
                <h2>Crear Área</h2>
                <form action="/empleados00/pruebaajax.php">
                    <label for="inputdefault">Nombre del Área</label>
                    <input class="form-control" id="nombre" type="text" placeholder="Nombre...">
                    <div class="form-group">
                        <label for="inputdefault">Observaciones</label>
                        <input class="form-control" id="observaciones" type="text" placeholder="Observaciones...">
                    </div>
                </form>
                <button type="button" class="btn btn-outline-primary" onclick="crea(7)">Crear</button>
            </div>
        </div>

        <div class="table-responsive">
            <h2>Lista Areas</h2>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Nombre</th>
                        <th scope="col">Observaciones</th>
                        <th scope="col">Operaciones</th>
                    </tr>
                </thead>
                <tbody id="tbodyx">
                </tbody>
            </table>
        </div>
    </div>

</body>
</html>



<script>function crea(valor) {

    var saber = valor
        var items = [

            {
                operacion: saber,
                nom_are: document.getElementById("nombre").value,
                obs_are: document.getElementById("observaciones").value

            }
        ];

        things = JSON.stringify({ 'items': items });

        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/operacionesarea',
            data: things,
            success: function (response) {

                if (response.success) {
                    // server returns true
                    alert("Área Creada");
                    limpiar();
                    vista00();
                } else {
                    // server returns false
                    alert(response.ex); // alert error message
                }
            }
        });

    }

    </script>


<script>

    function limpiar() {
        $("#tbodyx").empty();
    }

    function vista00() {

        var d = '';
        var operacionx = 1;
        var items = [
            {
                operacion: operacionx,
            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/datosarea',
            data: things,
            success: function (response) {

                $.each(response, function (i, item) {
                    d +=
                    '<tr>' +
                    '<th scope="row">' + item.id_reg + '</th>' +
                    '<td>' + item.nom_are + '</td>' +
                    '<td>' + item.obs_are + '</td>' +
                    '<td>' + "<p><a href='/administracion/editararea?codigo=" + item.id_reg + "'>Editar</a></p>" + '</td>' +

                    '</tr>';


                });
                $("#tbodyx").append(d);

            }
        });





    }

    window.addEventListener("load", function (event) {
        vista00();
    });

</script>


<script>


    $('#menu').load('../barra.aspx');

                    </script>

