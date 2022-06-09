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
    public partial class est_ingresosrela : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;

        //protected void ColaboradorIngresoSueldoBase_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorIngresoSueldoBase.Text != "")
        //    {

        //        string c1 = ColaboradorIngresoSueldoBase.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorIngresoSueldoBase = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_ingresosrela.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }
        //}

        //protected void ColaboradorIngresoBonifica_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorIngresoBonifica.Text != "")
        //    {

        //        string c1 = ColaboradorIngresoBonifica.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorIngresoBonifica = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Bonificaciones '); window.location.href= 'est_ingresosrela.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }

        //}

        //protected void ColaboradorIngresoComisiones_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorIngresoComisiones.Text != "")
        //    {

        //        string c1 = ColaboradorIngresoComisiones.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorIngresoComisiones = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo Comisiones '); window.location.href= 'est_ingresosrela.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }

        //}

        string[] loteact;

       

        protected void btningresos_Click(object sender, EventArgs e)
        {
            int error = 0;

            double f1, f2, f3;
            f1 = (ColaboradorIngresoSueldoBase.Text == "") ? Convert.ToDouble(ColaboradorIngresoSueldoBase.Text = "0") : Convert.ToDouble(ColaboradorIngresoSueldoBase.Text.Replace(",", ""));
            f2 = (ColaboradorIngresoBonifica.Text == "") ? Convert.ToDouble(ColaboradorIngresoBonifica.Text = "0") : Convert.ToDouble(ColaboradorIngresoBonifica.Text.Replace(",", ""));
            f3 = (ColaboradorIngresoComisiones.Text == "") ? Convert.ToDouble(ColaboradorIngresoComisiones.Text = "0") : Convert.ToDouble(ColaboradorIngresoComisiones.Text.Replace(",", ""));

            if (f1 <= 0)
            {
                lblsueldobase.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorIngresoSueldoBase.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorIngresoSueldoBase = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

          

                lblsueldobase.Visible = false;
            }

            if (f2 <= 0)
            {
                lblbonif.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorIngresoBonifica.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorIngresoBonifica = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblbonif.Visible = false;
            }
            if (f3 < 0)
            {
                lblcomis.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorIngresoComisiones.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorIngresoComisiones = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblcomis.Visible = false;
            }

            if (error > 0) { lblSuccessMessage1.Visible = false;lblerror.Visible = true; }
            else { lblSuccessMessage1.Visible = true; lblerror.Visible = false; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            estadoep = Convert.ToString(Session["estadoepp"]);
            if (estadoep == "0")
            {
                blk.Text = "0";
                lb.Visible = false;
                ScriptManager.RegisterStartupScript(this, this.Page.GetType(), "bloqueado", "bloqueado();", true);

            }
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            loteact = lte.lotevalido();
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack) { carga(); }
           
        }
        public void carga()
        {

            DataTable dt = new DataTable();
            dt = mest.datosgen(cifglobal, lote);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {

                    ColaboradorIngresoSueldoBase.Text = row["ColaboradorIngresoSueldoBase"].ToString();
                    ColaboradorIngresoBonifica.Text = row["ColaboradorIngresoBonifica"].ToString();
                    ColaboradorIngresoComisiones.Text = row["ColaboradorIngresoComisiones"].ToString();
           

                }
            }
            else
            {


            }


        }


    }
}