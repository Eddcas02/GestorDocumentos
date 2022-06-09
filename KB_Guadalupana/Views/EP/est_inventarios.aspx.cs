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
    public partial class est_inventarios : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;
        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            estadoep = Convert.ToString(Session["estadoepp"]);
            if (estadoep == "0")
            {
                blk.Text = "0";
                ScriptManager.RegisterStartupScript(this, this.Page.GetType(), "bloqueado", "bloqueado();", true);

            }
            loteact = lte.lotevalido();
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {

                llenartabla(inventarios, mest.llenarinventarios(cifglobal, lote));
              

            }
        }
        public void llenartabla(GridView dgv, DataTable dt)
        {
            DataTable dt1 = new DataTable();
            dt1 = dt;
            dgv.DataSource = dt1;
            dgv.DataBind();

        }
        protected void inventarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void inventarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            inventarios.EditIndex = -1;
            llenartabla(inventarios, mest.llenarinventarios(cifglobal, lote));
        }

        protected void inventarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorActivosInv` SET `ColaboradorActivoInvTipo`='" + (inventarios.Rows[e.RowIndex].FindControl("ColaboradorActivoInvTipo") as TextBox).Text + "'," +
                    "`ColaboradorActivoInvValor`='" + Convert.ToDecimal((inventarios.Rows[e.RowIndex].FindControl("ColaboradorActivoInvValor") as TextBox).Text.Replace(",", "")) + "'" +
                  
         
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorActivoInvID = '" + (inventarios.Rows[e.RowIndex].FindControl("ColaboradorActivoInvID") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                inventarios.EditIndex = -1;
                llenartabla(inventarios, mest.llenarinventarios(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void inventarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorActivosInv` WHERE ColaboradorActivoInvID = '" + inventarios.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(inventarios, mest.llenarinventarios(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro eliminado exitosamente";
                lblErrorMessage1.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void inventarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            inventarios.PageIndex = e.NewPageIndex;
            llenartabla(inventarios, mest.llenarinventarios(cifglobal, lote));
        }

        protected void btncuentasx_Click(object sender, EventArgs e)
        {

        }

        protected void btninventario_Click(object sender, EventArgs e)
        {

        }

        protected void cerrar2_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            llenartabla(inventarios, mest.llenarinventarios(cifglobal, lote));

        }

        protected void inventarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            inventarios.EditIndex = e.NewEditIndex;
            llenartabla(inventarios, mest.llenarinventarios(cifglobal, lote));


        }
      


    }
}