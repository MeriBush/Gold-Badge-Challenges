using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Tests
{
    [TestClass]
    public class Challenge_1_Test
    {
        MenuRepository menuRepo = new MenuRepository();

        [TestMethod]
        public void MenuRepository_AddDrinkToMenu_ShouldIncreaseCountByOne()
        {
            //-- Arrange
            Menu komodoKlassic = new Menu("6", "Komodo Klassic", "Our original cup of joe just as it was brewed back in the fifties. We even kept the price the same!", "Water, Komodo Koffee Beans", 0.48m);
            menuRepo.AddDrinkToMenu(komodoKlassic);

            //-- Act
            int actual = menuRepo.CountMenuItems();
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_RemoveDrinkFromMenu_ShouldHaveCountofOne()
        {
            //-- Arrange
            Menu komodoKlassic = new Menu("6", "Komodo Klassic", "Our original cup of joe just as it was brewed back in the fifties. We even kept the price the same!", "Water, Komodo Koffee Beans", 0.48m);
            menuRepo.AddDrinkToMenu(komodoKlassic);
            Menu komochaccino = new Menu("7", "Komochaccinno", "A Komodo fusion of two classic favorites", "Water, Milk, Espresso, Chocolate", 4.49m);
            menuRepo.AddDrinkToMenu(komochaccino);

            menuRepo.RemoveDrinkFromMenu("Komochaccinno");

            //-- Act
            int actual = menuRepo.CountMenuItems();
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_GetMenu_ShouldGetAllDrinksOnMenu()
        {
            //-- Arrange
            Menu komodoKlassic = new Menu("6", "Komodo Klassic", "Our original cup of joe just as it was brewed back in the fifties. We even kept the price the same!", "Water, Komodo Koffee Beans", 0.48m);
            menuRepo.AddDrinkToMenu(komodoKlassic);
            Menu komochaccino = new Menu("7", "Komochaccinno", "A Komodo fusion of two classic favorites", "Water, Milk, Espresso, Chocolate", 4.49m);
            List<Menu> testList = new List<Menu>();
            menuRepo.AddDrinkToMenu(komochaccino);

            testList.Add(komodoKlassic);
            testList.Add(komochaccino);

            //-- Act
            int actual = menuRepo.getList().Count;
            int expected = 2;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_printList_ShouldReturnTrue()
        {
            //-- Arrange
            Menu komodoKlassic = new Menu("6", "Komodo Klassic", "Our original cup of joe just as it was brewed back in the fifties. We even kept the price the same!", "Water, Komodo Koffee Beans", 0.48m);
            menuRepo.AddDrinkToMenu(komodoKlassic);
            Menu komochaccino = new Menu("7", "Komochaccinno", "A Komodo fusion of two classic favorites", "Water, Milk, Espresso, Chocolate", 4.49m);
            List<Menu> testList = new List<Menu>();
            menuRepo.AddDrinkToMenu(komochaccino);

            testList.Add(komodoKlassic);
            testList.Add(komochaccino);

            //-- Act
            var actual = menuRepo.printDrinks();
            var expected = true;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
