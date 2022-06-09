
$(document).ready(function () {
    var steps = $("#stepsbar li"), i = 0;
    var j = 0;

    var datosp = 1;
    var datost = 2;
    var datosf = 3;
    var datose = 4;
    var BCAJA = 5;
    var BCUENTASPC = 6;
    var BINVENTARIOS = 7;
    var BINMUEBLES = 8;
    var BMENAJE = 9;
    var BCUENTASPP = 10;
    var BTARJETAS = 11;
    var BPASIVOCONTINGENTE = 12;
    var BINGRESOS = 13;
    var BREMESAS = 14;
    var BEGRESOS = 15;


    $('#data').hide();


    //infogeneral

    $("#datosp").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();

        $("#INFOGENERAL").show();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#menaje").hide();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();
        $("#divtelefonos").hide();
        if (datosp < steps.length) {
            var elmnt = document.getElementById("l1");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < datosp; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }

    });

    $("#datost").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").show();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#menaje").hide();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (datost < steps.length) {
            var elmnt = document.getElementById("l2");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < datost; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });
    //familiares
    $("#datosf").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();

        $("#INFOGENERAL").hide();
        $("#family").show();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#menaje").hide();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();
        $("#divtelefonos").hide();


        if (datosf < steps.length) {
            var elmnt = document.getElementById("l3");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < datosf; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });

    //estudios
    $("#datose").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").show();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#menaje").hide();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (datose < steps.length) {
            var elmnt = document.getElementById("l4");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < datose; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });
    //caja
    $("#BCAJA").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").show();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#menaje").hide();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BCAJA < steps.length) {
            var elmnt = document.getElementById("l5");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BCAJA; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });
    //cuentasxc
    $("#BCUENTASPC").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").show();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#menaje").hide();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BCUENTASPC < steps.length) {
            var elmnt = document.getElementById("l6");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BCUENTASPC; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });
    //inventarios
    $("#BINVENTARIOS").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").show();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BINVENTARIOS < steps.length) {
            var elmnt = document.getElementById("l7");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BINVENTARIOS; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });
    //equipo
    $("#BINMUEBLES").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").show();
        $("#menaje").hide();
        $("#cuentaspp").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BINMUEBLES < steps.length) {
            var elmnt = document.getElementById("l8");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BINMUEBLES; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });
    //menaje
    $("#BMENAJE").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#cuentaspp").hide();
        $("#menaje").show();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BMENAJE < steps.length) {
            var elmnt = document.getElementById("l9");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BMENAJE; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }

    });
    //cuentaspp


    $("#BCUENTASPP").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#cuentaspp").show();
        $("#menaje").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BCUENTASPP < steps.length) {
            var elmnt = document.getElementById("l10");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BCUENTASPP; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });

    //tarjetas


    $("#BTARJETAS").click(function (event) {
        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#cuentaspp").hide();
        $("#menaje").hide();
        $("#tarjetasdiv").show();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BTARJETAS < steps.length) {
            var elmnt = document.getElementById("l11");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BTARJETAS; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });

    $("#BPASIVOCONTINGENTE").click(function (event) {

        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#cuentaspp").hide();
        $("#menaje").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").show();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").hide();

        if (BPASIVOCONTINGENTE < steps.length) {
            var elmnt = document.getElementById("l12");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BPASIVOCONTINGENTE; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }
    });
    $("#BINGRESOS").click(function (event) {

        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#cuentaspp").hide();
        $("#menaje").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").show();
        $("#ingresosrela").hide();
        $("#divegresos").hide();


        if (BREMESAS < steps.length) {
            var elmnt = document.getElementById("l14");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BREMESAS; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }



    });
    $("#BREMESAS").click(function (event) {

        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#cuentaspp").hide();
        $("#menaje").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").show();
        $("#divegresos").hide();
        if (BINGRESOS < steps.length) {
            var elmnt = document.getElementById("l13");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BINGRESOS; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }


    });
    $("#BEGRESOS").click(function (event) {

        $('#data').show();
        $('#encabezado').hide();
        $('#subencabezado').hide();
        $("#divtelefonos").hide();
        $("#INFOGENERAL").hide();
        $("#family").hide();
        $("#estudios").hide();
        $("#cajab").hide();
        $("#cxc").hide();
        $("#inventarios").hide();
        $("#mobiliario").hide();
        $("#cuentaspp").hide();
        $("#menaje").hide();
        $("#tarjetasdiv").hide();
        $("#contingentediv").hide();
        $("#ingresosdiv").hide();
        $("#ingresosrela").hide();
        $("#divegresos").show();

        if (BEGRESOS < steps.length) {
            var elmnt = document.getElementById("l15");
            elmnt.scrollIntoView();

            for (i = 0; i < steps.length; i++) {

                steps.eq(i).removeClass();

            }


            console.log("Infogeeral - " + i);
            for (j = 0; j < BEGRESOS; j++) {
                steps.eq(j).removeClass().addClass('done').next().removeClass().addClass('active');

            }
        }

    });
});
