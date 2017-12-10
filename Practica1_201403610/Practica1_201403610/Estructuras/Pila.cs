using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{
    class Pila<T>
    {
        private NodoPila<T> top;
        private int tamano;

        public Pila()
        {
            top = null;
            tamano = 0;
        }

        public void Push(T dato)
        {
            if (top == null)
                top = new NodoPila<T>(dato);
            else
                top = new NodoPila<T>(dato, top);
            tamano++;
        }

        public NodoPila<T> Pop()
        {
            if (tamano == 0)
                return null;
            NodoPila<T> cabeza = top;
            top = top.Abajo;
            tamano--;
            return cabeza;
        }

        public NodoPila<T> Peek()
        {
            return top;
        }

        public int Size()
        {
            return tamano;
        }
    }
}
