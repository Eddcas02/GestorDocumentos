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
    public partial class PendienteFacturacionAbogado : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            llenargridviewcreditos();
            llenargridviewdesistimiento();
            llenargridviewdevueltos();

            if (gridViewCreditos.Rows.Count == 0)
            {
                Creditos.Visible = false;
            }

            if (gridViewDesistimiento.Rows.Count == 0)
            {
                facturaciondesistimiento.Visible = false;
            }

            if (gridViewDevueltos.Rows.Count == 0)
            {
                Devueltos.Visible = false;
            }
        }

        public void llenargridviewcreditos()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.idpj_etapa AS etapa, A.idpj_credito AS Credito, A.pj_nombrecliente AS Nombre, A.pj_status, A.pj_numincidente AS Incidente, A.pj_fecha AS Fecha, DATEDIFF(now(), A.pj_fecha) AS Dias, B.pj_numproceso AS NumProceso FROM pj_etapa_credito AS A LEFT JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.idpj_credito WHERE A.idpj_etapa IN(10,25) AND A.pj_status IN ('Enviado', 'Reingreso') ";
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
            string estado = Convert.ToString((gridViewCreditos.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("FacturacionAbogado.aspx");
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

        public void llenargridviewdesistimiento()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.idpj_etapa AS etapa, A.idpj_credito AS Credito, A.pj_nombrecliente AS Nombre, A.pj_status, A.pj_numincidente AS Incidente, A.pj_fecha AS Fecha, DATEDIFF(now(), A.pj_fecha) AS Dias, B.pj_numproceso AS NumProceso FROM pj_etapa_credito AS A LEFT JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.idpj_credito WHERE A.idpj_etapa IN(33) AND A.pj_status IN ('Enviado', 'Reingreso')";
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
            Response.Redirect("FacturacionDesistimiento.aspx");
        }

        public void llenargridviewdevueltos()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.idpj_etapa AS etapa, A.idpj_credito AS Credito, A.pj_numincidente AS Incidente, A.pj_nombrecliente AS Nombre, A.pj_status AS Estado, B.gen_areanombre AS DeArea, C.pj_comentario AS Comentario, A.pj_fecha AS Fecha, DATEDIFF(now(), A.pj_fecha) AS Dias FROM pj_etapa_credito AS A LEFT JOIN pj_area AS B ON A.gen_area = B.codgenarea INNER JOIN pj_bitacora AS C ON(C.pj_numcredito = A.idpj_credito AND C.pj_estado = A.pj_status AND A.gen_area = C.pj_deArea) WHERE A.pj_status = 'Devuelto' AND C.pj_paraArea IN (51)";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewDevueltos.DataSource = dt;
                    gridViewDevueltos.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void OnSelectedIndexChangedDevueltos(object sender, EventArgs e)
        {
            string numcredito = Convert.ToString((gridViewDevueltos.SelectedRow.FindControl("lblnumcredito") as Label).Text);
            Session["credito"] = numcredito;
            string estado = Convert.ToString((gridViewDevueltos.SelectedRow.FindControl("lbletapa") as Label).Text);
            Session["etapa"] = estado;
            Response.Redirect("DevueltosFactura.aspx");
        }
    }
}