<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editarsucursal.aspx.cs" Inherits="KB_Guadalupana.Views.test.administracion.editarsucursal" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>Registro</title>
    <link href="~/estatico/css/barra.css" rel="stylesheet" />
    

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
                <h2>Actualizar Unidad Operativa</h2>
                <form action="/empleados00/pruebaajax.php">
                    <div class="form-group">
                        <label for="">Información General</label>
                        <div class="input-group">
                            <input name="remitosucursal" id="nombre" type="text" required class="form-control" placeholder="Nombre">
                            <span class="input-group-addon">-</span>
                            <input name="remitonumero" id="direccion" type="text" required class="form-control" placeholder="Direccion">
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="input-group">
                            <input name="remitosucursal" id="telefono" type="text" required class="form-control" placeholder="Telefono">
                            <span class="input-group-addon">-</span>
                            <input name="remitonumero" id="email" type="text" required class="form-control" placeholder="Email">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputdefault">Encargado</label>
                        <div class="input-group">
                            <select class="form-control" id="colaboradores">
                                <option value="0">Opción</option>
                            </select>
                        </div>
                    </div>
                </form>
                <button type="button" class="btn btn-outline-primary" onclick="operaciones(3)">Actualizar</button>
                <button type="button" class="btn btn-danger" onclick="operaciones(4)">Eliminar</button>
            </div>
        </div>
    </div>

</body>
</html>



<script>

    var scodigo = 0;
    const valores = window.location.search;
    
    const urlParams = new URLSearchParams(valores);
    var xcodigo = urlParams.get('codigo');
    scodigo = xcodigo;

    var d = '';

    window.addEventListener("load", function (event) {
        listadocolaboradores();
        vistasucursales();

    });


    function operaciones(valor) {
        var operacionx = valor;
        var items = [

            {
                operacion: operacionx,
                suc_nom: document.getElementById("nombre").value,
                suc_dir: document.getElementById("direccion").value,
                suc_tel: document.getElementById("telefono").value,
                suc_cor: document.getElementById("email").value,
                id_enc: document.getElementById("colaboradores").value,
                id_reg: scodigo

            }
        ];

        things = JSON.stringify({ 'items': items });
        $.ajax({
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            type: 'POST',
            url: '../../../administracion/operacionsucursal',
            data: things,
            success: function (response) {
                if (response.success) {
                    // server returns true
                    alert("Listo");
                    window.location = "../administracion/agregarsucursal/";
                } else {
                    // server returns false
                    //alert(response.ex); // alert error message
                    alert("Hubo un error al operar"); // alert error message
                }
            }
        });

    }


    function vistasucursales() {

        var d = '';
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
            url: '../../../administracion/datossucursal',
            data: things,
            success: function (response) {
                $.each(response, function (i, item) {

                    document.getElementById("nombre").value = item.suc_nom;
                    document.getElementById("direccion").value = item.suc_dir;
                    document.getElementById("telefono").value = item.suc_tel;
                    document.getElementById("email").value = item.suc_cor;
                    document.getElementById("colaboradores").value = item.id_enc;
                    $("#colaboradores").val(item.id_enc);

                });
              
            }
        });
        
       
    }





    function listadocolaboradores() {
      


        $("#colaboradores").empty();
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

                    d += '<option value="' + item.col_id + '">' + item.col_1no + " " + item.col_1ap + '</option>';

                });
                $("#colaboradores").append(d);
            }

        });
       

    }

</script>



<script>


    $('#menu').load('../barra.aspx');

    </script>
