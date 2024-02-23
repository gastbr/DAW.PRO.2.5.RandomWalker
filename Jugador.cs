using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.PRO._2._5.RandomWalker
{
    internal class Jugador
    {
        Random r = new Random();
        int posX;
        int posY;
        Mapa mapa;
        public Jugador(Mapa MapaJug)
        {
            mapa = MapaJug;
            posX = mapa.ancho / 2;
            posY = mapa.alto / 2;
        }
        public void Dibuja()
        {
            Console.SetCursorPosition(posX, posY+1);
            Console.Write('@');
        }
        public void Movimiento(ConsoleKey tecla)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(' ');
            switch (tecla)
            {
                case ConsoleKey.UpArrow:
                    if (mapa.EsSuelo(posX, posY - 1))
                    {
                        posY--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (mapa.EsSuelo(posX, posY + 1))
                    {
                        posY++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (mapa.EsSuelo(posX - 1, posY))
                    {
                        posX--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (mapa.EsSuelo(posX + 1, posY))
                    {
                        posX++;
                    }
                    break;
            }
        }
        public bool Salir()
        {
            return mapa.EsSalida(posX, posY);
        }
    }
}