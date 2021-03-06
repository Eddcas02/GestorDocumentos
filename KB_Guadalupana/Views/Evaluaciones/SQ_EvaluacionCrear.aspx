<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SQ_EvaluacionCrear.aspx.cs" Inherits="KB_Guadalupana.Views.Evaluaciones.SQ_EvaluacionCrear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">


    <link rel="stylesheet" href="../../AvDiseños/Botones.css"   />
    <title>Crear Evaluación</title>
</head>
<body>
    <form id="form1" runat="server">
              <div class="container justify-content-center aling-items-center minh-100" style="max-width: 850px;">

         


            <div class="form-group" style="text-align: center">
           
                <label for="exampleInputEmail1">
                    <h1>Configuración de la evaluación</h1>
                </label>
                 <h5>Comentario</h5>
                  <textarea id="Textarea1" runat="server" class="form-control form-control-lg" placeholder="Pregunta" rows="4" maxlength="250" required></textarea>
            </div>
          
  
            <div class="form-group">
            
                <div class="row">
                    <div class="col-sm-4">
                        
                              <label for="exampleInputPassword1">
                    <h1>Fecha de inicio</h1>
                </label>

                <input id="fechainicial" runat="server" type="datetime-local"   class="form-control"   style="text-align: center;" />
                                   <label for="exampleInputPassword1">
                    <h1>Fecha final</h1>
                </label>

                <input id="fechafinal" runat="server" type="datetime-local"   class="form-control"   style="text-align: center;" />
                          <h5>Estado</h5>
                         <asp:DropDownList  id="dropestado" runat="server"   CssClass="form-control" AutoPostBack="true"    ></asp:DropDownList>
                    
                       
                     
                        </div>
                        <div class="col-sm-2" style="margin-top:11%">
                        
          
            <div class="container">
                
              <asp:Button ID="btninsert" runat="server" Cssclass="custom-btn btn-8"  Text="Crear" />
                
            


            </div>
   
                        
                    </div>
                </div>
            </div>
      
           

          




        </div>
    </form>
</body>
</html>
