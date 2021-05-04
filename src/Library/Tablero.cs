/*
    Siguiendo el principio Expert, creamos una clase que encapsule toda la información del tablero, y continuando con este principio
    todos sus metodos.
*/
namespace PII_Game_Of_Life
{
    public class Tablero
    {
        private bool[,] tabla;
        public bool[,] Tabla
        {
            get
            {
                return tabla;
            }
            set
            {
                tabla = value;
            }
        }
        private int heigth;
        public int Heigth
        {
            get
            {
                return heigth;
            }
            set
            {
                heigth = value;
                ;
            }
        }
        private int width;
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        
        //  Constructor de la clase.  
        public Tablero(string url)
        {
            Tabla = CargaDeTablero.CreacionDeTablero(url);
            Heigth = this.tabla.GetLength(1);
            Width = this.tabla.GetLength(0);
        }
        
        // Metodo para cambiar un valor especifico de la tabla.
        public void Cambiar(int x, int y, bool Valor)
        {
            this.tabla[x, y] = Valor;
        }
        
        // Metodo para cambiar todos los valores de la tabla.
        public void SetTabla(bool[,] nuevaTabla)
        {
            Tabla = nuevaTabla;
        }

        // Metodo para saber el valor de un lugar especifico de la tabla.
        public bool SaberValorPosicion(int x, int y)
        {
            return this.tabla[x, y];
        }
    }
}
