using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{
    class Matriz
    {
        private NodoMatriz inicio;
        private int x, y;

        public Matriz(int x, int y)
        {
            inicio = new NodoMatriz(0, 0, 0);
            this.x = x;
            this.y = y;
        }

        private void generarMatriz()
        {
            int j;
            NodoMatriz anterior, actual;
            j = y;
            crearFila(inicio, 0);
            anterior = null;
            actual = inicio;
            while (j > 0)
            {
                actual.Abajo = new NodoMatriz(0, actual.getPosition()[0], actual.getPosition()[1] + 1);
                anterior = actual;
                actual = actual.Abajo;
                actual.Arriba = anterior;
                crearFila(actual, actual.getPosition()[1]);
                j--;
            }
        }

        private void crearFila(NodoMatriz actual, int fila)
        {
            int i;
            NodoMatriz anterior = null;
            for (i = 0; i < x - 1; i++)
            {
                actual.Derecha = new NodoMatriz(0, i + 1, fila);
                anterior = actual;
                actual = actual.Derecha;
                actual.Izquierda = anterior;
            }
            actual.Izquierda = anterior;
        }

    }
}
