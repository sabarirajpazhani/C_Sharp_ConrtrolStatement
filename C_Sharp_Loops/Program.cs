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

        public static void infinateLoop()
        {
            for(; ; )
            {
                Console.WriteLine("Hello");
            }
        }

        public static void forEachInLoop()
        {
            char[] ch = { 'f', 'm', 'm', 'f', 'm' };

            int maleCount = 0;
            int femaleCount = 0;

            foreach(char i in ch)
            {
                if (i == 'm'){
                    maleCount++;
                }
                if (i == 'f')
                {
                    femaleCount++;
                }
            }

            Console.WriteLine($"Male count is {maleCount}");
            Console.WriteLine($"Female Count is {femaleCount}");

        }
        static void Main(String[] args)
        {
            forLoop();
            whileLoop();
            doWhileLoop();
            infinateLoop();

            forEachInLoop();

        }
    }
}
