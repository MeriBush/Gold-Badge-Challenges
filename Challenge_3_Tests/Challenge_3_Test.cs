using System;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class Challenge_3_Test
    {
        OutingRepository outingRepo = new OutingRepository();

        [TestMethod]
        public void OutingRepository_AddOuting_ShouldIncreaseCountByOne()
        {
            //--Arrange
            DateTime renOneDate = new DateTime(2016, 10, 15);
            DateTime renTwoDate = new DateTime(2016, 11, 15);

            Outing RenOne = new Outing("Renaissance Festival", 15, renOneDate, 15m);
            Outing RenTwo = new Outing("Renaissance Festival", 20, renTwoDate, 15m);

            outingRepo.AddOuting(RenOne);
            outingRepo.AddOuting(RenTwo);

            //--Act
            int actual = outingRepo.CountOutings();
            int expected = 2;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepository_GetOutingList_ShouldHaveCountOfTwo()
        {
            //--Arrange
            DateTime renOneDate = new DateTime(2016, 10, 15);
            DateTime renTwoDate = new DateTime(2016, 11, 15);

            Outing RenOne = new Outing("Renaissance Festival", 15, renOneDate, 15m);
            Outing RenTwo = new Outing("Renaissance Festival", 20, renTwoDate, 15m);

            outingRepo.AddOuting(RenOne);
            outingRepo.AddOuting(RenTwo);

            //--Act
            int actual = outingRepo.GetOutingList().Count;
            int expected = 2;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepository_CombineOutingCosts_ShouldReturnTotalCosts()
        {
            //-- Assert
            OutingRepository outingRepo = new OutingRepository();

            DateTime renOneDate = new DateTime(2016, 10, 15);
            DateTime renTwoDate = new DateTime(2016, 11, 15);
            DateTime concertDate = new DateTime(2017, 04, 03);

            Outing RenOne = new Outing("Renaissance Festival", 15, renOneDate, 15m);
            Outing RenTwo = new Outing("Renaissance Festival", 20, renTwoDate, 15m);
            Outing Concert = new Outing("Concert", 10, concertDate, 65m);

            outingRepo.AddOuting(RenOne);
            outingRepo.AddOuting(RenTwo);
            outingRepo.AddOuting(Concert);

            decimal totalbyType = outingRepo.CombineOutingCosts();

            //-- Act
            decimal actual = outingRepo.CombineOutingCosts();
            decimal expected = 1175m;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutingRepository_CombineOutingByType_ShouldReturnTotalCostByType()
        {
            //-- Assert
            OutingRepository outingRepo = new OutingRepository();

            DateTime renOneDate = new DateTime(2016, 10, 15);
            DateTime renTwoDate = new DateTime(2016, 11, 15);
            DateTime concertDate = new DateTime(2017, 04, 03);

            Outing RenOne = new Outing("Renaissance Festival", 15, renOneDate, 15m);
            Outing RenTwo = new Outing("Renaissance Festival", 20, renTwoDate, 15m);
            Outing Concert = new Outing("Concert", 10, concertDate, 65m);

            outingRepo.AddOuting(RenOne);
            outingRepo.AddOuting(RenTwo);
            outingRepo.AddOuting(Concert);

            decimal totalbyType = outingRepo.CombineOutingByType("Renaissance Festival");

            //-- Act
            decimal actual = outingRepo.CombineOutingByType("Renaissance Festival");
            decimal expected = 525m;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
