<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarusuario.aspx.cs" Inherits="KB_Guadalupana.Views.test.usuario.editarusuario" %>
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
                <h2>Editar Usuarios</h2>
                <div class="input-group mb-3">
                    <input class="form-control" id="xusuario" type="text" placeholder="Usuario..." disabled>
                </div>
                <div class="form-group">
                    <label for="inputdefault">Seleccione Tipo Usuario</label>
                    <select class="form-control" id="tipus" onfocus="categoria();">
                        <option value="0">Opción</option>
                    </select>
                </div>
                <div class="input-group mb-3">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Pass</span>
                    </div>
                    <input type="password" class="form-control" id="pwd" placeholder="Ingrese Contraseña" name="pwd">
                    <div class="input-group-prepend">
                        <span class="input-group-text">Confirm Pass</span>
                    </div>
                    <input type="password" class="form-control" id="pwdc" placeholder="Confirmar Contraseña" name="pwd">
                </div>
                <button type="button" class="btn btn-outline-primary" onclick="operarusuario(2,0)">Actualizar</button>
                <button type="button" class="btn btn-danger" onclick="operarusuario(3)">Eliminar</button>
            </div>
        </div>
    </div>
    

</body>
</html>



<script>

    var xrol = 0;
    var xarea = 0;
    var xsucursal = 0;

    var scodigo = 0;
    const valores = window.location.search;
    console.log(valores);
    const urlParams = new URLSearchParams(valores);
    var xcodigo = urlParams.get('codigo');
    scodigo = xcodigo;

    window.addEventListener("load", function (event) {
        datosusuario();

    });



    function datosusuario() {


     
        $("#tipus").empty();
        var dd = '';
        var operacionx = 2;
        var items = [
            {
                operacion: operacionx,
                id_reg: scodigo,

            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../usuario/vistausuarios',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {
                    document.getElementById("xusuario").value = item.nom_usu;
                    document.getElementById("pwd").value = item.usu_pas;
                    document.getElementById("pwdc").value = item.usu_cpa;
                    dd += '<option value="' + item.id_cat + '">' + item.nom_cat+ '</option>';
                });
           
                $("#tipus").append(dd);

            }
              
        });

    }


    function categoria() {
        $("#tipus").empty();
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
            url: '../../../usuario/vistatipus',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {

                    d += '<option value="' + item.id_cat + '">' + item.cat_nom + '</option>';

                });
                $("#tipus").append(d);
            }

        });
    }



    function operarusuario(valor, valor2) {

        var saber = valor

        var items = [

            {
                operacion: saber,
                id_reg: scodigo,
                nom_usu: document.getElementById("xusuario").value,
                usu_pas: document.getElementById("pwd").value,
                usu_cpa: document.getElementById("pwdc").value,
                id_cat: document.getElementById("tipus").value,
                nom_cat: $("#tipus option:selected").text(),

             
            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../usuario/operacionusuario',
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
</script>




<script>

    $('#menu').load('../barra.aspx');

</script>
