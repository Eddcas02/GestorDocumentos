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
    public partial class est_telefonos : System.Web.UI.Page
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



                mest.llenartabla(contactoemergen, mest.llenardgvemergencia(cifglobal, lote));
                mest.llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));

            }

        }



        protected void contactoemergen_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && contactoemergen.EditIndex == e.Row.RowIndex)
            {

                DropDownList dropuniveriti = (DropDownList)e.Row.FindControl("tipoparentesco");

                mest.llenadocombo("SELECT * FROM `Gen_TipoParentesco`", dropuniveriti, "TipoParentescoDescripcion", "TipoParentescoID", "Parentesco");



            }

        }

        protected void contactoemergen_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            contactoemergen.EditIndex = -1;
            llenartabla(contactoemergen, mest.llenardgvemergencia(cifglobal, lote));

        }

        protected void contactoemergen_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorContactoEmer` SET `ColaboradorContactoEID`='" + (contactoemergen.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "'," +
                    "`ColaboradorContactoENombre`='" + (contactoemergen.Rows[e.RowIndex].FindControl("txtcontactonom") as TextBox).Text + "'" +
                    ",`ColaboradorContactoETelefono`='" + (contactoemergen.Rows[e.RowIndex].FindControl("txttelcontacto") as TextBox).Text + "'," +
                    "`TipoParentescoID`='" + (contactoemergen.Rows[e.RowIndex].FindControl("tipoparentesco") as DropDownList).SelectedValue + "'" +

                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorContactoEID  = '" + (contactoemergen.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                contactoemergen.EditIndex = -1;
                llenartabla(contactoemergen, mest.llenardgvemergencia(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void contactoemergen_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorContactoEmer` WHERE ColaboradorContactoEID = '" + contactoemergen.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(contactoemergen, mest.llenardgvemergencia(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro eliminado exitosamente";
                lblErrorMessage1.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }

        }

        protected void contactoemergen_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            contactoemergen.PageIndex = e.NewPageIndex;
            llenartabla(contactoemergen, mest.llenardgvemergencia(cifglobal, lote));

        }

        protected void contactoemergen_RowEditing(object sender, GridViewEditEventArgs e)
        {
            contactoemergen.EditIndex = e.NewEditIndex;
            llenartabla(contactoemergen, mest.llenardgvemergencia(cifglobal, lote));

            cargarcomboengrid(e, contactoemergen, "lblidcolab", "tipoparentesco", "TipoParentescoID", "EP_ColaboradorContactoEmer", "ColaboradorContactoEID");
        }

        public void cargarcomboengrid(GridViewEditEventArgs e, GridView grid, string idlabel, string dropdowncargar, string campo, string tabla, string campowhere)
        {
            Label lblFrom = (Label)grid.Rows[e.NewEditIndex].FindControl(idlabel);
            DropDownList dropmodalidad = (DropDownList)grid.Rows[e.NewEditIndex].FindControl(dropdowncargar);
            string data = mest.cargacombogrid(campo, tabla, campowhere, lblFrom.Text);
            dropmodalidad.SelectedIndex = Convert.ToInt32(data);


        }

        protected void btnemergencias_Click(object sender, EventArgs e)
        {

        }
        public void llenartabla(GridView dgv, DataTable dt)
        {
            DataTable dt1 = new DataTable();
            dt1 = dt;
            dgv.DataSource = dt1;
            dgv.DataBind();

        }
        protected void cargadenuevo(object sender, EventArgs e)
        {
            llenartabla(contactoemergen, mest.llenardgvemergencia(cifglobal, lote));
            llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));


        }

        protected void btncerrar2_Click(object sender, EventArgs e)
        {
            llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));
        }

        protected void telefoonosdgv_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && telefoonosdgv.EditIndex == e.Row.RowIndex)
            {

                DropDownList dropuniveriti = (DropDownList)e.Row.FindControl("tipotelefonodrp");

                mest.llenadocombo("SELECT * FROM `Gen_TipoTelefono` ", dropuniveriti, "TipoTelefonoDescripcion", "TipoTelefonoID", "Tipo");



            }



        }

        protected void telefoonosdgv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            telefoonosdgv.EditIndex = -1;
            llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));
        }

        protected void telefoonosdgv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string tipotelefono = Convert.ToString(Session["idtipotel"]);
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorTelefono` SET `TipoTelefonoID`='" + (telefoonosdgv.Rows[e.RowIndex].FindControl("tipotelefonodrp") as DropDownList).SelectedValue + "'," +
                    "`ColaboradorTelefonoNumero`='" + (telefoonosdgv.Rows[e.RowIndex].FindControl("txtnumerotel") as TextBox).Text + "'" +

                    " WHERE ColaboradorID = '" + cifglobal + "'   AND LoteID  = '" + lote + "' AND TipOTelefonoID = '" + tipotelefono + "' ");




                telefoonosdgv.EditIndex = -1;
                llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));
                lblSuccessMessage12.Text = "Registro modificado exitosamente";
                lblErrorMessage12.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage12.Text = "";
                lblErrorMessage12.Text = ex.Message;
            }

        }

        protected void telefoonosdgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorTelefono` WHERE ColaboradorTelefonoNumero = '" + (telefoonosdgv.Rows[e.RowIndex].FindControl("telefono") as Label).Text + "'");

                llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro eliminado exitosamente";
                lblErrorMessage1.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage1.Text = "";
                lblErrorMessage1.Text = ex.Message;
            }
        }

        protected void telefoonosdgv_RowEditing(object sender, GridViewEditEventArgs e)
        {

            telefoonosdgv.EditIndex = e.NewEditIndex;
            llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));

            cargarcomboengrid(e, telefoonosdgv, "lblidcolabtel", "tipotelefonodrp", "TipoTelefonoID", "EP_ColaboradorTelefono", "ColaboradorTelefonoNumero");

            DropDownList dropmodalidad = (DropDownList)telefoonosdgv.Rows[e.NewEditIndex].FindControl("tipotelefonodrp");
            Session["idtipotel"] = dropmodalidad.SelectedValue;

        }




        protected void telefoonosdgv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            telefoonosdgv.PageIndex = e.NewPageIndex;
            llenartabla(telefoonosdgv, mest.llenartelefonos(cifglobal, lote));
        }





    }
}