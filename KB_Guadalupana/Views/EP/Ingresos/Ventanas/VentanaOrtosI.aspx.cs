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
    public partial class VentanaOrtosI : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

       

     


        protected void btntc_Click(object sender, EventArgs e)
        {
            if (TipoOtroIngresoID.SelectedIndex != 0 && ColaboradoringresoOtrDescripci.Text != "" && ColaboradoringresoOtrValor.Text != "" )
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorIngresoOtro", "ColaboradoringresoOtrID");

           
                string c4 = ColaboradoringresoOtrValor.Text;
                decimal d4 = Convert.ToDecimal(c4.Replace(",", ""));

                mest.executesql("INSERT INTO `EP_ColaboradorIngresoOtro`(`LoteID`, `ColaboradorID`, `ColaboradoringresoOtrID`, `TipoOtroIngresoID`, `ColaboradoringresoOtrDescripci`, `ColaboradoringresoOtrValor`)" +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + TipoOtroIngresoID.SelectedValue + "','" + ColaboradoringresoOtrDescripci.Text + "','" + d4 + "')");
                TipoOtroIngresoID.SelectedIndex = 0;


                ColaboradoringresoOtrDescripci.Text = "";
                ColaboradoringresoOtrValor.Text = "";



                lblSuccessMessage1.Visible = true;



            }
            else
            {
                lblerror.Visible = true;

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
        
            if (!IsPostBack)
            {
                mest.llenadocombo("SELECT * FROM `Gen_TipoOtroIngreso`", TipoOtroIngresoID, "TipoOtroIngresoDescripcion", "TipoOtroIngresoID", "Otros Ingresos");
          

            }

        }


        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
           
        

        }
    }
}