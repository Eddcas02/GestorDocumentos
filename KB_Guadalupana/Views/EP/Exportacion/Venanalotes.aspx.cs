using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KB_Guadalupana.Controllers;
using System.Data;
using MySql.Data.MySqlClient;

namespace KB_Guadalupana.Views.EP
{
    public partial class Venanalotes : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre;
        string[] loteact; string val2;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                mest.llenadocombo("SELECT * FROM `EP_Lote`", lotes, "LoteDescripcion", "LoteID", "Lote");

            }
        }

        protected void ModificarLote_Click(object sender, EventArgs e)
        {
            if (LoteDescripcion.Text != "" && LoteFecInicio.Text != "" && LoteFecFin.Text != "" && LoteEstado.SelectedIndex != 0 && LoteTipoCambio.Text != "")
            {
                string val = LoteEstado.SelectedValue;

                if (val == "True")
                {
                    val2 = "1";
                }
                else
                {
                    val2 = "0";
                }
                try
                {
                    decimal v2 = Convert.ToDecimal(LoteTipoCambio.Text.ToString());
                    string update = "UPDATE `EP_Lote` SET `LoteDescripcion`='" + LoteDescripcion.Text + "',`LoteFecInicio`='" + LoteFecInicio.Text + "',`LoteFecFin`='" + LoteFecFin.Text + "',`LoteEstado`='" + val2 + "',`LoteTipoCambio`='" + v2 + "', LoteFecData = '"+ LoteFecData.Text + "' WHERE `LoteID`= '" + lotes.SelectedValue + "'";

                    mest.executesql(update);
                    LoteDescripcion.Text = "";
                    LoteFecInicio.Text = "";
                    LoteFecFin.Text = "";
                    LoteFecData.Text = "";
                    LoteEstado.SelectedValue = "";
                    LoteTipoCambio.Text = "";
                    lblerror.Visible = false;
                    lblSuccessMessage1.Visible = true;

                }
                catch (Exception ex)
                {

                    lblerror.Text = ex.Message;
                }


            }
            else
            {
                lblerror.Text = "Error al Actualizar";
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;

            }

        }

        protected void lotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            loteact = lte.lotevalidoid(lotes.SelectedValue);
            LoteDescripcion.Text = loteact[1];
            LoteTipoCambio.Text = loteact[5];
            LoteFecInicio.Text = loteact[7];
            LoteFecFin.Text = loteact[8];
            LoteEstado.SelectedValue = loteact[4];
            LoteFecData.Text = loteact[6];
        }

        protected void habil_CheckedChanged(object sender, EventArgs e)
        {
            if (habil.Checked)
            {
                btncrearlote.Visible = false;
                ModificarLote.Visible = true;
                lotes.Visible = true;

                LoteDescripcion.Text = "";
                LoteFecInicio.Text = "";
                LoteFecFin.Text = "";
                LoteEstado.Text = "";
                LoteFecData.Text = "";
                LoteTipoCambio.Text = "";
            }
            else
            {

                btncrearlote.Visible = true;
                ModificarLote.Visible = false;
                lotes.Visible = false;
                LoteDescripcion.Text = "";
                LoteFecInicio.Text = "";
                LoteFecFin.Text = "";
                LoteFecData.Text = "";
                LoteEstado.Text = "";
                LoteTipoCambio.Text = "";
            }
        }

        protected void btncrearlote_Click(object sender, EventArgs e)
        {

            if (LoteDescripcion.Text != "" && LoteFecInicio.Text != "" && LoteFecFin.Text != "" && LoteEstado.SelectedIndex != 0 && LoteTipoCambio.Text != "")
            {
                string valor = LoteEstado.Text;
                string val2;
                if (valor == "True")
                {
                    val2 = "1";
                }
                else
                {
                    val2 = "0";
                }

                try
                {
                    decimal v2 = Convert.ToDecimal(LoteTipoCambio.Text.ToString());
                    string ult = mest.obtenerultimo("EP_Lote", "LoteID");
                    string Insert = "INSERT INTO `EP_Lote`(`LoteID`, `LoteDescripcion`, `LoteFecInicio`, `LoteFecFin`, `LoteEstado`,LoteTipoCambio, LoteFecData )" +
                        " VALUES ('" + ult + "','" + LoteDescripcion.Text + "','" + LoteFecInicio.Text + "','" + LoteFecFin.Text + "','" + val2 + "', '" + v2 + "', '"+ LoteFecData.Text + "')";

                    mest.executesql(Insert);
                    LoteDescripcion.Text = "";
                    LoteFecInicio.Text = "";
                    LoteFecFin.Text = "";
                    LoteTipoCambio.Text = "";
                    LoteEstado.SelectedValue = "";
                    LoteFecData.Text = "";
                    lblerror.Visible = false;
                    lblSuccessMessage1.Visible = true;
                }
                catch (Exception ex)
                {

                    lblerror.Text = ex.Message;
                }

            }
            else
            {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;

            }

        }






    }
}