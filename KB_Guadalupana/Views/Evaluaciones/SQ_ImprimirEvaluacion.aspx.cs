using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using KB_Guadalupana.Controllers;
using Microsoft.Reporting.WebForms;

namespace KB_Guadalupana.Views.Evaluaciones
{
    public partial class SQ_ImprimirEvaluacion : System.Web.UI.Page
    {
        ModeloSQ msq = new ModeloSQ();
        string ususario;
        protected void Page_Load(object sender, EventArgs e)
        {
            ususario = Convert.ToString(Session["sesion_usuario"] );

            

        }
        //primera
        private DataTable auto15()
        {
            DataTable dt3 = new DataTable();




            string usuario2 = msq.iduser(ususario);

            dt3 = msq.AUTO15(usuario2);






            return dt3;



        }
        private DataTable auto613()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.AUTO613(usuario2);






            return dt3;



        }
        private DataTable auto1420()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.AUTO1420(usuario2);






            return dt3;



        }
        private DataTable jefe15()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.JEFE15(usuario2);






            return dt3;



        }
        private DataTable jefe613()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE613(usuario2);






            return dt3;



        }

        private DataTable jefe15a()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.JEFE15a(usuario2);






            return dt3;



        }
        private DataTable jefe613a()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE613a(usuario2);






            return dt3;



        }

        private DataTable auto6132()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.AUTO6132(usuario2);






            return dt3;



        }

        private DataTable jefe6132()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE6132(usuario2);






            return dt3;



        }
        private DataTable JEFE1420()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE1420(usuario2);






            return dt3;



        }


        private DataTable promedios15()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.PROM15(usuario2);






            return dt3;



        }
        private DataTable promedios613()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.PROM613(usuario2);






            return dt3;



        }
        private DataTable promedios6132()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.PROM6132(usuario2);






            return dt3;



        }
        private DataTable promedios1420()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.PROM1420(usuario2);






            return dt3;



        }
        private DataTable comentarios()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.COMENT(usuario2);






            return dt3;



        }
        private DataTable comentariosa()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.COMENTa(usuario2);






            return dt3;



        }

        private DataTable scomentariosa()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sCOMENTa(usuario2);






            return dt3;



        }
        private DataTable encabezado()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.ENCABEZADO(usuario2);






            return dt3;



        }
        private DataTable preguntassub()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntassub();






            return dt3;



        }

        private DataTable preguntasjefe()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasjefe();






            return dt3;



        }
        private DataTable preguntasjefe17()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasjefe17();






            return dt3;



        }
        private DataTable preguntasescalajefe()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasrangosjefe1();






            return dt3;



        }
        private DataTable preguntasescalasub()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasrangosjefe2();






            return dt3;



        }
        private DataTable SUB15()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sub15(usuario2);






            return dt3;



        }
        private DataTable SUB613()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sub613(usuario2);






            return dt3;



        }
        private DataTable SUB1420()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sub1420(usuario2);






            return dt3;



        }

        private DataTable promediosbueno()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio1");



            dt3 = msq.AUTO15(usuario2);
            dt4 = msq.JEFE15(usuario2);
            dt5 = msq.sub15(usuario2);
            if (dt3.Rows.Count != 0 && dt4.Rows.Count != 0 && dt5.Rows.Count != 0)
            {
                //seccion subalterno
                var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
                var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
                var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
                var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
                var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
                //seccion jefes
                var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
                var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
                var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
                var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
                var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);

                //seccion auto
                var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
                var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
                var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
                var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
                var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);


                row1["promedio1"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

                row2["promedio1"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
                row3["promedio1"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

                row4["promedio1"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

                row5["promedio1"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;

                dt6.Rows.Add(row1);
                dt6.Rows.Add(row2);
                dt6.Rows.Add(row3);
                dt6.Rows.Add(row4);
                dt6.Rows.Add(row5);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Aún faltan datos para generar el reporte.')", true);

            }



            return dt6;

        }
        private DataTable promediosbueno2()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();
            DataRow row8 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio2");



            dt3 = msq.AUTO6132(usuario2);
            dt4 = msq.JEFE6132(usuario2);
            dt5 = msq.sub613(usuario2);
            if (dt3.Rows.Count != 0 && dt4.Rows.Count != 0 && dt5.Rows.Count != 0)
            {
                //seccion subalterno
                var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
                var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
                var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
                var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
                var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
                var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
                var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);
                var datos8 = Convert.ToDecimal(dt5.Rows[7]["resultado"]);
                //seccion jefes
                var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
                var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
                var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
                var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
                var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
                var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
                var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);
                var datoj8 = Convert.ToDecimal(dt4.Rows[7]["nota"]);

                //seccion auto
                var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
                var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
                var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
                var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
                var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
                var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
                var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);
                var dato8 = Convert.ToDecimal(dt3.Rows[7]["nota"]);


                row1["promedio2"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

                row2["promedio2"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
                row3["promedio2"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

                row4["promedio2"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

                row5["promedio2"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
                row6["promedio2"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
                row7["promedio2"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;
                row8["promedio2"] = decimal.Round((dato8 + datoj8 + datos8) / 3, 2); ;

                dt6.Rows.Add(row1);
                dt6.Rows.Add(row2);
                dt6.Rows.Add(row3);
                dt6.Rows.Add(row4);
                dt6.Rows.Add(row5);
                dt6.Rows.Add(row6);
                dt6.Rows.Add(row7);
                dt6.Rows.Add(row8);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Aún faltan datos para generar el reporte.')", true);

            }



            return dt6;

        }
        private DataTable promediosbueno3()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();

            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio3");



            dt3 = msq.AUTO1420(usuario2);
            dt4 = msq.JEFE1420(usuario2);
            dt5 = msq.sub1420(usuario2);
            if (dt3.Rows.Count != 0 && dt4.Rows.Count != 0 && dt5.Rows.Count != 0)
            {
                //seccion subalterno
                var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
                var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
                var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
                var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
                var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
                var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
                var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);

                //seccion jefes
                var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
                var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
                var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
                var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
                var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
                var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
                var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);


                //seccion auto
                var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
                var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
                var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
                var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
                var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
                var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
                var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);



                row1["promedio3"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

                row2["promedio3"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
                row3["promedio3"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

                row4["promedio3"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

                row5["promedio3"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
                row6["promedio3"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
                row7["promedio3"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;


                dt6.Rows.Add(row1);
                dt6.Rows.Add(row2);
                dt6.Rows.Add(row3);
                dt6.Rows.Add(row4);
                dt6.Rows.Add(row5);
                dt6.Rows.Add(row6);
                dt6.Rows.Add(row7);

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Aún faltan datos para generar el reporte.')", true);


            }




            return dt6;

        }

        private DataTable promediosbuenoag()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio1");



            dt3 = msq.AUTO15(usuario2);
            dt4 = msq.JEFE15mod(usuario2);
            dt5 = msq.sub15(usuario2);

            //seccion subalterno
            var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
            var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
            var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
            var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
            var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
            //seccion jefes
            var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
            var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
            var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
            var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
            var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);

            //seccion auto
            var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
            var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
            var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
            var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
            var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);


            row1["promedio1"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

            row2["promedio1"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
            row3["promedio1"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

            row4["promedio1"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

            row5["promedio1"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;

            dt6.Rows.Add(row1);
            dt6.Rows.Add(row2);
            dt6.Rows.Add(row3);
            dt6.Rows.Add(row4);
            dt6.Rows.Add(row5);





            return dt6;

        }
        private DataTable promediosbueno2ag()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();
            DataRow row8 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio2");



            dt3 = msq.AUTO6132(usuario2);
            dt4 = msq.JEFE6132mod(usuario2);
            dt5 = msq.sub613(usuario2);

            //seccion subalterno
            var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
            var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
            var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
            var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
            var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
            var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
            var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);
            var datos8 = Convert.ToDecimal(dt5.Rows[7]["resultado"]);
            //seccion jefes
            var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
            var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
            var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
            var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
            var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
            var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
            var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);
            var datoj8 = Convert.ToDecimal(dt4.Rows[7]["nota"]);

            //seccion auto
            var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
            var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
            var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
            var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
            var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
            var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
            var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);
            var dato8 = Convert.ToDecimal(dt3.Rows[7]["nota"]);


            row1["promedio2"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

            row2["promedio2"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
            row3["promedio2"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

            row4["promedio2"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

            row5["promedio2"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
            row6["promedio2"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
            row7["promedio2"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;
            row8["promedio2"] = decimal.Round((dato8 + datoj8 + datos8) / 3, 2); ;

            dt6.Rows.Add(row1);
            dt6.Rows.Add(row2);
            dt6.Rows.Add(row3);
            dt6.Rows.Add(row4);
            dt6.Rows.Add(row5);
            dt6.Rows.Add(row6);
            dt6.Rows.Add(row7);
            dt6.Rows.Add(row8);





            return dt6;

        }
        private DataTable promediosbueno3ag()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();

            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio3");



            dt3 = msq.AUTO1420(usuario2);
            dt4 = msq.JEFE1420mod(usuario2);
            dt5 = msq.sub1420(usuario2);

            //seccion subalterno
            var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
            var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
            var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
            var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
            var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
            var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
            var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);

            //seccion jefes
            var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
            var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
            var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
            var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
            var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
            var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
            var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);


            //seccion auto
            var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
            var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
            var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
            var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
            var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
            var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
            var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);



            row1["promedio3"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

            row2["promedio3"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
            row3["promedio3"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

            row4["promedio3"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

            row5["promedio3"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
            row6["promedio3"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
            row7["promedio3"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;


            dt6.Rows.Add(row1);
            dt6.Rows.Add(row2);
            dt6.Rows.Add(row3);
            dt6.Rows.Add(row4);
            dt6.Rows.Add(row5);
            dt6.Rows.Add(row6);
            dt6.Rows.Add(row7);






            return dt6;

        }



        private DataTable notafinal()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.notafinal(usuario2);






            return dt3;



        }


        private DataTable encabezadomod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.ENCABEZADOmod2(usuario2);






            return dt3;



        }
        private DataTable encabezadomod2()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.ENCABEZADOmod(usuario2);






            return dt3;



        }
        private DataTable jefe15mod()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.JEFE15mod(usuario2);






            return dt3;



        }
        private DataTable jefe613mod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE613mod(usuario2);






            return dt3;



        }
        private DataTable jefe6132mod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE6132mod(usuario2);






            return dt3;



        }
        private DataTable JEFE1420mod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE1420mod(usuario2);






            return dt3;



        }
        private DataTable comentariosmod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.COMENTmod(usuario2);






            return dt3;



        }

        //

        //segunda
        private DataTable sauto15()
        {
            DataTable dt3 = new DataTable();




            string usuario2 = msq.iduser(ususario);

            dt3 = msq.sAUTO15(usuario2);






            return dt3;



        }
        private DataTable sauto613()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.sAUTO613(usuario2);






            return dt3;



        }
        private DataTable sauto1420()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.sAUTO1420(usuario2);






            return dt3;



        }
        private DataTable sjefe15()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.sJEFE15(usuario2);






            return dt3;



        }
        private DataTable sjefe613()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sJEFE613(usuario2);






            return dt3;



        }

        private DataTable sjefe15a()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.sJEFE15a(usuario2);






            return dt3;



        }
        private DataTable sjefe613a()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sJEFE613a(usuario2);






            return dt3;



        }
        private DataTable sauto6132()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.sAUTO6132(usuario2);






            return dt3;



        }

        private DataTable sjefe6132()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sJEFE6132(usuario2);






            return dt3;



        }
        private DataTable sJEFE1420()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sJEFE1420(usuario2);






            return dt3;



        }


        private DataTable spromedios15()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sPROM15(usuario2);






            return dt3;



        }
        private DataTable spromedios613()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sPROM613(usuario2);






            return dt3;



        }
        private DataTable spromedios6132()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.PROM6132(usuario2);






            return dt3;



        }
        private DataTable spromedios1420()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.PROM1420(usuario2);






            return dt3;



        }
        private DataTable scomentarios()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sCOMENT(usuario2);






            return dt3;



        }
        private DataTable sencabezado()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sENCABEZADO(usuario2);






            return dt3;



        }
        private DataTable sencabezadoa()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sENCABEZADOa(usuario2);






            return dt3;



        }
        private DataTable spreguntassub()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntassub();






            return dt3;



        }

        private DataTable spreguntasjefe()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasjefe();






            return dt3;



        }
        private DataTable spreguntasjefe17()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasjefe17();






            return dt3;



        }
        private DataTable spreguntasescalajefe()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasrangosjefe1();






            return dt3;



        }
        private DataTable spreguntasescalasub()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.preguntasrangosjefe2();






            return dt3;



        }
        private DataTable sSUB15()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.ssub15(usuario2);






            return dt3;



        }
        private DataTable sSUB613()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.ssub613(usuario2);






            return dt3;



        }
        private DataTable sSUB1420()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.ssub1420(usuario2);






            return dt3;



        }

        private DataTable spromediosbueno()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio1");



            dt3 = msq.sAUTO15(usuario2);
            dt4 = msq.sJEFE15(usuario2);
            dt5 = msq.ssub15(usuario2);
            if (dt3.Rows.Count != 0 && dt4.Rows.Count != 0 && dt5.Rows.Count != 0)
            {
                //seccion subalterno
                var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
                var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
                var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
                var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
                var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
                //seccion jefes
                var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
                var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
                var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
                var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
                var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);

                //seccion auto
                var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
                var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
                var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
                var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
                var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);


                row1["promedio1"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

                row2["promedio1"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
                row3["promedio1"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

                row4["promedio1"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

                row5["promedio1"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;

                dt6.Rows.Add(row1);
                dt6.Rows.Add(row2);
                dt6.Rows.Add(row3);
                dt6.Rows.Add(row4);
                dt6.Rows.Add(row5);

            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Aún faltan datos para generar el reporte.')", true);



            }




            return dt6;

        }
        private DataTable spromediosbueno2()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();
            DataRow row8 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio2");



            dt3 = msq.sAUTO6132(usuario2);
            dt4 = msq.sJEFE6132(usuario2);
            dt5 = msq.ssub613(usuario2);
            if (dt3.Rows.Count != 0 && dt4.Rows.Count != 0 && dt5.Rows.Count != 0)
            {
                //seccion subalterno
                var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
                var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
                var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
                var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
                var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
                var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
                var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);
                var datos8 = Convert.ToDecimal(dt5.Rows[7]["resultado"]);
                //seccion jefes
                var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
                var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
                var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
                var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
                var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
                var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
                var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);
                var datoj8 = Convert.ToDecimal(dt4.Rows[7]["nota"]);

                //seccion auto
                var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
                var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
                var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
                var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
                var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
                var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
                var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);
                var dato8 = Convert.ToDecimal(dt3.Rows[7]["nota"]);


                row1["promedio2"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

                row2["promedio2"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
                row3["promedio2"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

                row4["promedio2"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

                row5["promedio2"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
                row6["promedio2"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
                row7["promedio2"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;
                row8["promedio2"] = decimal.Round((dato8 + datoj8 + datos8) / 3, 2); ;

                dt6.Rows.Add(row1);
                dt6.Rows.Add(row2);
                dt6.Rows.Add(row3);
                dt6.Rows.Add(row4);
                dt6.Rows.Add(row5);
                dt6.Rows.Add(row6);
                dt6.Rows.Add(row7);
                dt6.Rows.Add(row8);

            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Aún faltan datos para generar el reporte.')", true);



            }


            return dt6;

        }
        private DataTable spromediosbueno3()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();

            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio3");



            dt3 = msq.sAUTO1420(usuario2);
            dt4 = msq.sJEFE1420(usuario2);
            dt5 = msq.ssub1420(usuario2);
            if (dt3.Rows.Count != 0 && dt4.Rows.Count != 0 && dt5.Rows.Count != 0)
            {
                //seccion subalterno
                var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
                var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
                var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
                var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
                var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
                var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
                var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);

                //seccion jefes
                var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
                var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
                var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
                var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
                var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
                var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
                var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);


                //seccion auto
                var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
                var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
                var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
                var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
                var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
                var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
                var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);



                row1["promedio3"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

                row2["promedio3"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
                row3["promedio3"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

                row4["promedio3"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

                row5["promedio3"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
                row6["promedio3"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
                row7["promedio3"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;


                dt6.Rows.Add(row1);
                dt6.Rows.Add(row2);
                dt6.Rows.Add(row3);
                dt6.Rows.Add(row4);
                dt6.Rows.Add(row5);
                dt6.Rows.Add(row6);
                dt6.Rows.Add(row7);


            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Aún faltan datos para generar el reporte.')", true);


            }



            return dt6;

        }

        private DataTable spromediosbuenoag()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio1");



            dt3 = msq.sAUTO15(usuario2);
            dt4 = msq.sJEFE15mod(usuario2);
            dt5 = msq.ssub15(usuario2);

            //seccion subalterno
            var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
            var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
            var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
            var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
            var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
            //seccion jefes
            var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
            var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
            var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
            var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
            var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);

            //seccion auto
            var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
            var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
            var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
            var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
            var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);


            row1["promedio1"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

            row2["promedio1"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
            row3["promedio1"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

            row4["promedio1"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

            row5["promedio1"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;

            dt6.Rows.Add(row1);
            dt6.Rows.Add(row2);
            dt6.Rows.Add(row3);
            dt6.Rows.Add(row4);
            dt6.Rows.Add(row5);





            return dt6;

        }
        private DataTable spromediosbueno2ag()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();
            DataRow row8 = dt6.NewRow();
            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio2");



            dt3 = msq.sAUTO6132(usuario2);
            dt4 = msq.sJEFE6132mod(usuario2);
            dt5 = msq.ssub613(usuario2);

            //seccion subalterno
            var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
            var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
            var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
            var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
            var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
            var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
            var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);
            var datos8 = Convert.ToDecimal(dt5.Rows[7]["resultado"]);
            //seccion jefes
            var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
            var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
            var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
            var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
            var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
            var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
            var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);
            var datoj8 = Convert.ToDecimal(dt4.Rows[7]["nota"]);

            //seccion auto
            var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
            var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
            var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
            var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
            var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
            var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
            var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);
            var dato8 = Convert.ToDecimal(dt3.Rows[7]["nota"]);


            row1["promedio2"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

            row2["promedio2"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
            row3["promedio2"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

            row4["promedio2"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

            row5["promedio2"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
            row6["promedio2"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
            row7["promedio2"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;
            row8["promedio2"] = decimal.Round((dato8 + datoj8 + datos8) / 3, 2); ;

            dt6.Rows.Add(row1);
            dt6.Rows.Add(row2);
            dt6.Rows.Add(row3);
            dt6.Rows.Add(row4);
            dt6.Rows.Add(row5);
            dt6.Rows.Add(row6);
            dt6.Rows.Add(row7);
            dt6.Rows.Add(row8);





            return dt6;

        }
        private DataTable spromediosbueno3ag()
        {
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            string usuario2 = msq.iduser(ususario);

            DataRow row1 = dt6.NewRow();
            DataRow row2 = dt6.NewRow();
            DataRow row3 = dt6.NewRow();
            DataRow row4 = dt6.NewRow();
            DataRow row5 = dt6.NewRow();
            DataRow row6 = dt6.NewRow();
            DataRow row7 = dt6.NewRow();

            dt6.Columns.Add("usuario_calificado");
            dt6.Columns.Add("ordenpregunta");
            dt6.Columns.Add("promedio3");



            dt3 = msq.sAUTO1420(usuario2);
            dt4 = msq.sJEFE1420mod(usuario2);
            dt5 = msq.ssub1420(usuario2);
            if (dt3.Rows.Count != 0 && dt4.Rows.Count != 0 && dt5.Rows.Count != 0)
            {
                //seccion subalterno
                var datos1 = Convert.ToDecimal(dt5.Rows[0]["resultado"]);
                var datos2 = Convert.ToDecimal(dt5.Rows[1]["resultado"]);
                var datos3 = Convert.ToDecimal(dt5.Rows[2]["resultado"]);
                var datos4 = Convert.ToDecimal(dt5.Rows[3]["resultado"]);
                var datos5 = Convert.ToDecimal(dt5.Rows[4]["resultado"]);
                var datos6 = Convert.ToDecimal(dt5.Rows[5]["resultado"]);
                var datos7 = Convert.ToDecimal(dt5.Rows[6]["resultado"]);

                //seccion jefes
                var datoj1 = Convert.ToDecimal(dt4.Rows[0]["nota"]);
                var datoj2 = Convert.ToDecimal(dt4.Rows[1]["nota"]);
                var datoj3 = Convert.ToDecimal(dt4.Rows[2]["nota"]);
                var datoj4 = Convert.ToDecimal(dt4.Rows[3]["nota"]);
                var datoj5 = Convert.ToDecimal(dt4.Rows[4]["nota"]);
                var datoj6 = Convert.ToDecimal(dt4.Rows[5]["nota"]);
                var datoj7 = Convert.ToDecimal(dt4.Rows[6]["nota"]);


                //seccion auto
                var dato1 = Convert.ToDecimal(dt3.Rows[0]["nota"]);
                var dato2 = Convert.ToDecimal(dt3.Rows[1]["nota"]);
                var dato3 = Convert.ToDecimal(dt3.Rows[2]["nota"]);
                var dato4 = Convert.ToDecimal(dt3.Rows[3]["nota"]);
                var dato5 = Convert.ToDecimal(dt3.Rows[4]["nota"]);
                var dato6 = Convert.ToDecimal(dt3.Rows[5]["nota"]);
                var dato7 = Convert.ToDecimal(dt3.Rows[6]["nota"]);



                row1["promedio3"] = decimal.Round((dato1 + datoj1 + datos1) / 3, 2);

                row2["promedio3"] = decimal.Round((dato2 + datoj2 + datos2) / 3, 2);
                row3["promedio3"] = decimal.Round((dato3 + datoj3 + datos3) / 3, 2);

                row4["promedio3"] = decimal.Round((dato4 + datoj4 + datos4) / 3, 2);

                row5["promedio3"] = decimal.Round((dato5 + datoj5 + datos5) / 3, 2); ;
                row6["promedio3"] = decimal.Round((dato6 + datoj6 + datos6) / 3, 2); ;
                row7["promedio3"] = decimal.Round((dato7 + datoj7 + datos7) / 3, 2); ;


                dt6.Rows.Add(row1);
                dt6.Rows.Add(row2);
                dt6.Rows.Add(row3);
                dt6.Rows.Add(row4);
                dt6.Rows.Add(row5);
                dt6.Rows.Add(row6);
                dt6.Rows.Add(row7);


            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Aún faltan datos para generar el reporte.')", true);


            }



            return dt6;

        }



        private DataTable snotafinal()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.snotafinal(usuario2);






            return dt3;



        }



        private DataTable sencabezadomod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sENCABEZADOmod(usuario2);






            return dt3;



        }
        private DataTable sjefe15mod()
        {
            DataTable dt3 = new DataTable();


            string usuario2 = msq.iduser(ususario);



            dt3 = msq.sJEFE15mod(usuario2);






            return dt3;



        }
        private DataTable sjefe613mod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.JEFE613mod(usuario2);






            return dt3;



        }
        private DataTable sjefe6132mod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sJEFE6132mod(usuario2);






            return dt3;



        }
        private DataTable sJEFE1420mod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sJEFE1420mod(usuario2);






            return dt3;



        }
        private DataTable scomentariosmod()
        {
            DataTable dt3 = new DataTable();



            string usuario2 = msq.iduser(ususario);


            dt3 = msq.sCOMENTmod(usuario2);






            return dt3;



        }
        //
        protected void preguntasgen()
        {
            ReportViewer1.Reset();
            ReportDataSource fuente = new ReportDataSource("preguntasescalas", preguntasescalajefe());


            ReportViewer1.LocalReport.DataSources.Add(fuente);

            ReportViewer1.LocalReport.ReportPath = "Views/Evaluaciones/Preguntas.rdlc";

            ReportViewer1.LocalReport.Refresh();

        }
        protected void preguntasgen2()
        {
            ReportViewer1.Reset();
            ReportDataSource fuente = new ReportDataSource("preguntasescalas", preguntasescalasub());


            ReportViewer1.LocalReport.DataSources.Add(fuente);

            ReportViewer1.LocalReport.ReportPath = "Views/Evaluaciones/Preguntas.rdlc";

            ReportViewer1.LocalReport.Refresh();

        }
        public void individualrepo()
        {
            string puestos = msq.obtenerpuesto(ususario);
            if (puestos == "80" || puestos == "78" || puestos == "81" || puestos == "82" || puestos == "83" || puestos == "51" || puestos == "77" || puestos == "79")
            {
                ReportViewer1.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15a());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe613a());
                ReportDataSource fuente5 = new ReportDataSource("pro1", promedios15());
                ReportDataSource fuente6 = new ReportDataSource("pro2", promedios613());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", comentariosa());
                ReportDataSource fuente8 = new ReportDataSource("encab", encabezadomod2());
                ReportDataSource fuente9 = new ReportDataSource("preguntas", preguntassub());


                ReportViewer1.LocalReport.DataSources.Add(fuente);
                ReportViewer1.LocalReport.DataSources.Add(fuente2);
                ReportViewer1.LocalReport.DataSources.Add(fuente3);
                ReportViewer1.LocalReport.DataSources.Add(fuente4);
                ReportViewer1.LocalReport.DataSources.Add(fuente5);
                ReportViewer1.LocalReport.DataSources.Add(fuente6);
                ReportViewer1.LocalReport.DataSources.Add(fuente7);
                ReportViewer1.LocalReport.DataSources.Add(fuente8);
                ReportViewer1.LocalReport.DataSources.Add(fuente9);

                ReportViewer1.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeño.rdlc";

                ReportViewer1.LocalReport.Refresh();

            }
            else
            {

                ReportViewer1.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe613());
                ReportDataSource fuente5 = new ReportDataSource("pro1", promedios15());
                ReportDataSource fuente6 = new ReportDataSource("pro2", promedios613());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", comentarios());
                ReportDataSource fuente8 = new ReportDataSource("encab", encabezado());
                ReportDataSource fuente9 = new ReportDataSource("preguntas", preguntassub());


                ReportViewer1.LocalReport.DataSources.Add(fuente);
                ReportViewer1.LocalReport.DataSources.Add(fuente2);
                ReportViewer1.LocalReport.DataSources.Add(fuente3);
                ReportViewer1.LocalReport.DataSources.Add(fuente4);
                ReportViewer1.LocalReport.DataSources.Add(fuente5);
                ReportViewer1.LocalReport.DataSources.Add(fuente6);
                ReportViewer1.LocalReport.DataSources.Add(fuente7);
                ReportViewer1.LocalReport.DataSources.Add(fuente8);
                ReportViewer1.LocalReport.DataSources.Add(fuente9);

                ReportViewer1.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeño.rdlc";

                ReportViewer1.LocalReport.Refresh();
            }

        }
        public void vaciorepo()
        {
            ReportViewer1.Reset();

        }
        public void generarpropio2()
        {

            string puestos = msq.obtenerpuesto(ususario);
            if (puestos == "80" || puestos == "78" || puestos == "81" || puestos == "82" || puestos == "83" || puestos == "51" || puestos == "77" || puestos == "79")
            {

                ReportViewer2.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", sauto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", sauto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", sjefe15a());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", sjefe613a());
                ReportDataSource fuente5 = new ReportDataSource("pro1", spromedios15());
                ReportDataSource fuente6 = new ReportDataSource("pro2", spromedios613());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", scomentariosa());
                ReportDataSource fuente8 = new ReportDataSource("encab", sencabezadoa());
                ReportDataSource fuente9 = new ReportDataSource("preguntas", spreguntassub());

                ReportViewer2.LocalReport.DataSources.Add(fuente);
                ReportViewer2.LocalReport.DataSources.Add(fuente2);
                ReportViewer2.LocalReport.DataSources.Add(fuente3);
                ReportViewer2.LocalReport.DataSources.Add(fuente4);
                ReportViewer2.LocalReport.DataSources.Add(fuente5);
                ReportViewer2.LocalReport.DataSources.Add(fuente6);
                ReportViewer2.LocalReport.DataSources.Add(fuente7);
                ReportViewer2.LocalReport.DataSources.Add(fuente8);
                ReportViewer2.LocalReport.DataSources.Add(fuente9);
                ReportViewer2.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeño2.rdlc";

                ReportViewer2.LocalReport.Refresh();
            }
            else
            {

                ReportViewer2.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", sauto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", sauto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", sjefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", sjefe613());
                ReportDataSource fuente5 = new ReportDataSource("pro1", spromedios15());
                ReportDataSource fuente6 = new ReportDataSource("pro2", spromedios613());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", scomentarios());
                ReportDataSource fuente8 = new ReportDataSource("encab", sencabezado());
                ReportDataSource fuente9 = new ReportDataSource("preguntas", spreguntassub());

                ReportViewer2.LocalReport.DataSources.Add(fuente);
                ReportViewer2.LocalReport.DataSources.Add(fuente2);
                ReportViewer2.LocalReport.DataSources.Add(fuente3);
                ReportViewer2.LocalReport.DataSources.Add(fuente4);
                ReportViewer2.LocalReport.DataSources.Add(fuente5);
                ReportViewer2.LocalReport.DataSources.Add(fuente6);
                ReportViewer2.LocalReport.DataSources.Add(fuente7);
                ReportViewer2.LocalReport.DataSources.Add(fuente8);
                ReportViewer2.LocalReport.DataSources.Add(fuente9);
                ReportViewer2.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeño2.rdlc";

                ReportViewer2.LocalReport.Refresh();


            }
        }

        public void jeferepo2()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "83" || puestos == "76" || puestos == "122")
            {
                ReportViewer2.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", sauto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", sauto6132());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", sjefe15mod());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", sjefe6132mod());
                ReportDataSource fuente5 = new ReportDataSource("pro1", spromediosbuenoag());
                ReportDataSource fuente6 = new ReportDataSource("pro2", spromediosbueno2ag());
                ReportDataSource fuente12 = new ReportDataSource("pro3", spromediosbueno3ag());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", scomentariosmod());
                ReportDataSource fuente8 = new ReportDataSource("encab", sencabezadomod());
                ReportDataSource fuente9 = new ReportDataSource("subal15", sSUB15());
                ReportDataSource fuente10 = new ReportDataSource("subal613", sSUB613());
                ReportDataSource fuente11 = new ReportDataSource("subal1420", sSUB1420());
                ReportDataSource fuente13 = new ReportDataSource("jefe1420", sJEFE1420mod());
                ReportDataSource fuente14 = new ReportDataSource("auto1420", sauto1420());
                ReportDataSource fuente15 = new ReportDataSource("notafinal", snotafinal());
                ReportDataSource fuente16 = new ReportDataSource("preguntas", spreguntasjefe());
                ReportDataSource fuente17 = new ReportDataSource("preguntas16", spreguntasjefe17());


                ReportViewer2.LocalReport.DataSources.Add(fuente);
                ReportViewer2.LocalReport.DataSources.Add(fuente2);
                ReportViewer2.LocalReport.DataSources.Add(fuente3);
                ReportViewer2.LocalReport.DataSources.Add(fuente4);
                ReportViewer2.LocalReport.DataSources.Add(fuente5);
                ReportViewer2.LocalReport.DataSources.Add(fuente6);
                ReportViewer2.LocalReport.DataSources.Add(fuente7);
                ReportViewer2.LocalReport.DataSources.Add(fuente8);
                ReportViewer2.LocalReport.DataSources.Add(fuente9);
                ReportViewer2.LocalReport.DataSources.Add(fuente10);
                ReportViewer2.LocalReport.DataSources.Add(fuente11);
                ReportViewer2.LocalReport.DataSources.Add(fuente12);
                ReportViewer2.LocalReport.DataSources.Add(fuente13);
                ReportViewer2.LocalReport.DataSources.Add(fuente14);
                ReportViewer2.LocalReport.DataSources.Add(fuente15);
                ReportViewer2.LocalReport.DataSources.Add(fuente16);
                ReportViewer2.LocalReport.DataSources.Add(fuente17);

                ReportViewer2.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeñoJefe.rdlc";

                ReportViewer2.LocalReport.Refresh();


            }
            else
            {
                ReportViewer2.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", sauto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", sauto6132());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", sjefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", sjefe6132());
                ReportDataSource fuente5 = new ReportDataSource("pro1", spromediosbueno());
                ReportDataSource fuente6 = new ReportDataSource("pro2", spromediosbueno2());
                ReportDataSource fuente12 = new ReportDataSource("pro3", spromediosbueno3());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", scomentarios());
                ReportDataSource fuente8 = new ReportDataSource("encab", sencabezado());
                ReportDataSource fuente9 = new ReportDataSource("subal15", sSUB15());
                ReportDataSource fuente10 = new ReportDataSource("subal613", sSUB613());
                ReportDataSource fuente11 = new ReportDataSource("subal1420", sSUB1420());
                ReportDataSource fuente13 = new ReportDataSource("jefe1420", sJEFE1420());
                ReportDataSource fuente14 = new ReportDataSource("auto1420", sauto1420());
                ReportDataSource fuente15 = new ReportDataSource("notafinal", snotafinal());
                ReportDataSource fuente16 = new ReportDataSource("preguntas", spreguntasjefe());
                ReportDataSource fuente17 = new ReportDataSource("preguntas16", spreguntasjefe17());

                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{

                ReportViewer2.LocalReport.DataSources.Add(fuente);
                ReportViewer2.LocalReport.DataSources.Add(fuente2);
                ReportViewer2.LocalReport.DataSources.Add(fuente3);
                ReportViewer2.LocalReport.DataSources.Add(fuente4);
                ReportViewer2.LocalReport.DataSources.Add(fuente5);
                ReportViewer2.LocalReport.DataSources.Add(fuente6);
                ReportViewer2.LocalReport.DataSources.Add(fuente7);
                ReportViewer2.LocalReport.DataSources.Add(fuente8);
                ReportViewer2.LocalReport.DataSources.Add(fuente9);
                ReportViewer2.LocalReport.DataSources.Add(fuente10);
                ReportViewer2.LocalReport.DataSources.Add(fuente11);
                ReportViewer2.LocalReport.DataSources.Add(fuente12);
                ReportViewer2.LocalReport.DataSources.Add(fuente13);
                ReportViewer2.LocalReport.DataSources.Add(fuente14);
                ReportViewer2.LocalReport.DataSources.Add(fuente15);
                ReportViewer2.LocalReport.DataSources.Add(fuente16);
                ReportViewer2.LocalReport.DataSources.Add(fuente17);

                ReportViewer2.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeñoJefe.rdlc";

                ReportViewer2.LocalReport.Refresh();
                //}

                //else
                //{

                //    String script = "alert('Faltan datos para crear el reporte '); window.location.href= 'sq_imprimirevaluacion.aspx';";
                //    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                //}
            }

        }
        public void jeferepo()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "83" || puestos == "76" || puestos == "122")
            {
                ReportViewer1.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto6132());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15mod());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132mod());
                ReportDataSource fuente5 = new ReportDataSource("pro1", promediosbuenoag());
                ReportDataSource fuente6 = new ReportDataSource("pro2", promediosbueno2ag());
                ReportDataSource fuente12 = new ReportDataSource("pro3", promediosbueno3ag());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", comentariosmod());
                ReportDataSource fuente8 = new ReportDataSource("encab", encabezadomod());
                ReportDataSource fuente9 = new ReportDataSource("subal15", SUB15());
                ReportDataSource fuente10 = new ReportDataSource("subal613", SUB613());
                ReportDataSource fuente11 = new ReportDataSource("subal1420", SUB1420());
                ReportDataSource fuente13 = new ReportDataSource("jefe1420", JEFE1420mod());
                ReportDataSource fuente14 = new ReportDataSource("auto1420", auto1420());
                ReportDataSource fuente15 = new ReportDataSource("notafinal", notafinal());
                ReportDataSource fuente16 = new ReportDataSource("preguntas", preguntasjefe());
                ReportDataSource fuente17 = new ReportDataSource("preguntas16", preguntasjefe17());


                ReportViewer1.LocalReport.DataSources.Add(fuente);
                ReportViewer1.LocalReport.DataSources.Add(fuente2);
                ReportViewer1.LocalReport.DataSources.Add(fuente3);
                ReportViewer1.LocalReport.DataSources.Add(fuente4);
                ReportViewer1.LocalReport.DataSources.Add(fuente5);
                ReportViewer1.LocalReport.DataSources.Add(fuente6);
                ReportViewer1.LocalReport.DataSources.Add(fuente7);
                ReportViewer1.LocalReport.DataSources.Add(fuente8);
                ReportViewer1.LocalReport.DataSources.Add(fuente9);
                ReportViewer1.LocalReport.DataSources.Add(fuente10);
                ReportViewer1.LocalReport.DataSources.Add(fuente11);
                ReportViewer1.LocalReport.DataSources.Add(fuente12);
                ReportViewer1.LocalReport.DataSources.Add(fuente13);
                ReportViewer1.LocalReport.DataSources.Add(fuente14);
                ReportViewer1.LocalReport.DataSources.Add(fuente15);
                ReportViewer1.LocalReport.DataSources.Add(fuente16);
                ReportViewer1.LocalReport.DataSources.Add(fuente17);

                ReportViewer1.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeñoJefe.rdlc";

                ReportViewer1.LocalReport.Refresh();


            }
            else
            {
                ReportViewer1.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto6132());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132());
                ReportDataSource fuente5 = new ReportDataSource("pro1", promediosbueno());
                ReportDataSource fuente6 = new ReportDataSource("pro2", promediosbueno2());
                ReportDataSource fuente12 = new ReportDataSource("pro3", promediosbueno3());
                ReportDataSource fuente7 = new ReportDataSource("comentarios", comentarios());
                ReportDataSource fuente8 = new ReportDataSource("encab", encabezado());
                ReportDataSource fuente9 = new ReportDataSource("subal15", SUB15());
                ReportDataSource fuente10 = new ReportDataSource("subal613", SUB613());
                ReportDataSource fuente11 = new ReportDataSource("subal1420", SUB1420());
                ReportDataSource fuente13 = new ReportDataSource("jefe1420", JEFE1420());
                ReportDataSource fuente14 = new ReportDataSource("auto1420", auto1420());
                ReportDataSource fuente15 = new ReportDataSource("notafinal", notafinal());
                ReportDataSource fuente16 = new ReportDataSource("preguntas", preguntasjefe());
                ReportDataSource fuente17 = new ReportDataSource("preguntas16", preguntasjefe17());


                ReportViewer1.LocalReport.DataSources.Add(fuente);
                ReportViewer1.LocalReport.DataSources.Add(fuente2);
                ReportViewer1.LocalReport.DataSources.Add(fuente3);
                ReportViewer1.LocalReport.DataSources.Add(fuente4);
                ReportViewer1.LocalReport.DataSources.Add(fuente5);
                ReportViewer1.LocalReport.DataSources.Add(fuente6);
                ReportViewer1.LocalReport.DataSources.Add(fuente7);
                ReportViewer1.LocalReport.DataSources.Add(fuente8);
                ReportViewer1.LocalReport.DataSources.Add(fuente9);
                ReportViewer1.LocalReport.DataSources.Add(fuente10);
                ReportViewer1.LocalReport.DataSources.Add(fuente11);
                ReportViewer1.LocalReport.DataSources.Add(fuente12);
                ReportViewer1.LocalReport.DataSources.Add(fuente13);
                ReportViewer1.LocalReport.DataSources.Add(fuente14);
                ReportViewer1.LocalReport.DataSources.Add(fuente15);
                ReportViewer1.LocalReport.DataSources.Add(fuente16);
                ReportViewer1.LocalReport.DataSources.Add(fuente17);

                ReportViewer1.LocalReport.ReportPath = "Views/Evaluaciones/ReporteDesempeñoJefe.rdlc";

                ReportViewer1.LocalReport.Refresh();
            }



        }

        public void resultadosiis()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "83" || puestos == "76")
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente2 = new ReportDataSource("ssauto613", sauto6132());
                ReportDataSource fuente3 = new ReportDataSource("ssjefe15", sjefe15mod());
                ReportDataSource fuente4 = new ReportDataSource("ssjefe6132", sjefe6132mod());



                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividual.rdlc";

                ReportViewer3.LocalReport.Refresh();


            }
            else
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente2 = new ReportDataSource("ssauto613", sauto6132());
                ReportDataSource fuente3 = new ReportDataSource("ssjefe15", sjefe15());
                ReportDataSource fuente4 = new ReportDataSource("ssjefe6132", sjefe6132());


                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividual.rdlc";

                ReportViewer3.LocalReport.Refresh();
                //}

                //else
                //{

                //    String script = "alert('Faltan datos para crear el reporte '); window.location.href= 'sq_imprimirevaluacion.aspx';";
                //    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                //}
            }

        }
        public void resultadosii()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "80" || puestos == "78" || puestos == "81" || puestos == "82" || puestos == "51" || puestos == "77")
            {

                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15a());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe613a());

                ReportDataSource fuente5 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente6 = new ReportDataSource("ssauto6132", sauto613());
                ReportDataSource fuente7 = new ReportDataSource("ssjefe15", sjefe15a());
                ReportDataSource fuente8 = new ReportDataSource("ssjefe6132", sjefe613a());

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);

                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);

                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividual.rdlc";

                ReportViewer3.LocalReport.Refresh();


            }
            else
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132());

                ReportDataSource fuente5 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente6 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente7 = new ReportDataSource("ssjefe15", sjefe15());
                ReportDataSource fuente8 = new ReportDataSource("ssjefe6132", sjefe6132());


                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);

                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividual.rdlc";

                ReportViewer3.LocalReport.Refresh();
            }



        }
        public void resultadosji()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "83" || puestos == "76")
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto6132());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15mod());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132mod());



                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadojefeindividual.rdlc";

                ReportViewer3.LocalReport.Refresh();


            }
            else
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto6132());
                ReportDataSource fuente13 = new ReportDataSource("auto1420", auto1420());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132());
                ReportDataSource fuente12 = new ReportDataSource("jefe1420", JEFE1420());
                ReportDataSource fuente9 = new ReportDataSource("subal15", SUB15());
                ReportDataSource fuente10 = new ReportDataSource("subal613", SUB613());
                ReportDataSource fuente11 = new ReportDataSource("subal1420", SUB1420());

                ReportDataSource fuente5 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente6 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente7 = new ReportDataSource("ssjefe15", sjefe15());
                ReportDataSource fuente8 = new ReportDataSource("ssjefe6132", sjefe6132());


                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);

                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);
                ReportViewer3.LocalReport.DataSources.Add(fuente9);
                ReportViewer3.LocalReport.DataSources.Add(fuente10);
                ReportViewer3.LocalReport.DataSources.Add(fuente11);
                ReportViewer3.LocalReport.DataSources.Add(fuente12);
                ReportViewer3.LocalReport.DataSources.Add(fuente13);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadojefeindividual.rdlc";

                ReportViewer3.LocalReport.Refresh();
            }



        }
        public void resultadosjj()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "83" || puestos == "76")
            {
                ReportViewer3.Reset();




                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto6132());
                ReportDataSource fuente3 = new ReportDataSource("auto1420", auto1420());
                ReportDataSource fuente4 = new ReportDataSource("jefe15", jefe15mod());
                ReportDataSource fuente5 = new ReportDataSource("jefe613", jefe6132mod());


                ReportDataSource fuente6 = new ReportDataSource("subal15", SUB15());
                ReportDataSource fuente7 = new ReportDataSource("subal613", SUB613());
                ReportDataSource fuente8 = new ReportDataSource("subal1420", SUB1420());
                ReportDataSource fuente9 = new ReportDataSource("jefe1420", JEFE1420mod());

                ReportDataSource fuente10 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente11 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente12 = new ReportDataSource("ssauto1420", sauto1420());
                ReportDataSource fuente13 = new ReportDataSource("ssjefe15", sjefe15mod());
                ReportDataSource fuente14 = new ReportDataSource("ssjefe6132", sjefe6132mod());
                ReportDataSource fuente15 = new ReportDataSource("ssjefe1420", sJEFE1420mod());
                ReportDataSource fuente16 = new ReportDataSource("ssubal15", sSUB15());
                ReportDataSource fuente17 = new ReportDataSource("ssubal613", sSUB613());
                ReportDataSource fuente18 = new ReportDataSource("ssubal1420", sSUB1420());




                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);

                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);

                ReportViewer3.LocalReport.DataSources.Add(fuente9);
                ReportViewer3.LocalReport.DataSources.Add(fuente10);
                ReportViewer3.LocalReport.DataSources.Add(fuente11);
                ReportViewer3.LocalReport.DataSources.Add(fuente12);

                ReportViewer3.LocalReport.DataSources.Add(fuente13);
                ReportViewer3.LocalReport.DataSources.Add(fuente14);
                ReportViewer3.LocalReport.DataSources.Add(fuente15);
                ReportViewer3.LocalReport.DataSources.Add(fuente16);

                ReportViewer3.LocalReport.DataSources.Add(fuente17);
                ReportViewer3.LocalReport.DataSources.Add(fuente18);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadojefejefe.rdlc";

                ReportViewer3.LocalReport.Refresh();


            }
            else
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto6132());
                ReportDataSource fuente3 = new ReportDataSource("auto1420", auto1420());
                ReportDataSource fuente4 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente5 = new ReportDataSource("jefe613", jefe6132());
                ReportDataSource fuente6 = new ReportDataSource("jefe1420", JEFE1420());
                ReportDataSource fuente7 = new ReportDataSource("subal15", SUB15());
                ReportDataSource fuente8 = new ReportDataSource("subal613", SUB613());
                ReportDataSource fuente9 = new ReportDataSource("subal1420", SUB1420());

                ReportDataSource fuente10 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente11 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente12 = new ReportDataSource("ssauto1420", sauto1420());
                ReportDataSource fuente13 = new ReportDataSource("ssjefe15", sjefe15());
                ReportDataSource fuente14 = new ReportDataSource("ssjefe6132", sjefe6132());
                ReportDataSource fuente15 = new ReportDataSource("ssjefe1420", sJEFE1420());
                ReportDataSource fuente16 = new ReportDataSource("ssubal15", sSUB15());
                ReportDataSource fuente17 = new ReportDataSource("ssubal613", sSUB613());
                ReportDataSource fuente18 = new ReportDataSource("ssubal1420", sSUB1420());


                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);

                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);

                ReportViewer3.LocalReport.DataSources.Add(fuente9);
                ReportViewer3.LocalReport.DataSources.Add(fuente10);
                ReportViewer3.LocalReport.DataSources.Add(fuente11);
                ReportViewer3.LocalReport.DataSources.Add(fuente12);

                ReportViewer3.LocalReport.DataSources.Add(fuente13);
                ReportViewer3.LocalReport.DataSources.Add(fuente14);
                ReportViewer3.LocalReport.DataSources.Add(fuente15);
                ReportViewer3.LocalReport.DataSources.Add(fuente16);

                ReportViewer3.LocalReport.DataSources.Add(fuente17);
                ReportViewer3.LocalReport.DataSources.Add(fuente18);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadojefejefe.rdlc";

                ReportViewer3.LocalReport.Refresh();
            }



        }
        public void resultadosjjn()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "83" || puestos == "76")
            {
                ReportViewer3.Reset();






                ReportDataSource fuente10 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente11 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente12 = new ReportDataSource("ssauto1420", sauto1420());
                ReportDataSource fuente13 = new ReportDataSource("ssjefe15", sjefe15mod());
                ReportDataSource fuente14 = new ReportDataSource("ssjefe6132", sjefe6132mod());
                ReportDataSource fuente15 = new ReportDataSource("ssjefe1420", sJEFE1420mod());
                ReportDataSource fuente16 = new ReportDataSource("ssubal15", sSUB15());
                ReportDataSource fuente17 = new ReportDataSource("ssubal613", sSUB613());
                ReportDataSource fuente18 = new ReportDataSource("ssubal1420", sSUB1420());




                ReportViewer3.LocalReport.DataSources.Add(fuente10);
                ReportViewer3.LocalReport.DataSources.Add(fuente11);
                ReportViewer3.LocalReport.DataSources.Add(fuente12);

                ReportViewer3.LocalReport.DataSources.Add(fuente13);
                ReportViewer3.LocalReport.DataSources.Add(fuente14);
                ReportViewer3.LocalReport.DataSources.Add(fuente15);
                ReportViewer3.LocalReport.DataSources.Add(fuente16);

                ReportViewer3.LocalReport.DataSources.Add(fuente17);
                ReportViewer3.LocalReport.DataSources.Add(fuente18);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadojefenuevo.rdlc";

                ReportViewer3.LocalReport.Refresh();


            }
            else
            {
                ReportViewer3.Reset();


                ReportDataSource fuente10 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente11 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente12 = new ReportDataSource("ssauto1420", sauto1420());
                ReportDataSource fuente13 = new ReportDataSource("ssjefe15", sjefe15());
                ReportDataSource fuente14 = new ReportDataSource("ssjefe6132", sjefe6132());
                ReportDataSource fuente15 = new ReportDataSource("ssjefe1420", sJEFE1420());
                ReportDataSource fuente16 = new ReportDataSource("ssubal15", sSUB15());
                ReportDataSource fuente17 = new ReportDataSource("ssubal613", sSUB613());
                ReportDataSource fuente18 = new ReportDataSource("ssubal1420", sSUB1420());


                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{


                ReportViewer3.LocalReport.DataSources.Add(fuente10);
                ReportViewer3.LocalReport.DataSources.Add(fuente11);
                ReportViewer3.LocalReport.DataSources.Add(fuente12);

                ReportViewer3.LocalReport.DataSources.Add(fuente13);
                ReportViewer3.LocalReport.DataSources.Add(fuente14);
                ReportViewer3.LocalReport.DataSources.Add(fuente15);
                ReportViewer3.LocalReport.DataSources.Add(fuente16);

                ReportViewer3.LocalReport.DataSources.Add(fuente17);
                ReportViewer3.LocalReport.DataSources.Add(fuente18);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadojefenuevo.rdlc";

                ReportViewer3.LocalReport.Refresh();
            }



        }
        public void resultadosij()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "80" || puestos == "78" || puestos == "81" || puestos == "82" || puestos == "51")
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132());

                ReportDataSource fuente10 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente11 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente12 = new ReportDataSource("ssauto1420", sauto1420());
                ReportDataSource fuente13 = new ReportDataSource("ssjefe15", sjefe15a());
                ReportDataSource fuente14 = new ReportDataSource("ssjefe6132", sjefe613a());
                ReportDataSource fuente15 = new ReportDataSource("ssjefe1420", sJEFE1420mod());
                ReportDataSource fuente16 = new ReportDataSource("ssubal15", sSUB15());
                ReportDataSource fuente17 = new ReportDataSource("ssubal613", sSUB613());
                ReportDataSource fuente18 = new ReportDataSource("ssubal1420", sSUB1420());

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);
                ReportViewer3.LocalReport.DataSources.Add(fuente10);
                ReportViewer3.LocalReport.DataSources.Add(fuente11);
                ReportViewer3.LocalReport.DataSources.Add(fuente12);
                ReportViewer3.LocalReport.DataSources.Add(fuente13);
                ReportViewer3.LocalReport.DataSources.Add(fuente14);
                ReportViewer3.LocalReport.DataSources.Add(fuente15);
                ReportViewer3.LocalReport.DataSources.Add(fuente16);
                ReportViewer3.LocalReport.DataSources.Add(fuente17);
                ReportViewer3.LocalReport.DataSources.Add(fuente18);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividualjefe.rdlc";

                ReportViewer3.LocalReport.Refresh();


            }
            else
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132());

                ReportDataSource fuente5 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente6 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente7 = new ReportDataSource("ssjefe15", sjefe15());
                ReportDataSource fuente8 = new ReportDataSource("ssjefe6132", sjefe6132());
                ReportDataSource fuente9 = new ReportDataSource("jefe1420", JEFE1420());
                ReportDataSource fuente10 = new ReportDataSource("subal15", SUB15());
                ReportDataSource fuente11 = new ReportDataSource("subal613", SUB613());
                ReportDataSource fuente12 = new ReportDataSource("subal1420", SUB1420());



                ReportDataSource fuente13 = new ReportDataSource("ssauto1420", sauto1420());
                ReportDataSource fuente14 = new ReportDataSource("ssjefe1420", sJEFE1420());
                ReportDataSource fuente16 = new ReportDataSource("ssubal15", sSUB15());
                ReportDataSource fuente17 = new ReportDataSource("ssubal613", sSUB613());
                ReportDataSource fuente18 = new ReportDataSource("ssubal1420", sSUB1420());

                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);

                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);
                ReportViewer3.LocalReport.DataSources.Add(fuente9);
                ReportViewer3.LocalReport.DataSources.Add(fuente10);
                ReportViewer3.LocalReport.DataSources.Add(fuente11);
                ReportViewer3.LocalReport.DataSources.Add(fuente12);

                ReportViewer3.LocalReport.DataSources.Add(fuente13);
                ReportViewer3.LocalReport.DataSources.Add(fuente14);

                ReportViewer3.LocalReport.DataSources.Add(fuente16);

                ReportViewer3.LocalReport.DataSources.Add(fuente17);
                ReportViewer3.LocalReport.DataSources.Add(fuente18);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividualjefe.rdlc";

                ReportViewer3.LocalReport.Refresh();
            }



        }
        public void resultadosi()
        {


            string puestos = msq.obtenerpuesto(ususario);

            if (puestos == "80" || puestos == "78" || puestos == "81" || puestos == "82" || puestos == "51")
            {
                ReportViewer3.Reset();
                ReportDataSource fuente5 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente6 = new ReportDataSource("ssauto6132", sauto613());
                ReportDataSource fuente7 = new ReportDataSource("ssjefe15", sjefe15a());
                ReportDataSource fuente8 = new ReportDataSource("ssjefe6132", sjefe613a());



                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividualnuevo.rdlc";

                ReportViewer3.LocalReport.Refresh();


            }
            else
            {
                ReportViewer3.Reset();
                ReportDataSource fuente = new ReportDataSource("auto15", auto15());
                ReportDataSource fuente2 = new ReportDataSource("auto613", auto613());
                ReportDataSource fuente3 = new ReportDataSource("jefe15", jefe15());
                ReportDataSource fuente4 = new ReportDataSource("jefe613", jefe6132());

                ReportDataSource fuente5 = new ReportDataSource("ssauto15", sauto15());
                ReportDataSource fuente6 = new ReportDataSource("ssauto6132", sauto6132());
                ReportDataSource fuente7 = new ReportDataSource("ssjefe15", sjefe15());
                ReportDataSource fuente8 = new ReportDataSource("ssjefe6132", sjefe6132());


                //if (sauto15().Rows.Count != 0 && sauto6132().Rows.Count != 0 && sjefe15().Rows.Count != 0 && sjefe6132().Rows.Count != 0)
                //{

                ReportViewer3.LocalReport.DataSources.Add(fuente);
                ReportViewer3.LocalReport.DataSources.Add(fuente2);
                ReportViewer3.LocalReport.DataSources.Add(fuente3);
                ReportViewer3.LocalReport.DataSources.Add(fuente4);

                ReportViewer3.LocalReport.DataSources.Add(fuente5);
                ReportViewer3.LocalReport.DataSources.Add(fuente6);
                ReportViewer3.LocalReport.DataSources.Add(fuente7);
                ReportViewer3.LocalReport.DataSources.Add(fuente8);


                ReportViewer3.LocalReport.ReportPath = "Views/Evaluaciones/Consolidadoindividualnuevo.rdlc";

                ReportViewer3.LocalReport.Refresh();
            }



        }

        protected void Imprimir_Click(object sender, EventArgs e)
        {
            string id = msq.iduser(ususario);
            string cont = msq.contarimprimir(id);
            string cont2 = msq.contarimprimir2(id);
            ReportViewer1.ShowPrintButton = false;

            //resultadosiis();
          
                switch (cont)
                {

                    case "16":
                        individualrepo();
                        break;
                    case "23":
                        jeferepo();
                        break;
                    case "0":
                        individualrepo();
                        break;

                    default:

                        String script = "alert('Error en la evaluación '); window.location.href= 'SQ_ImprimirEvaluacion.aspx';";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                        break;
                }
                switch (cont2)
                {

                    case "16":
                        generarpropio2();
                        break;
                    case "23":
                        jeferepo2();
                        break;
                    case "0":
                        vaciorepo();
                        break;
                    default:

                        String script = "alert('Error en la evaluación 2 '); window.location.href= 'SQ_ImprimirEvaluacion.aspx';";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                        break;
                }

                if (cont == "0" && cont2 != "0")
                {

                    if (cont == "0" && cont2 == "16")
                    {
                        resultadosi();
                    }
                    if (cont == "0" && cont2 == "23")
                    {
                        resultadosjjn();

                    }


                }
                if (cont != "0" && cont2 != "0")
                {

                    if (cont == "16" && cont2 == "16")
                    {

                        resultadosii();
                    }
                    //jefeindividual
                    if (cont == "23" && cont2 == "16")
                    {
                        resultadosji();

                    }
                    //individualjefe
                    if (cont == "16" && cont2 == "23")
                    {

                        resultadosij();
                    }
                    if (cont == "23" && cont2 == "23")
                    {

                        resultadosjj();

                    }

                }
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = msq.iduser(ususario);
            string[] permiso = msq.puestos(id);
            int cantidadpermiso = permiso.Length;
            if (permiso[0] == "null" || permiso[0] == "0" || permiso[0] == "" || permiso[0] == null)
            {
                //permisoempleado
                preguntasgen2();

                ReportViewer1.ShowPrintButton = true;

            }
            else
            {
                //permisojefe
                preguntasgen();
                ReportViewer1.ShowPrintButton = true;
            }
        }
    }
}