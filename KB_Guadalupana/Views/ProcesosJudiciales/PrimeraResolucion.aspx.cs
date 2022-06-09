using System;
using System.Data;
using MySql.Data.MySqlClient;
using KB_Guadalupana.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

namespace KB_Guadalupana.Views.ProcesosJudiciales
{
    public partial class PrimeraResolucion : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        string documento = "";
        Sentencia_juridico sn = new Sentencia_juridico();
        ServiceReference1.WebService1SoapClient WS = new ServiceReference1.WebService1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarcombodocumentoResolucion();
                llenarcomboestado();
                llenarformulario();
                llenarcomentarios();
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
                String script = "alert('Se perdió la conexión, intente más tarde'); window.location.href= 'PendientePresentacionDemanda.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else
            {
                gridview1.DataSource = WS.buscarresponsables(numcredito);
                gridview1.DataBind();

                for (int i = 0; i < campos.Length; i++)
                {
                    NumPrestamo.Value = campos[1];
                    CreditoNumero.Value = campos[1];
                    DPI.Value = campos[21];
                    CodigoCliente.Value = campos[19];
                    NumCif.Value = campos[19];
                    NombreCliente.Value = campos[20];
                    ClienteNombre.Value = campos[20];
                    MontoOriginal.Value = "Q " + campos[9];
                    CapitalDesem.Value = "Q " + campos[9];

                    if (campos[8] == "            .00")
                    {
                        SaldoActual.Value = "Q 0.00";
                    }
                    else
                    {
                        SaldoActual.Value = "Q " + campos[8];
                    }
                }

            }

            string[] infoproceso = sn.obtenerdatosproceso(numcredito);
            Numproceso.Value = infoproceso[0];
            NumJuzgado.Value = infoproceso[1];
            NombreJuzgado.Value = infoproceso[2];
            Oficial.Value = infoproceso[3];

