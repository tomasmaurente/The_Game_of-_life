using System;
using System.Text;

namespace PII_Game_Of_Life
{
    public class Imprimir
    {
        public static string TableroToString(Tablero nuevaTabla)
        {
            int width = nuevaTabla.Width;
            int height = nuevaTabla.Heigth;

            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(nuevaTabla.SaberValorPosicion(x,y))
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            return (s.ToString());
        }
    }
}