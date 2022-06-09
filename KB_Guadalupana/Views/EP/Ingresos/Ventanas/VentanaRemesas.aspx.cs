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
    public partial class VentanaRemesas : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

       

     


        protected void btntc_Click(object sender, EventArgs e)
        {
            if (ColaboradorIngresoRemesaRemite.Text != "" && ColaboradorIngresoRemesaRelaci.Text != "" && ColaboradorIngresoRemesaPromed.Text != "" && ColaboradorIngresoRemesaPeriod.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorIngresoRemesa", "ColaboradoringresoRemesaID");

                string c1 = ColaboradorIngresoRemesaPromed.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
       
                mest.executesql("INSERT INTO `EP_ColaboradorIngresoRemesa`(`LoteID`, `ColaboradorID`, `ColaboradoringresoRemesaID`, `ColaboradorIngresoRemesaRemite`, `ColaboradorIngresoRemesaRelaci`, `ColaboradorIngresoRemesaPromed`, `ColaboradorIngresoRemesaPeriod`) " +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + ColaboradorIngresoRemesaRemite.Text + "','" + ColaboradorIngresoRemesaRelaci.Text + "','" + d1 + "','" + ColaboradorIngresoRemesaPeriod.Text + "')");
             


                ColaboradorIngresoRemesaRemite.Text = "";
                ColaboradorIngresoRemesaRelaci.Text = "";
                ColaboradorIngresoRemesaPromed.Text = "";
                ColaboradorIngresoRemesaPeriod.Text = "";



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


        }


        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
           
        

        }
    }
}