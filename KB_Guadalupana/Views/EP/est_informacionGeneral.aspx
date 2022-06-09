<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="est_informacionGeneral.aspx.cs" Inherits="KB_Guadalupana.Views.EP.est_informacionGeneral" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Estaticos/cssContene.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" rel="stylesheet" />
         <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="Estaticos/bloqueo.js"></script>
    <script src="Estaticos/validacionletrasnum.js"></script>
    <title>Familiares</title>
</head>
<body>
     <style>

        .switch
        {
            position: relative;
            display: inline-block;
            width: 50px;
            height: 24px;
        }
        
        .switch input
        {
            opacity: 0;
        }
        
        .slider
        {
            position: absolute;
            cursor: pointer;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-color: #ccc;
            -webkit-transition: .4s;
            transition: .4s;
        }
        
        .slider:before
        {
            position: absolute;
            content: "";
            height: 16px;
            width: 16px;
            left: 4px;
            bottom: 4px;
            background-color: white;
            -webkit-transition: .4s;
            transition: .4s;
        }
        
        input:checked + .slider
        {
            background-color: #2196F3;
        }
        
        input:focus + .slider
        {
            box-shadow: 0 0 1px #2196F3;
        }
        
        input:checked + .slider:before
        {
            -webkit-transform: translateX(26px);
            -ms-transform: translateX(26px);
            transform: translateX(26px);
        }
        
        /* Rounded sliders */
        .slider.round
        {
            border-radius: 34px;
        }
        
        .slider.round:before
        {
            border-radius: 50%;
        }

