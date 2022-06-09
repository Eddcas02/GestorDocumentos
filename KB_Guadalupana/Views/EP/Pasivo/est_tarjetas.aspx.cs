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
    public partial class est_tarjetas : System.Web.UI.Page
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

                llenartabla(tarjetastabla, mest.llenartarjetas(cifglobal, lote));
                llenartabla(prestamostabla, mest.llenarprestamos(cifglobal, lote));

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

        protected void tarjetastabla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {

                string c1 = (tarjetastabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoTCLimiteQ") as TextBox).Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string c2 = (tarjetastabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoTCLimiteUS") as TextBox).Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string c3 = (tarjetastabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoTCSaldoQ") as TextBox).Text;
                decimal d3 = Convert.ToDecimal(c3.Replace(",", ""));
                string c4 = (tarjetastabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoTCSaldoUS") as TextBox).Text;
                decimal d4 = Convert.ToDecimal(c4.Replace(",", ""));



                mest.executesql(" UPDATE `EP_ColaboradorPasivoTC` SET `EntidadFinCodigo`='" + (tarjetastabla.Rows[e.RowIndex].FindControl("EntidadFinCodigo") as DropDownList).SelectedValue + "'," +
                    "`ColaboradorPasivoTCLimiteQ`='" + d1 + "'," +
                    "`ColaboradorPasivoTCLimiteUS`='" + d2 + "', " +
                    "`ColaboradorPasivoTCSaldoQ`='" + d3 + "'," +
                    "`ColaboradorPasivoTCSaldoUS`='" + d4+ "'" +

                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorPasivoTCID = '" + (tarjetastabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoTCID") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                tarjetastabla.EditIndex = -1;
                llenartabla(tarjetastabla, mest.llenartarjetas(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }


     

        protected void tarjetastabla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            tarjetastabla.EditIndex = e.NewEditIndex;
            llenartabla(tarjetastabla, mest.llenartarjetas(cifglobal, lote));
            cargarcomboengrid(e, tarjetastabla, "ColaboradorPasivoTCID", "EntidadFinCodigo", "EntidadFinCodigo", "EP_ColaboradorPasivoTC", "ColaboradorPasivoTCID");

        }
        protected void tarjetastabla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            tarjetastabla.EditIndex = -1;
            llenartabla(tarjetastabla, mest.llenartarjetas(cifglobal, lote));
        }

        protected void tarjetastabla_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorPasivoTC` WHERE ColaboradorPasivoTCID = '" + tarjetastabla.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(tarjetastabla, mest.llenartarjetas(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }


        protected void btncuentas_Click(object sender, EventArgs e)
        {

        }


        protected void tarjetastabla_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && tarjetastabla.EditIndex == e.Row.RowIndex)
            {

                DropDownList drp1 = (DropDownList)e.Row.FindControl("EntidadFinCodigo");




                llenadocombo("SELECT * FROM `Gen_EntidadFinanciera`", drp1, "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");

            }
        }

        protected void tarjetastabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tarjetastabla.PageIndex = e.NewPageIndex;
            llenartabla(tarjetastabla, mest.llenartarjetas(cifglobal, lote));
        }

        //INVERSIONES



























        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            ModalPopupExtender1.Hide();
            llenartabla(prestamostabla, mest.llenarprestamos(cifglobal, lote));

            llenartabla(tarjetastabla, mest.llenartarjetas(cifglobal, lote));


        }

        protected void prestamostabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            prestamostabla.PageIndex = e.NewPageIndex;
            llenartabla(prestamostabla, mest.llenarprestamos(cifglobal, lote));

        }

        protected void prestamostabla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            prestamostabla.EditIndex = e.NewEditIndex;
            llenartabla(prestamostabla, mest.llenarprestamosf(cifglobal, lote));
            cargarcomboengrid(e, prestamostabla, "ColaboradorPasivoPrestID", "TipoPrestamoID", "TipoPrestamoID", "EP_ColaboradorPasivoPrestamo", "ColaboradorPasivoPrestID");
            cargarcomboengrid(e, prestamostabla, "ColaboradorPasivoPrestID", "EntidadFinCodigo", "EntidadFinCodigo", "EP_ColaboradorPasivoPrestamo", "ColaboradorPasivoPrestID");


        }

        protected void prestamostabla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            prestamostabla.EditIndex = -1;
            llenartabla(prestamostabla, mest.llenarprestamos(cifglobal, lote));
        }

        protected void prestamostabla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string c1 = (prestamostabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoPrestMontoIni") as TextBox).Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string c2 = (prestamostabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoPrestSaldo") as TextBox).Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));

                mest.executesql(" UPDATE `EP_ColaboradorPasivoPrestamo` SET `TipoPrestamoID`='" + (prestamostabla.Rows[e.RowIndex].FindControl("TipoPrestamoID") as DropDownList).SelectedValue + "'," +
                    "`EntidadFinCodigo`='" + (prestamostabla.Rows[e.RowIndex].FindControl("EntidadFinCodigo") as DropDownList).SelectedValue + "' ," +
                    "`ColaboradorPasivoPrestMontoIni`='" +d1+ "'," +
                    "`ColaboradorPasivoPrestSaldo`='" + d2 + "', " +
                    "`ColaboradorPasivoPrestDestino`='" + (prestamostabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoPrestDestino") as TextBox).Text + "'," +
                    "`ColaboradorPasivoPrestFecDesem`='" + (prestamostabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoPrestFecDesem") as TextBox).Text + "'," +
                    "`ColaboradorPasivoPrestFecFinal`='" + (prestamostabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoPrestFecFinal") as TextBox).Text + "' " +
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorPasivoPrestID = '" + (prestamostabla.Rows[e.RowIndex].FindControl("ColaboradorPasivoPrestID") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                prestamostabla.EditIndex = -1;
                llenartabla(prestamostabla, mest.llenarprestamos(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }

        }

        protected void prestamostabla_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorPasivoPrestamo` WHERE ColaboradorPasivoPrestID = '" + prestamostabla.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(prestamostabla, mest.llenarprestamos(cifglobal, lote));
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



        protected void prestamostabla_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && prestamostabla.EditIndex == e.Row.RowIndex)
            {

                DropDownList dropuniveriti = (DropDownList)e.Row.FindControl("EntidadFinCodigo");
                DropDownList dropuniveriti2 = (DropDownList)e.Row.FindControl("TipoPrestamoID");
                llenadocombo("SELECT * FROM `Gen_TipoPrestamo` ", dropuniveriti2, "TipoPrestamoDescripcion", "TipoPrestamoID", "Tipo-Préstamo");
              

                llenadocombo("SELECT * FROM `Gen_EntidadFinanciera` ", dropuniveriti , "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");

      
            }
        }

     
    


        protected void btntarjetas_Click(object sender, EventArgs e)
        {

        }

     
        protected void inversionesbtn_Click(object sender, EventArgs e)
        {

        }
    }
}