    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="est_pp.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_pp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />

    <title>Información General</title>
</head>
<body>
    <form id="form1" runat="server">
           <div class="container main">


        <div class="row">
            <div class="row">
                <div class="col-12 text-center ">
                    <h2>Información General</h2>
                </div>
            </div>
        </div>

        <br />

        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Primer Nombre.</label>
                        <input class="form-control" id="nom1" type="text" placeholder="Primer Nombre..."/>

                    </div>
                    <div class="col-lg-2">
                        <label>Segundo Nombre.</label>
                        <input class="form-control" id="nom2" type="text" placeholder="Segundo Nombre..."/>


                    </div>
                    <div class="col-lg-2">
                        <label>Tercer nombre.</label>
                        <input class="form-control" id="nom3" type="text" placeholder="Tercer Nombre..."/>
                    </div>

                    <div class="col-lg-2">
                        <label>Primer Apellido</label>
                        <input class="form-control" id="ap1" type="text" placeholder="Primer Apellido..."/>

                    </div>
                    <div class="col-lg-2">
                        <label>Segundo Apellido.</label>
                        <input class="form-control" id="ap2" type="text" placeholder="Segundo Apellido..."/>
                    </div>
                    <div class="col-lg-2">
                        <label>Apellido de Casada.</label>
                        <input class="form-control" id="ap3" type="text" placeholder="Apellido de Casada..."/>
                    </div>

                    <div class="col-lg-6">
                        <div class="row">
                            <div class="col-md-6">
                                 <label>Fec. Nac.</label>
                        <input type="date" id="fecnac" name="trip-start" class="form-control"
                               value="2018-07-22"
                               min="1995-01-01" max="2030-12-31"/>

                            </div>
                       

                            <div class="col-md-6">
                        <label>Peso (Libras).</label>
                        <input class="form-control" id="peso" type="text" placeholder="Peso..."/>
                    </div>
                            </div>
                    </div>

                    
                    <div class="col-lg-2">
                        <label>Altura (Metro).</label>
                        <input class="form-control" id="altura" type="text" placeholder="Altura..."/>
                    </div>
                    <div class="col-lg-2">
                        <label>Religión.</label>
                        <select id="reli" class="form-control" onfocus="inf_rel();">
                        </select>

                    </div>
                    <div class="col-lg-2">
                        <label>Teléfono Casa.</label>
                        <input class="form-control" id="tcasa" type="text" placeholder="Teléfono Casa..."/>
                    </div>
                    <div class="col-lg-2">
                        <label>Teléfono Personal.</label>
                        <input class="form-control" id="tel" type="text" placeholder="Teléfono..."/>
                    </div>



                </div>
            </div>
        </div>


               </div>

    </form>
</body>
</html>
