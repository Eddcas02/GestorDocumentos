using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KB_Guadalupana.Controllers;
using System.Data;

namespace KB_Guadalupana.Views.EP.Ventanas
{
    public partial class VentanaOtrosEstudios : System.Web.UI.Page
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
                llenadocombo("SELECT * FROM `Gen_ModalidadEstudio` WHERE ModalidadEstudioActivo = 1 ", modalidaddrp, "ModalidadEstudioDescripcion", "ModalidadEstudioID", "Modalidad");

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
        protected void btnotrosestudios_Click(object sender, EventArgs e)
        {
            string [] loteval = lt.lotevalido();

            if (curso.Text != ""&&
            establecimiento.Text != ""&&
            modalidaddrp.SelectedIndex != 0 &&
            anio.Text != ""&&
            duracion.Text != "" ) {
                string ult = mest.obtenerultimo("EP_ColaboradorEstudioOtr", "ColaboradorEstudioOtrID");
                mest.executesql("INSERT INTO `EP_ColaboradorEstudioOtr`(`LoteID`, `ColaboradorID`, `ColaboradorEstudioOtrID`, `ColaboradorEstudioOtrCurso`, `ColaboradorEstudioOtrEstableci`, `ModalidadEstudioID`, `ColaboradorEstudioOtrAnio`, `ColaboradorEstudioOtrDuracion`) VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + curso.Text + "','" + establecimiento.Text + "','" + modalidaddrp.SelectedValue + "','" + anio.Text + "','" + duracion.Text + "')");

                curso.Text = "";
                establecimiento.Text = "";
                modalidaddrp.SelectedIndex = 0;
                anio.Text = "";
                duracion.Text = "";
                lblSuccessMessage1.Visible = true;
                lblerror.Visible = false;
            }
            else {
                lblerror.Visible = true;
                lblSuccessMessage1.Visible = false;
            }
        }
    }
}