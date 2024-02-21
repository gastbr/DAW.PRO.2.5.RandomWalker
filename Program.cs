using DAW.PRO._2._5.RandomWalker;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Mapa CasaPepe = new Mapa();
        Jugador Pepe = new Jugador();
        ConsoleKey tecla;
        /* Console.CursorVisible = false;*/ 
        while (true)
        {
            Console.Clear();
            tecla = Console.ReadKey().Key;
            CasaPepe.Dibuja();
            Pepe.Dibuja();
            Console.ReadKey(true);
        }
    }
}