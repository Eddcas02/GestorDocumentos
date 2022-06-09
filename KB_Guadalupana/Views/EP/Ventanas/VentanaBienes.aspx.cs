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
    public partial class VentanaBienes : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

        protected void btnbienes_Click(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(ColaboradorActivoBIValor.Text.Replace(",", ""));
            if (TipoPresuncionID.SelectedValue == "1")
            {
                if (TipoPresuncionID.SelectedIndex != 0 && TipoInmuebleID.SelectedIndex != 0 && ColaboradorActivoBIFinca.Text != "" && ColaboradorActivoBIFolio.Text != "" && ColaboradorActivoBILibro.Text != "" && ColaboradorActivoBIDireccon.Text != "" && ColaboradorActivoBIValor.Text != "" && dato>0)
                {
                    string[] infolote = lt.lotevalido();
                    string ult = mest.obtenerultimo("EP_ColaboradorActivosBienes", "ColaboradorActivoBIID");
                    string c1 = ColaboradorActivoBIValor.Text;
                    decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                    mest.executesql("INSERT INTO `EP_ColaboradorActivosBienes`(`LoteID`, `ColaboradorID`, `ColaboradorActivoBIID`, `TipoPresuncionID`, `TipoInmuebleID`, `ColaboradorActivoBIFinca`, `ColaboradorActivoBIFolio`, `ColaboradorActivoBILibro`, `ColaboradorActivoBIDireccon`, `ColaboradorActivoBIValor`, `ColaboradorActivoBIComentario`) " +
                        " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + TipoPresuncionID.SelectedValue + "','" + TipoInmuebleID.SelectedValue + "','" + ColaboradorActivoBIFinca.Text + "','" + ColaboradorActivoBIFolio.Text + "','" + ColaboradorActivoBILibro.Text + "','" + ColaboradorActivoBIDireccon.Text + "','" + d1 + "','" + ColaboradorActivoBIComentario.Text + "')");
                    TipoPresuncionID.SelectedIndex = 0;
                    TipoInmuebleID.SelectedIndex = 0;

                    ColaboradorActivoBIFinca.Text = "";
                    ColaboradorActivoBIFolio.Text = "";
                    ColaboradorActivoBILibro.Text = "";
                    ColaboradorActivoBIDireccon.Text = "";
                    ColaboradorActivoBIValor.Text = "";
                    ColaboradorActivoBIComentario.Text = "";


                    lblSuccessMessage1.Visible = true;
                    lblerror.Visible = false;

                }
                else
                {
                    lblerror.Visible = true;
                    lblSuccessMessage1.Visible = false;

                }
            }
            else {
                if (TipoPresuncionID.SelectedIndex != 0 && TipoInmuebleID.SelectedIndex != 0 && ColaboradorActivoBIDireccon.Text != "" && ColaboradorActivoBIValor.Text != ""&& dato>0)
                {
                    string[] infolote = lt.lotevalido();
                    string ult = mest.obtenerultimo("EP_ColaboradorActivosBienes", "ColaboradorActivoBIID");
                    string c1 = ColaboradorActivoBIValor.Text;
                    decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                    mest.executesql("INSERT INTO `EP_ColaboradorActivosBienes`(`LoteID`, `ColaboradorID`, `ColaboradorActivoBIID`, `TipoPresuncionID`, `TipoInmuebleID`, `ColaboradorActivoBIFinca`, `ColaboradorActivoBIFolio`, `ColaboradorActivoBILibro`, `ColaboradorActivoBIDireccon`, `ColaboradorActivoBIValor`, `ColaboradorActivoBIComentario`) " +
                        " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + TipoPresuncionID.SelectedValue + "','" + TipoInmuebleID.SelectedValue + "','0','0','0','" + ColaboradorActivoBIDireccon.Text + "','" + d1 + "','" + ColaboradorActivoBIComentario.Text + "')");
                    TipoPresuncionID.SelectedIndex = 0;
                    TipoInmuebleID.SelectedIndex = 0;

                    ColaboradorActivoBIFinca.Text = "";
                    ColaboradorActivoBIFolio.Text = "";
                    ColaboradorActivoBILibro.Text = "";
                    ColaboradorActivoBIDireccon.Text = "";
                    ColaboradorActivoBIValor.Text = "";
                    ColaboradorActivoBIComentario.Text = "";


                    lblSuccessMessage1.Visible = true;
                    lblerror.Visible = false;

                }
                else
                {
                    lblerror.Visible = true;
                    lblSuccessMessage1.Visible = false;

                }
            }
        }

        protected void TipoPresuncionID_TextChanged(object sender, EventArgs e)
        {
            string valor = mest.obligar(TipoPresuncionID.SelectedValue);
            if (valor == "1")
            {
                ColaboradorActivoBIFinca.Attributes.Add("required", "true");
                ColaboradorActivoBIFolio.Attributes.Add("required", "true");
                ColaboradorActivoBILibro.Attributes.Add("required", "true");
                ColaboradorActivoBIFinca.Enabled = true;
                ColaboradorActivoBIFolio.Enabled = true;
                ColaboradorActivoBILibro.Enabled = true;
            }
            else {

                ColaboradorActivoBIFinca.Attributes.Add("Text", "0");
                ColaboradorActivoBIFolio.Attributes.Add("Text", "0");
                ColaboradorActivoBILibro.Attributes.Add("Text", "0");
                ColaboradorActivoBIFinca.Enabled = false;
                ColaboradorActivoBIFolio.Enabled = false;
                ColaboradorActivoBILibro.Enabled = false;
      
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {
                mest.llenadocombo("SELECT * FROM `Gen_TipoPresuncion`", TipoPresuncionID, "TipoPresuncionDescripcion", "TipoPresuncionID", "Presuncion");
                mest.llenadocombo("SELECT * FROM `Gen_TipoInmueble`", TipoInmuebleID, "TipoInmuebleDescripcion", "TipoInmuebleID", "Tipo Inmueble");

            }

        }


        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
           
        

        }
    }
}