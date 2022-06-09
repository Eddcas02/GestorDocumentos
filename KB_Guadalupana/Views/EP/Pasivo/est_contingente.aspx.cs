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
    public partial class est_contingente : System.Web.UI.Page
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

                llenartabla(contingente, mest.llenardgvcontingente(cifglobal, lote));
             

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

        protected void contingente_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            contingente.EditIndex = -1;
            llenartabla(contingente, mest.llenardgvcontingente(cifglobal, lote));
        }

        protected void contingente_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string c1 = (contingente.Rows[e.RowIndex].FindControl("ColaboradorPasivoContSaldo") as TextBox).Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));

                mest.executesql(" UPDATE `EP_ColaboradorPasivoContin` SET `EntidadFinCodigo`='" + (contingente.Rows[e.RowIndex].FindControl("EntidadFinCodigo") as DropDownList).SelectedValue + "'," +
                    "`ColaboradorPasivoContDeudor`='" + (contingente.Rows[e.RowIndex].FindControl("ColaboradorPasivoContDeudor") as TextBox).Text + "'," +
                    "`ColaboradorPasivoContRelacion`='" + (contingente.Rows[e.RowIndex].FindControl("ColaboradorPasivoContRelacion") as TextBox).Text + "'," +
                    "`ColaboradorPasivoContSaldo`='" + d1 + "'," +
                    "`ColaboradorPasivoContFechaDese`='" + (contingente.Rows[e.RowIndex].FindControl("ColaboradorPasivoContFechaDese") as TextBox).Text + "'," +
                    "`ColaboradorPasivoContFechaFin`='" + (contingente.Rows[e.RowIndex].FindControl("ColaboradorPasivoContFechaFin") as TextBox).Text + "'" +
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorPasivoContID = '" + (contingente.Rows[e.RowIndex].FindControl("ColaboradorPasivoContID") as Label).Text + "' AND LoteID  = '"+lote+"' ");




                contingente.EditIndex = -1;
                llenartabla(contingente, mest.llenardgvcontingente(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void contingente_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorPasivoContin` WHERE ColaboradorPasivoContID = '" + contingente.DataKeys[e.RowIndex].Value.ToString() + "' AND ColaboradorID = '" + cifglobal + "'  AND LoteID  = '" + lote + "'  ");

                llenartabla(contingente, mest.llenardgvcontingente(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro eliminado exitosamente";
                lblErrorMessage1.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void contingente_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            contingente.PageIndex = e.NewPageIndex;
            llenartabla(contingente, mest.llenardgvcontingente(cifglobal, lote));
        }

        protected void contingente_RowEditing(object sender, GridViewEditEventArgs e)
        {
            contingente.EditIndex = e.NewEditIndex;
            llenartabla(contingente, mest.llenardgvcontingentef(cifglobal, lote));

            cargarcomboengrid(e, contingente, "ColaboradorPasivoContID", "EntidadFinCodigo", "EntidadFinCodigo", "EP_ColaboradorPasivoContin", "ColaboradorPasivoContID");
        }



        protected void btncontingente_Click(object sender, EventArgs e)
        {

        }
 
        //INVERSIONES

        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            llenartabla(contingente, mest.llenardgvcontingente(cifglobal, lote));

        }

        


        public void cargarcomboengrid(GridViewEditEventArgs e, GridView grid, string idlabel, string dropdowncargar, string campo, string tabla, string campowhere)
        {
            Label lblFrom = (Label)grid.Rows[e.NewEditIndex].FindControl(idlabel);
            DropDownList dropmodalidad = (DropDownList)grid.Rows[e.NewEditIndex].FindControl(dropdowncargar);
            string data = mest.cargacombogrid(campo, tabla, campowhere, lblFrom.Text);
            dropmodalidad.SelectedValue = data;


        }

        public void fechasgrid(GridViewEditEventArgs e, GridView grid)
        {
            TextBox ColaboradorPasivoContFechaDese = (TextBox)grid.Rows[e.NewEditIndex].FindControl("ColaboradorPasivoContFechaDese");
            TextBox ColaboradorPasivoContFechaFin = (TextBox)grid.Rows[e.NewEditIndex].FindControl("ColaboradorPasivoContFechaFin");
    
            ColaboradorPasivoContFechaFin.Text = "";

            ColaboradorPasivoContFechaFin.Attributes.Add("min", ColaboradorPasivoContFechaDese.Text);

        }
        protected void btncuentaspp_Click(object sender, EventArgs e)
        {

        }

        protected void contingente_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && contingente.EditIndex == e.Row.RowIndex)
            {

                DropDownList drp1 = (DropDownList)e.Row.FindControl("EntidadFinCodigo");




                llenadocombo("SELECT * FROM `Gen_EntidadFinanciera`", drp1, "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");

            }
        }

        protected void ColaboradorPasivoContFechaDese_TextChanged(object sender, EventArgs e)
        {
           

         
        }

        protected void btncontingentebt_Click(object sender, EventArgs e)
        {

        }


        protected void inversionesbtn_Click(object sender, EventArgs e)
        {

        }
    }
}