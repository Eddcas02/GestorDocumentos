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
    public partial class VentanaTC : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

       

     


        protected void btntc_Click(object sender, EventArgs e)
        {
            if (EntidadFinCodigo.SelectedIndex != 0 && ColaboradorPasivoTCLimiteQ.Text != "" && ColaboradorPasivoTCLimiteUS.Text != "" && ColaboradorPasivoTCSaldoQ.Text != "" && ColaboradorPasivoTCSaldoUS.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorPasivoTC", "ColaboradorPasivoTCID");

                string c1 = ColaboradorPasivoTCLimiteQ.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string c2 = ColaboradorPasivoTCLimiteUS.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string c3 = ColaboradorPasivoTCSaldoQ.Text;
                decimal d3 = Convert.ToDecimal(c3.Replace(",", ""));
                string c4 = ColaboradorPasivoTCSaldoUS.Text;
                decimal d4 = Convert.ToDecimal(c4.Replace(",", ""));

                mest.executesql("INSERT INTO `EP_ColaboradorPasivoTC`(`LoteID`, `ColaboradorID`, `ColaboradorPasivoTCID`, `EntidadFinCodigo`, `ColaboradorPasivoTCLimiteQ`, `ColaboradorPasivoTCLimiteUS`, `ColaboradorPasivoTCSaldoQ`, `ColaboradorPasivoTCSaldoUS`) " +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + EntidadFinCodigo.SelectedValue + "','" + d1 + "','" + d2 + "','" + d3 + "','" + d4 + "')");
                EntidadFinCodigo.SelectedIndex = 0;


                ColaboradorPasivoTCLimiteQ.Text = "";
                ColaboradorPasivoTCLimiteUS.Text = "";
                ColaboradorPasivoTCSaldoQ.Text = "";
                ColaboradorPasivoTCSaldoUS.Text = "";



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

            if (!IsPostBack)
            {
                mest.llenadocombo("SELECT * FROM `Gen_EntidadFinanciera` ORDER BY EntidadFinPrioridad DESC ", EntidadFinCodigo, "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");


            }

        }


        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
           
        

        }
    }
}