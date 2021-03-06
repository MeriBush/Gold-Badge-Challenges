﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaimRepository claimRepo = new ClaimRepository();

            DateTime incidentOneTime = new DateTime(2018, 04, 25);
            DateTime claimOneTime = new DateTime(2018, 04, 27);

            Claim claimSmith = new Claim(101, "Car", "Car accident on 465", 400.00m, incidentOneTime, claimOneTime, true);
            claimRepo.AddClaim(claimSmith);

            bool cont = true;
            while(cont)
            {
                Console.Clear();
                Console.WriteLine($"What do you want to do? Please select a number:\n" +
                    $"1) See all claims\n" +
                    $"2) Take care of the next claim\n" +
                    $"3) Enter a new claim\n" +
                    $"4) Exit");
                string userAnswer = Console.ReadLine();

                switch (userAnswer)
                {
                    case "1":
                        Console.Clear();
                        claimRepo.printQueue();
                    break;

                    case "2":
                        Console.Clear();

                        Console.SetBufferSize(150, 150);

                        Claim peek = claimRepo.SeeNextClaimInQueue();
                        Console.SetCursorPosition(0,0);
                        Console.Write("ID:");
                        Console.SetCursorPosition(0, 1);
                        Console.Write(peek.ClaimID);
                        //Console.WriteLine($"Claim ID: {peek.ClaimID}\n" +
                        Console.SetCursorPosition(9,0);
                        Console.Write("Type:");
                        Console.SetCursorPosition(9, 1);
                        Console.Write(peek.ClaimType);
                        //$"Claim Type: {peek.ClaimType}\n" +
                        Console.SetCursorPosition(20, 0);
                        Console.Write("Description:");
                        Console.SetCursorPosition(20, 1);
                        Console.Write(peek.ClaimDescription);
                        //$"Claim Description: {peek.ClaimDescription}\n" +
                        Console.SetCursorPosition(47, 0);
                        Console.Write("Amount:");
                        Console.SetCursorPosition(47, 1);
                        Console.Write(peek.ClaimAmount);
                        //$"Claim Amount: {peek.ClaimAmount}\n" +
                        Console.SetCursorPosition(60, 0);
                        Console.Write("Date of Incident:");
                        Console.SetCursorPosition(60, 1);
                        Console.Write(peek.DateOfIncident.ToShortDateString());
                        //$"Date of Incident: {peek.DateOfIncident}\n" +
                        Console.SetCursorPosition(83, 0);
                        Console.Write("Date of Claim:");
                        Console.SetCursorPosition(83, 1);
                        Console.Write(peek.DateOfClaim.ToShortDateString());
                        //$"Date of Claim: {peek.DateOfClaim}\n" +
                        Console.SetCursorPosition(103, 0);
                        Console.Write("Validity:");
                        Console.SetCursorPosition(103, 1);
                        Console.Write(peek.IsValidKomodo);
                        //$"Claim Validity: {peek.IsValidKomodo}\n");

                        Console.WriteLine("\n\nDo you want to be assigned as the agent for this claim? y/n");
                        string agentAssignment = Console.ReadLine();
                        if (agentAssignment == "y")
                        {
                            claimRepo.TakeNextClaim();
                            Console.WriteLine("You have been assigned as the agent for this claim.");
                        }
                        else
                        {
                            Console.WriteLine("This claim will remain in the queue.");
                        }
                        break;

                    case "3":
                        Console.Clear();
                        while (true)
                        {
                            bool isValidKomodo = true;

                            Console.Clear();
                            Console.WriteLine("Enter the Claim ID:");
                            string claimIDString = Console.ReadLine();
                            int claimID = Int32.Parse(claimIDString);

                            Console.WriteLine("Enter claim type (Car, Home, or Theft:");
                            string claimType = Console.ReadLine();

                            Console.WriteLine("Enter claim description:");
                            string claimDescription = Console.ReadLine();

                            Console.WriteLine("Enter amount of damage:");
                            string claimAmountString = Console.ReadLine();
                            decimal claimAmount = decimal.Parse(claimAmountString);

                            Console.WriteLine("Enter date of incident (MM/DD/YYYY):");  //how to I manage how DateTime appears?
                            string dateOfIncidentString = Console.ReadLine();
                            DateTime dateOfIncident = DateTime.Parse(dateOfIncidentString);

                            Console.WriteLine("Enter date of claim:");  //how to I manage how DateTime appears?
                            string dateOfClaimString = Console.ReadLine();
                            DateTime dateOfClaim = DateTime.Parse(dateOfClaimString);

                            TimeSpan span = new TimeSpan(30, 0, 0, 0);
                            if(dateOfClaim - dateOfIncident <= span)
                                isValidKomodo = true;
                            else if(dateOfClaim - dateOfIncident > span)
                            {
                                isValidKomodo = false;
                                Console.WriteLine("I'm sorry, we cannot process your claim because it occurred outside our 30-day claim period.");
                                break;
                            }
                            Claim userInput = new Claim(claimID, claimType, claimDescription, claimAmount, dateOfIncident, dateOfClaim, isValidKomodo);
                            claimRepo.AddClaim(userInput);

                            Console.WriteLine("Thank you! Your claim is being processed.");
                            break;
                        }
                        break;

                    case "4":
                        (cont) = false;
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        break;
                }
                Console.ReadLine();
            }
        }

        //DateTime claim = DateTime.Parse(Console.ReadLine());
        //TimeSpan span = new TimeSpan (30, 0, 0, 0)
        //if claim - incident <= span)>
    }
}
