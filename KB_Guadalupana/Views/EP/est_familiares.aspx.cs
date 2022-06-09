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
    public partial class est_familiares : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;
        string[] loteact;
        string ec, nc,fc,oc;
        protected void Page_Load(object sender, EventArgs e)
        {

            usernombre = Convert.ToString(Session["sesion_usuario"]);
            estadoep = Convert.ToString(Session["estadoepp"]);
            if (estadoep == "0")
            {
                blk.Text = "0";
                lblencab.Visible = false;
                ScriptManager.RegisterStartupScript(this, this.Page.GetType(), "bloqueado", "bloqueado();", true);

            }
            lote = Convert.ToString(Session["lotepasa"]);
            loteact = lte.lotevalido();
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {
                llenadocombo("SELECT * FROM `Gen_EstadoCivil`", estadocivildrp, "EstadoCivilDescripcion", "EstadoCivilID", "Estado Civil");

                llenartabla(familiarsdgv, mest.llenardgvfamilia(cifglobal, lote));
                DataTable dt = new DataTable();

                dt = mest.datosgen(cifglobal, lote);
                foreach (DataRow row in dt.Rows)
                {

                    ec = row["EstadoCivilID"].ToString();
                    nc = row["ColaboradorConyugeNombre"].ToString();
                    oc = row["ColaboradorConyugeOcupacion"].ToString();
                    fc = row["ColaboradorConyugeFecNacimient"].ToString();

                }
                estadocivildrp.SelectedValue = ec;
                if (ec == "2")
                {
                    ColaboradorConyugeNombre.Text = nc;
                    ColaboradorConyugeOcupacion.Text = oc;
                    ColaboradorConyugeFecNacimient.Text = fc;
                    if (nc == "") { ColaboradorConyugeNombre.Attributes.Add("required", "true"); ColaboradorConyugeNombre.Enabled = true; } else ColaboradorConyugeNombre.Enabled = true;
                    if (oc == "") { ColaboradorConyugeOcupacion.Attributes.Add("required", "true"); ColaboradorConyugeOcupacion.Enabled = true; } else ColaboradorConyugeOcupacion.Enabled = true;
                    if (fc == "") { ColaboradorConyugeFecNacimient.Attributes.Add("required", "true"); ColaboradorConyugeFecNacimient.Enabled = true; } else ColaboradorConyugeFecNacimient.Enabled = true;



                }
                else
                {
                    ColaboradorConyugeNombre.Attributes.Remove("required");
                    ColaboradorConyugeOcupacion.Attributes.Remove("required");
                    ColaboradorConyugeFecNacimient.Attributes.Remove("required");
                    btnconyuge.Visible = true;
                    lblencab.Visible = false;

                }

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

        protected void DGRVWPEN_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            familiarsdgv.PageIndex = e.NewPageIndex;
            llenartabla(familiarsdgv, mest.llenardgvfamilia(cifglobal, lote));

        }





        protected void Agregar_Click(object sender, EventArgs e)
        {

        }

        protected void cerrar_Click(object sender, EventArgs e)
        {
            mp1.Hide();
            llenartabla(familiarsdgv, mest.llenardgvfamilia(cifglobal, lote));
        }

        protected void estadocivildrp_SelectedIndexChanged(object sender, EventArgs e)
        {


            string valor = estadocivildrp.SelectedValue;
            mest.executesql("UPDATE EP_Colaborador SET EstadoCivilID = '" + valor + "' WHERE  ColaboradorID = '" + cifglobal + "' ");
            if (valor == "2")
            {

                ColaboradorConyugeNombre.Text = nc;
                ColaboradorConyugeOcupacion.Text = oc;
                ColaboradorConyugeFecNacimient.Text = fc;
                btnconyuge.Visible = true;
                ColaboradorConyugeNombre.Visible = true;
                ColaboradorConyugeOcupacion.Visible = true;
                ColaboradorConyugeFecNacimient.Visible = true;
                lblsuccesss.Visible = false;

                if (nc == "") { ColaboradorConyugeNombre.Attributes.Add("required", "true"); ColaboradorConyugeNombre.Enabled = true; } else ColaboradorConyugeNombre.Enabled = true;
                if (oc == "") { ColaboradorConyugeOcupacion.Attributes.Add("required", "true"); ColaboradorConyugeOcupacion.Enabled = true; } else ColaboradorConyugeOcupacion.Enabled = true;
                if (fc == "") { ColaboradorConyugeFecNacimient.Attributes.Add("required", "true"); ColaboradorConyugeFecNacimient.Enabled = true; } else ColaboradorConyugeFecNacimient.Enabled = true;


            }
            else
            {

                lblfc.Visible = false;
                lblnc.Visible = false;
                lbloc.Visible = false;
                lblerror.Visible = false;
                ColaboradorConyugeNombre.Attributes.Remove("required");
                ColaboradorConyugeOcupacion.Attributes.Remove("required");
                ColaboradorConyugeFecNacimient.Attributes.Remove("required");
                btnconyuge.Visible = true;
                lblencab.Visible = false;

                lblsuccesss.Visible = false;
            }


        }

        protected void familiarsdgv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            familiarsdgv.EditIndex = e.NewEditIndex;
            llenartabla(familiarsdgv, mest.llenardgvfamiliaf(cifglobal, lote));
        }



        protected void familiarsdgv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            familiarsdgv.EditIndex = -1;
            llenartabla(familiarsdgv, mest.llenardgvfamilia(cifglobal, lote));
        }

        protected void btnconyuge_Click(object sender, EventArgs e)
        {




            int error = 0;





            if (ColaboradorConyugeNombre.Text == "" && estadocivildrp.SelectedValue == "2")
            {
                lblnc.Visible = true; error++;
            }
            else
            {
                mest.executesql("UPDATE EP_Colaborador SET ColaboradorConyugeNombre = '" + ColaboradorConyugeNombre.Text.ToUpper() + "', ColaboradorConyugeOcupacion = '" + ColaboradorConyugeOcupacion.Text.ToUpper() + "', ColaboradorConyugeFecNacimient = '" + ColaboradorConyugeFecNacimient.Text + "' WHERE ColaboradorID = '" + cifglobal + "' AND LoteID = '" + lote + "'    ");

                lblnc.Visible = false;
            }
            if (ColaboradorConyugeOcupacion.Text == "" && estadocivildrp.SelectedValue == "2")
            {
                lbloc.Visible = true; error++;
            }
            else
            {
                mest.executesql("UPDATE EP_Colaborador SET ColaboradorConyugeOcupacion = '" + ColaboradorConyugeOcupacion.Text.ToUpper() + "', ColaboradorConyugeOcupacion = '" + ColaboradorConyugeOcupacion.Text.ToUpper() + "', ColaboradorConyugeFecNacimient = '" + ColaboradorConyugeFecNacimient.Text + "' WHERE ColaboradorID = '" + cifglobal + "' AND LoteID = '" + lote + "'    ");

                lbloc.Visible = false;
            }
            if (ColaboradorConyugeFecNacimient.Text == "" && estadocivildrp.SelectedValue == "2")
            {
                lblfc.Visible = true; error++;


            }
            else
            {
                if (ColaboradorConyugeFecNacimient.Text == "") {
                    string fech = "1111-11-11";
                    mest.executesql("UPDATE EP_Colaborador SET ColaboradorConyugeFecNacimient = '" + ColaboradorConyugeFecNacimient.Text + "', ColaboradorConyugeOcupacion = '" + ColaboradorConyugeOcupacion.Text.ToUpper() + "', ColaboradorConyugeFecNacimient = '" + fech+ "' WHERE ColaboradorID = '" + cifglobal + "' AND LoteID = '" + lote + "'    ");

                    lblfc.Visible = false;
                }
                else {
                    mest.executesql("UPDATE EP_Colaborador SET ColaboradorConyugeFecNacimient = '" + ColaboradorConyugeFecNacimient.Text + "', ColaboradorConyugeOcupacion = '" + ColaboradorConyugeOcupacion.Text.ToUpper() + "', ColaboradorConyugeFecNacimient = '" + ColaboradorConyugeFecNacimient.Text + "' WHERE ColaboradorID = '" + cifglobal + "' AND LoteID = '" + lote + "'    ");

                    lblfc.Visible = false;
                }
            }


            if (error > 0)
            {

                lblerror.Visible = true;
                lblSuccessMessage.Visible = false;
            }
            else
            {


                lblerror.Visible = false;
                lblsuccesss.Visible = true;
            }


        }


        protected void familiarsdgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {


            try
            {
                mest.executesql("DELETE FROM `EP_ColaboradorFamilia` WHERE ColaboradorFamiliaID = '" + familiarsdgv.DataKeys[e.RowIndex].Value.ToString() + "'");

                llenartabla(familiarsdgv, mest.llenardgvfamilia(cifglobal, lote));
                lblSuccessMessage.Text = "Registro eliminado exitosamente";
                lblErrorMessage.Text = "";

            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }





        }

        protected void familiarsdgv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                mest.executesql(" UPDATE `EP_ColaboradorFamilia` SET `ColaboradorFamiliaNombre`='" + (familiarsdgv.Rows[e.RowIndex].FindControl("txtfamiliarnom") as TextBox).Text.ToUpper() + "'," +
                    "`ColaboradorFamiliaOcupacion`='" + (familiarsdgv.Rows[e.RowIndex].FindControl("txtocupacion") as TextBox).Text.ToUpper() + "'" +
                    ",`ColaboradorFamiliaComentario`='" + (familiarsdgv.Rows[e.RowIndex].FindControl("txtcoment") as TextBox).Text.ToUpper() + "'," +
                    "`ColaboradorFamiliaFecNacimient`='" + (familiarsdgv.Rows[e.RowIndex].FindControl("txtfechanac") as TextBox).Text + "' WHERE ColaboradorID = '" + cifglobal + "' AND ColaboradorFamiliaID = '" + (familiarsdgv.Rows[e.RowIndex].FindControl("lblidcolab") as Label).Text + "'  ");




                familiarsdgv.EditIndex = -1;
                llenartabla(familiarsdgv, mest.llenardgvfamilia(cifglobal, lote));
                lblSuccessMessage.Text = "Registro modificado exitosamente";
                lblErrorMessage.Text = "";


            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }


        }
    }
}