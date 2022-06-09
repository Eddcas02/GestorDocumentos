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
    public partial class est_egresos : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;



        string[] loteact;

        //protected void ColaboradorEgresoOtros_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoOtros.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoOtros.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoOtros = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }
        //}

        //protected void ColaboradorEgresoRecreacion_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoRecreacion.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoRecreacion.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoRecreacion = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }

        //}

        //protected void ColaboradorEgresoVestuario_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoVestuario.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoVestuario.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoVestuario = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }
        //}

        //protected void ColaboradorEgresoExtraFin_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoExtraFin.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoExtraFin.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoExtraFin = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }
        //}

        //protected void ColaboradorEgresoPrestamo_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoPrestamo.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoPrestamo.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoPrestamo = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }

        //}

        //protected void ColaboradorEgresoEstudio_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoEstudio.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoEstudio.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoEstudio = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }
        //}

        //protected void ColaboradorEgresoTransporte_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoTransporte.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoTransporte.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoTransporte = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }
        //}

        //protected void ColaboradorEgresoAlimentacion_TextChanged(object sender, EventArgs e)
        //{
        //    if (ColaboradorEgresoAlimentacion.Text != "")
        //    {

        //        string c1 = ColaboradorEgresoAlimentacion.Text;
        //        decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
        //        string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoAlimentacion = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
        //        mest.executesql(sql);


        //    }
        //    else
        //    {
        //        String script = "alert('complete el campo de Sueldo Base '); window.location.href= 'est_egresos.aspx';";
        //        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

        //    }
        //}

        protected void btnegresos_Click(object sender, EventArgs e)
        {
            int error = 0;

            double f1, f2, f3,f4,f5,f6,f7,f8;
            f1 = (ColaboradorEgresoAlimentacion.Text == "") ? Convert.ToDouble(ColaboradorEgresoAlimentacion.Text = "") : Convert.ToDouble(ColaboradorEgresoAlimentacion.Text.Replace(",", ""));
            f2 = (ColaboradorEgresoTransporte.Text == "") ? Convert.ToDouble(ColaboradorEgresoTransporte.Text = "") : Convert.ToDouble(ColaboradorEgresoTransporte.Text.Replace(",", ""));
            f3 = (ColaboradorEgresoEstudio.Text == "") ? Convert.ToDouble(ColaboradorEgresoEstudio.Text = "0") : Convert.ToDouble(ColaboradorEgresoEstudio.Text.Replace(",", ""));
             f4 = (ColaboradorEgresoPrestamo.Text == "") ? Convert.ToDouble(ColaboradorEgresoPrestamo.Text = "0") : Convert.ToDouble(ColaboradorEgresoPrestamo.Text.Replace(",", ""));
            f5 = (ColaboradorEgresoExtraFin.Text == "") ? Convert.ToDouble(ColaboradorEgresoExtraFin.Text = "0") : Convert.ToDouble(ColaboradorEgresoExtraFin.Text.Replace(",", ""));
            f6 = (ColaboradorEgresoVestuario.Text == "") ? Convert.ToDouble(ColaboradorEgresoVestuario.Text = "") : Convert.ToDouble(ColaboradorEgresoVestuario.Text.Replace(",", ""));
            f7 = (ColaboradorEgresoRecreacion.Text == "") ? Convert.ToDouble(ColaboradorEgresoRecreacion.Text = "") : Convert.ToDouble(ColaboradorEgresoRecreacion.Text.Replace(",", ""));
            f8 = (ColaboradorEgresoOtros.Text == "") ? Convert.ToDouble(ColaboradorEgresoOtros.Text = "0") : Convert.ToDouble(ColaboradorEgresoOtros.Text.Replace(",", ""));

            if (f1 <= 0)
            {
                lblcomida.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoAlimentacion.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoAlimentacion = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblcomida.Visible = false;
            }

            if (f2 <= 0 )
            {
                lblgaso.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoTransporte.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoTransporte = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblgaso.Visible = false;
            }
            if (f3 < 0)
            {
                lblestudios.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoEstudio.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoEstudio = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblestudios.Visible = false;
            }
            if (f4 < 0)
            {
                lblprestamos.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoPrestamo.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoPrestamo = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblprestamos.Visible = false;
            }
            if (f5 < 0)
            {
                lblamorti.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoExtraFin.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoExtraFin = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblamorti.Visible = false;
            }
            if (f6 <= 0)
            {
                lblvestuario.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoVestuario.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoVestuario = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblvestuario.Visible = false;
            }
            if (f7 <= 0)
            {
                lblrecrea.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoRecreacion.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoRecreacion = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblrecrea.Visible = false;
            }
            if (f8 < 0)
            {
                lblotros.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else
            {
                string c1 = ColaboradorEgresoOtros.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorEgresoOtros = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                lblotros.Visible = false;
            }
     

            if (error > 0) { lblSuccessMessage1.Visible = false; lblerror.Visible = true; }
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
            if (!IsPostBack)
            {

                carga();


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

                    ColaboradorEgresoAlimentacion.Text = row["ColaboradorEgresoAlimentacion"].ToString();
                    ColaboradorEgresoTransporte.Text = row["ColaboradorEgresoTransporte"].ToString();
                    ColaboradorEgresoEstudio.Text = row["ColaboradorEgresoEstudio"].ToString();
                    ColaboradorEgresoPrestamo.Text = row["ColaboradorEgresoPrestamo"].ToString();
                    ColaboradorEgresoExtraFin.Text = row["ColaboradorEgresoExtraFin"].ToString();
                    ColaboradorEgresoVestuario.Text = row["ColaboradorEgresoVestuario"].ToString();
                    ColaboradorEgresoRecreacion.Text = row["ColaboradorEgresoRecreacion"].ToString();
                    ColaboradorEgresoOtros.Text = row["ColaboradorEgresoOtros"].ToString();
           

                }
            }
            else
            {


            }


        }
        //protected void btnfinalizar_Click(object sender, EventArgs e)
        //{
        //    bool listo;
        //    listo = lte.validaretapa(cifglobal, lote);
        //    if (listo == true)
        //    {
        //        string cambioetapa = "UPDATE EP_Colaborador SET ColaboradorEstado = 1 WHERE  ColaboradorID = '" + cifglobal + "' AND LoteID = '" + lote + "'  ";
        //        mest.executesql(cambioetapa);
        //        Label2.Visible = true;
             

        //    }
        //    else
        //    {
        //        Label3.Visible = true;

        //    }
        //}

    }
}