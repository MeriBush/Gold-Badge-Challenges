using System;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_2_Tests
{
    [TestClass]
    public class Challenge_2_Test
    {
        ClaimRepository claimRepo = new ClaimRepository();

        [TestMethod]
        public void ClaimRepository_AddClaim_ShouldIncreaseCountByOne()
        {
            //--Arrange
            DateTime incidentOneTime = new DateTime(2018, 04, 25);
            DateTime claimOneTime = new DateTime(2018, 04, 27);

            Claim claimSmith = new Claim(101, "Car", "Car accident on 465", 400.00m, incidentOneTime, claimOneTime, true);
            claimRepo.AddClaim(claimSmith);

            //--Act
            int actual = claimRepo.CountClaims();
            int expected = 1;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_TakeNextClaim_ShouldHaveCountOfOne()
        {
            //--Arrange
            DateTime incidentOneTime = new DateTime(2018, 04, 25);
            DateTime claimOneTime = new DateTime(2018, 04, 27);

            DateTime incidentTwoTime = new DateTime(1999, 04, 01);
            DateTime claimTwoTime = new DateTime(1999, 04, 20);

            Claim claimSmith = new Claim(101, "Car", "Car accident on 465", 400.00m, incidentOneTime, claimOneTime, true);
            claimRepo.AddClaim(claimSmith);
            Claim claimJones = new Claim(102, "House", "spontaneous combustion", 1000000.00m, incidentTwoTime, claimTwoTime, true);
            claimRepo.AddClaim(claimJones);

            claimRepo.TakeNextClaim();

            //--Act
            int actual = claimRepo.CountClaims();
            int expected = 1;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_GetClaimQueue_ShouldHaveCountOfTwo()
        {
            //--Arrange
            DateTime incidentOneTime = new DateTime(2018, 04, 25);
            DateTime claimOneTime = new DateTime(2018, 04, 27);

            DateTime incidentTwoTime = new DateTime(1999, 04, 01);
            DateTime claimTwoTime = new DateTime(1999, 04, 20);

            Claim claimSmith = new Claim(101, "Car", "Car accident on 465", 400.00m, incidentOneTime, claimOneTime, true);
            claimRepo.AddClaim(claimSmith);
            Claim claimJones = new Claim(102, "House", "spontaneous combustion", 1000000.00m, incidentTwoTime, claimTwoTime, true);
            claimRepo.AddClaim(claimJones);

            //--Act
            int actual = claimRepo.GetClaimQueue().Count;
            int expected = 2;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_SeeNextClaimInQueue_ShouldReturnClaimSmith()
        {
            //--Arrange
            DateTime incidentOneTime = new DateTime(2018, 04, 25);
            DateTime claimOneTime = new DateTime(2018, 04, 27);

            DateTime incidentTwoTime = new DateTime(1999, 04, 01);
            DateTime claimTwoTime = new DateTime(1999, 04, 20);

            Claim claimSmith = new Claim(101, "Car", "Car accident on 465", 400.00m, incidentOneTime, claimOneTime, true);
            claimRepo.AddClaim(claimSmith);
            Claim claimJones = new Claim(102, "House", "spontaneous combustion", 1000000.00m, incidentTwoTime, claimTwoTime, true);
            claimRepo.AddClaim(claimJones);

            //--Act
            var actual = claimRepo.SeeNextClaimInQueue();
            var expected = claimSmith;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClaimRepository_printQueue_ShouldReturnTrue()
        {
            //--Arrange
            DateTime incidentOneTime = new DateTime(2018, 04, 25);
            DateTime claimOneTime = new DateTime(2018, 04, 27);

            DateTime incidentTwoTime = new DateTime(1999, 04, 01);
            DateTime claimTwoTime = new DateTime(1999, 04, 20);

            Claim claimSmith = new Claim(101, "Car", "Car accident on 465", 400.00m, incidentOneTime, claimOneTime, true);
            claimRepo.AddClaim(claimSmith);
            Claim claimJones = new Claim(102, "House", "spontaneous combustion", 1000000.00m, incidentTwoTime, claimTwoTime, true);
            claimRepo.AddClaim(claimJones);

            //--Act
            var actual = claimRepo.printQueue();
            var expected = true;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
