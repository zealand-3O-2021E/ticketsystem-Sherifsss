using System;
using ClassLibraryTicketSystem;

namespace OresundbronLibrary
{
    public class OresundbronCar : Vehicle
    {

        public OresundbronCar(string licensePlate, DateTime dateTime):base(licensePlate,dateTime)
        {
            LicensePlate = licensePlate;
            Date = dateTime;
            Brobiz = false;
        }

        public override double Price()
        {
            if(Brobiz)
            {
                return 161;
            }
            return 410;
        }

        public override string VehicleType()
        {
            return "Oresundbron car";
        }

        
    }
}
