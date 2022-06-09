using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using KB_Guadalupana.Controllers;

namespace KB_Guadalupana.Views.Excedentes
{
    public partial class Registros : System.Web.UI.Page
    {
        objetoExce obj = new objetoExce();
        bitacora bt = new bitacora();
        ModeloESX mj = new ModeloESX();
        objCred ocre = new objCred();

        string fechamin, horamin, fechahora, usernombre, nombrepersona;
        string fechaactual;

        char delimitador2 = ' ';
        protected void Page_Load(object sender, EventArgs e)
        {
            usernombre = Convert.ToString(Session["sesion_usuario"] );
            nombrepersona = Convert.ToString(Session["Nombre"]);
            now();
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

        public void obtenercredito(string id, string cred)
        {

            string exist = mj.recibobuscar(cred);
            string exiss = mj.recib(id);
            if (nocredito.Text != exist)
            {
                var url = $"http://10.60.81.49:82/APIEXBK/api/BKDATOS/{cred}";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var responseBody = reader.ReadToEnd();
                    objCred deserializedProduct = JsonConvert.DeserializeObject<objCred>(responseBody);


                    if (responseBody != "")
                    {

                        string numcred2 = deserializedProduct.COLNUMDOCUMEN;





                        if (numcred2 == nocredito.Text)
                        {








                            var url2 = $"http://10.60.81.49:82/APIESX/api/BKDATOS/{id}/{cred}";
                            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create(url2);
                            using (HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse())
                            using (Stream stream2 = response2.GetResponseStream())
                            using (StreamReader reader2 = new StreamReader(stream2))
                            {
                                var responseBody2 = reader2.ReadToEnd();
                                objetoExce deserializedProduct2 = JsonConvert.DeserializeObject<objetoExce>(responseBody2);


                                if (responseBody2 != "")
                                {
                                    string boleta = deserializedProduct2.COLNUMBOLETA;
                                    string montorec = deserializedProduct2.COLVALINGRE01;
                                    string numcred = deserializedProduct2.COLNUMDOCUMEN;
                                    string transac = deserializedProduct2.COLNUMTRANSAC;

                                    decimal mnt2 = Convert.ToDecimal(montoex.Text.Replace(",", ""));
                                    double valors = Convert.ToDouble(montoex.Text.Trim().Replace(",", ""));


                                    if (boleta == norecibo.Text && numcred == nocredito.Text)
                                    {

                                        decimal mnt = Convert.ToDecimal(montorec);
                                        if (mnt2 > 0)
                                        {

                                            if (mnt2 <= mnt)
                                            {
                                                string area = mj.obtenerarea(usernombre);
                                                bt.bitacoraing(usernombre, "Nuevo ingreso");
                                                string ultimoing = mj.obtenerultimo("esx_ingresos", "idreging");
                                                string sql = "INSERT INTO esx_ingresos ( idreging, usuario, fecha,area ,no_recibo, no_cred, excedente, encontrado ) VALUES ('" + ultimoing + "', '" + usernombre + "', '" + fechaactual + "','" + area + "' ,'" + norecibo.Text + "', '" + nocredito.Text + "', '" + montoex.Text + "', 1);";
                                                mj.executesql(sql);
                                                String script = "alert('Valor Ingresado correctamente!');";
                                                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                                                norecibo.Text = "";
                                                nocredito.Text = "";
                                                montoex.Text = "";
                                            }
                                            else
                                            {
                                                String script = "alert('El valor del excedente no puede ser mayor al del recibo!');";
                                                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                                                bt.bitacoraing(usernombre, "Dato mal ingresado en monto");
                                            }

                                        }
                                        else
                                        {
                                            String script = "alert('Ingrese un valor mayo a 0');";
                                            ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                                            bt.bitacoraing(usernombre, "Dato ingresado menor a 0");
                                        }


                                    }
                                    else
                                    {
                                        String script = "alert('Los datos no coinciden con la infomación');";
                                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                                    }

                                }
                                else
                                {

                                    String script = "alert('Datos almacenados');";
                                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                                    bt.bitacoraing(usernombre, nocredito.Text + "--" + norecibo.Text);


                                    string area = mj.obtenerarea(usernombre);

                                    string ultimoing = mj.obtenerultimo("esx_ingresos", "idreging");
                                    string sql = "INSERT INTO esx_ingresos ( idreging, usuario, fecha,area ,no_recibo, no_cred, excedente, encontrado ) VALUES ('" + ultimoing + "', '" + usernombre + "', '" + fechaactual + "','" + area + "' ,'" + norecibo.Text + "', '" + nocredito.Text + "', '" + montoex.Text + "', 0);";
                                    mj.executesql(sql);

                                    norecibo.Text = "";
                                    nocredito.Text = "";
                                    montoex.Text = "";
                                }
                            }


                        }
                        else
                        {
                            String script = "alert('El número de crédito es inválido');";
                            ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                            bt.bitacoraing(usernombre, "Número de crédito mal ingresado");
                        }

                    }
                    else
                    {

                        String script = "alert('Crédito Inválido');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                        bt.bitacoraing(usernombre, nocredito.Text + "--" + norecibo.Text);


                        string area = mj.obtenerarea(usernombre);

                        string ultimoing = mj.obtenerultimo("esx_ingresos", "idreging");
                        string sql = "INSERT INTO esx_ingresos ( idreging, usuario, fecha,area ,no_recibo, no_cred, excedente, encontrado ) VALUES ('" + ultimoing + "', '" + usernombre + "', '" + fechaactual + "','" + area + "' ,'" + norecibo.Text + "', '" + nocredito.Text + "', '" + montoex.Text + "', 0);";
                        mj.executesql(sql);

                        norecibo.Text = "";
                        nocredito.Text = "";
                        montoex.Text = "";
                    }
                }
            }
            else
            {
                String script = "alert('Este dato ya fue ingresado');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);


            }

        }
        public void obtener(string id, string cred)
        {
            string exist = mj.recibobuscar(cred);
            string exiss = mj.recib(id);
            if (nocredito.Text != exist)
            {
                var url = $"http://10.60.81.49:82/APIESX/api/BKDATOS/{id}/{cred}";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var responseBody = reader.ReadToEnd();
                    objetoExce deserializedProduct = JsonConvert.DeserializeObject<objetoExce>(responseBody);


                    if (responseBody != "")
                    {
                        string boleta = deserializedProduct.COLNUMBOLETA;
                        string montorec = deserializedProduct.COLVALINGRE01;
                        string numcred = deserializedProduct.COLNUMDOCUMEN;
                        string transac = deserializedProduct.COLNUMTRANSAC;

                        decimal mnt2 = Convert.ToDecimal(montoex.Text);
                        double valors = Convert.ToDouble(montoex.Text.Trim());


                        if (boleta == norecibo.Text && numcred == nocredito.Text)
                        {

                            decimal mnt = Convert.ToDecimal(montorec);
                            if (mnt2 > 0)
                            {

                                if (mnt2 <= mnt)
                                {
                                    string area = mj.obtenerarea(usernombre);
                                    bt.bitacoraing(usernombre, "Nuevo ingreso");
                                    string ultimoing = mj.obtenerultimo("esx_ingresos", "idreging");
                                    string sql = "INSERT INTO esx_ingresos ( idreging, usuario, fecha,area ,no_recibo, no_cred, excedente, encontrado ) VALUES ('" + ultimoing + "', '" + usernombre + "', '" + fechaactual + "','" + area + "' ,'" + norecibo.Text + "', '" + nocredito.Text + "', '" + montoex.Text + "', 1);";
                                    mj.executesql(sql);
                                    String script = "alert('Valor Ingresado correctamente');";
                                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                                    norecibo.Text = "";
                                    nocredito.Text = "";
                                    montoex.Text = "";
                                }
                                else
                                {
                                    String script = "alert('El valor del excedente no puede ser mayor al del recibo');";
                                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                                    bt.bitacoraing(usernombre, "Dato mal ingresado en monto");
                                }

                            }
                            else
                            {
                                String script = "alert('Ingrese un valor mayo a 0');";
                                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                                bt.bitacoraing(usernombre, "Dato ingresado menor a 0");
                            }


                        }
                        else
                        {
                            String script = "alert('Los datos no coinciden con la infomación');";
                            ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                        }

                    }
                    else
                    {

                        String script = "alert('Datos almacenados');";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                        bt.bitacoraing(usernombre, nocredito.Text + "--" + norecibo.Text);


                        string area = mj.obtenerarea(usernombre);

                        string ultimoing = mj.obtenerultimo("esx_ingresos", "idreging");
                        string sql = "INSERT INTO esx_ingresos ( idreging, usuario, fecha,area ,no_recibo, no_cred, excedente, encontrado ) VALUES ('" + ultimoing + "', '" + usernombre + "', '" + fechaactual + "','" + area + "' ,'" + norecibo.Text + "', '" + nocredito.Text + "', '" + montoex.Text + "', 0);";
                        mj.executesql(sql);

                        norecibo.Text = "";
                        nocredito.Text = "";
                        montoex.Text = "";
                    }
                }
            }
            else
            {


                String script = "alert('Este dato ya fue ingresado');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }

        }


