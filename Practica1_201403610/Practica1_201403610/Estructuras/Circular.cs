using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{
    class Circular<T>
    {
        private NodoCircular<T> inicio;
        private int tamano;

        public Circular()
        {
            inicio = null;
            tamano = 0;
        }

        public void Agregar(T dato)
        {
            if (inicio == null)
            {
                inicio = new NodoCircular<T>(dato);
            }
            else
            {
                NodoCircular<T> nuevo = new NodoCircular<T>(dato, inicio.Anterior, inicio);
                nuevo.Anterior.Siguiente = nuevo;
                inicio.Anterior = nuevo;
            }
            tamano++;
        }

        public int Size()
        {
            return tamano;
        }
    }
}
