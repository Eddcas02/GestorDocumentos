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
    public partial class VentanaContingente : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;






        protected void btntc_Click(object sender, EventArgs e)
        {
            double dato = (ColaboradorPasivoContSaldo.Text == "") ? Convert.ToDouble(ColaboradorPasivoContSaldo.Text = "0") : Convert.ToDouble(ColaboradorPasivoContSaldo.Text.Replace(",", ""));

            if (EntidadFinCodigo.SelectedIndex != 0 && dato>0 &&ColaboradorPasivoContDeudor.Text != "" && ColaboradorPasivoContRelacion.Text != "" && ColaboradorPasivoContSaldo.Text != "" && ColaboradorPasivoContFechaDese.Text != "" && ColaboradorPasivoContFechaFin.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorPasivoContin", "ColaboradorPasivoContID");

                string c1 = ColaboradorPasivoContSaldo.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
              


                mest.executesql("INSERT INTO `EP_ColaboradorPasivoContin`(`LoteID`, `ColaboradorID`, `ColaboradorPasivoContID`, `EntidadFinCodigo`, `ColaboradorPasivoContDeudor`, `ColaboradorPasivoContRelacion`, `ColaboradorPasivoContSaldo`, `ColaboradorPasivoContFechaDese`, `ColaboradorPasivoContFechaFin`)  " +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','"  + EntidadFinCodigo.SelectedValue + "','" + ColaboradorPasivoContDeudor.Text + "','" + ColaboradorPasivoContRelacion.Text + "','" + d1 + "', '"+ ColaboradorPasivoContFechaDese.Text+ "', '"+ ColaboradorPasivoContFechaFin.Text+"')");
         
                EntidadFinCodigo.SelectedIndex = 0;


                ColaboradorPasivoContDeudor.Text = "";
                ColaboradorPasivoContRelacion.Text = "";
                ColaboradorPasivoContSaldo.Text = "";
                ColaboradorPasivoContFechaDese.Text = "";
                ColaboradorPasivoContFechaFin.Text = "";



                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;


            }
            else
            {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;
            }
        }

        protected void ColaboradorPasivoContFechaDese_TextChanged(object sender, EventArgs e)
        {
         
            ColaboradorPasivoContFechaFin.Text = "";
            ColaboradorPasivoContFechaFin.Attributes.Add("min",ColaboradorPasivoContFechaDese.Text);
            
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