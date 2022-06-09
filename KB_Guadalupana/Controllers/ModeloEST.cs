using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace KB_Guadalupana.Controllers
{
    public class ModeloEST
    {

        Conexion conexiongeneral = new Conexion();

        //Clonacion de info o duplicacion

        public string estado(string lote)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT LoteEstado FROM EP_Lote WHERE LoteID = '" + lote + "' ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string ExisteLoteCif(string cif, string lote)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "     = '" + cif + "' AND '" + lote + "'  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string UltimoLote(string cif)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = " SELECT LoteID FROM `EP_Colaborador` WHERE `ColaboradorID` = '" + cif + "' ORDER BY LoteID DESC  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string textomensaje()
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "Select EPParametroDescripcion FROM EP_Parametro WHERE EPParametroNombre = 'Footer';";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string parametro()
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "Select EPParametroDescripcion FROM EP_Parametro WHERE EPParametroNombre = 'DiasIngreso';";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string fechaingreso(string colab, string lote)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "Select ColaboradorFecIngreso FROM EP_Colaborador WHERE ColaboradorID ='" + colab + "'AND LoteID = '" + lote + "' ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string obtenerpuesto(string cif)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = " SELECT codgenpuestos FROM `EP_Colaborador` WHERE `ColaboradorID` = '" + cif + "' ORDER BY LoteID DESC  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string obtenerarea(string cif)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = " SELECT codgenarea FROM `EP_Colaborador` WHERE `ColaboradorID` = '" + cif + "' ORDER BY LoteID DESC  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public DataTable validacion(string sql)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public string finalizado(string cif, string lote)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT ColaboradorEstado FROM EP_Colaborador WHERE `ColaboradorID` = '" + cif + "' AND LoteID = '" + lote + "' ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string[] datetime()
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[950];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT DATE_FORMAT(CURRENT_DATE,  '%Y %m %d'), CURRENT_TIME ;";
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
        //SELECT exc.ex_cifgeneral, exc.ex_controlarea, exc.ex_controlrol FROM ex_controlingreso exc WHERE exc.ex_cifgeneral = "778208"
        public string[] datoslote(string cif, string lote)
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[100];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT * FROM `EP_Colaborador` WHERE  ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ;";
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
        public string[] obtenertodostemp()
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                string[] Campos = new string[500];
                int i = 0;
                try
                {
                    string consultaGraAsis = "SELECT `Nocredito` FROM `ex_temporal1`;";
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
        public void executesql(string sql)
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {

                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();

                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

            }


        }

        public string obtenerultimo(string tabla, string campo)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT MAX(" + campo + ")+1 FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
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

        public string idusuariogeneral(string user)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT cif FROM general_usuarios WHERE usuario = '" + user + "'  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string obtenerciclo(string iduni)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT UniversidadCiclo FROM `Gen_Universidad` WHERE UniversidadID = '" + iduni + "'  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string obtenertamanio(string tipo)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT TipoIdentificacionLongitud FROM Gen_TipoDocumentoId WHERE TipoIdentificacionID = '" + tipo + "'  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string obligar(string tipo)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT TipoPresuncionID FROM `Gen_TipoPresuncion` WHERE TipoPresuncionFinFolLib  = '" + tipo + "'  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string buscarloteandid(string user, string lote)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT ColaboradorID FROM  EP_Colaborador WHERE ColaboradorID = '" + user + "' AND LoteID = '" + lote + "'  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }


        public string cargacombogrid(string campo, string tabla, string campowhere, string parametro)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT " + campo + " FROM " + tabla + " WHERE " + campowhere + " = '" + parametro + "'  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string modalidad(string dato)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT ModalidadEstudioID FROM EP_ColaboradorEstudioOtr WHERE ColaboradorEstudioOtrID = '" + dato + "' ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }

        public string okasig(string cif, string lote)
        {
            String camporesultante = "";
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT ColaboradorID FROM EP_Colaborador WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    camporesultante = reader.GetValue(0).ToString();

                }
                catch (Exception)
                {
                    Console.WriteLine(camporesultante);
                }
                return camporesultante;
            }

        }
        public string[] loteactivo()
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                int i = 0;
                string[] campos = new string[0];
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT *, DATE_FORMAT(LoteFecInicio, '%Y-%m-%d') AS fechain, DATE_FORMAT(LoteFecFin, '%Y-%m-%d') AS fechaf FROM EP_Lote WHERE LoteEstado = 1  ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    campos = new string[reader.FieldCount];
                    while (reader.Read())
                    {

                        for (int p = 0; p < reader.FieldCount; p++)
                        {

                            campos[i] = reader.GetString(p);

                            i++;


                        }


                    }



                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return campos;
            }

        }
        public string[] loteactivoid(string id)
        {

            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                int i = 0;
                string[] campos = new string[0];
                try
                {
                    sqlCon.Open();
                    string sql = "SELECT *, DATE_FORMAT(LoteFecInicio, '%Y-%m-%d') AS fechain, DATE_FORMAT(LoteFecFin, '%Y-%m-%d') AS fechaf FROM EP_Lote WHERE LoteID = '" + id + "' ;";
                    MySqlCommand command = new MySqlCommand(sql, sqlCon);
                    MySqlDataReader reader = command.ExecuteReader();
                    campos = new string[reader.FieldCount];
                    while (reader.Read())
                    {

                        for (int p = 0; p < reader.FieldCount; p++)
                        {

                            campos[i] = reader.GetString(p);

                            i++;


                        }


                    }



                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }
                return campos;
            }

        }
        public DataTable llenardgvfamilia(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `ColaboradorFamiliaID`,`ColaboradorFamiliaNombre`,`ColaboradorFamiliaOcupacion`,`ColaboradorFamiliaComentario`, DATE_FORMAT(ColaboradorFamiliaFecNacimient, '%d-%m-%Y') as ColaboradorFamiliaFecNacimient FROM `EP_ColaboradorFamilia` WHERE LoteID = '" + lt + "' AND `ColaboradorID`= '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvfamiliaf(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `ColaboradorFamiliaID`,`ColaboradorFamiliaNombre`,`ColaboradorFamiliaOcupacion`,`ColaboradorFamiliaComentario`, DATE_FORMAT(ColaboradorFamiliaFecNacimient, '%Y-%m-%d') as ColaboradorFamiliaFecNacimient FROM `EP_ColaboradorFamilia` WHERE LoteID = '" + lt + "' AND `ColaboradorID`= '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable datosgen(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `codgensucursal`, `gen_sucursalnombre`, `codgenarea`, `codgenpuestos`, `ColaboradorFecIngreso`, `ColaboradorFecRegistro`, `ColaboradorPrimerApellido`, `ColaboradorSegundoApellido`, `ColaboradorCasadaApellido`, `ColaboradorPrimerNombre`, `ColaboradorSegundoNombre`, `ColaboradorOtroNombre`, `ColaboradorDirDomicilio`, `ColaboradorZonaDomicilio`, `DivisionGeograficaID`, `SubDivisionGeograficaID`, `ZonaDivisionGeograficaID`, `TipoIdentificacionID`, `ColaboradorNoIdentificacion`, " +
                        "`ColaboradorFecNacimiento`, `ColaboradorNIT`, `ColaboradorNacionalidad`, `ColaboradorEmailPersonal`, `ColaboradorEmailLaboral`, `ColaboradorEstatura`, `ColaboradorPeso`, `ColaboradorReligion`, `EstadoCivilID`, `ColaboradorConyugeNombre`, `ColaboradorConyugeOcupacion`,  DATE_FORMAT(`ColaboradorConyugeFecNacimient`, '%Y-%m-%d') as ColaboradorConyugeFecNacimient , `ColaboradorPEP`, `ColaboradorCPE`, `ColaboradorActivoMenEQCant`,  `ColaboradorActivoMenSalaCant`,  `ColaboradorActivoMenComeCant`,  `ColaboradorActivoMenTVCant`, `ColaboradorActivoMenSonCant`, " +
                        " `ColaboradorActivoMenLavCant`, `ColaboradorActivoMenSecCant`,  `ColaboradorActivoMenEstCant`,  `ColaboradorActivoMenRefCant`,`ColaboradorActivoMenCelCant`,  `ColaboradorActivoMenOtrDesc`, " +
                        "FORMAT(ColaboradorActivosCaja,2) ColaboradorActivosCaja ," +
                        "FORMAT(ColaboradorInversionFenarore,2) ColaboradorInversionFenarore, " +
                        "FORMAT(ColaboradorActivoMenEQVAlor,2) ColaboradorActivoMenEQVAlor, " +
                        "FORMAT(ColaboradorActivoMenSalaValor,2) ColaboradorActivoMenSalaValor," +
                        "FORMAT(ColaboradorActivoMenComeValor,2) ColaboradorActivoMenComeValor, " +
                        "FORMAT(ColaboradorActivoMenTVValor,2) ColaboradorActivoMenTVValor," +
                        " FORMAT(ColaboradorActivoMenSonValor,2) ColaboradorActivoMenSonValor, " +
                        "FORMAT(ColaboradorActivoMenLavValor,2) ColaboradorActivoMenLavValor, " +
                        "FORMAT(ColaboradorActivoMenSecValor,2) ColaboradorActivoMenSecValor, " +
                        "FORMAT(ColaboradorActivoMenEstValor,2) ColaboradorActivoMenEstValor," +
                        " FORMAT(ColaboradorActivoMenRefValor,2) ColaboradorActivoMenRefValor, " +
                        "FORMAT(ColaboradorActivoMenCelValor,2) ColaboradorActivoMenCelValor," +
                        " FORMAT(ColaboradorActivoMenOtrValor,2) ColaboradorActivoMenOtrValor," +
                        " FORMAT(ColaboradorIngresoSueldoBase,2) ColaboradorIngresoSueldoBase," +
                        " FORMAT(ColaboradorIngresoBonifica,2) ColaboradorIngresoBonifica, " +
                        "FORMAT(ColaboradorIngresoComisiones,2) ColaboradorIngresoComisiones, " +
                        "FORMAT(ColaboradorEgresoAlimentacion,2) ColaboradorEgresoAlimentacion," +
                        " FORMAT(ColaboradorEgresoTransporte,2) ColaboradorEgresoTransporte, " +
                        "FORMAT(ColaboradorEgresoEstudio,2) ColaboradorEgresoEstudio" +
                        ", FORMAT(ColaboradorEgresoPrestamo,2) ColaboradorEgresoPrestamo," +
                        " FORMAT(ColaboradorEgresoExtraFin,2) ColaboradorEgresoExtraFin," +
                        " FORMAT(ColaboradorEgresoVestuario,2) ColaboradorEgresoVestuario, " +
                        "FORMAT(ColaboradorEgresoRecreacion,2) ColaboradorEgresoRecreacion," +
                        " FORMAT(ColaboradorEgresoOtros,2) ColaboradorEgresoOtros , " +
                        "DATE_FORMAT(`ColaboradorFecIngreso`, '%Y-%m-%d') as fehcaingreso, " +
                        "DATE_FORMAT(ColaboradorFecNacimiento,'%Y-%m-%d') as fechanac  FROM `EP_Colaborador` WHERE  ColaboradorID = '" + colab + "' AND LoteID = '" + lt + "' ;", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvestudios(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT a.ColaboradorEstudioUniID, a.ColaboradorEstudioUniCarrera, a.ColaboradorEstudioUniUltCiclo, a.ColaboradorEstudiouniAnio, b.UniversidadNombre as UniversidadID,ColaboradorEstudioUniGraduado FROM EP_ColaboradorEstudioUni a INNER JOIN Gen_Universidad b on a.UniversidadID= b.UniversidadID   WHERE LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvcuentas(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorActivoCBID`,  b.TipoCuentaFinDescripcion, c.EntidadFinDescripcion,d.MonedaNombre, `ColaboradorActivoCBActiva`, d.MonedaNombre, `ColaboradorActivoCBNumero`, FORMAT(ColaboradorActivoCBSaldo,2) as ColaboradorActivoCBSaldo, `ColaboradorActivoCBOrigen`  FROM EP_ColaboradorActivosCB a INNER JOIN Gen_TipoCuentaFinanciera b on a.TipoCuentaFinCodigo = b.TipoCuentaFinCodigo INNER JOIN Gen_EntidadFinanciera c on c.EntidadFinCodigo =a.EntidadFinCodigo INNER JOIN Gen_Moneda d on d.MonedaID=a.MonedaID WHERE LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable llenartarjetas(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorPasivoTCID`,  b.EntidadFinDescripcion," +
                        " FORMAT(a.ColaboradorPasivoTCLimiteQ, 2) as ColaboradorPasivoTCLimiteQ, " +
                        "FORMAT(a.ColaboradorPasivoTCLimiteUS, 2) as ColaboradorPasivoTCLimiteUS," +
                        "FORMAT(a.ColaboradorPasivoTCSaldoQ, 2) as ColaboradorPasivoTCSaldoQ," +
                        "FORMAT(a.ColaboradorPasivoTCSaldoUS, 2) as ColaboradorPasivoTCSaldoUS FROM  EP_ColaboradorPasivoTC a INNER JOIN Gen_EntidadFinanciera b on a.EntidadFinCodigo= b.EntidadFinCodigo WHERE LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvcuentaspc(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorPasivoCXPID`, `ColaboradorPasivoCXPOrigen`,  FORMAT(ColaboradorPasivoCXPMonto,2) as ColaboradorPasivoCXPMonto, ColaboradorPasivoCXPDescripcio FROM `EP_ColaboradorPasivoCXP` WHERE LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvcontingente(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorPasivoContID`, b.EntidadFinDescripcion, `ColaboradorPasivoContDeudor`, `ColaboradorPasivoContRelacion`, FORMAT(ColaboradorPasivoContSaldo,2) as ColaboradorPasivoContSaldo , DATE_FORMAT(ColaboradorPasivoContFechaDese, '%d-%m-%Y') as ColaboradorPasivoContFechaDese , DATE_FORMAT(ColaboradorPasivoContFechaFin, '%d-%m-%Y')as ColaboradorPasivoContFechaFin FROM EP_ColaboradorPasivoContin a INNER JOIN Gen_EntidadFinanciera b ON a.EntidadFinCodigo= b.EntidadFinCodigo WHERE LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvcontingentef(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorPasivoContID`, b.EntidadFinDescripcion, `ColaboradorPasivoContDeudor`, `ColaboradorPasivoContRelacion`, FORMAT(ColaboradorPasivoContSaldo,2) as ColaboradorPasivoContSaldo , DATE_FORMAT(ColaboradorPasivoContFechaDese, '%Y-%m-%d') as ColaboradorPasivoContFechaDese, DATE_FORMAT(ColaboradorPasivoContFechaDese, '%Y-%m-%d') as ColaboradorPasivoContFechaDese , DATE_FORMAT(ColaboradorPasivoContFechaFin, '%Y-%m-%d')as ColaboradorPasivoContFechaFin FROM EP_ColaboradorPasivoContin a INNER JOIN Gen_EntidadFinanciera b ON a.EntidadFinCodigo= b.EntidadFinCodigo WHERE LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvBienes(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorActivoBIID`, b.TipoPresuncionDescripcion , c.TipoInmuebleDescripcion , `ColaboradorActivoBIFinca`, `ColaboradorActivoBIFolio`, `ColaboradorActivoBILibro`, `ColaboradorActivoBIDireccon`,  FORMAT(ColaboradorActivoBIValor, 2)AS ColaboradorActivoBIValor, `ColaboradorActivoBIComentario` FROM EP_ColaboradorActivosBienes a INNER JOIN Gen_TipoPresuncion b on a.TipoPresuncionID=b.TipoPresuncionID INNER JOIN Gen_TipoInmueble c on c.TipoInmuebleID= a.TipoInmuebleID WHERE  LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarvehiculos(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT *, b.TipoVehiculoDescripcion, FORMAT(ColaboradorActivoVehValor,2) AS ColaboradorActivoVehValor2 FROM EP_ColaboradorActivosVehiculos a INNER JOIN Gen_TipoVehiculo b on a.TipoVehiculoID= b.TipoVehiculoID WHERE  LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarmobi(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT  `LoteID`, `ColaboradorID`, `ColaboradorActivoEqID`, `TipoEquipoID`, FORMAT(ColaboradorActivoEqValor, 2) AS ColaboradorActivoEqValor, `ColaboradorActivoEqDescripcion` FROM EP_ColaboradorActivosEquipo WHERE  LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenaruserlote(string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT b.ColaboradorID, c.nombrepersonal,a.LoteEstado, b.ColaboradorEstado FROM EP_Lote a INNER JOIN EP_Colaborador b ON a.LoteID=b.LoteID INNER JOIN general_usuarios c on c.cif= b.ColaboradorID WHERE a.LoteID = '" + lt + "' ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvemergencia(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT *,b.TipoParentescoDescripcion FROM EP_ColaboradorContactoEmer a INNER JOIN Gen_TipoParentesco b on a.TipoParentescoID = b.TipoParentescoID WHERE LoteID = '" + lt + "' AND  ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenartelefonos(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT *, b.TipoTelefonoDescripcion FROM EP_ColaboradorTelefono a INNER JOIN Gen_TipoTelefono b on a.TipoTelefonoID=b.TipoTelefonoID WHERE LoteID = '" + lt + "' AND ColaboradorID = '" + colab + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarotrosestudios(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT a.ColaboradorEstudioOtrID, a.ColaboradorEstudioOtrCurso, a.ColaboradorEstudioOtrEstableci, a.ColaboradorEstudioOtrAnio, a.ColaboradorEstudioOtrDuracion, b.ModalidadEstudioDescripcion as ModalidadEstudioID FROM EP_ColaboradorEstudioOtr a INNER JOIN Gen_ModalidadEstudio b on a.ModalidadEstudioID= b.ModalidadEstudioID WHERE LoteID = '" + lt + "' AND  a.ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarinversiones(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorActivoInverID`, `ColaboradorActivoInverPlazo`, FORMAT(a.ColaboradorActivoInverMonto,2) AS ColaboradorActivoInverMonto, `ColaboradorActivoInverOrigen`, `ColaboradorActivoInverCuenta`, DATE_FORMAT(a.ColaboradorActivoInverFechaApe,'%d-%m-%Y') as ColaboradorActivoInverFechaApe, b.MonedaNombre, c.EntidadFinDescripcion FROM EP_ColaboradorActivosInver a INNER JOIN Gen_Moneda b on a.MonedaID = b.MonedaID INNER JOIN Gen_EntidadFinanciera c on c.EntidadFinCodigo=a.EntidadFinCodigo WHERE LoteID = '" + lt + "' AND  a.ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarinversionesf(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorActivoInverID`, `ColaboradorActivoInverPlazo`, FORMAT(a.ColaboradorActivoInverMonto,2) AS ColaboradorActivoInverMonto, `ColaboradorActivoInverOrigen`, `ColaboradorActivoInverCuenta`, DATE_FORMAT(a.ColaboradorActivoInverFechaApe,'%Y-%m-%d') as ColaboradorActivoInverFechaApe, b.MonedaNombre, c.EntidadFinDescripcion FROM EP_ColaboradorActivosInver a INNER JOIN Gen_Moneda b on a.MonedaID = b.MonedaID INNER JOIN Gen_EntidadFinanciera c on c.EntidadFinCodigo=a.EntidadFinCodigo WHERE LoteID = '" + lt + "' AND  a.ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarprestamos(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorPasivoPrestID`, c.TipoPrestamoDescripcion, b.EntidadFinDescripcion, FORMAT(a.ColaboradorPasivoPrestMontoIni,2) as ColaboradorPasivoPrestMontoIni, FORMAT(a.ColaboradorPasivoPrestSaldo,2) AS ColaboradorPasivoPrestSaldo, `ColaboradorPasivoPrestDestino`, DATE_FORMAT(ColaboradorPasivoPrestFecDesem, '%d-%m-%Y') as ColaboradorPasivoPrestFecDesem, DATE_FORMAT( ColaboradorPasivoPrestFecFinal, '%d-%m-%Y') as ColaboradorPasivoPrestFecFinal FROM EP_ColaboradorPasivoPrestamo a  INNER JOIN Gen_EntidadFinanciera b on a.EntidadFinCodigo = b.EntidadFinCodigo INNER JOIN Gen_TipoPrestamo c on c.TipoPrestamoID= a.TipoPrestamoID  WHERE LoteID = '" + lt + "' AND  a.ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarprestamosf(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorPasivoPrestID`, c.TipoPrestamoDescripcion, b.EntidadFinDescripcion, FORMAT(a.ColaboradorPasivoPrestMontoIni,2) as ColaboradorPasivoPrestMontoIni, FORMAT(a.ColaboradorPasivoPrestSaldo,2) AS ColaboradorPasivoPrestSaldo, `ColaboradorPasivoPrestDestino`, DATE_FORMAT(ColaboradorPasivoPrestFecDesem, '%Y-%m-%d') as ColaboradorPasivoPrestFecDesem, DATE_FORMAT( ColaboradorPasivoPrestFecFinal, '%Y-%m-%d') as ColaboradorPasivoPrestFecFinal FROM EP_ColaboradorPasivoPrestamo a  INNER JOIN Gen_EntidadFinanciera b on a.EntidadFinCodigo = b.EntidadFinCodigo INNER JOIN Gen_TipoPrestamo c on c.TipoPrestamoID= a.TipoPrestamoID  WHERE LoteID = '" + lt + "' AND  a.ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvnegocio(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradoringresoNegID`, b.TipoNegocioDescripcion, `ColaboradoringresoNegNombre`, `ColaboradoringresoNegPatente`, `ColaboradoringresoNegEmpleados`, `ColaboradoringresoNegObjeto`, FORMAT(ColaboradoringresoNegIngresos,2) AS ColaboradoringresoNegIngresos, FORMAT(ColaboradoringresoNegEgresos, 2) AS ColaboradoringresoNegEgresos, `ColaboradoringresoNegDireccion` FROM EP_ColaboradorIngresoNegocio a INNER JOIN Gen_TipoNegocio b on a.TipoNegocioID=b.TipoNegocioID WHERE  LoteID = '" + lt + "' AND  a.ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvremesas(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradoringresoRemesaID`, `ColaboradorIngresoRemesaRemite`, `ColaboradorIngresoRemesaRelaci`, FORMAT(ColaboradorIngresoRemesaPromed,2) AS ColaboradorIngresoRemesaPromed, `ColaboradorIngresoRemesaPeriod` FROM `EP_ColaboradorIngresoRemesa` WHERE  LoteID = '" + lt + "' AND  ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenardgvotros(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand(" SELECT `LoteID`, `ColaboradorID`, `ColaboradoringresoOtrID`, b.TipoOtroIngresoDescripcion , `ColaboradoringresoOtrDescripci`, FORMAT(ColaboradoringresoOtrValor,2) AS ColaboradoringresoOtrValor FROM EP_ColaboradorIngresoOtro a INNER JOIN Gen_TipoOtroIngreso b on a.TipoOtroIngresoID = b.TipoOtroIngresoID  WHERE  LoteID = '" + lt + "' AND  a.ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable llenarcpc(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorActivoCXCID`, `ColaboradorActivoCXCOrigen`, FORMAT(ColaboradorActivoCXCMonto,2) as ColaboradorActivoCXCMonto, `ColaboradorActivoCXCMotivo` FROM  EP_ColaboradorActivosCXC WHERE LoteID = '" + lt + "' AND  ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

        public DataTable llenarinventarios(string colab, string lt)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `ColaboradorID`, `ColaboradorActivoInvID`, `ColaboradorActivoInvTipo`, FORMAT(ColaboradorActivoInvValor,2) AS ColaboradorActivoInvValor FROM `EP_ColaboradorActivosInv` WHERE  LoteID = '" + lt + "' AND  ColaboradorID =  '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public void llenartabla(GridView dgv, DataTable dt)
        {
            DataTable dt1 = new DataTable();
            dt1 = dt;
            dgv.DataSource = dt1;
            dgv.DataBind();

        }
        public DataTable llenarloteselegir(string colab)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT a.LoteID,a.LoteDescripcion ,c.nombrepersonal,a.LoteEstado, b.ColaboradorEstado  FROM EP_Lote a INNER JOIN EP_Colaborador b ON a.LoteID=b.LoteID INNER JOIN general_usuarios c on c.cif= b.ColaboradorID WHERE c.usuario = '" + colab + "'  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarusuarios()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT DISTINCT * FROM `general_usuarios` WHERE estado = 1", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarusuariosdepto(string gerencia, string area)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT DISTINCT b.ColaboradorID as cif, a.nombrepersonal FROM general_usuarios a INNER JOIN EP_Colaborador b on a.cif=b.ColaboradorID WHERE a.estado = 1 AND b.codgensucursal = '" + gerencia + "' AND b.codgenarea = '" + area + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarusuariosperiodo(string fechai, string fechaf)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT DISTINCT b.ColaboradorID as cif, a.nombrepersonal FROM general_usuarios a INNER JOIN EP_Colaborador b on a.cif=b.ColaboradorID WHERE a.estado = 1 AND a.fechaingreso BETWEEN '" + fechai + "' AND '" + fechaf + "'", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }
        public DataTable llenarloteinfo(string colab)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {

                try
                {
                    sqlCon.Open();
                    MySqlCommand command = new MySqlCommand("SELECT `LoteID`, `LoteDescripcion`, `LoteFecInicio`, `LoteFecFin`, `LoteEstado`,LoteTipoCambio FROM `EP_Lote` ORDER BY LoteID DESC  ", sqlCon);
                    MySqlDataAdapter ds = new MySqlDataAdapter();
                    ds.SelectCommand = command;
                    ds.Fill(dt);


                }
                catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nERROR EN CONSULTA\n -"); }

                return dt;
            }
        }

    }
}