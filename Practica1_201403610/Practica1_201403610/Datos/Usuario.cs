using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1_201403610.Estructuras;
using System.Windows.Forms;

namespace Practica1_201403610.Datos
{
    class Usuario
    {
        private string nombre, contrasena;
        public Cola<Matriz> cola;
        public Pila<Matriz> pila;

        public Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
            cola = new Cola<Matriz>();
            pila = new Pila<Matriz>();
        }

        public void multiplicar()
        {
            if (cola.isEmpty() && pila.isEmpty())
                MessageBox.Show("Pila y Cola vacía.");
            else if (cola.isEmpty())
                MessageBox.Show("Cola vacía.");
            else if (pila.isEmpty())
                MessageBox.Show("Pila vacía.");
            else
            {
                Matriz m1 = pila.Pop().Dato;
                Matriz m2 = cola.Dequeue().Dato;
                Matriz re;
                if (m1.Size()[1] == m2.Size()[0])
                {
                    re = multiplicar(m1, m2);
                    MessageBox.Show("Multiplicación de AxB realizada.");
                }
                else if (m2.Size()[1] == m1.Size()[0])
                {
                    re = multiplicar(m2, m1);
                    MessageBox.Show("Multiplicación de BxA realizada.");
                }
                else
                    MessageBox.Show("Las matrices no se pueden multiplicar.");
            }
        }

        private Matriz multiplicar(Matriz m1, Matriz m2)
        {
            int suma;
            Matriz resultado = new Matriz(m1.Size()[0], m2.Size()[1]);
            for (int i = 0; i < resultado.Size()[0]; i++)
            {
                for (int j = 0; j < resultado.Size()[1]; j++)
                {
                    suma = 0;
                    for (int a = 0; a < m1.Size()[1]; a++)
                    {
                        suma += m1.get(i, a).Dato * m2.get(a, j).Dato;
                    }
                    resultado.set(suma, i, j);
                }
            }
            return resultado;
        }
    }
}
