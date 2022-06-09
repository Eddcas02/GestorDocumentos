using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KB_Guadalupana.Controllers;
using System.Data;

namespace KB_Guadalupana.Views.EP
{
    public partial class est_informacionGeneral : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        string cifglobal, usernombre, lote, estadoep;
        string[] loteact;
        protected void Page_Load(object sender, EventArgs e)
        {
            lote = Convert.ToString(Session["lotepasa"]);
            estadoep = Convert.ToString(Session["estadoepp"]);
            if (estadoep == "0")
            {
                blk.Text = "0";
                lb.Visible = false;
                ScriptManager.RegisterStartupScript(this, this.Page.GetType(), "bloqueado", "bloqueado();", true);

            }
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            loteact = lte.lotevalido();
            cifglobal = mest.idusuariogeneral(usernombre); lote = Convert.ToString(Session["lotepasa"]);
            if (!IsPostBack) {
               
               llenadocombo("SELECT * FROM `Gen_SubDivisionGeografica`", divisiondrp, "SubDivisionGeograficaDescripci", "SubDivisionGeograficaID", "Departamento");
       
            
          
                llenadocombo("SELECT * FROM `Gen_TipoDocumentoId`", tipodocumento, "TipoIdentificacionDescripcion", "TipoIdentificacionID", "Tipo-Documento");
                llenadocombo("SELECT * FROM `gen_sucursal`", gerenciadrp, "gen_sucursalnombre", "codgensucursal", "Gerencia");
                cargaporlote();
            }
           
            usernombre = Convert.ToString(Session["sesion_usuario"]);

            cifglobal = mest.idusuariogeneral(usernombre);
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
                    drp.Items.Insert(0, new System.Web.UI.WebControls.ListItem("["+valorcero+"]", "0"));
                }
                catch { Console.WriteLine("Verifique los campos"); }
            }
        }

        protected void gerenciadrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dato = gerenciadrp.SelectedValue;
            llenadocombo("SELECT * FROM `gen_area` where codgensucursal = '"+dato+"' ", deptoagedrp, "gen_areanombre", "codgenarea", "Departamento/Agencia");

        }

        protected void deptoagedrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dato = deptoagedrp.SelectedValue;
            llenadocombo("SELECT * FROM `gen_puestos` where codgenarea = '" + dato + "' ", puestodrp, "gen_puestosnombre", "codgenpuestos", "Puesto");


        }

        public void cargaporlote() {

            DataTable dt = new DataTable();
           
            llenadocombo("SELECT * FROM `gen_puestos` ", puestodrp, "gen_puestosnombre", "codgenpuestos", "Puesto");
            llenadocombo("SELECT * FROM `gen_area` ", deptoagedrp, "gen_areanombre", "codgenarea", "Departamento/Agencia");
            string[] datosinfogeneral = mest.datoslote(cifglobal, lote);



            dt = mest.datosgen(cifglobal, lote);
            if (dt.Rows.Count != 0)
            {
               
                    foreach (DataRow row in dt.Rows) {
                    if (row["ColaboradorPrimerApellido"].ToString() != "") papell.Enabled = false;
                    if (row["ColaboradorSegundoApellido"].ToString() != "") sapell.Enabled = false;
                    if (row["ColaboradorPrimerNombre"].ToString() != "") pnombre.Enabled = false;
                    if (row["ColaboradorSegundoNombre"].ToString() != "") snombre.Enabled = false;
      
                    txtcif.Text = row["ColaboradorID"].ToString();
                        gerenciadrp.SelectedValue = row["codgensucursal"].ToString();
                        deptoagedrp.SelectedValue = row["codgenarea"].ToString();
                        puestodrp.SelectedValue = row["codgenpuestos"].ToString();
                        txtfechaingreso.Text = row["fehcaingreso"].ToString();
                        papell.Text = row["ColaboradorPrimerApellido"].ToString();
                        sapell.Text = row["ColaboradorSegundoApellido"].ToString();
                        apellcasa.Text = row["ColaboradorCasadaApellido"].ToString();
                        pnombre.Text = row["ColaboradorPrimerNombre"].ToString();
                        snombre.Text = row["ColaboradorSegundoNombre"].ToString();
                        tnombre.Text = row["ColaboradorOtroNombre"].ToString();
                        direxa.Text = row["ColaboradorDirDomicilio"].ToString();

                        divisiondrp.SelectedValue = row["SubDivisionGeograficaID"].ToString();
                        llenadocombo("SELECT * FROM `Gen_ZonaDivisionGeografica` WHERE DivisionGeograficaID = '89' AND SubDivisionGeograficaID ='" + row["SubDivisionGeograficaID"].ToString() + "' ", subdivdrp, "ZonaDivisionGeograficaDescripc", "ZonaDivisionGeograficaID", "Municipio");
                        subdivdrp.SelectedValue = row["ZonaDivisionGeograficaID"].ToString();
                    string tamani = mest.obtenertamanio(tipodocumento.SelectedValue);

                    txtnodoc.Attributes.Add("maxlength", tamani);
                    if (tamani == "") txtnodoc.Attributes.Add("maxlength","13");

                    zonadivdrp.Text = row["ColaboradorZonaDomicilio"].ToString();
                        tipodocumento.SelectedValue = row["TipoIdentificacionID"].ToString();

                        txtnodoc.Text = row["ColaboradorNoIdentificacion"].ToString();
                        fechanacinfo.Text = row["fechanac"].ToString();
                        txtnit.Text = row["ColaboradorNIT"].ToString();
                        txtnacionalidad.Text = row["ColaboradorNacionalidad"].ToString();
                        correop.Text = row["ColaboradorEmailPersonal"].ToString();
                        correoi.Text = row["ColaboradorEmailLaboral"].ToString();
                        altura.Text = row["ColaboradorEstatura"].ToString();
                        peso.Text = row["ColaboradorPeso"].ToString();
                        txtreligion.Text = row["ColaboradorReligion"].ToString();
                 

                        string pep = row["ColaboradorPEP"].ToString();
                        string cpe = row["ColaboradorCPE"].ToString();
                        switch (pep) {
                            case "False":
                                chkOnOff.Checked = false;
                                break;
                            case "True":
                                chkOnOff.Checked = true;
                                break;
                            default:
                                chkOnOff.Checked = false;
                                break;

                        }
                        switch (cpe) {
                            case "False":
                                chkOnOff2.Checked = false;
                                break;
                            case "True":
                                chkOnOff2.Checked = true;
                                break;
                            default:
                                chkOnOff2.Checked = false;
                                break;
                        }


                    }
                  
              
               
            }
            else { 
            
            
            }


        }

   

      
        public void llenartabla(GridView dgv, DataTable dt)
        {
            DataTable dt1 = new DataTable();
            dt1 = dt;
            dgv.DataSource = dt1;
            dgv.DataBind();

        }
   

     

  






    

        protected void divisiondrp_TextChanged(object sender, EventArgs e)
        {
            string valor = divisiondrp.SelectedValue;
            llenadocombo("SELECT * FROM `Gen_ZonaDivisionGeografica` WHERE  SubDivisionGeograficaID = '" + valor + "' AND DivisionGeograficaID = 89 ", subdivdrp, "ZonaDivisionGeograficaDescripc", "ZonaDivisionGeograficaID", "Municipio");

        }

        protected void tipodocumento_TextChanged(object sender, EventArgs e)
        {
            string tamani = mest.obtenertamanio(tipodocumento.SelectedValue);

            txtnodoc.Attributes.Add("maxlength", tamani);
        }

  

        protected void btnGuardarinfogeneral_Click(object sender, EventArgs e)
        {

            //if lote y cif ya existen update
            string lt = mest.buscarloteandid(cifglobal, lote);
            if (lt == "") {

                string r1, r2;
                if (chkOnOff.Checked)
                {
                    r1 = "1";
                }
                else
                {
                    r1 = "0";
                }
                if (chkOnOff2.Checked)
                {
                    r2 = "1";
                }
                else
                {
                    r2 = "0";
                }


                mest.executesql("INSERT INTO `EP_Colaborador` (`LoteID`, `ColaboradorID`, `codgensucursal`, `gen_sucursalnombre`, `codgenarea`, `codgenpuestos`, `ColaboradorFecIngreso`, `ColaboradorFecRegistro`, `ColaboradorPrimerApellido`, `ColaboradorSegundoApellido`, `ColaboradorCasadaApellido`, `ColaboradorPrimerNombre`, `ColaboradorSegundoNombre`, `ColaboradorOtroNombre`, `ColaboradorDirDomicilio`, `ColaboradorZonaDomicilio`, `DivisionGeograficaID`, `SubDivisionGeograficaID`, `ZonaDivisionGeograficaID`, `TipoIdentificacionID`, `ColaboradorNoIdentificacion`, `ColaboradorFecNacimiento`, `ColaboradorNIT`, `ColaboradorNacionalidad`, `ColaboradorEmailPersonal`, `ColaboradorEmailLaboral`, `ColaboradorEstatura`, `ColaboradorPeso`, `ColaboradorReligion`, `EstadoCivilID`, `ColaboradorConyugeNombre`, `ColaboradorConyugeOcupacion`, `ColaboradorConyugeFecNacimient`, `ColaboradorPEP`, `ColaboradorCPE`, `ColaboradorActivosCaja`, `ColaboradorInversionFenarore`, `ColaboradorActivoMenEQCant`, `ColaboradorActivoMenEQVAlor`, `ColaboradorActivoMenSalaCant`, `ColaboradorActivoMenSalaValor`, `ColaboradorActivoMenComeCant`, `ColaboradorActivoMenComeValor`, `ColaboradorActivoMenTVCant`, `ColaboradorActivoMenTVValor`, `ColaboradorActivoMenSonCant`, `ColaboradorActivoMenSonValor`, `ColaboradorActivoMenLavCant`, `ColaboradorActivoMenLavValor`, `ColaboradorActivoMenSecCant`, `ColaboradorActivoMenSecValor`, `ColaboradorActivoMenEstCant`, `ColaboradorActivoMenEstValor`, `ColaboradorActivoMenRefCant`, `ColaboradorActivoMenRefValor`, `ColaboradorActivoMenCelCant`, `ColaboradorActivoMenCelValor`, `ColaboradorActivoMenOtrDesc`, `ColaboradorActivoMenOtrValor`, `ColaboradorIngresoSueldoBase`, `ColaboradorIngresoBonifica`, `ColaboradorIngresoComisiones`, `ColaboradorEgresoAlimentacion`, `ColaboradorEgresoTransporte`, `ColaboradorEgresoEstudio`, `ColaboradorEgresoPrestamo`, `ColaboradorEgresoExtraFin`, `ColaboradorEgresoVestuario`, `ColaboradorEgresoRecreacion`, `ColaboradorEgresoOtros`) VALUES " +
                                                                    "('" + lote + "', '" + cifglobal + "', '" + gerenciadrp.SelectedValue + "', '" + gerenciadrp.Text + "', '" + deptoagedrp.SelectedValue + "', '" + puestodrp.SelectedValue + "', '" + txtfechaingreso.Text + "', '2022-01-17', '" + papell.Text + "', '" + sapell.Text + "', '" + apellcasa.Text + "', '" + pnombre.Text + "', '" + snombre.Text + "', '" + tnombre.Text + "', '" + direxa.Text + "', '" + zonadivdrp.Text + "', '" + divisiondrp.SelectedValue + "', '" + subdivdrp.SelectedValue + "', '" + zonadivdrp.Text + "', '" + tipodocumento.SelectedValue + "', '" + txtnodoc.Text + "', '" + fechanacinfo.Text + "', '" + txtnit.Text + "', '" + txtnacionalidad.Text + "', '" + correop.Text + "', '" + correoi.Text + "', '" + altura.Text + "', '" + peso.Text + "', '" + txtreligion.Text + "', '1', NULL, NULL, NULL, '" + r1 + "', '" + r2 + "', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);");
       
                lblSuccessMessage1.Visible = true;
            }
            else {


                string r1, r2;
                if (chkOnOff.Checked)
                {
                    r1 = "1";
                }
                else
                {
                    r1 = "0";
                }
                if (chkOnOff2.Checked)
                {
                    r2 = "1";
                }
                else
                {
                    r2 = "0";
                }


                mest.executesql("UPDATE `EP_Colaborador` SET " +
                    "`codgensucursal`= '" + gerenciadrp.SelectedValue + "'," +
                    "`gen_sucursalnombre`='" + gerenciadrp.SelectedValue + "'," +
                    "`codgenarea`='" + deptoagedrp.SelectedValue + "'," +
                    "`codgenpuestos`='" + puestodrp.SelectedValue + "'," +
                    "`ColaboradorFecIngreso`='" + txtfechaingreso.Text + "'," +
                    "`ColaboradorFecRegistro`='2021-10-10'," +
                    "`ColaboradorPrimerApellido`='" + papell.Text + "'," +
                    "`ColaboradorSegundoApellido`='" + sapell.Text + "'," +
                    "`ColaboradorCasadaApellido`='" + apellcasa.Text + "'," +
                    "`ColaboradorPrimerNombre`='" + pnombre.Text + "',`" +
                    "ColaboradorSegundoNombre`='" + snombre.Text + "'," +
                    "`ColaboradorOtroNombre`='" + tnombre.Text + "'," +
                    "`ColaboradorDirDomicilio`='" + direxa.Text + "'," +
                    "`ColaboradorZonaDomicilio`='" + zonadivdrp.Text + "'," +
                    "`DivisionGeograficaID`='89'," +
                    "`SubDivisionGeograficaID`='" + divisiondrp.SelectedValue + "'," +
                    "`ZonaDivisionGeograficaID`='" + subdivdrp.SelectedValue + "'," +
                    "`TipoIdentificacionID`='" + tipodocumento.SelectedValue + "'," +
                    "`ColaboradorNoIdentificacion`='" + txtnodoc.Text + "'," +
                    "`ColaboradorFecNacimiento`='" + fechanacinfo.Text + "'," +
                    "`ColaboradorNIT`='" + txtnit.Text + "'," +
                    "`ColaboradorNacionalidad`='" + txtnacionalidad.Text + "'," +
                    "`ColaboradorEmailPersonal`='" + correop.Text + "'," +
                    "`ColaboradorEmailLaboral`='" + correoi.Text + "'," +
                    "`ColaboradorEstatura`='" + altura.Text + "'," +
                    "`ColaboradorPeso`='" + peso.Text + "'," +
                    "`ColaboradorReligion`='" + txtreligion.Text + "'," +

                    "`ColaboradorConyugeNombre`=''," +
                    "`ColaboradorConyugeOcupacion`=''," +
                    "`ColaboradorPEP`='" + r1 + "'," +
                    "`ColaboradorCPE`='" + r2 + "'" +
                                               "WHERE  ColaboradorID = '"+cifglobal+"' AND LoteID = '"+lote+"' ");
                lblSuccessMessage1.Visible = true;

            }


            //sino es un insert

        }

    }
}