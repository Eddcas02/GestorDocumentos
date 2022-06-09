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
    public partial class VentanaPrestamos : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;






        protected void btntc_Click(object sender, EventArgs e)
        {
            if (TipoPrestamoID.SelectedIndex != 0 && EntidadFinCodigo.SelectedIndex != 0 && ColaboradorPasivoPrestMontoIni.Text != "" && ColaboradorPasivoPrestSaldo.Text != "" && ColaboradorPasivoPrestDestino.Text != "" && ColaboradorPasivoPrestFecDesem.Text != "" && ColaboradorPasivoPrestFecFinal.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorPasivoPrestamo", "ColaboradorPasivoPrestID");

                string c1 = ColaboradorPasivoPrestMontoIni.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string c2 = ColaboradorPasivoPrestSaldo.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));


                mest.executesql("INSERT INTO `EP_ColaboradorPasivoPrestamo`(`LoteID`, `ColaboradorID`, `ColaboradorPasivoPrestID`, `TipoPrestamoID`, `EntidadFinCodigo`, `ColaboradorPasivoPrestMontoIni`, `ColaboradorPasivoPrestSaldo`, `ColaboradorPasivoPrestDestino`, `ColaboradorPasivoPrestFecDesem`, `ColaboradorPasivoPrestFecFinal`) " +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + TipoPrestamoID.SelectedValue + "','" + EntidadFinCodigo.SelectedValue + "','" + d1 + "','" + d2 + "','" + ColaboradorPasivoPrestDestino.Text + "', '"+ColaboradorPasivoPrestFecDesem.Text+ "', '"+ColaboradorPasivoPrestFecFinal.Text+"')");
                TipoPrestamoID.SelectedIndex = 0;
                EntidadFinCodigo.SelectedIndex = 0;


                ColaboradorPasivoPrestMontoIni.Text = "";
                ColaboradorPasivoPrestSaldo.Text = "";
                ColaboradorPasivoPrestDestino.Text = "";
                ColaboradorPasivoPrestFecDesem.Text = "";
                ColaboradorPasivoPrestFecFinal.Text = "";


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

                 mest.llenadocombo("SELECT * FROM  Gen_TipoPrestamo", TipoPrestamoID, "TipoPrestamoDescripcion", "TipoPrestamoID", "Tipo-Prestamo");
          

            }

        }


        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
           
        

        }
    }
}