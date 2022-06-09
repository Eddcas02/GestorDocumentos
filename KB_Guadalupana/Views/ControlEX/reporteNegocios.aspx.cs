using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KB_Guadalupana.Controllers;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.Text.RegularExpressions;

namespace KB_Guadalupana.Views.ControlEX
{
    public partial class reporteNegocios : System.Web.UI.Page
    {
        ModeloEX mex = new ModeloEX();
        ServiceReference1.WebService1SoapClient WS = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        private DataTable reporte()
        {
            DataTable dt3 = new DataTable();

            string fecha1 = date1.Value;
            string fecha2 = date2.Value;

            dt3 = mex.ll( fecha1, fecha2 );


            int a = dt3.Rows.Count ;
            cont.Text = Convert.ToString(a);


            return dt3;




        }


        public DataTable decred()
        {
            string n1, n2, n3, n4;

            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();

            string fechafiin = date2.Value;
            string fechainicio = date1.Value;
            dt4 = mex.creditosno(fechainicio,fechafiin);


            int d = dt4.Rows.Count;
            dt3.Columns.Add("cred");
            dt3.Columns.Add("fecha");
            dt3.Columns.Add("est");
            dt3.Columns.Add("AG");

            for (int i = 0; i < dt4.Rows.Count; i++)
            {



                string estado = WS.buscarcreditoexpedientes(dt4.Rows[i]["cred"].ToString());
                char delimitador = '|';
                string[] valoresprocesados = estado.Split(delimitador);

                if (estado.Length != 4)
                {
                    //if (valoresprocesados[2] == "ANULADO") { }

                    DataRow row = dt3.NewRow();

                    row["cred"] = dt4.Rows[i]["cred"].ToString();
                    row["fecha"] = dt4.Rows[i]["fecha"].ToString();
                    row["est"] = valoresprocesados[2];



                    Regex regex = new Regex("");
                    string[] substrings = regex.Split(dt4.Rows[i]["cred"].ToString());

                    n1 = substrings[1];
                    n2 = substrings[2];
                    n3 = substrings[3];
                    n4 = substrings[4];

                    string first = n1 + n2 + n3 + n4;
                    switch (first)
                    {

                        case "0100":
                            row["AG"] = "CENTRAL ZONA 14 Y TELEVENTAS";
                            break;
                        case "0200":
                            row["AG"] = "AG. ZONA 4";
                            break;
                        case "0300":
                            row["AG"] = "AG. FLORIDA";
                            break;
                        case "0400":
                            row["AG"] = "AG. PORTALES";
                            break;
                        case "0500":
                            row["AG"] = "AG. PETAPA";
                            break;
                        case "0600":
                            row["AG"] = "AG. BOCA DEL MONTE";
                            break;
                        case "0700":
                            row["AG"] = "AG. GRAN VIA";
                            break;
                        case "0800":
                            row["AG"] = "AG. SAN LUCAS";
                            break;
                        case "0900":
                            row["AG"] = "AG. SAN NICOLAS";
                            break;
                        case "1000":
                            row["AG"] = "AG. SAN CRISTOBAL";
                            break;
                        case "1100":
                            row["AG"] = "AG. METROCENTRO";
                            break;
                        case "1200":
                            row["AG"] = "STA CATARINA PINULA";
                            break;
                        case "1300":
                            row["AG"] = "MINI AG. METRONORTE";
                            break;
                        case "1400":
                            row["AG"] = "AG. MEGA 6";
                            break;
                        case "1500":
                            row["AG"] = "AG. SAN NICOLAS";
                            break;
                        case "1600":
                            row["AG"] = "AG. PACIFIC VH";
                            break;
                        case "1800":
                            row["AG"] = "KIOSCO MIRAFLORES";
                            break;
                        case "1900":
                            row["AG"] = "AG. MIXCO";
                            break;

                        case "2000":
                            row["AG"] = "AG. ATANASIO TZUL";
                            break;

                        case "2100":
                            row["AG"] = "AG. LOS ALAMOS";
                            break;

                        case "2200":
                            row["AG"] = "AG.C.C. NARANJO MALL";
                            break;
                        case "2300":
                            row["AG"] = "AG. CENTRAL ZONA 14";
                            break;

                        case "2500":
                            row["AG"] = "AG. PROTALES";
                            break;
                        case "2600":
                            row["AG"] = "AG. TERMINAL";
                            break;
                        case "2800":
                            row["AG"] = "CREDITOS";
                            break;

                        default:
                            row["AG"] = "falta";

                            break;

                    }
                    dt3.Rows.Add(row);

                }
            }

            int c = dt3.Rows.Count;

            cont.Text = Convert.ToString(c);
            return dt3;
        }
        public void crearreporte() {

            ReportViewer1.Reset();
            ReportDataSource fuente = new ReportDataSource("SetDRepo", reporte());
     

            ReportViewer1.LocalReport.DataSources.Add(fuente);


            ReportViewer1.LocalReport.ReportPath = "Views/ControlEX/ReporteMensual.rdlc";

            ReportViewer1.LocalReport.Refresh();

        }
        public void crearreporte2()
        {

            ReportViewer1.Reset();
            ReportDataSource fuente = new ReportDataSource("PENAG", decred());


            ReportViewer1.LocalReport.DataSources.Add(fuente);


            ReportViewer1.LocalReport.ReportPath = "Views/ControlEX/reportePendientes.rdlc";

            ReportViewer1.LocalReport.Refresh();

        }

        protected void btnreporte_Click(object sender, EventArgs e)
        {
            if (date1.Value != "" && date2.Value != "")
            {

                crearreporte();
            }
            else {
                String script = "alert('Seleccione un rango de fechas '); window.location.href= 'reporteNegocios.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

            }
        }

        protected void repo2_Click(object sender, EventArgs e)
        {
            if (date1.Value != "" && date2.Value != "")
            {
                crearreporte2();
            }
            else {
                String script = "alert('Seleccione un rango de fechas '); window.location.href= 'reporteNegocios.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
        }
    }
}