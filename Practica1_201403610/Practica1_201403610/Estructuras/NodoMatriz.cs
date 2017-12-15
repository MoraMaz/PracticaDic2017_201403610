namespace Practica1_201403610.Estructuras
{
    class NodoMatriz
    {
        private int dato, x, y;
        private NodoMatriz izquierda, derecha, arriba, abajo;

        public NodoMatriz(int dato, int x, int y)
        {
            this.dato = dato;
            setPosition(x, y);
            izquierda = null;
            derecha = null;
            arriba = null;
            abajo = null;
        }

        public NodoMatriz(int dato, int x, int y, NodoMatriz izquierda, NodoMatriz derecha, NodoMatriz arriba, NodoMatriz abajo)
        {
            this.dato = dato;
            setPosition(x, y);
            this.izquierda = izquierda;
            this.derecha = derecha;
            this.arriba = arriba;
            this.abajo = abajo;
        }

        private void setPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int[] getPosition()
        {
            int[] posicion = {x, y};
            return posicion;
        }

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        internal NodoMatriz Izquierda
        {
            get { return izquierda; }
            set { izquierda = value; }
        }

        internal NodoMatriz Derecha
        {
            get { return derecha; }
            set { derecha = value; }
        }

        internal NodoMatriz Arriba
        {
            get { return arriba; }
            set { arriba = value; }
        }

        internal NodoMatriz Abajo
        {
            get { return abajo; }
            set { abajo = value; }
        }
    }
}
