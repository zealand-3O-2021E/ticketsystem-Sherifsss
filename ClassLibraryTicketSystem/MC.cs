using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// MC class that inherits from the Vehicle base class
    /// </summary>
    public class MC : Vehicle
    {

        /// <summary>
        /// MC class constructor that takes two parameters
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>

        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
            licensePlate = LicensePlate;
            date = Date;
        }
        /// <summary>
        /// The abstract price method from the base class is being overriden 
        /// if the brobiz is active (in this case it is) there is a discount of 5% applied
        /// </summary>
        /// <returns></returns>

        public override double Price()
        {
            if (Brobiz == true)
            {
                return 125 - (125 * 0.05);
            }
            return 125;
        }

        /// <summary>
        /// the veichle type method being overriden here so that it would display the needed message (MC)
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
