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
    public partial class est_equipo : System.Web.UI.Page
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

               mest.llenartabla(Bienes, mest.llenardgvBienes(cifglobal, lote));
                mest.llenartabla(vehiculostabla, mest.llenarvehiculos(cifglobal, lote));
                mest.llenartabla(mobiliario, mest.llenarmobi(cifglobal, lote));
            }
        }
 
      //Bienes

        protected void Bienes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Bienes.EditIndex = -1;
            mest.llenartabla(Bienes, mest.llenardgvBienes(cifglobal, lote));
        }

        protected void Bienes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorActivosBienes` SET `TipoPresuncionID`='" + (Bienes.Rows[e.RowIndex].FindControl("TipoPresuncionID") as DropDownList).SelectedValue + "'," +
                    "`TipoInmuebleID`='" + (Bienes.Rows[e.RowIndex].FindControl("TipoInmuebleID") as DropDownList).SelectedValue+ "'" +
                    ",`ColaboradorActivoBIFinca`='" + (Bienes.Rows[e.RowIndex].FindControl("ColaboradorActivoBIFinca") as TextBox).Text + "'," +
                    "`ColaboradorActivoBIFolio`='" + (Bienes.Rows[e.RowIndex].FindControl("ColaboradorActivoBIFolio") as TextBox).Text + "', " +
                    "`ColaboradorActivoBILibro`='" + (Bienes.Rows[e.RowIndex].FindControl("ColaboradorActivoBILibro") as TextBox).Text + "'," +
                    "`ColaboradorActivoBIDireccon`='" + (Bienes.Rows[e.RowIndex].FindControl("ColaboradorActivoBIDireccon") as TextBox).Text + "'," +
                    "`ColaboradorActivoBIValor`='" + Convert.ToDecimal((Bienes.Rows[e.RowIndex].FindControl("ColaboradorActivoBIValor") as TextBox).Text.Replace(",","")) + "' ," +
                    "`ColaboradorActivoBIComentario`='" + (Bienes.Rows[e.RowIndex].FindControl("ColaboradorActivoBIComentario") as TextBox).Text + "' " +

                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorActivoBIID = '" + (Bienes.Rows[e.RowIndex].FindControl("ColaboradorActivoBIID") as Label).Text + "' AND LoteID  = '"+lote+"' ");




                Bienes.EditIndex = -1;
                mest.llenartabla(Bienes, mest.llenardgvBienes(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void Bienes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorActivosBienes` WHERE ColaboradorActivoBIID = '" + Bienes.DataKeys[e.RowIndex].Value.ToString() + "'");

                mest.llenartabla(Bienes, mest.llenardgvBienes(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void Bienes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Bienes.PageIndex = e.NewPageIndex;
            mest.llenartabla(Bienes, mest.llenardgvBienes(cifglobal, lote));
        }

        protected void Bienes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Bienes.EditIndex = e.NewEditIndex;
            mest.llenartabla(Bienes, mest.llenardgvBienes(cifglobal, lote));
            cargarcomboengrid(e, Bienes, "ColaboradorActivoBIID", "TipoPresuncionID", "TipoPresuncionID", "EP_ColaboradorActivosBienes", "ColaboradorActivoBIID");
            cargarcomboengrid(e, Bienes, "ColaboradorActivoBIID", "TipoInmuebleID", "TipoInmuebleID", "EP_ColaboradorActivosBienes", "ColaboradorActivoBIID");

        }

     

        protected void btnBienes_Click(object sender, EventArgs e)
        {

        }
        protected void Bienes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && Bienes.EditIndex == e.Row.RowIndex)
            {

                DropDownList drp1 = (DropDownList)e.Row.FindControl("TipoPresuncionID");
                DropDownList drp2 = (DropDownList)e.Row.FindControl("TipoInmuebleID");
            



                mest.llenadocombo("SELECT * FROM `Gen_TipoPresuncion`", drp1, "TipoPresuncionDescripcion", "TipoPresuncionID", "Presuncion");
                mest.llenadocombo("SELECT * FROM `Gen_TipoInmueble`", drp2, "TipoInmuebleDescripcion", "TipoInmuebleID", "Tipo Inmueble");

            }
        }
        //Vehiculos












        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            ModalPopupExtender1.Hide();
            ModalPopupExtender2.Hide();
            mest.llenartabla(Bienes, mest.llenardgvBienes(cifglobal, lote));
            mest.llenartabla(vehiculostabla, mest.llenarvehiculos(cifglobal, lote));
            mest.llenartabla(mobiliario, mest.llenarmobi(cifglobal, lote));
        }
        protected void cerrar2_Click(object sender, EventArgs e)
        {
            
        }

        protected void vehiculostabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            vehiculostabla.PageIndex = e.NewPageIndex;
            mest.llenartabla(vehiculostabla, mest.llenarvehiculos(cifglobal, lote));

        }

        protected void vehiculostabla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            vehiculostabla.EditIndex = e.NewEditIndex;
            mest.llenartabla(vehiculostabla, mest.llenarvehiculos(cifglobal, lote)); 
            cargarcomboengrid(e, vehiculostabla, "ColaboradorActivoVehID", "TipoVehiculoID", "TipoVehiculoID", "EP_ColaboradorActivosVehiculos", "ColaboradorActivoVehID");

            cargarcomboengrid(e, vehiculostabla, "ColaboradorActivoVehID", "ColaboradorActivoVehPropietari", "ColaboradorActivoVehPropietari", "EP_ColaboradorActivosVehiculos", "ColaboradorActivoVehID");



            Label lblFrom = (Label)vehiculostabla.Rows[e.NewEditIndex].FindControl("ColaboradorActivoVehID");
            DropDownList dropmodalidad = (DropDownList)vehiculostabla.Rows[e.NewEditIndex].FindControl("ColaboradorActivoVehPropietari");
            string data = mest.cargacombogrid("ColaboradorActivoVehPropietari", "EP_ColaboradorActivosVehiculos", "ColaboradorActivoVehID", lblFrom.Text);
            if (data == "True")
            {

                dropmodalidad.SelectedValue = "1";
            }
            else
            {
                dropmodalidad.SelectedValue = "0";
            }
        }

        protected void vehiculostabla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            vehiculostabla.EditIndex = -1;
            mest.llenartabla(vehiculostabla, mest.llenarvehiculos(cifglobal, lote));
        }

        protected void vehiculostabla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorActivosVehiculos` SET `ColaboradorActivoVehPropietari`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehPropietari") as DropDownList).SelectedValue + "'," +
                    "`TipoVehiculoID`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("TipoVehiculoID") as DropDownList).SelectedValue + "'," +
                    "`ColaboradorActivoVehMarca`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehMarca") as TextBox).Text + "', " +
                    "`ColaboradorActivoVehLinea`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehLinea") as TextBox).Text + "'," +
                    "`ColaboradorActivoVehModelo`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehModelo") as TextBox).Text + "'," +
                    "`ColaboradorActivoVehPlaca`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehPlaca") as TextBox).Text + "' ," +
                     "`ColaboradorActivoVehComentario`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehComentario") as TextBox).Text + "', " +
                      "`ColaboradorActivoVehNombre`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehNombre") as TextBox).Text + "', " +
                       "`ColaboradorActivoVehMotivo`='" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehMotivo") as TextBox).Text + "', " +
                       "`ColaboradorActivoVehValor`='" + Convert.ToDecimal((vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehValor") as TextBox).Text.Replace(",", "")) + "' " +
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorActivoVehID = '" + (vehiculostabla.Rows[e.RowIndex].FindControl("ColaboradorActivoVehID") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                vehiculostabla.EditIndex = -1;
                mest.llenartabla(vehiculostabla, mest.llenarvehiculos(cifglobal, lote));
                lblSuccessMessage.Text = "Registro modificado exitosamente";
                lblErrorMessage.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }

        }


        protected void vehiculostabla_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorActivosVehiculos` WHERE ColaboradorActivoVehID = '" + vehiculostabla.DataKeys[e.RowIndex].Value.ToString() + "'");

                mest.llenartabla(vehiculostabla, mest.llenarvehiculos(cifglobal, lote));
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





        protected void vehiculostabla_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && vehiculostabla.EditIndex == e.Row.RowIndex)
            {

                DropDownList dropuniveriti = (DropDownList)e.Row.FindControl("TipoVehiculoID");
       
                mest.llenadocombo("SELECT * FROM `Gen_TipoVehiculo` ", dropuniveriti, "TipoVehiculoDescripcion", "TipoVehiculoID", "Vehiculo");


  

      
            }
        }

        protected void btnbienes_Click1(object sender, EventArgs e)
        {

        }

        protected void vehiculosbtn_Click1(object sender, EventArgs e)
        {

        }

        protected void mobibtn_Click(object sender, EventArgs e)
        {
            ModalPopupExtender2.Show();
        }

        protected void mobiliario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            mobiliario.PageIndex = e.NewPageIndex;
            mest.llenartabla(mobiliario, mest.llenarmobi(cifglobal, lote));
        }

        protected void mobiliario_RowEditing(object sender, GridViewEditEventArgs e)
        {
            mobiliario.EditIndex = e.NewEditIndex;
            mest.llenartabla(mobiliario, mest.llenarmobi(cifglobal, lote));
           
        }

        protected void mobiliario_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           

        }

        protected void mobiliario_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            mobiliario.EditIndex = -1;
            mest.llenartabla(mobiliario, mest.llenarmobi(cifglobal, lote));

        }

        protected void mobiliario_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorActivosEquipo` SET `TipoEquipoID`='" + (mobiliario.Rows[e.RowIndex].FindControl("TipoEquipoID") as TextBox).Text + "'," +
                    "`ColaboradorActivoEqValor`='" + Convert.ToDecimal((mobiliario.Rows[e.RowIndex].FindControl("ColaboradorActivoEqValor") as TextBox).Text.Replace(",", "")) + "', " +
                    "`ColaboradorActivoEqDescripcion`='" + (mobiliario.Rows[e.RowIndex].FindControl("ColaboradorActivoEqDescripcion") as TextBox).Text + "' " +
      
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorActivoEqID = '" + (mobiliario.Rows[e.RowIndex].FindControl("ColaboradorActivoEqID") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                mobiliario.EditIndex = -1;
                mest.llenartabla(mobiliario, mest.llenarmobi(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }

        }


        protected void listManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            int currentRowInEdit = Bienes.EditIndex;
            
        DropDownList droppresun = (DropDownList)Bienes.Rows[currentRowInEdit].FindControl("TipoPresuncionID");

            TextBox txt1 = (TextBox)Bienes.Rows[currentRowInEdit].FindControl("ColaboradorActivoBIFinca");
            TextBox txt2 = (TextBox)Bienes.Rows[currentRowInEdit].FindControl("ColaboradorActivoBIFolio");
            TextBox txt3 = (TextBox)Bienes.Rows[currentRowInEdit].FindControl("ColaboradorActivoBILibro");
            string id = droppresun.SelectedValue;
            if (id == "1")
            {


                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";

                txt1.Attributes.Add("required", "true");
                txt2.Attributes.Add("required", "true");
                txt3.Attributes.Add("required", "true");

            }
            else {
                txt1.Text = "0";
                txt2.Text = "0";
                txt3.Text = "NA";
                txt1.Attributes.Add("required", "false");

                txt2.Attributes.Add("required", "false");
                txt3.Attributes.Add("required", "false");
               
            }

      

        }

        protected void ColaboradorActivoVehPropietari_SelectedIndexChanged(object sender, EventArgs e)
        {

            int currentRowInEdit = vehiculostabla.EditIndex;

            DropDownList droppresun = (DropDownList)vehiculostabla.Rows[currentRowInEdit].FindControl("ColaboradorActivoVehPropietari");

            TextBox txt1 = (TextBox)vehiculostabla.Rows[currentRowInEdit].FindControl("ColaboradorActivoVehNombre");
            TextBox txt2 = (TextBox)vehiculostabla.Rows[currentRowInEdit].FindControl("ColaboradorActivoVehMotivo");
           
            string id = droppresun.SelectedValue;
            if (id == "1")
            {


             

                txt1.Text = "";
                txt2.Text = "";

                txt1.Enabled = false;

                txt2.Enabled = false;


            }
            else
            {
                txt1.Text = "";
                txt2.Text = "";

                txt1.Enabled = true;

                txt2.Enabled = true;
                txt1.Attributes.Add("required", "true");
                txt2.Attributes.Add("required", "true");


            }

        }

        protected void mobiliario_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorActivosEquipo` WHERE ColaboradorActivoEqID = '" + mobiliario.DataKeys[e.RowIndex].Value.ToString() + "'");

                mest.llenartabla(mobiliario, mest.llenarmobi(cifglobal, lote));
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