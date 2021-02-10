using System;

namespace CS_ASP_30Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int inValue = 0;
            string inString;

            Console.WriteLine(" Enter your age :");
            inString = Console.ReadLine();

            while (int.TryParse(inString, out inValue)== false)
            {
                Console.WriteLine("Hey stupid enter an Interger");
                Console.WriteLine("Please re-enter value :");
                inString = Console.ReadLine();
            }

            Console.WriteLine("You enetered :" + inValue);

            Console.ReadLine();



        }
    }
}