            string[] campos2 = sn.obtenertipocredito(numcredito);
            string idcredito = campos2[0];
            if (idcredito == null)
            {
                Session["TipoCredito"] = "tarjeta";

                string[] campos3 = sn.obtenertipotarjeta(numcredito);
                for (int i = 0; i < campos3.Length; i++)
                {
                    NumIncidente.Value = campos3[0];
                    NumeroIncidente.Value = campos3[0];
                }
            }
            else
            {
                Session["TipoCredito"] = "credito";
                for (int i = 0; i < campos2.Length; i++)
                {
                    NumIncidente.Value = campos2[0];
                    NumeroIncidente.Value = campos2[0];
                }
            }
        }

        public void llenarcombodocumentoResolucion()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM pj_tipodocumento  WHERE idpj_tipodocumento = 17";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);
                    TDocumentoResolucion.DataSource = ds;
                    TDocumentoResolucion.DataTextField = "pj_nombretipodoc";
                    TDocumentoResolucion.DataValueField = "idpj_tipodocumento";
                    TDocumentoResolucion.DataBind();
                    TDocumentoResolucion.Items.Insert(0, new ListItem("[Tipo Documento]", "0"));
                }
                catch
                {

                }
            }
        }

        protected void AgregarResolucion_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload2.HasFile)
                {
                    string ext = System.IO.Path.GetExtension(FileUpload2.FileName);
                    ext = ext.ToLower();

                    if (ext == ".pdf" || ext == ".tiff" || ext == ".tif")
                    {
                        string numcredito = Session["credito"] as string;
                        string siguiente = sn.siguiente("pj_documento", "idpj_documento");
                        documento = "Subidos/Resolucion/" + siguiente + '-' + FileUpload2.FileName;
                        string nombredoc = siguiente + '-' + FileUpload2.FileName;
                        sn.guardardocumentoexp(siguiente, TDocumentoResolucion.SelectedValue, documento, nombredoc, numcredito);
                        FileUpload2.SaveAs(Server.MapPath("Subidos/Resolucion/" + siguiente + '-' + FileUpload2.FileName));
                        ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Espere un momento mientras se sube el archivo');", true);
                        llenargridviewdocumentosResolucion();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('El archivo debe ser en formato pdf o tif');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "error", "alert('Debe subir un archivo');", true);
                }
            }
            catch
            {

            }
            EstadoDemanda.Focus();
        }

        public void llenargridviewdocumentosResolucion()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string numcredito = Session["credito"] as string;
                    sqlCon.Open();
                    string query = "SELECT pj_documento.idpj_documento AS Codigo, pj_tipodocumento.pj_nombretipodoc AS TipoDocumento, pj_documento.pj_nombrearchivo AS Nombre FROM pj_documento INNER JOIN pj_tipodocumento ON pj_documento.idpj_tipodocumento = pj_tipodocumento.idpj_tipodocumento WHERE idpj_credito = '" + numcredito + "' AND pj_tipodocumento.idpj_tipodocumento = 17";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewResolucion.DataSource = dt;
                    gridViewResolucion.DataBind();
                }
                catch
                {

                }
            }
        }


        protected void OnSelectedIndexChangedResolucion(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString((gridViewResolucion.SelectedRow.FindControl("lblid") as Label).Text);
                string documentoselec = sn.obtenerrutadocumento(id);
                string nombrearchivo = sn.nombrearchivo(id);
                string[] extension = nombrearchivo.Split('.');
                int tamaño = extension.Length;
                string tipo = extension[tamaño - 1];

                string FilePath = Server.MapPath(documentoselec);
                WebClient User = new WebClient();
                Byte[] FileBuffer = User.DownloadData(FilePath);
                if (FileBuffer != null)
                {
                    if (tipo.ToLower() == "pdf")
                    {
                        Response.ContentType = "application/pdf";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                    else if (tipo.ToLower() == "tif" || tipo.ToLower() == "tiff")
                    {
                        Response.ContentType = "image/tiff";
                        Response.AddHeader("content-length", FileBuffer.Length.ToString());
                        Response.BinaryWrite(FileBuffer);
                    }
                }
            }
            catch
            {

            }
        }

        public void llenarcomboestado()
        {
            EstadoDemanda.Items.Insert(0, new ListItem("[Estado]", "0"));
            EstadoDemanda.Items.Insert(1, new ListItem("Admitida", "1"));
            EstadoDemanda.Items.Insert(2, new ListItem("Rechazada", "2"));
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            string numcredito = Session["credito"] as string;
            string usuario = Session["sesion_usuario"] as string;
            string idusuario = sn.obteneridusuario(usuario);

            if (EstadoDemanda.SelectedValue != "2")
            {
                DemandaRechazada.Value = "Admitida";
            }
            string sig7 = sn.siguiente("pj_resoluciontramite", "idpj_resoluciontramite");
            sn.insertarresolucion(sig7, numcredito, idusuario, EstadoDemanda.SelectedValue, DemandaRechazada.Value, FechaNotificacion.Value);

            
            if (Medidas1.Checked)
            {
                string sig6 = sn.siguiente("pj_asignacionmedidas", "idpj_asignacionmedidas");
                sn.insertarmedidaspre(sig6, "1", "Embargo de Salario", numcredito, "3");
            }
            if (Medidas2.Checked)
            {
                string sig6 = sn.siguiente("pj_asignacionmedidas", "idpj_asignacionmedidas");
                sn.insertarmedidaspre(sig6, "2", "Embargo de cuentas bancarias", numcredito, "3");
            }
            if (Medidas3.Checked)
            {
                string sig6 = sn.siguiente("pj_asignacionmedidas", "idpj_asignacionmedidas");
                sn.insertarmedidaspre(sig6, "3", "Arraigo", numcredito, "3");
            }
            if (Medidas4.Checked)
            {
                string sig6 = sn.siguiente("pj_asignacionmedidas", "idpj_asignacionmedidas");
                sn.insertarmedidaspre(sig6, "4", "Embargo en cooperativas", numcredito, "3");
            }
            if (Medidas6.Checked)
            {
                string sig6 = sn.siguiente("pj_asignacionmedidas", "idpj_asignacionmedidas");
                sn.insertarmedidaspre(sig6, "6", OtraMedida.Value, numcredito, "3");
            }
            if (Medidas5.Checked)
            {
                string sig6 = sn.siguiente("pj_asignacionmedidas", "idpj_asignacionmedidas");
                sn.insertarmedidaspre(sig6, "5", "Embargo de bienes", numcredito, "3");
            }

            String script = "alert('Se guardó exitosamente'); window.location.href= 'PendientePresentacionDemanda.aspx';";
            ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        }

        protected void EstadoDemanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenarcomentarios()
        {
            DataSet comentarios = new DataSet();
            string numcredito = Session["credito"] as string;
            comentarios = sn.consultarComentarios(numcredito);
            Repeater1.DataSource = comentarios;
            Repeater1.DataBind();
        }
    }
}