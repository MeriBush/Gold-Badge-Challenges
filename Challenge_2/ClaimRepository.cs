using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        Queue<Claim> claimQueue = new Queue<Claim>();

        public int CountClaims()
        {
            return claimQueue.Count;
        }

        public void TakeNextClaim()
        {
            claimQueue.Dequeue();
        }

        public void AddClaim(Claim claim)
        {
            claimQueue.Enqueue(claim);
        }

        public Queue<Claim> GetClaimQueue()
        {
            return claimQueue;
        }

        public bool printQueue()
        {
            foreach (Claim claim in claimQueue)
            {
                Console.WriteLine($"Claim ID: {claim.ClaimID}\n" +
                    $"Claim Type: {claim.ClaimType}\n" +
                    $"Claim Description: {claim.ClaimDescription}\n" +
                    $"Date of Incident: {claim.DateOfIncident.ToShortDateString()}\n" +
                    $"Date of Claim: {claim.DateOfIncident.ToShortDateString()}\n" +
                    $"Claim Validity: {claim.IsValidKomodo}\n");
            }
            return true;
        }

        public Claim SeeNextClaimInQueue()
        {
            return claimQueue.Peek();
        }
    }
}
