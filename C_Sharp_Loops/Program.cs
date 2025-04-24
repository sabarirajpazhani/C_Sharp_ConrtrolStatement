using System;
using System.Text.Json.Serialization.Metadata;

namespace C_Sharp_Loops
{
    public class Program
    {
        public static void forLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void whileLoop()
        {
            int num = 10;

            int i = 0;

            while (i <= num)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void doWhileLoop()
        {
            int num  = 20;
            int i = 21;
            do
            {
                Console.WriteLine("Hello World");
                i++;
            }
            while (i <= num);
        }
        static void Main(String[] args)
        {
            forLoop();
            whileLoop();
            doWhileLoop();

        }
    }
}
