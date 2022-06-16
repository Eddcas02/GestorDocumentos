using System;
using KB_Guadalupana.Controllers;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Drawing;

namespace KB_Guadalupana.Views.Procesos
{
    public partial class visordocumentos : System.Web.UI.Page
    {
        Conexion conexiongeneral = new Conexion();
        Sentencia_proceso sn = new Sentencia_proceso();
        string usuario;
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Convert.ToString(Session["path"]);
            usuario = Session["sesion_usuario"] as string;
            visor1.Document = path;
            permisoscarga(usuario);
        }

        void permisoscarga(string id) {
            DataTable permi = new DataTable();
            string[] datos = new string[100];
            int i = 0;
            string iduser = sn.obteneridusuario(id);
            permi = sn.permisosuser(iduser);

            foreach (DataRow row in permi.Rows)
            {
                datos[i] = row["permiso"].ToString();

                i++;
            }

            if (datos[2] == "3")
            {
                visor1.ToolbarVisible = true;
               
            }
            else {

                visor1.ToolbarVisible = false;
            }
        }
    }
}