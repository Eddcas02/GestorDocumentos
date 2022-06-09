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
    public partial class VentanaActivosCaja : System.Web.UI.Page
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
                llenadocombo("SELECT * FROM `Gen_EntidadFinanciera` ORDER BY EntidadFinPrioridad DESC ", entidaddrp, "EntidadFinDescripcion", "EntidadFinCodigo", "Entidad");
                llenadocombo("SELECT * FROM `Gen_Moneda`", monedadrp, "MonedaNombre", "MonedaID", "Moneda");
                llenadocombo("SELECT * FROM `Gen_TipoCuentaFinanciera` WHERE TipoCuentaFinEstado = 1", cuentadrp, "TipoCuentaFinDescripcion", "TipoCuentaFinCodigo", "Tipo-Cuenta");
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

        protected void btnguardarcuentas_Click(object sender, EventArgs e)
        {
            if (entidaddrp.SelectedIndex != 0 && cuentadrp.SelectedIndex != 0 && dropestado.SelectedIndex != 0 && txtorigen.Text != "" && monedadrp.SelectedIndex != 0 && nrmocuenta.Text != "" && txtsaldo.Text != "")
            {
                string[] infolote = lt.lotevalido();
                string ult = mest.obtenerultimo("EP_ColaboradorActivosCB", "ColaboradorActivoCBID");
                string c2 = txtsaldo.Text;
                decimal d2 = Convert.ToDecimal(c2.Replace(",", ""));
                mest.executesql("INSERT INTO `EP_ColaboradorActivosCB`(`LoteID`, `ColaboradorID`, `ColaboradorActivoCBID`, `TipoCuentaFinCodigo`, `EntidadFinCodigo`, `ColaboradorActivoCBActiva`, `MonedaID`, `ColaboradorActivoCBNumero`, `ColaboradorActivoCBSaldo`, `ColaboradorActivoCBOrigen`)" +
                    " VALUES ('" + lote + "','" + cifglobal + "','" + ult + "','" + cuentadrp.SelectedValue + "','" + entidaddrp.SelectedValue + "','" + dropestado.SelectedValue + "','" + monedadrp.SelectedValue + "','" + nrmocuenta.Text + "','" + d2+ "','" + txtorigen.Text + "')");
                cuentadrp.SelectedIndex = 0;
                entidaddrp.SelectedIndex = 0;
                monedadrp.SelectedIndex = 0;
                dropestado.SelectedIndex = 0;
                txtsaldo.Text = "";
                txtorigen.Text = "";
                nrmocuenta.Text = "";

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