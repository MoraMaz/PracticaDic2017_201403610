using Practica1_201403610.Datos;
using System.IO;

namespace Practica1_201403610.Estructuras
{
    class Circular
    {
        private NodoCircular<Usuario> inicio;
        private Varios.Varios varios;
        private int tamano;

        public Circular()
        {
            varios = new Varios.Varios();
            inicio = null;
            tamano = 0;
        }

        public bool Agregar(Usuario dato)
        {
            if (isEmpty())
                inicio = new NodoCircular<Usuario>(dato);
            else if (Existe(dato.Nombre))
                return false;
            else
            {
                NodoCircular<Usuario> nuevo = new NodoCircular<Usuario>(dato, inicio.Anterior, inicio);
                nuevo.Anterior.Siguiente = nuevo;
                inicio.Anterior = nuevo;
            }
            tamano++;
            return true;
        }

        public bool Existe(string nombre)
        {
            if (isEmpty())
                return false;
            NodoCircular<Usuario> auxiliar = inicio;
            do
            {
                if (auxiliar.Dato.Nombre.Equals(nombre))
                    return true;
                auxiliar = auxiliar.Siguiente;
            } while (auxiliar != inicio);
            return false;
        }

        public NodoCircular<Usuario> Obtener(string nombre, string contrasena)
        {
            if (isEmpty())
                return null;
            NodoCircular<Usuario> auxiliar = inicio;
            do
            {
                if (auxiliar.Dato.Nombre.Equals(nombre) && auxiliar.Dato.Contrasena.Equals(contrasena))
                    return auxiliar;
                auxiliar = auxiliar.Siguiente;
            } while (auxiliar != inicio);
            return null;
        }

        public bool Eliminar(string nombre, string contrasena)
        {
            if (isEmpty())
                return false;
            NodoCircular<Usuario> auxiliar = Obtener(nombre, contrasena);
            if (auxiliar != null)
            {
                if (tamano == 1)
                    inicio = null;
                else
                {
                    if (auxiliar == inicio)
                        inicio = inicio.Siguiente;
                    auxiliar.Anterior.Siguiente = auxiliar.Siguiente;
                    auxiliar.Siguiente.Anterior = auxiliar.Anterior;
                }
                tamano--;
                return true;
            }
            return false;
        }

        public void Graficar()
        {
            if (isEmpty())
                return;
            string grafo = "digraph Lista_Circular {\n\tlabel = \"Lista Circular\"\n\tnode [shape = circle];\n\t";
            NodoCircular<Usuario> auxiliar = inicio;
            do{
                grafo += "N" + varios.Limpiar(auxiliar.Dato.Nombre) + " [label = \"usuario: " + auxiliar.Dato.Nombre + "\" ];\n\t";
                grafo += "N" + varios.Limpiar(auxiliar.Dato.Nombre) + " -> N" + varios.Limpiar(auxiliar.Siguiente.Dato.Nombre) + " [label = \"Siguiente\"];\n\t";
                grafo += "N" + varios.Limpiar(auxiliar.Siguiente.Dato.Nombre) + " -> N" + varios.Limpiar(auxiliar.Dato.Nombre) + " [label = \"Anterior\"];\n\t";
                auxiliar = auxiliar.Siguiente;
            } while (auxiliar != inicio);
            grafo += "\n}";
            string pathDot = @"C:\Salidas";
            string pathPng;
            if (!Directory.Exists(pathDot))
                Directory.CreateDirectory(pathDot);
            pathDot = Path.Combine(pathDot, "ls.dot");
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

        public bool isEmpty()
        {
            return (tamano == 0);
        }
    }
}
