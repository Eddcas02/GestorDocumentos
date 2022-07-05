<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ver.aspx.cs" Inherits="KB_Guadalupana.Views.ProcesosJudiciales.ver" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
            <title>Registro</title>
    <script src="../../estatico/js/jquery-1.11.0.min.js"></script>    
    <link href="../../estatico/css/creaciontest.css" rel="stylesheet" />
    <link href="../../estatico/css/barra.css" rel="stylesheet" />
    <link href="../../estatico/css/creaciontest.css" rel="stylesheet" />
    <link href="../../estatico/css/bootstrap.min.css" rel="stylesheet" />
    <script src="../../estatico/css/bootstrap.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
<link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>

</head>
    <%--<div id="menu" class="menu"></div>--%>
<body>
    <div class="container main">
        <br />
        <h2>Reporte General</h2>
        
        <div class="table-responsive">
            <input class="form-control" id="myInput" type="text" placeholder="Search..">
            <button type="button" class="btn btn-link" id="1" onclick="exportar2()"><img src="../../estatico/imagenes/excel.png" class="img-fluid" style="max-width:40px; " /></button>
            <br>

            <table class="table">
                <thead>
                    <tr>

                        <th scope="col">1 Agencia</th>
                        <th scope="col">2 Instrumento</th>
                        <th scope="col">3 Línea de crédito</th>
                        <th scope="col">4 Destino</th>
                        <th scope="col">5 Garantía</th>
                        <th scope="col">6 Plazo en meses</th>
                        <th scope="col">7 Estado</th>
                        <th scope="col">8 Tasa Q</th>
                        <th scope="col">9 Fecha solicitud</th>
                        <th scope="col">10 Fecha 1er. desembolso</th>
                        <th scope="col">11 Fecha de acta</th>
                        <th scope="col">12 Fecha Último Desembolso</th>
                        <th scope="col">13 Fecha desembolso</th>
                        <th scope="col">14 Fecha Última Cuota</th>
                        <th scope="col">15 Fecha Acta</th>
                        <th scope="col">16 No. Acta</th>
                        <th scope="col">17 No.Crédito</th>
                        
                        <th scope="col">18 DPI</th>
                        <th scope="col">19 Codigo Cliente</th>
                        
                        <th scope="col">20 Nombre Cliente</th>
                        
                        <th scope="col">21 Monto Original</th>
                        <th scope="col">22 Capital Desembolsado</th>
                        <th scope="col">23 Descripción Documento</th>

                        <th scope="col">24 Nombre Oficial 1</th>
                        <th scope="col">25 Nombre Oficial 2</th>
                        <th scope="col">26 Nombre Oficial 3</th>
                        <th scope="col">27 Saldo Actual</th>
                        <th scope="col">28 Saldo capital</th>


                        <th scope="col">29 No. Incidente</th>
                        <th scope="col">30 No. Tarjeta</th>
                        <th scope="col">31 No. Cuenta</th>
                        <th scope="col">32 CIF</th>
                        

                        <!-- segunda etapa Emisión de Certificación Contable -->

                        <th scope="col">33 Primer Nombre</th>
                        <th scope="col">34 Segundo Nombre</th>
                        <th scope="col">35 Otro Nombre</th>
                        <th scope="col">36 Apellido Casada</th>
                        <th scope="col">37 Primer Apellido</th>


                        <th scope="col">38 Segundo Apellido</th>
                        <th scope="col">39 Limite</th>
                        <th scope="col">40 Saldo</th>
                        <th scope="col">41 Gastos cobranza</th>
                        <th scope="col">42 Seguro</th>


                        <th scope="col">43 OtrosGastos</th>
                        <th scope="col">44 Comentario</th>
                        <th scope="col">45 Total</th>
                        
                        <th scope="col">46 Incendio</th>
                        <th scope="col">47 Intereses </th>
                        <th scope="col">48 Mora</th>
                        <th scope="col">49 Fecha Estado Cuenta</th>
                        <th scope="col">50 No. Registro</th>
                        <th scope="col">51 Contador General</th>
                        

                        <th scope="col">52 Observaciones</th>
                        <th scope="col">53 No. Colegiado</th>
                        <th scope="col">54 Tipo proceso</th>
                        <th scope="col">55 Fecha asignación abogado</th>
                        <th scope="col">56 Nombre abogado</th>
                        <th scope="col">57 Observaciones </th>

                        <th scope="col">58 Medidas obligatorias</th>
                        <th scope="col">59 Medidas solicitadas</th>
                        <th scope="col">60 Medidas otorgadas</th>

                        <th scope="col">61 Medidas autorizadas</th>
                        
                        <th scope="col">62 No. proceso</th>
                        <th scope="col">63 Fecha presentación demanda</th>
                        <th scope="col">64 Oficial</th>


                        <th scope="col">65 Notificador</th>
                        <th scope="col">66 No. Juzgado</th>
                        <th scope="col">67 Nombre Juzgado</th>
                        <th scope="col">68 departamento</th>
                        <th scope="col">69 municipio</th>


                        <th scope="col">70 Motivo rechazo</th>
                        <th scope="col">71 fecha notificación</th>



                        <th scope="col">72 número de cheque</th>
                        <th scope="col">73 fecha emisión cheque</th>


                        <th scope="col">74 Observaciones</th>
                        <th scope="col">75 Monto cheque</th>
                        <th scope="col">76 Nombre del banco</th>

                        <th scope="col">77 fecha oficio migración</th>
                             <!-- sin datos -->   
                        <th scope="col">78 Fecha </th>



                        <th scope="col">79 voluntaria</th>
                             <!-- sin datos -->   
                        <th scope="col">80 Fecha presentación</th>
                        <th scope="col">81 Fecha resolución</th>

                        <th scope="col">82 fecha notificación</th>

                        <th scope="col">83 observaciones</th>
                        <th scope="col">84 fecha</th>
                             <!-- demanda nuevo  -->   


                        <th scope="col">85 Fecha presentación</th>
                        <th scope="col">86 Fecha resolución</th>
                        <th scope="col">87 fecha notificaciòn</th>
                        <th scope="col">88 observaciones</th>
                        <th scope="col">89 fecha</th>
                        <th scope="col">90 hay resultados</th>
                        <th scope="col">91 empresa trabajo</th>
                        <th scope="col">92 fecha presentación</th>
                        <th scope="col">93 fecha sentencia</th>
                        <th scope="col">94 fecha apremio</th>
                        <th scope="col">95 fecha</th>


                        <th scope="col">96 honorarios</th>
                        <th scope="col">97 fecha</th>
                        <th scope="col">98 No. cheque</th>
                        <th scope="col">99 fecha emisión</th>
                        <th scope="col">100 No. recibo</th>
                        <th scope="col">101 Monto</th>
                        <th scope="col">102 Banco</th>
                        <th scope="col">103 Fecha </th>


                        <th scope="col">104 No. factura</th>
                        <th scope="col">105 No. serie</th>
                        <th scope="col">106 descripción</th>
                        <th scope="col">107 importe total</th>
                        <th scope="col">108 fecha emosión factura</th>
                        <th scope="col">109 importe del caso</th>
                        <th scope="col">110 motivo de pago</th>
                        <th scope="col">111 cif</th>
                        <th scope="col">112 nombre asociado</th>
                        <th scope="col">113 nombre emite cheque</th>
                        <th scope="col">114 observaciones</th>
                        
                        
                        <th scope="col">115 fecha notificación</th>
                        <th scope="col">116 actitud demandado</th>
                        <th scope="col">117 fecha </th>
                        <th scope="col">118 fecha sentencia</th>
                        <th scope="col">119 notificación de la sentencia</th>
                        <th scope="col">120 lugar</th>
                        <th scope="col">121 observaciones</th>


                        <th scope="col">122 excepciones</th>
                        <th scope="col">123 fecha resolución excepciones</th>
                        <th scope="col">124 fecha de apertura</th>
                        <th scope="col">125 observaciones</th>
                        <th scope="col">126 fecha de la vista</th>
                        <th scope="col">127 fecha de sentencia</th>
                        <th scope="col">128 notificacion de sentencia</th>
                        <th scope="col">129 lugar</th>
                        <th scope="col">130 observaciones</th>



                        <th scope="col">131 nit</th>
                        <th scope="col">132 placa</th>
                        <th scope="col">133 mdelo</th>
                        <th scope="col">134 marca</th>


                        <th scope="col">135 finca</th>
                        <th scope="col">136 folio</th>
                        <th scope="col">137 libro</th>


                        <th scope="col">138 nombre banco</th>
                        <th scope="col">139 monto</th>
                        <th scope="col">140 nombre cooperativa</th>
                        <th scope="col">141 monto</th>
                        <th scope="col">142 lugar de trabajo</th>
                        <th scope="col">143 fecha presentación oficio a migración</th>
                        <th scope="col">144 fecha</th>
                        <th scope="col">145 fecha presentación a trabajo</th>


                        <th scope="col">146 fecha solicitud edictos</th>
                        <th scope="col">147 monto</th>
                        <th scope="col">148 descripción</th>
                        <th scope="col">149 fecha publicación 1</th>
                        <th scope="col">150 fecha publicación 2</th>
                        <th scope="col">151 fecha publicación 3</th>
                        <th scope="col">152 fecha</th>


                        <th scope="col">153 fecha intento nootificación 1</th>
                        <th scope="col">154 fecha intento nootificación 2</th>
                        <th scope="col">155 fecha intento nootificación 3</th>
                        <th scope="col">156 fecha solicitud de nombramiento de notario </th>
                        <th scope="col">157 nombre notario propuesto</th>
                        <th scope="col">158 No. colegiado de notario propuesto</th>
                        <th scope="col">159 fecha de resolución de nombramiento de notario</th>
                        <th scope="col">160 fecha notificaón de resolución</th>
                        <th scope="col">161 notificacion al asociado</th>
                        <th scope="col">162 fecha</th>


                        <th scope="col">163 fecha presentación de desistimiento</th>
                        <th scope="col">164 fecha resolución del desistimiento</th>
                        <th scope="col">165 fecha</th>

                        <th scope="col">166 monto</th>
                        <th scope="col">167 nombre a quien dirige el cheque</th>
                        <th scope="col">168 fecha</th>
                        
                        
                        <th scope="col">169 total</th>
                        <th scope="col">170 nombre a quien dirige el cheque</th>
                        <th scope="col">171 fecha</th>
                        
                        

                        <th scope="col">172 fecha acta notarial de notificación</th>
                        <th scope="col">173 fecha memorarial de acta notarial de notificación</th>
                        <th scope="col">174 fecha</th>
                        
                        

                        <th scope="col">175 fecha entrega fisica expedientes</th>
                        <th scope="col">176 observaciones</th>

                      
                        <th scope="col">177 fecha acta notaria de notificaciòn </th>
                        <th scope="col">178 fecha memorial acta notarial de notificación</th>
                        <th scope="col">179 fecha resolución acta notarial de notificación</th>
                        <th scope="col">180 fecha de remate</th>
                        <th scope="col">181 observaciones remate </th>
                        <th scope="col">182 adjudicado</th>
                        <th scope="col">183 monto</th>
                        <th scope="col">184 fecha presentación memorial proyecto liquidación</th>
                        <th scope="col">185 fecha resolución memorial proyecto liquidación</th>
                        <th scope="col">186 fecha notificación resolución liquidación</th>
                        <th scope="col">187 fecha presentación de memorail para nombrar notario cartulante</th>
                        <th scope="col">188 nombre del notario </th>
                        <th scope="col">189 No. colegiado notario</th>
                        <th scope="col">190 fecha resolución de memorail para nombrar notario cartulante</th>
                        <th scope="col">191 fecha notificación de resolución para nombrar notario</th>
                        <th scope="col">192 No. escritura</th>
                        <th scope="col">193 fecha de la escritura</th>
                        <th scope="col">194 honorario de registro</th>
                        <th scope="col">195 honorario impuesto</th>
                        <th scope="col">196 fecha</th>
                        <th scope="col">197 etapa actual</th>

                        
                        
                        
                    </tr>
                </thead>
                <tbody id="tbodyx">
                </tbody>
            </table>
        </div>
    </div>


