using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KB_Guadalupana.Controllers;

namespace KB_Guadalupana.Views.Procesos.Ventanas
{
    public partial class UsuariosMant : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        Sentencia_proceso sn = new Sentencia_proceso();
        encrip en = new encrip();
        protected void Page_Load(object sender, EventArgs e)
        {
      


        }

        protected void btnguardaruser_Click(object sender, EventArgs e)
        {
            if (gen_nombrecomp.Text != "" && gen_pass.Text != "" && gen_usuariocorreo.Text != "" && gen_usuarioest.SelectedIndex != 0 && contra2.Text !="" )
            {
                
                if (gen_pass.Text == contra2.Text  )
                {
                  
                    if (gen_pass.Text.Length >= 8)
                    {
                        lblcontraseña.Visible = false;  


                        lblerror.Visible = false;
                        lblcontraseñacorta.Visible = false;
                        string cadenaresult = en.Encrypt(gen_pass.Text);

                        string ultimo = sn.obtenerultimo("gen_usuario", "codgenusuario");

                        string sqll = "INSERT INTO `gen_usuario`(`codgenusuario`, `gen_usuarionombre`, `gen_usuariocorreo`, `gen_usuarioest`, `gen_pass`, `gen_nombrecomp`) VALUES ('" + ultimo + "','" + gen_usuarionombre.Text + "','" + gen_usuariocorreo.Text + "','" + gen_usuarioest.SelectedValue + "','" + cadenaresult + "','" + gen_nombrecomp.Text + "');";
                        sn.Insertar(sqll);

                        gen_nombrecomp.Text = "";
                        gen_pass.Text = "";
                        gen_usuariocorreo.Text = "";
                        gen_usuarioest.Text = "";
                        gen_usuarionombre.Text = "";
                    }
                    else
                    {
                      
                        lblcontraseñacorta.Visible = true;
                    }
                }
                else {
                    lblcontraseña.Visible = true;

                }

            }
            else {
                lblerror.Visible = true;
               


            }

        }
    }
}