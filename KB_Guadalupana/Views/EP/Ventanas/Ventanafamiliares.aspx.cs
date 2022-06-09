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
    public partial class Ventanafamiliares : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        string cifglobal, usernombre, lote;
        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {

                

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
        protected void btnactualizarinfofam_Click(object sender, EventArgs e)
        {

        }

        protected void btnguardarinfofam_Click(object sender, EventArgs e)
        {

        
                if (nombrecom.Text != "" && fechanacfm.Text != "" && ocupacion.Text != "") {
                    string ult = mest.obtenerultimo("EP_ColaboradorFamilia", "ColaboradorFamiliaID");
                    mest.executesql("INSERT INTO `EP_ColaboradorFamilia`(`LoteID`, `ColaboradorID`, `ColaboradorFamiliaID`, `ColaboradorFamiliaNombre`, `ColaboradorFamiliaOcupacion`, `ColaboradorFamiliaComentario`, `ColaboradorFamiliaFecNacimient`) VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + nombrecom.Text.ToUpper() + "','" + ocupacion.Text.ToUpper() + "','" + coment.Text.ToUpper() + "','" + fechanacfm.Text + "' )");
                    nombrecom.Text = "";
                    fechanacfm.Text = "";
                    coment.Text = "";
                    ocupacion.Text = "";
                    lblSuccessMessage1.Visible = true;
                    lblerror.Visible = false;
                }
                else {
                    lblSuccessMessage1.Visible = false;
                    lblerror.Visible = true;
                }
            
      
                //if (nombrecom.Text != "" && fechanacfm.Text != "" && ocupacion.Text != "")
                //{
                //    string ult = mest.obtenerultimo("EP_ColaboradorFamilia", "ColaboradorFamiliaID");
                //    mest.executesql("INSERT INTO `EP_ColaboradorFamilia`(`LoteID`, `ColaboradorID`, `ColaboradorFamiliaID`, `ColaboradorFamiliaNombre`, `ColaboradorFamiliaOcupacion`, `ColaboradorFamiliaComentario`, `ColaboradorFamiliaFecNacimient`) VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + nombrecom.Text.ToUpper() + "','" + ocupacion.Text.ToUpper() + "','" + coment.Text.ToUpper() + "','" + fechanacfm.Text + "' )");

                  
                //    mest.executesql("UPDATE EP_Colaborador SET ColaboradorConyugeNombre = '"+nombrecom.Text.ToUpper()+"', ColaboradorConyugeOcupacion = '"+ocupacion.Text.ToUpper()+"', ColaboradorConyugeFecNacimient = '"+fechanacfm.Text+ "' WHERE ColaboradorID = '"+cifglobal+"' AND LoteID = '"+lote+"'    ");
                //    nombrecom.Text = "";
                //    fechanacfm.Text = "";
                //    coment.Text = "";
                //    ocupacion.Text = "";
                //    lblSuccessMessage1.Visible = true;
                //    lblerror.Visible = false;
                //}
                //else
                //{
                //    lblSuccessMessage1.Visible = false;
                //    lblerror.Visible = true;
                //}

            
        }
    }
}