</body>
</html>

<%--<script>
    $(document).ready(function () {
        $('.menu').load('MenuPrincipal.aspx');
    });
</script>--%>

<script>

    window.addEventListener("load", function (event) {
        vistausuarios();
    });

    function vistausuarios() {

        var d = "";

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
            url: '../../reportesaida/reporetegeneraldatatable',
            data: things,
            success: function (response) {
                var data = jQuery.parseJSON(response);
                $.each(data, function (i, item) {

                    d +=
                        '<tr>' +
                        '<th scope="row">' + item.d0 + '</th>' +
                        '<th scope="row">' + item.d1 + '</th>' +
                        '<td>' + item.d2 + '</td>' +
                        '<td>' + item.d3 + '</td>' +
                        '<td>' + item.d4 + '</td>' +
                        '<td>' + item.d5 + '</td>' +
                        '<td>' + item.d6 + '</td>' +
                        '<td>' + item.d7 + '</td>' +
                        '<td>' + item.d8 + '</td>' +
                        '<td>' + item.d9 + '</td>' +
                        '<td>' + item.d10 + '</td>' +
                        '<td>' + item.d11 + '</td>' +
                        '<td>' + item.d12 + '</td>' +
                        '<td>' + item.d13 + '</td>' +
                        '<td>' + item.d14 + '</td>' +
                        '<td>' + item.d15 + '</td>' +
                        '<td>' + item.d16 + '</td>' +
                        '<td>' + item.d17 + '</td>' +
                        '<td>' + item.d18 + '</td>' +
                        '<td>' + item.d19 + '</td>' +
                        '<td>' + item.d20 + '</td>' +
                        '<td>' + item.d21 + '</td>' +
                        '<td>' + item.d22 + '</td>' +
                        '<td>' + item.d23 + '</td>' +
                        '<td>' + item.d24 + '</td>' +
                        '<td>' + item.d25 + '</td>' +
                        '<td>' + item.d26 + '</td>' +
                        '<td>' + item.d27 + '</td>' +
                        '<td>' + item.d28 + '</td>' +
                        '<td>' + item.d29 + '</td>' +
                        '<td>' + item.d30 + '</td>' +
                        '<td>' + item.d31 + '</td>' +
                        '<td>' + item.d32 + '</td>' +
                        '<td>' + item.d33 + '</td>' +
                        '<td>' + item.d34 + '</td>' +
                        '<td>' + item.d35 + '</td>' +
                        '<td>' + item.d36 + '</td>' +
                        '<td>' + item.d37 + '</td>' +
                        '<td>' + item.d38 + '</td>' +
                        '<td>' + item.d39 + '</td>' +
                        '<td>' + item.d40 + '</td>' +
                        '<td>' + item.d41 + '</td>' +
                        '<td>' + item.d42 + '</td>' +
                        '<td>' + item.d43 + '</td>' +
                        '<td>' + item.d44 + '</td>' +
                        '<td>' + item.d45 + '</td>' +
                        '<td>' + item.d46 + '</td>' +
                        '<td>' + item.d47 + '</td>' +
                        '<td>' + item.d48 + '</td>' +
                        '<td>' + item.d49 + '</td>' +
                        '<td>' + item.d50 + '</td>' +
                        '<td>' + item.d51 + '</td>' +
                        '<td>' + item.d52 + '</td>' +
                        '<td>' + item.d53 + '</td>' +
                        '<td>' + item.d54 + '</td>' +
                        '<td>' + item.d55 + '</td>' +
                        '<td>' + item.d56 + '</td>' +
                        '<td>' + item.d57 + '</td>' +
                        '<td>' + item.d58 + '</td>' +
                        '<td>' + item.d59 + '</td>' +
                        '<td>' + item.d60 + '</td>' +
                        '<td>' + item.d61 + '</td>' +
                        '<td>' + item.d62 + '</td>' +
                        '<td>' + item.d63 + '</td>' +
                        '<td>' + item.d64 + '</td>' +
                        '<td>' + item.d65 + '</td>' +
                        '<td>' + item.d66 + '</td>' +
                        '<td>' + item.d67 + '</td>' +
                        '<td>' + item.d68 + '</td>' +
                        '<td>' + item.d69 + '</td>' +

                        '<td>' + item.d70 + '</td>' +
                        '<td>' + item.d71 + '</td>' +
                        '<td>' + item.d72 + '</td>' +
                        '<td>' + item.d73 + '</td>' +
                        '<td>' + item.d74 + '</td>' +
                        '<td>' + item.d75 + '</td>' +
                        '<td>' + item.d76 + '</td>' +
                        '<td>' + item.d77 + '</td>' +
                        '<td>' + item.d78 + '</td>' +
                        '<td>' + item.d79 + '</td>' +

                        '<td>' + item.d80 + '</td>' +
                        '<td>' + item.d81 + '</td>' +
                        '<td>' + item.d82 + '</td>' +
                        '<td>' + item.d83 + '</td>' +
                        '<td>' + item.d84 + '</td>' +
                        '<td>' + item.d85 + '</td>' +
                        '<td>' + item.d86 + '</td>' +
                        '<td>' + item.d87 + '</td>' +
                        '<td>' + item.d88 + '</td>' +
                        '<td>' + item.d89 + '</td>' +

                        '<td>' + item.d90 + '</td>' +
                        '<td>' + item.d91 + '</td>' +
                        '<td>' + item.d92 + '</td>' +
                        '<td>' + item.d93 + '</td>' +
                        '<td>' + item.d94 + '</td>' +
                        '<td>' + item.d95 + '</td>' +
                        '<td>' + item.d96 + '</td>' +
                        '<td>' + item.d97 + '</td>' +
                        '<td>' + item.d98 + '</td>' +
                        '<td>' + item.d99 + '</td>' +


                        '<td>' + item.d100 + '</td>' +
                        '<td>' + item.d101 + '</td>' +
                        '<td>' + item.d102 + '</td>' +
                        '<td>' + item.d103 + '</td>' +
                        '<td>' + item.d104 + '</td>' +
                        '<td>' + item.d105 + '</td>' +
                        '<td>' + item.d106 + '</td>' +
                        '<td>' + item.d107 + '</td>' +
                        '<td>' + item.d108 + '</td>' +
                        '<td>' + item.d109 + '</td>' +

                        '<td>' + item.d110 + '</td>' +
                        '<td>' + item.d111 + '</td>' +
                        '<td>' + item.d112 + '</td>' +
                        '<td>' + item.d113 + '</td>' +
                        '<td>' + item.d114 + '</td>' +
                        '<td>' + item.d115 + '</td>' +
                        '<td>' + item.d116 + '</td>' +
                        '<td>' + item.d117 + '</td>' +
                        '<td>' + item.d118 + '</td>' +
                        '<td>' + item.d119 + '</td>' +

                        '<td>' + item.d120 + '</td>' +
                        '<td>' + item.d121 + '</td>' +
                        '<td>' + item.d122 + '</td>' +
                        '<td>' + item.d123 + '</td>' +
                        '<td>' + item.d124 + '</td>' +
                        '<td>' + item.d125 + '</td>' +
                        '<td>' + item.d126 + '</td>' +
                        '<td>' + item.d127 + '</td>' +
                        '<td>' + item.d128 + '</td>' +
                        '<td>' + item.d129 + '</td>' +

                        '<td>' + item.d130 + '</td>' +
                        '<td>' + item.d131 + '</td>' +
                        '<td>' + item.d132 + '</td>' +
                        '<td>' + item.d133 + '</td>' +
                        '<td>' + item.d134 + '</td>' +
                        '<td>' + item.d135 + '</td>' +

                        '<td>' + item.d136 + '</td>' +
                        '<td>' + item.d137 + '</td>' +
                        '<td>' + item.d138 + '</td>' +
                        '<td>' + item.d139 + '</td>' +
                        '<td>' + item.d140 + '</td>' +
                        '<td>' + item.d141 + '</td>' +
                        '<td>' + item.d142 + '</td>' +
                        '<td>' + item.d143 + '</td>' +
                        '<td>' + item.d144 + '</td>' +
                        '<td>' + item.d145 + '</td>' +
                        '<td>' + item.d146 + '</td>' +
                        '<td>' + item.d147 + '</td>' +
                        '<td>' + item.d148 + '</td>' +
                        '<td>' + item.d149 + '</td>' +
                        '<td>' + item.d150 + '</td>' +
                        '<td>' + item.d151 + '</td>' +
                        '<td>' + item.d152 + '</td>' +
                        '<td>' + item.d153 + '</td>' +
                        '<td>' + item.d154 + '</td>' +
                        '<td>' + item.d155 + '</td>' +
                        '<td>' + item.d156 + '</td>' +
                        '<td>' + item.d157 + '</td>' +
                        '<td>' + item.d158 + '</td>' +
                        '<td>' + item.d159 + '</td>' +
                        '<td>' + item.d160 + '</td>' +
                        '<td>' + item.d161 + '</td>' +
                        '<td>' + item.d162 + '</td>' +
                        '<td>' + item.d163 + '</td>' +
                        '<td>' + item.d164 + '</td>' +
                        '<td>' + item.d165 + '</td>' +
                        '<td>' + item.d166 + '</td>' +
                        '<td>' + item.d167 + '</td>' +
                        '<td>' + item.d168 + '</td>' +

                        '<td>' + item.d169 + '</td>' +
                        '<td>' + item.d170 + '</td>' +
                        '<td>' + item.d171 + '</td>' +
                        '<td>' + item.d172 + '</td>' +
                        '<td>' + item.d173 + '</td>' +
                        '<td>' + item.d174 + '</td>' +
                        '<td>' + item.d175 + '</td>' +


                    '<td>' + item.d176 + '</td>' +
                    '<td>' + item.d177 + '</td>' +
                    '<td>' + item.d178 + '</td>' +
                    '<td>' + item.d179 + '</td>' +
                    '<td>' + item.d180 + '</td>' +
                    '<td>' + item.d181 + '</td>' +
                    '<td>' + item.d182 + '</td>' +
                    '<td>' + item.d183 + '</td>' +
                    '<td>' + item.d184 + '</td>' +
                    '<td>' + item.d185 + '</td>' +
                    '<td>' + item.d186 + '</td>' +
                    '<td>' + item.d187 + '</td>' +
                    '<td>' + item.d188 + '</td>' +
                    '<td>' + item.d189 + '</td>' +
                    '<td>' + item.d190 + '</td>' +
                    '<td>' + item.d191 + '</td>' +
                    '<td>' + item.d192 + '</td>' +
                    '<td>' + item.d193 + '</td>' +
                    '<td>' + item.d194 + '</td>' +
                    '<td>' + item.d195 + '</td>' +
                    '<td>' + item.d196 + '</td>' +





                        '</tr>';

                });
                $("#tbodyx").append(d);
            }
        });
    }




    function exportar2() {

        window.location = '../../reportesaida/Download2';


    }


</script>


<script>
    $(document).ready(function () {
        $("#myInput").on("keyup", function () {
            var value = $(this).val().toLowerCase();
            $("#tbodyx tr").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>


