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
    public partial class VentanaVehiculos : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

        protected void btnbienes_Click(object sender, EventArgs e)
        {
            if (ColaboradorActivoVehPropietari.SelectedIndex != 0 && TipoVehiculoID.SelectedIndex != 0 && ColaboradorActivoVehMarca.Text != ""  && ColaboradorActivoVehLinea.Text != "" && ColaboradorActivoVehModelo.Text != "" && ColaboradorActivoVehPlaca.Text != ""  )
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorActivosVehiculos", "ColaboradorActivoVehID");

                string valor = ColaboradorActivoVehPropietari.SelectedValue;
                string valor2;
                if (valor == "True") {

                     valor2 ="1" ;
                }
                else {

                     valor2 = "0";
                }
                
                mest.executesql("INSERT INTO `EP_ColaboradorActivosVehiculos`(`LoteID`, `ColaboradorID`, `ColaboradorActivoVehID`, `ColaboradorActivoVehPropietari`, `TipoVehiculoID`, `ColaboradorActivoVehMarca`, `ColaboradorActivoVehLinea`, `ColaboradorActivoVehModelo`, `ColaboradorActivoVehPlaca`, `ColaboradorActivoVehComentario`, `ColaboradorActivoVehNombre`, `ColaboradorActivoVehMotivo`, ColaboradorActivoVehValor) " +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + valor2 + "','" + TipoVehiculoID.SelectedValue + "','" + ColaboradorActivoVehMarca.Text + "','" + ColaboradorActivoVehLinea.Text + "','" + ColaboradorActivoVehModelo.Text + "','" + ColaboradorActivoVehPlaca.Text + "','" + ColaboradorActivoVehComentario.Text + "','" + ColaboradorActivoVehNombre.Text + "' , '" + ColaboradorActivoVehMotivo.Text + "', '" + Convert.ToDecimal(ColaboradorActivoVehValor.Text.Replace(",", "")) + "')");
                ColaboradorActivoVehPropietari.SelectedIndex = 0;
                TipoVehiculoID.SelectedIndex = 0;

                ColaboradorActivoVehMarca.Text = "";
                ColaboradorActivoVehLinea.Text = "";
                ColaboradorActivoVehModelo.Text = "";
                ColaboradorActivoVehPlaca.Text = "";
                ColaboradorActivoVehComentario.Text = "";
                ColaboradorActivoVehNombre.Text = "";
                ColaboradorActivoVehMotivo.Text = "";
                ColaboradorActivoVehValor.Text = "";
                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;


            }
            else
            {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;

            }
        }

        protected void ColaboradorActivoVehPropietari_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = ColaboradorActivoVehPropietari.SelectedValue;
            if(valor == "True"){
                ColaboradorActivoVehNombre.Enabled = false;
                ColaboradorActivoVehMotivo.Enabled = false;
            }
            else {
                ColaboradorActivoVehNombre.Enabled = true;
                ColaboradorActivoVehMotivo.Enabled = true;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {
                mest.llenadocombo("SELECT * FROM `Gen_TipoVehiculo`", TipoVehiculoID, "TipoVehiculoDescripcion", "TipoVehiculoID", "Tipo-Vehículo");
         

            }

        }


        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
           
        

        }
    }
}