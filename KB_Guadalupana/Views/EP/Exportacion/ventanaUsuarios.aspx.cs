using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KB_Guadalupana.Controllers;
using System.Data;
using MySql.Data.MySqlClient;

namespace KB_Guadalupana.Views.EP
{
    public partial class ventanaUsuarios : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lotes;

        protected void lote_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            lote.PageIndex = e.NewPageIndex;
            mest.llenartabla(lote, mest.llenaruserlote(lotes));

        }

        protected void AgregarColaboradorLote_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ModalPopupExtender1.Hide();
            mest.llenartabla(lote, mest.llenaruserlote(lotes));
        }

        protected void lblrepo_Click(object sender, EventArgs e)
        {

           
        }

        protected void lote_SelectedIndexChanged(object sender, EventArgs e)
        {

            string cifcolab = (lote.SelectedRow.FindControl("ColaboradorID") as Label).Text;
            Response.Redirect("http://10.60.81.49/Reportes/aestadopatrimonial.aspx?" + lotes + "," + cifcolab + "");

        }

        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
         lotes = Convert.ToString(Session["lotepasaadm"]);
            loteestoy.InnerText = "Lote Número "+lotes+"";
            string estado = mest.estado(lotes);

            if (estado == "False") {
                AgregarColaboradorLote.Visible = false;
            }
            DataTable dt1 = new DataTable();
            int i = 0;
                dt1 = mest.llenaruserlote(lotes);
            asignados.Text = Convert.ToString(mest.llenaruserlote(lotes).Rows.Count);
            foreach (DataRow row in dt1.Rows) {

                if (row["ColaboradorEstado"].ToString() == "False") {
                    i++;
                }

            }
            pendientes.Text = Convert.ToString(i);
            int j = dt1.Rows.Count;
            int f = j - i;
            finalizados.Text = Convert.ToString(f);
            if (!IsPostBack)
            {

                mest.llenartabla(lote, mest.llenaruserlote(lotes));
            }


        }


   

    
    }
}