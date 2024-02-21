using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.PRO._2._5.RandomWalker
{
    internal class Mapa
    {
        private Celda[,] celdas;
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
            RandomWalker(200);
        }

        public void Dibuja()
        {
            for (int i = 0; i < alto; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < ancho; j++)
                {
                    if (celdas[j, i].Terreno == Terreno.Suelo)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("█");
                    }
                }
            }
        }

        public void RandomWalker(int CantidadSuelo)
        {
            Random r = new Random();
            int dir;
            int x = ancho / 2;
            int y = alto / 2;
            int andado = 0;

            do
            {
                celdas[x, y].Terreno = Terreno.Suelo;
                if (x < 4 || y < 2 || x > (ancho - 5) || y > (alto - 3))
                {
                    x = ancho / 2;
                    y = alto / 2;
                }
                else
                {
                    celdas[x, y].Terreno = Terreno.Suelo;
                    if (celdas[x, y].Terreno == Terreno.Muro)
                    {
                        celdas[x, y].Terreno = Terreno.Suelo;
                        andado++;
                    }
                    dir = r.Next(4);
                    switch (dir)
                    {
                        case 0:
                            x++;
                            celdas[x, y].Terreno = Terreno.Suelo;
                            andado++;
                            x++;
                            celdas[x, y].Terreno = Terreno.Suelo;
                            andado++;
                            x++;
                            break;
                        case 1:
                            y++;
                            break;
                        case 2:
                            x--;
                            celdas[x, y].Terreno = Terreno.Suelo;
                            andado++;
                            x--;
                            celdas[x, y].Terreno = Terreno.Suelo;
                            andado++;
                            x--;
                            break;
                        case 3:
                            y--;
                            break;
                    }
                }
            }
            while (andado < CantidadSuelo);
        }










    }
}
