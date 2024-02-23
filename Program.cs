using DAW.PRO._2._5.RandomWalker;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Mapa CasaPepe;
        Jugador Pepe;
        Interfaz partida;
        while (true)
        {
            CasaPepe = new Mapa();
            Pepe = new Jugador(CasaPepe);
            partida = new Interfaz();
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