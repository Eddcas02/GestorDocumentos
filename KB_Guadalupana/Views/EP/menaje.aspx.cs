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
    public partial class menaje : System.Web.UI.Page
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
                lb.Visible = false;
                ScriptManager.RegisterStartupScript(this, this.Page.GetType(), "bloqueado", "bloqueado();", true);

            }
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

                    ColaboradorActivoMenEQCant.Text = row["ColaboradorActivoMenEQCant"].ToString();
                    ColaboradorActivoMenEQVAlor.Text = row["ColaboradorActivoMenEQVAlor"].ToString();
                    ColaboradorActivoMenSalaCant.Text = row["ColaboradorActivoMenSalaCant"].ToString();
                    ColaboradorActivoMenSalaValor.Text = row["ColaboradorActivoMenSalaValor"].ToString();
                    ColaboradorActivoMenComeCant.Text = row["ColaboradorActivoMenComeCant"].ToString();
                    ColaboradorActivoMenComeValor.Text = row["ColaboradorActivoMenComeValor"].ToString();
                    ColaboradorActivoMenTVCant.Text = row["ColaboradorActivoMenTVCant"].ToString();
                    ColaboradorActivoMenTVValor.Text = row["ColaboradorActivoMenTVValor"].ToString();
                    ColaboradorActivoMenSonCant.Text = row["ColaboradorActivoMenSonCant"].ToString();
                    ColaboradorActivoMenSonValor.Text = row["ColaboradorActivoMenSonValor"].ToString();
                    ColaboradorActivoMenLavCant.Text = row["ColaboradorActivoMenLavCant"].ToString();
                    ColaboradorActivoMenLavValor.Text = row["ColaboradorActivoMenLavValor"].ToString();
                    ColaboradorActivoMenSecCant.Text = row["ColaboradorActivoMenSecCant"].ToString();
                    ColaboradorActivoMenSecValor.Text = row["ColaboradorActivoMenSecValor"].ToString();
                    ColaboradorActivoMenEstCant.Text = row["ColaboradorActivoMenEstCant"].ToString();
                    ColaboradorActivoMenEstValor.Text = row["ColaboradorActivoMenEstValor"].ToString();
                    ColaboradorActivoMenRefCant.Text = row["ColaboradorActivoMenRefCant"].ToString();
                    ColaboradorActivoMenRefValor.Text = row["ColaboradorActivoMenRefValor"].ToString();
                    ColaboradorActivoMenCelCant.Text = row["ColaboradorActivoMenCelCant"].ToString();
                    ColaboradorActivoMenCelValor.Text = row["ColaboradorActivoMenCelValor"].ToString();
                    ColaboradorActivoMenOtrDesc.Text = row["ColaboradorActivoMenOtrDesc"].ToString();
                    ColaboradorActivoMenOtrValor.Text = row["ColaboradorActivoMenOtrValor"].ToString();








                }
            }
            else
            {


            }


        }



        protected void btnmenajeguardar_Click(object sender, EventArgs e)
        {

            int error = 0;

            double f1, f2, f3, f4, f5, f6, f7, f71, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18, f19, f21;
            string f20;

            f1 = (ColaboradorActivoMenEQCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenEQCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenEQCant.Text.Replace(",", ""));
            f2 = (ColaboradorActivoMenEQVAlor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenEQVAlor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenEQVAlor.Text.Replace(",", ""));
            f3 = (ColaboradorActivoMenSalaCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenSalaCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenSalaCant.Text.Replace(",", ""));
            f4 = (ColaboradorActivoMenSalaValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenSalaValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenSalaValor.Text.Replace(",", ""));
            f5 = (ColaboradorActivoMenComeCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenComeCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenComeCant.Text.Replace(",", ""));
            f6 = (ColaboradorActivoMenComeValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenComeValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenComeValor.Text.Replace(",", ""));
            f7 = (ColaboradorActivoMenTVCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenTVCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenTVCant.Text.Replace(",", ""));
            f8 = (ColaboradorActivoMenSonCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenSonCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenSonCant.Text.Replace(",", ""));
            f9 = (ColaboradorActivoMenSonValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenSonValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenSonValor.Text.Replace(",", ""));
            f10 = (ColaboradorActivoMenLavCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenLavCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenLavCant.Text.Replace(",", ""));
            f11 = (ColaboradorActivoMenLavValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenLavValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenLavValor.Text.Replace(",", ""));
            f12 = (ColaboradorActivoMenSecCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenSecCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenSecCant.Text.Replace(",", ""));
            f13 = (ColaboradorActivoMenSecValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenSecValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenSecValor.Text.Replace(",", ""));
            f14 = (ColaboradorActivoMenEstCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenEstCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenEstCant.Text.Replace(",", ""));
            f15 = (ColaboradorActivoMenEstValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenEstValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenEstValor.Text.Replace(",", ""));
            f71 = (ColaboradorActivoMenTVValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenTVValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenTVValor.Text.Replace(",", ""));
            f16 = (ColaboradorActivoMenRefCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenRefCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenRefCant.Text.Replace(",", ""));
            f17 = (ColaboradorActivoMenRefValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenRefValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenRefValor.Text.Replace(",", ""));
            f18 = (ColaboradorActivoMenCelCant.Text == "") ? Convert.ToDouble(ColaboradorActivoMenCelCant.Text = "0") : Convert.ToDouble(ColaboradorActivoMenCelCant.Text.Replace(",", ""));
            f19 = (ColaboradorActivoMenCelValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenCelValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenCelValor.Text.Replace(",", ""));
            f20 = (ColaboradorActivoMenOtrDesc.Text == "") ? ColaboradorActivoMenOtrDesc.Text = "N/A" : ColaboradorActivoMenOtrDesc.Text;
            f21 = (ColaboradorActivoMenOtrValor.Text == "") ? Convert.ToDouble(ColaboradorActivoMenOtrValor.Text = "0") : Convert.ToDouble(ColaboradorActivoMenOtrValor.Text.Replace(",", ""));




            if (f1 == 0 && f2 > 0)
            {
                lblcompu.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f1 > 0 && f2 == 0)
            {

                lblcompu.Visible = true; lblSuccessMessage1.Visible = false;
                error++;

            }
            else if (f1 == 0 && f2 == 0)
            {
                string c1 = ColaboradorActivoMenEQCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEQCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenEQVAlor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEQVAlor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);

                lblcompu.Visible = false;
            }
            else
            {

                string c1 = ColaboradorActivoMenEQCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEQCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenEQVAlor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEQVAlor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);
                lblcompu.Visible = false;
            }

            if (f3 == 0 && f4 > 0)
            {
                lblsala.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f3 > 0 && f4 == 0)
            {

                lblsala.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f3 == 0 && f4 == 0)
            {
                string c1 = ColaboradorActivoMenSalaCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSalaCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenSalaValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSalaValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);
                lblsala.Visible = false;


            }
            else
            {
                string c1 = ColaboradorActivoMenSalaCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSalaCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenSalaValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSalaValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);
                lblsala.Visible = false;
            }



            if (f5 == 0 && f6 > 0)
            {
                lblcomedor.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f5 > 0 && f6 == 0)
            {

                lblcomedor.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f5 == 0 && f6 == 0)
            {
                string c1 = ColaboradorActivoMenComeCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenComeCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenComeValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenComeValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);
                lblcomedor.Visible = false;
            }
            else
            {

                string c1 = ColaboradorActivoMenComeCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenComeCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenComeValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenComeValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);
                lblcomedor.Visible = false;
            }


            if (f7 == 0 && f71 > 0)
            {
                lbltv.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f7 > 0 && f71 == 0)
            {

                lbltv.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f7 == 0 && f71 == 0)
            {
                string c1 = ColaboradorActivoMenTVCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenTVCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                string c2 = ColaboradorActivoMenSonValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenTVValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);





                lbltv.Visible = false;
            }
            else
            {

                string c1 = ColaboradorActivoMenTVCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenTVCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                string c2 = ColaboradorActivoMenSonValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenTVValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);





                lbltv.Visible = false;
            }

            if (f8 == 0 && f9 > 0)
            {
                lblsonido.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f8 > 0 && f9 == 0)
            {

                lblsonido.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f8 == 0 && f9 == 0)
            {
                string c1 = ColaboradorActivoMenSonCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSonCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                string c2 = ColaboradorActivoMenSonValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSonValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);

                lblsonido.Visible = false;

            }
            else
            {

                string c1 = ColaboradorActivoMenSonCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSonCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                string c2 = ColaboradorActivoMenSonValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSonValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);

                lblsonido.Visible = false;
            }


            if (f10 == 0 && f11 > 0)
            {
                lbllavadora.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f10 > 0 && f11 == 0)
            {

                lbllavadora.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f10 == 0 && f11 == 0)
            {
                string c1 = ColaboradorActivoMenLavCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenLavCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                string c2 = ColaboradorActivoMenLavValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenLavValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2); lbllavadora.Visible = false;

            }
            else
            {

                string c1 = ColaboradorActivoMenLavCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenLavCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);



                string c2 = ColaboradorActivoMenLavValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenLavValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2); lbllavadora.Visible = false;
            }


            if (f12 == 0 && f13 > 0)
            {
                lblsecadora.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f12 > 0 && f13 == 0)
            {

                lblsecadora.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f12 == 0 && f13 == 0)
            {

                string c1 = ColaboradorActivoMenSecCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSecCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenSecValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSecValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);


                lblsecadora.Visible = false;

            }
            else
            {

                string c1 = ColaboradorActivoMenSecCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSecCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenSecValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenSecValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);


                lblsecadora.Visible = false;
            }



            if (f14 == 0 && f15 > 0)
            {
                lblestufa.Visible = true; lblSuccessMessage1.Visible = false; error++;
            }
            else if (f14 > 0 && f15 == 0)
            {

                lblestufa.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f14 == 0 && f15 == 0)
            {

                string c1 = ColaboradorActivoMenEstCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEstCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);
                string c2 = ColaboradorActivoMenEstValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEstValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);
                lblestufa.Visible = false;

            }
            else
            {
                string c1 = ColaboradorActivoMenEstCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEstCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);
                string c2 = ColaboradorActivoMenEstValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenEstValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);
                lblestufa.Visible = false;
            }



            if (f16 == 0 && f17 > 0)
            {
                lblrefri.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f16 > 0 && f17 == 0)
            {

                lblrefri.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f16 == 0 && f17 == 0)
            {

                string c1 = ColaboradorActivoMenRefCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenRefCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);
                string c2 = ColaboradorActivoMenRefValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenRefValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);


                lblrefri.Visible = false;

            }
            else
            {

                string c1 = ColaboradorActivoMenRefCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenRefCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);
                string c2 = ColaboradorActivoMenRefValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenRefValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);


                lblrefri.Visible = false;
            }


            if (f18 == 0 && f19 > 0)
            {
                lbltelefono.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f18 > 0 && f19 == 0)
            {

                lbltelefono.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f18 == 0 && f19 == 0)
            {

                string c1 = ColaboradorActivoMenCelCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenCelCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenCelValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenCelValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);



                lbltelefono.Visible = false;

            }
            else
            {


                string c1 = ColaboradorActivoMenCelCant.Text;
                decimal d1 = Convert.ToDecimal(c1.Replace(",", ""));
                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenCelCant = '" + d1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenCelValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenCelValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);



                lbltelefono.Visible = false;
            }


            if (f20 == "N/A" && f21 > 0)
            {
                lblotros.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f20 != "N/A" && f21 == 0)
            {

                lblotros.Visible = true; lblSuccessMessage1.Visible = false;
                error++;
            }
            else if (f20 == "N/A" && f21 == 0)
            {

                string c1 = ColaboradorActivoMenOtrDesc.Text;

                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenOtrDesc = '" + c1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenOtrValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenOtrValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);



                lblotros.Visible = false;

            }
            else
            {


                string c1 = ColaboradorActivoMenOtrDesc.Text;

                string sql = "UPDATE EP_Colaborador  SET ColaboradorActivoMenOtrDesc = '" + c1 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql);

                string c2 = ColaboradorActivoMenOtrValor.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                string sql2 = "UPDATE EP_Colaborador  SET ColaboradorActivoMenOtrValor = '" + d2 + "' WHERE LoteID  = '" + lote + "' AND ColaboradorID = '" + cifglobal + "'   ";
                mest.executesql(sql2);



                lblotros.Visible = false;
            }

            if (error > 0) { lblSuccessMessage1.Visible = false; lblerror.Visible = true; }
            else { lblSuccessMessage1.Visible = true; lblerror.Visible = false; }

        }




    }
}