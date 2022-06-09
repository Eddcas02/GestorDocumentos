using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KB_Guadalupana.Controllers;

namespace KB_Guadalupana.Views.EP
{
    public class bitacoraest
    {
        ModeloEST mep = new ModeloEST();
        string fechaactual;
        string fechamin, horamin, fechahora, usernombre, nombrepersona, coduser;
        char delimitador2 = ' ';

        public void bitacora(string envio, string est, string etapa, string userr)
        {
            now();
            string ultimobit = mep.obtenerultimo("mj_bitacora", "idreg");
            string insertbit = "INSERT INTO `mj_bitacora`(`idreg`, `idenvio`, `idestado`, `idetapa`, `fechareg`, `usuario`) VALUES ('" + ultimobit + "','" + envio + "','" + est + "','" + etapa + "','" + fechaactual + "','" + userr + "')";
            mep.executesql(insertbit);

        }


        public void now()
        {

            string[] fecha = mep.datetime();
            try
            {
                for (int i = 0; i < fecha.Length; i++)
                {
                    fechamin = Convert.ToString(fecha.GetValue(0));
                    string hora = Convert.ToString(fecha.GetValue(1));

                    string[] valores2 = fechamin.Split(delimitador2);

                    fechahora = valores2[0] + "-" + valores2[1] + "-" + valores2[2] + " " + hora;

                    fechaactual = fechahora;

                }

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);

            }


        }
    }
}