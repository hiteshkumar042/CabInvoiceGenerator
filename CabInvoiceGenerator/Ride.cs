using System;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;
        public double totalFare;
        public int MINIMUM_FARE = 5;
        public int COST_PER_KM = 10;
        public int COST_PER_MINUTE = 1;

        // UC1 - Method to calculate fare for single ride
        public double CalculateFare(double distance, int time)
        {
            try
            {
                if (time <= 0)
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_TIME, "Invalid Time");
                if (distance <= 0)
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                //Total fare for single ride
                totalFare = (distance * COST_PER_KM) + (time * COST_PER_MINUTE);
                //Comparing minimum fare and calculated fare to return the maximum fare
                return Math.Max(totalFare, MINIMUM_FARE);
            }
            catch (CabInvoiceException ex)
            {
                throw ex;
            }
        }
    }
}
