using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// This is the base class, it has 3 properties : License plate, Date and Brobiz. It implements these properties to the child classes.
    /// Since it is an abstract class we can and do have some abstract methods in here
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// instance field for license plate
        /// </summary>
        private string _licensePlate;
        /// <summary>
        /// Base class constructor that takes 2 parameters
        /// We also check if the license plate is longer than 7 characters, if it is the system will throw an argument exception
        /// It also initializes the brobiz discount which is by default false
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="dateTime"></param>
        protected Vehicle(string licensePlate, DateTime dateTime)
        {
            
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("Too many characters in the license plate");
            }

            LicensePlate = licensePlate;
            Date = dateTime;
                       
            Brobiz = false;
        }
        /// <summary>
        /// License plate property that will be initialized in the child classes, makes sure there arent more than 7 characters
        /// Since properties dont support logic we have an instance field for this
        /// </summary>
        protected string LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Too many characters in the license plate");
                }
                _licensePlate = value;
            }
        }
        protected DateTime Date { get; set; }
        /// <summary>
        /// Brobiz is a boolean discount property which would be false by default
        /// </summary>
        public bool Brobiz { get; set; }

        /// <summary>
        /// An abstract method which is to be implemented in the children classes, its return type is a double
        /// </summary>
        /// <returns></returns>
        public abstract double Price();

        /// <summary>
        /// An abstract method which is to be implemented in the children classes, its return type is a string
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();

    }
}
