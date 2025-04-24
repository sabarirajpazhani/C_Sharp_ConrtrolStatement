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
        static void Main(String[] args)
        {
            SwitchStatement();
        }
    }
}