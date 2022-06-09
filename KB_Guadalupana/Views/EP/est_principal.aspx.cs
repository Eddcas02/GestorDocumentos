using KB_Guadalupana.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KB_Guadalupana.Views.EP
{
    public partial class est_principal : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            bool listo;
            listo = lte.validaretapa(cifglobal, lote);
            if (listo == true)
            {
                string cambioetapa = "UPDATE EP_Colaborador SET ColaboradorEstado = 1 WHERE  ColaboradorID = '" + cifglobal + "' AND LoteID = '" + lote + "'  ";
                mest.executesql(cambioetapa);
                String script = "alert('Completo Correctamente'); window.location.href= 'est_elegirlote.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);


            }
            else
            {
                string cadenatot = lte.cadenacampos(cifglobal, lote);

                String script = "alert(\"Aún Falta completar los siguientes campos: " + cadenatot + "\"); ";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
        }

        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"] );
            lote = Convert.ToString(Session["lotepasa"]);
            estadoep = Convert.ToString(Session["estadoepp"]);

            string EPParametroDescripcion = mest.textomensaje();
            LinkButton1.Attributes.Add("onclick", "return confirm('" + EPParametroDescripcion + "');");
            if (estadoep == "0")
            {
                finaltodo.Visible = false;
                
            }
            cifglobal = mest.idusuariogeneral(usernombre);
            string area = mest.obtenerarea(cifglobal);
            string puesto = mest.obtenerpuesto(cifglobal);
         
                mantenimientosop.Visible = false;
          
                BASIGLOTE.Visible = false;
                reportes.Visible = false;
                BMANTENIMIENTOS.Visible = false;
                A1.Visible = false;
            
        }
        protected void isrepo_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://10.60.81.49/Reportes/aestadopatrimonial.aspx?" + lote + "," + cifglobal + "");
        }


        protected void btnrecargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("est_principal.aspx");
        }
    }
}