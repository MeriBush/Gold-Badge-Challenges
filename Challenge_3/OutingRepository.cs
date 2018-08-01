using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        List<Outing> outingsList = new List<Outing>();

        public int CountOutings()
        {
            return outingsList.Count;
        }

        public List<Outing> GetOutingList()
        {
            return outingsList;
        }

        public void AddOuting(Outing outing)
        {
            outingsList.Add(outing);
        }

        public decimal CombineOutingCosts()
        {
            decimal outingCosts = 0;
            
            foreach(Outing outing in outingsList)
            {
                outingCosts += outing.CostOuting;
            }
            return outingCosts;
        }

        public decimal CombineOutingByType(string userInput)
        {
            decimal outingTypeCosts = 0;

            foreach(Outing outing in outingsList)
            {
                if(outing.OutingType == userInput)
                {
                    outingTypeCosts += outing.CostOuting;
                }

            }
            return outingTypeCosts;
        }
    }
}
