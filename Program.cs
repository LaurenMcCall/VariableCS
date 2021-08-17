using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {

            //Practice Creating Variables
            int numberOfCupsOfCoffee = 0;
            string fullName = "Lauren McCall";
            DateTime today = DateTime.Now;
            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);

            //Practice Getting Input From the User
            Console.Write("Enter your gamer tag: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");
            if (userName == "Alice")
            {
                Console.WriteLine("Welcome to the tea party!");
            }

            //Practice Getting Different Types of Input From the User
            Console.Write("Enter a number: ");
            string firstNumberAsString = Console.ReadLine();
            Console.Write("Enter another number: ");
            string secondNumberAsString = Console.ReadLine();

            //Converting String Input Into Numbers
            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);

            //Doing Math
            double sum = firstOperand + secondOperand;
            double difference = firstOperand - secondOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);

        }
    }
}
