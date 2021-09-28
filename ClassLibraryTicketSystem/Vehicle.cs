using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        private string _licensePlate;

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

        public bool Brobiz { get; set; }

        public abstract double Price();

        public abstract string VehicleType();

    }
}
