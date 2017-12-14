using Practica1_201403610.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201403610.Varios
{
    class Varios
    {
        public string Limpiar(string cadena)
        {
            string nueva = cadena;
            nueva.Replace(" ", "");
            nueva.Replace("\t", "");
            nueva.Replace("\n", "");
            nueva.Replace("\r", "");
            nueva.Replace("\f", "");
            return nueva;
        }

        public void cargarArchivo(string path, Usuario actual)
        {
            //esto falta alv
        }
    }
}
