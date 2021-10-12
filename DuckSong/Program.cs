using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 4; i > -2; i--)
            {
                if (i == -1)
                {
                    Console.WriteLine("Sad mother duck went out one day\nOver the hill and far away\nThe sad mother duck said,'Quack quack quack quack'\nAnd all of the 5 little ducks came back!");
                }
                else
                {
                    Console.WriteLine($"{i + 1} little ducks went swimming one day\nOver the hill and far away\nMother duck said, 'Quack quack quack quack'\nBut only {i} little ducks came back!\n");
                }
            }
            Console.ReadLine();
        }
    }
}
