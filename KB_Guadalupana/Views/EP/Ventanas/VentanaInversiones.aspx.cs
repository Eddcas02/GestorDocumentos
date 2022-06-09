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
    public partial class VentanaInversiones : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                mest.llenadocombo("SELECT * FROM `Gen_Moneda`", monedadrp, "MonedaNombre", "MonedaID", "Moneda");

                mest.llenadocombo("SELECT * FROM `Gen_EntidadFinanciera` ORDER BY EntidadFinPrioridad DESC ", fropentidad, "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");


            }
        }

        protected void guardarinversiones(object sender, EventArgs e)
        {
            if (fropentidad.SelectedIndex != 0 && txtplazo.Text != "" && txtcuenta.Text != "" && monedadrp.SelectedIndex != 0 && montocaja.Text != "" && txtorigen.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorActivosInver", "ColaboradorActivoInverID");
                string c1 = montocaja.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                mest.executesql("INSERT INTO `EP_ColaboradorActivosInver`(`LoteID`, `ColaboradorID`, `ColaboradorActivoInverID`, `EntidadFinCodigo`, `ColaboradorActivoInverPlazo`, `MonedaID`, `ColaboradorActivoInverMonto`, `ColaboradorActivoInverOrigen`, `ColaboradorActivoInverCuenta`, `ColaboradorActivoInverFechaApe`)" +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + fropentidad.SelectedValue + "','" + txtplazo.Text + "','" + monedadrp.SelectedValue + "','" + d1 + "','" + txtorigen.Text + "','" + txtcuenta.Text + "','" + fechainv.Text + "')");
                fropentidad.SelectedIndex = 0;
                monedadrp.SelectedIndex = 0;

                txtplazo.Text = "";
                txtorigen.Text = "";
                txtcuenta.Text = "";
                montocaja.Text = "";

                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;
            }
            else
            {
                lblSuccessMessage1.Visible = false;
                lblerror.Visible = true;
            }


        }
    }
}