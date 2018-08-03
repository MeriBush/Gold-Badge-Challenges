using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{

    public class MenuRepository
    {
        //--2--
        //--3--
        private List<Menu> drinks = new List<Menu>();

        //--4--
        public int CountMenuItems()
        {
            return drinks.Count;
        }

        //--5--
        public void AddDrinkToMenu(Menu drink)
        {
            drinks.Add(drink);
        }

        //--6--
        public void RemoveDrinkFromMenu(string name)
        {
            //--7--
            int theIndex = drinks.FindIndex(drink => drink.MealName == name);
            drinks.RemoveAt(theIndex);
        }

        //--8--
        public List<Menu> getList()
        {
            return drinks;
        }

        //--9--
        public bool printDrinks()
        {
            foreach (Menu drink in drinks)
            {
                Console.WriteLine($"{drink}\n");
            }
            return true;
        }
    }
}




//NOTES

//--2-- 
//Dear human, here I am in MenuRepository to learn learn about menuRepo's mystical powers.

//--3--
//Looks like menuRepo contains a list named "drinks." This list is full of the objects from the Menu class. It's very private though, and is shy about communicating outside of
//this folder. The list named drinks will need a more extroverted friend to help it communicate with other files in this assembly or solution.

//--4--
//Oooo, here are some of menuRepo's mystical powers you told me about! Looks like it can count the number of Menu objects in the "drinks" list. That's cool!
//I see that it can not only count the number of drinks in the list, but it will also pretend to be that integer if I shout the name of the list and tell it to count,
//like this:  "drinks.Count"

//--5-- 
//Looks like menuRepo can also add objects from the menu (we'll just generalize and call each one "drink") to the list called "drinks!" That's handy.

//--6-- 
//And of course, menuRepo can also remove an object of the Menu class (aka, a drink) from the "drinks" list. This looks a little more complicated, though...

//--7--
//How does menuRepo know which drink you, the user, wants to remove? Well, it uses a string that you enter (we'll call this string "name" and an integer that you've named
//"theIndex." What is theIndex? I'm glad you asked!
//theIndex is an integer produced when the method FindIndex goes hunting in the List entitled "drinks." It is looking for an object of the Menu class (aka "drink").
//It will know it has find the right drink when the drink's MealName (I'll go look in the Menu class if I need to understand that better) is the same as the string "name" that you
//entered.  When drink.MealName and the string you enter line up, theIndex will remove the corresponding object (aka object of the menu class aka drink).

//--8--
//Okay, so you know how I said that the list called "drinks" would need a more extroverted friend to help it communicate outside of this file? Well, I think that this is its friend!
//It looks like the list named "drinks" has a friend named "getList" that is willing to dress up like the list named "drinks" fror public appearances outside of this file. That way drinks
//can keep a low profile while still making public appearances. D'awwwww, that's so sweet of getList()!

//--9--
//So, it looks like another mystical power of menuRepo is to print to the console. This mystical power (aka "method" or "function" is named "printDrinks()"
//For each drink (remember, it's an object of the menu class) that this mystical power finds in the list named "drinks," it will print all the info about that drink to the
//console window. Sweet!