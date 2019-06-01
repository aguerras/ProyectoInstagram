using EstructuraDeDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace ProyectoInstagram
{
    public partial class Login : System.Web.UI.Page
    {
        public ArbolAVL usuariosRegistrados = new ArbolAVL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_usuario"] != null)
            {
                Response.Redirect("/Profile.aspx");
            }
            

            if (Session["usuariosRegistrados"] == null)
            {
                Usuario usuario1 = new Usuario(1, "Kevin Guerra", "07-05-1997", "", "kguerra", "123", "/Images/default-user.png");
                usuariosRegistrados.insertar(usuario1);
                Usuario usuario2 = new Usuario(2, "Alexis Guerra", "07-05-1997", "", "aguerra", "123", "/Images/default-user.png");
                usuariosRegistrados.insertar(usuario2);
                Usuario usuario3 = new Usuario(3, "Fredy Guerra", "07-05-1997", "", "fguerra", "123", "/Images/default-user.png");
                usuariosRegistrados.insertar(usuario3);
                Usuario usuario4 = new Usuario(4, "Hydra L", "07-05-1997", "", "hl", "123", "/Images/default-user.png");
                usuariosRegistrados.insertar(usuario4);
                Usuario usuario5 = new Usuario(5, "Naix L", "07-05-1997", "", "nl", "123", "/Images/default-user.png");
                usuariosRegistrados.insertar(usuario5);
                Session["usuariosRegistrados"] = usuariosRegistrados;
            }
        }

        protected void btn_login(object sender, EventArgs e)
        {
            //Verificar datos del login.

            usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];
            Usuario usuario = new Usuario();
            usuario = (Usuario)usuariosRegistrados.igualar(nombre_usuario.Text, password.Text);
            if (usuario == null)
            {
                reqUserName.IsValid = false;
                reqPassword.IsValid = false;
            }
            else
            {
                Session["id_usuario"] = usuario.Id_usuario;
                Response.Redirect("/Profile.aspx");
            }
        }

        protected void btn_xml(object sender, EventArgs e)
        {
            usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];

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
                string savePath = folderPath + Path.GetFileName(fileXml.FileName);
                fileXml.SaveAs(savePath);

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(folderPath + fileXml.FileName);
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/USERDATA/USER");
                int id = 0;
                string nombreUsuario = "", nombreCompleto = "", fotoPath = "", cumpleanios = "";
                foreach (XmlNode node in nodeList)
                {
                    Usuario usrTmp = new Usuario();
                    usrTmp = (Usuario)usuariosRegistrados.getMayor(usuariosRegistrados.getNodoRaiz());
                    id = usrTmp.Id_usuario + 1;

                    nombreUsuario = node.SelectSingleNode("USERNAME").InnerText;
                    nombreCompleto = node.SelectSingleNode("FULLNAME").InnerText;
                    fotoPath = node.SelectSingleNode("PROFILEIMAGE").InnerText;
                    cumpleanios = node.SelectSingleNode("BIRTHDATE").InnerText;

                    Usuario usuario = new Usuario(id, nombreCompleto, cumpleanios, "", nombreUsuario, "123", fotoPath);
                    usuariosRegistrados.insertar(usuario);
                }
                Session["usuariosRegistrados"] = usuariosRegistrados;
            } catch (Exception){}

            Response.Redirect("/Profile-edit.aspx");
        }
    }
}