using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class BicycleParking
    {
        // Instance variables

        private double pricePerHour;
        private double surchargeElectricPerHour;
        private List<Bicycle> bicycles;

        // Properties
        public double GetPricePerHour()
        {
            return this.pricePerHour;
        }

        public double GetSurcharge()
        {
            return this.surchargeElectricPerHour;
        }

        // Constructor

        public BicycleParking(double pricePerHour, double surchargeElectricPerHour)
        {
            this.pricePerHour = pricePerHour;
            this.surchargeElectricPerHour = surchargeElectricPerHour;
            this.bicycles = new List<Bicycle>();
        }

        // Methods       

        private Bicycle GetBicycle(string ticketNumber)
        {
            foreach (Bicycle bicycle in this.bicycles)
            {
                if (ticketNumber == bicycle.GetTicket())
                {
                    return bicycle;
                } 
            }
            return null;
        }

        public string ParkBicycle(BicycleType type)
        {
            Bicycle parkedBicycle = new Bicycle(type);
            bicycles.Add(parkedBicycle);
            return parkedBicycle.GetTicket();
        }

        public double RetrieveBicycle(string ticketNumber, int hoursInParking, string zipcode)
        {
            Bicycle retrieved = GetBicycle(ticketNumber);
            retrieved.SetHours(hoursInParking);
            retrieved.SetZipcode(zipcode);

            retrieved.IsInParking = false;

            if(retrieved.Type == BicycleType.NORMAL)
            {
                return this.pricePerHour;
            }

            else if(retrieved.Type == BicycleType.ELECTRIC)
            {
                return this.pricePerHour + this.surchargeElectricPerHour;
            }

            else if(retrieved.Type == BicycleType.FOLDING)
            {
                return pricePerHour / 2;
            }

            else if(retrieved.Type == BicycleType.TANDEM)
            {
                return pricePerHour * 2;
            }

            else
            {
                return -1;
            }
        }
    }
}
