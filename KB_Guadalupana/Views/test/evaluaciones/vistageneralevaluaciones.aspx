﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vistageneralevaluaciones.aspx.cs" Inherits="KB_Guadalupana.Views.test.evaluaciones.vistageneralevaluaciones" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Registro</title>
    <link href="~/estatico/css/vistatest.css" rel="stylesheet" />
    <link href="~/estatico/css/barra.css" rel="stylesheet" />
    <link href="~/estatico/css/fondogris.css" rel="stylesheet" />

<script src="../../../estatico/js/jquery-1.11.0.min.js"></script>    
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
    <link href="../../../estatico/css/barra.css" rel="stylesheet" />
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
</head>


    <div id="menu" class="manu"></div>

<body>

    <div class="container main">
        <h2>Evaluaciones Ingresados</h2>
        <div class="table-responsive">
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">ID</th>
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

    <table style="width:100%" border="1" id="tabla"></table>

</body>
</html>

<script>

    window.addEventListener("load", function (event) {
        vistageneral();
    });

   

    function limpiar() {
        $("#tbodyx").empty();
    }


    function vistageneral() {

        $("#tbodyx").empty();
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
            url: '../../../evaluaciones/vistaevaluaciones',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {


                    d +=
                        '<tr>' +
                        '<th scope="row">' + item.id_eva + '</th>' +
                        '<td>' + item.nom_eva + '</td>' +
                        '<td>' + item.obs_eva + '</td>' +
                        '<td>' + "<p><a href='/evaluaciones/enviodeevaluaciones?codigo=" + item.id_eva + "'>Editar</a></p>" + '</td>' +
                        '</tr>';

                });
                $("#tbodyx").append(d);
            }

        });
    }
</script>


<script>

    $('#menu').load('../barra.aspx');

</script>