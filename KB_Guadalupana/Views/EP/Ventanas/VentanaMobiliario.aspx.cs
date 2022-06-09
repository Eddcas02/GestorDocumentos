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
    public partial class VentanaMobiliario : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

    

        protected void btnmobiliario_Click(object sender, EventArgs e)
        {
            if (TipoEquipoID.Text != "" && ColaboradorActivoEqValor.Text != "" )
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorActivosEquipo", "ColaboradorActivoEqID");
                string c1 = ColaboradorActivoEqValor.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                mest.executesql("INSERT INTO `EP_ColaboradorActivosEquipo`(`LoteID`, `ColaboradorID`, `ColaboradorActivoEqID`, `TipoEquipoID`, `ColaboradorActivoEqValor`, `ColaboradorActivoEqDescripcion`)" +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + TipoEquipoID.Text + "','" + d1 + "','" + ColaboradorActivoEqDescripcion.Text + "')");

                TipoEquipoID.Text = "";
                ColaboradorActivoEqValor.Text = "";
                ColaboradorActivoEqDescripcion.Text = "";

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


    }
}