using System.IO;
/*
    Clase que crea un tablero según un archivo ".txt".
    Esta clase se crea ya que existe la posibilidad de que se quiera cargar el archivo desde otro tipo de archivo que ne sea file.
    Si este fuese el caso se tendria que cambiar el metodo, y si este metodo estubiese en la clase Tablero, la clase Tablero tendria
    dos razones de cambio:
    1) Cambiar el metodo CreacionDeTablero.
    2) Cambiar el constructor de clase.
    El patrón SRP dice "Una clase debe tener solo una razón para cambiar.".
*/
namespace PII_Game_Of_Life
{
    public class CargaDeTablero
    {
        public static bool[,] CreacionDeTablero(string url) // Constructor del objeto tablero
        {
            string content = File.ReadAllText(@url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[x, y] = true;
                    }
                }
            }
            return board;
        }
    }
}
