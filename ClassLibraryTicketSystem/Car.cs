using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Car class that inherits from the Vehicle base class
    /// </summary>
    public class Car : Vehicle
    {
          /// <summary>
          /// Car class constructor that takes two parameters
          /// </summary>
          /// <param name="licensePlate"></param>
          /// <param name="dateTime"></param>

        public Car(string licensePlate, DateTime dateTime) : base(licensePlate, dateTime)
        {
            Date = dateTime;
            LicensePlate =licensePlate;
        }

        /// <summary>
        /// The price method from the base class being overriden here so that the needed message is applied
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
        /// The vehicle type method is being overriden here so that we get the desired return
        /// </summary>
        /// <returns></returns>

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
