using System;
using KB_Guadalupana.Controllers;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KB_Guadalupana.Controllers
{
    public class Sentencia_juridico
    {
        Conexion conexiongeneral = new Conexion();

        public void guardarcobros(string sig, string numproceso, string usuario, string numcredito, string cif, string nombre, string fechades, string plazo, string tasa, string montodes, string saldo, string valor)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_procesocobros VALUES ('" + sig + "', 1, '" + numproceso + "', '" + usuario + "', '" + numcredito + "', '" + cif + "', '" + nombre + "', '" + fechades + "', '" + plazo + "', '" + tasa + "', '" + montodes + "', '" + saldo + "', '" + valor + "')";
                }
                catch { }
            }
        }

        public void agregardemandado(string id, string nombres, string apellidos)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                sqlCon.Open();
                string query = "INSERT INTO pj_demandados VALUES('" + id + "', '" + nombres + "', '" + apellidos + "')";
                MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader = myCommand.ExecuteReader();
            }
        }

        public string siguiente(string tabla, string campo)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                    //Console.WriteLine("El resultado es: " + camporesultante);
                    if (String.IsNullOrEmpty(camporesultante))
                        camporesultante = "1";
                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }
        }

        public string siguienteCredito(string tabla, string campo)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                    //Console.WriteLine("El resultado es: " + camporesultante);
                    if (String.IsNullOrEmpty(camporesultante))
                        camporesultante = "101010";
                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }
        }

        public string siguienteTarjeta(string tabla, string campo)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                    //Console.WriteLine("El resultado es: " + camporesultante);
                    if (String.IsNullOrEmpty(camporesultante))
                        camporesultante = "900";
                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }
        }

        public void guardardocumentoexp(string id, string tipodoc, string archivo, string nombredoc, string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_documento VALUES ('" + id + "', '" + tipodoc + "', '" + archivo + "', '" + nombredoc + "', '" + credito + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string obtenerrutadocumento(string id)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_archivo FROM pj_documento WHERE idpj_documento = '" + id + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch { }
                return camporesultante;
            }
        }

        public string obtenernombredocumento(string id)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_nombrearchivo FROM pj_documento WHERE idpj_documento = '" + id + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch { }
                return camporesultante;
            }
        }

        public string[] obtenerinforcredito(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[50];
                int i = 0;

                try
                {
                    string consultaGraAsis = "SELECT * FROM gen_credito WHERE gen_numprestamo = '" + numcredito + "'";

                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;
            }
        }

        public void asignarcreditojuridico(string id, string numcredito, string fecha, string estado)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_asignacion_juridico VALUES ('" + id + "', '" + numcredito + "', '" + fecha + "', '" + estado + "') ";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string datetime()
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                string fecha = "";
                try
                {
                    string consultaGraAsis = "SELECT DATE_FORMAT(CURRENT_DATE,  '%Y %m %d')";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    fecha = reader.GetValue(0).ToString();
                    string[] fechaseparada = fecha.Split(' ');
                    string año = fechaseparada[0];
                    string mes = fechaseparada[1];
                    string dia = fechaseparada[2];
                    camporesultante = año + '-' + mes + '-' + dia;
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }

        }

        public void guardartipocredito(string id, string gastosco, string gastosju, string otrosgastos, string total, string comentario, string numcredito, string fecha, string fechaestado, string incendio, string intereses, string mora)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_tipocredito VALUES('" + id + "', '" + gastosco + "', '" + gastosju + "', '" + otrosgastos + "', '" + total + "', '" + comentario + "', '" + numcredito + "', '" + fecha + "', '" + fechaestado + "', '" + incendio + "', '" + intereses + "', '" + mora + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void guardartipotarjeta(string id, string numtarjeta, string numcuenta, string cif, string nombre1, string nombre2, string otronombre, string apellidocasada, string apellido, string apellido2, string limite, string saldo, string credito, string gastoscobranza, string gastosjudiciales, string otrosgastos, string comentario, string total, string fechacreacion, string fechaestado, string incendio, string intereses, string mora)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_tipotarjeta VALUES('" + id + "', '" + numtarjeta + "', '" + numcuenta + "', '" + cif + "', '" + nombre1 + "', '" + nombre2 + "', '" + otronombre + "', '" + apellidocasada + "', '" + apellido + "', '" + apellido2 + "', '" + limite + "', '" + saldo + "', '" + credito + "', '" + gastoscobranza + "', '" + gastosjudiciales + "', '" + otrosgastos + "', '" + comentario + "', '" + total + "', '" + fechacreacion + "', '" + fechaestado + "', '" + incendio + "', '" + intereses + "', '" + mora + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string[] obtenertipocredito(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_tipocredito WHERE pj_numcredito = '" + numcredito + "'";

                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;
            }
        }

        public string[] obtenertipotarjeta(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[20];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_tipotarjeta WHERE pj_numcredito = '" + numcredito + "'";

                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;
            }
        }

        public string[] obtenerdatoscredito(string NumCredito, string Nombres, string Apellidos)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                string consultaGraAsis;
                try
                {
                   
                    if (Apellidos != "" && Nombres != "")
                    {
                        consultaGraAsis = "SELECT gen_numprestamo, gen_nombre AS Nombre, gen_estado FROM gen_credito WHERE gen_numprestamo = '" + NumCredito + "' OR gen_nombre LIKE '%" + Apellidos + "%" + Nombres + "%'";
                    }
                    else if(Apellidos != "")
                    {
                        consultaGraAsis = "SELECT gen_numprestamo, gen_nombre AS Nombre, gen_estado FROM gen_credito WHERE gen_numprestamo = '" + NumCredito + "' OR gen_nombre LIKE '%" + Apellidos + "%'";
                    }
                    else if (Nombres != "")
                    {
                        consultaGraAsis = "SELECT gen_numprestamo, gen_nombre AS Nombre, gen_estado FROM gen_credito WHERE gen_numprestamo = '" + NumCredito + "' OR gen_nombre LIKE '%" + Nombres + "%'";
                    }
                    else
                    {
                        consultaGraAsis = "SELECT gen_numprestamo, gen_nombre AS Nombre, gen_estado FROM gen_credito WHERE gen_numprestamo = '" + NumCredito + "'";
                    }
                    

                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;
            }
        }

        public void guardaretapa(string id, string etapa, string credito, string fecha, string status, string usuario, string area, string nombrecliente, string numincidente)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_etapa_credito VALUES('" + id + "', '" + etapa + "', '" + credito + "', '" + fecha + "', '" + status + "', '" + usuario + "', '" + area + "', '"+nombrecliente+"', '"+numincidente+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string obteneridusuario(string usuario)
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    string consultaGraAsis = "SELECT codgenusuario FROM gen_usuario WHERE gen_usuarionombre = '"+usuario+"'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }

        }

        public void guardarcreditocontable(string id, string nombrearchivo, string ruta, string credito, string usuario, string observaciones)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_certificacioncontable VALUES ('"+id+"', '"+nombrearchivo+"', '"+ruta+"', '"+credito+"', '"+usuario+"', '"+observaciones+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void estadodevuelto(string credito, string area, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE DISTINCT pj_etapa_credito SET pj_status = 'Devuelto', gen_area = '" + area + "' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void estadoreingreso(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Reingreso' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "' AND pj_status = 'Devuelto'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void devolvercertificacionjuridico(string id, string credito, string comentario, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_certificacionjuridicodevolver VALUES ('"+id+"', '"+credito+"', '"+comentario+"', '"+usuario+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string creditoscobros()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE pj_status IN ('Devuelto', 'Investigacion', 'Medidas suficientes', 'Enviado','Reingreso') AND idpj_etapa IN (1,9)";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string creditoscobrosexpediente()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE pj_status IN ('Devuelto') AND idpj_etapa IN (1)";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string creditoscobrosdiligenciamiento()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE pj_status IN ('Investigacion', 'Medidas suficientes') AND idpj_etapa IN (9)";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string creditoscobrosfondos()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE pj_status IN ('Enviado','Reingreso') AND idpj_etapa IN (9)";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoInfornet(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '"+credito+ "' AND idpj_tipodocumento=1";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }
        public string tipodocumentoRecibo(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=2";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoDPI(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=3";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoCartaIngreso(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=4";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoContratos(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=6";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoSolicitudCredito(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=7";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoConsultaIggs(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=8";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoConsultaDicabi(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=9";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoBitacora(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=10";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoEstadoCuenta(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=11";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void cambiarestado(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Recibido' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '"+etapa+"'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoenviado(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Enviado' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadodesasignado(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Desasignado' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void estadoacobros(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Cobros' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string cantidadcreditoscobros()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_credito) FROM pj_etapa_credito WHERE idpj_etapa = 1 AND pj_status IN ('Enviado','Devuelto') ";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosconta()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (1,6,12,17) AND pj_status IN ('Enviado','Reingreso', 'Devuelto')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditoscontacertificacion()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (1) AND pj_status IN ('Enviado','Reingreso', 'Devuelto')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditoscontasolicitud()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (6,12,17) AND pj_status IN ('Enviado','Reingreso')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosjuridico()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (2,3,5,6,7,11,13,16,18,21,23,27,29) AND pj_status IN ('Enviado','Reingreso', 'Devuelto', 'Cargar Voucher')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosjuridicoexpedientes()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (2,3) AND pj_status IN ('Enviado','Reingreso', 'Devuelto')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosjuridicoreporte()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (3) AND pj_status IN ('Enviado')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosjuridicorequerimiento()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (5,7,11,13,16,18,27,29,21,23) AND pj_status IN ('Enviado', 'Reingreso', 'Cargar Voucher')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosabogado()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (4,8,9,20,24,10,25,33,15) AND pj_status IN ('Enviado','Reingreso', 'Rechazado', 'Diligenciamiento','Nueva Investigacion','Transaccion voluntaria', 'Transaccion no voluntaria')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosabogadodemanda()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (4) AND pj_status IN ('Enviado','Reingreso', 'Rechazado', 'Diligenciamiento')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosabogadodiligenciamiento()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (8,9) AND pj_status IN ('Enviado','Reingreso','Nueva Investigacion','Transaccion voluntaria', 'Transaccion no voluntaria')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosabogadonotificacioneva()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (20) AND pj_status IN ('Enviado','Reingreso')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosabogadofacturacion()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (10,25,33) AND pj_status IN ('Enviado','Reingreso')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosabogadonotificacion()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (15,20) AND pj_status IN ('Enviado','Reingreso')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void insertarbitacora(string id, string incidente, string credito, string nombre, string estado, string dearea, string paraarea, string fecha, string fechacreacion, string comentario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_bitacora VALUES('"+id+"', '"+incidente+"', '"+credito+"', '"+nombre+"', '"+estado+"', '"+dearea+"', '"+paraarea+"', '"+fecha+"', '"+fechacreacion+"', '"+comentario+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }


        public string fechacreacioncredito(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_fechacreacion FROM pj_tipocredito WHERE pj_numcredito = '" + numcredito+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string fechacreaciontarjeta(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_fechacreacion FROM pj_tipotarjeta WHERE pj_numcredito = '" + numcredito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }
        public string[] fechayhora()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT DATE_FORMAT(CURRENT_DATE,  '%Y %m %d'), CURRENT_TIME";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public void editartarjeta(string id, string numtarjeta, string numcuenta, string cif, string nombre1, string nombre2, string otronombre, string apellidocasada, string apellido, string apellido2, string limite, string saldo, string credito, string gastoscobranza, string gastosjudiciales, string otrosgastos, string comentario, string total, string fechaestado, string incendio, string intereses, string mora)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_tipotarjeta SET pj_numtarjeta='" + numtarjeta + "', pj_numcuenta='" + numcuenta + "', pj_cif='" + cif + "', pj_primernombre = '" + nombre1 + "', pj_segundonombre='" + nombre2 + "', pj_otronombre='" + otronombre + "', pj_apellidocasada='" + apellidocasada + "', pj_primerapellido = '" + apellido + "', pj_segundoapellido='" + apellido2 + "', pj_limite='" + limite + "', pj_saldo='" + saldo + "', pj_gastoscobranza='" + gastoscobranza + "', pj_seguro='" + gastosjudiciales + "', pj_otrosgastos='" + otrosgastos + "', pj_comentariogastos='" + comentario + "', pj_total='" + total + "', pj_fechaestado= '" + fechaestado + "', pj_incendio = '" + incendio + "', pj_interesesvencidos = '" + intereses + "', pj_mora = '" + mora + "' WHERE idpj_tipotarjeta='" + id + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void editarcredito(string id, string gastosco, string gastosju, string otrosgastos, string total, string comentario, string numcredito, string fechaestado, string incendio, string intereses, string mora)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_tipocredito SET pj_gastoscobranza='" + gastosco + "', pj_seguro='" + gastosju + "', pj_otrosgastos='" + otrosgastos + "', pj_total='" + total + "', pj_comentario='" + comentario + "', pj_fechaestado = '" + fechaestado + "', pj_incendio = '" + incendio + "', pj_interesesvencidos = '" + intereses + "', pj_mora = '" + mora + "' WHERE idpj_tipocredito = '" + id + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string area(string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_area FROM pj_controlingreso WHERE idpj_usuario = '" + usuario + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string nombrearea(string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT gen_areanombre FROM gen_area WHERE codgenarea = '" + id + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void actualizararea(string id, string nombre)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE gen_area SET gen_areanombre='"+nombre+ "' WHERE codgenarea='"+id+"'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch { }
            }
        }

        public void nuevaarea(string id, string nombre)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO gen_area VALUES('"+id+"', '"+nombre+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch { }
            }
        }

        public string obtenernumtipocredito(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_tipocredito FROM pj_tipocredito WHERE pj_numcredito = '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string obtenernumtipotarjeta(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_tipotarjeta FROM pj_tipotarjeta WHERE pj_numcredito = '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] traercertificacioncontable(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_certificacioncontable WHERE pj_numcredito = '"+credito+"'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public void editarcertificacioncontable(string credito, string numregistro, string contador, string observaciones, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_certificacioncontable SET pj_numregistrado='" + numregistro + "', pj_contador = '"+contador+ "', pj_observaciones = '"+observaciones+ "', pj_usuario = '"+usuario+"' WHERE pj_numcredito='" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch { }
            }
        }

        public DataTable reporteabogados(string abogado)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.pj_nombre, A.pj_cif, A.pj_numcredito, A.pj_fechaasignacion, B.pj_nombreabogado FROM pj_certificacionjuidico AS A INNER JOIN pj_abogado AS B ON B.idpj_abogado = A.idpj_abogado WHERE A.idpj_abogado = '"+abogado+"'";
                     MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public void insertarcertificacionjuridico(string id, string abogado, string tipoproceso, string procesonombre, string numcredito, string usuario, string fechaasignacion, string nombre, string cif, string observaciones)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_certificacionjuidico VALUES('"+id+"', '"+abogado+"', '"+tipoproceso+"', '"+procesonombre+"', '"+numcredito+"', '"+usuario+"', '"+fechaasignacion+"', '"+nombre+"', '"+cif+"', '"+observaciones+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch { }
            }
        }

        public void insertarmedidaspre(string id, string medida, string nombreotro, string numcredito, string tipo)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_asignacionmedidas VALUES('"+id+"', '"+medida+"', '"+nombreotro+"', '"+numcredito+"', '"+tipo+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch { }
            }
        }

        public string tipodocumentoMemorial(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=16";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipoproceso(string credito)
        {
            using(MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";

                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_tipoproceso FROM pj_certificacionjuidico WHERE pj_numcredito = '"+credito+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void insertarpresentaciondemanda(string id, string numincidente, string numproceso, string fechapresentacion, string numcredito, string oficial, string notificador, string numjuzgado, string nombrejuzgado, string departamento, string municipio, string usuario)
        {
            using(MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_presentaciondemanda VALUES ('"+id+"', '"+numincidente+"', '"+numproceso+"', '"+fechapresentacion+"', '"+numcredito+"', '"+oficial+"', '"+notificador+"', '"+numjuzgado+"', '"+nombrejuzgado+"', '"+departamento+"', '"+municipio+"', '"+usuario+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipodocumentoresolucion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=17";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void insertarresolucion(string id, string numcredito, string usuario, string estado, string motivorechazo, string fechanotificacion)
        {
            using(MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_resoluciontramite VALUES ('"+id+"', '"+numcredito+"', '"+usuario+"', '"+estado+"', '"+ motivorechazo + "', '"+fechanotificacion+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipodocumentoAvaluo(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=5";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoTransunion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=12";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public DataTable fechaactual()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DATE_FORMAT(CURDATE(), '%d / %m / %Y') AS Fecha";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable nombreabogado(string id)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_nombreabogado FROM pj_abogado WHERE idpj_abogado = '"+id+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable dpi(string usuario)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT(B.ep_informaciongeneralnumeroidentificacion) FROM ep_control AS A INNER JOIN ep_informaciongeneral AS B ON A.codepinformaciongeneralcif = B.codepinformaciongeneralcif WHERE A.codgenusuario = '"+usuario+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable nombreUsuario(string usuario)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT CONCAT(B.ep_informaciongeneralprimernombre , ' ' , B.ep_informaciongeneralsegundonombre , ' ' , B.ep_informaciongeneralprimerapellido , ' ' , B.ep_informaciongeneralsegundoapellido) AS Nombre FROM ep_control AS A INNER JOIN ep_informaciongeneral AS B ON A.codepinformaciongeneralcif = B.codepinformaciongeneralcif WHERE A.codgenusuario = '"+usuario+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public string tipodocumentoFactura(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=18";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void guardarfacturaabogado(string id, string numcredito, string usuario, string numfactura, string numserie, string descripcion, string importetotal, string fechaemision, string importecaso, string motivopago, string nombremotivo, string cif, string nombreaso, string nombrecheque, string observaciones, string estado, string etapa)
        {
            using(MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                sqlCon.Open();
                string query = "INSERT INTO pj_facturacionabogado VALUES ('"+id+"', '"+numcredito+"', '"+usuario+"', '"+numfactura+"', '"+numserie+"', '"+descripcion+"', '"+importetotal+"', '"+fechaemision+"', '"+importecaso+"', '"+motivopago+"', '"+nombremotivo+"', '"+cif+"', '"+nombreaso+"', '"+nombrecheque+"', '"+observaciones+"', '"+estado+"', '"+etapa+"')";
                MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader = myCommand.ExecuteReader();
            }
        }

        public string fecha()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DATE_FORMAT(CURDATE(), '%d / %m / %Y')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string importetotal(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_importetotal FROM pj_facturacionabogado WHERE pj_numcredito = '"+numcredito+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string importetotal6(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_importetotal FROM pj_facturacionabogado WHERE pj_numcredito = '" + numcredito + "' AND pj_estado = 'Pendiente6'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string importetotal8(string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_importetotal FROM pj_facturacionabogado WHERE pj_numcredito = '" + numcredito + "' AND pj_estado = 'Pendiente8'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public DataTable solicitudcheque(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT(B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_oficial AS Oficial FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie+ "' AND A.pj_estado = 'Pendiente' AND D.idpj_etapa = 5 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudcheque1(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente' AND D.idpj_etapa = 5";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa2(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT(B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_oficial AS Oficial FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente2' AND D.idpj_etapa = 11 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa22(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente2' AND D.idpj_etapa = 11";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa3(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT(B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_oficial AS Oficial FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente3' AND D.idpj_etapa = 16 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa33(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente3' AND D.idpj_etapa = 16";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa4(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT(B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_oficial AS Oficial FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente5' AND D.idpj_etapa = 25 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa44(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente5' AND D.idpj_etapa = 25";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa6(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT(B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe,B.pj_oficial AS Oficial FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente6' AND D.idpj_etapa = 34 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa8(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT(B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe,B.pj_oficial AS Oficial FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente8' AND D.idpj_etapa = 40 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudchequeEstapa66(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente6' AND D.idpj_etapa = 34";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public string fechaestadocredito(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DATE_FORMAT(pj_fechaestado, '%Y-%m-%d') FROM pj_tipocredito WHERE pj_numcredito = '" + credito+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string fechaestadotarjeta(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DATE_FORMAT(pj_fechaestado, '%Y-%m-%d') FROM pj_tipotarjeta WHERE pj_numcredito = '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string nombrearchivo(string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_nombrearchivo FROM pj_documento WHERE idpj_documento = '"+id+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string rolusuario(string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_rol FROM pj_controlingreso WHERE idpj_usuario = '" + usuario + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Iniciado'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura2(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Pendiente2'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura3(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Pendiente'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura4(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Pendiente3'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura5(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Pendiente5'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura6(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Pendiente6'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura8(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Pendiente8'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] puestos(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT f.organisup FROM sq_organigrama f INNER JOIN sq_personal t ON t.codesqpuesto = f.codsqpuesto WHERE t.codsqpersonal = '"+credito+"'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public DataTable reporteabogados2(string abogado, string fecha)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.pj_nombre, A.pj_cif, A.pj_numcredito, A.pj_fechaasignacion, B.pj_nombreabogado FROM pj_certificacionjuidico AS A INNER JOIN pj_abogado AS B ON B.idpj_abogado = A.idpj_abogado INNER JOIN  pj_etapa_credito AS C ON C.idpj_credito = A.pj_numcredito WHERE A.idpj_abogado = '"+abogado+ "' AND C.idpj_etapa = 3 AND C.pj_status IN('Enviado','Reingreso') AND C.pj_fecha = '"+ fecha +"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public void insertarreporteabogado(string id, string usuario, string fecha, string tipodoc, string ruta, string nombrearchivo, string observaciones, string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_reporteabogado VALUES ('"+id+"', '"+usuario+"', '"+fecha+"', '"+tipodoc+"', '"+ruta+"', '"+nombrearchivo+"', '"+observaciones+"', '"+credito+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public DataTable reporteabogados3(string abogado)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.pj_nombre AS Nombre, A.pj_cif, A.pj_numcredito AS Credito, A.pj_fechaasignacion, B.pj_nombreabogado, C.pj_numincidente AS Incidente FROM pj_certificacionjuidico AS A INNER JOIN pj_abogado AS B ON B.idpj_abogado = A.idpj_abogado INNER JOIN  pj_etapa_credito AS C ON C.idpj_credito = A.pj_numcredito WHERE A.idpj_abogado = '" + abogado + "' AND C.idpj_etapa = 3 AND C.pj_status IN('Enviado','Reingreso')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public string tipodocumentoReporte(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=19";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string motivopago(string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_nombremotivo FROM pj_motivopago WHERE idpj_motivopago= '" + id + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void modificarfacturaabogado(string id, string numfactura, string numserie, string descripcion, string importetotal, string fechaemision, string importecaso, string motivopago, string nombremotivo, string nombrecheque)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                sqlCon.Open();
                string query = "UPDATE pj_facturacionabogado SET pj_numfactura = '"+ numfactura + "', pj_numserie = '"+ numserie + "', pj_descripcion = '"+descripcion+ "', pj_importetotal = '"+ importetotal + "', pj_fechaemision = '"+ fechaemision + "', pj_importecaso = '"+ importecaso + "', pj_motivopago = '"+ motivopago + "', pj_nombremotivo = '"+ nombremotivo + "', pj_nombrecheque = '"+ nombrecheque + "' WHERE idpj_facturacionabogado = '" + id + "'";
                MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                MySqlDataReader reader = myCommand.ExecuteReader();
            }
        }

        public void insertarrequerimientopago(string id, string numcredito, string usuario, string observaciones, string concepto, string nombrecuenta, string numcuenta, string centrocosto, string observacionescredito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_requerimientopago VALUES ('"+id+"', '"+numcredito+"', '"+usuario+"', '"+observaciones+ "','" + concepto + "', '"+nombrecuenta+"', '"+numcuenta+"', '"+centrocosto+"', '" + observacionescredito+"',  '"+etapa+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipodocumentoCheque(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=20";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoCheque2(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=51";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoCheque3(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=60";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoCheque4(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=53";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void insertarsolicitudcheque(string id, string numcredito, string usuario, string numcheque, string fechaemision, string banco, string observaciones, string monto, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_solicitudcheque VALUES('" + id+"', '"+numcredito+"', '"+usuario+"', '"+numcheque+"', '"+fechaemision+"', '"+banco+"', '"+observaciones+"', '"+monto+"', '"+etapa+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string[] etapavoucher(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT idpj_correlativo_etapa FROM pj_etapa_credito WHERE idpj_credito = '" + credito + "' AND idpj_etapa = 6";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }
        public string[] etapavoucher2(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT idpj_correlativo_etapa FROM pj_etapa_credito WHERE idpj_credito = '" + credito + "' AND idpj_etapa = 12";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] etapavoucher3(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT idpj_correlativo_etapa FROM pj_etapa_credito WHERE idpj_credito = '" + credito + "' AND idpj_etapa = 17";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] etapavoucher4(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT idpj_correlativo_etapa FROM pj_etapa_credito WHERE idpj_credito = '" + credito + "' AND idpj_etapa = 28";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] etapavoucher5(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT idpj_correlativo_etapa FROM pj_etapa_credito WHERE idpj_credito = '" + credito + "' AND idpj_etapa = 22";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoVoucher(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=21";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoVoucher8(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=75";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoCheque8(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=74";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void cambiarestadoVoucher(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Cargar Voucher' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipoProceso(string proceso)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_nombreproceso FROM pj_tipoproceso WHERE idpj_tipoproceso= '" + proceso + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] traerComentarios(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT pj_comentario FROM pj_bitacora WHERE pj_estado = 'Enviado' AND pj_numcredito = '" + credito + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public DataTable reporteabogadosNombre(string abogado)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.pj_nombre, A.pj_cif, A.pj_numcredito, A.pj_fechaasignacion, B.pj_nombreabogado FROM pj_certificacionjuidico AS A INNER JOIN pj_abogado AS B ON B.idpj_abogado = A.idpj_abogado INNER JOIN  pj_etapa_credito AS C ON C.idpj_credito = A.pj_numcredito WHERE A.idpj_abogado = '" + abogado + "' AND C.idpj_etapa = 3 AND C.pj_status IN('Enviado','Reingreso')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable reporteabogados3Todo(string abogado, string fecha)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.pj_nombre AS Nombre, A.pj_cif, A.pj_numcredito AS Credito, A.pj_fechaasignacion, B.pj_nombreabogado, C.pj_numincidente AS Incidente FROM pj_certificacionjuidico AS A INNER JOIN pj_abogado AS B ON B.idpj_abogado = A.idpj_abogado INNER JOIN  pj_etapa_credito AS C ON C.idpj_credito = A.pj_numcredito WHERE A.idpj_abogado = '" + abogado + "' AND C.idpj_etapa = 3 AND C.pj_status IN('Enviado','Reingreso') AND C.pj_fecha = '" + fecha + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable reporteabogadosFecha(string fecha)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.pj_nombre, A.pj_cif, A.pj_numcredito, A.pj_fechaasignacion, B.pj_nombreabogado FROM pj_certificacionjuidico AS A INNER JOIN pj_abogado AS B ON B.idpj_abogado = A.idpj_abogado INNER JOIN  pj_etapa_credito AS C ON C.idpj_credito = A.pj_numcredito WHERE C.idpj_etapa = 3 AND C.pj_status IN('Enviado','Reingreso') AND C.pj_fecha = '" + fecha + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable reporteabogados3Fecha(string fecha)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT A.pj_nombre AS Nombre, A.pj_cif, A.pj_numcredito AS Credito, A.pj_fechaasignacion, B.pj_nombreabogado, C.pj_numincidente AS Incidente FROM pj_certificacionjuidico AS A INNER JOIN pj_abogado AS B ON B.idpj_abogado = A.idpj_abogado INNER JOIN  pj_etapa_credito AS C ON C.idpj_credito = A.pj_numcredito WHERE C.idpj_etapa = 3 AND C.pj_status IN('Enviado','Reingreso') AND C.pj_fecha = '" + fecha + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable actualizarcreditosreporte()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_credito AS Credito, pj_nombrecliente AS Nombre, pj_status, pj_numincidente AS Incidente, pj_fecha AS Fecha FROM pj_etapa_credito WHERE idpj_etapa = 4 AND pj_status = 'Pendiente' ";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public void actualizaretapareporte(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Enviado' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "' AND pj_status = 'Pendiente'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public DataSet consultarComentarios(string credito)
        {
            DataSet ds1 = new DataSet();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    //"SELECT * FROM " + tabla + " where" + campo + "='" + dato + "';"
                    sqlCon.Open();
                    //MySqlCommand command = new MySqlCommand("SELECT pj_comentario AS Comentario FROM pj_bitacora WHERE pj_estado IN('Enviado', 'Devuelto') AND pj_numcredito = '" + credito + "'", sqlCon);
                    MySqlCommand command = new MySqlCommand("SELECT pj_comentario AS Comentario FROM pj_bitacora WHERE pj_estado != 'Recibido' AND pj_numcredito = '" + credito + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(ds1);

                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return ds1;

            }



        }

        public string numproceso(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT pj_numproceso FROM pj_presentaciondemanda WHERE pj_numcredito = '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void cambiarestadoFactura(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_facturacionabogado SET pj_estado = 'Pendiente' WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoFactura2(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_facturacionabogado SET pj_estado = 'Pendiente2' WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoFactura3(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_facturacionabogado SET pj_estado = 'Pendiente3' WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoFactura5(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_facturacionabogado SET pj_estado = 'Pendiente5' WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoFactura6(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_facturacionabogado SET pj_estado = 'Pendiente6' WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoFactura8(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_facturacionabogado SET pj_estado = 'Pendiente8' WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string numserie(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT pj_numserie FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string pendientesolicitud(string serie)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT pj_numserie FROM pj_facturacionabogado WHERE pj_estado = 'Iniciado' AND pj_numserie = '" + serie+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public DataTable cambioestadofactura(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, C.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_presentaciondemanda AS C ON C.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente' AND D.idpj_etapa = 5";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public void cambiarestadocredito(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Espera' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadorechazado(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Rechazado' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public DataTable solicitudcheque2(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_numincidente AS Incidente FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente' AND D.idpj_etapa = 5 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudcheque2Etapa2(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_numincidente AS Incidente FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente2' AND D.idpj_etapa = 11 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudcheque2Etapa3(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_numincidente AS Incidente FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente3' AND D.idpj_etapa = 16 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudcheque2Etapa4(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_numincidente AS Incidente FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente5' AND D.idpj_etapa = 27 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudcheque2Etapa6(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_numincidente AS Incidente FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente6' AND D.idpj_etapa = 34 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable solicitudcheque2Etapa8(string serie)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT A.pj_cif AS CIF, A.pj_nombreasociado AS Nombre, A.pj_numcredito AS Credito, B.pj_numproceso AS Juicio, CONCAT('Juzgado', B.pj_numjuzgado, ' ' , B.pj_nombrejuzgado) AS Juzgado, CONCAT('SERIE ', A.pj_numserie, ' No. ', A.pj_numfactura) AS Factura, CONCAT('Q ', A.pj_importecaso) AS Importe, B.pj_numincidente AS Incidente FROM pj_facturacionabogado AS A INNER JOIN pj_presentaciondemanda AS B ON B.pj_numcredito = A.pj_numcredito INNER JOIN pj_etapa_credito AS D ON D.idpj_credito = A.pj_numcredito WHERE A.pj_numserie = '" + serie + "' AND A.pj_estado = 'Pendiente8' AND D.idpj_etapa = 40 AND D.pj_status = 'Espera'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public void estadodevuelto2(string credito, string area, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Devuelto', idpj_etapa = '3', gen_area = '" + area + "' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarvehiculo(string id, string nit, string placa, string modelo, string marca, string credito, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_vehiculo VALUES ('"+id+"', '"+nit+"', '"+placa+"', '"+modelo+"', '"+marca+"', '"+credito+"', '"+usuario+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarbieninmueble(string id, string finca, string folio, string libro, string credito, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_bienesinmuebles VALUES ('"+id+"', '"+finca+"', '"+folio+"', '"+libro+"', '"+credito+"', '"+usuario+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string[] datosvehiculo(string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_vehiculo WHERE idpj_vehiculo = '" + id + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosbienes(string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_bienesinmuebles WHERE idpj_bienesinmuebles = '" + id + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public void actualizarvehiculo(string id, string nit, string placa, string modelo, string marca)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_vehiculo SET pj_nit = '"+nit+ "', pj_placa = '"+placa+ "', pj_modelo = '" + modelo+ "', pj_marca = '"+marca+ "' WHERE idpj_vehiculo = '"+id+"'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void actualizarbien(string id, string finca, string folio, string libro)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_bienesinmuebles SET pj_finca = '"+finca+ "', pj_folio = '"+folio+ "', pj_libro = '"+libro+ "' WHERE idpj_bienesinmuebles = '"+id+"'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarsonefectivas(string id, string banco, string montob, string cooperativa, string montoc, string trabajo, string fechamigracion, string credito, string usuario, string fechaactual, string fechatrabajo)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_sonefectivas VALUES ('"+id+"', '"+banco+"', '"+montob+"', '"+cooperativa+"', '"+montoc+"', '"+trabajo+"', '"+fechamigracion+"', '"+credito+"', '"+usuario+"', '"+fechaactual+"', '"+fechatrabajo+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }
        
        public void insertarvoluntaria(string id,string voluntario, string fechapresentacion, string monto, string fecharesolucion, string fechanotificacion, string observaciones, string credito, string usuario, string fechaactual)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_voluntaria VALUES ('"+id+"', '"+voluntario+"' ,'"+fechapresentacion+"', '"+monto+"', '"+fecharesolucion+"', '"+fechanotificacion+"', '"+observaciones+"', '"+credito+"', '"+usuario+"', '"+fechaactual+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertargestionmedidas(string id, string medida, string gestion, string credito, string idresultados)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_gestionmedida VALUES ('"+id+"', '"+medida+"', '"+gestion+"', '"+credito+"', '"+idresultados+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarhayresultados(string id, string trabajo, string fechapresentacion, string fechasentencia, string fechaapremio, string credito, string usuario, string fecha, string numfactura, string numserie, string descripcion, string importetotal, string fechaemision, string importecaso, string motivopago, string nombremotivo, string fechajuzgado)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_hayresultados VALUES ('"+id+"', '"+trabajo+"', '"+fechapresentacion+"', '"+fechasentencia+"', '"+fechaapremio+"', '"+credito+"', '"+usuario+"', '"+fecha+"', '"+numfactura+"', '"+numserie+"', '"+descripcion+"', '"+importetotal+"', '"+fechaemision+"', '"+importecaso+"', '"+motivopago+"', '"+nombremotivo+"', '"+fechajuzgado+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoinvestigacion(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Nueva Investigacion' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoinvestigacion3(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Nueva Investigacion' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "' AND pj_status = 'Investigacion (Cartera Depurada)'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoinvestigacion2(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Investigacion' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestadoresolucion(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Diligenciamiento', idpj_etapa = '4'  WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string[] medidasautorizadas(string credito, string tipomedida)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT idpj_medidaore FROM pj_asignacionmedidas WHERE pj_tipomedida = '"+tipomedida+ "' AND pj_numcredito = '"+credito+"'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public void cambiarestado2(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Recibido', idpj_etapa = '4' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarcontador(string id, string numero, string fecha, string usuario, string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_contadorinvestigacion VALUES ('"+id+"', '"+numero+"', '"+fecha+"', '"+usuario+"', '"+numcredito+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string siguientenumero(string tabla, string campo, string numcredito)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + " WHERE pj_credito = '"+numcredito+"';"; //SELECT MAX(idFuncion) FROM `funciones`     
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                    //Console.WriteLine("El resultado es: " + camporesultante);
                    if (String.IsNullOrEmpty(camporesultante))
                        camporesultante = "1";
                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }
        }

        public DataSet consultarcontador(string credito)
        {
            DataSet ds1 = new DataSet();
            string camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                
                try
                {
                    //"SELECT * FROM " + tabla + " where" + campo + "='" + dato + "';"
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT pj_numveces AS Numero, pj_fecha AS Fecha FROM pj_contadorinvestigacion WHERE pj_credito = '" + credito + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(ds1);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return ds1;

            }



        }

        public void cambiarestadotransaccion(string estado,string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = '"+estado+"' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipodocumentoMemorialTransaccion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=23";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoResolucionTransaccion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=24";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoFacturacionMemorial(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=31";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void cambiarestadovoluntaria(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Enviado' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipodocumentoEntregaFondos(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=29";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoReciboCaja(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=30";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void insertaraplicacionpago(string id, string numcheque, string fechaemision, string numrecibo, string monto, string banco, string usuario, string fecha, string numcredito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_aplicacionpago VALUES('"+id+"', '"+numcheque+"', '"+fechaemision+"', '"+numrecibo+"',  '"+monto+"', '"+banco+"', '"+usuario+"', '"+fecha+"', '"+numcredito+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarnonotificacion(string id, string fechamemorial, string notario, string colegiado, string fecharesolucion, string fechanotificacion, string usuario, string numcredito, string fecha, string notificacion)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_nonotificacion VALUES('"+id+"', '"+fechamemorial+"', '"+notario+"', '"+colegiado+"', '"+fecharesolucion+"', '"+fechanotificacion+"', '"+usuario+"', '"+numcredito+"', '"+fecha+"', '"+notificacion+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertaractitudpositiva(string id, string fechasentencia, string notificacionsentencia, string lugar, string observaciones, string numcredito, string usuario, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_actitudpositiva VALUES('" + id + "', '"+fechasentencia+"', '"+notificacionsentencia+"', '"+lugar+"', '"+observaciones+"', '"+numcredito+"', '"+usuario+"', '"+fecha+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertaractitudnegativa(string id, string interexcepciones, string fechaexcepcion, string fechaapertura, string observaciones, string fechavista, string fechasentencia, string fechanotificacion, string lugar, string observacionesgen, string numcredito, string usuario, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_actitudnegativa VALUES('" + id + "','"+interexcepciones+"', '"+fechaexcepcion+"' ,'"+fechaapertura+"', '"+observaciones+"', '"+fechavista+"', '"+fechasentencia+"', '"+fechanotificacion+"', '"+lugar+"', '"+observacionesgen+"', '"+numcredito+"', '"+usuario+"', '"+fecha+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarsinotificacion(string id, string fechaintento1, string fechaintento2, string fechaintento3, string fechanotificacion, string actituddemandado, string credito, string usuario, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_sinotificacion VALUES('" + id + "', '"+fechaintento1+"', '"+fechaintento2+"', '"+fechaintento3+"','"+fechanotificacion+"', '"+actituddemandado+"', '"+credito+"', '" + usuario + "', '" + fecha + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarsinotificacion2(string id, string fechanotificacion, string fechamemorial, string numcredito, string fecha, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_segundanotificacioneva VALUES('" + id + "', '" + fechanotificacion + "', '" + fechamemorial + "', '" + numcredito + "', '" + fecha + "', '" + usuario + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarexcepciones(string id, string tipoexcepciones, string descripcion, string observaciones, string idactitudnegativa, string numcredito, string fecha, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_excepciones VALUES('" + id + "', '" + tipoexcepciones + "', '" + descripcion + "', '"+observaciones+"', '"+idactitudnegativa+"', '" + numcredito + "', '" + fecha + "', '" + usuario + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertacreditosgeneral(string numincidente, string numcredito, string tipocredito, string nombre, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_creditosgeneral VALUES('"+numincidente+"', '"+numcredito+"', '"+tipocredito+"', '"+nombre+"', '"+fecha+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string obtenertipoproceso(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_tipoproceso FROM pj_certificacionjuidico WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void insertasolicitudfacturacion(string id, string honorarios, string numcredito, string usuario, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_solicitudfacturacion VALUES('"+id+"', '"+honorarios+"', '"+numcredito+"', '"+usuario+"', '"+fecha+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarnonotificacioneva(string id, string fechaintento1, string fechaintento2, string fechaintento3, string fechamemorial, string notariopropuesto, string colegiado, string fecharesolucion, string fechanotificacion, string notificacion, string numcredito, string usuario, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_nonotificacioneva VALUES('" + id + "', '"+fechaintento1+"', '"+fechaintento2+"', '"+fechaintento3+"', '"+fechamemorial+"', '"+notariopropuesto+"', '"+colegiado+"', '"+fecharesolucion+"', '"+fechanotificacion+"', '"+notificacion+"', '"+numcredito+"', '"+usuario+"', '"+fecha+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarsinotificacioneva(string id, string fechasolicitud, string monto, string descripcion, string fechapublicacion1, string fechapublicacion2, string fechapublicacion3, string numcredito, string usuario, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_sinotificacioneva VALUES('" + id + "', '" + fechasolicitud + "', '" + monto + "', '"+descripcion+"' , '"+fechapublicacion1+"', '"+fechapublicacion2+"', '"+fechapublicacion3+"','" + numcredito + "', '" + usuario + "', '" + fecha + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertaraudiencia(string id, string fechaactanotarial, string fechamemorialacta, string fecharesolucionacta, string fecharemate, string observacionesremate, string adjudicado, string monto, string fechamemorialliqui, string fecharesolucionliqui, string fechanotificacionliqui, string fechamemorialnotario, string abogado, string numcolegiado, string fecharesolucionnotario, string fechanotificacionnotario, string numescritura, string fechaescritura, string honorarioregistro, string honorarioimpuesto, string numcredito, string usuario, string fecha)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_audenciaremate VALUES('" + id + "', '"+fechaactanotarial+"', '"+fechamemorialacta+"', '"+fecharesolucionacta+"', '" + fecharemate + "', '"+observacionesremate+"', '" + adjudicado + "', '" + monto + "', '"+fechamemorialliqui+"', '"+fecharesolucionliqui+"', '"+fechanotificacionliqui+"', '"+fechamemorialnotario+"', '"+abogado+"', '"+numcolegiado+"', '"+fecharesolucionnotario+"', '"+fechanotificacionnotario+"', '"+numescritura+"', '"+fechaescritura+"', '"+honorarioregistro+"', '"+honorarioimpuesto+"','" + numcredito + "', '" + usuario + "', '" + fecha + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipodocumentoEdictos(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=40";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoPagoEdictos(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=41";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoactanotarial(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=49";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentomemorialnotario(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=38";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoresolucionnotarionoti(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=39";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentomemorialnotarial(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=50";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentomemorialliquidacion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=42";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoresolucionliquidacion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=43";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentonotariocartulante(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=44";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentoresolucionnotario(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=45";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentotestimonio(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=46";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void insertarsolicitudchequenoti(string id, string monto, string nombrecheque, string numcredito, string fecha, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_solicitudnotificacion VALUES('" + id + "', '" + monto + "', '" + nombrecheque + "' , '" + numcredito + "', '" + fecha + "', '" + usuario + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertarsolicitudchequehonorario(string id, string monto, string nombrecheque, string numcredito, string fecha, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_solicitudhonorario VALUES('" + id + "', '" + monto + "', '" + nombrecheque + "' , '" + numcredito + "', '" + fecha + "', '" + usuario + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void insertardesistimiento(string id, string fechapresentacion, string fecharesolucion, string numcredito, string fecha, string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_desistimiento VALUES('" + id + "', '" + fechapresentacion + "' , '"+fecharesolucion+"', '" + numcredito + "', '" + fecha + "', '" + usuario + "')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string tipodocumentodesistimiento(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=58";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentorecibo(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=57";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string tipodocumentointegracion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_documento FROM pj_documento WHERE idpj_credito= '" + credito + "' AND idpj_tipodocumento=56";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] obtenermedidaspre(string credito, string tipomedida)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT distinct idpj_medidaore, pj_nombreotro FROM pj_asignacionmedidas WHERE pj_tipomedida = '" + tipomedida + "' AND pj_numcredito = '" + credito + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] obtenercertificacionjuridico(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_certificacionjuidico WHERE pj_numcredito = '" + credito + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string actualizarcertificacionjuridico(string id, string abogado,string tipoproceso, string nombreproceso,string observaciones)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_certificacionjuidico SET idpj_abogado = '"+abogado+ "', idpj_tipoproceso = '"+tipoproceso+ "', pj_tipoprocesonombre = '"+nombreproceso+ "', pj_observaciones = '"+observaciones+ "' WHERE idpj_certificacionjuidico = '"+id+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string actualizarmedidaspre(string credito, string medida)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_asignacionmedidas SET ";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] obtenerusuarios(string usuario)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_controlingreso WHERE idpj_usuario = '" + usuario + "' AND pj_status = 'Activo'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public void asignaraplicacion(string id, string usuario, string opcion, string estado)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_asignacionmenu VALUES('"+id+"', '"+usuario+"', '"+opcion+"', '"+estado+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void actualizarasignacion(string usuario, string opcion, string estado)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_asignacionmenu SET pj_estado = '"+estado+ "' WHERE idpj_usuario = '"+usuario+ "' AND idpj_opcion = '"+opcion+"'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void agregarcontrolingreso(string id, string usuario, string area, string rol, string estado, string puesto)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "INSERT INTO pj_controlingreso VALUES('" + id + "', '" + usuario + "', '" + area + "', '"+rol+"', '" + estado + "', '"+puesto+"')";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void actualizarcontrolingreso(string usuario, string area, string rol, string estado, string puesto)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_controlingreso SET idpj_area = '"+area+ "', idpj_rol = '"+rol+ "', pj_status = '"+estado+ "', pj_puesto = '"+puesto+ "' WHERE idpj_usuario = '"+usuario+ "' AND pj_status = 'Activo'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public DataSet consultaropciones(string idusuario)
        {
            DataSet ds1 = new DataSet();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    //"SELECT * FROM " + tabla + " where" + campo + "='" + dato + "';"
                    sqlCon.Open();
                    //MySqlCommand command = new MySqlCommand("SELECT pj_comentario AS Comentario FROM pj_bitacora WHERE pj_estado IN('Enviado', 'Devuelto') AND pj_numcredito = '" + credito + "'", sqlCon);
                    string query = "SELECT C.pj_nombreopcion AS Nombre, C.pj_direcionopcion AS Ruta FROM pj_asignacionmenu AS A INNER JOIN gen_usuario AS B ON B.codgenusuario = A.idpj_usuario INNER JOIN pj_menuopciones AS C ON C.idpj_menuopciones = A.idpj_opcion WHERE idpj_usuario = '" + idusuario + "' AND A.pj_estado = 'Activo' ORDER BY C.pj_orden ASC";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(ds1);

                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return ds1;

            }



        }

        public void actualizarrequerimientopago(string id, string numcredito, string usuario, string observaciones, string concepto, string nombrecuenta, string numcuenta, string centrocosto, string observacionescredito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_requerimientopago SET pj_observaciones = '"+observaciones+ "', pj_concepto = '"+concepto+ "', pj_nombrecuenta = '"+nombrecuenta+ "', pj_numcuenta = '"+numcuenta+ "', pj_centrocosto = '"+centrocosto+ "', pj_observacionescredito = '"+observacionescredito+"' WHERE ";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string ultimabitacora(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT MAX(idpj_bitacora) FROM pj_bitacora WHERE pj_numcredito = '"+credito+"'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] obtenerdatosbitacora(string credito, string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[15];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT A.pj_numcredito AS Credito, A.pj_estado AS Estado, C.gen_areanombre AS ParaNombre, DATEDIFF(now(), A.pj_fecha) AS DiasFecha FROM pj_bitacora AS A INNER JOIN pj_area AS C ON C.codgenarea = A.pj_paraArea WHERE A.pj_numcredito = '"+credito+"' AND A.idpj_bitacora = '"+id+"'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public DataSet consultarGastos(string credito)
        {
            DataSet ds1 = new DataSet();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    //"SELECT * FROM " + tabla + " where" + campo + "='" + dato + "';"
                    sqlCon.Open();
                    //MySqlCommand command = new MySqlCommand("SELECT pj_comentario AS Comentario FROM pj_bitacora WHERE pj_estado IN('Enviado', 'Devuelto') AND pj_numcredito = '" + credito + "'", sqlCon);
                    MySqlCommand command = new MySqlCommand("SELECT pj_importecaso AS Monto, pj_nombremotivo AS Nombre FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(ds1);

                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return ds1;

            }



        }

        public string obtenerdesistimiento(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_desistimiento FROM pj_desistimiento WHERE pj_numcredito= '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] obtenerdatoshonorarios(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT pj_total, pj_nombre FROM pj_solicitudhonorario WHERE pj_numcredito = '" + credito + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] obtenerdatosnotificacion(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT pj_monto, pj_nombrecheque FROM pj_solicitudnotificacion WHERE pj_numcredito = '" + credito + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string obteneridultimaetapa(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT MAX(idpj_etapa) FROM pj_etapa_credito WHERE idpj_credito = '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string obtenerultimaetapa(string credito, string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT B.pj_etapanombre FROM pj_etapa_credito AS A INNER JOIN pj_etapacatalogo AS B ON B.idpj_etapacatalogo = A.idpj_etapa WHERE A.idpj_credito = '" + credito + "' AND A.idpj_correlativo_etapa = '" + id + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string cantidadcreditosresolucion()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT COUNT(idpj_correlativo_etapa) FROM pj_etapa_credito WHERE idpj_etapa IN (5) AND pj_status IN ('Facturacion')";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public string obtenercredito(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT idpj_numincidente FROM pj_creditosgeneral WHERE pj_numcredito = '" + credito + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public void cambiarestadocredito5(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Espera' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "' AND pj_status = 'Enviado'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public void cambiarestado5(string credito, string etapa)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_etapa_credito SET pj_status = 'Recibido' WHERE idpj_credito= '" + credito + "' AND idpj_etapa = '" + etapa + "', pj_status = 'Espera'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public string obtenerultimaetapa2( string id)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string camporesultante = "";
                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_etapanombre FROM pj_etapacatalogo WHERE idpj_etapacatalogo = '" + id + "'";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return camporesultante;// devuelve un arrgeglo con los campos 
            }
        }

        public DataTable datosSolicitud(string numcredito)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    string query = "SELECT pj_numproceso AS Juicio, CONCAT(pj_numjuzgado, ' ' , pj_nombrejuzgado) AS Juzgado, pj_oficial AS Oficial FROM pj_presentaciondemanda WHERE pj_numcredito = '"+numcredito+"';";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public string[] obtenerdatosproceso(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT pj_numproceso, pj_numjuzgado, pj_nombrejuzgado, pj_oficial FROM pj_presentaciondemanda WHERE pj_numcredito = '" + credito + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public string[] datosfactura88(string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[30];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM pj_facturacionabogado WHERE pj_numcredito = '" + credito + "' AND pj_estado = 'Iniciado'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }

        public void actualizarinfo(string oficial, string notificador, string numjuzgado, string nombrejuzgado, string credito)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "UPDATE pj_presentaciondemanda SET pj_oficial = '" + oficial + "', idpj_notificador = '" + notificador + "', pj_numjuzgado = '" + numjuzgado + "' pj_nombrejuzgado = '" + nombrejuzgado + "'  WHERE idpj_credito= '" + credito + "'";
                    MySqlCommand myCommand = new MySqlCommand(query, sqlCon);
                    MySqlDataReader reader = myCommand.ExecuteReader();
                }
                catch
                {

                }
            }
        }

        public DataTable datosReporteGeneral()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT DISTINCT(CGENERAL.idpj_numincidente) AS INCIDENTE," +
             "CGENERAL.pj_numcredito AS CREDITO," +
            "CGENERAL.pj_nombre AS NOMBRE," +
           " CGENERAL.pj_fecha AS 'FECHA_CREACION'," +
            "TIPO.pj_nombretipo AS 'TIPO_CREDITO'," +
            "TCREDITO.pj_gastoscobranza AS 'GASTOS_COBRANZA'," +
           " TCREDITO.pj_seguro AS SEGURO," +
            "TCREDITO.pj_otrosgastos AS 'OTROS_GASTOS'," +
            "TCREDITO.pj_total AS TOTAL," +
           " TCREDITO.pj_comentario AS COMENTARIO," +
           " TCREDITO.pj_fechaestado AS 'FECHA_ESTADO_CUENTA'," +
            "TCREDITO.pj_incendio AS INCENDIO," +
            "TCREDITO.pj_interesesvencidos AS INTERESES," +
            "TCREDITO.pj_mora AS MORA," +
            "TTARJETA.pj_numtarjeta AS 'NO_TARJETA'," +
            "TTARJETA.pj_numcuenta AS CUENTA," +
           "TTARJETA.pj_cif AS CIF2," +
            "TTARJETA.pj_primernombre AS 'PRIMER_NOMBRE'," +
            "TTARJETA.pj_segundonombre AS 'SEGUNDO_NOMBRE'," +
            "TTARJETA.pj_otronombre AS 'OTRO_NOMBRE'," +
            "TTARJETA.pj_apellidocasada AS 'APELLIDO_CASADA'," +
            "TTARJETA.pj_primerapellido AS 'PRIMER_APELLIDO'," +
            "TTARJETA.pj_segundoapellido AS 'SEGUNDO_APELLIDO'," +
           "TTARJETA.pj_limite AS LIMITE," +
            "TTARJETA.pj_saldo AS SALDO," +
           " TTARJETA.pj_gastoscobranza AS 'GASTOS_COBRANZA2'," +
            "TTARJETA.pj_seguro AS SEGURO2," +
           " TTARJETA.pj_otrosgastos AS 'OTROS_GASTOS2'," +
            "TTARJETA.pj_comentariogastos AS COMENTARIO2," +
           " TTARJETA.pj_total AS TOTAL2," +
            "TTARJETA.pj_fechaestado AS 'FECHA_ESTADO_CUENTA2'," +
            "TTARJETA.pj_incendio AS INCENDIO2," +
            "TTARJETA.pj_interesesvencidos AS INTERESES2," +
            "TTARJETA.pj_mora AS MORA2," +
           " CCONTABLE.pj_numregistrado AS 'NO_REGISTRADO'," +
            "CCONTABLE.pj_contador AS CONTADOR," +
            "CCONTABLE.pj_observaciones AS OBSERVACIONES2," +
            "CJURIDICO.pj_tipoprocesonombre AS 'TIPO_PROCESO'," +
            "CJURIDICO.pj_fechaasignacion AS 'FECHA_ASIGNACION_ABOGADO'," +
            "ABOGADO.pj_nombreabogado AS 'NOMBRE_ABOGADO'," +
            "CJURIDICO.pj_observaciones AS OBSERVACIONES3," +
            "DEMANDA.pj_numproceso AS 'NO_PROCESO'," +
            "DEMANDA.pj_fechapresentacion AS 'FECHA_PRESENTACION_DEMANDA'," +
           " DEMANDA.pj_numjuzgado AS 'NO_JUZGADO'," +
            "DEMANDA.pj_nombrejuzgado AS 'NOMBRE_JUZGADO'," +
            "OFICIAL.pj_nombre AS OFICIAL," +
           " NOTIFICADOR.pj_nombrenotificador AS NOTIFICADOR," +
           " DEPARTAMENTO.pj_departamentonombre AS DEPARTAMENTO," +
           " MUNICIPIO.pj_municipionombre AS MUNICIPIO," +
           " RESOLUCION.pj_estadodemanda AS 'ESTADO_DEMANDA'," +
            "RESOLUCION.pj_motivorechazo AS 'MOTIVO_RECHAZO'," +
            "RESOLUCION.pj_fechanotificacion AS 'FECHA_NOTIFICACION'," +
           " BANCO.pj_nombrebanco AS BANCO," +
           "EFECTIVAS.pj_monto AS MONTO," +
            "COOPERATIVA.pj_nombrecoope AS COOPERATIVA," +
            "EFECTIVAS.pj_montoc AS MONTO2," +
           " EFECTIVAS.pj_lugartrabajo AS TRABAJO," +
            "EFECTIVAS.pj_fechamigracion AS 'FECHA_OFICIO_MIGRACION'," +
           " EFECTIVAS.pj_fecha AS FECHA," +
            "EFECTIVAS.pj_fechatrabajo AS 'FECHA_OFICIO_TRABAJO'," +
           " VOLUNTARIA.pj_voluntaria AS VOLUNTARIA," +
           " VOLUNTARIA.pj_fechapresentacion AS 'FECHA_PRESENTACION'," +
           " VOLUNTARIA.pj_monto AS MONTO3," +
            "VOLUNTARIA.pj_fecharesolucion AS 'FECHA_RESOLUCION'," +
            "VOLUNTARIA.pj_fechanotificacion AS 'FECHA_NOTIFICACION2'," +
            "VOLUNTARIA.pj_observaciones AS OBSERVACIONES4," +
           " VOLUNTARIA.pj_fecha AS FECHA3," +
            "RESULTADOS.pj_empresatrabajo AS TRABAJO2," +
           " RESULTADOS.pj_fechapresentacion AS 'FECHA_PRESENTACION_MEMORIAL'," +
           " RESULTADOS.pj_fechasentencia AS 'FECHA_SOLICITUD_SENTENCIA'," +
           " RESULTADOS.pj_fechaapremio AS 'FECHA_DEMANDA_APREMIO'," +
           " RESULTADOS.pj_fecha AS FECHA4," +
           " RESULTADOS.pj_numfactura AS 'NO_FACTURA'," +
          "  RESULTADOS.pj_numserie AS 'NO_SERIE'," +
           " RESULTADOS.pj_descripcion AS DESCRIPCION," +
            "RESULTADOS.pj_importetotal AS 'IMPORTE_TOTAL'," +
           " RESULTADOS.pj_fechaemision AS 'FECHA_EMISION_FACTURA'," +
           " RESULTADOS.pj_importecaso AS 'IMPORTE_CASO'," +
           " RESULTADOS.pj_nombremotivo AS 'MOTIVO_DE_PAGO'," +
           " RESULTADOS.pj_fechajuzgado AS 'FECHA_PRESENTACION_JUZGADO'," +
           " SOLICITUDFAC.pj_honorarios AS HONORARIOS," +
           "APLICACIONPA.pj_numcheque AS 'NO_CHEQUE'," +
           " APLICACIONPA.pj_fechaemision AS 'FECHA_EMISION_CHEQUE'," +
           " APLICACIONPA.pj_numrecibo AS 'NO_RECIBO'," +
           " APLICACIONPA.pj_monto AS MONTO4," +
           " BANCO2.pj_nombrebanco AS BANCO2," +
           " APLICACIONPA.pj_fecha AS FECHA5," +
           " SINOTIFICACION.pj_fechanotificacion AS 'FECHA_NOTIFICACION3'," +
            "SINOTIFICACION.pj_actituddemandado AS ACTITUD," +
            "SINOTIFICACION.pj_fecha AS FECHA6," +
            "APOSITIVA.pj_fechasentencia AS 'FECHA_SENTENCIA4'," +
           " APOSITIVA.pj_notificacionsentencia AS 'NOTIFICACION_SENTENCIA'," +
            "APOSITIVA.pj_lugar AS LUGAR," +
           " APOSITIVA.pj_observaciones AS OBSERVACIONES5," +
           " APOSITIVA.pj_fecha AS FECHA7," +
           " ANEGATIVA.pj_interexcepciones AS EXCEPCIONES," +
           " ANEGATIVA.pj_fechaexcepcion AS 'FECHA_RESOLUCION_EXCEPCIONES'," +
           "ANEGATIVA.pj_fechaapertura AS 'FECHA_DE_APERTURA'," +
           " ANEGATIVA.pj_observaciones AS OBSERVACIONES6," +
           " ANEGATIVA.pj_fechavista AS 'FECHA_VISTA'," +
           " ANEGATIVA.pj_fechasentencia AS 'FECHA_SENTENCIA'," +
           " ANEGATIVA.pj_fechanotificacion AS 'FECHA_NOTIFICACION_SENTENCIA'," +
           " ANEGATIVA.pj_lugar AS LUGAR2," +
            "ANEGATIVA.pj_observacionesgen AS OBSERVACIONES7," +
           " ANEGATIVA.pj_fecha AS FECHA8," +
           "VEHICULOS.pj_nit AS NIT," +
           " VEHICULOS.pj_placa AS PLACA," +
           " VEHICULOS.pj_modelo AS MODELO," +
           " VEHICULOS.pj_marca AS MARCA," +
           " BIENES.pj_finca AS FINCA," +
           " BIENES.pj_folio AS FOLIO," +
           " BIENES.pj_libro AS LIBRO," +
           " SINOTIFICACIONEVA.pj_fechasolicitud AS 'FECHA_SOLICITUD_EDICTOS'," +
           " SINOTIFICACIONEVA.pj_monto AS MONTO5," +
           " SINOTIFICACIONEVA.pj_descripcion AS DESCRIPCION2," +
           " SINOTIFICACIONEVA.pj_fechapublicacion1 AS 'FECHA_PUBLICACION1'," +
           " SINOTIFICACIONEVA.pj_fechapublicacion2 AS 'FECHA_PUBLICACION2'," +
           " SINOTIFICACIONEVA.pj_fechapublicacion3 AS 'FECHA_PUBLICACION3'," +
           " SINOTIFICACIONEVA.pj_fecha AS FECHA9," +
           " NONOTIFICACIONEVA.pj_fechaintento1 AS 'FECHA_INTENTO_NOTIFICACION1'," +
           " NONOTIFICACIONEVA.pj_fechaintento2 AS 'FECHA_INTENTO_NOTIFICACION2'," +
           " NONOTIFICACIONEVA.pj_fechaintento3 AS 'FECHA_INTENTO_NOTIFICACION3'," +
            "NONOTIFICACIONEVA.pj_fechamemorial AS 'FECHA_SOLICITUD_NOMBRAMIENTO_NOTARIO'," +
           " NONOTIFICACIONEVA.pj_notariopropuesto AS 'NOTARIO_PROPUESTO'," +
           " NONOTIFICACIONEVA.pj_colegiadopropuesto AS 'COLEGIADO_NOTARIO_PROPUESTO'," +
           " NONOTIFICACIONEVA.pj_fecharesolucion AS 'FECHA_RESOLUCIÓN_NOMBRAMIENTO_NOTARIO'," +
           " NONOTIFICACIONEVA.pj_fechanotificacion AS 'FECHA_NOTIFICACION_RESOLUCION'," +
           " NONOTIFICACIONEVA.pj_notificacion AS 'NOTIFICACION_AL_ASOCIADO'," +
           " NONOTIFICACIONEVA.pj_fecha AS FECHA10," +
           " DESISTIMIENTO.pj_fechapresentacion AS 'FECHA_PRESENTACION_DESISTIMIENTO'," +
           " DESISTIMIENTO.pj_fecharesolucion AS 'FECHA_RESOLUCION_DESISTIMIENTO'," +
           " DESISTIMIENTO.pj_fecha AS FECHA11," +
           " SOLICITUDN.pj_monto AS MONTO6," +
          "  SOLICITUDN.pj_nombrecheque AS 'NOMBRE_CHEQUE'," +
           " SOLICITUDN.pj_fecha AS FECHA12," +
           " SOLICITUDHO.pj_total AS TOTAL4," +
           " SOLICITUDHO.pj_nombre AS 'NOMBRE_CHEQUE2'," +
           " SOLICITUDHO.pj_fecha AS FECHA15," +
           " SEGNOTIFICACIONEVA.pj_fechaactanotificacion AS 'FECHA_ACTA_NOTARIAL_NOTIFICACION'," +
           " SEGNOTIFICACIONEVA.pj_fechamemorialacta AS 'FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACIÓN'," +
           " SEGNOTIFICACIONEVA.pj_fecha AS FECHA13," +
           " REPORTE.pj_fecharecibido AS 'FECHA_ENTREGA_FISICA_EXPEDIENTE'," +
           " REPORTE.pj_observaciones AS OBSERVACIONES8," +
           " AUDIENCIAR.pj_fechaactanotarial AS 'FECHA_ACTA_NOTARIAL_NOTIFICACION2'," +
           " AUDIENCIAR.pj_fechamemorialacta AS 'FECHA_MEMORIAL_ACTA_NOTARIAL_NOTIFICACION2'," +
           " AUDIENCIAR.pj_fecharesolucionacta AS 'FECHA_RESOLUCIÓN_ACTA_NOTARIAL_NOTIFICACION'," +
          "  AUDIENCIAR.pj_fecharemate AS 'FECHA_REMATE'," +
           " AUDIENCIAR.pj_observacionesremate AS 'OBSERVACIONES_REMATE'," +
           " AUDIENCIAR.pj_adjudicado AS ADJUDICADO," +
           " AUDIENCIAR.pj_monto AS MONTO7," +
           " AUDIENCIAR.pj_fechamemorialliqui AS 'FECHA_MEMORIAL_PROYECTO_LIQUIDACION3'," +
           " AUDIENCIAR.pj_fecharesolucionliqui AS 'FECHA_RESOLUCION_PROYECTO_LIQUIDACION'," +
           " AUDIENCIAR.pj_fechanotificacionliqui AS 'FECHA_NOTIFICACION_RESOLUCION_LIQUIDACION'," +
           " AUDIENCIAR.pj_fechamemorialnotario AS 'FECHA_MEMORIAL_PARA_NOMBRAR_NOTARIO_CARTULANTE'," +
           " AUDIENCIAR.pj_abogado AS NOTARIO," +
           " AUDIENCIAR.pj_numcolegiado AS 'COLEGIADO_NOTARIO'," +
           " AUDIENCIAR.pj_fecharesolucionnotario AS 'FECHA_RESOLUCIÓN_PARA_NOMBRAR_NOTARIO_CARTULANTE'," +
           " AUDIENCIAR.pj_fechanotificacionnotario AS 'FECHA_NOTIFICACION_RESOLUCION_NOTARIO'," +
           " AUDIENCIAR.pj_numescritura AS 'NO_ESCRITURA'," +
           " AUDIENCIAR.pj_fechaescritura AS 'FECHA_ESCRITURA'," +
           " AUDIENCIAR.pj_honorarioregistro AS 'HONORARIO_DE_REGISTRO'," +
           " AUDIENCIAR.pj_honorarioimpuesto AS 'HONORARIO_IMPUESTO'," +
           " AUDIENCIAR.pj_fecha AS FECHA14," +
           " '44' AS 'ETAPA_ACTUAL' " +
           " FROM pj_creditosgeneral AS CGENERAL " +
           " INNER JOIN pj_tipo AS TIPO ON TIPO.idpj_tipo = CGENERAL.pj_tipocredito " +
           " LEFT JOIN pj_tipocredito AS TCREDITO ON TCREDITO.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_tipotarjeta AS TTARJETA ON TTARJETA.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_certificacioncontable AS CCONTABLE ON CCONTABLE.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_certificacionjuidico AS CJURIDICO ON CJURIDICO.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_abogado AS ABOGADO ON ABOGADO.idpj_abogado = CJURIDICO.idpj_abogado " +
           " LEFT JOIN pj_presentaciondemanda AS DEMANDA ON DEMANDA.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_oficial AS OFICIAL ON OFICIAL.idpj_oficial = DEMANDA.pj_oficial " +
           " LEFT JOIN pj_notificador AS NOTIFICADOR ON NOTIFICADOR.idpj_notificador = DEMANDA.idpj_notificador " +
           " LEFT JOIN pj_departamento AS DEPARTAMENTO ON DEPARTAMENTO.idpj_departamento = DEMANDA.idpj_departamento " +
            "LEFT JOIN pj_municipio AS MUNICIPIO ON MUNICIPIO.idpj_municipio = DEMANDA.idpj_municipio " +
            "LEFT JOIN pj_resoluciontramite AS RESOLUCION ON RESOLUCION.pj_numcredito = CGENERAL.pj_numcredito " +
            "LEFT JOIN pj_sonefectivas AS EFECTIVAS ON EFECTIVAS.pj_numcredito = CGENERAL.pj_numcredito " +
            "LEFT JOIN pj_bancoemisor AS BANCO ON BANCO.idpj_bancoemisor = EFECTIVAS.idpj_banco " +
            "LEFT JOIN pj_cooperativas AS COOPERATIVA ON COOPERATIVA.idpj_cooperativas = EFECTIVAS.idpj_cooperativa " +
            "LEFT JOIN pj_voluntaria AS VOLUNTARIA ON VOLUNTARIA.pj_numcredito = CGENERAL.pj_numcredito " +
            "LEFT JOIN pj_hayresultados AS RESULTADOS ON RESULTADOS.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_solicitudfacturacion AS SOLICITUDFAC ON SOLICITUDFAC.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_aplicacionpago AS APLICACIONPA ON APLICACIONPA.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_bancoemisor AS BANCO2 ON BANCO2.idpj_bancoemisor = APLICACIONPA.pj_banco " +
           " LEFT JOIN pj_sinotificacion AS SINOTIFICACION ON SINOTIFICACION.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_actitudpositiva AS APOSITIVA ON APOSITIVA.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_actitudnegativa AS ANEGATIVA ON ANEGATIVA.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_vehiculo AS VEHICULOS ON VEHICULOS.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_bienesinmuebles AS BIENES ON BIENES.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_sinotificacioneva AS SINOTIFICACIONEVA ON SINOTIFICACIONEVA.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_nonotificacioneva AS NONOTIFICACIONEVA ON NONOTIFICACIONEVA.pj_numcredito = CGENERAL.pj_numcredito " +
          "  LEFT JOIN pj_desistimiento AS DESISTIMIENTO ON DESISTIMIENTO.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_solicitudnotificacion AS SOLICITUDN ON SOLICITUDN.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_solicitudhonorario AS SOLICITUDHO ON SOLICITUDHO.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_segundanotificacioneva AS SEGNOTIFICACIONEVA ON SEGNOTIFICACIONEVA.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_reporteabogado AS REPORTE ON REPORTE.pj_numcredito = CGENERAL.pj_numcredito " +
           " LEFT JOIN pj_audenciaremate AS AUDIENCIAR ON AUDIENCIAR.pj_numcredito = CGENERAL.pj_numcredito";
                    MySqlCommand command = new MySqlCommand(query, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public string[] obtenermedidas(string credito, string tipo)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[6];
                int i = 0;
                try
                {

                    string consultaGraAsis = "SELECT pj_nombreotro FROM pj_asignacionmedidas WHERE pj_numcredito = '" + credito + "' AND pj_tipomedida = '" + tipo + "'";
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(consultaGraAsis, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        for (int p = 0; p < reader.FieldCount; p++)
                        {
                            Campos[i] = reader.GetString(p);
                            i++;
                        }
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return Campos;// devuelve un arrgeglo con los campos 
            }
        }
    }
}
