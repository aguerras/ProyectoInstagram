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
    public partial class Profile : System.Web.UI.Page
    {
        public LinkedListDouble publicaciones;
        public Usuario usuario = new Usuario();
        public ArbolAVL usuariosRegistrados = new ArbolAVL();
        public String strPublicacionesHTML;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ObtenerSesion();
                publicaciones.iniciarPrimero();
                while (publicaciones.getActual() != null)
                {
                    Publicacion publicacion_actual = (Publicacion)publicaciones.getActual();
                    if (publicacion_actual.User_name == usuario.Nombre_usuario) {
                        String strPublicacionHTML = "";
                        strPublicacionHTML = "<div class='gallery'><div class='gallery-item' tabindex='0'><img src='" + publicacion_actual.Imagen + "' class='gallery-image' alt=''>";
                        strPublicacionHTML = strPublicacionHTML + "<div class='gallery-item-type'>";
                        strPublicacionHTML = strPublicacionHTML + "<img src='" + usuario.Foto + "' alt='' width='32' height='32'/><h2 class=''><a style='text-decoration: none;' class='' title='" + publicacion_actual.User_name + "' href='#'>" + publicacion_actual.User_name + "</a></h2></div>";
                        strPublicacionHTML = strPublicacionHTML + "<div class='gallery-item-info'><ul>";
                        strPublicacionHTML = strPublicacionHTML + "<li class='gallery-item-description'><span class='visually-hidden'>Descripcion:</span><p style='color: #fff;'>" + publicacion_actual.Descripcion + "</p></li>";
                        //strPublicacionHTML = strPublicacionHTML + "<li class='gallery-item-likes'><span class='visually-hidden'>Likes:</span><i class='fas fa-heart' aria-hidden='true'></i>0</li>";
                        //strPublicacionHTML = strPublicacionHTML + "<li class='gallery-item-comments'><span class='visually-hidden'>Comments:</span><i class='fas fa-comment' aria-hidden='true'></i>0</li>";
                        strPublicacionHTML = strPublicacionHTML + "</ul></div></div></div>";


                        strPublicacionesHTML = strPublicacionesHTML + strPublicacionHTML;
                    }
                    publicaciones.next();
                }
            }
        }

        protected void EditarPerfilBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Profile-edit.aspx");
        }

        protected void EliminarPerfilBtn_Click(object sender, EventArgs e)
        {
            int id_usuario = (int)Session["id_usuario"];
            usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];
            Usuario usuarioEliminar = new Usuario();
            usuarioEliminar = (Usuario)usuariosRegistrados.buscar(id_usuario);
            usuariosRegistrados.eliminar(usuarioEliminar);
            Session["usuariosRegistrados"] = usuariosRegistrados;
            Session["id_usuario"] = null;
            Response.Redirect("/Login.aspx");
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