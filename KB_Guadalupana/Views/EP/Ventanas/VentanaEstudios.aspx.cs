using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using KB_Guadalupana.Controllers;
using System.Data;
using MySql.Data.MySqlClient;

namespace KB_Guadalupana.Views.EP.Ventanas
{
    public partial class VentanaEstudios : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;

        protected void btnguardarestudios_Click(object sender, EventArgs e)
        {
            string[] infolote = lt.lotevalido();


            if (carrera.Text != "" && ciclo.Text != "" && anio.Text != "" && universidaddrp.SelectedIndex != 0 && ColaboradorEstudioUniGraduado.SelectedIndex !=0) {
                string ult = mest.obtenerultimo("EP_ColaboradorEstudioUni", "ColaboradorEstudioUniID");
                string dato = universidaddrp.SelectedValue;
                mest.executesql("INSERT INTO `EP_ColaboradorEstudioUni`(`LoteID`, `ColaboradorID`, `ColaboradorEstudioUniID`, `ColaboradorEstudioUniCarrera`, `ColaboradorEstudioUniUltCiclo`, `ColaboradorEstudiouniAnio`, `UniversidadID`, ColaboradorEstudioUniGraduado) VALUES ('" + lote + "','" + cifglobal + "','" + ult + "' ,'" + carrera.Text + "','" + ciclo.Text + "','" + anio.Text + "','" + universidaddrp.SelectedValue + "','"+ ColaboradorEstudioUniGraduado.SelectedValue+ "')");
                carrera.Text = "";
                universidaddrp.SelectedIndex = 0;
                anio.Text = "";
                ciclo.Text = "";

                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;
            }
            else {


                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;
            }


        }

        protected void universidaddrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UniversidadCiclo.Text = mest.obtenerciclo(universidaddrp.SelectedValue);
            
        }

        protected void ColaboradorEstudioUniGraduado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColaboradorEstudioUniGraduado.SelectedValue == "0")
            {
                ciclo.Enabled = true;
                ciclo.Text = "";
            }
            else
            {
                ciclo.Enabled = false;
                ciclo.Text = "0";
            }
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

        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack) {
                llenadocombo("SELECT * FROM `Gen_Universidad`", universidaddrp, "UniversidadNombre", "UniversidadID", "Universidad");
            }
        }
    }
}