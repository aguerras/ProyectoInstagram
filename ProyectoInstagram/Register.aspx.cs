using EstructuraDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoInstagram
{
    public partial class Register : System.Web.UI.Page
    {
        public ArbolAVL usuariosRegistrados = new ArbolAVL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (Session["id_usuario"] != null)
            {
                Server.Transfer("/Profile.aspx");
            }
            if (!IsPostBack)
            {
            }
        }

        protected void btn_registrar(object sender, EventArgs e)
        {
            if (Session["usuariosRegistrados"] != null) {
                usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];
            }
            //Registrar usuario.
            int id_usuario = 1;
            if (usuariosRegistrados.getRaiz() != null)
            {
                Usuario usrTmp = new Usuario();
                usrTmp = (Usuario)usuariosRegistrados.getMayor(usuariosRegistrados.getNodoRaiz());
                id_usuario = usrTmp.Id_usuario + 1;
            }
            String nombre = Request.Form["nombre"];
            String fecha_nacimiento = Request.Form["fecha_nacimiento"];
            String nombre_usuario = Request.Form["nombre_usuario"];
            String password = Request.Form["password"];
            Usuario usuario = new Usuario(id_usuario,nombre,fecha_nacimiento,"",nombre_usuario,password,"");
            usuariosRegistrados.insertar(usuario);
            Session["usuariosRegistrados"] = usuariosRegistrados;
            Session["id_usuario"] = id_usuario;

            Server.Transfer("Profile-edit.aspx");
        }

        //Función para validar si existe un nombre de usuario de los usuarios ya registrados.
        protected void valid_user_name(object source, ServerValidateEventArgs args)
        {
            try
            {
                if (Session["usuariosRegistrados"] != null)
                {
                    usuariosRegistrados = (ArbolAVL)Session["usuariosRegistrados"];
                    //Recorro el arbol en preorden(pudo haber sido cualquiera) para obtener un string de todos los usernames existentes y luego validarlo con contains.
                    String usuariosExistentes = ArbolAVL.preorden(usuariosRegistrados.getNodoRaiz());
                    args.IsValid = !usuariosExistentes.Contains(args.Value);
                }
            }
            catch (Exception e)
            {
                args.IsValid = false;
            }
        }
    }
}