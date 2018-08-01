using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class Claim
    {
        //Constructors
        public Claim(int claimID, string claimType, string claimDescription, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValidKomodo)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValidKomodo = isValidKomodo;
        }

        //Properties
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string ClaimDescription { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValidKomodo { get; set; }

        //Override ToString
        public override string ToString()
        {
            return $"{ClaimID}\n" +
                $"{ClaimType}\n" +
                $"{ClaimDescription}\n" +
                $"{DateOfIncident}\n" +
                $"{DateOfClaim}" +
                $"{IsValidKomodo}";
        }
    }
}
