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
    public partial class est_cuentaspp : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;
        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
            estadoep = Convert.ToString(Session["estadoepp"]);
            if (estadoep == "0")
            {
                blk.Text = "0";
                ScriptManager.RegisterStartupScript(this, this.Page.GetType(), "bloqueado", "bloqueado();", true);

            }
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            loteact = lte.lotevalido();
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {

                llenartabla(cuentaspc, mest.llenardgvcuentaspc(cifglobal, lote));
             

            }
        }
        public void llenartabla(GridView dgv, DataTable dt)
        {
            DataTable dt1 = new DataTable();
            dt1 = dt;
            dgv.DataSource = dt1;
            dgv.DataBind();

        }
        public void llenadocombo(string sql, DropDownList drp, string textfield, string valuecode, string valorcero)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string QueryString = sql;
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds, "usuarios");
                    drp.DataSource = ds;
                    drp.DataTextField = textfield;
                    drp.DataValueField = valuecode;
                    drp.DataBind();
                    drp.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[" + valorcero + "]", "0"));
                }
                catch { Console.WriteLine("Verifique los campos"); }
            }
        }

        protected void cuentaspc_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            cuentaspc.EditIndex = -1;
            llenartabla(cuentaspc, mest.llenardgvcuentaspc(cifglobal, lote));
        }

        protected void cuentaspc_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorPasivoCXP` SET `ColaboradorPasivoCXPOrigen`='" + (cuentaspc.Rows[e.RowIndex].FindControl("ColaboradorPasivoCXPOrigen") as TextBox).Text + "'," +
                    "`ColaboradorPasivoCXPDescripcio`='" + (cuentaspc.Rows[e.RowIndex].FindControl("ColaboradorPasivoCXPDescripcio") as TextBox).Text + "'," +
                    "`ColaboradorPasivoCXPMonto`='" + Convert.ToDecimal((cuentaspc.Rows[e.RowIndex].FindControl("ColaboradorPasivoCXPMonto") as TextBox).Text.Replace(",", "")) + "'" +
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorPasivoCXPID = '" + (cuentaspc.Rows[e.RowIndex].FindControl("ColaboradorPasivoCXPID") as Label).Text + "' AND LoteID  = '"+lote+"' ");




                cuentaspc.EditIndex = -1;
                llenartabla(cuentaspc, mest.llenardgvcuentaspc(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void cuentaspc_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorPasivoCXP` WHERE ColaboradorPasivoCXPID = '" + cuentaspc.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(cuentaspc, mest.llenardgvcuentaspc(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro eliminado exitosamente";
                lblErrorMessage1.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void cuentaspc_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cuentaspc.PageIndex = e.NewPageIndex;
            llenartabla(cuentaspc, mest.llenardgvcuentaspc(cifglobal, lote));
        }

        protected void cuentaspc_RowEditing(object sender, GridViewEditEventArgs e)
        {
            cuentaspc.EditIndex = e.NewEditIndex;
            llenartabla(cuentaspc, mest.llenardgvcuentaspc(cifglobal, lote));
                  }

     

        protected void btncuentaspc_Click(object sender, EventArgs e)
        {

        }
 
        //INVERSIONES

        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            llenartabla(cuentaspc, mest.llenardgvcuentaspc(cifglobal, lote));

        }

        


        public void cargarcomboengrid(GridViewEditEventArgs e, GridView grid, string idlabel, string dropdowncargar, string campo, string tabla, string campowhere)
        {
            Label lblFrom = (Label)grid.Rows[e.NewEditIndex].FindControl(idlabel);
            DropDownList dropmodalidad = (DropDownList)grid.Rows[e.NewEditIndex].FindControl(dropdowncargar);
            string data = mest.cargacombogrid(campo, tabla, campowhere, lblFrom.Text);
            dropmodalidad.SelectedValue = data;


        }

        protected void btncuentaspp_Click(object sender, EventArgs e)
        {

        }

        protected void btncuentaspcpp_Click(object sender, EventArgs e)
        {

        }


        protected void inversionesbtn_Click(object sender, EventArgs e)
        {

        }
    }
}