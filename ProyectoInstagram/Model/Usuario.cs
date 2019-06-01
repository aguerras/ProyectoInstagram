using EstructuraDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoInstagram
{
    public class Usuario : Comparador
    {
        private int id_usuario;
        private String nombre;
        private String fecha_nacimiento;
        private String bio;
        private String nombre_usuario;
        private String password;
        private String foto;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Bio { get => bio; set => bio = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Foto { get => foto; set => foto = value; }

        public Usuario()
        {
        }

        public Usuario(int id_usuario, string nombre, string fecha_nacimiento, string bio, string nombre_usuario, string password, string foto)
        {
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.fecha_nacimiento = fecha_nacimiento;
            this.bio = bio;
            this.nombre_usuario = nombre_usuario;
            this.password = password;
            this.foto = foto;
        }

        bool Comparador.igualQue(Object valor)
        {
            return id_usuario == (int)valor;
        }

        bool Comparador.menorQue(Object op2)
        {
            Usuario p2 = (Usuario)op2;
            return id_usuario < p2.id_usuario;
        }

        bool Comparador.menorIgualQue(Object op2)
        {
            Usuario p2 = (Usuario)op2;
            return id_usuario <= p2.id_usuario;
        }

        bool Comparador.mayorQue(Object op2)
        {
            Usuario p2 = (Usuario)op2;
            return id_usuario > p2.id_usuario;
        }

        bool Comparador.mayorIgualQue(Object op2)
        {
            Usuario p2 = (Usuario)op2;
            return id_usuario > p2.id_usuario;
        }

        bool Comparador.igualar(Object valor1, Object valor2)
        {
            String nombre_usuario_v = (String)valor1;
            String password_v = (String)valor2;
            if (nombre_usuario == nombre_usuario_v && password == password_v)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "(" + nombre_usuario + ")";
        }
    }
}