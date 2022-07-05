﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vistageneral.aspx.cs" Inherits="KB_Guadalupana.Views.test.usuario.vistageneral" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
            <title>Registro</title>
    <script src="../../../estatico/js/jquery-1.11.0.min.js"></script>    
    <link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    <link href="../../../estatico/css/barra.css" rel="stylesheet" />
    <link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
</head>
    <div id="menu" class="manu"></div>
<body>
    <div class="container main">
        <h2>Colaboradores Ingresados</h2>
        <div class="table-responsive">
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Nombre</th>
                        <th scope="col">CIF</th>
                        <th scope="col">Area</th>
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

<script>

    window.addEventListener("load", function (event) {
        listacolaboradores();
    });

    function listacolaboradores() {

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
            url: '../../../usuario/vistacolaboador',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {

                    d +=
                        '<tr>' +
                        '<th scope="row">' + item.col_id + '</th>' +
                        '<td>' + item.col_dpi + '</td>' +
                        '<td>' + item.col_cif + '</td>' +
                        '<td>' + item.col_1no + ' ' + item.col_1ap + '</td>' +
                        '<td>' + "<p><a href='/usuario/editarcolaborador?codigo=" + item.col_id + "'>Editar</a></p>" + '</td>' +
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