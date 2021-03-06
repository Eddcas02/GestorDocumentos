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
    public partial class PendienteRequerimientoPago : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            llenargridviewcreditos();
            llenargridviewcredito();
            llenargridviewapremio();
            llenargridviewnotificacion();
            llenargridviewnotificacionhonorarios();
            llenargridviewdesistimiento();
            llenargridviewnotificacionapremio();

            if (gridViewDemanda.Rows.Count == 0)
            {
                RequerimientoPago.Visible = false;
            }

            if (gridViewCreditos.Rows.Count == 0)
            {
                devueltos.Visible = false;
            }

            if (gridViewApremio.Rows.Count == 0)
            {
                Apremio.Visible = false;
            }

            if (gridViewNotificacion.Rows.Count == 0)
            {
                Notificacion.Visible = false;
            }

            if (gridViewHonorarios.Rows.Count == 0)
            {
                Honorarios.Visible = false;
            }

            if (gridViewDesistimiento.Rows.Count == 0)
            {
                Desistimiento.Visible = false;
            }

            if (gridViewNotificacionApremio.Rows.Count == 0)
            {
                NotificacionApremio.Visible = false;
            }
        }

        public void llenargridviewcreditos()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN (5,7,11,13,16,18) AND pj_status IN ('Enviado','Reingreso', 'Cargar Voucher') ";
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
            string etapa = Convert.ToString((gridViewDemanda.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = etapa;
            string nombreetapa = Convert.ToString((gridViewDemanda.SelectedRow.FindControl("lblestado") as Label).Text);
            Session["NombreEtapa"] = nombreetapa;

            Response.Redirect("RequerimientoPago.aspx");
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

        public void llenargridviewcredito()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.idpj_etapa AS etapa, A.idpj_credito AS Credito, A.pj_numincidente AS Incidente, A.pj_nombrecliente AS Nombre, A.pj_status AS Estado, B.gen_areanombre AS DeArea, C.pj_comentario AS Comentario, A.pj_fecha AS Fecha, DATEDIFF(now(), A.pj_fecha) AS Dias FROM pj_etapa_credito AS A INNER JOIN pj_area AS B ON A.gen_area = B.codgenarea INNER JOIN pj_bitacora AS C ON(C.pj_numcredito = A.idpj_credito AND C.pj_estado = A.pj_status AND A.gen_area = C.pj_deArea) WHERE A.pj_status = 'Devuelto' AND C.pj_paraArea = 34 AND A.idpj_etapa IN (6,26,12,17,22)";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);

                    gridViewCreditos.DataSource = dt;
                    gridViewCreditos.DataBind();
                }
                catch
                {

                }
            }
        }

        protected void OnSelectedIndexChangedCreditos(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewCreditos.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string area = Convert.ToString((gridViewCreditos.SelectedRow.FindControl("lbldeArea") as Label).Text);
            Session["area"] = area;
            string estado = Convert.ToString((gridViewCreditos.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            string nombreetapa = Convert.ToString((gridViewCreditos.SelectedRow.FindControl("lblestado") as Label).Text);
            Session["NombreEtapa"] = nombreetapa;
            Response.Redirect("DevueltosSolicitudCheque.aspx");
        }

        public void llenargridviewapremio()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN (27,29) AND pj_status IN ('Enviado','Reingreso', 'Cargar Voucher') ";
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
            string nombreetapa = Convert.ToString((gridViewApremio.SelectedRow.FindControl("lblestado") as Label).Text);
            Session["NombreEtapa"] = nombreetapa;
            Response.Redirect("RequerimientoPagoApremio.aspx");
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

        public void   llenargridviewnotificacion()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN (21,23) AND pj_status IN ('Enviado','Reingreso', 'Cargar Voucher') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewNotificacion.DataSource = dt;
                    gridViewNotificacion.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedNotificacion(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewNotificacion.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewNotificacion.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            string nombreetapa = Convert.ToString((gridViewNotificacion.SelectedRow.FindControl("lblestado") as Label).Text);
            Session["NombreEtapa"] = nombreetapa;
            Response.Redirect("RequerimientoPagoNotificacion.aspx");
        }

        protected void gridViewNotificacion_RowDataBound(object sender, GridViewRowEventArgs e)
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

        public void llenargridviewnotificacionhonorarios()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN (37,39) AND pj_status IN ('Enviado','Reingreso', 'Cargar Voucher') ";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewHonorarios.DataSource = dt;
                    gridViewHonorarios.DataBind();
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
            string nombreetapa = Convert.ToString((gridViewHonorarios.SelectedRow.FindControl("lblestado") as Label).Text);
            Session["NombreEtapa"] = nombreetapa;
            Response.Redirect("RequerimientoPagoHonorarios.aspx");
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
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN (34,36) AND pj_status IN ('Enviado','Reingreso', 'Cargar Voucher') ";
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
            string nombreetapa = Convert.ToString((gridViewDesistimiento.SelectedRow.FindControl("lblestado") as Label).Text);
            Session["NombreEtapa"] = nombreetapa;
            Response.Redirect("RequerimientoPagoDesistimiento.aspx");
        }

        protected void gridViewDesistimiento_RowDataBound(object sender, GridViewRowEventArgs e)
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
                    string query = "SELECT idpj_etapa AS etapa, idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha, DATEDIFF(now(), pj_fecha) AS Dias FROM pj_etapa_credito WHERE idpj_etapa IN (40,42) AND pj_status IN ('Enviado','Reingreso', 'Cargar Voucher') ";
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
            string nombreetapa = Convert.ToString((gridViewNotificacionApremio.SelectedRow.FindControl("lblestado") as Label).Text);
            Session["NombreEtapa"] = nombreetapa;
            Response.Redirect("RequerimientoPagoNotificacionApremio.aspx");
        }

        protected void gridViewNotificacionApremio_RowDataBound(object sender, GridViewRowEventArgs e)
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
    }
}