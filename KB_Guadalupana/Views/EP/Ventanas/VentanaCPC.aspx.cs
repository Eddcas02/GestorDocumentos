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
    public partial class VentanaCPC : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
            if (txtmonto.Text != "" && txtmotivo.Text != "" && txtorigen.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorActivosCXC", "ColaboradorActivoCXCID");
                string c1 = txtmonto.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                mest.executesql("INSERT INTO `EP_ColaboradorActivosCXC`(`LoteID`, `ColaboradorID`, `ColaboradorActivoCXCID`, `ColaboradorActivoCXCOrigen`, `ColaboradorActivoCXCMonto`, `ColaboradorActivoCXCMotivo`) " +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + txtorigen.Text + "','" + d1 + "','" + txtmotivo.Text + "')");

                txtmonto.Text = "";
                txtmotivo.Text = "";
                txtorigen.Text = "";
                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;
            }
            else {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lote = Convert.ToString(Session["lotepasa"]);
            usernombre = Convert.ToString(Session["sesion_usuario"]);

            cifglobal = mest.idusuariogeneral(usernombre);
            
        }
    }
}