function bloqueado() {

    var texto = $("#blk").text();

    if (texto == "0") {
        $("#form1 :input").prop("disabled", true);
        $('#form1 :input[type=submit]').attr("hidden", true);
        $('#form1 :input[type=image]').attr("hidden", true);
       
        $('a').hide();
        $('#blk').hide();
    }

}




