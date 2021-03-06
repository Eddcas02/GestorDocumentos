<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="porfec.aspx.cs" Inherits="KB_Guadalupana.Views.test.reporte.porfec" %>
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
        <h2>Filtre por Fechas.</h2>

        <h6>Fecha de inicio.</h6>
        <div class="input-group mb-3">
            <input type="date" id="fecha1" name="trip-start" class="form-control"
                   value="2018-07-22"
                   min="1995-01-01" max="2030-12-31">

        </div>
        <h6>Fecha de finalización.</h6>
        <div class="input-group mb-3">
            <input type="date" id="fecha2" name="trip-start" class="form-control"
                   value="2018-07-22"
                   min="1995-01-01" max="2030-12-31">
        </div>
        <button type="button" class="btn btn-outline-primary" onclick="operacion(1)">Filtrar</button>
        <div class="table-responsive">
            <br />
            <label for="inputdefault">Evaluaciones encontradas en el rango de fechas.</label>
            <button type="button" class="btn btn-link" id="0" onclick="exportar1()"><img src="../../../estatico/imagenes/excel.png" class="img-fluid" style="max-width:40px; " /></button>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">ID Calificación</th>
                        <th scope="col">ID Eva.</th>
                        <th scope="col">ID Test.</th>
                        <th scope="col">Nombre evaluacón</th>
                        <th scope="col">Fecha Inicio</th>
                        <th scope="col">Fecha Final</th>
                        <th scope="col">Estado</th>
                    </tr>
                </thead>
                <tbody id="tbodyx">
                </tbody>
            </table>
        </div>
        <div class="table-responsive">
            <br />
            <label for="inputdefault">Detalle</label>
            <button type="button" class="btn btn-link" id="1" onclick="exportar2()"><img src="../../../estatico/imagenes/excel.png" class="img-fluid" style="max-width:40px; " /></button>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">ID Registro</th>
                        <th scope="col">Reg/Eva.</th>
                        <th scope="col">Evaluación.</th>
                        <th scope="col">Pregunta</th>
                        <th scope="col">Área Evaluador</th>
                        <th scope="col">Evaluador</th>
                        <th scope="col">Área Evaluado</th>
                        <th scope="col">Evaluado</th>
                        <th scope="col">Nota</th>

                    </tr>
                </thead>
                <tbody id="tbodyxz">
                </tbody>
            </table>
            <button type="button" class="btn btn-outline-primary" onclick="operacion2()">Detalle</button>
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
                fec_ini: document.getElementById("fecha1").value,
                fec_fin: document.getElementById("fecha2").value,

            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../reporte/filtrofecha',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {


                    d +=
                        '<tr>' +
                        '<th scope="row">' + item.id_eva + '</th>' +
                        '<td>' + item.id_tes + '/' + item.nom_tes + '</td>' +
                        '<td>' + item.tit_eva + '</td>' +
                        '<td>' + item.obs_eva + '</td>' +
                        '<td>' + item.fec_ini + '</td>' +
                        '<td>' + item.fec_fin + '</td>' +
                        '<td>' + item.nom_est + '</td>' +
                        '</tr>';



                });
                $("#tbodyx").append(d);
            }

        });
    }



    function operacion2() {

        $("#tbodyxz").empty();
        var d = '';
        
        var items = [
            {
                operacion: 1,
                fec_ini: document.getElementById("fecha1").value,
                fec_fin: document.getElementById("fecha2").value,

            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../reporte/filtrofechadet',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {

                    d +=
                        '<tr>' +
                    '<th scope="row">' + item.id_reg_det + '</th>' +
                    '<td>' + item.id_calificacion + '</td>' +
                    '<td>' + item.id_eva + '</td>' +
                     '<td>' + item.id_pre + '/' + item.tit_pre + '</td>' +
                    '<td>' + item.id_are_cal + '</td>' +
                    '<td>' + item.nom_calificador + '</td>' +
                    '<td>' + item.id_are_eva + '</td>' +
                    '<td>' + item.nom_evaluado + '</td>' +
                    '<td>' + item.punteo + '</td>' +
                        '</tr>';



                });
                $("#tbodyxz").append(d);
            }

        });
    }






    function exportar1() {

        window.location = '../../../reporte/Download';

    }




    function exportar2() {

        window.location = '../../../reporte/Download2';

    }


    function exportar2() {

        window.location = '../../../reporte/desdetalle';

    }
</script>



<script>

    $('#menu').load('../barra.aspx');

</script>