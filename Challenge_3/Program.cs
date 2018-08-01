using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            OutingRepository outingRepo = new OutingRepository();

            DateTime renOneDate = new DateTime(2016, 10, 15);
            DateTime renTwoDate = new DateTime(2016, 11, 15);
            DateTime concertDate = new DateTime(2017, 04, 03);
            DateTime puttPuttDate = new DateTime(2018, 06, 16);
            DateTime comicConDate = new DateTime(2018, 07, 17);

            Outing RenOne = new Outing("Renaissance Festival", 15, renOneDate, 15m);
            Outing RenTwo = new Outing("Renaissance Festival", 20, renTwoDate, 15m);
            Outing Concert = new Outing("Concert", 10, concertDate, 65m);
            Outing PuttPutt = new Outing("Putt Putt Golf", 20, puttPuttDate, 15m);
            Outing ComicCon = new Outing("Comic Con", 12, comicConDate, 75m);

            outingRepo.AddOuting(RenOne);
            outingRepo.AddOuting(RenTwo);
            outingRepo.AddOuting(Concert);
            outingRepo.AddOuting(PuttPutt);
            outingRepo.AddOuting(ComicCon);

            bool cont = true;
            while(cont)
            {
                Console.Clear();
                Console.WriteLine($"Welcome to Komodo Outings! What would you like to do? (Please select the corresponding number):\n" +
                    $"1) View All Outings\n" +
                    $"2) Add Outing\n" +
                    $"3) View Total Outing Costs\n" +
                    $"4) View Total Outing Costs by Type\n" +
                    $"5) Exit");
                string userAnswer = Console.ReadLine();

                switch (userAnswer)
                {
                    case "1":
                        Console.Clear();
                        foreach (Outing outing in outingRepo.GetOutingList())
                        {
                            Console.WriteLine($"Outing Type: {outing.OutingType}\n" +
                                $"Total People in attendance: {outing.TotalPeople}\n" +
                                $"Date of Outing: {outing.Date.ToShortDateString()}\n" +
                                $"Cost per Person: {outing.CostPerson}\n" +
                                $"Total Cost of Outing: {outing.CostOuting}\n");
                        }
                        Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Is there anything else I can help you with? (y/n)");
                        string Answer = Console.ReadLine();
                        if(Answer == "y") { }
                        else
                        {
                            (cont) = false;
                            Console.Clear();
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Enter the event type:");
                        string outingType = Console.ReadLine();

                        Console.WriteLine("Enter the total number of people attending the event:");
                        string totalPeopleString = Console.ReadLine();
                        int totalPeople = Int32.Parse(totalPeopleString);

                        Console.WriteLine("Enter the date of the outing (MM/DD/YYYY):");
                        string dateString = Console.ReadLine();
                        DateTime date = DateTime.Parse(dateString);

                        Console.WriteLine("Enter the cost per person:");
                        string costPersonString = Console.ReadLine();
                        decimal costPerson = decimal.Parse(costPersonString);

                        Console.WriteLine($"The total cost of this outing is: {totalPeople*costPerson}");

                        Outing userInput = new Outing(outingType, totalPeople, date, costPerson);
                        outingRepo.AddOuting(userInput);

                        Console.Clear();
                        Console.WriteLine("Thank you! Your outing has been added to the Komodo Outings List.");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("The combined cost of all outings is $" + outingRepo.CombineOutingCosts());
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("What outing type do you need the total cost for?");
                        string type = Console.ReadLine();
                        Console.WriteLine("The combined cost of all " + type + " outings is $" + outingRepo.CombineOutingByType(type));
                        Console.ReadLine();
                        break;

                    case "5":
                        (cont) = false;
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
