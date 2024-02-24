using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.PRO._2._5.RandomWalker
{
    internal class Mapa
    {
        Random r = new Random();
        Celda[,] celdas;
        public int alto;
        public int ancho;
        public Mapa()
        {
            alto = 20;
            ancho = 80;
            celdas = new Celda[ancho, alto];
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    celdas[j, i] = new Celda();
                }
            }
            RandomWalker(450);
        }
        public void Dibuja()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < ancho; j++)
                {
                    if (celdas[j, i].Terreno == Terreno.Suelo) { Console.Write(" "); }
                    else if (celdas[j, i].Terreno == Terreno.Salida) { Console.Write("X"); }
                    else if (celdas[j, i].Terreno == Terreno.Objeto) { Console.Write("o"); }
                    else { Console.Write("█"); }
                }
            }
        }
        public void RandomWalker(int CantidadSuelo)
        {
            int dir;
            int x = ancho / 2;
            int y = alto / 2;
            int tirado = 0;

            do
            {
                if (x < 3 || y < 2 || x > (ancho - 5) || y > (alto - 3))
                {
                    x = ancho / 2;
                    y = alto / 2;
                }
                else
                {
                    tirado = TiraMuro(x, y, tirado);
                    dir = r.Next(4);
                    switch (dir)
                    {
                        case 0:
                            x++;
                            tirado = TiraMuro(x, y, tirado);
                            x++;
                            tirado = TiraMuro(x, y, tirado);
                            x++;
                            break;
                        case 1:
                            y++;
                            break;
                        case 2:
                            x--;
                            tirado = TiraMuro(x, y, tirado);
                            x--;
                            tirado = TiraMuro(x, y, tirado);
                            x--;
                            break;
                        case 3:
                            y--;
                            break;
                    }
                }
            }
            while (tirado < CantidadSuelo);
            celdas[x, y].Terreno = Terreno.Salida;
        }
        public int TiraMuro(int x, int y, int tirado)
        {
            int random = r.Next(100);
            if (celdas[x, y].Terreno == Terreno.Muro)
            {
                if (random == 1)
                {
                    celdas[x, y].Terreno = Terreno.Objeto;
                }
                else
                {
                    celdas[x, y].Terreno = Terreno.Suelo;
                }
                tirado++;
            }
            return tirado;
        }
        public bool EsSuelo(int x, int y)
        {
            return celdas[x, y].Terreno == Terreno.Suelo || celdas[x, y].Terreno == Terreno.Salida || celdas[x, y].Terreno == Terreno.Objeto;
        }
        public bool EsSalida(int x, int y)
        {
            return celdas[x, y].Terreno == Terreno.Salida;
        }
        public int RecogeObjeto(int posX, int posY, int objetos)
        {
            if (celdas[posX, posY].Terreno == Terreno.Objeto)
            {
                celdas[posX, posY].Terreno = Terreno.Suelo;
                objetos++;
            }
            return objetos;
        }







    }
}
