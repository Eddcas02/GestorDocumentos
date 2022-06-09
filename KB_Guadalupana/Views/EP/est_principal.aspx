<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_principal.aspx.cs" MaintainScrollPositionOnPostback="true" Inherits="KB_Guadalupana.Views.EP.est_principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

         <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css'>
<link rel="stylesheet" href="../../SQEstilos/EstilosMenu.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css"/>
         <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <link rel="stylesheet"  href="../../SQEstilos/EstilosDash.css" />
    <link href="Estaticos/estilosbarrita.css" rel="stylesheet" />
    <script src="Estaticos/jsbarrita.js"></script>
    <link rel="stylesheet" href="../../AvDiseños/Botones.css"   />
         <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
                      <script src="https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js" type="text/javascript"></script>
                  <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.jquery.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/chosen/1.8.7/chosen.min.css" rel="stylesheet"/>
    <link href="Estaticos/cssContene.css" rel="stylesheet" />
    <title>Principal</title>
</head>

 
<body>
   <form id="form1" runat="server">

      
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
      

      
   
        <%-- MENU PRINCIPAL --%>
         <nav class="navbar navbar-default no-margin">
      <!-- Brand and toggle get grouped for better mobile display -->
      <div class="navbar-header fixed-brand">
         <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" id="menu-toggle">
<span class="glyphicon glyphicon-th-large" aria-hidden="true"></span>
</button>
         <a class="navbar-brand" style="font-size:15px" ><i class="fa fa-file fa-4"></i> Estado Patrimonial</a>
              <ul class="nav navbar-nav">

            <li class="active">

               <button class="navbar-toggle collapse in" data-toggle="collapse" id="menu-toggle-2"> <span class="glyphicon glyphicon-th-large" aria-hidden="true"></span>
               </button>

            </li>
         </ul> 
      </div>
      <!-- navbar-header-->
      <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1" style="text-align: -webkit-right;">
            <div id="stepsbar-wrap" style="padding-bottom: 50px;">
  <div id="stepsbar" class="stepsbar">

      <ol style="display: -webkit-box">
          <li class="active"><span>Inicio</span></li>

          <li id="l1"><span>Datos Personales</span></li>

          <li id="l2"><span>Teléfonos</span></li>
          <li id="l3"><span>Familares</span></li>
          <li id="l4"><span>Estudios   </span></li>
          <li id="l5"><span>Caja, Cuentas Inversiones  </span></li>
          <li id="l6"><span>Cuentas por Cobrar   </span></li>
          <li id="l7"><span>Inventarios   </span></li>
          <li id="l8"><span>Vehiculos, Inmuebles, Maquinaria y Equipo   </span></li>
          <li id="l9"><span>Menaje, Otros Activos   </span></li>
          <li id="l10"><span>Cuenta por Pagar  </span></li>
          <li id="l11"><span>Tarjetas de Crédito, Prestamos  </span></li>
          <li id="l12"><span>Pasivo Contingente  </span></li>
          <li id="l13"><span>Ingresos En Relación   </span></li>
          <li id="l14"><span>Negócios, Remesas y Otros  </span></li>
          <li id="l15"><span>Egresos Mensuales  </span></li>
      </ol>


  </div>        
