using System;
using System.ComponentModel.DataAnnotations;

namespace c_Sharp_Arrays
{
    public class Program
    {
        public static void BasicArray()
        {
            Console.Write("Enter the array element: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }

        public static void Array1()
        {
            String[] str = new String[] { "c#", "Java", "c++", "C" };

            foreach (string i in str)
            {
                Console.WriteLine(i);
            }
        }


        static void Main(String[] args)
        {
            BasicArray();

            Array1();





        }
    }
}
