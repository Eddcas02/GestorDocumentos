using System;
using System.Collections.Generic;
using KB_Guadalupana.Controllers;
using System.Linq;
using System.Web;

namespace KB_Guadalupana.Views.Evaluaciones
{
    public class clasebit
    {



        ModeloSQ msq = new ModeloSQ();
        string fechaactual;
        string fechamin, horamin, fechahora, usernombre, nombrepersona, coduser;
        char delimitador2 = ' ';


        public void bitacora(string usuario, string btn)
        {
            now();
            string ultimobit = msq.obtenerfinal("sq_bitacora", "idreg");
            string insertbit = "INSERT INTO `sq_bitacora`(`idreg`, `fecha`, `usuario`, `btn`) VALUES ('" + ultimobit + "','" + fechaactual + "','" + usuario + "','" + btn + "')";
            msq.Insertar(insertbit);

        }


        public void now()
        {

            string[] fecha = msq.datetime();
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