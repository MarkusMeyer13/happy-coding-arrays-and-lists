using System;

namespace HappyCoding.ArraysLists.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            var text = Console.ReadLine();
            CharacterCounter characterCounter = new CharacterCounter();
            characterCounter.CalculateCharacters(text);
            characterCounter.Print();

            //FunMaker funMaker = new();
            //funMaker.SumEvenNumbers();

            //Sample.ListSample();

            //Console.WriteLine();

            //Sample.DictionarySample();

            //Console.WriteLine();

            //FunMaker.Fun();


            Console.ReadLine();
        }
    }
}
