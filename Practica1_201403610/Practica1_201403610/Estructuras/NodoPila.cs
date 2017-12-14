using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{
    class NodoPila<T>
    {
        private T dato;
        private NodoPila<T> abajo;

        public NodoPila(T dato)
        {
            this.dato = dato;
            this.abajo = null;
        }

        public NodoPila(T dato, NodoPila<T> abajo)
        {
            this.dato = dato;
            this.abajo = abajo;
        }

        public NodoPila<T> Abajo
        {
            get { return abajo; }
            set { abajo = value; }
        }

        public T Dato
        {
            get { return dato; }
            set { dato = value; }
        }
    }
}
