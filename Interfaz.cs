using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.PRO._2._5.RandomWalker
{
    internal class Interfaz
    {
        Mapa CasaPepe;
        Jugador Pepe;
        ConsoleKey tecla;
        public Interfaz()
        {
            CasaPepe = new Mapa();
            Pepe = new Jugador(CasaPepe);
        }
        public int bucle(int nivel, int objetos)
        {
            while (Pepe.Salir() == false)
            {
                CasaPepe.Dibuja();
                Pepe.Dibuja();
                dibujaInterfaz(nivel, objetos);
                if (tecla == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                tecla = Console.ReadKey(true).Key;
                objetos = Pepe.Movimiento(tecla, objetos, CasaPepe);
                CasaPepe = Pepe.GetMapa();
            }
            return objetos;
        }
        public void dibujaInterfaz(int nivel, int objetos)
        {
            Console.SetCursorPosition(2, CasaPepe.alto + 2);
            Console.WriteLine("¡Ayuda al borracho Pepe a encontrar la salida de su casa!");
            Console.SetCursorPosition(6, CasaPepe.alto + 3);
            Console.WriteLine("Flechas para moverte. Esc para salir.");
            Console.SetCursorPosition(6, CasaPepe.alto + 5);
            Console.WriteLine("Nivel: " + nivel);
            Console.SetCursorPosition(6, CasaPepe.alto + 6);
            if (objetos > 0)
            {
                Console.WriteLine("Cervezas recogidas: " + objetos);
            }
        }
    }
}