</style>
    <form id="form1" runat="server">
          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:Label ID="blk" Visible="true"  runat="server" />
        <div>
           
            <h1 id="titulop" runat="server">Información General</h1>

        

        </div>

               <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">
                   <div class="col-lg-2">
                        <label>CIF.</label>
                   <asp:TextBox runat="server" Enabled="false" TextMode="Number" ID="txtcif" placeholder="000" CssClass="form-control" required ="true" />
                    </div>
                    <div class="col-lg-3">
                        <label>Fecha Ingreso a Cooperativa.</label>
                   <asp:TextBox runat="server" TextMode="Date" ID="txtfechaingreso" min="2000-01-01" max="2045-02-02"  CssClass="form-control" required ="true"  />
                    </div>
                         <div class="col-lg-3">
                      <label  id="Label4" runat="server" >Gerencia</label>
               <asp:DropDownList  ID="gerenciadrp" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="gerenciadrp_SelectedIndexChanged"  ></asp:DropDownList><br/>
                          </div>
                         <div class="col-lg-2">
                      <label  id="Label5" runat="server" >Departamento/Agencia</label>
               <asp:DropDownList  ID="deptoagedrp" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="deptoagedrp_SelectedIndexChanged"   ></asp:DropDownList><br/>
                          </div>
                         <div class="col-lg-2">
                      <label  id="Label6" runat="server" >Puesto</label>
               <asp:DropDownList  ID="puestodrp" runat="server" AutoPostBack="true" CssClass="form-control"    ></asp:DropDownList><br/>
                          </div>



      </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                    <div class="col-lg-2">
                        <label>Primer Nombre</label>
                       
                        <asp:TextBox runat="server" ID="pnombre" placeholder="Primer Nombre" CssClass="form-control"  required ="true" />
                    </div>
                    <div class="col-lg-2">
                        <label>Segundo Nombre</label>
                      <asp:TextBox runat="server" ID="snombre" placeholder="Segundo Nombre" CssClass="form-control" 
                        
                          />


                    </div>
                    <div class="col-lg-2">
                        <label>Tercer Nombre</label>
                     <asp:TextBox runat="server" ID="tnombre" placeholder="Tercer Nombre" CssClass="form-control"  />
                    </div>

                    <div class="col-lg-2">
                        <label>Primer Apellido</label>
                   <asp:TextBox runat="server" ID="papell" placeholder="Primer Apellido" CssClass="form-control" required ="true"  />

                    </div>
                    <div class="col-lg-2">
                        <label>Segundo Apellido</label>
                 <asp:TextBox runat="server" ID="sapell" placeholder="Segundo Apellido" 
                     CssClass="form-control"  />
                    </div>
                    <div class="col-lg-2">
                        <label>Apellido de Casada</label>
                    <asp:TextBox runat="server" ID="apellcasa" placeholder="Apellido de Casada" CssClass="form-control" />
                    </div>

                    <div class="col-lg-4">
                        <label>Fecha de Nacimiento</label>
                      <asp:TextBox runat="server" ID="fechanacinfo" min="1940-01-01" max="2040-01-01" TextMode="Date" CssClass="form-control" required ="true"  />

                    </div>

                    <div class="col-lg-2">
                        <label>Peso (Libras)</label>
                     <asp:TextBox runat="server" ID="peso" placeholder="Peso" CssClass="form-control" required ="true"  />
                    </div>
            

                    
                    <div class="col-lg-2">
                        <label>Altura (Metro)</label>
                        
                    <asp:TextBox CssClass="form-control" style="color:black" 
                        placeholder="1.65" type="text" name="email" id="altura"
                        onkeyup="format(this)" onchange="format(this);" maxlength="4"
                        oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);"  
                        runat="server" >  </asp:TextBox>
                    
                        
                    </div>
                    <div class="col-lg-2">
                        <label>Religión</label>
                   <asp:TextBox runat="server" ID="txtreligion" placeholder="Religion" CssClass="form-control" required ="true"  />

                    </div>
                  

          
      </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">

                      <div class="col-lg-4">
                        <label>Dirección Domicilio</label>
                       <asp:TextBox runat="server" ID="direxa"  placeholder="ej: 8av 10-64 condominio jasmines" CssClass="form-control" required ="true"  />
                    </div>
                      <div class="col-lg-2">
                      <label  id="encabasignados" runat="server" >Departamento</label>
               <asp:DropDownList AutoPostBack="true"  ID="divisiondrp" runat="server" CssClass="form-control" OnTextChanged="divisiondrp_TextChanged"   ></asp:DropDownList><br/>
                          </div>
                    <div class="col-lg-2">
                      <label  id="Label3" runat="server" >Municipio</label>
               <asp:DropDownList AutoPostBack="true"  ID="subdivdrp" runat="server" CssClass="form-control"   ></asp:DropDownList><br/>
                          </div>
                     <div class="col-lg-2">
                      <label  id="Label1" runat="server" >Zona</label>
                               <asp:TextBox runat="server" ID="zonadivdrp" TextMode="SingleLine" MaxLength="2" placeholder="Zona" CssClass="form-control"  />
                
                     </div>
                 
                     <div class="col-lg-2">
                        <label>Nacionalidad</label>
                         <asp:TextBox runat="server" ID="txtnacionalidad" TextMode="SingleLine" placeholder="Nacionalidad" CssClass="form-control" required ="true"  />
                    </div>
                     <div class="col-lg-4">
                        <label>Correo Personal</label>
                       <asp:TextBox runat="server" TextMode="Email" ID="correop" placeholder="Correo Personal" CssClass="form-control"  required ="true"  />
                    </div>
                      <div class="col-lg-4">
                        <label>Correo Institucional</label>
                     <asp:TextBox runat="server" TextMode="Email" ID="correoi" placeholder="Correo Institucional" CssClass="form-control" required ="true"  />
                    </div>
                        <div class="col-lg-2">
                        <label>Es persona expuesta politicamente</label>
                        <br />
                    <label class="switch">
            <asp:CheckBox ID="chkOnOff" runat="server" Checked="false"  />
            <span class="slider round"></span>
        </label>
                        
                                      </div>
                        <div class="col-lg-2">
                        <label>Contratista o proveedor del estado</label>
                        <br />
                    <label class="switch">
            <asp:CheckBox ID="chkOnOff2" runat="server"  Checked="false" />
            <span class="slider round"></span>
        </label>
                        
                                      </div>
    </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12 ">
                <div class="input-group mb-3">


                  

                    <div class="col-lg-2">
                        <label>Documento</label>
                       <asp:DropDownList AutoPostBack="true" required ="true"  OnTextChanged="tipodocumento_TextChanged"  ID="tipodocumento" runat="server" CssClass="form-control"  ></asp:DropDownList><br/>
                       
                    </div>
                    <div class="col-lg-3">
                        <label>Número de Documento</label>
                     <asp:TextBox CssClass="form-control" 
                        
                           style="color:black" placeholder="0"
                           type="text" name="email" id="txtnodoc" 
                           onkeyup="format(this)" onchange="format(this);" 
                             onkeypress="return numeros(event);" 
                           oninput="if(this.value.length > this.maxLength) this.value = this.value.slice(0, this.maxLength);" required ="true"  runat="server" >  </asp:TextBox>
               
                        </div>
             
                    <div class="col-lg-2">
                        <label>NIT</label>
                     <asp:TextBox runat="server" required ="true"   ID="txtnit" placeholder="NIT" CssClass="form-control" />
                    </div>
                     <div class="col-lg-2">
                      </div>
                        <div class="col-lg-2" style="text-align:center">
                                  <label id="lb" runat="server">Guardar Datos</label>
                                  <br />
                                 
                       <asp:Button ID="Button1"  Font-Names=" 'Rubik', sans-serif" runat="server" Width="100%" Height="40px" CssClass="btn1" Text="Guardar" OnClick="btnGuardarinfogeneral_Click" />
 <asp:Label ID="lblSuccessMessage1" Text="Datos Almacenados" runat="server" Visible="false" ForeColor="Green" />
                    </div>
                           
                    
                </div>
            </div>
        </div>

          




 
      
                  
     



     

       
 
    </form>

</body>
</html>
