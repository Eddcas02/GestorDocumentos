<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarpregunta.aspx.cs" Inherits="KB_Guadalupana.Views.test.administracion.editarpregunta" %>

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
    <div class="main">


        <div class="row">
            <div class="col-12 ">
                <form action="/empleados00/pruebaajax.php">
                    <h4>Encabezado</h4>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Nombre </span>
                        </div>
                        <input class="form-control" id="nombre" type="text" placeholder="Test...">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Area</span>
                        </div>
                        <input class="form-control" id="area" type="text" placeholder="Area...">
                    </div>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Observaciones</span>
                        </div>
                        <input class="form-control" id="observaciones" type="text" placeholder="Observaciones...">

                    </div>

                    <button type="button" class="btn btn-outline-primary" onclick="actenc()">Actualizaar</button>


                </form>
            </div>
        </div>


        <div class="row">
            <div class="col-12 ">
                <form action="/empleados00/pruebaajax.php">
                    <h4>Nueva pregunta</h4>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Pregunta </span>
                        </div>
                        <input class="form-control" id="pregunta" type="text" placeholder="¿?...">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Sugerencias</span>
                        </div>
                        <input class="form-control" id="sugerencia" type="text" placeholder="¿?...">
                    </div>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Observaciones</span>
                        </div>
                        <input class="form-control" id="obs" type="text" placeholder="Detalle...">
                        <div class="input-group-prepend">
                            <span class="input-group-text">Puntuacion</span>
                        </div>
                        <input class="form-control" id="punteo" type="text" placeholder="Punteo...">

                    </div>
                </form>
                <button type="button" class="btn btn-outline-primary" onclick="agregarpreg()">Agregar</button>
            </div>
        </div>



        <div class="table-responsive">
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Pregunta</th>
                        <th scope="col">Ponderacion</th>
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
    var scodigo = 0;
    const valores = window.location.search;
    console.log(valores);
    const urlParams = new URLSearchParams(valores);
    var xcodigo = urlParams.get('codigo');
    scodigo = xcodigo;

    var d = '';

    window.addEventListener("load", function (event) {

        cenc();

    });



    function cenc() {


        var oParam = "{ 'codigo': '" + xcodigo + "' }";

        $.ajax({
            type: "POST",
            url: '../../../administracion/datospregunta',
            data: oParam,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                $.each(data, function (i, item) {

                    document.getElementById("nombre").value = item.Nombre;
                    document.getElementById("area").value = item.Area;
                    document.getElementById("observaciones").value = item.Observaciones;


                });


            },
            error: function (data) {

            }

        });

        cdet();
    }

    function cdet() {



        var d = '';



        var oParam = "{ 'codigo': '" + xcodigo + "' }";

        $.ajax({
            type: "POST",
            url: '../../../test/vistapreguntas',
            data: oParam,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                var cuanto = data.length;

                $.each(data, function (i, item) {

                    console.log(item.Nombre);

                    console.log(item.Nombre);

                    d +=
                        '<tr>' +
                        '<th scope="row">' + item.id_reg + '</th>' +
                        '<td>' + item.pre_tes + '</td>' +
                        '<td>' + item.pun_tes + '</td>' +
                        '<td>' + "<p><a href='/test/eliminar?codigo=" + item.Id + "'>Eliminar</a></p>" + '</td>' +
                        '</tr>';





                });
                $("#tbodyx").append(d);



            },
            error: function (data) {

            }

        });


    }


    function actenc() {

        var items = [

            {
                nombre: document.getElementById("nombre").value,
                area: document.getElementById("area").value,
                observaciones: document.getElementById("observaciones").value,
                id: scodigo

            }
        ];


        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../test/actenct',
            data: things,
            success: function (response) {

                if (response.success) {
                    // server returns true
                    alert("correto");
                } else {
                    // server returns false
                    //alert(response.ex); // alert error message
                    alert("Hubo un error al guardar"); // alert error message
                }
            }
        });

    }


    function agregarpreg() {



        var items = [

            {

                id_tes: xcodigo,
                pre_tes: document.getElementById("pregunta").value,
                pun_tes: document.getElementById("punteo").value,
                obs_tes: document.getElementById("obs").value



            }
        ];

        things = JSON.stringify({ 'items': items });

        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../test/agrpreg',
            data: things,
            success: function (response) {

                if (response.success) {
                    // server returns true
                    alert("Pregunta agregada");
                    limpiar()
                    cdet();

                } else {
                    // server returns false
                    alert(response.ex); // alert error message
                }
            }
        });


    }



    function limpiar() {



        $("#tbodyx").empty();

    }

</script>



<script>


    $('#menu').load('../barra.aspx');

</script>
