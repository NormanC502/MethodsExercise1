using System;

namespace MethodExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine("What is your favorite song by your favorite band?");
            string song = Console.ReadLine();



            Console.WriteLine($"The funny thing about being {userName}, is he loves the color {color}, some say reflects the hot or coldness of the heart depending on the shade!");
            Console.WriteLine($"His spirit animal if your into that sort of thing is a {animal}, Imagine {userName}, and a {animal} doing a duet of {song} by {band}!");
            Console.WriteLine("Love don't cost a thing!!!");

        }
    }
}
