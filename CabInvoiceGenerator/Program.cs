using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator.");
            Ride ride = new Ride();
            double amount = ride.CalculateFare(30, 3);
            Console.WriteLine("Total Fare is : " + amount);
            Console.ReadLine();
        }
    }
}
