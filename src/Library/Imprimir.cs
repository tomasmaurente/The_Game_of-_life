using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class Imprimir
    {
        public static string TableroToString(bool[,] nuevaTabla)
        {
            int width = nuevaTabla.GetLength(0);
            int height = nuevaTabla.GetLength(1);

            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (nuevaTabla[x, y])
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