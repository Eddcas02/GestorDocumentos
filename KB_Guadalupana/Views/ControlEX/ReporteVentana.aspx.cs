using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using KB_Guadalupana.Controllers;
using KB_Guadalupana.Models;
using System.Data;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Reporting.WebForms;

namespace KB_Guadalupana.Views.ControlEX
{
    public partial class ReporteVentana : System.Web.UI.Page
    {
        ModeloEX mex = new ModeloEX();
        ControladorEX exc = new ControladorEX();
        string fechamin, horamin, fechahora, token, usernombre, nombrepersona, coduser;
        char delimitador2 = ' ';
        string cif;
        string rol;
        string area;
        string fechaactual;
        protected void btnrepo2_Click(object sender, EventArgs e)
        {
            string aer = mex.obtenerrol(usernombre);
            if (date1.Value == "" || date2.Value == "")
            {

                String script = "alert('Seleccione un rango de fechas '); window.location.href= 'ReporteVentana.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else
            {
                switch (aer)
                {

                    case "5":

                        if (token == "1025")
                        {
                            crearreporte("statustodos", "Views/ControlEX/hallazgosnegocios.rdlc", reporte3());
                            ReportViewer1.Visible = true;

                        }
                        break;
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            nombrepersona = Convert.ToString(Session["Nombre"]);
            token = Convert.ToString(Session["tok"]);
            coduser = exc.obtenercoduser(usernombre);

            string aerr = mex.obtenerrol(usernombre);

            switch (aerr)
            {

                case "8":
                    btnrepo.Visible = true;
                    break;
                case "6":
                    btnrepo.Visible = true;
                    break;
                case "5":
                    dateencab.Visible = true;
                    btnrepo2.Visible = true;
                    btnrepo.Visible = true;
                    break;
                case "10":
                    dateencab.Visible = true;
                    btnrepo2.Visible = true;
                    break;


            }
        }

        private DataTable reporte()
        {
            DataTable dt3 = new DataTable();


            string ae = mex.obtenerarea(usernombre);
            dt3 = mex.llenarexphall2(ae);





            return dt3;




        }
        private DataTable reporte2()
        {
            DataTable dt3 = new DataTable();


            string ae = mex.obtenerarea(usernombre);
            dt3 = mex.llenarexphall3();





            return dt3;




        }

        private DataTable reporte3()
        {
            DataTable dt3 = new DataTable();

            string fecha1, fecha2;
            fecha1 = date1.Value;
            fecha2 = date2.Value;
            string ae = mex.obtenerarea(usernombre);
            dt3 = mex.estatusall(fecha1, fecha2);





            return dt3;




        }
        public void crearreporte(string font, string path, DataTable dty)
        {

            ReportViewer1.Reset();
            ReportDataSource fuente = new ReportDataSource(font, dty);


            ReportViewer1.LocalReport.DataSources.Add(fuente);


            ReportViewer1.LocalReport.ReportPath = path;

            ReportViewer1.LocalReport.Refresh();

        }
        protected void btnrepo_Click(object sender, EventArgs e)
        {

            string aer = mex.obtenerrol(usernombre);

            switch (aer)
            {
                case "6":
                    crearreporte("hallazgos", "Views/ControlEX/reportehall.rdlc", reporte());
                    ReportViewer1.Visible = true;
                    break;
                case "8":
                    crearreporte("HallazgosMesa", "Views/ControlEX/Verhallazgo2.rdlc", reporte2());
                    ReportViewer1.Visible = true;
                    break;
                case "5":

                    crearreporte("HallazgosMesa", "Views/ControlEX/Verhallazgo2.rdlc", reporte2());
                    ReportViewer1.Visible = true;


                    break;
            }

        }
    }
}