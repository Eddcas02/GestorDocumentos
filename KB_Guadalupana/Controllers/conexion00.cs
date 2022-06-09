using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace KB_Guadalupana.Controllers
{
    public class conexion00
    {

        public MySqlConnection conne1 = new MySqlConnection();

        public string cc = "";
        public string mensaje = "";


        public void abrirconexion()
        {

            try
            {
                cc = "Server=10.60.81.5;Database=bdkbguadalupana;Uid=BDuser1205;Pwd=K91nforPGADM;";
                conne1 = new MySqlConnection(cc);
                conne1.Open();
                mensaje = "Conectado";


            }
            catch (Exception ex)
            {

                mensaje = "errod de conexion";
            }

        }
        public void cerrar()
        {

            conne1.Close();


        }
    }
}