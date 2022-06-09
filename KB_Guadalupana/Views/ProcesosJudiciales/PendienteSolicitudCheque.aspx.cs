using System;
using System.Data;
using MySql.Data.MySqlClient;
using KB_Guadalupana.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KB_Guadalupana.Views.ProcesosJudiciales
{
    public partial class PendienteSolicitudCheque : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenargridviewcreditos();
                llenargridviewcreditosapremio();
                llenargridviewnotificacionapremio();
                llenargridviewdesistimiento();
                llenargridviewnotificacioneva();

                if (gridViewDemanda.Rows.Count == 0)
                {
                    solictudcheque.Visible = false;
                }

                if (gridViewApremio.Rows.Count == 0)
                {
                    solicitudapremio.Visible = false;
                }

                if (gridViewNotificacionApremio.Rows.Count == 0)
                {
                    NotificacionApremio.Visible = false;
                }

                if (gridViewHonorarios.Rows.Count == 0)
                {
                    SolicitudHonorarios.Visible = false;
                }

                if (gridViewDesistimiento.Rows.Count == 0)
                {
                    Desistimiento.Visible = false;
                }

                if (gridViewNotificacionEVA.Rows.Count == 0)
                {
                    NotificacionEVA.Visible = false;
                }
            }
        }

        public void llenargridviewcreditos()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN(6,12,17) AND pj_status IN ('Enviado','Reingreso') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewDemanda.DataSource = dt;
                    gridViewDemanda.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedDemanda(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewDemanda.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewDemanda.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("SolicitudCheque.aspx");
        }

        protected void gridViewCertificacion_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //string estado = Convert.ToString((gridViewIncidente.SelectedRow.FindControl("lblestado") as Label).Text);
                string _estado = DataBinder.Eval(e.Row.DataItem, "pj_status").ToString();

                if (_estado == "Reingreso")
                    e.Row.BackColor = System.Drawing.Color.IndianRed;
                else
                    e.Row.BackColor = System.Drawing.Color.White;
            }
        }

        public void llenargridviewcreditosapremio()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN(40) AND pj_status IN ('Enviado','Reingreso') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewApremio.DataSource = dt;
                    gridViewApremio.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedApremio(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewApremio.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewApremio.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("SolicitudChequeApremio.aspx");
        }

        protected void gridViewApremio_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //string estado = Convert.ToString((gridViewIncidente.SelectedRow.FindControl("lblestado") as Label).Text);
                string _estado = DataBinder.Eval(e.Row.DataItem, "pj_status").ToString();

                if (_estado == "Reingreso")
                    e.Row.BackColor = System.Drawing.Color.IndianRed;
                else
                    e.Row.BackColor = System.Drawing.Color.White;
            }
        }

        public void llenargridviewnotificacionapremio()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN(22) AND pj_status IN ('Enviado','Reingreso') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewNotificacionApremio.DataSource = dt;
                    gridViewNotificacionApremio.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedNotificacionApremio(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewNotificacionApremio.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewNotificacionApremio.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("SolicitudChequeNotificacion.aspx");
        }

        public void llenargridviewhonorarios()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN(37) AND pj_status IN ('Enviado','Reingreso') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewNotificacionApremio.DataSource = dt;
                    gridViewNotificacionApremio.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedHonorarios(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewHonorarios.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewHonorarios.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("SolicitudChequeHonorarios.aspx");
        }

        protected void gridViewHonorarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //string estado = Convert.ToString((gridViewIncidente.SelectedRow.FindControl("lblestado") as Label).Text);
                string _estado = DataBinder.Eval(e.Row.DataItem, "pj_status").ToString();

                if (_estado == "Reingreso")
                    e.Row.BackColor = System.Drawing.Color.IndianRed;
                else
                    e.Row.BackColor = System.Drawing.Color.White;
            }
        }

        public void llenargridviewdesistimiento()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN(35) AND pj_status IN ('Enviado','Reingreso') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewDesistimiento.DataSource = dt;
                    gridViewDesistimiento.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedDesistimiento(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewDesistimiento.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewDesistimiento.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("SolicitudChequeDesistimiento.aspx");
        }

        public void llenargridviewnotificacioneva()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN(41) AND pj_status IN ('Enviado','Reingreso') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewNotificacionEVA.DataSource = dt;
                    gridViewNotificacionEVA.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedNotificacionEVA(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewNotificacionEVA.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewNotificacionEVA.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("SolicitudChequeNotificacionApremio.aspx");
        }
    }
}