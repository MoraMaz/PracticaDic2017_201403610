using System.IO;

namespace Practica1_201403610.Estructuras
{
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
            if (filas == 0 || columnas == 0)
                return;
            int indice;
            NodoMatriz anterior, actual, enlace_arriba, enlace_abajo;
            crearFila(inicio, 0);
            anterior = null;
            actual = inicio;
            for (indice = filas - 1; indice > 0; indice--)
            {
                actual.Abajo = new NodoMatriz(0, actual.getPosition()[0], actual.getPosition()[1] + 1);
                anterior = actual;
                actual = actual.Abajo;
                actual.Arriba = anterior;
                crearFila(actual, actual.getPosition()[1]);
            }
            anterior = inicio;
            for (actual = inicio.Abajo; actual != null; actual = actual.Abajo)
            {
                enlace_arriba = anterior;
                enlace_abajo = actual;
                for (indice = 0; indice < columnas - 1; indice++)
                {
                    enlace_arriba = enlace_arriba.Derecha;
                    enlace_abajo = enlace_abajo.Derecha;
                    if (enlace_arriba != null && enlace_abajo != null)
                    {
                        enlace_arriba.Abajo = enlace_abajo;
                        enlace_abajo.Arriba = enlace_arriba;
                    }

                }
                anterior = actual;
            }
        }

        private void crearFila(NodoMatriz actual, int fila)
        {
            int indice;
            NodoMatriz anterior = null;
            for (indice = 0; indice < columnas - 1; indice++)
            {
                actual.Derecha = new NodoMatriz(0, indice + 1, fila);
                anterior = actual;
                actual = actual.Derecha;
                actual.Izquierda = anterior;
            }
            actual.Izquierda = anterior;
        }

        public NodoMatriz get(int fila, int columna)
        {
            if (columna >= this.columnas || fila >= this.filas)
                return null;
            int indice_columna, indice_fila;
            NodoMatriz buscado = inicio;
            for (indice_columna = 0; indice_columna < this.columnas; indice_columna++)
            {
                if (columna == indice_columna)
                    for (indice_fila = 0; indice_fila < this.filas; indice_fila++)
                    {
                        if (fila == indice_fila)
                            return buscado;
                        buscado = buscado.Abajo;
                    }
                buscado = buscado.Derecha;
            }
            return null;
        }

        public void set(int dato, int fila, int columna)
        {
            NodoMatriz a_setear = get(fila, columna);
            if (a_setear != null)
                a_setear.Dato = dato;
        }

        public int getValor()
        {
            int suma = 0;
            NodoMatriz auxiliar, actual;
            auxiliar = inicio;
            actual = inicio;
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (filas - 1 == j)
                        auxiliar = auxiliar.Derecha;
                    suma += actual.Dato;
                    actual = actual.Abajo;
                }
                actual = auxiliar;
            }
            return suma;
        }

        public int[] Size()
        {
            int[] tamano = { filas, columnas };
            return tamano;
        }

        public void Graficar()
        {
            if (!(filas > 0 && columnas > 0))
                return;
            string grafo = "digraph Matriz {\n\tlabel = \"Matriz\";\n\tnode [shape = box];\n\t";
            NodoMatriz auxiliar, actual;
            auxiliar = inicio;
            actual = inicio;
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < filas; j++)
                {
                    if (j == 0)
                        grafo += "\t\t{\n\t\t\trank = min;\n";
                    else if (j == filas - 1)
                    {
                        grafo += "\t\t{\n\t\t\trank = max;\n";
                        auxiliar = auxiliar.Derecha;
                    }
                    else
                        grafo += "\t\t{\n\t\t\trank = same;\n";
                    grafo += "\t\t\tN" + actual.getPosition()[0] + actual.getPosition()[1] + " [label = \"" + actual.Dato + "\"];\n";
                    if (actual.Derecha != null)
                        grafo += "\t\t\tN" + actual.getPosition()[0] + actual.getPosition()[1] + " -> N" + actual.Derecha.getPosition()[0] + actual.Derecha.getPosition()[1] + "[rankdir=LR];\n";
                    if (actual.Izquierda != null)
                        grafo += "\t\t\tN" + actual.getPosition()[0] + actual.getPosition()[1] + " -> N" + actual.Izquierda.getPosition()[0] + actual.Izquierda.getPosition()[1] + ";\n";
                    grafo += "\t\t}\n";
                    
                    if (actual.Arriba != null)
                        grafo += "\tN" + actual.getPosition()[0] + actual.getPosition()[1] + " -> N" + actual.Arriba.getPosition()[0] + actual.Arriba.getPosition()[1] + ";\n";
                    if (actual.Abajo != null)
                        grafo += "\tN" + actual.getPosition()[0] + actual.getPosition()[1] + " -> N" + actual.Abajo.getPosition()[0] + actual.Abajo.getPosition()[1] + "[rankdir=UD];\n";
                    actual = actual.Abajo;
                }
                actual = auxiliar;
            }
            grafo += "\n}";
            string pathDot = @"C:\Salidas";
            string pathPng;
            if (!Directory.Exists(pathDot))
                Directory.CreateDirectory(pathDot);
            pathDot = Path.Combine(pathDot, "m.dot");
            pathPng = pathDot.Replace(".dot", ".png");
            StreamWriter fichero = new StreamWriter(pathDot, false);
            fichero.WriteLine(grafo);
            fichero.Close();
            System.Diagnostics.ProcessStartInfo startProceso = new System.Diagnostics.ProcessStartInfo("cmd", "/cdot " + pathDot + " -Tpng -o " + pathPng);
            startProceso.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startProceso.RedirectStandardOutput = true;
            startProceso.UseShellExecute = false;
            startProceso.CreateNoWindow = false;
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo = startProceso;
            proceso.Start();
            startProceso = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + pathPng);
            startProceso.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startProceso.RedirectStandardOutput = true;
            startProceso.UseShellExecute = false;
            startProceso.CreateNoWindow = false;
            proceso = new System.Diagnostics.Process();
            proceso.StartInfo = startProceso;
            proceso.Start();
        }
    }
}
