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
    public partial class est_ingresos : System.Web.UI.Page
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

               mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));
                mest.llenartabla(remesastabla, mest.llenardgvremesas(cifglobal, lote));
                mest.llenartabla(otrostabla, mest.llenardgvotros(cifglobal, lote));
            }
        }
 
      //negocio

        protected void negocio_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            negocio.EditIndex = -1;
            mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));
        }

        protected void negocio_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorIngresoNegocio` SET `TipoNegocioID`='" + (negocio.Rows[e.RowIndex].FindControl("TipoNegocioID") as DropDownList).SelectedValue + "'," +
                    "`ColaboradoringresoNegNombre`='" + (negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegNombre") as TextBox).Text+ "'," +
                    "`ColaboradoringresoNegPatente`='" + (negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegPatente") as TextBox).Text + "'," +
                    "`ColaboradoringresoNegEmpleados`='" + (negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegEmpleados") as TextBox).Text + "', " +
                    "`ColaboradoringresoNegObjeto`='" + (negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegObjeto") as TextBox).Text + "'," +
                    "`ColaboradoringresoNegIngresos`='" + Convert.ToDecimal((negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegIngresos") as TextBox).Text.Replace(",", "")) + "'," +
                    "`ColaboradoringresoNegEgresos`='" + Convert.ToDecimal((negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegEgresos") as TextBox).Text.Replace(",","")) + "' ," +
                    "`ColaboradoringresoNegDireccion`='" + (negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegDireccion") as TextBox).Text + "' " +

                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradoringresoNegID = '" + (negocio.Rows[e.RowIndex].FindControl("ColaboradoringresoNegID") as Label).Text + "' AND LoteID  = '"+lote+"' ");




                negocio.EditIndex = -1;
                mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void negocio_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorIngresoNegocio` WHERE ColaboradoringresoNegID = '" + negocio.DataKeys[e.RowIndex].Value.ToString() + "' AND ColaboradorID = '" + cifglobal + "'  AND LoteID  = '" + lote + "'    ");

                mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void negocio_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            negocio.PageIndex = e.NewPageIndex;
            mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));
        }

        protected void negocio_RowEditing(object sender, GridViewEditEventArgs e)
        {
            negocio.EditIndex = e.NewEditIndex;
            mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));
           cargarcomboengrid(e, negocio, "ColaboradoringresoNegID", "TipoNegocioID", "TipoNegocioID", "EP_ColaboradorIngresoNegocio", "ColaboradoringresoNegID");
            
        }

     

        protected void btnnegocio_Click(object sender, EventArgs e)
        {

        }
        protected void negocio_RowDataBound(object sender, GridViewRowEventArgs e)
        {
         

            if (e.Row.RowType == DataControlRowType.DataRow && negocio.EditIndex == e.Row.RowIndex)
            {

                DropDownList dropuniveriti = (DropDownList)e.Row.FindControl("TipoNegocioID");

                mest.llenadocombo("SELECT * FROM `Gen_TipoNegocio`", dropuniveriti, "TipoNegocioDescripcion", "TipoNegocioID", "Tipo-Negocio");


            }
        }
        //remesas












        protected void cerrar_Click(object sender, EventArgs e)
        {
            mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));

        }
        protected void cerrar2_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            ModalPopupExtender2.Hide();
            ModalPopupExtender2.Hide();

            mest.llenartabla(remesastabla, mest.llenardgvremesas(cifglobal, lote));
            mest.llenartabla(negocio, mest.llenardgvnegocio(cifglobal, lote));
            mest.llenartabla(otrostabla, mest.llenardgvotros(cifglobal, lote));
        }

        protected void remesastabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            remesastabla.PageIndex = e.NewPageIndex;
            mest.llenartabla(remesastabla, mest.llenardgvremesas(cifglobal, lote));

        }

        protected void remesastabla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            remesastabla.EditIndex = e.NewEditIndex;
            mest.llenartabla(remesastabla, mest.llenardgvremesas(cifglobal, lote));
        
        }

        protected void remesastabla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            remesastabla.EditIndex = -1;
            mest.llenartabla(remesastabla, mest.llenardgvremesas(cifglobal, lote));
        }

        protected void remesastabla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorIngresoRemesa` SET `ColaboradorIngresoRemesaRemite`='" + (remesastabla.Rows[e.RowIndex].FindControl("ColaboradorIngresoRemesaRemite") as TextBox).Text + "'," +
                    "`ColaboradorIngresoRemesaRelaci`='" + (remesastabla.Rows[e.RowIndex].FindControl("ColaboradorIngresoRemesaRelaci") as TextBox).Text + "'," +
                    "`ColaboradorIngresoRemesaPromed`='" + Convert.ToDecimal((remesastabla.Rows[e.RowIndex].FindControl("ColaboradorIngresoRemesaPromed") as TextBox).Text.Replace(",", "")) + "', " +
                    "`ColaboradorIngresoRemesaPeriod`='" + (remesastabla.Rows[e.RowIndex].FindControl("ColaboradorIngresoRemesaPeriod") as TextBox).Text + "'" +
                   
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradoringresoRemesaID = '" + (remesastabla.Rows[e.RowIndex].FindControl("ColaboradoringresoRemesaID") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                remesastabla.EditIndex = -1;
                mest.llenartabla(remesastabla, mest.llenardgvremesas(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }

        }


        protected void remesastabla_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorIngresoRemesa` WHERE ColaboradoringresoRemesaID = '" + remesastabla.DataKeys[e.RowIndex].Value.ToString() + "' AND ColaboradorID = '" + cifglobal + "' AND LoteID  = '" + lote + "'  ");

                mest.llenartabla(remesastabla, mest.llenardgvremesas(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }


        public void cargarcomboengrid(GridViewEditEventArgs e, GridView grid, string idlabel, string dropdowncargar, string campo, string tabla, string campowhere)
        {
            Label lblFrom = (Label)grid.Rows[e.NewEditIndex].FindControl(idlabel);
            DropDownList dropmodalidad = (DropDownList)grid.Rows[e.NewEditIndex].FindControl(dropdowncargar);
            string data = mest.cargacombogrid(campo, tabla, campowhere, lblFrom.Text);
            dropmodalidad.SelectedValue = data;
        }




        protected void btnnegocio_Click1(object sender, EventArgs e)
        {

        }

        protected void vehiculosbtn_Click1(object sender, EventArgs e)
        {

        }

        protected void mobibtn_Click(object sender, EventArgs e)
        {

        }

        protected void otrostabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            otrostabla.PageIndex = e.NewPageIndex;
            mest.llenartabla(otrostabla, mest.llenardgvotros(cifglobal, lote));
        }

        protected void otrostabla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            otrostabla.EditIndex = e.NewEditIndex;
            mest.llenartabla(otrostabla, mest.llenardgvotros(cifglobal, lote));
            cargarcomboengrid(e, otrostabla, "ColaboradoringresoOtrID", "TipoOtroIngresoID", "TipoOtroIngresoID", "EP_ColaboradorIngresoOtro", "ColaboradoringresoOtrID");

        }

        protected void otrostabla_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && otrostabla.EditIndex == e.Row.RowIndex)
            {

                DropDownList drp1 = (DropDownList)e.Row.FindControl("TipoOtroIngresoID");





                mest.llenadocombo("SELECT * FROM `Gen_TipoOtroIngreso`", drp1, "TipoOtroIngresoDescripcion", "TipoOtroIngresoID", "Otro-Negocio");


            }


        }

        protected void otrostabla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            otrostabla.EditIndex = -1;
            mest.llenartabla(otrostabla, mest.llenardgvotros(cifglobal, lote));

        }

        protected void otrostabla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorIngresoOtro` SET `TipoOtroIngresoID`='" + (otrostabla.Rows[e.RowIndex].FindControl("TipoOtroIngresoID") as DropDownList).SelectedValue + "'," +
                    "`ColaboradoringresoOtrDescripci`='" + (otrostabla.Rows[e.RowIndex].FindControl("ColaboradoringresoOtrDescripci") as TextBox).Text + "', " +
                    "`ColaboradoringresoOtrValor`='" + Convert.ToDecimal((otrostabla.Rows[e.RowIndex].FindControl("ColaboradoringresoOtrValor") as TextBox).Text.Replace(",", "")) + "' " +
      
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradoringresoOtrID = '" + (otrostabla.Rows[e.RowIndex].FindControl("ColaboradoringresoOtrID") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                otrostabla.EditIndex = -1;
                mest.llenartabla(otrostabla, mest.llenardgvotros(cifglobal, lote));
                Label1.Text = "Registro modificado exitosamente";
                Label2.Text = "";


            }
            catch (Exception ex)
            {
                Label1.Text = "";
                Label2.Text = ex.Message;
            }

        }

        protected void TipoNegocioID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentRowInEdit = negocio.EditIndex;

            DropDownList droppresun = (DropDownList)negocio.Rows[currentRowInEdit].FindControl("TipoNegocioID");

            TextBox txt1 = (TextBox)negocio.Rows[currentRowInEdit].FindControl("ColaboradoringresoNegPatente");
  

            string id = droppresun.SelectedValue;
            if (id == "1")
            {


                txt1.Text = "";
            

                txt1.Enabled = true;

             
                txt1.Attributes.Add("required", "true");



            }
            else
            {
                txt1.Text = "";
              

                txt1.Enabled = false;

  


            }
        }

        protected void otrostabla_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorIngresoOtro` WHERE ColaboradoringresoOtrID = '" + otrostabla.DataKeys[e.RowIndex].Value.ToString() + "' AND ColaboradorID = '" + cifglobal + "' AND LoteID  = '" + lote + "'   ");

                mest.llenartabla(otrostabla, mest.llenardgvotros(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }



        protected void vehiculosbtn_Click(object sender, EventArgs e)
        {

        }
    }
}