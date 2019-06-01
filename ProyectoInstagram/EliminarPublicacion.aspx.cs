using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EstructuraDeDatos;
using ProyectoInstagram.Model;

namespace ProyectoInstagram
{
    public partial class EliminarPublicacion : System.Web.UI.Page
    {
        public LinkedListDouble publicaciones;
        public Usuario usuario = new Usuario();
        public ArbolAVL usuariosRegistrados = new ArbolAVL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerSesion();
                try
                {
                    
                    if (Request.QueryString["id_publicacion"] != null)
                    {
                        String id_publicacion = Request.QueryString["id_publicacion"];
                        publicaciones.iniciarPrimero();
                        while (publicaciones.getActual() != null)
                        {
                            Publicacion publicacion_actual = (Publicacion)publicaciones.getActual();
                            if (publicacion_actual.Id_publicacion == int.Parse(id_publicacion))
                            {
                                publicaciones.eliminar(publicacion_actual);
                                publicaciones.iniciarPrimero();
                                Session["publicaciones"] = publicaciones;
                                Response.Redirect("/Profile");
                                return;
                            }
                            publicaciones.next();
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        public void ObtenerSesion()
        {
            String name = Request.QueryString["name"];
            try
            {
                publicaciones = (LinkedListDouble)Session["publicaciones"];
                usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];

                if (Session["id_usuario"] == null)
                {
                    Response.Redirect("/Login.aspx");
                }
                else
                {
                    usuario = (Usuario)usuariosRegistrados.buscar(Session["id_usuario"]);
                }

                if (publicaciones == null)
                {
                    publicaciones = new LinkedListDouble();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}