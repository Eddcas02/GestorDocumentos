using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KB_Guadalupana.Controllers;
namespace KB_Guadalupana.Views.EP.Exportacion
{
    public class export
    {
        ModeloEST mest = new ModeloEST();
        public void importar(string tempo,string ColaboradorID, string LoteID, string LoteID2, string tablaorigen, string tabladestino)
        {
            string sql1 = "CREATE TEMPORARY TABLE "+tempo+" SELECT * FROM " + tablaorigen + " WHERE ColaboradorID= '" + ColaboradorID + "'  AND LoteID= '" + LoteID2 + "' ;" +

                "UPDATE " + tempo + " SET LoteID='" + LoteID + "' WHERE ColaboradorID='" + ColaboradorID + "';" +
                "INSERT INTO " + tabladestino + " SELECT * FROM " + tempo + " WHERE ColaboradorID = '" + ColaboradorID + "';" +
                "";
            mest.executesql(sql1);


        }


    }
}