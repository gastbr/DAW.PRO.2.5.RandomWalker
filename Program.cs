using DAW.PRO._2._5.RandomWalker;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Interfaz partida;
        Console.CursorVisible = false;
        int nivel = 0;
        int objetos = 0;
        while (true)
        {
            partida = new Interfaz();
            nivel++;
            objetos = partida.bucle(nivel, objetos);
        }
    }
}