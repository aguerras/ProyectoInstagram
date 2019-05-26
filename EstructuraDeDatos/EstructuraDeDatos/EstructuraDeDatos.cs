using System;

namespace EstructuraDeDatos
{
    class Nodo
    {
        private Object valor;
        private Nodo enlaceSiguiente;
        private Nodo enlaceAnterior;

        public Nodo()
        {
            valor = null;
            enlaceSiguiente = null;
            enlaceAnterior = null;
        }

        public Nodo(Object valor)
        {
            this.valor = valor;
            this.enlaceSiguiente = null;
            this.enlaceAnterior = null;
        }

        public Object getValor()
        {
            return this.valor;
        }

        public void setValor(Object valor)
        {
            this.valor = valor;
        }

        public Nodo getEnlaceSiguiente()
        {
            return this.enlaceSiguiente;
        }

        public void setEnlaceSiguiente(Nodo enlaceSiguiente)
        {
            this.enlaceSiguiente = enlaceSiguiente;
        }

        public Nodo getEnlaceAnterior()
        {
            return this.enlaceAnterior;
        }

        public void setEnlaceAnterior(Nodo enlaceAnterior)
        {
            this.enlaceAnterior = enlaceAnterior;
        }
    }

    public class LinkedList
    {
        private Nodo primero;
        private Nodo actual;
        private Nodo ultimo;

        public LinkedList()
        {
            primero = null;
            actual = null;
            ultimo = null;
        }

        public void insertar(Object dato)
        {
            Nodo nodo = new Nodo(dato);
            if (primero == null)
            {
                primero = nodo;
                actual = nodo;
                ultimo = nodo;
            }
            else
            {
                ultimo.setEnlaceSiguiente(nodo);
                ultimo = nodo;
            }
        }

        public Object getActual()
        {
            return actual.getValor();
        }
        public Object getEnlaceActual()
        {
            return actual.getEnlaceSiguiente();
        }
        public Object getUltimo()
        {
            return ultimo.getValor();
        }
        public void next()
        {
            actual = actual.getEnlaceSiguiente();
        }
    }

    public class LinkedListDouble
    {
        private Nodo primero;
        private Nodo actual;
        private Nodo ultimo;

        public LinkedListDouble()
        {
            primero = null;
            actual = null;
            ultimo = null;
        }

        public LinkedListDouble Clone()
        {
            LinkedListDouble newList = new LinkedListDouble();
            Nodo actualList = primero;
            while (actualList != null)
            {
                newList.insertar(actualList.getValor());
                actualList = actualList.getEnlaceSiguiente();
            }
            return newList;
        }

        public void insertar(Object dato)
        {
            Nodo nodo = new Nodo(dato);
            if (primero == null)
            {
                primero = nodo;
                actual = nodo;
                ultimo = nodo;
            }
            else
            {
                ultimo.setEnlaceSiguiente(nodo);
                Nodo nodoTemporal = ultimo;
                ultimo = nodo;
                ultimo.setEnlaceAnterior(nodoTemporal);
            }
        }

        public Object getActual()
        {
            if (actual != null) {
                return actual.getValor();
            } else
            {
                return null;
            }
        }
        public Object getEnlaceActual()
        {
            return actual.getEnlaceSiguiente();
        }   
        public Object getUltimo()
        {
            return ultimo.getValor();
        }
        public void next()
        {
            if (actual.getEnlaceSiguiente() != null) {
                actual = actual.getEnlaceSiguiente();
            } else
            {
                actual = null;
            }
        }
        public void iniciarPrimero()
        {
            actual = primero;
        }
    }

    public class Cola
    {
        private Nodo primero;
        private Nodo ultimo;

        public Cola()
        {
            primero = null;
            ultimo = null;
        }

        public Cola Clone()
        {
            Cola newList = new Cola();
            Nodo actualList = primero;
            while (actualList != null)
            {
                newList.push(actualList.getValor());
                actualList = actualList.getEnlaceSiguiente();
            }
            return newList;
        }

        public void push(Object valor)
        {
            Nodo nodo = new Nodo(valor);
            if (primero == null)
            {
                primero = nodo;
                
            } else
            {
                ultimo.setEnlaceSiguiente(nodo);
            }
            ultimo = nodo;
        }
        public Object pop()
        {
            Object objectCola;
            if (primero != null)
            {
                objectCola = primero.getValor();
                primero = primero.getEnlaceSiguiente();
            }
            else
            {
                throw new Exception("Error al eliminar en una cola vacia");
            }
            return objectCola;
        }

        public Object getPrimero()
        {
            if (primero != null)
            {
                return primero.getValor();
            }
            else
            {
                return null;
            }
        }

        public void borrarCola()
        {
            for (; primero != null;)
            {
                primero = primero.getEnlaceSiguiente();
            }
        }
    }

    public class Pila
    {
        private Nodo primero;

        public Pila()
        {
            primero = null;
        }

        public Pila Clone()
        {
            Pila newList = new Pila();
            Nodo actualList = primero;
            while (actualList != null)
            {
                newList.push(actualList.getValor());
                actualList = actualList.getEnlaceSiguiente();
            }
            return newList;
        }

        public Object pop()
        {
            Object aux = primero.getValor();
            primero = primero.getEnlaceSiguiente();
            return aux;
        }

        public void push(Object valor)
        {
            Nodo nodo = new Nodo(valor);
            nodo.setEnlaceSiguiente(primero);
            primero = nodo;
        }
        public Object getPrimero()
        {
            if (primero != null)
            {
                return primero.getValor();
            }
            else
            {
                return null;
            }
        }
    }
}
