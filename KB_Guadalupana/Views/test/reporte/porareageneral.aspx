<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="porareageneral.aspx.cs" Inherits="KB_Guadalupana.Views.test.reporte.porareageneral" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Registro</title>

    <link href="~/estatico/css/fondogris.css" rel="stylesheet" />
    <link href="~/estatico/css/barra.css" rel="stylesheet" />
<script src="../../../estatico/js/jquery-1.11.0.min.js"></script>    
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
    <link href="../../../estatico/css/barra.css" rel="stylesheet" />
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
</head>


    <div id="menu" class="manu"></div>

<body>

    <div class="container main">
        <h2>Filtre por área.</h2>
        <div class="form-group">
            <label for="inputdefault">Seleccione Área</label>
            <select class="form-control" id="areaedit" onfocus="area00();">
                <option value="0">Opción</option>
            </select>
        </div>
        <div class="form-group">
            <label for="inputdefault">Seleccione Evaluacion</label>
            <select class="form-control" id="evaluacion" onfocus="eva();">
                <option value="0">Opción</option>
            </select>
        </div>
        <button type="button" class="btn btn-outline-primary" onclick="operacion(1)">Filtrar</button>

        <div class="table-responsive">
            <br />
            <label for="inputdefault">Encabezado</label>
            <button type="button" class="btn btn-link" id="0" onclick="exportar1()"><img src="../../../estatico/imagenes/excel.png" class="img-fluid" style="max-width:40px; " /></button>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Evaluación</th>
                        <th scope="col">Evaluado</th>
                        <th scope="col">ID Pregunta</th>
                        <th scope="col">Pregunta</th>
                        <th scope="col">Punteo</th>
                        <th scope="col">Cant. </th>
                        <th scope="col">Cant Eval.</th>
                        <th scope="col">ID Área</th>
                        <th scope="col">Promedio P/P</th>
                        <th scope="col">Promedio individual</th>
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


    function area00() {

        $("#areaedit").empty();
        var d = '<option value="0">Opción</option>';
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

                    d += '<option value="' + item.id_reg + '">' + item.nom_are + '</option>';

                });
                $("#areaedit").append(d);
            }

        });

    }


    function eva() {


        $("#evaluacion").empty();
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
            url: '../../../evaluaciones/vistageneral',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {

                    d += '<option value="' + item.id_eva + '">' + item.tit_eva + '</option>';

                });
                $("#evaluacion").append(d);
            }

        });

    }



    function operacion(valor) {

        $("#tbodyx").empty();
        var d = '';
        var operacionx = valor;
        var items = [
            {
                operacion: operacionx,
                id_are: document.getElementById("areaedit").value,
                id_eva: document.getElementById("evaluacion").value,

            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../reporte/filtroareadet',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {


                    d +=
                        '<tr>' +
                    '<th scope="row">' + item.id_eva + '</th>' +
                    '<td>' + item.id_calificado + '</td>' +
                    '<td>' + item.id_pre + '</td>' +
                    '<td>' + item.nom_pre + '</td>' +
                    '<td>' + item.punteo + '</td>' +
                    '<td>' + item.cant_preg + '</td>' +
                    '<td>' + item.calificador_cuantos + '</td>' +
                    '<td>' + item.id_are + '</td>' +
                    '<td>' + item.promedio_ind + '</td>' +
                    '<td>' + item.promedio_gen + '</td>' +
                    
                        '</tr>';

                /*
                 *
                 *
                 operacion
                id_eva
                id_calificado
                id_pre
                nom_pre
                punteo
                cant_preg
                calificador_cuantos
                id_are
                promedio_ind
                promedio_gen
    
    
    
               
                */


                });
                $("#tbodyx").append(d);
            }

        });
    }





    function exportar1() {

        window.location = '../../../reporte/dmareageneral';

    }



</script>


<script>

    $('#menu').load('../barra.aspx');

</script>