using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class Bicycle
    {
        // Instance variables
        private static int ticketSeeder = 10000;

        private string ticketNumber;
        private int hoursInParking;
        private string ownerZipcode;
    

        // Properties
        
        public BicycleType Type { get; private set; }

        public bool IsInParking
        {
            get
            {
                if(this.hoursInParking == 0)
                {
                    return true;
                }
                return false;
            }
            set { }
        }



        // Constructor

        public Bicycle(BicycleType type)
        {
            this.ticketNumber = GetUniqueTicket();
            this.Type = type;
            this.IsInParking = true;

        }
        
      
        public string GetInfo()
        {
            string s = this.ticketNumber + ": " + this.Type.ToString() + " bicycle";
            if (!this.IsInParking)
            {
                s += " - hours parked " + this.hoursInParking;
                s += " & owner zipcode "+ this.ownerZipcode;
            }
            return s;
        }

        public void SetZipcode(string zipcode)
        {
            if(zipcode == String.Empty)
            {
                this.ownerZipcode = "Unknown";
            }
        }

        public void SetHours(int hoursInParking)
        {
            if(hoursInParking <= 0)
            {
                this.hoursInParking = 1;
            }
        }

        private string GetUniqueTicket()
        {
            string biketype = this.Type.ToString();
            string letters = biketype.Substring(0, 3);

            int uniqueTicket = ticketSeeder;
            ticketSeeder += 1;
            return $"{letters} {ticketSeeder}";
        }

        public string GetTicket()
        {
            return this.ticketNumber;
        }
    }
}
