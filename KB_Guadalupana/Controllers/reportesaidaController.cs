using ClosedXML.Excel;
using KB_Guadalupana.funcionalidad;
using KB_Guadalupana.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KB_Guadalupana.Controllers
{
    public class reportesaidaController : Controller
    {
        // GET: reportesaida

        ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
        Sentencia_juridico sn = new Sentencia_juridico();
        static string[,] nueva2 = null;

        [HttpPost]
        public ActionResult reportegeneral(List<modelogeneral.modelox> items)
        {

            string[,] nueva = null;
            inyeccion operacion = new inyeccion();
            //nueva = operacion.vistageneral(" tik_tik_det as t1 join tik_tik_enc as t2 on t2.id_tik= t1.id_tik ", "  t1.id_tik,id_pro,id_env_uni,tik_env_col,tik_env_obs,DATE_FORMAT(tik_env_fec, '%Y/%m/%d %H:%i:%s') as tik_env_fec,id_rec_uni,id_rec_col , DATE_FORMAT(tik_rec_fec, '%Y/%m/%d %H:%i:%s') as tik_rec_fec, t1.tik_est, tik_nom ", " where t1.tik_est = '1' and id_rec_uni = '"+Session["unidad"].ToString()+"'");
            nueva = operacion.vistageneral("pj_bitacora ", "  DISTINCT(idpj_incidente), pj_numcredito, pj_nombre, pj_fechacreacion, DATEDIFF(now(), pj_fechacreacion) AS Dias ", " ");
            string arreglo = operacion.maquetado(nueva);
            return Json(arreglo, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public ActionResult reporetegeneraldatatable(List<modelogeneral.modelox> items)
        {


            DataTable dt1 = new DataTable("Customers");


            int desiredSize = 0;

            while (dt1.Columns.Count > desiredSize)
            {
                dt1.Columns.RemoveAt(desiredSize);
            }


            for (int x = 0; x < 197; x++)

            {
                dt1.Columns.Add("t" + x);

            }





            string Agencia = "";
            string Instrumento = "";
            string LineaCredito = "";
            string destino = "";
            string Garantia = "";
            string Plazomeses = "";
            string Estado = "";
            string Tasa = "";
            string[] fecha = null;
            string FechaSolicitud = "";
            string[] fecha2 = null;
            string FechaDesembolso1 = "";
            string[] fecha3 = null;
            string FechaUltimoDes = "";
            string[] fecha4 = null;
            string FechaVencimiento = "";
            string[] fecha5 = null;
            string FechaUltimaCuota = "";
            string[] fecha6 = null;
            string FechaActa = "";
            string NumActa = "";
            string NumPrestamo = "";
            string CreditoNumero = "";
            string DPI = "";
            string CodigoCliente = "";
            string NumCif = "";
            string NombreCliente = "";
            string ClienteNombre = "";
            string MontoOriginal = "";
            string CapitalDesem = "";
            string DescripcionDoc = "";
            string NombreOficial = "";
            string NombreOficial2 = "";
            string NombreOficial3 = "";
            string SaldoActual = "";
            string Saldo1 = "";



            string[,] nueva = null;
            string[,] nuevas = null;
            inyeccion operacion = new inyeccion();
            //nueva = operacion.vistageneral(" tik_tik_det as t1 join tik_tik_enc as t2 on t2.id_tik= t1.id_tik ", "  t1.id_tik,id_pro,id_env_uni,tik_env_col,tik_env_obs,DATE_FORMAT(tik_env_fec, '%Y/%m/%d %H:%i:%s') as tik_env_fec,id_rec_uni,id_rec_col , DATE_FORMAT(tik_rec_fec, '%Y/%m/%d %H:%i:%s') as tik_rec_fec, t1.tik_est, tik_nom ", " where t1.tik_est = '1' and id_rec_uni = '"+Session["unidad"].ToString()+"'");
            // tercera etapa vacio
            nuevas = operacion.vistageneral("pj_creditosgeneral", "pj_numcredito", " ");

            for (int ra = 0; ra < nuevas.GetLength(0); ra++)
            {


                string[] vary = new string[197];




                string nnumero = "";
                nnumero = nuevas[ra, 0].ToString();

                nueva = operacion.vistageneral("pj_tipocredito ", "*", " ");

                DataRow row1 = dt1.NewRow();
                string numcredito = nnumero;
                string var1 = ws.buscarcredito(numcredito);
                char delimitador = '|';
                string[] campos = var1.Split(delimitador);

                if (var1.Length == 4)
                {
                    Response.Write("NO HAY DATOS QUE MOSTRARA");
                }
                else
                {


                    for (int i = 0; i < campos.Length; i++)
                    {
                        Agencia = campos[29];
                        Instrumento = campos[17];
                        LineaCredito = campos[18];
                        destino = campos[28];
                        Garantia = campos[22];
                        Plazomeses = campos[2];

                        Estado = campos[23];

                        Tasa = campos[13];
                        fecha = campos[3].Split(' ');
                        FechaSolicitud = fecha[0];
                        fecha2 = campos[4].Split(' ');
                        FechaDesembolso1 = fecha2[0];
                        fecha3 = campos[10].Split(' ');
                        FechaUltimoDes = fecha3[0];
                        fecha4 = campos[5].Split(' ');
                        FechaVencimiento = fecha4[0];
                        fecha5 = campos[7].Split(' ');
                        FechaUltimaCuota = fecha5[0];
                        fecha6 = campos[12].Split(' ');
                        FechaActa = fecha6[0];
                        NumActa = campos[11];
                        NumPrestamo = campos[1];
                        CreditoNumero = campos[1];
                        DPI = campos[21];
                        CodigoCliente = campos[19];
                        NumCif = campos[19];
                        NombreCliente = campos[20];
                        ClienteNombre = campos[20];
                        MontoOriginal = "Q " + campos[9];
                        CapitalDesem = "Q " + campos[9];

                        DescripcionDoc = campos[24];




                        NombreOficial = campos[25];
                        NombreOficial2 = campos[26];
                        NombreOficial3 = campos[27];

                        if (campos[8] == "            .00")
                        {
                            SaldoActual = "Q 0.00";
                            Saldo1 = "0.00";
                        }
                        else
                        {
                            SaldoActual = "Q " + campos[8];
                            Saldo1 = campos[8];
                        }
                    }

                }


                vary[0] = Agencia;
                vary[1] = Instrumento;
                vary[2] = LineaCredito;
                vary[3] = destino;
                vary[4] = Garantia;
                vary[5] = Plazomeses;
                vary[6] = Estado;
                vary[7] = Tasa;
                vary[8] = fecha[0].ToString();
                vary[9] = FechaSolicitud;
                vary[10] = FechaDesembolso1;
                vary[11] = FechaUltimoDes;
                vary[12] = FechaVencimiento;
                vary[13] = FechaUltimaCuota;
                vary[14] = FechaActa;
                vary[15] = NumActa;
                vary[16] = NumPrestamo;
                vary[17] = DPI;
                vary[18] = CodigoCliente;
                vary[19] = NombreCliente;
                vary[20] = MontoOriginal;
                vary[21] = CapitalDesem;
                vary[22] = DescripcionDoc;
                vary[23] = NombreOficial;
                vary[24] = NombreOficial2;
                vary[25] = NombreOficial3;
                vary[26] = SaldoActual;
                vary[27] = Saldo1;


                string NumIncidente = "";
                string NumeroIncidente = "";
                string NumTarjeta = "";
                string NumCuenta = "";
                string CIF = "";
                string PrimerNombre = "";
                string SegundoNombre = "";
                string OtroNombre = "";
                string ApellidoCasada = "";
                string PrimerApellido = "";
                string SegundoApellido = "";
                string Limite = "";
                string Saldo = "";
                string Gastos1 = "";
                string GastosJudiciales = "";
                string OtrosGastos = "";
                string Comentario = "";
                string Total1 = "";
                string fechaestado = "";
                string[] separarfechahora = null;
                string[] fechaestado2 = null;
                string Incendio = "";
                string Interes1 = "";
                string Mora = "";
                string FechaEstadoCuenta = "";


                string[] campos2 = sn.obtenertipocredito(numcredito);
                string idcredito = campos2[0];
                if (idcredito == null)
                {


                    string[] campos3 = sn.obtenertipotarjeta(numcredito);
                    for (int i = 0; i < campos3.Length; i++)
                    {
                        NumIncidente = campos3[0];
                        NumeroIncidente = campos3[0];
                        NumTarjeta = campos3[1];
                        NumCuenta = campos3[2];
                        CIF = campos3[3];
                        PrimerNombre = campos3[4];
                        SegundoNombre = campos3[5];
                        OtroNombre = campos3[6];
                        ApellidoCasada = campos3[7];
                        PrimerApellido = campos3[8];
                        SegundoApellido = campos3[9];
                        Limite = "Q " + campos3[10];
                        Saldo = "Q " + campos3[11];
                        Gastos1 = campos3[13];
                        GastosJudiciales = campos3[14];
                        OtrosGastos = campos3[15];
                        Comentario = campos3[16];
                        Total1 = "Q " + campos3[17];
                        fechaestado = campos3[19];
                        separarfechahora = fechaestado.Split(' ');
                        fechaestado2 = separarfechahora[0].Split('/');
                        Incendio = "pendiente";
                        Interes1 = "pendiente";
                        Mora = "pendiente";

                        if (fechaestado2[0].Length == 1)
                        {
                            FechaEstadoCuenta = fechaestado2[2] + '-' + fechaestado2[1] + '-' + "0" + fechaestado2[0];
                        }
                        else
                        {
                            FechaEstadoCuenta = fechaestado2[2] + '-' + fechaestado2[1] + '-' + fechaestado2[0];
                        }
                    }

                }
                else
                {

                    for (int i = 0; i < campos2.Length; i++)
                    {
                        NumIncidente = campos2[0];
                        NumeroIncidente = campos2[0];
                        Gastos1 = campos2[1];
                        GastosJudiciales = campos2[2];
                        OtrosGastos = campos2[3];
                        Total1 = "Q " + campos2[4];
                        Comentario = campos2[5];
                        fechaestado = campos2[8];
                        separarfechahora = fechaestado.Split(' ');
                        fechaestado2 = separarfechahora[0].Split('/');
                        Incendio = campos2[9];
                        Interes1 = campos2[10];
                        Mora = campos2[11];

                        if (fechaestado2[0].Length == 1)
                        {
                            FechaEstadoCuenta = fechaestado2[2] + '-' + fechaestado2[1] + '-' + "0" + fechaestado2[0];
                        }
                        else
                        {
                            FechaEstadoCuenta = fechaestado2[2] + '-' + fechaestado2[1] + '-' + fechaestado2[0];
                        }

                    }

                }

                vary[28] = NumIncidente;
                vary[29] = NumTarjeta;
                vary[30] = NumCuenta;
                vary[31] = CIF;
                vary[32] = PrimerNombre;
                vary[33] = SegundoNombre;
                vary[34] = OtroNombre;
                vary[35] = ApellidoCasada;
                vary[36] = PrimerApellido;
                vary[37] = SegundoApellido;
                vary[38] = Limite;
                vary[39] = Saldo;
                vary[40] = Gastos1;
                vary[41] = GastosJudiciales;
                vary[42] = OtrosGastos;
                vary[43] = Comentario;
                vary[44] = Total1;
                vary[45] = Incendio;
                vary[46] = Interes1;
                vary[47] = Mora;
                vary[48] = FechaEstadoCuenta;

                // segunda etapa 
                nueva = operacion.vistageneral("pj_certificacioncontable ", "  *", " where pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                // contador
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[49] = nueva[f, 1].ToString();
                    vary[50] = nueva[f, 2].ToString();
                    vary[51] = nueva[f, 5].ToString();




                }

                nueva = operacion.vistageneral(" pj_certificacionjuidico as t1 join pj_asignacionmedidas as t2 on t1.pj_numcredito = t2.pj_numcredito inner join pj_abogado as b on t1.idpj_abogado = b.idpj_abogado", " *", " where t1.pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[52] = nueva[f, 1].ToString();
                    vary[53] = nueva[f, 3].ToString();
                    vary[54] = nueva[f, 6].ToString();
                    vary[55] = nueva[f, 16].ToString();
                    vary[56] = nueva[f, 9].ToString();


                    switch (nueva[f, 14].ToString())
                    {
                        case "1":
                            vary[57] = vary[64] + "/" + nueva[f, 12].ToString();
                            break;
                        case "2":
                            vary[58] = vary[65] + "/" + nueva[f, 12].ToString();
                            break;

                        case "3":
                            vary[59] = vary[66] + "/" + nueva[f, 12].ToString();
                            break;
                        case "4":
                            vary[60] = vary[67] + "/" + nueva[f, 12].ToString();
                            break;

                    }



                }



                nueva = operacion.vistageneral("pj_presentaciondemanda as a inner join pj_departamento as b on a.idpj_departamento = b.idpj_departamento inner join pj_municipio as c on a.idpj_municipio = c.idpj_municipio  ", "pj_numproceso, pj_fechapresentacion, pj_oficial, idpj_notificador, pj_numjuzgado, pj_nombrejuzgado, pj_departamentonombre, pj_municipionombre ", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {

                    vary[61] = nueva[f, 0].ToString();
                    vary[62] = nueva[f, 1].ToString();
                    vary[63] = nueva[f, 2].ToString();
                    vary[64] = nueva[f, 3].ToString();
                    vary[65] = nueva[f, 4].ToString();
                    vary[66] = nueva[f, 5].ToString();
                    vary[67] = nueva[f, 6].ToString();
                    vary[68] = nueva[f, 7].ToString();


                }


                nueva = operacion.vistageneral("pj_resoluciontramite as t1 join pj_facturacionabogado as t2 on t1.pj_numcredito = t2.pj_numcredito ", "*", " where t1.pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {

                    vary[69] = nueva[f, 4].ToString();
                    vary[70] = nueva[f, 5].ToString();

                }


                nueva = operacion.vistageneral("pj_solicitudcheque as t1 join pj_bancoemisor as t2 on t1.idpj_banco = t2.idpj_bancoemisor ", "  *", " where t1.pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {
                    vary[71] = nueva[f, 3].ToString();
                    vary[72] = nueva[f, 4].ToString();
                    vary[73] = nueva[f, 6].ToString();
                    vary[74] = nueva[f, 7].ToString();
                    vary[75] = nueva[f, 10].ToString();

                }



                nueva = operacion.vistageneral("pj_sonefectivas as t1 join pj_voluntaria as t2 on t1.pj_numcredito = t2.pj_numcredito join pj_asignacionmedidas as t3 on t2.pj_numcredito = t3.pj_numcredito", "*", " where t1.pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {

                    vary[76] = nueva[f, 6].ToString();
                    vary[77] = nueva[f, 9].ToString();


                    if (nueva[f, 12].ToString() == "1")
                    {

                        vary[78] = "si es voluntario";
                    }
                    else
                    {
                        vary[78] = "no es voluntaria";

                    }



                    vary[79] = nueva[f, 13].ToString();
                    vary[80] = nueva[f, 15].ToString();
                    vary[81] = nueva[f, 16].ToString();
                    vary[82] = nueva[f, 17].ToString();
                    vary[83] = nueva[f, 20].ToString();


                }



                nueva = operacion.vistageneral("pj_voluntaria as t1 join pj_hayresultados as t2 on t1.pj_numcredito = t2.pj_numcredito join pj_gestionmedida as t3 on t2.pj_numcredito  = t3.pj_credito ", "  *", " where t1.pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {

                    //fecha presentacion
                    vary[84] = nueva[f, 2].ToString();
                    // fecha resolucion
                    vary[85] = nueva[f, 4].ToString();
                    // fecha notificacion
                    vary[86] = nueva[f, 5].ToString();
                    // observaciobes
                    vary[87] = nueva[f, 6].ToString();
                    // fecha
                    vary[88] = nueva[f, 9].ToString();
                    // hay resultado
                    vary[89] = nueva[f, 10].ToString();
                    // empresatrabajo
                    vary[90] = nueva[f, 11].ToString();
                    // fecha presentacio
                    vary[91] = nueva[f, 12].ToString();
                    // fecha sentencia 
                    vary[92] = nueva[f, 13].ToString();

                    // fecha apremio
                    vary[93] = nueva[f, 14].ToString();
                    // fecha 
                    vary[94] = nueva[f, 17].ToString();

                }


                // novena fase 
                nueva = operacion.vistageneral("pj_solicitudfacturacion as t1 join pj_aplicacionpago as t2 on t1.pj_numcredito = t2.pj_numcredito  inner join pj_bancoemisor as t3 on t3.idpj_bancoemisor = pj_banco", "idpj_solicitudfacturacion, pj_honorarios, t1.pj_fecha,idpj_aplicacionpago, pj_numcheque, pj_fechaemision, pj_numrecibo, pj_monto, pj_nombrebanco, t1.pj_fecha ", " where t1.pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {

                    vary[95] = nueva[f, 1].ToString();
                    vary[96] = nueva[f, 2].ToString();
                    vary[97] = nueva[f, 4].ToString();
                    vary[98] = nueva[f, 5].ToString();
                    vary[99] = nueva[f, 6].ToString();
                    vary[100] = nueva[f, 7].ToString();
                    vary[101] = nueva[f, 8].ToString();
                    vary[102] = nueva[f, 9].ToString();




                }


                // novena fase 
                nueva = operacion.vistageneral("pj_facturacionabogado", "  *", " where pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {

                    vary[103] = nueva[f, 3].ToString();
                    vary[104] = nueva[f, 4].ToString();
                    vary[105] = nueva[f, 5].ToString();
                    vary[106] = nueva[f, 6].ToString();
                    vary[107] = nueva[f, 7].ToString();
                    vary[108] = nueva[f, 8].ToString();
                    vary[109] = nueva[f, 10].ToString();
                    vary[110] = nueva[f, 11].ToString();
                    vary[111] = nueva[f, 12].ToString();
                    vary[112] = nueva[f, 13].ToString();
                    vary[113] = nueva[f, 14].ToString();



                }




                // novena respuesta positiva 
                nueva = operacion.vistageneral("pj_sinotificacion as t1  join pj_actitudpositiva as t2 on t1.pj_numcredito = t2.pj_numcredito", " idpj_sinotificacion, pj_fechanotificacion, pj_actituddemandado, t1.pj_fecha, idpj_actitudpositiva, pj_fechasentencia, pj_notificacionsentencia, pj_lugar, pj_observaciones ", " where t1.pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[114] = nueva[f, 1].ToString();
                    vary[115] = nueva[f, 2].ToString();
                    vary[116] = nueva[f, 3].ToString();
                    vary[117] = nueva[f, 5].ToString();
                    vary[118] = nueva[f, 6].ToString();
                    vary[119] = nueva[f, 7].ToString();
                    vary[120] = nueva[f, 8].ToString();


                }


                nueva = operacion.vistageneral("pj_actitudnegativa", " *", " where pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {



                    if (nueva[f, 1].ToString() == "1")
                    {

                        vary[121] = "Se Interpusieron excepciones";
                    }
                    else
                    {

                        vary[121] = "Se Interpusieron excepciones";

                    }
                    vary[122] = nueva[f, 2].ToString();
                    vary[123] = nueva[f, 3].ToString();
                    vary[124] = nueva[f, 4].ToString();
                    vary[125] = nueva[f, 5].ToString();
                    vary[126] = nueva[f, 6].ToString();
                    vary[127] = nueva[f, 7].ToString();
                    vary[128] = nueva[f, 8].ToString();
                    vary[129] = nueva[f, 9].ToString();


                }


                //////////////agregue nuevas tablas 
                nueva = operacion.vistageneral("pj_vehiculo", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[130] = nueva[f, 1].ToString();
                    vary[131] = nueva[f, 2].ToString();
                    vary[132] = nueva[f, 3].ToString();
                    vary[133] = nueva[f, 4].ToString();


                }



                nueva = operacion.vistageneral("pj_bienesinmuebles", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[134] = nueva[f, 1].ToString();
                    vary[135] = nueva[f, 2].ToString();
                    vary[136] = nueva[f, 3].ToString();


                }

                nueva = operacion.vistageneral("pj_sonefectivas", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[137] = nueva[f, 1].ToString();
                    vary[138] = nueva[f, 2].ToString();
                    vary[139] = nueva[f, 3].ToString();
                    vary[140] = nueva[f, 4].ToString();
                    vary[141] = nueva[f, 5].ToString();
                    vary[142] = nueva[f, 6].ToString();
                    vary[143] = nueva[f, 9].ToString();
                    vary[144] = nueva[f, 10].ToString();


                }


                nueva = operacion.vistageneral("pj_sinotificacioneva", "  *", " where pj_numcredito = '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[145] = nueva[f, 1].ToString();
                    vary[146] = nueva[f, 2].ToString();
                    vary[147] = nueva[f, 3].ToString();
                    vary[148] = nueva[f, 4].ToString();
                    vary[149] = nueva[f, 5].ToString();
                    vary[150] = nueva[f, 6].ToString();
                    vary[151] = nueva[f, 9].ToString();


                }



                nueva = operacion.vistageneral("pj_nonotificacioneva", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[152] = nueva[f, 1].ToString();
                    vary[153] = nueva[f, 2].ToString();
                    vary[154] = nueva[f, 3].ToString();
                    vary[155] = nueva[f, 4].ToString();
                    vary[156] = nueva[f, 5].ToString();
                    vary[157] = nueva[f, 6].ToString();
                    vary[158] = nueva[f, 7].ToString();
                    vary[159] = nueva[f, 8].ToString();
                    vary[160] = nueva[f, 9].ToString();
                    vary[161] = nueva[f, 12].ToString();


                }

                nueva = operacion.vistageneral("pj_desistimiento", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {


                    vary[162] = nueva[f, 1].ToString();
                    vary[163] = nueva[f, 2].ToString();
                    vary[164] = nueva[f, 4].ToString();
                }


                nueva = operacion.vistageneral("pj_solicitudnotificacion", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {
                    vary[165] = nueva[f, 1].ToString();
                    vary[166] = nueva[f, 2].ToString();
                    vary[167] = nueva[f, 4].ToString();

                }

                //////////// nuevas tablas 
                nueva = operacion.vistageneral("pj_solicitudhonorario", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {
                    vary[168] = nueva[f, 1].ToString();
                    vary[169] = nueva[f, 2].ToString();
                    vary[170] = nueva[f, 4].ToString();

                }


                nueva = operacion.vistageneral("pj_segundanotificacioneva", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {
                    vary[171] = nueva[f, 1].ToString();
                    vary[172] = nueva[f, 2].ToString();
                    vary[173] = nueva[f, 4].ToString();

                }



                nueva = operacion.vistageneral("pj_reporteabogado", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {
                    vary[174] = nueva[f, 2].ToString();
                    vary[175] = nueva[f, 6].ToString();


                }

                nueva = operacion.vistageneral("pj_audenciaremate", "  *", " where pj_numcredito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {
                    vary[176] = nueva[f, 1].ToString();
                    vary[177] = nueva[f, 2].ToString();
                    vary[178] = nueva[f, 3].ToString();
                    vary[179] = nueva[f, 4].ToString();
                    vary[180] = nueva[f, 5].ToString();
                    vary[181] = nueva[f, 6].ToString();
                    vary[182] = nueva[f, 7].ToString();
                    vary[183] = nueva[f, 8].ToString();
                    vary[184] = nueva[f, 9].ToString();
                    vary[185] = nueva[f, 10].ToString();
                    vary[186] = nueva[f, 11].ToString();
                    vary[187] = nueva[f, 12].ToString();
                    vary[188] = nueva[f, 13].ToString();
                    vary[189] = nueva[f, 14].ToString();
                    vary[190] = nueva[f, 15].ToString();
                    vary[191] = nueva[f, 16].ToString();
                    vary[192] = nueva[f, 17].ToString();
                    vary[193] = nueva[f, 18].ToString();
                    vary[194] = nueva[f, 19].ToString();
                    vary[195] = nueva[f, 22].ToString();



                }



                nueva = operacion.vistageneral("pj_etapa_credito", "MAX(idpj_etapa)+ 1", " where idpj_credito= '" + numcredito + "'");
                row1 = dt1.NewRow();
                for (int f = 0; f < nueva.GetLength(0); f++)
                {
                    string idx =  nueva[f, 0].ToString();

                    string[,] nueva2 = operacion.vistageneral("pj_etapacatalogo  ", "  pj_etapanombre ", " where idpj_etapacatalogo= '" + idx + "'");
                    row1 = dt1.NewRow();
                    for (int f2 = 0; f2 < nueva2.GetLength(0); f2++)
                    {
                        vary[196] = nueva2[f2, 0].ToString();
                        string valor = vary[196];



                    }




                }


                for (int x = 0; x < 197; x++)

                {

                    row1["t" + x] = vary[x];
                }

                dt1.Rows.Add(row1);

            }




            nueva2 = new string[dt1.Rows.Count, 197];
            for (int ss = 0; ss < dt1.Rows.Count; ss++)

            {

                for (int ss1 = 0; ss1 < 197; ss1++)
                {

                    nueva2[ss, ss1] = dt1.Rows[ss]["t" + ss1].ToString();

                }


            }


            string arreglo = operacion.maquetado(nueva2);
            return Json(arreglo, JsonRequestBehavior.AllowGet);

        }



        public FileResult Download2()
        {

            DataTable dt = new DataTable("Page");
            dt.Columns.AddRange(new DataColumn[197]
            {



                        new DataColumn("1 Agencia"),
                        new DataColumn("2 Instrumento"),
                        new DataColumn("3 Línea de crédito"),
                        new DataColumn("4 Destino"),
                        new DataColumn("5 Garantía"),
                        new DataColumn("6 Plazo en meses"),
                        new DataColumn("7 Estado"),
                        new DataColumn("8 Tasa Q"),
                        new DataColumn("9 Fecha solicitud"),
                        new DataColumn("10 Fecha 1er. desembolso"),
                        new DataColumn("11 Fecha de acta"),
                        new DataColumn("12 Fecha Último Desembolso"),
                        new DataColumn("13 Fecha desembolso"),
                        new DataColumn("14 Fecha Última Cuota"),
                        new DataColumn("15 Fecha Acta"),
                        new DataColumn("16 No. Acta"),
                        new DataColumn("17 No.Crédito"),


                        new DataColumn("18 DPI"),
                        new DataColumn("19 Codigo Cliente"),


                        new DataColumn("20 Nombre Cliente"),


                        new DataColumn("21 Monto Original"),
                        new DataColumn("22 Capital Desembolsado"),
                        new DataColumn("23 Descripción Documento"),

                        new DataColumn("24 Nombre Oficial 1"),
                        new DataColumn("25 Nombre Oficial 2"),
                        new DataColumn("26 Nombre Oficial 3"),
                        new DataColumn("27 Saldo Actual"),
                        new DataColumn("28 Saldo capital"),


                        new DataColumn("29 No. Incidente"),
                        new DataColumn("30 No. Tarjeta"),
                        new DataColumn("31 No. Cuenta"),
                        new DataColumn("32 CIF"),





                        new DataColumn("33 Primer Nombre"),
                        new DataColumn("34 Segundo Nombre"),
                        new DataColumn("35 Otro Nombre"),
                        new DataColumn("36 Apellido Casada"),
                        new DataColumn("37 Primer Apellido"),


                        new DataColumn("38 Segundo Apellido"),
                        new DataColumn("39 Limite"),
                        new DataColumn("40 Saldo"),
                        new DataColumn("41 Gastos cobranza"),
                        new DataColumn("42 Seguro"),


                        new DataColumn("43 OtrosGastos"),
                        new DataColumn("44 Comentario"),
                        new DataColumn("45 Total"),


                        new DataColumn("46 Incendio"),
                        new DataColumn("47 Intereses "),
                        new DataColumn("48 Mora"),
                        new DataColumn("49 Fecha Estado Cuenta"),
                        new DataColumn("50 No. Registro"),
                        new DataColumn("51 Contador General"),



                        new DataColumn("52 Observaciones"),
                        new DataColumn("53 No. Colegiado"),
                        new DataColumn("54 Tipo proceso"),
                        new DataColumn("55 Fecha asignación abogado"),
                        new DataColumn("56 Nombre abogado"),
                        new DataColumn("57 Observaciones "),

                        new DataColumn("58 Medidas obligatorias"),
                        new DataColumn("59 Medidas solicitadas"),
                        new DataColumn("60 Medidas otorgadas"),

                        new DataColumn("61 Medidas autorizadas"),


                        new DataColumn("62 No. proceso"),
                        new DataColumn("63 Fecha presentación demanda"),
                        new DataColumn("64 Oficial"),


                        new DataColumn("65 Notificador"),
                        new DataColumn("66 No. Juzgado"),
                        new DataColumn("67 Nombre Juzgado"),
                        new DataColumn("68 departamento"),
                        new DataColumn("69 municipio"),


                        new DataColumn("70 Motivo rechazo"),
                        new DataColumn("71 fecha notificación"),



                        new DataColumn("72 número de cheque"),
                        new DataColumn("73 fecha emisión cheque"),


                        new DataColumn("74 Observaciones"),
                        new DataColumn("75 Monto cheque"),
                        new DataColumn("76 Nombre del banco"),

                        new DataColumn("77 fecha oficio migración"),
                        new DataColumn("78 Fecha "),



                        new DataColumn("79 voluntaria"),

                        new DataColumn("80 Fecha presentación"),
                        new DataColumn("81 Fecha resolución"),

                        new DataColumn("82 fecha notificación"),

                        new DataColumn("83 observaciones"),
                        new DataColumn("84 fecha"),



                        new DataColumn("85 Fecha presentación"),
                        new DataColumn("86 Fecha resolución"),
                        new DataColumn("87 fecha notificaciòn"),
                        new DataColumn("88 observaciones"),
                        new DataColumn("89 fecha"),
                        new DataColumn("90 hay resultados"),
                        new DataColumn("91 empresa trabajo"),
                        new DataColumn("92 fecha presentación"),
                        new DataColumn("93 fecha sentencia"),
                        new DataColumn("94 fecha apremio"),
                        new DataColumn("95 fecha"),


                        new DataColumn("96 honorarios"),
                        new DataColumn("97 fecha"),
                        new DataColumn("98 No. cheque"),
                        new DataColumn("99 fecha emisión"),
                        new DataColumn("100 No. recibo"),
                        new DataColumn("101 Monto"),
                        new DataColumn("102 Banco"),
                        new DataColumn("103 Fecha "),


                        new DataColumn("104 No. factura"),
                        new DataColumn("105 No. serie"),
                        new DataColumn("106 descripción"),
                        new DataColumn("107 importe total"),
                        new DataColumn("108 fecha emosión factura"),
                        new DataColumn("109 importe del caso"),
                        new DataColumn("110 motivo de pago"),
                        new DataColumn("111 cif"),
                        new DataColumn("112 nombre asociado"),
                        new DataColumn("113 nombre emite cheque"),
                        new DataColumn("114 observaciones"),



                        new DataColumn("115 fecha notificación"),
                        new DataColumn("116 actitud demandado"),
                        new DataColumn("117 fecha "),
                        new DataColumn("118 fecha sentencia"),
                        new DataColumn("119 notificación de la sentencia"),
                        new DataColumn("120 lugar"),
                        new DataColumn("121 observaciones"),


                        new DataColumn("122 excepciones"),
                        new DataColumn("123 fecha resolución excepciones"),
                        new DataColumn("124 fecha de apertura"),
                        new DataColumn("125 observaciones"),
                        new DataColumn("126 fecha de la vista"),
                        new DataColumn("127 fecha de sentencia"),
                        new DataColumn("128 notificacion de sentencia"),
                        new DataColumn("129 lugar"),
                        new DataColumn("130 observaciones"),



                        new DataColumn("131 nit"),
                        new DataColumn("132 placa"),
                        new DataColumn("133 mdelo"),
                        new DataColumn("134 marca"),


                        new DataColumn("135 finca"),
                        new DataColumn("136 folio"),
                        new DataColumn("137 libro"),


                        new DataColumn("138 nombre banco"),
                        new DataColumn("139 monto"),
                        new DataColumn("140 nombre cooperativa"),
                        new DataColumn("141 monto"),
                        new DataColumn("142 lugar de trabajo"),
                        new DataColumn("143 fecha presentación oficio a migración"),
                        new DataColumn("144 fecha"),
                        new DataColumn("145 fecha presentación a trabajo"),


                        new DataColumn("146 fecha solicitud edictos"),
                        new DataColumn("147 monto"),
                        new DataColumn("148 descripción"),
                        new DataColumn("149 fecha publicación 1"),
                        new DataColumn("150 fecha publicación 2"),
                        new DataColumn("151 fecha publicación 3"),
                        new DataColumn("152 fecha"),


                        new DataColumn("153 fecha intento nootificación 1"),
                        new DataColumn("154 fecha intento nootificación 2"),
                        new DataColumn("155 fecha intento nootificación 3"),
                        new DataColumn("156 fecha solicitud de nombramiento de notario "),
                        new DataColumn("157 nombre notario propuesto"),
                        new DataColumn("158 No. colegiado de notario propuesto"),
                        new DataColumn("159 fecha de resolución de nombramiento de notario"),
                        new DataColumn("160 fecha notificaón de resolución"),
                        new DataColumn("161 notificacion al asociado"),
                        new DataColumn("162 fecha"),


                        new DataColumn("163 fecha presentación de desistimiento"),
                        new DataColumn("164 fecha resolución del desistimiento"),
                        new DataColumn("165 fecha"),

                        new DataColumn("166 monto"),
                        new DataColumn("167 nombre a quien dirige el cheque"),
                        new DataColumn("168 fecha"),

                        new DataColumn("169 total"),
                        new DataColumn("170 nombre a quien dirige el cheque"),
                        new DataColumn("171 fecha"),

                        new DataColumn("172 fecha acta notarial de notificación"),
                        new DataColumn("173 fecha memorarial de acta notarial de notificación"),
                        new DataColumn("174 fecha"),

                        new DataColumn("175 fecha entrega fisica expedientes"),
                        new DataColumn("176 observaciones"),


                        new DataColumn("177 fecha acta notaria de notificaciòn "),
                        new DataColumn("178 fecha memorial acta notarial de notificación"),
                        new DataColumn("179 fecha resolución acta notarial de notificación"),
                        new DataColumn("180 fecha de remate"),
                        new DataColumn("181 observaciones remate "),
                        new DataColumn("182 adjudicado"),
                        new DataColumn("183 monto"),
                        new DataColumn("184 fecha presentación memorial proyecto liquidación"),
                        new DataColumn("185 fecha resolución memorial proyecto liquidación"),
                        new DataColumn("186 fecha notificación resolución liquidación"),
                        new DataColumn("187 fecha presentación de memorail para nombrar notario cartulante"),
                        new DataColumn("188 nombre del notario "),
                        new DataColumn("189 No. colegiado notario"),
                        new DataColumn("190 fecha resolución de memorail para nombrar notario cartulante"),
                        new DataColumn("191 fecha notificación de resolución para nombrar notario"),
                        new DataColumn("192 No. escritura"),
                        new DataColumn("193 fecha de la escritura"),
                        new DataColumn("194 honorario de registro"),
                        new DataColumn("195 honorario impuesto"),
                        new DataColumn("196 fecha"),
                        new DataColumn("197 etapa actual")








            });

            DataRow workRow = dt.NewRow();
            for (int i = 0; i < nueva2.GetLength(0); i++)
            {

                workRow = dt.NewRow();


                for (int x = 0; x <= 196; x++)
                {

                    var datox = nueva2[i, x].ToString();
                    workRow[x] = datox;

                }





                dt.Rows.Add(workRow);

            }



            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Reporte_general_juridico" + DateTime.Now.Year + "" + DateTime.Now.Day + ".xlsx");
                }
            }
        }


    }
}