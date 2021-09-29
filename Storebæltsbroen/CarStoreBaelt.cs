using System;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class CarStoreBaelt : Vehicle
    {
        public CarStoreBaelt(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            date = Date;
            licensePlate = LicensePlate;
            Brobiz = false;
        }

        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                if(Brobiz)
                {
                    double weekendDiscount = 240 - (240 * 0.2);
                    weekendDiscount = weekendDiscount - (weekendDiscount * 0.05);
                    return weekendDiscount;
                }
                return 240 - (240 * 0.2);
            }

            else if (Brobiz)
            {
                return 240 - (240 * 0.05);
            }
            return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
