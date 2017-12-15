using Practica1_201403610.Datos;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace Practica1_201403610.Varios
{
    class Varios
    {
        public string Limpiar(string cadena)
        {
            string nueva = cadena;
            nueva = nueva.Replace(" ", "");
            nueva = nueva.Replace("\t", "");
            nueva = nueva.Replace("\n", "");
            nueva = nueva.Replace("\r", "");
            nueva = nueva.Replace("\f", "");
            return nueva;
        }

        public void cargarArchivo(string path, Usuario actual)
        {
            Raiz root;
            using (StreamReader reader = new StreamReader(path))
            {
                var json = reader.ReadToEnd();
                root = JsonConvert.DeserializeObject<Raiz>(json);
            }
            if(root != null)
            {
                if (root.archivo.pila != null)
                    if (root.archivo.pila.matrices != null)
                        if (root.archivo.pila.matrices.matriz != null)
                            foreach (MatrizPila matriz in root.archivo.pila.matrices.matriz)
                                if (matriz != null)
                                {
                                    Estructuras.Matriz nueva = new Estructuras.Matriz(int.Parse(matriz.size_y), int.Parse(matriz.size_x));
                                    if (matriz.valores != null)
                                        foreach (ValorPila valor in matriz.valores.valor)
                                            nueva.set(int.Parse(valor.dato), int.Parse(valor.pos_y), int.Parse(valor.pos_x));
                                    actual.pila.Push(nueva);
                                }
                if (root.archivo.cola != null)
                    if (root.archivo.cola.matrices != null)
                        if (root.archivo.cola.matrices.matriz != null)
                            foreach (MatrizCola matriz in root.archivo.cola.matrices.matriz)
                                if (matriz != null)
                                {
                                    Estructuras.Matriz nueva = new Estructuras.Matriz(int.Parse(matriz.size_y), int.Parse(matriz.size_x));
                                    if (matriz.valores != null)
                                        foreach (ValorCola valor in matriz.valores.valor)
                                            nueva.set(int.Parse(valor.dato), int.Parse(valor.pos_y), int.Parse(valor.pos_x));
                                    actual.cola.Enqueue(nueva);
                                }
            }
            else
                MessageBox.Show("Carga fallida.");
        }
    }

    /*
     * Clases para leer el archivo json creadas por http://json2csharp.com/
     * y luego modificadas para mayor comprensión de las mismas.
     */

    public class ValorPila
    {
        public string pos_x { get; set; }
        public string pos_y { get; set; }
        public string dato { get; set; }
    }

    public class ValoresPila
    {
        public List<ValorPila> valor { get; set; }
    }

    public class MatrizPila
    {
        public string size_x { get; set; }
        public string size_y { get; set; }
        public ValoresPila valores { get; set; }
    }

    public class MatricesPila
    {
        public List<MatrizPila> matriz { get; set; }
    }

    public class Pila
    {
        public MatricesPila matrices { get; set; }
    }

    public class ValorCola
    {
        public string pos_x { get; set; }
        public string pos_y { get; set; }
        public string dato { get; set; }
    }

    public class ValoresCola
    {
        public List<ValorCola> valor { get; set; }
    }

    public class MatrizCola
    {
        public string size_x { get; set; }
        public string size_y { get; set; }
        public ValoresCola valores { get; set; }
    }

    public class MatricesCola
    {
        public List<MatrizCola> matriz { get; set; }
    }

    public class Cola
    {
        public MatricesCola matrices { get; set; }
    }

    public class Archivo
    {
        public Pila pila { get; set; }
        public Cola cola { get; set; }
    }

    public class Raiz
    {
        public Archivo archivo { get; set; }
    }
}
