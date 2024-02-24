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
                tecla = Console.ReadKey().Key;
                objetos = Pepe.Movimiento(tecla, objetos, CasaPepe);
                CasaPepe = Pepe.GetMapa();
            }
            return objetos;
        }
        public void dibujaInterfaz(int nivel, int objetos)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("¡Ayuda al borracho Pepe a encontrar la salida de su casa!");
            Console.SetCursorPosition(CasaPepe.ancho + 2, 0);
            Console.WriteLine("Nivel: " + nivel);
            Console.SetCursorPosition(CasaPepe.ancho + 2, 1);
            if (objetos > 0)
            {
                Console.WriteLine("Cervezas recogidas: " + objetos);
            }
        }
    }
}
