using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear la variable que contenga la url del .txt.
            string url = "..\\File.txt";
            // Creo un tablero
            Tablero tablero = new Tablero(url); //variable que representa el tablero

            // Creo un bucle que imprima La tabla inicial,
            // luego la modifique,
            // luego limpie la consola,
            // y la vuelva a imprimir
            
            while (true)
            {
                // Imprime
                Console.WriteLine(Imprimir.TableroToString(tablero));
                // Modifica la tabla
                Logica.Juego(tablero);
                // Limpia la consola despues de 0.3s
                Thread.Sleep(500);
                Console.Clear();
                // Vuelve a impimir
            }

        }
    }
}
