/*
    Clase que crea el siguiente paso del juego segun el tablero actual.
*/

namespace PII_Game_Of_Life
{
    public class Logica
    {
        public static void Juego(Tablero gameBoard)
        {
            int boardWidth = gameBoard.Width;
            int boardHeight = gameBoard.Heigth;
            bool[,] cloneboard = new bool[boardWidth, boardHeight];


            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard.SaberValorPosicion(i, j))
                            {
                                aliveNeighbors += 1;
                            }
                        }
                    }
                    
                    // Se crea variable que almacena el estado de la posicion para no utilizar innecesariamente el metodo "SaberValorPosicion"
                    bool estadoPosicion = gameBoard.SaberValorPosicion(x, y);

                    if (estadoPosicion)
                    {
                        aliveNeighbors--;
                    }

                    if (estadoPosicion && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población.
                        cloneboard[x,y] = false;

                    }

                    else if (estadoPosicion && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación.
                        cloneboard[x,y] = false;
                    }

                    else if (!estadoPosicion && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción.
                        cloneboard[x,y] = true;
                    }

                    else
                    {
                        //Celula mantiene el estado que tenía.
                        cloneboard[x,y] = estadoPosicion;
                    }
                }
            }
            // Se cambia el tablero anterior por el actualizado.
            gameBoard.SetTabla(cloneboard);
        }
    }
}