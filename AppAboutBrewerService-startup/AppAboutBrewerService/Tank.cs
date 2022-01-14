using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutBrewerService
{
    public class Tank
    {
		private String id;
		private int capacity;
		private int amountOfBeer;
        private Brewer brewer;

        public Tank(String id, int capacity)
        {
            this.id = id;
            this.capacity = capacity;
        }

        public Brewer Brewer
        {
            get { return this.brewer; }
        }

        public String Id
        {
            get { return this.id; }
        }

        public int AmountOfBeer
        {
            get { return this.amountOfBeer; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public bool IsFree
        {
            get { return this.brewer == null; }
        }

        public void Claim(Brewer b, int amountOfBeer)
        {
            this.brewer = b;
            this.amountOfBeer = amountOfBeer;

        }

        public void MakeFree()
        {
            this.brewer = null;
            this.amountOfBeer = 0;
        }

        public String GetInfo()
        {
            String amount = this.IsFree ? "is empty" : "amount of beer: " + this.amountOfBeer.ToString();
            return $"tankid: {this.id} , capacity: {this.capacity}, {amount}";
        }
        

	}
}
