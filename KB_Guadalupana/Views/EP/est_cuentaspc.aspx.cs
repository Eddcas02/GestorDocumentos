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
    public partial class est_cuentaspc : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;
        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            estadoep = Convert.ToString(Session["estadoepp"]);
            if (estadoep == "0")
            {
                blk.Text = "0";
                ScriptManager.RegisterStartupScript(this, this.Page.GetType(), "bloqueado", "bloqueado();", true);

            }
            lote = Convert.ToString(Session["lotepasa"]);
            loteact = lte.lotevalido();
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {

                llenartabla(cuentasxcx, mest.llenarcpc(cifglobal, lote));
              

            }
        }
        public void llenartabla(GridView dgv, DataTable dt)
        {
            DataTable dt1 = new DataTable();
            dt1 = dt;
            dgv.DataSource = dt1;
            dgv.DataBind();

        }
        protected void cuentasxcx_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void cuentasxcx_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            cuentasxcx.EditIndex = -1;
            llenartabla(cuentasxcx, mest.llenarcpc(cifglobal, lote));
        }

        protected void cuentasxcx_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                 mest.executesql(" UPDATE `EP_ColaboradorActivosCXC` SET `ColaboradorActivoCXCOrigen`='" + (cuentasxcx.Rows[e.RowIndex].FindControl("txtorigen") as TextBox).Text + "'," +
                    "`ColaboradorActivoCXCMonto`='" + Convert.ToDecimal((cuentasxcx.Rows[e.RowIndex].FindControl("montotxt") as TextBox).Text.Replace(",", "")) + "'" +
                    ",`ColaboradorActivoCXCMotivo`='" + (cuentasxcx.Rows[e.RowIndex].FindControl("txtmotivo") as TextBox).Text + "'" +
         
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorActivoCXCID = '" + (cuentasxcx.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                cuentasxcx.EditIndex = -1;
                llenartabla(cuentasxcx, mest.llenarcpc(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void cuentasxcx_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorActivosCXC` WHERE ColaboradorActivoCXCID = '" + cuentasxcx.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(cuentasxcx, mest.llenarcpc(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro eliminado exitosamente";
                lblErrorMessage1.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void cuentasxcx_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cuentasxcx.PageIndex = e.NewPageIndex;
            llenartabla(cuentasxcx, mest.llenarcpc(cifglobal, lote));
        }

        protected void btncuentasx_Click(object sender, EventArgs e)
        {

        }

        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            llenartabla(cuentasxcx, mest.llenarcpc(cifglobal, lote));
        }

        protected void cuentasxcx_RowEditing(object sender, GridViewEditEventArgs e)
        {
            cuentasxcx.EditIndex = e.NewEditIndex;
            llenartabla(cuentasxcx, mest.llenarcpc(cifglobal, lote));


        }
      


    }
}