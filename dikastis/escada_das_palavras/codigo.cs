using System;

class Program
{
    static void Main(string[] args)
    {
        string palavra = Console.ReadLine();

        for (int i = 1; i <= palavra.Length; i++)
        {
            Console.WriteLine(palavra.Substring(0, i));
        }
    }
}
