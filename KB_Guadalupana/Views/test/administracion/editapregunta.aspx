<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editapregunta.aspx.cs" Inherits="KB_Guadalupana.Views.test.administracion.editapregunta" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <style>
        /* Style the input field */
        #myInput {
            padding: 20px;
            margin-top: -6px;
            border: 0;
            border-radius: 0;
            background: #f1f1f1;
        }
    </style>
    
  
<script src="../../../estatico/js/jquery-1.11.0.min.js"></script>    
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
    <link href="../../../estatico/css/barra.css" rel="stylesheet" />
<link href="../../../estatico/css/creaciontest.css" rel="stylesheet" />
    
</head>


    <div id="menu" class="manu"></div>

<body>
    <div class="container main">
        <h2>Editar Pregunta</h2>
        <div class="row">
            <div class="col-md-12">
                <form action="/empleados00/pruebaajax.php">
                    <label for="inputdefault">Pregunta</label>
                    <input class="form-control" id="nombre" type="text" placeholder="Pregunta...">
                    <div class="form-group">
                        <label for="inputdefault">Punteo</label>
                        <input class="form-control" id="punteo" type="text" placeholder="punteo...">
                    </div>
                </form>
                <button type="button" class="btn btn-outline-primary" onclick="operarpregunta(3,0)">Actualizar</button>
            </div>
        </div>


        <div class="row">
            <div class="col-12 ">
                <form action="/empleados00/pruebaajax.php">
                    <h4>Agregar Respuestas</h4>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Respuesta </span>
                        </div>
                        <input class="form-control" id="respuesta" type="text" placeholder="Respuesta...">

                    </div>
                </form>
                <button type="button" class="btn btn-outline-primary" onclick="operarrespuesta(1,0)">Agregar</button>
            </div>
        </div>


        <div class="table-responsive">
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">ID</th>
                        <th scope="col">Posibles Respuestas</th>
                        <th scope="col">R/Correcta</th>
                        <th scope="col">Eliminar</th>

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
    var scodigo = 0;
    const valores = window.location.search;
    console.log(valores);
    const urlParams = new URLSearchParams(valores);
    var xcodigo = urlParams.get('codigo');
    scodigo = xcodigo;

    var d = '';

    window.addEventListener("load", function (event) {

        encabezado();
        vistageneral();

    });



    function encabezado() {
        var d = '';
        var operacionx = 2;
        var items = [
            {
                operacion: operacionx,
                id_preg: scodigo,
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
                    document.getElementById("nombre").value = item.pre_tit;
                    document.getElementById("punteo").value = item.pre_pun;
                });
            }
        });
    }


    function operarrespuesta(valor, valor2) {

        var saber = valor

        var items = [

            {
                operacion: saber,
                res_nom: document.getElementById("respuesta").value,
                id_pre: scodigo,
                id_reg: valor2,
                
          


            }
        ];

        things = JSON.stringify({ 'items': items });

        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/operacionrespuesta',
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



    function vistageneral() {

        $("#tbodyx").empty();
        var d = '';
        var operacionx = 2;
        var items = [
            {
                operacion: operacionx,
                id_pre: scodigo,
            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/vistarespuesta',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {


                    d +=
                        '<tr>' +
                    '<th scope="row">' + item.id_reg + '</th>' +
                    '<td>' + item.res_nom + '</td>' +
                        '<td>' + item.res_cor + '</td>' +

                    '<td>' + '<button type="button" class="btn btn-link" id="' + item.id_reg + '" onclick="operarrespuesta(4,this.id)" ><img src="../estatico/imagenes/eliminar.jpg" class="img-fluid" style="max-width:30px; " /></button>' + '</td>' +
                        '</tr>';

                });
                $("#tbodyx").append(d);
            }

        });
    }


    function operarpregunta(valor, id) {

        var saber = valor

        var items = [

            {
                operacion: saber,
                pre_tit: document.getElementById("nombre").value,
                pre_pun: document.getElementById("punteo").value,
                id_preg: scodigo,


            }
        ];

        things = JSON.stringify({ 'items': items });

        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/operacionpregunta',
            data: things,
            success: function (response) {

                if (response.success) {
                    // server returns true
                    alert("Listo");
                    preguntas();
                } else {
                    // server returns false
                    alert(response.ex); // alert error message
                }
            }
        });

    }
</script>


<script>


    $('#menu').load('../barra.aspx');

</script>
