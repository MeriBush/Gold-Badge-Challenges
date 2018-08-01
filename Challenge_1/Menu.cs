using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Menu
    {
        //Constructor
        public Menu(string number, string name, string description, string ingredients, decimal price)
        {
            MealNumber = number;
            MealName = name;
            MealDescription = description;  
            MealIngredients = ingredients;
            MealPrice = price;
        }

        //Properties
        public string MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public decimal MealPrice { get; set; }

        //Override of ToString
        public override string ToString()
        {
            string stringToReturn = $"{MealNumber}\n" +
                $"{MealName}\n" +
                $"{MealDescription}\n" +
                $"{MealIngredients}\n" +
                $"{MealPrice}";
            return stringToReturn;
        }
    }
}
