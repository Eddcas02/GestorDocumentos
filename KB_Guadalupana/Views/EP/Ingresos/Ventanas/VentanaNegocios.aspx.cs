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
    public partial class VentanaNegocios : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

       

     


        protected void btntc_Click(object sender, EventArgs e)
        {
            if (TipoNegocioID.SelectedIndex != 0 && ColaboradoringresoNegNombre.Text != ""  && ColaboradoringresoNegObjeto.Text != "" && ColaboradoringresoNegDireccion.Text != "" && ColaboradoringresoNegEgresos.Text != "" && ColaboradoringresoNegIngresos.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorIngresoNegocio", "ColaboradoringresoNegID");

                string c1 = ColaboradoringresoNegIngresos.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string c2 = ColaboradoringresoNegEgresos.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string val;
                if (ColaboradoringresoNegEmpleados.Text == "")
                {
                    val = "0";

                }
                else {
                    val = ColaboradoringresoNegEmpleados.Text;
                }

                mest.executesql("INSERT INTO `EP_ColaboradorIngresoNegocio`(`LoteID`, `ColaboradorID`, `ColaboradoringresoNegID`, `TipoNegocioID`, `ColaboradoringresoNegNombre`, `ColaboradoringresoNegPatente`, `ColaboradoringresoNegEmpleados`, `ColaboradoringresoNegObjeto`, `ColaboradoringresoNegIngresos`, `ColaboradoringresoNegEgresos`, `ColaboradoringresoNegDireccion`)  " +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + TipoNegocioID.SelectedValue + "','" + ColaboradoringresoNegNombre.Text + "','" + ColaboradoringresoNegPatente.Text + "','" + val + "','" + ColaboradoringresoNegObjeto.Text + "' ,'" + d1 + "' ,'" + d2 + "' ,'" + ColaboradoringresoNegDireccion.Text + "')");
                TipoNegocioID.SelectedIndex = 0;


                ColaboradoringresoNegNombre.Text = "";
                ColaboradoringresoNegPatente.Text = "";
                ColaboradoringresoNegEmpleados.Text = "";
                ColaboradoringresoNegObjeto.Text = "";
                ColaboradoringresoNegIngresos.Text = "";
                ColaboradoringresoNegEgresos.Text = "";
                ColaboradoringresoNegDireccion.Text = "";



                lblSuccessMessage1.Visible = true;
              


            }
            else
            {
                lblerror.Visible = true;

            }
        }

        protected void TipoNegocioID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoNegocioID.SelectedValue == "2")
            {

                ColaboradoringresoNegPatente.Enabled = false;
            }
            else {
                ColaboradoringresoNegPatente.Enabled = true;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
 
            if (!IsPostBack)
            {
                mest.llenadocombo("SELECT * FROM `Gen_TipoNegocio`", TipoNegocioID, "TipoNegocioDescripcion", "TipoNegocioID", "Tipo-Negocio");
          

            }

        }


        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
           
        

        }
    }
}