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
    public partial class VentanaEmergencias : System.Web.UI.Page
    {
        ModeloEST mest = new ModeloEST();
        Conexion conexiongeneral = new Conexion();
        loteval lt = new loteval();
        string cifglobal, usernombre, lote;
        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"]);
            lote = Convert.ToString(Session["lotepasa"]);
            cifglobal = mest.idusuariogeneral(usernombre);
            if (!IsPostBack)
            {
                llenadocombo("SELECT * FROM `Gen_TipoParentesco`", parentescodrp, "TipoParentescoDescripcion", "TipoParentescoID", "Parentesco");
                
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

        protected void agregaremergencias_Click(object sender, EventArgs e)
        {
            if ( parentescodrp.SelectedIndex != 0 && txttelefono.Text != "" && txtnombre.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorContactoEmer", "ColaboradorContactoEID");

                mest.executesql("INSERT INTO `EP_ColaboradorContactoEmer`(`LoteID`, `ColaboradorID`, `ColaboradorContactoEID`, `ColaboradorContactoENombre`, `ColaboradorContactoETelefono`, `TipoParentescoID`)" +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + txtnombre.Text + "','" + txttelefono.Text + "','" + parentescodrp.SelectedValue + "')");
                txtnombre.Text = "";
                txttelefono.Text = "";
                parentescodrp.SelectedIndex = 0;
                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;
            }
            else
            {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;
            }
        }
    }
}