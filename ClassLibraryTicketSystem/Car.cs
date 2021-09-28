using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car : Vehicle
    {
          

        public Car(string licensePlate, DateTime dateTime) : base(licensePlate, dateTime)
        {
            Date = dateTime;
            LicensePlate =licensePlate;
        }

        /// <summary>
        /// License plate property modified so it has a max length of 7
        /// </summary>        


        public override double Price()
        {
            if (Brobiz==true)
            {
                return 240 - (240 * 0.05);
            }
            return 240;
        }
        /// <summary>
        /// Price method that returns a double value
        /// depending on if the brobiz is apllied it will give a discount
        /// </summary>
        /// <returns></returns>

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
