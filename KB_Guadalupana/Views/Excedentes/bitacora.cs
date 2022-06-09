using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KB_Guadalupana.Controllers;

namespace KB_Guadalupana.Views.Excedentes
{
    public class bitacora
    {

        ModeloESX mj = new ModeloESX();
        string fechaactual;
        string fechamin, horamin, fechahora, usernombre, nombrepersona, coduser;
        char delimitador2 = ' ';


        public void bitacoraing( string userr  , string evento)
        {
            now();
           string area = mj.obtenerarea(userr);
            string ultimobit = mj.obtenerultimo("esx_bitacora", "idreg");
            string insertbit = "INSERT INTO `esx_bitacora`(`idreg`, `usuario`, `fecha`,`area` ,`evento`) VALUES ('" + ultimobit + "','" + userr + "','" + fechaactual + "', '"+area+"'  ,'" + evento + "')";
            mj.executesql(insertbit);

        }


        public void now()
        {

            string[] fecha = mj.datetime();
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