using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using KB_Guadalupana.Controllers;

namespace KB_Guadalupana.Views.EP
{


    public class loteval
    {

        ModeloEST mest = new ModeloEST();



        public string[] lotevalido()
        {
            string[] lote = mest.loteactivo();


            return lote;

        }

        public string[] lotevalidoid(string id)
        {
            string[] lote = mest.loteactivoid(id);


            return lote;

        }


        public void importar(string ColaboradorID, string LoteID, string LoteID2, string tablaorigen, string tabladestino)
        {
            string sql1 = "CREATE TEMPORARY TABLE tmp SELECT * FROM '" + tablaorigen + "' WHERE ColaboradorID= '" + ColaboradorID + "'  AND LoteID= '" + LoteID2 + "' ;" +

                "UPDATE tmp SET LoteID='" + LoteID + "' WHERE ColaboradorID='" + ColaboradorID + "';" +
                "INSERT INTO '" + tabladestino + "' SELECT * FROM tmp WHERE ColaboradorID = '" + ColaboradorID + "';" +
                "";
            mest.executesql(sql1);


        }
        public bool fenafore(string colab, string lote)
        {
            bool si;
            string[] fechadatoscorte = lotevalidoid(lote);
            int parametro = Convert.ToInt32(mest.parametro());
            DateTime diaingreso = Convert.ToDateTime(mest.fechaingreso(colab, lote));
            DateTime fecharesultado = Convert.ToDateTime(fechadatoscorte[6]);

            DateTime dias = fecharesultado.AddDays(parametro);

            if (diaingreso <= dias) { si = true; }
            else { si = false; }
            return si;

        }
        public string cadenacampos(string cif, string lote)
        {

            string cadenatotal = "";
            bool fena = fenafore(cif, lote);

            if (fena == true)
            {
                string infgen = "SELECT `ColaboradorID` AS CIF,`codgensucursal` AS GERENCIA,`codgenarea` AS ÁREA,`codgenpuestos` AS PUESTO,`ColaboradorFecIngreso` AS FECHA_INGRESO,`ColaboradorPrimerApellido` AS PRIMER_APELLIDO,`ColaboradorPrimerNombre` AS PRIMER_NOMBRE,`ColaboradorDirDomicilio` AS DOMICILIO,`SubDivisionGeograficaID` AS DEPARTAMENTO," +
                 "`ZonaDivisionGeograficaID` AS MUNICIPIO,`TipoIdentificacionID` AS TIPO_IDENTIFICACIÓN," +
                 "`ColaboradorNoIdentificacion` AS NO_IDENTIFICACIÓN,`ColaboradorFecNacimiento` AS FECHA_NACIMIENTO," +
                 "`ColaboradorNacionalidad` AS NACIONALIDAD ,`EstadoCivilID` AS ESTADO_CIVIL ," +
                 "`ColaboradorPEP` AS PEP,`ColaboradorCPE` AS CPE," +
                 "`ColaboradorInversionFenarore` AS FENAFORE , " +
                 "ColaboradorActivoMenCelCant AS CANTIDAD_CELULAR  " +
                 ", ColaboradorActivoMenCelValor AS VALOR_CELULAR," +
                 " ColaboradorIngresoSueldoBase AS SUELDO_BASE, " +
                 "ColaboradorIngresoBonifica AS BONIFICACIONES, ColaboradorEgresoAlimentacion AS EGRESOS_ALIMENTACIÓN" +
                 ", ColaboradorEgresoTransporte AS EGRESOS_TRANSPORTE, ColaboradorEgresoVestuario AS EGRESO_VESTUARIO" +
                 ", ColaboradorEgresoRecreacion AS EGRESO_RECREACIÓN FROM EP_Colaborador WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string telefonos = "SELECT `TipoTelefonoID` AS TIPO_TELEFONO,`ColaboradorTelefonoNumero` AS NUMERO_TELEFONO FROM `EP_ColaboradorTelefono` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string emergencias = "SELECT `ColaboradorContactoENombre` AS NOMBRE_CONTACTO_EMERGENCIA,`ColaboradorContactoETelefono` AS CONTACTO_EMERGENCIA ,`TipoParentescoID` AS TIPO_PARENTESO FROM `EP_ColaboradorContactoEmer` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string activos = "SELECT `TipoCuentaFinCodigo` AS TIPO_CUENTA,`EntidadFinCodigo` AS ENTIDAD_COOPERATIVA,`ColaboradorActivoCBActiva` AS ESTADO_CUENTA,`MonedaID` AS MONEDA,`ColaboradorActivoCBNumero` AS NO_CUENTA,`ColaboradorActivoCBSaldo` AS SALDO,`ColaboradorActivoCBOrigen` AS ORIGEN_FONDOS FROM EP_ColaboradorActivosCB WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' AND EntidadFinCodigo = 38 ; ";



                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();

                dt1 = mest.validacion(infgen);
                dt2 = mest.validacion(telefonos);

                dt3 = mest.validacion(emergencias);
                dt4 = mest.validacion(activos);

                string[] camp1 = recorrer2(dt1);
                string[] camp2 = recorrer2(dt2);
                string[] camp3 = recorrer2(dt3);
                string[] camp4 = recorrer2(dt4);

                int total = camp1.Length + camp2.Length + camp3.Length + camp4.Length;


                for (int l = 0; l < camp1.Length; l++)
                {
                    if (camp1[l] != null)
                    {
                        cadenatotal = "\\n" + camp1[l] + cadenatotal;
                    }

                }
                for (int m = 0; m < camp2.Length; m++)
                {
                    if (camp2[m] != null)
                    {
                        cadenatotal = "\\n" + camp2[m] + cadenatotal;
                    }

                }

                for (int n = 0; n < camp3.Length; n++)
                {
                    if (camp3[n] != null)
                    {
                        cadenatotal = "\\n" + camp3[n] + cadenatotal;
                    }

                }

                for (int o = 0; o < camp4.Length; o++)
                {
                    if (camp4[o] != null)
                    {
                        cadenatotal = "\\n" + camp4[o] + cadenatotal;
                    }

                }


            }
            else
            {
                string infgen = "SELECT `ColaboradorID` AS CIF,`codgensucursal` AS GERENCIA,`codgenarea` AS ÁREA,`codgenpuestos` AS PUESTO,`ColaboradorFecIngreso` AS FECHA_INGRESO,`ColaboradorPrimerApellido` AS PRIMER_APELLIDO,`ColaboradorPrimerNombre` AS PRIMER_NOMBRE,`ColaboradorDirDomicilio` AS DOMICILIO,`SubDivisionGeograficaID` AS DEPARTAMENTO," +
                    "`ZonaDivisionGeograficaID` AS MUNICIPIO,`TipoIdentificacionID` AS TIPO_IDENTIFICACIÓN," +
                    "`ColaboradorNoIdentificacion` AS NO_IDENTIFICACIÓN,`ColaboradorFecNacimiento` AS FECHA_NACIMIENTO," +
                    "`ColaboradorNacionalidad` AS NACIONALIDAD ,`EstadoCivilID` AS ESTADO_CIVIL ," +
                    "`ColaboradorPEP` AS PEP,`ColaboradorCPE` AS CPE," +

                    "ColaboradorActivoMenCelCant AS CANTIDAD_CELULAR  " +
                    ", ColaboradorActivoMenCelValor AS VALOR_CELULAR," +
                    " ColaboradorIngresoSueldoBase AS SUELDO_BASE, " +
                    "ColaboradorIngresoBonifica AS BONIFICACIONES, ColaboradorEgresoAlimentacion AS EGRESOS_ALIMENTACIÓN" +
                    ", ColaboradorEgresoTransporte AS EGRESOS_TRANSPORTE, ColaboradorEgresoVestuario AS EGRESO_VESTUARIO" +
                    ", ColaboradorEgresoRecreacion AS EGRESO_RECREACIÓN FROM EP_Colaborador WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string telefonos = "SELECT `TipoTelefonoID` AS TIPO_TELEFONO,`ColaboradorTelefonoNumero` AS NUMERO_TELEFONO FROM `EP_ColaboradorTelefono` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string emergencias = "SELECT `ColaboradorContactoENombre` AS NOMBRE_CONTACTO_EMERGENCIA,`ColaboradorContactoETelefono` AS CONTACTO_EMERGENCIA ,`TipoParentescoID` AS TIPO_PARENTESO FROM `EP_ColaboradorContactoEmer` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string activos = "SELECT `TipoCuentaFinCodigo` AS TIPO_CUENTA,`EntidadFinCodigo` AS ENTIDAD_COOPERATIVA,`ColaboradorActivoCBActiva` AS ESTADO_CUENTA,`MonedaID` AS MONEDA,`ColaboradorActivoCBNumero` AS NO_CUENTA,`ColaboradorActivoCBSaldo` AS SALDO,`ColaboradorActivoCBOrigen` AS ORIGEN_FONDOS FROM EP_ColaboradorActivosCB WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' AND EntidadFinCodigo = 38 ; ";



                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();

                dt1 = mest.validacion(infgen);
                dt2 = mest.validacion(telefonos);

                dt3 = mest.validacion(emergencias);
                dt4 = mest.validacion(activos);

                string[] camp1 = recorrer2(dt1);
                string[] camp2 = recorrer2(dt2);
                string[] camp3 = recorrer2(dt3);
                string[] camp4 = recorrer2(dt4);

                int total = camp1.Length + camp2.Length + camp3.Length + camp4.Length;


                for (int l = 0; l < camp1.Length; l++)
                {
                    if (camp1[l] != null)
                    {
                        cadenatotal = "\\n" + camp1[l] + cadenatotal;
                    }

                }
                for (int m = 0; m < camp2.Length; m++)
                {
                    if (camp2[m] != null)
                    {
                        cadenatotal = "\\n" + camp2[m] + cadenatotal;
                    }

                }

                for (int n = 0; n < camp3.Length; n++)
                {
                    if (camp3[n] != null)
                    {
                        cadenatotal = "\\n" + camp3[n] + cadenatotal;
                    }

                }

                for (int o = 0; o < camp4.Length; o++)
                {
                    if (camp4[o] != null)
                    {
                        cadenatotal = "\\n" + camp4[o] + cadenatotal;
                    }

                }







            }



            return cadenatotal;

        }
        public string[] recorrer2(DataTable dt)
        {
            int i = 0;
            int vacio = 0;
            int co = dt.Columns.Count;
            int ro = dt.Rows.Count;
            int cant = co * ro;
            string[] campos = new string[cant];
            string[] campost = new string[cant];
            string[] nombre = new string[cant];


            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    string comparar = row[column].ToString();
                    if (comparar == "" || comparar == "0" || comparar == "0.00" || comparar == "0.0")
                    {

                        campost[i] = dt.Columns[i].ColumnName;
                    }

                    i++;
                }
            }
            return campost;
        }

        public int recorrer(DataTable dt)
        {
            int i = 0;
            int vacio = 0;
            int ro = dt.Rows.Count;
            if (dt.Rows.Count == 0) {
                vacio++;
            
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    string comparar = row[column].ToString();
                    if (comparar == "" || comparar == "0" || comparar == "0.00" || comparar == "0.0")
                    {
                        vacio++;
                    }

                    i++;
                }
            }
            return vacio;
        }


        public bool validaretapa(string cif, string lote)
        {

            bool si;
            bool fena = fenafore(cif, lote);
            if (fena == true)
            {
                //pep en infogen y fenafore
                string infgen = "SELECT `ColaboradorID` AS CIF,`codgensucursal` AS GERENCIA,`codgenarea` AS ÁREA,`codgenpuestos` AS PUESTO,`ColaboradorFecIngreso` AS FECHA_INGRESO,`ColaboradorPrimerApellido` AS PRIMER_APELLIDO,`ColaboradorPrimerNombre` AS PRIMER_NOMBRE,`ColaboradorDirDomicilio` AS DOMICILIO,`SubDivisionGeograficaID` AS DEPARTAMENTO," +
                    "`ZonaDivisionGeograficaID` AS MUNICIPIO,`TipoIdentificacionID` AS TIPO_IDENTIFICACIÓN," +
                    "`ColaboradorNoIdentificacion` AS NO_IDENTIFICACIÓN,`ColaboradorFecNacimiento` AS FECHA_NACIMIENTO," +
                    "`ColaboradorNacionalidad` AS NACIONALIDAD ,`EstadoCivilID` AS ESTADO_CIVIL ," +
                    "`ColaboradorPEP` AS PEP,`ColaboradorCPE` AS CPE," +
                    "`ColaboradorInversionFenarore` AS FENAFORE , " +
                    "ColaboradorActivoMenCelCant AS CANTIDAD_CELULAR  " +
                    ", ColaboradorActivoMenCelValor AS VALOR_CELULAR," +
                    " ColaboradorIngresoSueldoBase AS SUELDO_BASE, " +
                    "ColaboradorIngresoBonifica AS BONIFICACIONES, ColaboradorEgresoAlimentacion AS EGRESOS_ALIMENTACIÓN" +
                    ", ColaboradorEgresoTransporte AS EGRESOS_TRANSPORTE, ColaboradorEgresoVestuario AS EGRESO_VESTUARIO" +
                    ", ColaboradorEgresoRecreacion AS EGRESO_RECREACIÓN FROM EP_Colaborador WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string telefonos = "SELECT `TipoTelefonoID` AS TIPO_TELEFONO,`ColaboradorTelefonoNumero` AS NUMERO_TELEFONO FROM `EP_ColaboradorTelefono` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string emergencias = "SELECT `ColaboradorContactoENombre` AS NOMBRE_CONTACTO_EMERGENCIA,`ColaboradorContactoETelefono` AS CONTACTO_EMERGENCIA ,`TipoParentescoID` AS TIPO_PARENTESO FROM `EP_ColaboradorContactoEmer` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string activos = "SELECT `TipoCuentaFinCodigo` AS TIPO_CUENTA,`EntidadFinCodigo` AS ENTIDAD_COOPERATIVA,`ColaboradorActivoCBActiva` AS ESTADO_CUENTA,`MonedaID` AS MONEDA,`ColaboradorActivoCBNumero` AS NO_CUENTA,`ColaboradorActivoCBSaldo` AS SALDO,`ColaboradorActivoCBOrigen` AS ORIGEN_FONDOS FROM EP_ColaboradorActivosCB WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' AND EntidadFinCodigo = 38 ; ";



                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();



                dt1 = mest.validacion(infgen);
                dt2 = mest.validacion(telefonos);

                dt3 = mest.validacion(emergencias);
                dt4 = mest.validacion(activos);


                int vacio = recorrer(dt1);
                int vacio2 = recorrer(dt2);
                int vacio3 = recorrer(dt3);
                int vacio4 = recorrer(dt4);







                if (
                     vacio == 0 &&
                     vacio2 == 0 &&
                     vacio3 == 0 &&
                     vacio4 == 0


                    )
                {
                    //ESTO VA EN EL BTN SI BOOL ES TRUE
                    //string cambioetapa = "UPDATE EP_Colaborador SET  ";
                    //mest.executesql(cambioetapa);
                    si = true;

                }
                else
                {
                    si = false;
                }

            }

            else
            {

                string infgen = "SELECT `ColaboradorID` AS CIF,`codgensucursal` AS GERENCIA,`codgenarea` AS ÁREA,`codgenpuestos` AS PUESTO,`ColaboradorFecIngreso` AS FECHA_INGRESO,`ColaboradorPrimerApellido` AS PRIMER_APELLIDO,`ColaboradorPrimerNombre` AS PRIMER_NOMBRE,`ColaboradorDirDomicilio` AS DOMICILIO,`SubDivisionGeograficaID` AS DEPARTAMENTO," +
         "`ZonaDivisionGeograficaID` AS MUNICIPIO,`TipoIdentificacionID` AS TIPO_IDENTIFICACIÓN," +
         "`ColaboradorNoIdentificacion` AS NO_IDENTIFICACIÓN,`ColaboradorFecNacimiento` AS FECHA_NACIMIENTO," +
         "`ColaboradorNacionalidad` AS NACIONALIDAD ,`EstadoCivilID` AS ESTADO_CIVIL ," +
         "`ColaboradorPEP` AS PEP,`ColaboradorCPE` AS CPE," +

         "ColaboradorActivoMenCelCant AS CANTIDAD_CELULAR  " +
         ", ColaboradorActivoMenCelValor AS VALOR_CELULAR," +
         " ColaboradorIngresoSueldoBase AS SUELDO_BASE, " +
         "ColaboradorIngresoBonifica AS BONIFICACIONES, ColaboradorEgresoAlimentacion AS EGRESOS_ALIMENTACIÓN" +
         ", ColaboradorEgresoTransporte AS EGRESOS_TRANSPORTE, ColaboradorEgresoVestuario AS EGRESO_VESTUARIO" +
         ", ColaboradorEgresoRecreacion AS EGRESO_RECREACIÓN FROM EP_Colaborador WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; "; string telefonos = "SELECT `TipoTelefonoID` AS TIPO_TELEFONO,`ColaboradorTelefonoNumero` AS NUMERO_TELEFONO FROM `EP_ColaboradorTelefono` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string emergencias = "SELECT `ColaboradorContactoENombre` AS NOMBRE_CONTACTO_EMERGENCIA,`ColaboradorContactoETelefono` AS CONTACTO_EMERGENCIA ,`TipoParentescoID` AS TIPO_PARENTESO FROM `EP_ColaboradorContactoEmer` WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' ; ";
                string activos = "SELECT `TipoCuentaFinCodigo` AS TIPO_CUENTA,`EntidadFinCodigo` AS ENTIDAD_COOPERATIVA,`ColaboradorActivoCBActiva` AS ESTADO_CUENTA,`MonedaID` AS MONEDA,`ColaboradorActivoCBNumero` AS NO_CUENTA,`ColaboradorActivoCBSaldo` AS SALDO,`ColaboradorActivoCBOrigen` AS ORIGEN_FONDOS FROM EP_ColaboradorActivosCB WHERE ColaboradorID = '" + cif + "' AND LoteID = '" + lote + "' AND EntidadFinCodigo = 38 ; ";



                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();



                dt1 = mest.validacion(infgen);
                dt2 = mest.validacion(telefonos);

                dt3 = mest.validacion(emergencias);
                dt4 = mest.validacion(activos);


                int vacio = recorrer(dt1);
                int vacio2 = recorrer(dt2);
                int vacio3 = recorrer(dt3);
                int vacio4 = recorrer(dt4);







                if (
                     vacio == 0 &&
                     vacio2 == 0 &&
                     vacio3 == 0 &&
                     vacio4 == 0


                    )
                {
                    //ESTO VA EN EL BTN SI BOOL ES TRUE
                    //string cambioetapa = "UPDATE EP_Colaborador SET  ";
                    //mest.executesql(cambioetapa);
                    si = true;

                }
                else
                {
                    si = false;
                }

            }

            return si;
        }

    }
}