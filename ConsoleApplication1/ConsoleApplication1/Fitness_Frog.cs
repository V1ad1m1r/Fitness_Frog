using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {

            double runningTotal = 0;
            while (true)
            {


                // Prompt User for minutes exercised
                System.Console.Write("Enter how many minutes you exercised, or type quit to exit.");

                var entry = System.Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }

                try
                {
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        System.Console.WriteLine("Enter a number!!!");
                        continue;
                    }
                    else if (minutes < 10)
                    {
                        System.Console.WriteLine("Better than nothing!");
                    }
                    else if (minutes < 30)
                    {
                        System.Console.WriteLine("Way To Go!!");
                    }
                    else
                    {
                        System.Console.WriteLine("YOUR A MACHINE!!!");
                    }

                    // Add minutes to get running total
                    runningTotal += minutes;

                    //display to screen

                    System.Console.WriteLine("You've exercised " + runningTotal + " minutes");
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Enter a number!!!");
                    continue;
                }




                // Repeat until user quits
            }

        }

    }
}
