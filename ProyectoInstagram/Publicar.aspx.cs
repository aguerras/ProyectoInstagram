using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using EstructuraDeDatos;
using ProyectoInstagram.Model;

namespace ProyectoInstagram
{
    public partial class Publicar : System.Web.UI.Page
    {
        public LinkedListDouble publicaciones;
        Usuario usuario = new Usuario();
        public ArbolAVL usuariosRegistrados = new ArbolAVL();

        protected void Page_Load(object sender, EventArgs e)
        {
            ObtenerSesion();
        }

        protected void UploadFile(object sender, EventArgs e)
        {
            ObtenerSesion();
            try
            {
                string folderPath = Server.MapPath("~/Files/");

                //Check whether Directory (Folder) exists.
                if (!Directory.Exists(folderPath))
                {
                    //If Directory (Folder) does not exists Create it.
                    Directory.CreateDirectory(folderPath);
                }

                //Save the File to the Directory (Folder).
                FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

                //Display the Picture in Image control.
                Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);
            }
            catch (Exception)
            {

            }
        }
        protected void SubirImagenBtn_Click(object sender, EventArgs e)
        {
            int id = 1;
            String descripcion = txt_descripcion.Text;
            String imagen = Image1.ImageUrl;
            DateTime fecha = DateTime.Now;
            Publicacion ultimo = null;
            try
            {
                ultimo = (Publicacion)publicaciones.getUltimo();
                
            }
            catch (Exception)
            {

            }
            if (ultimo != null)
            {
                id = ultimo.Id_publicacion + 1;
            }
            Publicacion publicacion = new Publicacion(id, usuario.Nombre_usuario, descripcion, imagen, fecha);
            publicaciones.insertar(publicacion);
            Session["publicaciones"] = publicaciones;
            Response.Redirect("/Profile");
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