using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuRepository menuRepo = new MenuRepository();

            Menu komodoDragon = new Menu("1", "Komodo Dragon", "A Komodo twist on a chai tea latte", "Milk, Water, Chai Tea, Honey, Vanilla", 3.49m);
            Menu komocha = new Menu("2", "KoMocha", "A Mocha latte with a fiery twist!", "Milk, Espresso, Ground Cacao, Sugar, Cinnamon, Cayenne Pepper", 4.25m);
            Menu komodoKoffee = new Menu("3", "Komodo Koffee", "This classic Komodo blend is a customer favorite!", "Water, Fresh-ground Guatemalan coffee beans, natural and artificial flavors", 1.49m);
            Menu kappuccino = new Menu("4", "Komodo Kappuccino", "A cappuccino with a kick", "Milk, espresso, cinnamon, cayenne pepper", 3.99m);
            Menu iceDragon = new Menu("5", "Ice Dragon", "Prefer your coffee cold? Select your favorite Komodo blend served blended or poured over ice.", "Water, Fresh-ground Guatemalan coffee beans, natural and artificial flavors", 2.99m);

            menuRepo.AddDrinkToMenu(komodoDragon);
            menuRepo.AddDrinkToMenu(komocha);
            menuRepo.AddDrinkToMenu(komodoKoffee);
            menuRepo.AddDrinkToMenu(kappuccino);
            menuRepo.AddDrinkToMenu(iceDragon);

            bool cont = true;
            while(cont)
            {
                Console.Clear();
                Console.WriteLine("What do you want to do? Select a number.\n" +
                    "1) Add drink to menu\n" +
                    "2) Remove drink from menu\n" +
                    "3) View List\n" +
                    "4) Exit");
                string userAnswer = Console.ReadLine();

                switch (userAnswer)
                {
                    case "1":
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter drink number.");
                            string mealNumber = Console.ReadLine();

                            Console.WriteLine("Enter drink name.");
                            string mealName = Console.ReadLine();

                            Console.WriteLine("Enter drink description.");
                            string mealDescription = Console.ReadLine();

                            Console.WriteLine("Enter drink ingredients.");
                            string mealIngredients = Console.ReadLine();

                            Console.WriteLine("Enter drink price.");
                            string mealPriceString = Console.ReadLine();
                            decimal mealPrice = decimal.Parse(mealPriceString);

                            Menu newDrink = new Menu(mealNumber, mealName, mealDescription, mealIngredients, mealPrice);
                            menuRepo.AddDrinkToMenu(newDrink);

                            Console.Clear();
                            Console.WriteLine("Drink has been added! Do you want to add another drink? y/n");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "y") { }
                            else if (theAnswer == "n")
                                break;
                        }
                        break;

                    case "2":
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("What drink do you want to remove?");
                            string drinkName = Console.ReadLine();
                            menuRepo.RemoveDrinkFromMenu(drinkName);

                            Console.Clear();
                            Console.WriteLine("Drink has been removed! Do you want to remove another drink? y/n");
                            string theAnswer = Console.ReadLine();
                            if (theAnswer == "y") { }
                            else if (theAnswer == "n")
                                break;
                        }
                        break;

                    case "3":
                        Console.Clear();
                        menuRepo.printDrinks();
                        break;

                    case "4":
                        cont = false;
                        Console.Clear();
                        Console.WriteLine("Happy I could help!");
                        break;

                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
