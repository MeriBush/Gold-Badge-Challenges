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
            //OPTION 3
            Console.SetCursorPosition(0, 0);
            Console.Write("ID:");

            Console.SetCursorPosition(9, 0);
            Console.Write("Type:");

            Console.SetCursorPosition(20, 0);
            Console.Write("Description:");

            Console.SetCursorPosition(47, 0);
            Console.Write("Amount:");

            Console.SetCursorPosition(60, 0);
            Console.Write("Date of Incident:");

            Console.SetCursorPosition(83, 0);
            Console.Write("Date of Claim:");

            Console.SetCursorPosition(103, 0);
            Console.Write("Validity:");

            //OPTION 2
            //Console.WriteLine("{0,-20} {1, -20} {2 , -30} {3, -20:N2} {4, -20} {5, -20} {6, -20}", "Claim ID:", "Claim Type:", "Claim Description:", "Claim Amount", "Date of Incident:", "Date of Claim", "Claim Validity");

            //OPTION 1
            //$"Claim ID:\t" 
            //$"Claim Type:\t" +
            //$"Claim Description:\t" +
            //$"Date of Incident:\t" +
            //$"Date of Claim:\t" +
            //$"Claim Validity:";

            int row = 1;
            foreach (Claim claim in claimQueue)
            {
                //OPTION 3
                Console.SetCursorPosition(0, row);
                Console.Write(claim.ClaimID);

                Console.SetCursorPosition(9, row);
                Console.Write(claim.ClaimType);

                Console.SetCursorPosition(20, row);
                Console.Write(claim.ClaimDescription);

                Console.SetCursorPosition(47, row);
                Console.Write(claim.ClaimAmount);

                Console.SetCursorPosition(60, row);
                Console.Write(claim.DateOfIncident.ToShortDateString());

                Console.SetCursorPosition(83, row);
                Console.Write(claim.DateOfClaim.ToShortDateString());

                Console.SetCursorPosition(103, row);
                Console.Write(claim.IsValidKomodo);

                row++;



                //OPTION 2
                //Console.WriteLine("{0,-20} {1, -20} {2 , -30} {3, -20} {4, -20} {5, -20} {6, -20}", claim.ClaimID, claim.ClaimType, claim.ClaimDescription, claim.ClaimAmount, claim.DateOfIncident.ToShortDateString(), claim.DateOfClaim.ToShortDateString(), claim.IsValidKomodo);

                //OPTION 1
                //Console.WriteLine($"{claim.ClaimID}\t\t" +
                //    $"{claim.ClaimType}\t" +
                //    $"{claim.ClaimDescription}\t" +
                //    $"{claim.DateOfIncident.ToShortDateString()}\t" +
                //    $"{claim.DateOfClaim.ToShortDateString()}\t" +
                //    $"{claim.IsValidKomodo}");
                //Console.WriteLine($"Claim ID: {claim.ClaimID}\n" +
                //    $"Claim Type: {claim.ClaimType}\n" +
                //    $"Claim Description: {claim.ClaimDescription}\n" +
                //    $"Date of Incident: {claim.DateOfIncident.ToShortDateString()}\n" +
                //    $"Date of Claim: {claim.DateOfIncident.ToShortDateString()}\n" +
                //    $"Claim Validity: {claim.IsValidKomodo}\n");
            }
            return true;
        }

        public Claim SeeNextClaimInQueue()
        {
            return claimQueue.Peek();
        }
    }
}
