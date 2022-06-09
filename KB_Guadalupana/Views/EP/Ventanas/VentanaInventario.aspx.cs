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
    public partial class VentanaInventario : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

        protected void agregarinventario_Click(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(ColaboradorActivoInvValor.Text.Replace(",", ""));
            if (ColaboradorActivoInvTipo.Text != "" && ColaboradorActivoInvValor.Text != "" && dato>0)
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorActivosInv", "ColaboradorActivoInvID");
                string c1 = ColaboradorActivoInvValor.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                mest.executesql("INSERT INTO `EP_ColaboradorActivosInv`(`LoteID`, `ColaboradorID`, `ColaboradorActivoInvID`, `ColaboradorActivoInvTipo`, `ColaboradorActivoInvValor`)" +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + ColaboradorActivoInvTipo.Text + "','" + d1 + "')");

                ColaboradorActivoInvTipo.Text = "";
                ColaboradorActivoInvValor.Text = "";
                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;

            }
            else
            {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
   
        }

        protected void guardarinversiones(object sender, EventArgs e)
        {
          

        }
    }
}