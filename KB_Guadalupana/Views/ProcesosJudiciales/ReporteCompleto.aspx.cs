using System;
using System.Data;
using KB_Guadalupana.Controllers;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace KB_Guadalupana.Views.ProcesosJudiciales
{
    public partial class ReporteCompleto : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient WS = new ServiceReference1.WebService1SoapClient();
        Sentencia_juridico sn = new Sentencia_juridico();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Generar_Click(object sender, EventArgs e)
        {
            ReporteCompleto2.Reset();
            ReportDataSource fuente = new ReportDataSource("TablaGeneral", obtenerdatos());
            ReporteCompleto2.LocalReport.DataSources.Add(fuente);
            ReporteCompleto2.LocalReport.ReportPath = "Views/ProcesosJudiciales/Reportes/Reporte_general_juridico.rdlc";
            ReporteCompleto2.LocalReport.Refresh();
        }

        private DataTable obtenerdatos()
        {
            DataTable datosBW = new DataTable("datosBW");
            DataTable datosSistema = new DataTable();
            DataTable datosCompletos = new DataTable();

            datosCompletos.Columns.Add("INCIDENTE");
            datosCompletos.Columns.Add("CREDITO");
            datosCompletos.Columns.Add("NOMBRE");
            datosCompletos.Columns.Add("FECHA_CREACION");
            datosCompletos.Columns.Add("TIPO_CREDITO");
            datosCompletos.Columns.Add("AGENCIA");
            datosCompletos.Columns.Add("INSTRUMENTO");
            datosCompletos.Columns.Add("LINEA");
            datosCompletos.Columns.Add("DESTINO");
            datosCompletos.Columns.Add("GARANTIA");
            datosCompletos.Columns.Add("PLAZO");
            datosCompletos.Columns.Add("ESTADO");
            datosCompletos.Columns.Add("TASA");
            datosCompletos.Columns.Add("FECHA_SOLICITUD");
            datosCompletos.Columns.Add("FECHA_PRIMER_DESEMBOLSO");
            datosCompletos.Columns.Add("FECHA_ULTIMO_DESEMBOLSO");
            datosCompletos.Columns.Add("FECHA_VENCIMIENTO");
            datosCompletos.Columns.Add("FECHA_ULTIMA_CUOTA");
            datosCompletos.Columns.Add("NO_ACTA");
            datosCompletos.Columns.Add("DPI");
            datosCompletos.Columns.Add("CIF");
            datosCompletos.Columns.Add("MONTO_ORIGINAL");
            datosCompletos.Columns.Add("CAPITAL_DESEMBOLSADO");
            datosCompletos.Columns.Add("DESCRIPCION_DOCUMENTO");
            datosCompletos.Columns.Add("NOMBRE_OFICIAL1");
            datosCompletos.Columns.Add("NOMBRE_OFICIAL2");
            datosCompletos.Columns.Add("NOMBRE_OFICIAL3");
            datosCompletos.Columns.Add("SALDO_ACTUAL");
            datosCompletos.Columns.Add("SALDO_CAPITAL");
            datosCompletos.Columns.Add("GASTOS_COBRANZA");
            datosCompletos.Columns.Add("SEGURO");
            datosCompletos.Columns.Add("OTROS_GASTOS");
            datosCompletos.Columns.Add("TOTAL");
            datosCompletos.Columns.Add("COMENTARIO");
            datosCompletos.Columns.Add("FECHA_ESTADO_CUENTA");
            datosCompletos.Columns.Add("INCENDIO");
            datosCompletos.Columns.Add("INTERESES");
            datosCompletos.Columns.Add("MORA");
            datosCompletos.Columns.Add("NO_TARJETA");
            datosCompletos.Columns.Add("CUENTA");
            datosCompletos.Columns.Add("CIF2");
            datosCompletos.Columns.Add("PRIMER_NOMBRE");
            datosCompletos.Columns.Add("SEGUNDO_NOMBRE");
            datosCompletos.Columns.Add("OTRO_NOMBRE");
            datosCompletos.Columns.Add("APELLIDO_CASADA");
            datosCompletos.Columns.Add("PRIMER_APELLIDO");
            datosCompletos.Columns.Add("SEGUNDO_APELLIDO");
            datosCompletos.Columns.Add("LIMITE");
            datosCompletos.Columns.Add("SALDO");
            datosCompletos.Columns.Add("GASTOS_COBRANZA2");
            datosCompletos.Columns.Add("SEGURO2");
            datosCompletos.Columns.Add("OTROS_GASTOS2");
            datosCompletos.Columns.Add("COMENTARIO2");
            datosCompletos.Columns.Add("TOTAL2");
            datosCompletos.Columns.Add("FECHA_ESTADO_CUENTA2");
            datosCompletos.Columns.Add("INCENDIO2");
            datosCompletos.Columns.Add("INTERESES2");
            datosCompletos.Columns.Add("MORA2");
            datosCompletos.Columns.Add("NO_REGISTRADO");
            datosCompletos.Columns.Add("CONTADOR");
            datosCompletos.Columns.Add("OBSERVACIONES2");
            datosCompletos.Columns.Add("TIPO_PROCESO");
            datosCompletos.Columns.Add("FECHA_ASIGNACION_ABOGADO");
            datosCompletos.Columns.Add("NOMBRE_ABOGADO");
            datosCompletos.Columns.Add("OBSERVACIONES3");
            datosCompletos.Columns.Add("NO_PROCESO");
            datosCompletos.Columns.Add("FECHA_PRESENTACION_DEMANDA");
            datosCompletos.Columns.Add("NO_JUZGADO");
            datosCompletos.Columns.Add("NOMBRE_JUZGADO");
            datosCompletos.Columns.Add("OFICIAL");
            datosCompletos.Columns.Add("NOTIFICADOR");
            datosCompletos.Columns.Add("DEPARTAMENTO");
            datosCompletos.Columns.Add("MUNICIPIO");
            datosCompletos.Columns.Add("ESTADO_DEMANDA");
            datosCompletos.Columns.Add("MOTIVO_RECHAZO");
            datosCompletos.Columns.Add("FECHA_NOTIFICACION");
            datosCompletos.Columns.Add("BANCO");
            datosCompletos.Columns.Add("MONTO");
            datosCompletos.Columns.Add("COOPERATIVA");
            datosCompletos.Columns.Add("MONTO2");
            datosCompletos.Columns.Add("TRABAJO");
            datosCompletos.Columns.Add("FECHA_OFICIO_MIGRACION");
            datosCompletos.Columns.Add("FECHA");
            datosCompletos.Columns.Add("FECHA_OFICIO_TRABAJO");
            datosCompletos.Columns.Add("VOLUNTARIA");
            datosCompletos.Columns.Add("FECHA_PRESENTACION");
            datosCompletos.Columns.Add("MONTO3");
            datosCompletos.Columns.Add("FECHA_RESOLUCION");
            datosCompletos.Columns.Add("FECHA_NOTIFICACION2");
            datosCompletos.Columns.Add("OBSERVACIONES4");
            datosCompletos.Columns.Add("FECHA3");
            datosCompletos.Columns.Add("TRABAJO2");
            datosCompletos.Columns.Add("FECHA_PRESENTACION_MEMORIAL");
            datosCompletos.Columns.Add("FECHA_SOLICITUD_SENTENCIA");
            datosCompletos.Columns.Add("FECHA_DEMANDA_APREMIO");
            datosCompletos.Columns.Add("FECHA4");
            datosCompletos.Columns.Add("NO_FACTURA");
            datosCompletos.Columns.Add("NO_SERIE");
            datosCompletos.Columns.Add("DESCRIPCION");
            datosCompletos.Columns.Add("IMPORTE_TOTAL");
            datosCompletos.Columns.Add("FECHA_EMISION_FACTURA");
            datosCompletos.Columns.Add("IMPORTE_CASO");
            datosCompletos.Columns.Add("MOTIVO_DE_PAGO");
            datosCompletos.Columns.Add("FECHA_PRESENTACION_JUZGADO");
            datosCompletos.Columns.Add("HONORARIOS");
            datosCompletos.Columns.Add("NO_CHEQUE");
            datosCompletos.Columns.Add("FECHA_EMISION_CHEQUE");
            datosCompletos.Columns.Add("NO_RECIBO");
            datosCompletos.Columns.Add("MONTO4");
            datosCompletos.Columns.Add("BANCO2");
            datosCompletos.Columns.Add("FECHA5");
            datosCompletos.Columns.Add("FECHA_NOTIFICACION3");
            datosCompletos.Columns.Add("ACTITUD");
            datosCompletos.Columns.Add("FECHA6");
            datosCompletos.Columns.Add("FECHA_SENTENCIA4");
            datosCompletos.Columns.Add("NOTIFICACION_SENTENCIA");
            datosCompletos.Columns.Add("LUGAR");
            datosCompletos.Columns.Add("OBSERVACIONES5");
            datosCompletos.Columns.Add("FECHA7");
            datosCompletos.Columns.Add("EXCEPCIONES");
            datosCompletos.Columns.Add("FECHA_RESOLUCION_EXCEPCIONES");
            datosCompletos.Columns.Add("FECHA_DE_APERTURA");
            datosCompletos.Columns.Add("OBSERVACIONES6");
            datosCompletos.Columns.Add("FECHA_VISTA");
            datosCompletos.Columns.Add("FECHA_SENTENCIA");
            datosCompletos.Columns.Add("FECHA_NOTIFICACION_SENTENCIA");
            datosCompletos.Columns.Add("LUGAR2");
            datosCompletos.Columns.Add("OBSERVACIONES7");
            datosCompletos.Columns.Add("FECHA8");
            datosCompletos.Columns.Add("NIT");
            datosCompletos.Columns.Add("PLACA");
            datosCompletos.Columns.Add("MODELO");
            datosCompletos.Columns.Add("MARCA");
            datosCompletos.Columns.Add("FINCA");
            datosCompletos.Columns.Add("FOLIO");
            datosCompletos.Columns.Add("LIBRO");
            datosCompletos.Columns.Add("FECHA_SOLICITUD_EDICTOS");
            datosCompletos.Columns.Add("MONTO5");
            datosCompletos.Columns.Add("DESCRIPCION2");
            datosCompletos.Columns.Add("FECHA_PUBLICACION1");
            datosCompletos.Columns.Add("FECHA_PUBLICACION2");
            datosCompletos.Columns.Add("FECHA_PUBLICACION3");
            datosCompletos.Columns.Add("FECHA9");
            datosCompletos.Columns.Add("FECHA_INTENTO_NOTIFICACION1");
            datosCompletos.Columns.Add("FECHA_INTENTO_NOTIFICACION2");
            datosCompletos.Columns.Add("FECHA_INTENTO_NOTIFICACION3");
            datosCompletos.Columns.Add("FECHA_SOLICITUD_NOMBRAMIENTO_NOTARIO");
            datosCompletos.Columns.Add("NOTARIO_PROPUESTO");
            datosCompletos.Columns.Add("COLEGIADO_NOTARIO_PROPUESTO");
            datosCompletos.Columns.Add("FECHA_RESOLUCIÓN_NOMBRAMIENTO_NOTARIO");
            datosCompletos.Columns.Add("FECHA_NOTIFICACION_RESOLUCION");
            datosCompletos.Columns.Add("NOTIFICACION_AL_ASOCIADO");
            datosCompletos.Columns.Add("FECHA10");
            datosCompletos.Columns.Add("FECHA_PRESENTACION_DESISTIMIENTO");
            datosCompletos.Columns.Add("FECHA_RESOLUCION_DESISTIMIENTO");
            datosCompletos.Columns.Add("FECHA11");
            datosCompletos.Columns.Add("MONTO6");
            datosCompletos.Columns.Add("NOMBRE_CHEQUE");
            datosCompletos.Columns.Add("FECHA12");
            datosCompletos.Columns.Add("TOTAL4");
            datosCompletos.Columns.Add("NOMBRE_CHEQUE2");
            datosCompletos.Columns.Add("FECHA15");
            datosCompletos.Columns.Add("FECHA_ACTA_NOTARIAL_NOTIFICACION");
            datosCompletos.Columns.Add("FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACIÓN");
            datosCompletos.Columns.Add("FECHA13");
            datosCompletos.Columns.Add("FECHA_ENTREGA_FISICA_EXPEDIENTE");
            datosCompletos.Columns.Add("OBSERVACIONES8");
            datosCompletos.Columns.Add("FECHA_ACTA_NOTARIAL_NOTIFICACION2");
            datosCompletos.Columns.Add("FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACION2");
            datosCompletos.Columns.Add("FECHA_RESOLUCIÓN_ACTA_NOTARIAL_NOTIFICACION");
            datosCompletos.Columns.Add("FECHA_REMATE");
            datosCompletos.Columns.Add("OBSERVACIONES_REMATE");
            datosCompletos.Columns.Add("ADJUDICADO");
            datosCompletos.Columns.Add("MONTO7");
            datosCompletos.Columns.Add("FECHA_MEMORIAL_PROYECTO_LIQUIDACION3");
            datosCompletos.Columns.Add("FECHA_RESOLUCION_PROYECTO_LIQUIDACION");
            datosCompletos.Columns.Add("FECHA_NOTIFICACION_RESOLUCION_LIQUIDACION");
            /*datosCompletos.Columns.Add("FECHA_MEMORIAL_PARA_NOMBRAR_NOTARIO_CARTULANTE")*/;
            datosCompletos.Columns.Add("NOTARIO");
            datosCompletos.Columns.Add("COLEGIADO_NOTARIO");
            datosCompletos.Columns.Add("FECHA_RESOLUCIÓN_PARA_NOMBRAR_NOTARIO_CARTULANTE");
            datosCompletos.Columns.Add("FECHA_NOTIFICACION_RESOLUCION_NOTARIO");
            datosCompletos.Columns.Add("NO_ESCRITURA");
            datosCompletos.Columns.Add("FECHA_ESCRITURA");
            datosCompletos.Columns.Add("HONORARIO_DE_REGISTRO");
            datosCompletos.Columns.Add("HONORARIO_IMPUESTO");
            datosCompletos.Columns.Add("FECHA14");
            datosCompletos.Columns.Add("ETAPA_ACTUAL");
            datosCompletos.Columns.Add("MEDIDAS_OBLIGATORIAS");
            datosCompletos.Columns.Add("MEDIDAS_SOLICITADAS");
            datosCompletos.Columns.Add("MEDIDAS_OTORGADAS");
            datosCompletos.Columns.Add("MEDIDAS_AUTORIZADAS");

            datosSistema = sn.datosReporteGeneral();
            

            for (int i = 0; i < datosSistema.Rows.Count; i++)
            {
                string d1 = "";
                string d2 = "";
                string tipocredito = "";
                //d1 = datosBW.Rows[i]["COLNUMDOCUMEN"].ToString();
                d2 = datosSistema.Rows[i]["CREDITO"].ToString();
                tipocredito = datosSistema.Rows[i]["TIPO_CREDITO"].ToString();
                datosBW = WS.buscarcreditoTabla(d2);
                
                    var fila = datosCompletos.NewRow();
                if(tipocredito == "Tarjeta")
                {
                    fila["INCIDENTE"] = datosSistema.Rows[i]["INCIDENTE"];
                    fila["CREDITO"] = datosSistema.Rows[i]["CREDITO"];
                    fila["NOMBRE"] = datosSistema.Rows[i]["NOMBRE"];
                    fila["FECHA_CREACION"] = datosSistema.Rows[i]["FECHA_CREACION"];
                    fila["TIPO_CREDITO"] = datosSistema.Rows[i]["TIPO_CREDITO"];
                    fila["AGENCIA"] = "";
                    fila["INSTRUMENTO"] = "";
                    fila["LINEA"] = "";
                    fila["DESTINO"] = "";
                    fila["GARANTIA"] = "";
                    fila["PLAZO"] = "";
                    fila["ESTADO"] = "";
                    fila["TASA"] = "";
                    fila["FECHA_SOLICITUD"] = "";
                    fila["FECHA_PRIMER_DESEMBOLSO"] = "";
                    fila["FECHA_ULTIMO_DESEMBOLSO"] = "";
                    fila["FECHA_VENCIMIENTO"] = "";
                    fila["FECHA_ULTIMA_CUOTA"] = "";
                    fila["NO_ACTA"] = "";
                    fila["DPI"] = "";
                    fila["CIF"] = "";
                    fila["MONTO_ORIGINAL"] = "";
                    fila["CAPITAL_DESEMBOLSADO"] = "";
                    fila["DESCRIPCION_DOCUMENTO"] = "";
                    fila["NOMBRE_OFICIAL1"] = "";
                    fila["NOMBRE_OFICIAL2"] = "";
                    fila["NOMBRE_OFICIAL3"] = "";
                    fila["SALDO_ACTUAL"] = "";
                    fila["SALDO_CAPITAL"] = "";
                }
                else
                {
                    fila["INCIDENTE"] = datosSistema.Rows[i]["INCIDENTE"];
                    fila["CREDITO"] = datosSistema.Rows[i]["CREDITO"];
                    fila["NOMBRE"] = datosSistema.Rows[i]["NOMBRE"];
                    fila["FECHA_CREACION"] = datosSistema.Rows[i]["FECHA_CREACION"];
                    fila["TIPO_CREDITO"] = datosSistema.Rows[i]["TIPO_CREDITO"];
                    fila["AGENCIA"] = datosBW.Rows[0]["FINDESAREAFIN"];
                    fila["INSTRUMENTO"] = datosBW.Rows[0]["COLDESINSTRUM"];
                    fila["LINEA"] = datosBW.Rows[0]["COLDESLINCRED"];
                    fila["DESTINO"] = datosBW.Rows[0]["FINDESSECTOR"];
                    fila["GARANTIA"] = datosBW.Rows[0]["GARDESTIPOGAR"];
                    fila["PLAZO"] = datosBW.Rows[0]["plazoenmeses"];
                    fila["ESTADO"] = datosBW.Rows[0]["COLDESCESTADO"];
                    fila["TASA"] = datosBW.Rows[0]["COLTASAMORA"];
                    fila["FECHA_SOLICITUD"] = datosBW.Rows[0]["COLFCHSOLICIT"];
                    fila["FECHA_PRIMER_DESEMBOLSO"] = datosBW.Rows[0]["COLFCH1ERDESE"];
                    fila["FECHA_ULTIMO_DESEMBOLSO"] = datosBW.Rows[0]["COLFCHULTDESE"];
                    fila["FECHA_VENCIMIENTO"] = datosBW.Rows[0]["COLFCHVENCIMI"];
                    fila["FECHA_ULTIMA_CUOTA"] = datosBW.Rows[0]["COLFCHULTCUOT"];
                    fila["NO_ACTA"] = datosBW.Rows[0]["COLPUNTOACTA"];
                    fila["DPI"] = datosBW.Rows[0]["CIFDOCIDENT06"];
                    fila["CIF"] = datosBW.Rows[0]["CIFCODCLIENTE"];
                    fila["MONTO_ORIGINAL"] = datosBW.Rows[0]["MONTOORI"];
                    fila["CAPITAL_DESEMBOLSADO"] = datosBW.Rows[0]["MONTOORI"];
                    fila["DESCRIPCION_DOCUMENTO"] = datosBW.Rows[0]["COLDESTIPODOC"];
                    fila["NOMBRE_OFICIAL1"] = datosBW.Rows[0]["FINNOMEJECUTI"];
                    fila["NOMBRE_OFICIAL2"] = datosBW.Rows[0]["FINNOMEJECUTI"];
                    fila["NOMBRE_OFICIAL3"] = datosBW.Rows[0]["FINNOMEJECUTI"];
                    fila["SALDO_ACTUAL"] = datosBW.Rows[0]["SALDOACT"];
                    fila["SALDO_CAPITAL"] = datosBW.Rows[0]["SALDOACT"];
                }

                    
                    fila["GASTOS_COBRANZA"] = datosSistema.Rows[i]["GASTOS_COBRANZA"];
                    fila["SEGURO"] = datosSistema.Rows[i]["SEGURO"];
                    fila["OTROS_GASTOS"] = datosSistema.Rows[i]["OTROS_GASTOS"];
                    fila["TOTAL"] = datosSistema.Rows[i]["TOTAL"];
                    fila["COMENTARIO"] = datosSistema.Rows[i]["COMENTARIO"];
                    fila["FECHA_ESTADO_CUENTA"] = datosSistema.Rows[i]["FECHA_ESTADO_CUENTA"];
                    fila["INCENDIO"] = datosSistema.Rows[i]["INCENDIO"];
                    fila["INTERESES"] = datosSistema.Rows[i]["INTERESES"];
                    fila["MORA"] = datosSistema.Rows[i]["MORA"];
                    fila["NO_TARJETA"] = datosSistema.Rows[i]["NO_TARJETA"];
                    fila["CUENTA"] = datosSistema.Rows[i]["CUENTA"];
                    fila["CIF2"] = datosSistema.Rows[i]["CIF2"];
                    fila["PRIMER_NOMBRE"] = datosSistema.Rows[i]["PRIMER_NOMBRE"];
                    fila["SEGUNDO_NOMBRE"] = datosSistema.Rows[i]["SEGUNDO_NOMBRE"];
                    fila["OTRO_NOMBRE"] = datosSistema.Rows[i]["OTRO_NOMBRE"];
                    fila["APELLIDO_CASADA"] = datosSistema.Rows[i]["APELLIDO_CASADA"];
                    fila["PRIMER_APELLIDO"] = datosSistema.Rows[i]["PRIMER_APELLIDO"];
                    fila["SEGUNDO_APELLIDO"] = datosSistema.Rows[i]["SEGUNDO_APELLIDO"];
                    fila["LIMITE"] = datosSistema.Rows[i]["LIMITE"];
                    fila["SALDO"] = datosSistema.Rows[i]["SALDO"];
                    fila["GASTOS_COBRANZA2"] = datosSistema.Rows[i]["GASTOS_COBRANZA2"];
                    fila["SEGURO2"] = datosSistema.Rows[i]["SEGURO2"];
                    fila["OTROS_GASTOS2"] = datosSistema.Rows[i]["OTROS_GASTOS2"];
                    fila["COMENTARIO2"] = datosSistema.Rows[i]["COMENTARIO2"];
                    fila["TOTAL2"] = datosSistema.Rows[i]["TOTAL2"];
                    fila["FECHA_ESTADO_CUENTA2"] = datosSistema.Rows[i]["FECHA_ESTADO_CUENTA2"];
                    fila["INCENDIO2"] = datosSistema.Rows[i]["INCENDIO2"];
                    fila["INTERESES2"] = datosSistema.Rows[i]["INTERESES2"];
                    fila["MORA2"] = datosSistema.Rows[i]["MORA2"];
                    fila["NO_REGISTRADO"] = datosSistema.Rows[i]["NO_REGISTRADO"];
                    fila["CONTADOR"] = datosSistema.Rows[i]["CONTADOR"];
                    fila["OBSERVACIONES2"] = datosSistema.Rows[i]["OBSERVACIONES2"];
                    fila["TIPO_PROCESO"] = datosSistema.Rows[i]["TIPO_PROCESO"];
                    fila["FECHA_ASIGNACION_ABOGADO"] = datosSistema.Rows[i]["FECHA_ASIGNACION_ABOGADO"];
                    fila["NOMBRE_ABOGADO"] = datosSistema.Rows[i]["NOMBRE_ABOGADO"];
                    fila["OBSERVACIONES3"] = datosSistema.Rows[i]["OBSERVACIONES3"];
                    fila["NO_PROCESO"] = datosSistema.Rows[i]["NO_PROCESO"];
                    fila["FECHA_PRESENTACION_DEMANDA"] = datosSistema.Rows[i]["FECHA_PRESENTACION_DEMANDA"];
                    fila["NO_JUZGADO"] = datosSistema.Rows[i]["NO_JUZGADO"];
                    fila["NOMBRE_JUZGADO"] = datosSistema.Rows[i]["NOMBRE_JUZGADO"];
                    fila["OFICIAL"] = datosSistema.Rows[i]["OFICIAL"];
                    fila["NOTIFICADOR"] = datosSistema.Rows[i]["NOTIFICADOR"];
                    fila["DEPARTAMENTO"] = datosSistema.Rows[i]["DEPARTAMENTO"];
                    fila["MUNICIPIO"] = datosSistema.Rows[i]["MUNICIPIO"];
                    fila["ESTADO_DEMANDA"] = datosSistema.Rows[i]["ESTADO_DEMANDA"];
                    fila["MOTIVO_RECHAZO"] = datosSistema.Rows[i]["MOTIVO_RECHAZO"];
                    fila["FECHA_NOTIFICACION"] = datosSistema.Rows[i]["FECHA_NOTIFICACION"];
                    fila["BANCO"] = datosSistema.Rows[i]["BANCO"];
                    fila["MONTO"] = datosSistema.Rows[i]["MONTO"];
                    fila["COOPERATIVA"] = datosSistema.Rows[i]["COOPERATIVA"];
                    fila["MONTO2"] = datosSistema.Rows[i]["MONTO2"];
                    fila["TRABAJO"] = datosSistema.Rows[i]["TRABAJO"];
                    fila["FECHA_OFICIO_MIGRACION"] = datosSistema.Rows[i]["FECHA_OFICIO_MIGRACION"];
                    fila["FECHA"] = datosSistema.Rows[i]["FECHA"];
                    fila["FECHA_OFICIO_TRABAJO"] = datosSistema.Rows[i]["FECHA_OFICIO_TRABAJO"];
                    fila["VOLUNTARIA"] = datosSistema.Rows[i]["VOLUNTARIA"];
                    fila["FECHA_PRESENTACION"] = datosSistema.Rows[i]["FECHA_PRESENTACION"];
                    fila["MONTO3"] = datosSistema.Rows[i]["MONTO3"];
                    fila["FECHA_RESOLUCION"] = datosSistema.Rows[i]["FECHA_RESOLUCION"];
                    fila["FECHA_NOTIFICACION2"] = datosSistema.Rows[i]["FECHA_NOTIFICACION2"];
                    fila["OBSERVACIONES4"] = datosSistema.Rows[i]["OBSERVACIONES4"];
                    fila["FECHA3"] = datosSistema.Rows[i]["FECHA3"];
                    fila["TRABAJO2"] = datosSistema.Rows[i]["TRABAJO2"];
                    fila["FECHA_PRESENTACION_MEMORIAL"] = datosSistema.Rows[i]["FECHA_PRESENTACION_MEMORIAL"];
                    fila["FECHA_SOLICITUD_SENTENCIA"] = datosSistema.Rows[i]["FECHA_SOLICITUD_SENTENCIA"];
                    fila["FECHA_DEMANDA_APREMIO"] = datosSistema.Rows[i]["FECHA_DEMANDA_APREMIO"];
                    fila["FECHA4"] = datosSistema.Rows[i]["FECHA4"];
                    fila["NO_FACTURA"] = datosSistema.Rows[i]["NO_FACTURA"];
                    fila["NO_SERIE"] = datosSistema.Rows[i]["NO_SERIE"];
                    fila["DESCRIPCION"] = datosSistema.Rows[i]["DESCRIPCION"];
                    fila["IMPORTE_TOTAL"] = datosSistema.Rows[i]["IMPORTE_TOTAL"];
                    fila["FECHA_EMISION_FACTURA"] = datosSistema.Rows[i]["FECHA_EMISION_FACTURA"];
                    fila["IMPORTE_CASO"] = datosSistema.Rows[i]["IMPORTE_CASO"];
                    fila["MOTIVO_DE_PAGO"] = datosSistema.Rows[i]["MOTIVO_DE_PAGO"];
                    fila["FECHA_PRESENTACION_JUZGADO"] = datosSistema.Rows[i]["FECHA_PRESENTACION_JUZGADO"];
                    fila["HONORARIOS"] = datosSistema.Rows[i]["HONORARIOS"];
                    fila["NO_CHEQUE"] = datosSistema.Rows[i]["NO_CHEQUE"];
                    fila["FECHA_EMISION_CHEQUE"] = datosSistema.Rows[i]["FECHA_EMISION_CHEQUE"];
                    fila["NO_RECIBO"] = datosSistema.Rows[i]["NO_RECIBO"];
                    fila["MONTO4"] = datosSistema.Rows[i]["MONTO4"];
                    fila["BANCO2"] = datosSistema.Rows[i]["BANCO2"];
                    fila["FECHA5"] = datosSistema.Rows[i]["FECHA5"];
                    fila["FECHA_NOTIFICACION3"] = datosSistema.Rows[i]["FECHA_NOTIFICACION3"];
                    fila["ACTITUD"] = datosSistema.Rows[i]["ACTITUD"];
                    fila["FECHA6"] = datosSistema.Rows[i]["FECHA6"];
                    fila["FECHA_SENTENCIA4"] = datosSistema.Rows[i]["FECHA_SENTENCIA4"];
                    fila["NOTIFICACION_SENTENCIA"] = datosSistema.Rows[i]["NOTIFICACION_SENTENCIA"];
                    fila["LUGAR"] = datosSistema.Rows[i]["LUGAR"];
                    fila["OBSERVACIONES5"] = datosSistema.Rows[i]["OBSERVACIONES5"];
                    fila["FECHA7"] = datosSistema.Rows[i]["FECHA7"];
                    fila["EXCEPCIONES"] = datosSistema.Rows[i]["EXCEPCIONES"];
                    fila["FECHA_RESOLUCION_EXCEPCIONES"] = datosSistema.Rows[i]["FECHA_RESOLUCION_EXCEPCIONES"];
                    fila["FECHA_DE_APERTURA"] = datosSistema.Rows[i]["FECHA_DE_APERTURA"];
                    fila["OBSERVACIONES6"] = datosSistema.Rows[i]["OBSERVACIONES6"];
                    fila["FECHA_VISTA"] = datosSistema.Rows[i]["FECHA_VISTA"];
                    fila["FECHA_SENTENCIA"] = datosSistema.Rows[i]["FECHA_SENTENCIA"];
                    fila["FECHA_NOTIFICACION_SENTENCIA"] = datosSistema.Rows[i]["FECHA_NOTIFICACION_SENTENCIA"];
                    fila["LUGAR2"] = datosSistema.Rows[i]["LUGAR2"];
                    fila["OBSERVACIONES7"] = datosSistema.Rows[i]["OBSERVACIONES7"];
                    fila["FECHA8"] = datosSistema.Rows[i]["FECHA8"];
                    fila["NIT"] = datosSistema.Rows[i]["NIT"];
                    fila["PLACA"] = datosSistema.Rows[i]["PLACA"];
                    fila["MODELO"] = datosSistema.Rows[i]["MODELO"];
                    fila["MARCA"] = datosSistema.Rows[i]["MARCA"];
                    fila["FINCA"] = datosSistema.Rows[i]["FINCA"];
                    fila["FOLIO"] = datosSistema.Rows[i]["FOLIO"];
                    fila["LIBRO"] = datosSistema.Rows[i]["LIBRO"];
                    fila["FECHA_SOLICITUD_EDICTOS"] = datosSistema.Rows[i]["FECHA_SOLICITUD_EDICTOS"];
                    fila["MONTO5"] = datosSistema.Rows[i]["MONTO5"];
                    fila["DESCRIPCION2"] = datosSistema.Rows[i]["DESCRIPCION2"];
                    fila["FECHA_PUBLICACION1"] = datosSistema.Rows[i]["FECHA_PUBLICACION1"];
                    fila["FECHA_PUBLICACION2"] = datosSistema.Rows[i]["FECHA_PUBLICACION2"];
                    fila["FECHA_PUBLICACION3"] = datosSistema.Rows[i]["FECHA_PUBLICACION3"];
                    fila["FECHA9"] = datosSistema.Rows[i]["FECHA9"];
                    fila["FECHA_INTENTO_NOTIFICACION1"] = datosSistema.Rows[i]["FECHA_INTENTO_NOTIFICACION1"];
                    fila["FECHA_INTENTO_NOTIFICACION2"] = datosSistema.Rows[i]["FECHA_INTENTO_NOTIFICACION2"];
                    fila["FECHA_INTENTO_NOTIFICACION3"] = datosSistema.Rows[i]["FECHA_INTENTO_NOTIFICACION3"];
                    fila["FECHA_SOLICITUD_NOMBRAMIENTO_NOTARIO"] = datosSistema.Rows[i]["FECHA_SOLICITUD_NOMBRAMIENTO_NOTARIO"];
                    fila["NOTARIO_PROPUESTO"] = datosSistema.Rows[i]["NOTARIO_PROPUESTO"];
                    fila["COLEGIADO_NOTARIO_PROPUESTO"] = datosSistema.Rows[i]["COLEGIADO_NOTARIO_PROPUESTO"];
                    fila["FECHA_RESOLUCIÓN_NOMBRAMIENTO_NOTARIO"] = datosSistema.Rows[i]["FECHA_RESOLUCIÓN_NOMBRAMIENTO_NOTARIO"];
                    fila["FECHA_NOTIFICACION_RESOLUCION"] = datosSistema.Rows[i]["FECHA_NOTIFICACION_RESOLUCION"];
                    fila["NOTIFICACION_AL_ASOCIADO"] = datosSistema.Rows[i]["NOTIFICACION_AL_ASOCIADO"];
                    fila["FECHA10"] = datosSistema.Rows[i]["FECHA10"];
                    fila["FECHA_PRESENTACION_DESISTIMIENTO"] = datosSistema.Rows[i]["FECHA_PRESENTACION_DESISTIMIENTO"];
                    fila["FECHA_RESOLUCION_DESISTIMIENTO"] = datosSistema.Rows[i]["FECHA_RESOLUCION_DESISTIMIENTO"];
                    fila["FECHA11"] = datosSistema.Rows[i]["FECHA11"];
                    fila["MONTO6"] = datosSistema.Rows[i]["MONTO6"];
                    fila["NOMBRE_CHEQUE"] = datosSistema.Rows[i]["NOMBRE_CHEQUE"];
                    fila["FECHA12"] = datosSistema.Rows[i]["FECHA12"];
                    fila["TOTAL4"] = datosSistema.Rows[i]["TOTAL4"];
                    fila["NOMBRE_CHEQUE2"] = datosSistema.Rows[i]["NOMBRE_CHEQUE2"];
                    fila["FECHA15"] = datosSistema.Rows[i]["FECHA15"];
                    fila["FECHA_ACTA_NOTARIAL_NOTIFICACION"] = datosSistema.Rows[i]["FECHA_ACTA_NOTARIAL_NOTIFICACION"];
                    fila["FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACIÓN"] = datosSistema.Rows[i]["FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACIÓN"];
                    fila["FECHA13"] = datosSistema.Rows[i]["FECHA13"];
                    fila["FECHA_ENTREGA_FISICA_EXPEDIENTE"] = datosSistema.Rows[i]["FECHA_ENTREGA_FISICA_EXPEDIENTE"];
                    fila["OBSERVACIONES8"] = datosSistema.Rows[i]["OBSERVACIONES8"];
                    fila["FECHA_ACTA_NOTARIAL_NOTIFICACION2"] = datosSistema.Rows[i]["FECHA_ACTA_NOTARIAL_NOTIFICACION2"];
                    fila["FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACION2"] = datosSistema.Rows[i]["FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACION2"];
                    fila["FECHA_RESOLUCIÓN_ACTA_NOTARIAL_NOTIFICACION"] = datosSistema.Rows[i]["FECHA_RESOLUCIÓN_ACTA_NOTARIAL_NOTIFICACION"];
                    fila["FECHA_REMATE"] = datosSistema.Rows[i]["FECHA_REMATE"];
                    fila["OBSERVACIONES_REMATE"] = datosSistema.Rows[i]["OBSERVACIONES_REMATE"];
                    fila["ADJUDICADO"] = datosSistema.Rows[i]["ADJUDICADO"];
                    fila["MONTO7"] = datosSistema.Rows[i]["MONTO7"];
                    fila["FECHA_MEMORIAL_PROYECTO_LIQUIDACION3"] = datosSistema.Rows[i]["FECHA_MEMORIAL_PROYECTO_LIQUIDACION3"];
                    fila["FECHA_RESOLUCION_PROYECTO_LIQUIDACION"] = datosSistema.Rows[i]["FECHA_RESOLUCION_PROYECTO_LIQUIDACION"];
                    fila["FECHA_NOTIFICACION_RESOLUCION_LIQUIDACION"] = datosSistema.Rows[i]["FECHA_NOTIFICACION_RESOLUCION_LIQUIDACION"];
                    /*datosCompletos.Columns.Add("FECHA_MEMORIAL_PARA_NOMBRAR_NOTARIO_CARTULANTE")*/

                    fila["NOTARIO"] = datosSistema.Rows[i]["NOTARIO"];
                    fila["COLEGIADO_NOTARIO"] = datosSistema.Rows[i]["COLEGIADO_NOTARIO"];
                    fila["FECHA_RESOLUCIÓN_PARA_NOMBRAR_NOTARIO_CARTULANTE"] = datosSistema.Rows[i]["FECHA_RESOLUCIÓN_PARA_NOMBRAR_NOTARIO_CARTULANTE"];
                    fila["FECHA_NOTIFICACION_RESOLUCION_NOTARIO"] = datosSistema.Rows[i]["FECHA_NOTIFICACION_RESOLUCION_NOTARIO"];
                    fila["NO_ESCRITURA"] = datosSistema.Rows[i]["NO_ESCRITURA"];
                    fila["FECHA_ESCRITURA"] = datosSistema.Rows[i]["FECHA_ESCRITURA"];
                    fila["HONORARIO_DE_REGISTRO"] = datosSistema.Rows[i]["HONORARIO_DE_REGISTRO"];
                    fila["HONORARIO_IMPUESTO"] = datosSistema.Rows[i]["HONORARIO_IMPUESTO"];
                    fila["FECHA14"] = datosSistema.Rows[i]["FECHA14"];

                    string id = sn.obteneridultimaetapa(d2);
                string ultimaetapa;
                if (id == "")
                {
                    ultimaetapa = "";
                }
                else
                {
                    int id2 = Convert.ToInt32(id) + 1;
                    ultimaetapa = sn.obtenerultimaetapa2(id2.ToString());
                }
                    
                    fila["ETAPA_ACTUAL"] = ultimaetapa;

                    string[] medidas1 = sn.obtenermedidas(d2, "1");
                    string medidas = "";
                if (medidas1[0] == null || medidas1[0] == "")
                {
                    medidas = "";
                }
                else
                {
                    for (int m = 0; m < medidas1.Length; m++)
                    {
                        medidas = medidas + medidas1[m] + " / ";
                    }
                }
                    fila["MEDIDAS_OBLIGATORIAS"] = medidas;

                    medidas = "";
                    string[] medidas2 = sn.obtenermedidas(d2, "2");
                if (medidas2[0] == null || medidas2[0] == "")
                {
                    medidas = "";
                }
                else
                {
                    for (int n = 0; n < medidas2.Length; n++)
                    {
                        medidas = medidas + medidas2[n] + " / ";
                    }
                }
                    fila["MEDIDAS_SOLICITADAS"] = medidas;

                    medidas = "";
                    string[] medidas3 = sn.obtenermedidas(d2, "3");
                if (medidas3[0] == null || medidas3[0] == "")
                {
                    medidas = "";
                }
                else
                {
                    for (int p = 0; p < medidas3.Length; p++)
                    {
                        medidas = medidas + medidas3[p] + " / ";
                    }
                }
                    fila["MEDIDAS_OTORGADAS"] = medidas;

                    medidas = "";
                    string[] medidas4 = sn.obtenermedidas(d2, "4");
                if (medidas4[0] == null || medidas4[0] == "")
                {
                    medidas = "";
                }
                else
                {
                    for (int q = 0; q < medidas4.Length; q++)
                    {
                        medidas = medidas + medidas4[q] + " / ";
                    }
                }
                    fila["MEDIDAS_AUTORIZADAS"] = medidas;

                datosCompletos.Rows.Add(fila);
                
               int prueba =  datosCompletos.Rows.Count;
            }
            return datosCompletos;
        }
    }
}