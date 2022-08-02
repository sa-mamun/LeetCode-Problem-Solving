using System;

namespace DefanginAnIPAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] values = input.Split('.');
            string a = string.Empty;
            for (int i = 0; i< values.Length; i++)
            {
                if (i != values.Length - 1)
                    a += values[i] + "[.]";
                else
                    a += values[i];
            }

            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
