using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Estructuras
{    
    /* RECORDATORIO DE LA MATRIZ
     * Crear una matriz "a" de 2 filas por 3 columnas:
     * Estructuras.Matriz a = new Estructuras.Matriz(2, 3);
     * 
     * * El método constructor de la matriz recibe dos enteros: 
     *   cantidad de filas y cantidad de columnas, en ese orden.
     *      NOTA:
     *          cantidad de filas = tamaño en y
     *          cantidad de columnas = tamaño en x *
     * 
     * - Posiciones disponibles para el caso de esta matriz:
     * - (0,0) (0,1) (0,2) (1,0) (1,1) (1,2)
     * 
     * Insertar los números del 0 al 2 en la primera fila (fila 0):
     * a.set(0, 0, 0);
     * a.set(1, 0, 1);
     * a.set(2, 0, 2);
     * 
     * Insertar los números del 3 al 5 en la segunda fila (fila 1):
     * a.set(3, 1, 0);
     * a.set(4, 1, 1);
     * a.set(5, 1, 2);
     * 
     * * El método set de la matriz recibe tres enteros: dato, 
     *   fila y columna, en ese orden.
     *      NOTA: 
     *          fila = posición en y
     *          columna = posicion en x *
     */

    class Matriz
    {
        private NodoMatriz inicio;
        private int filas, columnas;

        public Matriz(int filas, int columnas)
        {
            inicio = new NodoMatriz(0, 0, 0);
            this.columnas = columnas;
            this.filas = filas;
            generarMatriz();
        }

        private void generarMatriz()
        {
            int i;
            NodoMatriz anterior, actual, aux1, aux2;
            i = filas - 1;
            crearFila(inicio, 0);
            anterior = null;
            actual = inicio;
            while (i > 0)
            {
                actual.Abajo = new NodoMatriz(0, actual.getPosition()[0], actual.getPosition()[1] + 1);
                anterior = actual;
                actual = actual.Abajo;
                actual.Arriba = anterior;
                crearFila(actual, actual.getPosition()[1]);
                i--;
            }
            anterior = inicio;
            actual = inicio.Abajo;
            while (actual != null)
            {
                aux1 = anterior;
                aux2 = actual;
                for (i = 0; i < columnas - 1; i++)
                {
                    aux1 = aux1.Derecha;
                    aux2 = aux2.Derecha;
                    if (aux1 != null && aux2 != null)
                    {
                        aux1.Abajo = aux2;
                        aux2.Arriba = aux1;
                    }

                }
                anterior = actual;
                actual = actual.Abajo;
            }
        }

        private void crearFila(NodoMatriz actual, int fila)
        {
            int i;
            NodoMatriz anterior = null;
            for (i = 0; i < columnas - 1; i++)
            {
                actual.Derecha = new NodoMatriz(0, i + 1, fila);
                anterior = actual;
                actual = actual.Derecha;
                actual.Izquierda = anterior;
            }
            actual.Izquierda = anterior;
        }

        public NodoMatriz get(int fila, int columna)
        {
            int i, j;
            NodoMatriz buscado = inicio;
            for (i = 0; i < this.columnas; i++)
            {
                if (columna == i)
                    for (j = 0; j < this.filas; j++)
                    {
                        if (fila == j)
                            return buscado;
                        buscado = buscado.Abajo;
                    }
                buscado = buscado.Derecha;
            }
            return null;
        }

        public void set(int dato, int fila, int columna)
        {
            if (columna >= this.columnas || fila >= this.filas)
                return;
            NodoMatriz seteado = get(fila, columna);
            if (seteado != null)
                seteado.Dato = dato;
        }

        public int[] Size()
        {
            int[] arr = { filas, columnas };
            return arr;
        }
    }
}
