using DAW.PRO._2._5.RandomWalker;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            /* dsasda */
            Mapa CasaPepe = new Mapa();
            Jugador Pepe = new Jugador(CasaPepe);
            Interfaz partida = new Interfaz();
            ConsoleKey tecla;
            Console.CursorVisible = false;
            while (Pepe.Salir() == false)
            {
                CasaPepe.Dibuja();
                Pepe.Dibuja();
                tecla = Console.ReadKey().Key;
                Pepe.Movimiento(tecla);
            }
        }
    }
}