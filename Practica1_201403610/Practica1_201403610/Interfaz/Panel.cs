using System;
using System.Drawing;
using System.Windows.Forms;
using Practica1_201403610.Datos;

namespace Practica1_201403610.Interfaz
{
    public partial class Panel : Form
    {
        private Varios.Varios varios;
        private Usuario logueado;

        public Panel(object logueado)
        {
            InitializeComponent();
            varios = new Varios.Varios();
            this.logueado = (Usuario)logueado;
            lblbienvenido.Text = "Bienvenido " + this.logueado.Nombre;
            lblbienvenido.Location = new Point((this.Width - lblbienvenido.Width)/2, 73);
        }

        private void graficarCola_Click(object sender, EventArgs e)
        {
            logueado.cola.Graficar();
        }

        private void peekCola_Click(object sender, EventArgs e)
        {
            logueado.cola.Peek();
        }

        private void graficarPila_Click(object sender, EventArgs e)
        {
            logueado.pila.Graficar();
        }

        private void peekPila_Click(object sender, EventArgs e)
        {
            logueado.pila.Peek();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                varios.cargarArchivo(openFileDialog1.FileName, logueado);
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
            //varios.cargarArchivo(path, logueado);
        }

        private void multiplicarMatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logueado.multiplicar();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
