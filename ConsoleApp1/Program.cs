using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Board uzo;

            uzo = new Board("*");

            uzo.addX(3);
            uzo.printBoard();

            uzo.addX(5);
            uzo.printBoard();
        }
    }
}
