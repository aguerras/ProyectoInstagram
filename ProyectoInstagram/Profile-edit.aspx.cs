using EstructuraDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ProyectoInstagram
{
    public partial class Profile_edit : System.Web.UI.Page
    {
        public ArbolAVL usuariosRegistrados = new ArbolAVL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id_usuario"] == null)
                {
                    Response.Redirect("/Login.aspx");
                }

                int id_usuario = (int)Session["id_usuario"];
                usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];

                Usuario usuario = new Usuario();
                usuario = (Usuario)usuariosRegistrados.buscar(id_usuario);
                nombre.Text = usuario.Nombre;
                nombre_usuario.Text = usuario.Nombre_usuario;
                bio.Text = usuario.Bio;
                fecha_nacimiento.Text = usuario.Fecha_nacimiento;
                password.Text = usuario.Password;
                
                Image1.ImageUrl = usuario.Foto;
            }
        }

        protected void btn_editar_perfil (object sender, EventArgs e)
        {
            //Guardar imagen
            string savePath = "/Imagen/default-user.png";
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
                savePath = "/Files/" + Path.GetFileName(foto.FileName);
                foto.SaveAs(folderPath + Path.GetFileName(foto.FileName));
            }
            catch (Exception)
            {

            }


            int id_usuario = (int)Session["id_usuario"];
            usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];
            
            Usuario usuarioModificar = new Usuario();
            Usuario usuarioEliminar = new Usuario();

            usuarioEliminar = (Usuario)usuariosRegistrados.buscar(id_usuario);

            usuarioModificar.Id_usuario = id_usuario;
            usuarioModificar.Nombre = nombre.Text;
            usuarioModificar.Nombre_usuario = usuarioEliminar.Nombre_usuario;
            usuarioModificar.Bio = bio.Text;
            usuarioModificar.Fecha_nacimiento = fecha_nacimiento.Text;
            usuarioModificar.Password = password.Text;
            usuarioModificar.Foto = savePath;

            usuariosRegistrados.eliminar(usuarioEliminar);
            usuariosRegistrados.insertar(usuarioModificar);
            Session["usuariosRegistrados"] = usuariosRegistrados;

            Response.Redirect("/Profile-edit.aspx");
        }
        
    }
}