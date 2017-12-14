using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1_201403610.Estructuras;
using Practica1_201403610.Datos;

namespace Practica1_201403610.Interfaz
{
    public partial class Login : Form
    {
        private Circular usuarios;

        public Login()
        {
            InitializeComponent();
            usuarios = new Circular();
        }

        private void graficarUsuarios_Click(object sender, EventArgs e)
        {
            if (usuarios.isEmpty())
                MessageBox.Show("La lista de usuarios está vacía.");
            else
                usuarios.Graficar();
        }

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario(nombre.Text, contrasena.Text);
            if (!usuarios.Agregar(nuevo))
                MessageBox.Show("El nombre de usuario ya está registrado.");
            else
                MessageBox.Show("Usuario registrado exitosamente.");
            nombre.Text = "";
            contrasena.Text = "";
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            NodoCircular<Usuario> a_loguear = usuarios.Obtener(nombre.Text, contrasena.Text);
            if (a_loguear != null)
            {
                (new Panel(a_loguear.Dato)).Show();
            }
            else
                MessageBox.Show("Datos de usuario incorrectos.");
            nombre.Text = "";
            contrasena.Text = "";
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            if (!usuarios.Eliminar(nombre.Text, contrasena.Text))
                MessageBox.Show("Las credenciales de usuario no están registradas.");
            else
                MessageBox.Show("Usuario eliminado exitosamente.");
            nombre.Text = "";
            contrasena.Text = "";
        }
    }
}
