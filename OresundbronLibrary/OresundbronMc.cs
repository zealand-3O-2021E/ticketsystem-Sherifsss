using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace OresundbronLibrary
{
    public class OresundbronMc : Vehicle
    {
        public OresundbronMc(string licensePlate, DateTime dateTime):base(licensePlate,dateTime)
        {
            LicensePlate = licensePlate;
            Date = dateTime;
            Brobiz = false;
        }

        public override double Price()
        {
            if(Brobiz)
            {
                return 73;
            }
            return 210;
        }

        public override string VehicleType()
        {
            return "Oresundbron Mc";
        }
    }
}