</div>
    
      </div>
      <!-- bs-example-navbar-collapse-1 -->
   </nav>

        <%-- OPCIONES DEL MENU --%>
   <div id="wrapper">
       <%-- MENU --%>
      <div id="sidebar-wrapper">
         <ul class="sidebar-nav nav-pills nav-stacked" id="menu">
            <li class="active">
               <a href="est_principal.aspx"><span class="fa-stack fa-lg pull-left"><i class="fa fa-home fa-stack-1x "></i></span> Inicio</a>
              
            </li>
           
                   <%--    INFOGENERAL    --%>
            <li>
               <a id="dash"  href="#" ><span class="fa-stack fa-lg pull-left"><i class="fa fa-user fa-stack-1x "></i></span>Información General</a>
               <ul class="nav-pills nav-stacked" style="list-style-type:none;">
                  <li><a id="datosp" href="#" ><span class="fa-stack fa-lg pull-left" ><i class="fa fa-edit fa-stack-1x "></i></span>Datos Personales</a></li>
                      <li><a id="datost" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-phone fa-stack-1x "></i></span>Teléfono</a></li>
                    <li><a id="datosf" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-users fa-stack-1x "></i></span>Familiares</a></li>
                    <li><a id="datose" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-university fa-stack-1x "></i></span>Estudios</a></li>
        
                     
               </ul>
            </li>


                   <%--    ACTIVO          --%>

            <li>
               <a href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-dollar fa-stack-1x "></i></span>Activo</a>
                 <ul class="nav-pills nav-stacked" style="list-style-type:none;">
                  <li><a id="BCAJA" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-bank fa-stack-1x "></i></span>Caja, Cuentas, Inversiones</a></li>
           
                    <li><a id="BCUENTASPC" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-dollar fa-stack-1x "></i></span>Cuentas por cobrar</a></li> 
                    <li><a id="BINVENTARIOS" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-truck fa-stack-1x "></i></span>Inventarios</a></li> 
               
                    <li><a id="BINMUEBLES" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-home fa-stack-1x "></i></span>Vehiculos, Inmuebles, Maquinaria y Equipo</a></li> 
                  
                    <li><a id="BMENAJE" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-television fa-stack-1x "></i></span>Menaje, Otros Activos</a></li> 
       
               </ul>
            </li>



             <%--    PASIVO          --%>


                    <li>
               <a id="Pasivoop"  href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-book fa-stack-1x "></i></span>Pasivo</a>
                 <ul class="nav-pills nav-stacked" style="list-style-type:none;">
                     <li><a id="BCUENTASPP" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-bank fa-stack-1x "></i></span> Cuentas por pagar</a></li>
  
                  <li><a id="BTARJETAS" href="#"  ><span class="fa-stack fa-lg pull-left"><i class="fa fa-credit-card fa-stack-1x "></i></span>Tarjetas de crédito, Prestamos</a></li>
                     <li><a id="BPASIVOCONTINGENTE" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-dollar fa-stack-1x "></i></span> Pasivo contingente</a></li>
                   
               </ul>
            </li>





                   <%--    INGRESOS        --%>



               <li>
               <a id="ingresosop"  href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-sort-amount-asc fa-stack-1x "></i></span>Ingresos Mensuales</a>
               <ul class="nav-pills nav-stacked" style="list-style-type:none;">
                  
                  <li><a id="BREMESAS" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-dollar fa-stack-1x "></i></span>Ingresos en Relación</a></li>
          <li><a id="BINGRESOS" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-dollar fa-stack-1x "></i></span>Negocios, Remesas y Otros </a></li>
                     

               </ul>
            </li>




                   <%--    EGRESOS          --%>


                <li>
               <a id="permisos"  href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-download fa-stack-1x "></i></span>Egresos</a>
               <ul class="nav-pills nav-stacked" style="list-style-type:none;">
                  <li><a id="BEGRESOS" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-dollar fa-stack-1x "></i></span>Egresos Mensuales</a></li>
            
                   
               </ul>
            </li>




                                <%--    MANTENIMIENTO          --%>




               <li>
               <a id="mantenimientosop" runat="server"  href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-edit fa-stack-1x "></i></span>Mantenimientos</a>
               <ul class="nav-pills nav-stacked" style="list-style-type:none;">
                  <li><a id="BMANTENIMIENTOS" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-pencil fa-stack-1x "></i></span>NOMBRE MANTENIMIENTO</a></li>
                     
               </ul>
            </li>



                <%--    OPCIONES DE ADMINISTRACION          --%>


             
               <li>
               <a id="A1" runat="server"  href="#"><span class="fa-stack fa-lg pull-left"><i class="fa fa-pencil fa-stack-1x "></i></span>Administración</a>
               <ul class="nav-pills nav-stacked" style="list-style-type:none;">
                  <li><a id="BASIGLOTE" runat="server" href="~/Views/EP/est_elegirlote.aspx"><span class="fa-stack fa-lg pull-left"><i class="fa fa-group fa-stack-1x "></i></span>Administración de lotes</a></li>
                      
               </ul>
            </li>


                <li>
               <a id="reportes" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-line-chart fa-stack-1x "></i></span>Reportes</a>
              
            </li>
                <li>
               <a id="finaltodo" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-check fa-stack-1x "></i></span><asp:LinkButton ID="LinkButton1"    CausesValidation="False" OnClick="LinkButton1_Click" Text="Finalizar" runat="server" /></a>
              
            </li>
                  <li>
               <a id="Reporte" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-archive fa-stack-1x "></i></span><asp:LinkButton ID="isrepo"   OnClientClick="return confirm('¿Verificar su Reporte?')" CausesValidation="False" OnClick="isrepo_Click" Text="Reporte" runat="server" /></a>
              
            </li>
                <li>
               <a id="lotes" runat="server" href="#"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-database fa-stack-1x "></i></span><asp:LinkButton ID="LinkButton2"   OnClientClick="return confirm('¿Desea elegir otro lote?')" CausesValidation="False" PostBackUrl="~/Views/EP/est_elegirlote.aspx" Text="Lotes" runat="server" /></a>
              
            </li>
                <li class="btn-danger">
               <a id="salir"  href="../Sesion/MenuBarra.aspx"><span class="fa-stack fa-lg pull-left"><i class="	fa fa-close fa-stack-1x "></i></span>Salir</a>
              
            </li>
         </ul>
      </div>
  <%-- CONTENIDO DE LA PAGINA --%>
      <div id="page-content-wrapper">
         <div class="container-fluid xyz">
            <div class="row">
               <div class="col-lg-12">
                  <h1 id="encabezado" >Estado Patrimonial<a ></a></h1>
               
                  <p id="subencabezado">Bienvenido, comienza llenando <b>Información General</b>, no olvides dar click en todas las petañas.
                  
                  </p>
                      
               </div>
        
                <div id="data" runat="server" class="menu">  
                   <%-- Información General --%>
                <div id="INFOGENERAL" runat="server" >  
               <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_informacionGeneral.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>
                </div>

                    <%-- Familia --%>

                    <div id="family" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_familiares.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>
                     <%-- telefonos --%>

                    <div id="divtelefonos" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel23" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_telefonos.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>


                     <%-- Estudios --%>

                         <div id="estudios" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_estudios.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>
   
                     <%-- Caja --%>

                      <div id="cajab" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_activoscaja.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>
                         <%-- cxpx --%>
                      <div id="cxc" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_cuentaspc.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>
                           <%-- inversiones --%>
                      <div id="inventarios" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_inventarios.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>

                           <%-- Mobiliario --%>
                      <div id="mobiliario" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="est_equipo.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>

                        <%-- Menaje --%>
                      <div id="menaje" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="menaje.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>
                    <%-- cuentaspp --%>
                         <div id="cuentaspp" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="Pasivo/est_cuentaspp.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>

                     <%-- tarjetas --%>
                         <div id="tarjetasdiv" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel10" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="Pasivo/est_tarjetas.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>

                       <%-- contingente --%>
                         <div id="contingentediv" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel101" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="Pasivo/est_contingente.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>



                          <%-- Ingresos --%>
                         <div id="ingresosdiv" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel11" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="Ingresos/est_ingresos.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>  
                    <div id="ingresosrela" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel112" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="Ingresos/est_ingresosrela.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>

                      <div id="divegresos" runat="server">
             
                          <asp:UpdatePanel ID="UpdatePanel12" runat="server" UpdateMode="Conditional">
               <ContentTemplate>
    
                   <div class="atrib1" >
                   <iframe src="Egresos/est_egresos.aspx" class="cont"></iframe>
                   </div>


                   </ContentTemplate>
              
      </asp:UpdatePanel>

            </div>

    
                </div> 
             
    
                </div>



               
                



               
            </div>
         </div>
      </div>
      <!-- /#page-content-wrapper -->

    <asp:LinkButton ID="btnrecargar" runat="server" OnClick="btnrecargar_Click" ClientIDMode="Static"></asp:LinkButton>
                 
  <script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js'></script><script  src="../../SQEstilos/jsmenu.js"></script>
   

    </form>
   
     
    <script>

        function numeros(e) {
            var unicode = e.charCode ? e.charCode : e.keyCode
            if (unicode != 8) {
                if (unicode < 48 || unicode > 57) //if not a number
                { return false } //disable key press    
            }
        }

        function soloLetras(e) {
            key = e.keyCode || e.which;
            tecla = String.fromCharCode(key).toLowerCase();
            letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
            especiales = "8-37-39-46";

            tecla_especial = false
            for (var i in especiales) {
                if (key == especiales[i]) {
                    tecla_especial = true;
                    break;
                }
            }

            if (letras.indexOf(tecla) == -1 && !tecla_especial) {
                return false;
            }
        }

    </script>
      <script type="text/javascript">

          function redirigir()  {

              document.getElementById('btnrecargar').click();

          }
      </script>
   
</body>
</html>
