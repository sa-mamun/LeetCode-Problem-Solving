using System;

namespace LC_2011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            var input = Console.ReadLine();
            string[] operations = input.Split(',');
            if (operations.Length >= 1 && operations.Length <= 100)
            {
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operations[i].Contains("++X") || operations[i].Contains("X++"))
                        X++;
                    else if (operations[i].Contains("--X") || operations[i].Contains("X--"))
                        X--;
                }
            }
            Console.WriteLine(X);
            Console.ReadLine();
        }
    }
}
