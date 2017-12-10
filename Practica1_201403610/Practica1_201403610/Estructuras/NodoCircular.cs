using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{
    class NodoCircular<T>
    {
        private T dato;
        private NodoCircular<T> anterior, siguiente;

        public NodoCircular(T dato)
        {
            this.dato = dato;
            anterior = this;
            siguiente = this;
        }

        public NodoCircular(T dato, NodoCircular<T> anterior, NodoCircular<T> siguiente)
        {
            this.dato = dato;
            this.anterior = anterior;
            this.siguiente = siguiente;
        }

        public T Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoCircular<T> Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public NodoCircular<T> Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
