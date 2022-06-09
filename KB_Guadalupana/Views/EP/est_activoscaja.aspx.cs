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
    public partial class est_activoscaja : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;
        string[] loteact;
        string valor2;
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
                carga();

                llenartabla(cuentas, mest.llenardgvcuentas(cifglobal, lote));
                llenartabla(inversionestabla, mest.llenarinversiones(cifglobal, lote));

            }

            bool val = lte.fenafore(cifglobal, lote);
            if (val == true)
            {
                ColaboradorInversionFenarore.Enabled = true;
            }
            else
            {
                ColaboradorInversionFenarore.Enabled = false;
            }
        }
        public void carga()
        {

            DataTable dt = new DataTable();
            dt = mest.datosgen(cifglobal, lote);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {

                    montocaja.Text = row["ColaboradorActivosCaja"].ToString();
                    ColaboradorInversionFenarore.Text = row["ColaboradorInversionFenarore"].ToString();
                


                }
            }
            else
            {


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

        protected void cuentas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
         
                
            cuentas.EditIndex = -1;
            llenartabla(cuentas, mest.llenardgvcuentas(cifglobal, lote));
        }

        protected void cuentas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                TextBox txt1 = (TextBox)cuentas.Rows[e.RowIndex].FindControl("txtnumerocta");

                string txt = txt1.Text;
                if (txt == "")
                {
                    lblErrorMessage1.Text = "No puede actualizar sin número de cuenta";

                }
                else
                {
                    string dato = (cuentas.Rows[e.RowIndex].FindControl("Estadodrp") as DropDownList).SelectedValue;

                    if (dato == "True")
                    {
                        valor2 = "1";
                    }
                    else
                    {
                        valor2 = "0";
                    }
                    mest.executesql(" UPDATE `EP_ColaboradorActivosCB` SET `TipoCuentaFinCodigo`='" + (cuentas.Rows[e.RowIndex].FindControl("tipoctadrp") as DropDownList).SelectedValue + "'," +
                        "`EntidadFinCodigo`='" + (cuentas.Rows[e.RowIndex].FindControl("entidaddrp") as DropDownList).SelectedValue + "'" +
                        ",`ColaboradorActivoCBActiva`='" + valor2 + "'," +
                        "`MonedaID`='" + (cuentas.Rows[e.RowIndex].FindControl("monedadrp") as DropDownList).SelectedValue + "', " +
                        "`ColaboradorActivoCBNumero`='" + (cuentas.Rows[e.RowIndex].FindControl("txtnumerocta") as TextBox).Text + "'," +
                        "`ColaboradorActivoCBSaldo`='" + Convert.ToDecimal((cuentas.Rows[e.RowIndex].FindControl("txtsaldo") as TextBox).Text.Replace(",", "")) + "'," +
                        "`ColaboradorActivoCBOrigen`='" + (cuentas.Rows[e.RowIndex].FindControl("txtorigen") as TextBox).Text + "' " +
                        " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorActivoCBID = '" + (cuentas.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                    cuentas.EditIndex = -1;
                    llenartabla(cuentas, mest.llenardgvcuentas(cifglobal, lote));
                    lblSuccessMessage1.Text = "Registro modificado exitosamente";
                    lblErrorMessage1.Text = "";

                }


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void cuentas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorActivosCB` WHERE ColaboradorActivoCBID = '" + cuentas.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(cuentas, mest.llenardgvcuentas(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void cuentas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cuentas.PageIndex = e.NewPageIndex;
            llenartabla(cuentas, mest.llenardgvcuentas(cifglobal, lote));
        }

        protected void cuentas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            cuentas.EditIndex = e.NewEditIndex;
            llenartabla(cuentas, mest.llenardgvcuentas(cifglobal, lote));
            cargarcomboengrid(e, cuentas, "lblidcolab", "entidaddrp", "EntidadFinCodigo", "EP_ColaboradorActivosCB", "ColaboradorActivoCBID");
            cargarcomboengrid(e, cuentas, "lblidcolab", "tipoctadrp", "TipoCuentaFinCodigo", "EP_ColaboradorActivosCB", "ColaboradorActivoCBID");

            cargarcomboengrid(e, cuentas, "lblidcolab", "monedadrp", "MonedaID", "EP_ColaboradorActivosCB", "ColaboradorActivoCBID");
            cargarcomboengrid(e, cuentas, "lblidcolab", "Estadodrp", "ColaboradorActivoCBActiva", "EP_ColaboradorActivosCB", "ColaboradorActivoCBID");
        }

     

        protected void btncuentas_Click(object sender, EventArgs e)
        {

        }
        protected void cuentas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && cuentas.EditIndex == e.Row.RowIndex)
            {

                DropDownList drp1 = (DropDownList)e.Row.FindControl("entidaddrp");
                DropDownList drp2 = (DropDownList)e.Row.FindControl("monedadrp");
                DropDownList drp3 = (DropDownList)e.Row.FindControl("tipoctadrp");



                llenadocombo("SELECT * FROM `Gen_EntidadFinanciera`", drp1, "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");
                llenadocombo("SELECT * FROM `Gen_Moneda`", drp2, "MonedaNombre", "MonedaID", "Moneda");
                llenadocombo("SELECT * FROM `Gen_TipoCuentaFinanciera` WHERE TipoCuentaFinEstado = 1 ", drp3, "TipoCuentaFinDescripcion", "TipoCuentaFinCodigo", "Tipo-Cuenta");
            }
        }
        //INVERSIONES



























        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            ModalPopupExtender1.Hide();
            
            llenartabla(inversionestabla, mest.llenarinversiones(cifglobal, lote));
            llenartabla(cuentas, mest.llenardgvcuentas(cifglobal, lote));

        }

        protected void inversionestabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            inversionestabla.PageIndex = e.NewPageIndex;
            llenartabla(inversionestabla, mest.llenarinversiones(cifglobal, lote));

        }

        protected void inversionestabla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            inversionestabla.EditIndex = e.NewEditIndex;
            llenartabla(inversionestabla, mest.llenarinversionesf(cifglobal, lote));
            cargarcomboengrid(e, inversionestabla, "lblidcolab", "entidaddrp", "EntidadFinCodigo", "EP_ColaboradorActivosInver", "ColaboradorActivoInverID");
            cargarcomboengrid(e, inversionestabla, "lblidcolab", "monedadrpinv", "MonedaID", "EP_ColaboradorActivosInver", "ColaboradorActivoInverID");


        }

        protected void inversionestabla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            inversionestabla.EditIndex = -1;
            llenartabla(inversionestabla, mest.llenarinversiones(cifglobal, lote));
        }

        protected void inversionestabla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorActivosInver` SET `EntidadFinCodigo`='" + (inversionestabla.Rows[e.RowIndex].FindControl("entidaddrp") as DropDownList).SelectedValue + "'," +
                    "`ColaboradorActivoInverPlazo`='" + (inversionestabla.Rows[e.RowIndex].FindControl("txtplazo") as TextBox).Text + "'" +
                    ",`MonedaID`='" + (inversionestabla.Rows[e.RowIndex].FindControl("monedadrpinv") as DropDownList).SelectedValue + "'," +
                    "`ColaboradorActivoInverMonto`='" + Convert.ToDecimal((inversionestabla.Rows[e.RowIndex].FindControl("montotxt") as TextBox).Text.Replace(",", "")) + "', " +
                    "`ColaboradorActivoInverOrigen`='" + (inversionestabla.Rows[e.RowIndex].FindControl("txtorigen") as TextBox).Text + "'," +
                    "`ColaboradorActivoInverCuenta`='" + (inversionestabla.Rows[e.RowIndex].FindControl("txtnrocuenta") as TextBox).Text + "'," +
                    "`ColaboradorActivoInverFechaApe`='" + (inversionestabla.Rows[e.RowIndex].FindControl("txtfecha") as TextBox).Text + "' " +
                    " WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorActivoInverID = '" + (inversionestabla.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "' AND LoteID  = '" + lote + "' ");




                inversionestabla.EditIndex = -1;
                llenartabla(inversionestabla, mest.llenarinversiones(cifglobal, lote));
                lblSuccessMessage1.Text = "Registro modificado exitosamente";
                lblErrorMessage1.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }

        }

        protected void inversionestabla_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorActivosInver` WHERE ColaboradorActivoInverID = '" + inversionestabla.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(inversionestabla, mest.llenarinversiones(cifglobal, lote));
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



        protected void inversionestabla_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow && inversionestabla.EditIndex == e.Row.RowIndex)
            {

                DropDownList dropuniveriti = (DropDownList)e.Row.FindControl("entidaddrp");
                DropDownList dropuniveriti2 = (DropDownList)e.Row.FindControl("monedadrpinv");
                llenadocombo("SELECT * FROM `Gen_Moneda` ", dropuniveriti2, "MonedaNombre", "MonedaID", "Moneda");
              

                llenadocombo("SELECT * FROM `Gen_EntidadFinanciera` ", dropuniveriti , "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");

      
            }
        }

        protected void ColaboradorInversionFenarore_TextChanged(object sender, EventArgs e)
        {
            if (ColaboradorInversionFenarore.Text != "")
            {

                string c1 = ColaboradorInversionFenarore.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorInversionFenarore = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);
                String script = "alert('Ingresado correctamente '); window.location.href= 'est_activoscaja.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else
            {
                String script = "alert('complete el campo de caja '); window.location.href= 'est_activoscaja.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

            }
        }

        protected void montocaja_TextChanged(object sender, EventArgs e)
        {
            if (montocaja.Text != "")
            {

                string c1 = montocaja.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivosCaja = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);
                String script = "alert('Ingresado correctamente '); window.location.href= 'est_activoscaja.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
            else
            {
                String script = "alert('complete el campo de caja '); window.location.href= 'est_activoscaja.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

            }

        }

     

        protected void inversionesbtn_Click(object sender, EventArgs e)
        {

        }
    }
}