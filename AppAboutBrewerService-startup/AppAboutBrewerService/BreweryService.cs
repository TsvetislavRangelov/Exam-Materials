using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutBrewerService
{
    public class BreweryService
    {
        private String name;
        private List<Brewer> brewers;
        private List<Tank> tanks;

        public BreweryService(String name)
        {
            this.name = name;
            this.brewers = new List<Brewer>();
            this.tanks = new List<Tank>();
        }

        public Brewer getBrewer(String id)
        {
            foreach(Brewer b in this.brewers)
            { if (b.Id == id) return b; }
            return null;
        }
        private Tank getTank(String id)
        {
            foreach (Tank t in this.tanks)
            { if (t.Id == id) return t; }
            return null;
        }

        public void AddBrewer(String name)
        {
            Brewer b = new Brewer(name);
            this.brewers.Add(b);
        }

        public bool AddTank(String id, int capacity)
        {
            Tank tankReturn = getTank(id);
            if(tankReturn == null)
            {
                Tank t = new Tank(id, capacity);
                this.tanks.Add(t);
                return true;
            }
            return false;
        }

        public String RequestTank(String brewerId, int amountOfBeer)
        {
            Tank tank = null;
            List<Tank> availableTanks = new List<Tank>();
            Brewer brewer = getBrewer(brewerId);
            foreach(var t in this.tanks)
            {
                if(t.Capacity >= amountOfBeer)
                {
                    availableTanks.Add(t);
                }
            }
            int smallestCapacity = Int32.MaxValue;
            foreach(var t in availableTanks)
            {
                if(t.Capacity < smallestCapacity)
                {
                    smallestCapacity = t.Capacity;
                    tank = t;
                }
            }

            if (availableTanks.Count == 0) return "";
            
            tank.Claim(brewer, amountOfBeer);
            return tank.Id;

        }

        public bool MakeTankEmpty(string brewerId, string tankId)
        {
            Tank tank = getTank(tankId);
            Brewer brewer = getBrewer(brewerId);

            if (brewer == null || tank == null || !brewer.HasTank(tank))
            {
                return false;
            }

            brewer.ReleaseTank(tank);
            return true;
        }

        public List<string> GetTanksInfo()
        {
            List<string> tanksInfo = new List<string>();
            foreach(var t in tanks)
            {
                tanksInfo.Add(t.GetInfo());
            }

            return tanksInfo;
        }

        public List<string> GetBrewersInfo()
        {
            List<string> brewersInfo = new List<string>();
            foreach(var b in brewers)
            {
                brewersInfo.Add(b.GetInfo());
            }
            return brewersInfo;
        }
    }
}
