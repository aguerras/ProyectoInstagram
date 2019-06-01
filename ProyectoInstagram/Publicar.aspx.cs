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
        public String user_name; 

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
            Publicacion publicacion = new Publicacion(id, user_name, descripcion, imagen, fecha);
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
                user_name = (String)Session["user_name"];
                if (user_name == null)
                {
                    Response.Redirect("/Login");
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