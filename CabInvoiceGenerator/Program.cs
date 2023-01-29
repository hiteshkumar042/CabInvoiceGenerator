using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //UC1 & 2
            Ride[] multiRides = { new Ride(10, 15), new Ride(10, 15) };
            Console.WriteLine(InvoiceGenerator.CalculateFare(multiRides));
            Console.ReadLine();
        }
    }
}
