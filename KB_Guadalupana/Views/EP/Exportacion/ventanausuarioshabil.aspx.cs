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
    public partial class ventanausuarioshabil : System.Web.UI.Page
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

        protected void habilitarcolab_Click(object sender, EventArgs e)
        {

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
                    if (okasig != "") {
                        if (existe != "")
                        {
                            mest.executesql("UPDATE EP_Colaborador SET ColaboradorEstado = 0 WHERE LoteID = '"+lotes+"' AND ColaboradorID = '"+cif.Text+"'");
                           lblsuccess.Visible = true;

                        }
                        else {

                                         lblerror.Visible = true;
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