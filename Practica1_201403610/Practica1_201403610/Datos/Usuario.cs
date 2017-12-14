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
        public Cola cola;
        public Pila pila;

        public Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
            cola = new Cola();
            pila = new Pila();
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
                Matriz m1 = cola.Dequeue().Dato;
                Matriz m2 = pila.Pop().Dato;
                Matriz re;
                if (m1.Size()[1] == m2.Size()[0])
                {
                    re = multiplicar(m1, m2);
                    re.Graficar();
                    MessageBox.Show("Multiplicación AxB realizada.");
                }
                //else if (m2.Size()[1] == m1.Size()[0])
                //{
                //    re = multiplicar(m2, m1);
                //    re.Graficar();
                //    MessageBox.Show("Multiplicación de BxA realizada.");
                //}
                else
                    MessageBox.Show("No se puede realizar la multiplicación.");
            }
        }

        private Matriz multiplicar(Matriz m1, Matriz m2)
        {
            int suma, filas, columnas, indice;
            Matriz resultado = new Matriz(m1.Size()[0], m2.Size()[1]);
            for (filas = 0; filas < resultado.Size()[0]; filas++)
            {
                for (columnas = 0; columnas < resultado.Size()[1]; columnas++)
                {
                    suma = 0;
                    for (indice = 0; indice < m1.Size()[1]; indice++)
                        suma += m1.get(filas, indice).Dato * m2.get(indice, columnas).Dato;
                    resultado.set(suma, filas, columnas);
                }
            }
            return resultado;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Contrasena
        {
            get { return contrasena; }
        }
    }
}
