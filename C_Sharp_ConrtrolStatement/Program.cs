using System;

namespace C_Sharp_ControlStatement
{
    public class Program
    {
        public static void SwitchStatement()
        {
            Console.WriteLine("Enter Your the Number to Get Lucky Tickets: ");
            int id = Convert.ToInt32(Console.ReadLine());

            switch (id)
            {
                case 1:
                    Console.WriteLine("Hello... You Got the IPL Ticket");
                    goto default;
                case 2:
                    Console.WriteLine("Hello... You Got the Movie Ticket");
                    goto default;
                case 3:
                    Console.WriteLine("Hey There.... You Got the Doni Fan Meet Ticket");
                    goto default;

                default:
                    Console.WriteLine("Your Entered Lucky Number is :" + id);
                    break;
            }
        }

        public static void ifElseStatement()
        {
            {
                Console.WriteLine("Enter your age to know you are eligible for voting or not");

                Console.Write("Enter your Age :");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age >= 18)
                {
                    Console.WriteLine("Your are Eligible for Voting :)");
                }
                else
                {
                    Console.WriteLine("Your not eligible for Voting :( ");

                }
            }
            
        }

        public static void ifStatement()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());  

            if(num < 10)
            {
                Console.WriteLine("Your Entered Mumber is Single Digit");
            }
        }

        public static void ifElseIfStatement()
        {
            int a = 100;
            int b = 150;
            int c = 50;

            if(a>b && a > c)
            {
                Console.WriteLine(" a is Greater than all");
            }

            else if (b > a && b > c)
            {
                Console.WriteLine("b is greater than all");
            }
            else
            {
                Console.WriteLine("c is greater than all");
            }
        }

        public static void nestedIfStatement()
        {
            Console.Write("Enter the Mumber: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num != 0)
            {
                if(num > 0)
                {
                    Console.WriteLine("Your Entered number is Positive");
                }
                else
                {
                    Console.WriteLine("Your Entered number is Negative");
                }
            }
            else
            {
                Console.WriteLine("Your Entered number is Zero");
            }
        }

        static void Main(String[] args)
        {
            //SwitchStatement();   
            //ifElseStatement();
            //ifStatement();
            //ifElseIfStatement();
            nestedIfStatement();
        }
    }
}