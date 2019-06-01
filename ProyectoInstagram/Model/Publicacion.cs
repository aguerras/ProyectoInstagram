using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoInstagram.Model
{
    public class Publicacion
    {
        private int id_publicacion;
        private String user_name;
        private String descripcion;
        private String imagen;
        private DateTime fecha;

        public Publicacion(int id_publicacion, String user_name, String descripcion, String imagen, DateTime fecha)
        {
            this.id_publicacion = id_publicacion;
            this.user_name = user_name;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.fecha = fecha;
        }

        public int Id_publicacion { get => id_publicacion; set => id_publicacion = value; }
        public String User_name { get => user_name; set => user_name = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
        public String Imagen { get => imagen; set => imagen = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}