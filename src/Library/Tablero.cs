using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        private bool[,] tabla;
        // falta asreadonly
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

        public Tablero(string url)
        {
            Tabla = CargaDeTablero.CreacionDeTablero(url);
            Heigth = this.tabla.GetLength(1);
            Width = this.tabla.GetLength(0);
        }

        public void Cambiar(int x, int y, bool Valor)
        {
            this.tabla[x,y] = Valor;
        }

        public bool SaberValorPosicion(int x, int y)
        {
            return this.tabla[x,y];
        }

        public void SetTabla (bool[,] nuevaTabla)
        {
            this.tabla = nuevaTabla;
        }
    }
}
