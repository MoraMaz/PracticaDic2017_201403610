using System.IO;
using System.Windows.Forms;

namespace Practica1_201403610.Estructuras
{
    class Cola
    {
        private NodoCola<Matriz> inicio, fin;
        private Varios.Varios varios;
        private int tamano;

        public Cola()
        {
            varios = new Varios.Varios();
            inicio = null;
            fin = null;
            tamano = 0;
        }

        public void Enqueue(Matriz dato)
        {
            if (isEmpty())
            {
                inicio = new NodoCola<Matriz>(dato);
                fin = inicio;
            }
            else
            {
                fin.Siguiente = new NodoCola<Matriz>(dato);
                fin = fin.Siguiente;
            }
            tamano++;
        }

        public NodoCola<Matriz> Dequeue()
        {
            if (isEmpty())
            {
                MessageBox.Show("Cola vacía.");
                return null;
            }
            NodoCola<Matriz> cabeza = inicio;
            inicio = inicio.Siguiente;
            tamano--;
            return cabeza;
        }

        public void Peek()
        {
            if (!isEmpty())
            {
                inicio.Dato.Graficar();
                return;
            }
            MessageBox.Show("Cola vacía.");
        }

        public void Graficar()
        {
            if (isEmpty())
            {
                MessageBox.Show("Cola vacía.");
                return;
            }
            string grafo = "digraph Cola {\n\trandir = LR;\n\tlabel = \"Cola\";\n\tnode [shape = box];\n\t";
            NodoCola<Matriz> auxiliar = inicio;
            int i = 0;
            while (auxiliar != null)
            {
                grafo += "N" + i + " [label = \"" + auxiliar.Dato.getValor() + "\" ];\n\t";
                if (auxiliar.Siguiente != null)
                    grafo += "N" + i + " -> N" + (i + 1) + " [label = \"Siguiente\"];\n\t";
                i++;
                auxiliar = auxiliar.Siguiente;
            }
            grafo += "\n}";
            string pathDot = @"C:\Salidas";
            string pathPng;
            if (!Directory.Exists(pathDot))
                Directory.CreateDirectory(pathDot);
            pathDot = Path.Combine(pathDot, "c.dot");
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
