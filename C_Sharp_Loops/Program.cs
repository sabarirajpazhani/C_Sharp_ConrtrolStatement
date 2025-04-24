using System;
using System.Text.Json.Serialization.Metadata;

namespace C_Sharp_Loops
{
    public class Program
    {
        static void Main(String[] args)
        {
            int[] a = { 1, 2, 3, 4 };

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
