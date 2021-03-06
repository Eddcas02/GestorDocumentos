using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using KB_Guadalupana.Controllers;
using KB_Guadalupana.Models;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;

namespace KB_Guadalupana.Views.Evaluaciones
{
    public partial class SQ_Evaluacion : System.Web.UI.Page
    {
        ModeloSQ msq = new ModeloSQ();
        ControladorSQ ctq = new ControladorSQ();
        Conexion conexiongeneral = new Conexion();
        clasebit claser = new clasebit();
        string persona2;
        string usuarios;
      

        DataTable dt = new DataTable();
        string codigoevaluador, nombreevaluador;
        string n1 = "", n2 = "";
        double pglobal = 0, resblobal = 0;
        double s1 = 0, s2 = 0;
        double xfinal = 0;
        string codigoevaluado, nombreevaluado, puestoevaluado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ususario = Convert.ToString( Session["sesion_usuario"] )   ;
                string idpuesto = msq.obtenerpuesto(ususario);
                string fecha = msq.obtenerfecha(ususario);
                string[] fecha2 = fecha.Split(' ');
                string[] fecha3 = fecha2[0].Split('/');



                if (fecha2[0] != "") {

                    DateTime date2 = Convert.ToDateTime("15/07/2021");
                    DateTime date = Convert.ToDateTime(fecha2[0]);
                    string puestojefe = msq.obtenerpuestojefe2(idpuesto);
                    if (date > date2)
                    {
                        String script = "alert('No puede realizar evaluación');  window.location.href= '../Sesion/MenuBarra.aspx';";
                        ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                    }
                    else
                    {
                        //if (idpuesto == "10" || idpuesto == "11" || idpuesto == "19" || idpuesto == "22" || idpuesto == "25" || idpuesto == "32" || idpuesto == "37" || idpuesto == "39" || idpuesto == "44" || idpuesto == "49" || idpuesto == "52" || idpuesto == "65" || idpuesto == "69" || idpuesto == "76" || idpuesto == "77" || idpuesto == "83" || idpuesto == "87" || idpuesto == "92" || idpuesto == "105" || idpuesto == "109" || idpuesto == "115")
                        if (puestojefe == null || puestojefe == "")
                        {
                            //Autoevaluacion.Visible = true;
                            //EcaluacionJefe.Visible = true;
                            //EvaluacionPersonas.Visible = true;
                            //tablapersonas.Visible = true;

                            Autoevaluacion.Visible = true;
                            EcaluacionJefe.Visible = true;
                            EvaluacionPersonas.Visible = false;
                            tablapersonas.Visible = false;
                        }
                        else
                        {
                            //Autoevaluacion.Visible = true;
                            //EcaluacionJefe.Visible = true;
                            //EvaluacionPersonas.Visible = false;
                            //tablapersonas.Visible = false;

                            Autoevaluacion.Visible = true;
                            EcaluacionJefe.Visible = true;
                            EvaluacionPersonas.Visible = true;
                            tablapersonas.Visible = true;
                        }

                        evaluacion.Visible = false;
                        DataSet ds1 = msq.preguntas();

                        Repeater1.DataSource = ds1;
                        Repeater1.DataBind();

                        Repeater2.DataSource = ds1;
                        Repeater2.DataBind();

                        llenargridviewpersonas();

                        //llenar();
                        //llenar2();
                    }
                }
                else {
                    String script = "alert('Su usuario no esta en la base de datos');  window.location.href= '../Sesion/MenuBarra.aspx';";
                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                }
                if (idpuesto == "2")
                {
                    Autoevaluacion.Visible = false;
                    EcaluacionJefe.Visible = false;
                }
            }
        }
        public void llenarcomboasignado()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string ususario = Session["sesion_usuario"] as string;
                    string idpuesto = msq.obtenerpuesto(ususario);
                    string [] jefe = msq.obtenerjefaso(idpuesto);
                  



                    for (int i = 0; i < jefe.Length; i++)
                    {
                        string p1 = Convert.ToString(jefe.GetValue(0));
                        string p2 = Convert.ToString(jefe.GetValue(1));

                        if (p2 == "")
                        {
                            sqlCon.Open();
                            string QueryString = "SELECT codsqpersonal, nombrepersonal FROM sq_personal WHERE codpuestoactual = '" + p1 + "' and estado = 1 ";
                            MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
                            DataSet ds = new DataSet();
                            myCommand.Fill(ds, "usuarios");
                            Persona.DataSource = ds;
                            Persona.DataTextField = "nombrepersonal";
                            Persona.DataValueField = "codsqpersonal";
                            Persona.DataBind();
                            Persona.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione]", "0"));

                        }
                        else
                        {
                            sqlCon.Open();
                            string QueryString2 = "SELECT codsqpersonal, nombrepersonal FROM sq_personal WHERE codpuestoactual IN ('" + p1 + "', '" + p2 + "') and estado = 1 ";
                            MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString2, sqlCon);
                            DataSet ds = new DataSet();
                            myCommand.Fill(ds, "usuarios");
                            Persona.DataSource = ds;
                            Persona.DataTextField = "nombrepersonal";
                            Persona.DataValueField = "codsqpersonal";
                            Persona.DataBind();
                            Persona.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione]", "0"));

                        }

                    }

                 


                }
                catch { Console.WriteLine("Verifique los campos"); }
            }
        }

        public void llenarcomboasignado2()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string ususario = Session["sesion_usuario"] as string;
                    string idusuario = msq.obteneridusuario(ususario);
                    sqlCon.Open();
                    string QueryString = "SELECT codsqpersonal, nombrepersonal FROM sq_personal WHERE codsqpersonal = '" + idusuario+"'";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds, "usuarios");
                    Persona.DataSource = ds;
                    Persona.DataTextField = "nombrepersonal";
                    Persona.DataValueField = "codsqpersonal";
                    Persona.DataBind();
                    Persona.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione]", "0"));
                }
                catch { Console.WriteLine("Verifique los campos"); }
            }
        }

        public void llenarcomboasignado3()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string ususario = Session["sesion_usuario"] as string;
                    string idpuesto = msq.obtenerpuesto(ususario);
                    string idusuario = msq.obteneridusuario(ususario);
                    string[] usuariosevaluados = msq.usuariosevaluados(idusuario);
                    string date = msq.obtfecha();
                    int ultimo;
                    string u = msq.obtenerunidad2(ususario);
                    ultimo = Convert.ToInt32(usuariosevaluados.Length) - 1;
                    for (int i = 0; i < usuariosevaluados.Length; i++)
                    {
                        if (i == 0 && usuariosevaluados[i] == null || usuariosevaluados[i] == "")
                        {
                            usuarios = "0";
                        }
                        else if (i == 0)
                        {
                            usuarios = usuarios + usuariosevaluados[i];
                        }
                        else if (usuariosevaluados[i] == null || usuariosevaluados[i] == "")
                        {
                            usuarios = usuarios;
                        }
                        else
                        {
                            usuarios = usuarios + ',' + usuariosevaluados[i];
                        }
                    }
                    if (idpuesto == "76" || idpuesto == "83")
                    {

                        sqlCon.Open();
                        string QueryString = "SELECT DISTINCT B.codsqpersonal AS Id, B.nombrepersonal AS Nombre FROM sq_organigrama AS A INNER JOIN sq_personal AS B ON B.codpuestoactual  = A.organisup WHERE B.estado = 1 AND A.codsqpuesto = '" + idpuesto + "' AND B.fechaingreso < '" + date + "' AND B.codsqpersonal NOT IN(" + usuarios + ") AND B.unidadoperativa = '" + u + "'  ";


                        MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
                        DataSet ds = new DataSet();
                        myCommand.Fill(ds, "usuarios");
                        Persona.DataSource = ds;
                        Persona.DataTextField = "Nombre";
                        Persona.DataValueField = "Id";
                        Persona.DataBind();
                        Persona.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione]", "0"));
                    }
                    else
                    {
                        string QueryString = "SELECT DISTINCT B.codsqpersonal AS Id, B.nombrepersonal AS Nombre FROM sq_organigrama AS A INNER JOIN sq_personal AS B ON B.codpuestoactual  = A.organisup WHERE A.codsqpuesto = '" + idpuesto + "' AND B.fechaingreso < '" + date + "' AND B.codsqpersonal NOT IN(" + usuarios + ") AND B.estado = 1";

                        MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
                        DataSet ds = new DataSet();
                        myCommand.Fill(ds, "usuarios");
                        Persona.DataSource = ds;
                        Persona.DataTextField = "Nombre";
                        Persona.DataValueField = "Id";
                        Persona.DataBind();
                        Persona.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione]", "0"));

                    }
                }
                catch { Console.WriteLine("Verifique los campos"); }
            }
        }


        //public void llenar()
        //{
        //    using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
        //    {
        //        try
        //        {
        //            string ususario = Session["sesion_usuario"] as string;
        //            string idusuario = msq.obteneridusuario(ususario);
        //            sqlCon.Open();
        //            string QueryString = "SELECT * FROM sq_personal ;";
        //            MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
        //            DataSet ds = new DataSet();
        //            myCommand.Fill(ds, "usuarios");
        //            DropDownList1.DataSource = ds;
        //            DropDownList1.DataTextField = "nombrepersonal";
        //            DropDownList1.DataValueField = "codsqpersonal";
        //            DropDownList1.DataBind();
        //            DropDownList1.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione]", "0"));
        //        }
        //        catch { Console.WriteLine("Verifique los campos"); }
        //    }
        //}

        //public void llenar2()
        //{
        //    using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
        //    {
        //        try
        //        {
        //            string ususario = Session["sesion_usuario"] as string;
        //            string idusuario = msq.obteneridusuario(ususario);
        //            sqlCon.Open();
        //            string QueryString = "SELECT * FROM sq_personal ;";
        //            MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
        //            DataSet ds = new DataSet();
        //            myCommand.Fill(ds, "usuarios");
        //            DropDownList2.DataSource = ds;
        //            DropDownList2.DataTextField = "nombrepersonal";
        //            DropDownList2.DataValueField = "codsqpersonal";
        //            DropDownList2.DataBind();
        //            DropDownList2.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Seleccione]", "0"));
        //        }
        //        catch { Console.WriteLine("Verifique los campos"); }
        //    }
        //}
        //control de preguntas cuerpo
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
               

                Label numeropregunta = (Label)e.Item.FindControl("lblrp2");
                Repeater rept = (Repeater)e.Item.FindControl("Repeater3");

                DropDownList identa2 = (DropDownList)e.Item.FindControl("valores");

                HtmlInputButton identa3 = (HtmlInputButton)e.Item.FindControl("ante");
                HtmlInputButton identa4 = (HtmlInputButton)e.Item.FindControl("sig");
                HtmlInputButton identa5 = (HtmlInputButton)e.Item.FindControl("envio");

              HtmlGenericControl identa6 = (HtmlGenericControl)e.Item.FindControl("comentariodiv");
                HtmlGenericControl identa7 = (HtmlGenericControl)e.Item.FindControl("dropcalifica");
               HtmlGenericControl identa8 = (HtmlGenericControl)e.Item.FindControl("Escala");


                string permiso = msq.obtenerorden(numeropregunta.Text);
                string ultimapregunta = msq.obtenerultima();
                string escala = msq.obtenerescala(numeropregunta.Text);
                string ordenultimo = msq.obtenerorden(numeropregunta.Text);
                string ulltimoorden = msq.obtenerordendeultima();

                string tipopregunta = msq.obtenertipo(numeropregunta.Text);
                if (permiso == "1")
                {
                    identa3.Visible = false;
                    identa5.Visible = false;
                }
                else if (ulltimoorden != ordenultimo) {

                    identa5.Visible = false;
                }
                else if (ulltimoorden == ordenultimo) {

                    identa5.Visible = true;
                    identa4.Visible = false;

                }
              
                
                DataSet ds2 = msq.escala(escala);
                rept.DataSource = ds2;
                rept.DataBind();

                switch (tipopregunta)
                {

                    case "1":
                        identa6.Visible = true;
                        identa7.Visible = false;
                        identa8.Visible = false;
                        identa2.SelectedValue = "1";
                        break;
                    case "2":
                        identa7.Visible = true;
                        identa6.Visible = false;
                        identa8.Visible = true;
                        break;
                    default:
                        identa6.Visible = false;
                        identa7.Visible = false;
                        break;

                }

                

                    using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
                    {
                        try
                        {
                            sqlCon.Open();
                            string QueryString = "SELECT * FROM `sq_calificaciones` ";
                            MySqlDataAdapter myCommand = new MySqlDataAdapter(QueryString, sqlCon);
                            DataSet ds = new DataSet();
                            myCommand.Fill(ds, "usuarios");
                            identa2.DataSource = ds;
                            identa2.DataTextField = "nota";
                            identa2.DataValueField = "codsqcalificacion";
                            identa2.DataBind();
                            identa2.Items.Insert(0, new System.Web.UI.WebControls.ListItem("[Calificación]", "0"));
                        }
                        catch { Console.WriteLine("Verifique los campos"); }
                    }
                
               

                //else if (orden != "1") { 




                //}




            }
        }

        //control de encabezado
        protected void Repeater2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                Label identa = (Label)e.Item.FindControl("lblpregunta");


             
                HtmlGenericControl identa3 = (HtmlGenericControl)e.Item.FindControl("barra");



                string orden = msq.obtenerorden(identa.Text);
                if (orden == "1")
                {

                    identa3.Attributes.Add("class", "active");


                }



            }

        }

        protected void Repeater3_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }


        //botondeenvio
        protected void btnsig_Click(object sender, EventArgs e)
        {
            //string combo, idc, orden, valor;
            //combo = sender.ToString();
            //LinkButton btn3 = (LinkButton)sender;
            //RepeaterItem item = (RepeaterItem)btn3.NamingContainer;
            //idc = ((Label)item.FindControl("lblrp2")).Text;
            //orden = ((Label)item.FindControl("orden")).Text;
            //valor = ((DropDownList)item.FindControl("Repeater1_valores_0")).SelectedValue;
            
                if (Persona.SelectedIndex == 0)
                {
                    //Control parent = ((Control)sender).Parent;
                    //DropDownList drop = (DropDownList)parent.FindControl("valores");
                    //string valor, id;
                    //id = drop.ID;
                    //valor = drop.Text;

                    String script = "alert('Seleccione a la persona antes de pasar a la siguiente pregunta');";
                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                }
            
   
            
        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            string combo, idc, orden, valor;
            int i = 0;
            int punteo = 0;
            //combo = sender.ToString();
            LinkButton btn3 = (LinkButton)sender;
            RepeaterItem item = (RepeaterItem)btn3.NamingContainer;
            //idc = ((Label)item.FindControl("lblrp2")).Text;
            //orden = ((Label)item.FindControl("orden")).Text;
            //valor = ((DropDownList)item.FindControl("valores")).SelectedValue;
            if (personacargo.SelectedValue == "0" && Persona.SelectedValue == "0")
            {
                String script2 = "alert('Complete todos los datos')";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script2, true);
            }
            else
            {


                foreach (RepeaterItem rpt in Repeater1.Items)
                {
                    DropDownList drop = (DropDownList)rpt.FindControl("valores");
                    string r = drop.SelectedValue.ToString();
                    if (r == "0" || r == "")
                    {
                     
                        i++;
                    }
                   
                }

              


                foreach (RepeaterItem rpt in Repeater1.Items)
                {
                    persona2 = Persona.SelectedValue;
                    if (persona2 != "0")
                    {
                        break;
                    }

                }
                if (i == 0)
                {
                    foreach (RepeaterItem rpt in Repeater1.Items)
                    {
                        //DropDownList drop = (DropDownList)item.FindControl("valores");
                        //valor = drop.ID;
                        //combo = drop.SelectedValue;
                        //if (rpt.ItemType == ListItemType.Item || rpt.ItemType == ListItemType.AlternatingItem)
                        //{
                        //    DropDownList drop = (DropDownList)rpt.FindControl("valores");

                        //    string r = drop.SelectedValue.ToString();
                        //}


                        DropDownList drop = (DropDownList)rpt.FindControl("valores");
                        Label pregunta = (Label)rpt.FindControl("lblrp2");
                        HtmlTextArea textarea = (HtmlTextArea)rpt.FindControl("campocomentario");
                        string respuestatext = textarea.InnerText;
                        string id = drop.ClientID;
                        string r = drop.SelectedValue.ToString();
                        string pregunta2 = pregunta.Text;
                        string sig = msq.obtenerfinal("sq_resultadopregunta", "codsqrespreg");
                        string evaluacion = msq.obtenerevaluacion();
                        //Session["sesion_usuario"] = "pgaortiz";
                        string ususario = Session["sesion_usuario"] as string;
                        string idusuario = msq.obteneridusuario(ususario);
                        string usuariopersonal = msq.obtenerusuariopersonal(idusuario);
                        string insert = "INSERT INTO sq_resultadopregunta(codsqrespreg, codsquser, codsqevaluacion, codsqpregunta, resultado, usuario_calificado, respuesta_texto) VALUES ('" + sig + "','" + idusuario + "','" + evaluacion + "','" + pregunta2 + "','" + r + "', '" + persona2 + "', '" + respuestatext + "')";
                        msq.Insertar(insert);

                        string area = msq.obtenerarea(usuariopersonal);


                        punteo = punteo + Convert.ToInt32(r);
                    }


                    string nombre = Session["Nombre"] as string;
                    string ususario2 = Session["sesion_usuario"] as string;
                    string idusuario2 = msq.obteneridusuario(ususario2);
                    string sig2 = msq.obtenerfinal("sq_controlevaluacion", "sq_idcontrol");
                    string eva = Session["tipo_evaluacion"] as string;
                    string idpuesto = msq.obtenerpuesto(ususario2);
                    string puesto = msq.obtenernombrepuesto(idpuesto);

                    int punteo2 = punteo;
                    string sig3 = msq.obtenerfinal("sq_resultadopregunta", "codsqrespreg");
                    string sig4 = msq.obtenerfinal("sq_resultado", "codsqresutado");
                    int id2 = Convert.ToInt32(sig3) - 1;

                    string insert3 = "INSERT INTO `sq_resultado`(`codsqresutado`, `codsquser`, `codsqevaluacion`, `resultado`) VALUES ('" + sig4 + "','" + idusuario2 + "','" + id2 + "','" + punteo2 + "')";
                    msq.Insertar(insert3);

                    if (eva == "auto")
                    {
                        string insert2 = "INSERT INTO sq_controlevaluacion (sq_idcontrol, Nombre, Puesto, Autoevaluacion) VALUES ('" + sig2 + "', '" + nombre + "', '" + idpuesto + "', 'Completado')";
                        msq.Insertar(insert2);
                    }
                    String script = "alert('Se ha enviado exitosamente'); window.location.href= '../Sesion/MenuBarra.aspx';";
                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
                }
                else {

                    String script2 = "alert('Complete todos los datos')";
                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script2, true);
                }
            }
        }
        protected void Autoevaluacion_Click(object sender, EventArgs e)
        {
            claser.bitacora(Session["sesion_usuario"] as string, "auto");
            string ususario = Session["sesion_usuario"] as string;
            string idusuario = msq.obteneridusuario(ususario);
            tablapersonas.Visible = false;
            string idpuesto = msq.obtenerpuesto(ususario);
            string puestojefe = msq.obtenerpuestojefe(idpuesto);



            string[] respuesta = msq.autoevaluacionresuelta(idusuario);

                if (respuesta[0] == "" || respuesta[0] == null)
                {
                    //if (idpuesto == "10" || idpuesto == "11" || idpuesto == "19" || idpuesto == "22" || idpuesto == "25" || idpuesto == "32" || idpuesto == "37" || idpuesto == "39" || idpuesto == "44" || idpuesto == "49" || idpuesto == "52" || idpuesto == "65" || idpuesto == "69" || idpuesto == "76" || idpuesto == "77" || idpuesto == "83" || idpuesto == "87" || idpuesto == "92" || idpuesto == "105" || idpuesto == "109" || idpuesto == "115")
                    if (puestojefe == null || puestojefe == "")
                    {
                        //evaluacion.Visible = true;
                        //botones.Visible = false;
                        //DataSet ds2 = msq.preguntas();

                        //Repeater1.DataSource = ds2;
                        //Repeater1.DataBind();

                        //Repeater2.DataSource = ds2;
                        //Repeater2.DataBind();

                        //llenarcomboasignado2();
                        //Session["tipo_evaluacion"] = "auto";

                        evaluacion.Visible = true;
                        botones.Visible = false;
                        DataSet ds1 = msq.preguntas2();

                        Repeater1.DataSource = ds1;
                        Repeater1.DataBind();

                        Repeater2.DataSource = ds1;
                        Repeater2.DataBind();

                        llenarcomboasignado2();
                        Session["tipo_evaluacion"] = "auto";

                    }
                    else
                    {
                        //evaluacion.Visible = true;
                        //botones.Visible = false;
                        //DataSet ds1 = msq.preguntas2();

                        //Repeater1.DataSource = ds1;
                        //Repeater1.DataBind();

                        //Repeater2.DataSource = ds1;
                        //Repeater2.DataBind();

                        //llenarcomboasignado2();
                        //Session["tipo_evaluacion"] = "auto";

                        evaluacion.Visible = true;
                        botones.Visible = false;
                        DataSet ds2 = msq.preguntas();

                        Repeater1.DataSource = ds2;
                        Repeater1.DataBind();

                        Repeater2.DataSource = ds2;
                        Repeater2.DataBind();

                        llenarcomboasignado2();
                        Session["tipo_evaluacion"] = "auto";
                    }
                }
                else
                {
                    String script = "alert('Ya realizó la evaluación'); window.location.href= '../Sesion/MenuBarra.aspx';";
                    ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);

                }
           
            
        }

        protected void EcaluacionJefe_Click(object sender, EventArgs e)
        {
            claser.bitacora(Session["sesion_usuario"] as string, "jefe");
            string ususario = Session["sesion_usuario"] as string;
            string idusuario = msq.obteneridusuario(ususario);
            //string usuariopersonal = msq.obtenerusuariopersonal(idusuario);
            tablapersonas.Visible = false;
            string idpuesto = msq.obtenerpuesto(ususario);
            string puestojefe = msq.obtenerpuestojefe(idpuesto);
            string unidad = msq.obtenerunidad(idusuario);
            string jefaso = msq.obteneridjefaso(puestojefe,unidad);

            string[] respuesta = msq.evaluacionjeferesuelta(idusuario,jefaso);

            if (respuesta[0] == "" || respuesta[0] == null)
            {
                evaluacion.Visible = true;
                botones.Visible = false;
                DataSet ds1 = msq.preguntas();

                Repeater1.DataSource = ds1;
                Repeater1.DataBind();

                Repeater2.DataSource = ds1;
                Repeater2.DataBind();

                llenarcomboasignado();
            }
            else
            {
                String script = "alert('Ya realizó la evaluación'); window.location.href= '../Sesion/MenuBarra.aspx';";
                ScriptManager.RegisterStartupScript(this, GetType().GetType(), "alertMessage", script, true);
            }
               
        }

        protected void EvaluacionPersonas_Click(object sender, EventArgs e)
        {
            claser.bitacora(Session["sesion_usuario"] as string, "personal");
            string ususario = Session["sesion_usuario"] as string;
            string idusuario = msq.obteneridusuario(ususario);
            string idpuesto = msq.obtenerpuesto(ususario);
            string puestojefe = msq.obtenerpuestojefe(idpuesto);
            evaluacion.Visible = true;
            botones.Visible = false;
            tablapersonas.Visible = false;
            Persona.Visible = true;
            //personacargo.Visible = true;
            DataSet ds1 = msq.preguntas2();

            Repeater1.DataSource = ds1;
            Repeater1.DataBind();

            Repeater2.DataSource = ds1;
            Repeater2.DataBind();
            llenarcomboasignado3();
        }


        public void llenargridviewpersonas()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conexiongeneral.cadenadeconexiongeneral()))
            {
                try
                {
                    string ususario = Session["sesion_usuario"] as string;
                    string idusuario = msq.obteneridusuario(ususario);
                    string usuariopersonal = msq.obtenerusuariopersonal(idusuario);
                    string area = msq.obtenerarea(usuariopersonal);
                    string idpuesto = msq.obtenerpuesto(ususario);
                    sqlCon.Open();
                    string query = "SELECT DISTINCT B.Nombre AS Nombre, C.puestodescrip AS Puesto, B.Autoevaluacion AS Autoevaluacion FROM sq_organigrama AS A INNER JOIN sq_controlevaluacion AS B ON B.Puesto = A.organisup INNER JOIN sq_puestoseval AS C ON C.codsqpuesto = B.Puesto WHERE A.codsqpuesto = '" + idpuesto + "' GROUP BY Nombre, puesto, autoevaluacion";
                    MySqlDataAdapter myCommand = new MySqlDataAdapter(query, sqlCon);
                    DataTable dt = new DataTable();
                    myCommand.Fill(dt);
                    gridViewPersonas.DataSource = dt;
                    gridViewPersonas.DataBind();
                }
                catch
                {

                }
            }

        }

        protected void Persona_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string idusuario = Persona.SelectedValue;
            string usuario = msq.obtenerusuario(idusuario);
            string idpuesto = msq.obtenerpuesto(usuario);
            string puestojefe = msq.obtenerpuestojefe2(idpuesto);

            Persona.Visible = true;
            personacargo.Visible = false;
            if (puestojefe == null || puestojefe == "")
            {
                evaluacion.Visible = true;
                botones.Visible = false;
                tablapersonas.Visible = false;
                DataSet ds1 = msq.preguntas2();

                Repeater1.DataSource = ds1;
                Repeater1.DataBind();

                Repeater2.DataSource = ds1;
                Repeater2.DataBind();


            }
            else
            {

                evaluacion.Visible = true;
                botones.Visible = false;
                tablapersonas.Visible = false;
                DataSet ds2 = msq.preguntas();

                Repeater1.DataSource = ds2;
                Repeater1.DataBind();

                Repeater2.DataSource = ds2;
                Repeater2.DataBind();



            }


        }


        public void reporte() {
        
        
        
        
        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    int i;

        //    for (i = 14; i<21; i++) {
        //        string sig = msq.obtenerfinal("sq_resultadopregunta", "codsqrespreg");
        //        string squele = " INSERT INTO `sq_resultadopregunta`(`codsqrespreg`, `codsquser`, `codsqevaluacion`, `codsqpregunta`, `resultado`, `usuario_calificado`, `respuesta_texto`) VALUES ('" + sig + "', '" + DropDownList1.SelectedValue + "',2,'"+i+"', 11, '"+DropDownList2.SelectedValue+"', '')";

        //        msq.Insertar(squele);
        //    }
        //}


      

  

      
       
      

     
     
       












        //private void ExportarDatos(GridView datalistado)
        //{
        //    try
        //    {



        //        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
        //        excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
        //        int IndiceColumna = 0;
        //        foreach (GridViewRow columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
        //        {
        //            IndiceColumna++;
        //            excel.Cells[1, IndiceColumna] = columna.Name;
        //        }
        //        int IndiceFila = 0;
        //        foreach (GridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
        //        {
        //            IndiceFila++;
        //            IndiceColumna = 0;
        //            foreach (GridViewRow columna in datalistado.Columns)
        //            {
        //                IndiceColumna++;
        //                excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.h].Value;
        //            }
        //        }
        //        excel.Visible = true;
        //    }
        //    catch (Exception)
        //    {
               
        //    }
        //}
   
    }
}