using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_201403610.Estructuras
{
    class Pila
    {
        private NodoPila<Matriz> top;
        private Varios.Varios varios;
        private int tamano;

        public Pila()
        {
            varios = new Varios.Varios();
            top = null;
            tamano = 0;
        }

        public void Push(Matriz dato)
        {
            if (isEmpty())
                top = new NodoPila<Matriz>(dato);
            else
                top = new NodoPila<Matriz>(dato, top);
            tamano++;
        }

        public NodoPila<Matriz> Pop()
        {
            if (isEmpty())
            {
                MessageBox.Show("Pila vacía.");
                return null;
            }
            NodoPila<Matriz> cabeza = top;
            top = top.Abajo;
            tamano--;
            return cabeza;
        }

        public void Peek()
        {
            if (!isEmpty())
                top.Dato.Graficar();
            MessageBox.Show("Pila vacía.");
        }

        public void Graficar()
        {
            if (isEmpty())
                return;
            string grafo = "digraph Pila {\n\trandir = UD;\n\tlabel = \"Pila\";\n\tnode [shape = box];\n\t";
            NodoPila<Matriz> auxiliar = top;
            int i = 0;
            while(auxiliar != null)
            {
                grafo += "N" + i + " [label = \"" + auxiliar.Dato.getValor() +"\" ];\n\t";
                if (auxiliar.Abajo != null)
                    grafo += "N" + i + " -> N" + (i+1) + " [label = \"Abajo\"];\n\t";
                i++;
                auxiliar = auxiliar.Abajo;
            }
            grafo += "\n}";
            string pathDot = @"C:\Salidas";
            string pathPng;
            if (!Directory.Exists(pathDot))
                Directory.CreateDirectory(pathDot);
            pathDot = Path.Combine(pathDot, "p.dot");
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
