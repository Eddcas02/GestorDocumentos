<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuCategorias2.aspx.cs" Inherits="KB_Guadalupana.Views.Procesos.MenuCategorias2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
<link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Nunito:wght@400;600&display=swap" rel="stylesheet"/>
    <title>Categorias</title>
 <style> 
             @import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;400&display=swap');
        html{
            width:100%;
            height:100%;
        }

        form{
            height: 105%;
        }

        body{
            font-family:'Montserrat';
            height:100%;
        }

        .menuCategorias{
            height:87.5%;
             font-family:'Montserrat';
             
        }
     /*MENU*/
    *{
    box-sizing:border-box;
    margin:0;
    padding:0;
    }
                  
    li{
    list-style-type:none;
    position:relative;
    width:120px;
    }

       
    li .button{
    text-decoration:none;
    display:inline-block;
    padding:5px 10px;
    width:170px;
    height:100%;
    border: 0.5px solid white;
    color:#fff;
    background-color:#213C69;
    white-space: normal;
word-wrap: break-word;
justify-content:flex-start;
 font-family:'Montserrat';
    }
            
    li .button:hover{
    color:#fff;
    background-color:#313C4F;
                
    }

    li .button2{
    text-decoration:none;
    display:inline-block;
    padding:5px 10px;
    width:200px;
    height:38px;
   border: 0.5px solid white;
    color:#fff;
    background-color:#32599C;
    white-space: normal;
    word-wrap: break-word;
    justify-content:flex-start;
     font-family:'Montserrat';
    }
            
    li .button2:hover{
    color:#fff;
    background-color:#313C4F; 
    }

     li .button3{
    text-decoration:none;
    display:inline-block;
    padding:5px 10px;
    width:150px;
    height:38px;
   border: 0.5px solid white;
    color:#fff;
    background-color:#32599C;
    white-space: normal;
    word-wrap: break-word;
    justify-content:flex-start;
     font-family:'Montserrat';
    }
            
    li .button3:hover{
    color:#fff;
    background-color:#313C4F;
                
    }
            
    .more{
        display:inline-block;
        position:absolute;
        right:0px;
        font-size:30px;
    }   
    
    nav li ul{
        display:none;
        position:absolute;
        top:0px;
        left:170px;
    } 
    nav li ul li ul li{
        display:none;
        position:absolute;
        top:0px;
         left:30px;
    }      
    nav li:hover ul{display:block;}
    nav li:hover ul li:hover ul li{display:block;}

    .linea{
        background-color:#69A43C;
        width:20px;
        height:100%;
    }

    nav{
        height:11.11%;
    }

    .dicat {
        height:100%;
    }

    .menuCategorias{
        border-left:30px #313C4F solid;
         
            background-repeat:  no-repeat;
  background-size: 30%;
    }
            
    </style>

</head>
<body style="background-size:cover">
      <div id="menu" runat="server" class="menu"></div>
    <form id="form1" runat="server">
         <p id="color" runat="server" hidden="hidden"></p>
        <div class="menuCategorias">
            <asp:Repeater ID="RepeaterCategoria" runat="server" OnItemDataBound="RepeaterCategoria_ItemDataBound">
            <ItemTemplate>
            <nav>
                <ul class="dicat">
                    <li class="submenu dicat"><asp:Button id="BotonCategoria" runat="server" OnClientClick="return false;" CssClass="button" Text='<%# Eval("Categoria") %>'></asp:Button>
                        <ul>
                            <asp:Repeater ID="RepeaterSubcategoria" runat="server" OnItemDataBound="RepeaterSubcategoria_ItemDataBound">
                            <ItemTemplate>
                        <li>
                             <asp:Button id="IdCategoria2" Visible="false" CssClass="button3" runat="server" Text='<%# Eval("IdCategoria") %>'></asp:Button>
                             <asp:Button id="IdSubcategoria2" Visible="false" CssClass="button3" runat="server" Text='<%# Eval("IdSubcategoria") %>'></asp:Button>
                             <asp:Button id="IdDocumento2" Visible="false" CssClass="button3" runat="server" Text='<%# Eval("IdDocumento") %>'></asp:Button>
                            <asp:Button id="BotonSubcategoria" runat="server" CssClass="button2" onmouseover="categoria_hover" OnClick="documentoSub_Click" Text='<%# Eval("Subcategoria") %>'></asp:Button>
                              <ul>
                                <li>
                                    <asp:Repeater ID="RepeaterDocumento" runat="server">
                                    <ItemTemplate>
                                    <%--<button id="Documento" runat="server" onclick="redirigir2()"><%# Eval("Nombre") %></button>--%>
                                    <asp:Button id="IdCategoria" Visible="false" CssClass="button3" runat="server" Text='<%# Eval("IdCategoria") %>'></asp:Button>
                                    <asp:Button id="IdSubcategoria" Visible="false" CssClass="button3" runat="server" Text='<%# Eval("IdSubcategoria") %>'></asp:Button>
                                    <asp:Button id="IdDocumento" Visible="false" CssClass="button3" runat="server" Text='<%# Eval("IdDocumento") %>'></asp:Button>
                                    <asp:Button id="Documento" CssClass="button3" runat="server" OnClick="documento2_Click" Text='<%# Eval("Nombre") %>'></asp:Button>
                                    </ItemTemplate>
                                    </asp:Repeater>
                                </li>
                              </ul>
                        </li>
                           </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                    </li>
                </ul>
            </nav>
         </ItemTemplate>
         </asp:Repeater>
        </div>

        <asp:LinkButton ID="categoria" runat="server" OnClick="categoria_Click" ClientIDMode="Static"></asp:LinkButton>
         <asp:LinkButton ID="Documento" runat="server" OnClick="documento_Click" ClientIDMode="Static"></asp:LinkButton>


        <script>
            $(document).ready(function () {
                $('.menu').load('MenuPrincipal.aspx');
            });
         </script>
        <script type="text/javascript">
            function redirigir() {

                document.getElementById('categoria').click();
            }
            function redirigir2() {

                document.getElementById('Documento').click();
            }
        </script>
    </form>
</body>
</html>
