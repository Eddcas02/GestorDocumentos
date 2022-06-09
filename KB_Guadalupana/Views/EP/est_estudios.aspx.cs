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
    public partial class est_estudios : System.Web.UI.Page
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

                llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));
                llenartabla(otrosestudiosdgvx, mest.llenarotrosestudios(cifglobal, lote));
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


        protected void estudiodgv_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && estudiodgv.EditIndex == e.Row.RowIndex)
            {

                DropDownList dropuniveriti = (DropDownList)e.Row.FindControl("univeredit");

                llenadocombo("SELECT * FROM `Gen_Universidad` ", dropuniveriti, "UniversidadNombre", "UniversidadID", "Universidad");


            }
            }
        protected void estudiodgv_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            estudiodgv.PageIndex = e.NewPageIndex;
            llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));
        }

        protected void estudiodgv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            estudiodgv.EditIndex = e.NewEditIndex;
            llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));

            cargarcomboengrid(e, estudiodgv, "lblidcolab", "univeredit", "UniversidadID", "EP_ColaboradorEstudioUni", "ColaboradorEstudioUniID");

            Label lblFrom = (Label)estudiodgv.Rows[e.NewEditIndex].FindControl("lblidcolab");
            DropDownList dropmodalidad = (DropDownList)estudiodgv.Rows[e.NewEditIndex].FindControl("ColaboradorEstudioUniGraduado");
            string data = mest.cargacombogrid("ColaboradorEstudioUniGraduado", "EP_ColaboradorEstudioUni", "ColaboradorEstudioUniID", lblFrom.Text);
            TextBox txt1 = (TextBox)estudiodgv.Rows[e.NewEditIndex].FindControl("txtultimociclo");
            if (data == "True") {

                dropmodalidad.SelectedValue = "1";
                txt1.Enabled = false;
            }
            else {
                dropmodalidad.SelectedValue = "0";
                txt1.Enabled = true;
            }

            
        }

        protected void estudiodgv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DropDownList droppresun = (DropDownList)estudiodgv.Rows[e.RowIndex].FindControl("ColaboradorEstudioUniGraduado");
            TextBox txt1 = (TextBox)estudiodgv.Rows[e.RowIndex].FindControl("txtultimociclo");
            try
            {
                
                string id = droppresun.SelectedValue;
                txt1.Attributes.Add("required", "true");
                int ciclo = Convert.ToInt32(txt1.Text);

                if (id == "0") {


                    if (ciclo > 0)
                    {




                        mest.executesql(" UPDATE `EP_ColaboradorEstudioUni` SET `ColaboradorEstudioUniCarrera`='" + (estudiodgv.Rows[e.RowIndex].FindControl("txtcarrera") as TextBox).Text + "'," +
                            "`ColaboradorEstudioUniUltCiclo`='" + (estudiodgv.Rows[e.RowIndex].FindControl("txtultimociclo") as TextBox).Text + "'" +
                            ",`ColaboradorEstudiouniAnio`='" + (estudiodgv.Rows[e.RowIndex].FindControl("txtañouni") as TextBox).Text + "'," +
                            "`UniversidadID`='" + (estudiodgv.Rows[e.RowIndex].FindControl("univeredit") as DropDownList).SelectedValue + "'," +
                            "`ColaboradorEstudioUniGraduado`='" + (estudiodgv.Rows[e.RowIndex].FindControl("ColaboradorEstudioUniGraduado") as DropDownList).SelectedValue + "'" +
                            " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorEstudioUniID = '" + (estudiodgv.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "' ");




                        estudiodgv.EditIndex = -1;
                        llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));
                        lblSuccessMessage.Text = "Registro modificado exitosamente";
                        lblErrorMessage.Text = "";




                    }
                    else
                    {
                        lblSuccessMessage.Text = "";
                        lblErrorMessage.Text = "El campo ciclo no puede ser 0";
                    }
                }

                else {


                    mest.executesql(" UPDATE `EP_ColaboradorEstudioUni` SET `ColaboradorEstudioUniCarrera`='" + (estudiodgv.Rows[e.RowIndex].FindControl("txtcarrera") as TextBox).Text + "'," +
                        "`ColaboradorEstudioUniUltCiclo`='" + (estudiodgv.Rows[e.RowIndex].FindControl("txtultimociclo") as TextBox).Text + "'" +
                        ",`ColaboradorEstudiouniAnio`='" + (estudiodgv.Rows[e.RowIndex].FindControl("txtañouni") as TextBox).Text + "'," +
                        "`UniversidadID`='" + (estudiodgv.Rows[e.RowIndex].FindControl("univeredit") as DropDownList).SelectedValue + "'," +
                        "`ColaboradorEstudioUniGraduado`='" + (estudiodgv.Rows[e.RowIndex].FindControl("ColaboradorEstudioUniGraduado") as DropDownList).SelectedValue + "'" +
                        " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorEstudioUniID = '" + (estudiodgv.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "' ");




                    estudiodgv.EditIndex = -1;
                    llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));
                    lblSuccessMessage.Text = "Registro modificado exitosamente";
                    lblErrorMessage.Text = "";

                }
            


           

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void estudiodgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorEstudioUni` WHERE ColaboradorEstudioUniID = '" + estudiodgv.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            ModalPopupExtender1.Hide();
            llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));
            llenartabla(otrosestudiosdgvx, mest.llenarotrosestudios(cifglobal, lote));
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {

        }

        protected void otrosestudiosdgvx_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void otrosestudiosdgvx_RowEditing(object sender, GridViewEditEventArgs e)
        {
            otrosestudiosdgvx.EditIndex = e.NewEditIndex;
            llenartabla(otrosestudiosdgvx, mest.llenarotrosestudios (cifglobal, lote));


            cargarcomboengrid(e, otrosestudiosdgvx, "lblidcolab", "modalidaddrp", "ModalidadEstudioID", "EP_ColaboradorEstudioOtr", "ColaboradorEstudioOtrID");


        }
        public void cargarcomboengrid(GridViewEditEventArgs e, GridView grid, string idlabel, string dropdowncargar, string campo, string tabla, string campowhere)
        {
            Label lblFrom = (Label)grid.Rows[e.NewEditIndex].FindControl(idlabel);
            DropDownList dropmodalidad = (DropDownList)grid.Rows[e.NewEditIndex].FindControl(dropdowncargar);
            string data = mest.cargacombogrid(campo, tabla, campowhere, lblFrom.Text);
            dropmodalidad.SelectedValue = data;


        }

        protected void otrosestudiosdgvx_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            otrosestudiosdgvx.EditIndex = -1;
            llenartabla(otrosestudiosdgvx, mest.llenarotrosestudios(cifglobal, lote));

        }

        protected void otrosestudiosdgvx_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorEstudioOtr` SET `ColaboradorEstudioOtrCurso`='" + (otrosestudiosdgvx.Rows[e.RowIndex].FindControl("txtcurso") as TextBox).Text + "'," +
                    "`ColaboradorEstudioOtrEstableci`='" + (otrosestudiosdgvx.Rows[e.RowIndex].FindControl("txtestabecimiento") as TextBox).Text + "'," +
                    "`ModalidadEstudioID`='" + (otrosestudiosdgvx.Rows[e.RowIndex].FindControl("modalidaddrp") as DropDownList).SelectedValue +
                     "',`ColaboradorEstudioOtrAnio`='" + (otrosestudiosdgvx.Rows[e.RowIndex].FindControl("txtuni") as TextBox).Text + "'," +
                      "`ColaboradorEstudioOtrDuracion`='" + (otrosestudiosdgvx.Rows[e.RowIndex].FindControl("txtduracion") as TextBox).Text + "' " +
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorEstudioOtrID = '" + (otrosestudiosdgvx.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "' ");




                otrosestudiosdgvx.EditIndex = -1;
                llenartabla(otrosestudiosdgvx, mest.llenarotrosestudios(cifglobal, lote));
                lblSuccessMessage.Text = "Registro modificado exitosamente";
                lblErrorMessage.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }

        }

        protected void otrosestudiosdgvx_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorEstudioOtr` WHERE ColaboradorEstudioOtrID = '" + otrosestudiosdgvx.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(otrosestudiosdgvx, mest.llenarotrosestudios(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void btnotrosestudios_Click(object sender, EventArgs e)
        {

        }

        protected void ntn_Click(object sender, EventArgs e)
        {
            //llenartabla(otrosestudiosdgvx, mest.llenarotrosestudios(cifglobal));
        }

        protected void ColaboradorEstudioUniGraduado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentRowInEdit = estudiodgv.EditIndex;

            DropDownList droppresun = (DropDownList)estudiodgv.Rows[currentRowInEdit].FindControl("ColaboradorEstudioUniGraduado");

            TextBox txt1 = (TextBox)estudiodgv.Rows[currentRowInEdit].FindControl("txtultimociclo");
            string id = droppresun.SelectedValue;
            if (id == "0")
            {


                txt1.Attributes.Add("required", "true");
                txt1.Enabled = true;


            }
            else
            {

                txt1.Attributes.Add("required", "false");
                txt1.Text = "0";
                txt1.Enabled = false;
            }



        }

        protected void otrosestudiosdgvx_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && otrosestudiosdgvx.EditIndex == e.Row.RowIndex)
            {

   

                DropDownList dropmodalidad = (DropDownList)e.Row.FindControl("modalidaddrp");


                llenadocombo("SELECT * FROM `Gen_ModalidadEstudio` WHERE ModalidadEstudioActivo = 1", dropmodalidad, "ModalidadEstudioDescripcion", "ModalidadEstudioID", "Modalidad");


            }
        }

        protected void estudiodgv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            estudiodgv.EditIndex = -1;
            llenartabla(estudiodgv, mest.llenardgvestudios(cifglobal, lote));
        }
    }
}