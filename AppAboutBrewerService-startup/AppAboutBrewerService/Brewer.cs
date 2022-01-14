using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutBrewerService
{
    public class Brewer
    {
		private String name;
		private String id;
		private static int nextFreeNr = 210;
		private List<Tank> claimedTanks;

		public Brewer(String name)
        {
			this.name = name;
			this.id = GetUniqueId();
			this.claimedTanks = new List<Tank>();
        }

		public String Id
        {
            get { return this.id; }
        }

		private string GetUniqueId()
        {
			int uniqueId = nextFreeNr;
			nextFreeNr += 10;
			return $"br{uniqueId}";
        }

		public void ClaimTank(Tank t, int amountOfBeer)
        {
			this.claimedTanks.Add(t);
			t.Claim(this, amountOfBeer);
        }

		public void ReleaseTank(Tank t)
        {
			t.MakeFree();
			this.claimedTanks.Remove(t);
		}

		public String GetInfo()
        {
			return $"Name: {this.name}, Id: {this.id}, Nr. Tanks: {this.claimedTanks.Count()}";
		}

		public int GetTotalAmountOfBeer()
		{
			int total = 0;
			foreach (Tank tank in this.claimedTanks)
			{
				total += tank.AmountOfBeer;
			}
			return total;
		}

		public bool HasTank(Tank tank)
		{
			return this.claimedTanks.Contains(tank);
		}

	}
}
