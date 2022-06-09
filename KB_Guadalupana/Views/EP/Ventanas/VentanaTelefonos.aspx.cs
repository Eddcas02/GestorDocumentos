using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using KB_Guadalupana.Controllers;
using System.Data;
using MySql.Data.MySqlClient;

namespace KB_Guadalupana.Views.EP.Ventanas
{
    public partial class VentanaTelefonos : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {
                mest.llenadocombo("SELECT * FROM `Gen_TipoTelefono`", tipotel, "TipoTelefonoDescripcion", "TipoTelefonoID", "Tipo-Teléfono");

            }
        }

        protected void agregartelefono_Click(object sender, EventArgs e)
        {
            if (tipotel.SelectedIndex != 0 && txtnumerotel.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorContactoEmer", "ColaboradorContactoEID");

                mest.executesql("INSERT INTO `EP_ColaboradorTelefono`(`LoteID`, `ColaboradorID`, `TipoTelefonoID`, `ColaboradorTelefonoNumero`)" +
                    " VALUES ('" + lote + "','" + cifglobal + "','" +tipotel.SelectedValue + "','" + txtnumerotel.Text + "')");
            
                txtnumerotel.Text = "";
                tipotel.SelectedIndex = 0;
                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;

            }
            else
            {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;
            }
        }
    }
}