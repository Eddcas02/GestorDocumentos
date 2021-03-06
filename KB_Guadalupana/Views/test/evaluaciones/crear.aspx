<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crear.aspx.cs" Inherits="KB_Guadalupana.Views.test.evaluaciones.crear" %>

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
                <h2>Creacion de Evaluación</h2>
                
                    <label for="inputdefault">Nombre </label>
                    <input class="form-control" id="cnombre" type="text" placeholder="Nombre...">
                    <div class="form-group">
                        <label for="inputdefault">Observaciones</label>
                        <input class="form-control" id="cobservaciones" type="text" placeholder="Observaciones...">
                    </div>
                    <div class="form-group">
                        <label for="inputdefault">Fecha Limite</label>
                        <div class="input-group">
                            <input type="date" id="cfecha" name="trip-start" class="form-control"
                                   value="2018-07-22"
                                   min="1995-01-01" max="2030-12-31">
                        </div>
                    </div>

                <button type="button" class="btn btn-outline-primary" onclick="operacion(1)">Crear</button>
            </div>
        </div>

        <div class="table-responsive">
            <h2>Listado de Evaluaciones</h2>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">ID</th>
                        <th scope="col">Nombre</th>
                        <th scope="col">Observaciones</th>
                        <th scope="col">Fecha limite</th>
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
        vistageneral();

    });


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

    function operacion(valor) {

        var saber = valor

        var items = [

            {
                operacion: saber,
                nom_eva: document.getElementById("cnombre").value,
                obs_eva: document.getElementById("cobservaciones").value,
                fec_lim: document.getElementById("cfecha").value,

            }
        ];

        things = JSON.stringify({ 'items': items });

        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../evaluaciones/operacionevaluaciones',
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


</script>




<script>

    $('#menu').load('../barra.aspx');
    
</script>
