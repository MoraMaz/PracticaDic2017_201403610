using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{
    class Cola<T>
    {
        private NodoCola<T> inicio, fin;
        private int tamano;

        public Cola()
        {
            inicio = null;
            fin = null;
            tamano = 0;
        }

        public void Enqueue(T dato)
        {
            if (tamano == 0)
            {
                inicio = new NodoCola<T>(dato);
                fin = inicio;
            }
            else
            {
                fin.Siguiente = new NodoCola<T>(dato);
                fin = fin.Siguiente;
            }
            tamano++;
        }

        public NodoCola<T> Dequeue()
        {
            if (tamano == 0)
                return null;
            NodoCola<T> cabeza = inicio;
            inicio = inicio.Siguiente;
            tamano--;
            return cabeza;
        }

        public NodoCola<T> Peek()
        {
            return inicio;
        }

        public int Size()
        {
            return tamano;
        }
    }
}
