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
    public partial class est_detalleLotes : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lte = new loteval();
        Exportacion.export ex = new Exportacion.export();
        string cifglobal, usernombre,lotes;
        string[] userss = new string[398];
        string[] loteact;
        string dato;
        protected void Page_Load(object sender, EventArgs e)
        {
            lotes = Convert.ToString(Session["lotepasaadm"]);
            if (!IsPostBack) {

                mest.llenartabla(lote, mest.llenarusuarios());
                mest.llenadocombo("SELECT * FROM `gen_sucursal`", gerenciadrp, "gen_sucursalnombre", "codgensucursal", "Gerencia");

            }
        }

        protected void chkall_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox chckheader = (CheckBox)lote.HeaderRow.FindControl("chkall");
            foreach (GridViewRow row in lote.Rows)
            {
                CheckBox chckrw = (CheckBox)row.FindControl("CheckBox1");
                if (chckheader.Checked == true)
                {
                    chckrw.Checked = true;

                }
                else
                {
                    chckrw.Checked = false;
                }

            }

        }

        protected void gerenciadrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dato = gerenciadrp.SelectedValue;
            mest.llenadocombo("SELECT * FROM `gen_area` where codgensucursal = '" + dato + "' ", deptoagedrp, "gen_areanombre", "codgenarea", "Departamento/Agencia");


        }

        protected void deptoagedrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            mest.llenartabla(lote, mest.llenarusuariosdepto(gerenciadrp.SelectedValue, deptoagedrp.SelectedValue));
        }

        protected void habil_CheckedChanged(object sender, EventArgs e)
        {
            if (habil.Checked)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            else
            {
                panel1.Visible = false;
                panel2.Visible = true;

            }

        }

       

        protected void btnbuscarperiodo_Click(object sender, EventArgs e)
        {
            mest.llenartabla(lote, mest.llenarusuariosperiodo(txtfechaingreso.Text, TextBox1.Text));
        }

        protected void AsignarLote_Click(object sender, EventArgs e)
        {
           
            int i = 0;
     
            foreach (GridViewRow row in lote.Rows)
            {
                CheckBox chckrw = (CheckBox)row.FindControl("CheckBox1");
                if (chckrw.Checked == true)
                {
                    Label cif = (Label)row.FindControl("cif");
                    string existe = mest.UltimoLote(cif.Text);
                    string okasig = mest.okasig(cif.Text,lotes);
                   userss[i] =okasig; 
                    if (okasig == "") {
                        if (existe != "")
                        {
                           
                            ex.importar("tmp1",cif.Text, lotes, existe, "EP_Colaborador",                  "EP_Colaborador");
                            ex.importar("tmp2",cif.Text, lotes, existe, "EP_ColaboradorActivosBienes", "EP_ColaboradorActivosBienes");
                            ex.importar("tmp3",cif.Text, lotes, existe, "EP_ColaboradorActivosCB", "EP_ColaboradorActivosCB");
                            ex.importar("tmp4",cif.Text, lotes, existe, "EP_ColaboradorActivosCXC", "EP_ColaboradorActivosCXC");
                            ex.importar("tmp5",cif.Text, lotes, existe, "EP_ColaboradorActivosEquipo", "EP_ColaboradorActivosEquipo");
                            ex.importar("tmp6",cif.Text, lotes, existe, "EP_ColaboradorActivosInv", "EP_ColaboradorActivosInv");
                            ex.importar("tmp7",cif.Text, lotes, existe, "EP_ColaboradorActivosInver", "EP_ColaboradorActivosInver");
                            ex.importar("tmp8",cif.Text, lotes, existe, "EP_ColaboradorActivosOtros", "EP_ColaboradorActivosOtros");
                            ex.importar("tmp9",cif.Text, lotes, existe, "EP_ColaboradorActivosVehiculos", "EP_ColaboradorActivosVehiculos");
                            ex.importar("tmp10",cif.Text, lotes, existe, "EP_ColaboradorContactoEmer", "EP_ColaboradorContactoEmer");
                            ex.importar("tmp11",cif.Text, lotes, existe, "EP_ColaboradorEstudioOtr", "EP_ColaboradorEstudioOtr");
                            ex.importar("tmp12",cif.Text, lotes, existe, "EP_ColaboradorEstudioUni", "EP_ColaboradorEstudioUni");
                            ex.importar("tmp13",cif.Text, lotes, existe, "EP_ColaboradorFamilia", "EP_ColaboradorFamilia");
                            ex.importar("tmp14",cif.Text, lotes, existe, "EP_ColaboradorIngresoNegocio", "EP_ColaboradorIngresoNegocio");
                            ex.importar("tmp15",cif.Text, lotes, existe, "EP_ColaboradorIngresoOtro", "EP_ColaboradorIngresoOtro");
                            ex.importar("tmp16",cif.Text, lotes, existe, "EP_ColaboradorIngresoRemesa", "EP_ColaboradorIngresoRemesa");
                            ex.importar("tmp17",cif.Text, lotes, existe, "EP_ColaboradorPasivoContin", "EP_ColaboradorPasivoContin");
                            ex.importar("tmp18",cif.Text, lotes, existe, "EP_ColaboradorPasivoCXP", "EP_ColaboradorPasivoCXP");
                            ex.importar("tmp19",cif.Text, lotes, existe, "EP_ColaboradorPasivoPrestamo", "EP_ColaboradorPasivoPrestamo");
                            ex.importar("tmp20",cif.Text, lotes, existe, "EP_ColaboradorPasivoTC", "EP_ColaboradorPasivoTC");
                            ex.importar("tmp21",cif.Text, lotes, existe, "EP_ColaboradorTelefono", "EP_ColaboradorTelefono");
                            lblsuccess.Visible = true;
                            mest.executesql("UPDATE EP_Colaborador SET ColaboradorEstado = 0 WHERE ColaboradorID = '" + cif.Text + "' AND LoteID= '" + lotes + "'");
                        }
                        else {

                            mest.executesql("INSERT INTO `EP_Colaborador` (`LoteID`, `ColaboradorID`, `codgensucursal`, `gen_sucursalnombre`, `codgenarea`, `codgenpuestos`, `ColaboradorFecIngreso`, `ColaboradorFecRegistro`, `ColaboradorPrimerApellido`, `ColaboradorSegundoApellido`, `ColaboradorCasadaApellido`, `ColaboradorPrimerNombre`, `ColaboradorSegundoNombre`, `ColaboradorOtroNombre`, `ColaboradorDirDomicilio`, `ColaboradorZonaDomicilio`, `DivisionGeograficaID`, `SubDivisionGeograficaID`, `ZonaDivisionGeograficaID`, `TipoIdentificacionID`, `ColaboradorNoIdentificacion`, `ColaboradorFecNacimiento`, `ColaboradorNIT`, `ColaboradorNacionalidad`, `ColaboradorEmailPersonal`, `ColaboradorEmailLaboral`, `ColaboradorEstatura`, `ColaboradorPeso`, `ColaboradorReligion`, `EstadoCivilID`, `ColaboradorConyugeNombre`, `ColaboradorConyugeOcupacion`, `ColaboradorConyugeFecNacimient`, `ColaboradorPEP`, `ColaboradorCPE`, `ColaboradorActivosCaja`, `ColaboradorInversionFenarore`, `ColaboradorActivoMenEQCant`, `ColaboradorActivoMenEQVAlor`, `ColaboradorActivoMenSalaCant`, `ColaboradorActivoMenSalaValor`, `ColaboradorActivoMenComeCant`, `ColaboradorActivoMenComeValor`, `ColaboradorActivoMenTVCant`, `ColaboradorActivoMenTVValor`, `ColaboradorActivoMenSonCant`, `ColaboradorActivoMenSonValor`, `ColaboradorActivoMenLavCant`, `ColaboradorActivoMenLavValor`, `ColaboradorActivoMenSecCant`, `ColaboradorActivoMenSecValor`, `ColaboradorActivoMenEstCant`, `ColaboradorActivoMenEstValor`, `ColaboradorActivoMenRefCant`, `ColaboradorActivoMenRefValor`, `ColaboradorActivoMenCelCant`, `ColaboradorActivoMenCelValor`, `ColaboradorActivoMenOtrDesc`, `ColaboradorActivoMenOtrValor`, `ColaboradorIngresoSueldoBase`, `ColaboradorIngresoBonifica`, `ColaboradorIngresoComisiones`, `ColaboradorEgresoAlimentacion`, `ColaboradorEgresoTransporte`, `ColaboradorEgresoEstudio`, `ColaboradorEgresoPrestamo`, `ColaboradorEgresoExtraFin`, `ColaboradorEgresoVestuario`, `ColaboradorEgresoRecreacion`, `ColaboradorEgresoOtros`, ColaboradorEstado) VALUES ('" + lotes + "', '" + cif.Text + "', '4', '4', '30', '273', '2022-02-07', '2022-02-11', '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, '89', '5', '1', '1', NULL, NULL, '', NULL, '', '', NULL, NULL, '', '2', NULL, NULL, '2022-02-01', '0', '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, '0', '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0);");
                            lblsuccess.Visible = true;
                        } 
                    }
                }
                else
                {
               
                }
                i++;
            }
            if (i > 0)
            {
                for (int f = 0; f<userss.Length; f++) {

                    dato = userss[i];
                        }

                lblusuarios.Text = dato;
            }
            else {
                lblsuccess.Visible = true;
            }
        }

        protected void lote_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            lote.PageIndex = e.NewPageIndex;
            mest.llenartabla(lote, mest.llenarusuarios());
        }

   

     

    
    }
}