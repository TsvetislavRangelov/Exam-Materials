using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutBrewerService
{
    public partial class Form1 : Form
    {
        private BreweryService bs;
        public Form1()
        {
            InitializeComponent();
            
            this.bs = new BreweryService("BrewStore");
            addSomeTestingStuff();
        }

        private void btnShowTanks_Click(object sender, EventArgs e)
        {
 
        }

        private void btnShowBrewers_Click(object sender, EventArgs e)
        {

        }
 

        private void btnRequestForTank_Click(object sender, EventArgs e)
        {
 
        }

        private void btnMakeTankEmpty_Click(object sender, EventArgs e)
        {
 
        }


        private void btnShowBrewerInfo_Click(object sender, EventArgs e)
        {
 
        }

        private void addSomeTestingStuff()
        {
            this.bs.AddTank("A1", 300);
            this.bs.AddTank("buk2", 200);
            this.bs.AddTank("buk3", 450);
            this.bs.AddTank("A3", 250);
            this.bs.AddTank("A5", 300);
            this.bs.AddTank("A6", 200);
            this.bs.AddTank("D4", 3000);
            this.bs.AddTank("D2", 5000);
            this.bs.AddTank("buk5", 220);
            this.bs.AddTank("buk6", 50);

            this.bs.AddBrewer("Erik Schriekie");
            this.bs.AddBrewer("Antoinette Smal");
            this.bs.AddBrewer("Anibas Vachepen");
            this.bs.AddBrewer("Marian Hunter");
            this.bs.AddBrewer("Basjan van Vucht");
            this.bs.AddBrewer("Bert Ravelo");

        }
    }
}
