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
        public Jugador() {
            mapa = new Mapa();
            posX = mapa.ancho / 2;
            posY = mapa.alto / 2;
        }


        public void Dibuja()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write('@');
        }

        public void Movimiento()
        {
            Console.ReadKey(ConsoleKey tecla);
        }
    }
}
