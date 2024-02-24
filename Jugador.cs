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
            Console.SetCursorPosition(posX, posY + 1);
            Console.Write('@');
        }
        public int Movimiento(ConsoleKey tecla, int objetos, Mapa mapaNuevo)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(' ');
            switch (tecla)
            {
                case ConsoleKey.UpArrow:
                    if (mapaNuevo.EsSuelo(posX, posY - 1))
                    {
                        posY--;
                    }
                    objetos = mapaNuevo.RecogeObjeto(posX, posY, objetos);
                    break;
                case ConsoleKey.DownArrow:
                    if (mapaNuevo.EsSuelo(posX, posY + 1))
                    {
                        posY++;
                    }
                    objetos = mapaNuevo.RecogeObjeto(posX, posY, objetos);
                    break;
                case ConsoleKey.LeftArrow:
                    if (mapaNuevo.EsSuelo(posX - 1, posY))
                    {
                        posX--;
                    }
                    objetos = mapaNuevo.RecogeObjeto(posX, posY, objetos);
                    break;
                case ConsoleKey.RightArrow:
                    if (mapaNuevo.EsSuelo(posX + 1, posY))
                    {
                        posX++;
                    }
                    objetos = mapaNuevo.RecogeObjeto(posX, posY, objetos);
                    break;
            }
            this.mapa = mapaNuevo;
            return objetos;
        }
        public bool Salir()
        {
            return mapa.EsSalida(posX, posY);
        }
        public Mapa GetMapa()
        {
            return this.mapa;
        }
    }
}