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
    public partial class est_lotesadm : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre;
        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
        
            if (!IsPostBack) {
              
                mest.llenartabla(lote, mest.llenarloteinfo(usernombre));
            }
        }

        protected void lote_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            lote.PageIndex = e.NewPageIndex;
            mest.llenartabla(lote, mest.llenarloteinfo(usernombre));
        }

     
        protected void Crear_Nuevo_Click(object sender, EventArgs e)
        {

        }

        protected void AgregarColaboradorLote_Click(object sender, EventArgs e)
        {

        }

        protected void Refresh(object sender, EventArgs e)
        {
            mest.llenartabla(lote, mest.llenarloteinfo(usernombre));
        }

        protected void lote_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lotesel = (lote.SelectedRow.FindControl("LoteID") as Label).Text;
            Session["lotepasaadm"] = lotesel;
            Response.Redirect("ventanaUsuarios.aspx");
        }

    
    }
}