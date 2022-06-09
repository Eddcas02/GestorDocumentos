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
    public partial class est_elegirlote : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, estadoep, estadofinal;
        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
            //usernombre = Convert.ToString(Session["sesion_usuario"]= "pgecasasola");
            usernombre = Convert.ToString(Session["sesion_usuario"] ="pgaortiz" );

            loteact = lte.lotevalido();
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {

                mest.llenartabla(lote, mest.llenarloteselegir(usernombre));


            }
        }

        protected void lote_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            lote.PageIndex = e.NewPageIndex;
            mest.llenartabla(lote, mest.llenarloteselegir(usernombre));
        }


        protected void lote_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lotesel = (lote.SelectedRow.FindControl("LoteID") as Label).Text;
            string estadolt = mest.estado(lotesel);
            Session["lotepasa"] = lotesel;

            estadofinal = mest.finalizado(cifglobal, lotesel);

            if (estadolt == "True" && estadofinal == "False")
            {

                Session["estadoepp"] = "1";
            }
            else if (estadolt == "True" && estadofinal == "True")
            {
                Session["estadoepp"] = "0";
            }
            else
            {
                Session["estadoepp"] = "0";
            }


            Response.Redirect("est_Principal.aspx");
        }
        //protected void lote_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string lotesel = (lote.SelectedRow.FindControl("LoteID") as Label).Text;
        //    Session["lotepasa"] = lotesel;
        //    string estadolote = mest.estado(lotesel);
        //    if (estadolote == "False")
        //    {
        //        Session["estadoepp"] = "0";
        //    }
        //    else {
        //        Session["estadoepp"] = "1";
        //    }
        //    Response.Redirect("est_Principal.aspx");
        //}


    }
}