using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear la variable que contenga la url del .txt.
            string url = "..\\board.txt";
            // Creo un tablero
            bool[,] tablero = CargaDeTablero.CreacionDeTablero(url); //variable que representa el tablero

            // Creo un bucle que imprima La tabla inicial,
            // luego la modifique,
            // luego limpie la consola,
            // y la vuelva a imprimir
            
            while (true)
            {
                // Imprime
                Console.WriteLine(Imprimir.TableroToString(tablero));
                // Modifica la tabla
                tablero = Logica.Juego(tablero);
                // Limpia la consola despues de 0.3s
                Thread.Sleep(300);
                Console.Clear();
                // Vuelve a impimir
            }

        }
    }
}
