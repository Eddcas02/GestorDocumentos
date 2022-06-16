using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KB_Guadalupana.Views.Procesos
{
    public partial class visordocumentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Convert.ToString(Session["path"]);

            visor1.Document = path;
        }
    }
}