        public static void GetItem(string id, string monto)
        {
            var url = $"https://localhost:44357/api/BKDATOS/{id}/{monto}";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            var responseBody = objReader.ReadToEnd();


                            objetoExce deserializedProduct = JsonConvert.DeserializeObject<objetoExce>(responseBody);






                            //var serializer = new JavaScriptSerializer();
                            //var jsonObject = serializer.DeserializeObject<List<obj>>(responseBody) ;

                            //var listProductos = JsonConvert.DeserializeObject<List<ExpandoObject>>(responseBody);

                            //foreach (dynamic prod in listProductos)
                            //{
                            //    Console.WriteLine("Código: " + prod);
                            //}

                            //string[] lines = responseBody.Split(new char[] { ','});
                            //string concat = lines[0] + lines[1] + lines[2] + lines[3];
                            //string[] lines2 = concat.Split(new char[] { '"' });
                            //string concat2 = lines2[0] + lines2[1] + lines2[2] + lines2[3] + lines2[4] + lines2[5] + lines2[6] + lines2[7] + lines2[8] + lines2[9] + lines2[10] + lines2[11] + lines2[12] + lines2[13] + lines2[14];
                            //int conx = lines2.Length;


                            // Do something with responseBody

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {

            if (norecibo.Text != "" && nocredito.Text != "" && montoex.Text != "")
            {
                obtenercredito(norecibo.Text.Trim(), nocredito.Text.Trim());

            }
            else
            {
                bt.bitacoraing(usernombre, "Error en ingreso");
                String script = "alert('Por favor llene todos los campos');";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

            }

        }
    }
}