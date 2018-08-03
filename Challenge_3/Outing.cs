using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    //public enum OutingTypeEnum
    //{
    //    RenFest, Concert, PuttPutt, ComicCon
    //}

    public class Outing
    {
        //Constructor
        public Outing(string outingType, int totalPeople, DateTime date, decimal costPerson)
        {
            OutingType = outingType;
            TotalPeople = totalPeople;
            Date = date;
            CostPerson = costPerson;
        }

        //Properties
        public string OutingType { get; set; }
        public int TotalPeople { get; set; }
        public DateTime Date { get; set; }
        public decimal CostPerson { get; set; }
        public decimal CostOuting => TotalPeople * CostPerson;

        //Override ToString
        public override string ToString()
        { 
            return $"{OutingType}\n" +
                $"{TotalPeople}\n" +
                $"{Date}\n" +
                $"{CostPerson}\n" +
                $"{CostOuting}";
        }
    }
}
