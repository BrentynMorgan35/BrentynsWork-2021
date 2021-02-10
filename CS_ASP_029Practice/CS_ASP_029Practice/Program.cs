using System;

namespace CS_ASP_029Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int dayOftheweek;
            string myDay;

            Console.Write(" Please enter the day of the week (1 - Monday, 2 - Tuesday .... 5 - Friday) :");
            dayOftheweek =int.Parse(Console.ReadLine());

            switch (dayOftheweek)
            {
                case 1: myDay = "Monday";
                    Console.WriteLine(myDay);
                    break;
                case 2: myDay = "Tuesday";
                    Console.WriteLine(myDay);
                    break;
                case 3: myDay = "Wednesday";
                    Console.WriteLine(myDay);
                    break;
                case 4: myDay = "Thursday";
                    Console.WriteLine(myDay);
                    break;
                case 5: myDay = "Friday";
                    Console.WriteLine(myDay);
                    break;
               
      default:
                    break;
            }


        }
    }
}
