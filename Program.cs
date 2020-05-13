using System;

namespace assignment2_variables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Set up variables
            int cupsOfCoffee = 1;
            string fullName = "David Rygwelski";
            DateTime today = DateTime.Now;

            // Print values of variables
            Console.WriteLine(cupsOfCoffee + " " + fullName + " " + today);

            // Ask user for their name and display it.
            Console.Write("What is your name? ");
            var userName = Console.ReadLine();

            if (userName == "Alice")
            {
                Console.WriteLine($"Good morning {userName}");
            }
            else
            {
                Console.WriteLine($"Well hello, {userName}");
            }

            // Collect two number from the user
            Console.Write("Please enter a number ");
            string firstNumberAsString = Console.ReadLine();
            double firstOperand = double.Parse(firstNumberAsString);

            Console.Write("Enter a second number ");
            string secondNumberAsString = Console.ReadLine();
            double secondOperand = double.Parse(secondNumberAsString);

            // Perform different actions on the numbers
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            // Display contents of the results to the user
            Console.WriteLine($"The two numbers added equal {sum}");
            Console.WriteLine($"The second number subtracted from the first equals {difference}");
            Console.WriteLine($"The two numbers multiplied equal {product}");
            Console.WriteLine($"The first number divided by the second number equals {quotient}");
            Console.WriteLine($"The remainder after the first number is divided by the second number equals {remainder}");











        }
    }
}
