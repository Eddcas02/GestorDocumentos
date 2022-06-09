using System;
using System.Data;
using KB_Guadalupana.Controllers;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KB_Guadalupana.Views.ProcesosJudiciales
{
    public partial class SolicitudChequeNotificacionApremio : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        string documento = "";
        Sentencia_juridico sn = new Sentencia_juridico();
        ServiceReference1.WebService1SoapClient WS = new ServiceReference1.WebService1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarformulario();
                //llenarcombodocumento();
                llenarcombobanco();
                llenarcomentarios();
                Observaciones.Visible = false;
                Guardar.Visible = false;
                //Enviar.Visible = false;
            }
        }

        public void llenarcombobanco()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM pj_bancoemisor";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);
                    Banco.DataSource = ds;
                    Banco.DataTextField = "pj_nombrebanco";
                    Banco.DataValueField = "idpj_bancoemisor";
                    Banco.DataBind();
                    Banco.Items.Insert(0, new ListItem("[Selecccione Banco]", "0"));
                }
                catch
                {

                }
            }
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            string numcredito = Session["credito"] as string;
            string cheque = sn.tipodocumentoCheque(numcredito);
            if (NumCheque.Value == "" || FechaEmision.Value == "" || Banco.SelectedValue == "0")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Complete los datos');", true);
            }
            else
            {
                string usuario = Session["sesion_usuario"] as string;
                string idusuario = sn.obteneridusuario(usuario);

                string sig = sn.siguiente("pj_solicitudcheque", "idpj_solicitudcheque");
                sn.insertarsolicitudcheque(sig, numcredito, idusuario, NumCheque.Value, FechaEmision.Value, Banco.SelectedValue, ObservacionesCredito.Value, Monto.Value, "36");




                string[] campos2 = sn.obtenertipocredito(numcredito);
                string idcredito = campos2[0];
                string fecha = "";
                string numindicende = "";
                string nombrecliente = "";

                if (idcredito == null)
                {
                    string[] campos3 = sn.obtenertipotarjeta(numcredito);
                    for (int i = 0; i < campos3.Length; i++)
                    {
                        numindicende = campos3[0];
                    }
                    fecha = sn.fechacreaciontarjeta(numcredito);
                }
                else
                {
                    for (int i = 0; i < campos2.Length; i++)
                    {
                        numindicende = campos2[0];
                    }
                    fecha = sn.fechacreacioncredito(numcredito);
                }

                string[] fechaseparada = fecha.Split(' ');
                string[] fechacreacion = fechaseparada[0].Split('/');
                string diacreacion = fechacreacion[0];
                string mescreacion = fechacreacion[1];
                string añocreacion = fechacreacion[2];

                string horacreacion = fechaseparada[1];

                string fechacreacion2 = añocreacion + '-' + mescreacion + '-' + diacreacion + ' ' + horacreacion;


                string[] fechayhora = sn.fechayhora();
                string[] fecha2 = fechayhora[0].Split(' ');
                string año = fecha2[0];
                string mes = fecha2[1];
                string dia = fecha2[2];

                string hora = fechayhora[1];
                string fechahoraactual = año + '-' + mes + '-' + dia + ' ' + hora;

                string var1 = WS.buscarcredito(numcredito);
                char delimitador = '|';
                string[] campos = var1.Split(delimitador);
                string nombrecliente2 = "";

                if (var1.Length == 4)
                {
                    Response.Write("NO HAY DATOS QUE MOSTRARA");
                }
                else
                {

                    for (int i = 0; i < campos.Length; i++)
                    {
                        nombrecliente2 = campos[20];
                    }
                }

                string sig5 = sn.siguiente("pj_bitacora", "idpj_bitacora");
                sn.insertarbitacora(sig5, numindicende, numcredito, nombrecliente2, "Recibido", "34", "28", fechahoraactual, fechacreacion2, ObservacionesCredito.Value);

                string sig4 = sn.siguiente("pj_bitacora", "idpj_bitacora");
                sn.insertarbitacora(sig4, numindicende, numcredito, nombrecliente2, "Enviado", "34", "28", fechahoraactual, fechacreacion2, ObservacionesCredito.Value);

                string estado = Session["etapa"] as string;

                sn.cambiarestado(numcredito, "41");

                string sig2 = sn.siguiente("pj_etapa_credito", "idpj_correlativo_etapa");
                sn.guardaretapa(sig2, "42", numcredito, sn.datetime(), "Cargar Voucher", idusuario, "28", nombrecliente2, NumeroIncidente.Value);


                String script = "alert('Se guardó exitosamente'); window.location.href= 'PendienteSolicitudCheque.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
        }

        public void llenarformulario()
        {

            string numcredito = Session["credito"] as string;
            string var1 = WS.buscarcredito(numcredito);
            char delimitador = '|';
            string[] campos = var1.Split(delimitador);

            if (var1.Length == 4)
            {
                String script = "alert('Se perdió la conexión, intente más tarde'); window.location.href= 'PendienteSolicitudCheque.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else
            {

                for (int i = 0; i < campos.Length; i++)
                {
                    CreditoNumero.Value = campos[1];
                    NumCif.Value = campos[19];
                    ClienteNombre.Value = campos[20];
                }

            }

            string[] campos2 = sn.obtenertipocredito(numcredito);
            string idcredito = campos2[0];
            if (idcredito == null)
            {
                Session["TipoCredito"] = "tarjeta";

                string[] campos3 = sn.obtenertipotarjeta(numcredito);
                for (int i = 0; i < campos3.Length; i++)
                {
                    NumeroIncidente.Value = campos3[0];
                }
            }
            else
            {
                Session["TipoCredito"] = "credito";
                for (int i = 0; i < campos2.Length; i++)
                {
                    NumeroIncidente.Value = campos2[0];
                }
            }
        }

        public void llenarcomentarios()
        {
            DataSet comentarios = new DataSet();
            string numcredito = Session["credito"] as string;
            comentarios = sn.consultarComentarios(numcredito);
            Repeater1.DataSource = comentarios;
            Repeater1.DataBind();

        }

        protected void Validar_Click(object sender, EventArgs e)
        {
            Validar.Visible = false;
            //Rechazar.Visible = false;
            Observaciones.Visible = true;
            Guardar.Visible = true;
            //Enviar.Visible = false;
        }

        protected void Rechazar_Click(object sender, EventArgs e)
        {
            Validar.Visible = false;
            //Rechazar.Visible = false;
            Observaciones.Visible = true;
            Guardar.Visible = false;
            //Enviar.Visible = true;
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {

        }
    }
}