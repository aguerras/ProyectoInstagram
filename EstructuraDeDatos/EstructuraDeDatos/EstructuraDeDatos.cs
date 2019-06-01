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

    public class NodoArbolAVL
    {
        private Object valor;
        private int factor_equilibrio;
        private NodoArbolAVL izquierdo;
        private NodoArbolAVL derecho;

        public NodoArbolAVL()
        {
            this.valor = null;
            this.factor_equilibrio = 0;
            this.izquierdo = this.derecho = null;
        }

        public NodoArbolAVL(Object valor)
        {
            this.valor = valor;
            this.factor_equilibrio = 0;
            this.izquierdo = this.derecho = null;
        }

        public NodoArbolAVL(Object valor, NodoArbolAVL izquierdo, NodoArbolAVL derecho)
        {
            this.valor = valor;
            this.factor_equilibrio = 0;
            this.izquierdo = izquierdo;
            this.derecho = derecho;
        }

        public Object getValor()
        {
            return this.valor;
        }

        public void setValor(Object valor)
        {
            this.valor = valor;
        }

        public int getFactorEquilibrio()
        {
            return this.factor_equilibrio;
        }

        public void setFactorEquilibrio(int factor_equilibrio)
        {
            this.factor_equilibrio = factor_equilibrio;
        }

        public NodoArbolAVL getIzquierdo()
        {
            return this.izquierdo;
        }

        public void setIzquierdo(NodoArbolAVL izquierdo)
        {
            this.izquierdo = izquierdo;
        }

        public NodoArbolAVL getDerecho()
        {
            return this.derecho;
        }

        public void setDerecho(NodoArbolAVL derecho)
        {
            this.derecho = derecho;
        }

        public string visitar()
        {
            return valor.ToString();
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

    public class Logical
    {
        Boolean v;
        public Logical(Boolean f)
        {
            v = f;
        }
        public void setLogical(Boolean f)
        {
            v = f;
        }
        public Boolean booleanValue()
        {
            return v;
        }
    }

    public interface Comparador
    {
        bool igualQue(Object q);
        bool menorQue(Object q);
        bool menorIgualQue(Object q);
        bool mayorQue(Object q);
        bool mayorIgualQue(Object q);
        bool igualar(Object p, Object q);
    }


    public class HashTable
    {
        Object[] tabla = new Object[1000];


    }

    public class ArbolAVL
    {
        private NodoArbolAVL raiz;

        public ArbolAVL()
        {
            this.raiz = null;
        }

        public ArbolAVL(Object valor)
        {
            this.raiz = new NodoArbolAVL(valor);
        }

        public Object getRaiz()
        {
            try
            {
                return this.raiz.getValor();
            }
            catch (NullReferenceException e)
            {
                return null;
            }
        }

        private NodoArbolAVL rotacionII(NodoArbolAVL nodo, NodoArbolAVL nodo2)
        {
            nodo.setIzquierdo(nodo2.getDerecho());
            nodo2.setDerecho(nodo);
            // actualización de los factores de equilibrio
            if (nodo2.getFactorEquilibrio() == -1) // se cumple en la inserción
            {
                nodo.setFactorEquilibrio(0);
                nodo2.setFactorEquilibrio(0);
            }
            else
            {
                nodo.setFactorEquilibrio(-1);
                nodo2.setFactorEquilibrio(-1);
            }
            return nodo2;
        }

        private NodoArbolAVL rotacionDD(NodoArbolAVL nodo, NodoArbolAVL nodo2)
        {
            nodo.setDerecho(nodo2.getIzquierdo());
            nodo2.setIzquierdo(nodo);
            // actualización de los factores de equilibrio
            if (nodo2.getFactorEquilibrio() == +1) // se cumple en la inserción
            {
                nodo.setFactorEquilibrio(0);
                nodo2.setFactorEquilibrio(0);
            }
            else
            {
                nodo.setFactorEquilibrio(+1);
                nodo2.setFactorEquilibrio(+1);
            }
            return nodo2;
        }

        private NodoArbolAVL rotacionID(NodoArbolAVL nodo, NodoArbolAVL nodo2)
        {
            NodoArbolAVL nodo3;
            nodo3 = (NodoArbolAVL)nodo2.getDerecho();
            nodo.setIzquierdo(nodo3.getDerecho());
            nodo3.setDerecho(nodo);
            nodo2.setDerecho(nodo3.getIzquierdo());
            nodo3.setIzquierdo(nodo2);
            // actualización de los factores de equilibrio
            if (nodo3.getFactorEquilibrio() == +1)
                nodo2.setFactorEquilibrio(-1);
            else
                nodo2.setFactorEquilibrio(0);
            if (nodo3.getFactorEquilibrio() == -1)
                nodo.setFactorEquilibrio(1);
            else
                nodo.setFactorEquilibrio(0);
            nodo3.setFactorEquilibrio(0);
            return nodo3;
        }

        private NodoArbolAVL rotacionDI(NodoArbolAVL nodo, NodoArbolAVL nodo2)
        {
            NodoArbolAVL nodo3;
            nodo3 = (NodoArbolAVL)nodo2.getIzquierdo();
            nodo.setDerecho(nodo3.getIzquierdo());
            nodo3.setIzquierdo(nodo);
            nodo2.setIzquierdo(nodo3.getDerecho());
            nodo3.setDerecho(nodo2);
            // actualización de los factores de equilibrio
            if (nodo3.getFactorEquilibrio() == +1)
                nodo.setFactorEquilibrio(-1);
            else
                nodo.setFactorEquilibrio(0);
            if (nodo3.getFactorEquilibrio() == -1)
                nodo2.setFactorEquilibrio(1);
            else
                nodo2.setFactorEquilibrio(0);
            nodo3.setFactorEquilibrio(0);
            return nodo3;
        }

        public void insertar(Object valor)//throws Exception
        {
            Comparador dato;
            Logical h = new Logical(false); // intercambia un valor booleano
            dato = (Comparador)valor;
            this.raiz = insertarAvl(this.raiz, dato, h);
        }

        private NodoArbolAVL insertarAvl(NodoArbolAVL raiz, Comparador dt, Logical h)
        {
            NodoArbolAVL n1;
            if (raiz == null)
            {
                raiz = new NodoArbolAVL(dt);
                h.setLogical(true);
            }
            else if (dt.menorQue(raiz.getValor()))
            {
                NodoArbolAVL iz;
                iz = insertarAvl((NodoArbolAVL)raiz.getIzquierdo(), dt, h);
                raiz.setIzquierdo(iz);
                // regreso por los nodos del camino de búsqueda
                if (h.booleanValue())
                {
                    // decrementa el fe por aumentar la altura de rama izquierda
                    switch (raiz.getFactorEquilibrio())
                    {
                        case 1:
                            raiz.setFactorEquilibrio(0);
                            h.setLogical(false);
                            break;
                        case 0:
                            raiz.setFactorEquilibrio(-1);
                            break;
                        case -1: // aplicar rotación a la izquierda
                            n1 = (NodoArbolAVL)raiz.getIzquierdo();
                            if (n1.getFactorEquilibrio() == -1)
                                raiz = rotacionII(raiz, n1);
                            else
                                raiz = rotacionID(raiz, n1);
                            h.setLogical(false);
                            break;
                    }
                }
            }
            else if (dt.mayorQue(raiz.getValor()))
            {
                NodoArbolAVL dr;
                dr = insertarAvl((NodoArbolAVL)raiz.getDerecho(), dt, h);
                raiz.setDerecho(dr);
                // regreso por los nodos del camino de búsqueda
                if (h.booleanValue())
                {
                    // incrementa el fe por aumentar la altura de rama izquierda
                    switch (raiz.getFactorEquilibrio())
                    {
                        case 1: // aplicar rotación a la derecha
                            n1 = (NodoArbolAVL)raiz.getDerecho();
                            if (n1.getFactorEquilibrio() == +1)
                                raiz = rotacionDD(raiz, n1);
                            else
                                raiz = rotacionDI(raiz, n1);
                            h.setLogical(false);
                            break;
                        case 0:
                            raiz.setFactorEquilibrio(+1);
                            break;
                        case -1:
                            raiz.setFactorEquilibrio(0);
                            h.setLogical(false);
                            break;
                    }
                }
            }
            else
                throw new Exception("No puede haber claves repetidas ");
            return raiz;
        }

        public void eliminar(Object valor) //throws Exception
        {
            Comparador dato;
            dato = (Comparador)valor;
            Logical flag = new Logical(false);
            raiz = borrarAvl(raiz, dato, flag);
        }

        private NodoArbolAVL borrarAvl(NodoArbolAVL r, Comparador clave, Logical cambiaAltura) //throws Exception
        {
            if (r == null)
            {
                throw new Exception(" Nodo no encontrado ");
            }
            else if (clave.menorQue(r.getValor()))
            {
                NodoArbolAVL iz;
                iz = borrarAvl((NodoArbolAVL)r.getIzquierdo(), clave, cambiaAltura);
                r.setIzquierdo(iz);
                if (cambiaAltura.booleanValue())
                    r = equilibrar1(r, cambiaAltura);
            }
            else if (clave.mayorQue(r.getValor()))
            {
                NodoArbolAVL dr;
                dr = borrarAvl((NodoArbolAVL)r.getDerecho(), clave, cambiaAltura);
                r.setDerecho(dr);
                if (cambiaAltura.booleanValue())
                    r = equilibrar2(r, cambiaAltura);
            }
            else // Nodo encontrado
            {
                NodoArbolAVL q;
                q = r; // nodo a quitar del árbol
                if (q.getIzquierdo() == null)
                {
                    r = (NodoArbolAVL)q.getDerecho();
                    cambiaAltura.setLogical(true);
                }
                else if (q.getDerecho() == null)
                {
                    r = (NodoArbolAVL)q.getIzquierdo();
                    cambiaAltura.setLogical(true);
                }
                else
                { // tiene rama izquierda y derecha
                    NodoArbolAVL iz;
                    iz = reemplazar(r, (NodoArbolAVL)r.getIzquierdo(), cambiaAltura);
                    r.setIzquierdo(iz);
                    if (cambiaAltura.booleanValue())
                        r = equilibrar1(r, cambiaAltura);
                }
                q = null;
            }
            return r;
        }

        private NodoArbolAVL reemplazar(NodoArbolAVL n, NodoArbolAVL act, Logical cambiaAltura)
        {
            if (act.getDerecho() != null)
            {
                NodoArbolAVL d;
                d = reemplazar(n, (NodoArbolAVL)act.getDerecho(), cambiaAltura);
                act.setDerecho(d);
                if (cambiaAltura.booleanValue())
                    act = equilibrar2(act, cambiaAltura);
            }
            else
            {
                n.setValor(act.getValor());
                n = act;
                act = (NodoArbolAVL)act.getIzquierdo();
                n = null;
                cambiaAltura.setLogical(true);
            }
            return act;
        }

        private NodoArbolAVL equilibrar1(NodoArbolAVL n, Logical cambiaAltura)
        {
            NodoArbolAVL n1;
            switch (n.getFactorEquilibrio())
            {
                case -1:
                    n.setFactorEquilibrio(0);
                    break;
                case 0:
                    n.setFactorEquilibrio(1);
                    cambiaAltura.setLogical(false);
                    break;
                case +1: //se aplicar un tipo de rotación derecha
                    n1 = (NodoArbolAVL)n.getDerecho();
                    if (n1.getFactorEquilibrio() >= 0)
                    {
                        if (n1.getFactorEquilibrio() == 0) //la altura no vuelve a disminuir
                            cambiaAltura.setLogical(false);
                        n = rotacionDD(n, n1);
                    }
                    else
                        n = rotacionDI(n, n1);
                    break;
            }
            return n;
        }

        private NodoArbolAVL equilibrar2(NodoArbolAVL n, Logical cambiaAltura)
        {
            NodoArbolAVL n1;
            switch (n.getFactorEquilibrio())
            {
                case -1: // Se aplica un tipo de rotación izquierda
                    n1 = (NodoArbolAVL)n.getIzquierdo();
                    if (n1.getFactorEquilibrio() <= 0)
                    {
                        if (n1.getFactorEquilibrio() == 0)
                            cambiaAltura.setLogical(false);
                        n = rotacionII(n, n1);
                    }
                    else
                        n = rotacionID(n, n1);
                    break;
                case 0:
                    n.setFactorEquilibrio(-1);
                    cambiaAltura.setLogical(false);
                    break;
                case +1:
                    n.setFactorEquilibrio(0);
                    break;
            }
            return n;
        }

        //Nodo raiz
        public NodoArbolAVL getNodoRaiz()
        {
            return this.raiz;
        }

        //Obtener el nodo mayor.
        public Object getMayor(NodoArbolAVL r) {
            if (r.getDerecho() != null)
            {
                return getMayor(r.getDerecho());
            } else
            {
                return r.getValor();
            }
        }

        //Buscar nodo
        public Object buscar(Object valor)
        {
            if (raiz == null)
                return null;
            else
                return buscar(raiz, valor);
        }
        protected Object buscar(NodoArbolAVL raizSub, Object valor)
        {
            if (raizSub == null)
                return null;

            Comparador comparador;
            comparador = (Comparador)raizSub.getValor();

            if (comparador.igualQue(valor))
                return raizSub.getValor();

            if (buscar(raizSub.getIzquierdo(), valor) != null)
            {
                return buscar(raizSub.getIzquierdo(), valor);
            }
            else
            {
                return buscar(raizSub.getDerecho(), valor);
            }
        }

        //Igualar 2 valores.
        public Object igualar(Object valor1, Object valor2)
        {
            if (raiz == null)
                return null;
            else
                return igualar(raiz, valor1, valor2);
        }
        protected Object igualar(NodoArbolAVL raizSub, Object valor1, Object valor2)
        {
            if (raizSub == null)
                return null;

            Comparador comparador;
            comparador = (Comparador)raizSub.getValor();

            if (comparador.igualar(valor1, valor2))
                return raizSub.getValor();

            if (igualar(raizSub.getIzquierdo(), valor1, valor2) != null)
            {
                return igualar(raizSub.getIzquierdo(), valor1, valor2);
            }
            else
            {
                return igualar(raizSub.getDerecho(), valor1, valor2);
            }
        }

        /////////////////////////////////
        /// <summary>
        /// Comprueba el estatus del árbol
        /// </summary>
        /// <returns></returns>
        bool esVacio()
        {
            return raiz == null;
        }

        public static string preorden(NodoArbolAVL r)
        {
            if (r != null)
            {
                return r.visitar() + preorden(r.getIzquierdo()) + preorden(r.getDerecho());
            }
            return "";
        }

        // Recorrido de un árbol binario en inorden
        public static string inorden(NodoArbolAVL r)
        {
            if (r != null)
            {
                return inorden(r.getIzquierdo()) + r.visitar() + inorden(r.getDerecho());
            }
            return "";
        }

        // Recorrido de un árbol binario en postorden
        public static string postorden(NodoArbolAVL r)
        {
            if (r != null)
            {
                return postorden(r.getIzquierdo()) + postorden(r.getDerecho()) + r.visitar();
            }
            return "";
        }

        //Devuelve el número de nodos que tiene el árbol
        public static int numNodos(NodoArbolAVL raiz)
        {
            if (raiz == null)
                return 0;
            else
                return 1 + numNodos(raiz.getIzquierdo()) +
                numNodos(raiz.getDerecho());
        }
    }
}
