<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editar.aspx.cs" Inherits="KB_Guadalupana.Views.test.test.editar" %>

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
            <div class="col-12 ">
                <form action="/empleados00/pruebaajax.php">
                    <h2>Editar test</h2>
                    <h4>Encabezado</h4>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Nombre </span>
                        </div>
                        <input class="form-control" id="nombre" type="text" placeholder="Test...">
                    </div>
                    <label for="inputdefault">Área</label>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Observaciones</span>
                        </div>
                        <input class="form-control" id="observaciones" type="text" placeholder="Observaciones...">
                    </div>
                    <button type="button" class="btn btn-outline-primary" onclick="operacionenc(3)">Actualizaar</button>
                </form>
            </div>
        </div>

        <div class="row">
            <div class="col-12 ">
                <br />
                <h4>Nueva pregunta</h4>
                <select class="form-control" id="lpregunta">
                    <option value="0">Opción</option>
                </select>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Punteo </span>
                    </div>
                    <input class="form-control" id="xpunteo" type="text" placeholder="Nota...">

                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Observaciones</span>
                    </div>
                    <input class="form-control" id="obs" type="text" placeholder="Detalle...">
                </div>
                <button type="button" class="btn btn-outline-primary" onclick="operarpregunta(1,0)">Agregar</button>
            </div>
        </div>



        <div class="table-responsive">
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Pregunta</th>
                        <th scope="col">Observaciones</th>
                        <th scope="col">Operaciones</th>
                    </tr>
                </thead>
                <tbody id="tbodyx">
                </tbody>
            </table>
        </div>

    </div>




    <script>


        var scodigo = 0;
        const valores = window.location.search;
        console.log(valores);
        const urlParams = new URLSearchParams(valores);
        var xcodigo = urlParams.get('codigo');
        scodigo = xcodigo;

        var d = '';

        window.addEventListener("load", function (event) {
            preguntas();
            vistageneral();
        });

        function encabezado() {
            var d = '';
            var operacionx = 2;
            var items = [
                {
                    operacion: operacionx,
                    id_tes: scodigo,
                }
            ];

            things = JSON.stringify({ 'items': items });
            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'POST',
                url: '../../../test/vistastest',
                data: things,
                success: function (response) {
                    $.each(response, function (i, item) {
                        document.getElementById("nombre").value = item.nom_tes;
                        document.getElementById("observaciones").value = item.obs_tes;
                    });
                }
            });
        }


        function preguntas() {

            $("#lpregunta").empty();
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
                url: '../../../administracion/vistapregunta',
                data: things,
                success: function (response) {
                    $.each(response, function (i, item) {
                        d += '<option value="' + item.id_preg + '">' + item.pre_tit + '</option>';
                    });
                    $("#lpregunta").append(d);

                }

            });

            encabezado();
        }


        function operarpregunta(valor, valor2) {

            var saber = valor

            var items = [

                {
                    operacion: saber,
                    id_tes: scodigo,
                    pre_tes: $("#lpregunta option:selected").text(),
                    pun_tes: document.getElementById("xpunteo").value,
                    obs_tes: document.getElementById("obs").value,
                    id_pre: document.getElementById("lpregunta").value,
                    id_reg: valor2,
                    


                }
            ];

            things = JSON.stringify({ 'items': items });

            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'POST',
                url: '../../../test/operaciontestd',
                data: things,
                success: function (response) {

                    if (response.success) {
                        // server returns true
                        alert("Listo");
                        vistageneral();
                        
                    } else {
                        // server returns false
                        alert(response.ex); // alert error message
                    }
                }
            });

        }



        function operacionenc(valor) {

            var saber = valor

            var items = [

                {
                    operacion: saber,
                    nom_tes: document.getElementById("nombre").value,
                    obs_tes: document.getElementById("observaciones").value,
                    id_tes: scodigo,


                }
            ];

            things = JSON.stringify({ 'items': items });

            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'POST',
                url: '../../../test/operaciontest',
                data: things,
                success: function (response) {

                    if (response.success) {
                        // server returns true
                        alert("Listo");
                        
                    } else {
                        // server returns false
                        alert(response.ex); // alert error message
                    }
                }
            });

        }

        function vistageneral() {

            $("#tbodyx").empty();
            var d = '';
            var operacionx = 2;
            var items = [
                {
                    operacion: operacionx,
                    id_tes: scodigo,
                }
            ];

            things = JSON.stringify({ 'items': items });
            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'POST',
                url: '../../../test/vistastestd',
                data: things,
                success: function (response) {
                    $.each(response, function (i, item) {


                        d +=
                            '<tr>' +
                        '<th scope="row">' + item.id_reg + '</th>' +
                        '<td>' + item.pre_tes + '</td>' +
                        '<td>' + item.obs_tes + '</td>' +
                        
                        '<td>' + '<button type="button" class="btn btn-link" id="' + item.id_reg + '" onclick="operarpregunta(4,this.id)" ><img src="../estatico/imagenes/eliminar.jpg" class="img-fluid" style="max-width:30px; " /></button>' + '</td>' +    
                            '</tr>';

                    });
                    $("#tbodyx").append(d);
                }

            });
        }


    </script>

</body>
</html>



<script>

    $('#menu').load('../barra.aspx');

</script>