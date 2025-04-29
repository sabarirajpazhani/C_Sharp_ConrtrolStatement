using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

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

            Console.WriteLine(str.GetLength(0));  //get the number of element in specific demensions
        }

        public static void arraysMethods()
        {
            int[] a = new int[6] { 10, 11, 2, 2, 40, 3 };

            Array.Sort(a);
            Array.Reverse(a);   

            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Length of the array: "+ a.Length);
            Console.WriteLine("Index: "+Array.IndexOf(a, 2));
            Console.WriteLine("Last Index: "+Array.LastIndexOf(a, 2));

            int[] copy = new int[a.Length];

            Array.Copy(a, copy, a.Length);

            Console.WriteLine("New copied array: ");
            foreach(int i in copy)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Array Element is exisit: ");
            Console.WriteLine(Array.Exists(a, x => x == 3));

            //resize the array
            Array.Resize(ref a, 7);
            Console.WriteLine("New length: "+ a.Length);
        }

        public static void importantMethods()
        {
            int[] arr = { 10, 30, 40, 60, 20, 80 };

            Console.WriteLine(Array.Exists(arr, x => x > 50));   //Exists
             
            int find = Array.Find(arr, x => x > 50);              //Find
            Console.WriteLine($"Find Method: {find}");

            int[] findAll = Array.FindAll(arr,x => x > 50);         //FindAll

            foreach(int i in findAll)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Maximum element : "+ arr.Max());
            Console.WriteLine("Minimum element : " + arr.Min());
        }

        public static void twoDemensionalArray()
        {
            int[,] arr = new int[2, 3];

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("No. of rows: "+ arr.GetLength(0));
            Console.WriteLine("No. columns: " + arr.GetLength(1));


            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }

            
        }

        public static void twoDemensionMethods()
        {
            int[,] arr = { { 1, 2, 3 }, { 5, 6, 7 } };

            arr.SetValue(10, 0, 2);        //setvalues

            Console.WriteLine("Setting values: ");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Get the value: "+arr.GetValue(0,2));
        }

        public static void threeDemension()
        {
            //int[,,] arr = new int[2, 2, 3];   //declaration

            int[,,] arr = new int[,,]
            {
                {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 9, 10, 11, 12 }
                },
                {
                    { 13, 14, 15, 16 },
                    { 17, 18, 19, 20 },
                    { 21, 22, 23, 24 }
                },
                {
                    { 25, 26, 27, 28 },
                    { 29, 30, 31, 32 },
                    { 33, 34, 35, 36 }
                }
            };
              
            Console.WriteLine("Depth Length: "+arr.GetLength(0));   //depath - 0
            Console.WriteLine("Row Length: " + arr.GetLength(1));   // row - 1
            Console.WriteLine("Row Length: " + arr.GetLength(2));   // clo - 2

            Console.WriteLine("Particular Value: " + arr[1, 0, 2]);


            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(1); j++)
                {
                    for(int k=0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"({i},{j},{k}) - "+arr[i, j, k]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void jaggedArray()
        {
            int[][] arr = new int[3][];

            arr[0] = new int[] { 1, 2 };
            arr[1] = new int[] { 3, 4, 5 };
            arr[2] = new int[] { 6 };

            for(int i =0; i< arr.GetLength(0); i++)
            {
                foreach(int j in arr[i])
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }

        public static void DateTimeInfo()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Date and Time: " + now);

            DateTime utc = DateTime.UtcNow;

            DateOnly date = DateOnly.FromDateTime(DateTime.Now);
            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now);

            Console.WriteLine("Date: " + date);
            Console.WriteLine("Time: " + time);

            TimeZoneInfo india = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime LocalTime = TimeZoneInfo.ConvertTimeFromUtc(utc, india);

            TimeZoneInfo sweden = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            DateTime swedenTime = TimeZoneInfo.ConvertTimeFromUtc(utc, sweden);

            Console.WriteLine("Indian Time" + LocalTime);
            Console.WriteLine("Sweden Time" + swedenTime);  
        }
        static void Main(String[] args)
        {
            //BasicArray();

            //Array1();

            //arraysMethods();

            //importantMethods();

            ////-------------------------------- Multi Demensional Array -----------------------------

            //twoDemensionalArray();
            //twoDemensionMethods();

            //threeDemension();

            //jaggedArray();

            DateTimeInfo();
        }
    }
}
