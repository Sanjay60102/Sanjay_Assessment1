


/*You deposit Rs 1000.00 in the bank account at 5% annual compound interest. 
The interest is paid once at the end of the year
What if you are interested in earning more than 100000? How long will it take to reach this mark?*/

using System;

class Exercise1
{
    static void Main()
    {
        double initialAmount = 1000.00; // Initial deposit
        double rate = 0.05; // Annual compound interest rate
        double target = 100000.00; // Target amount
        int years = 0;

        while (initialAmount < target)
        {
            initialAmount += initialAmount * rate; // Calculate compound interest
            years++; // Increment the number of years
        }

        Console.WriteLine("It will take " + years + " years to reach Rs 100,000.00.");
    }
}
