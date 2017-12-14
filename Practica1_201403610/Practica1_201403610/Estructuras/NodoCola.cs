using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{
    class NodoCola<T>
    {
        private T dato;
        private NodoCola<T> siguiente;

        public NodoCola(T dato)
        {
            this.dato = dato;
            siguiente = null;
        }

        public T Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoCola<T> Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
