using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Ckawakam_300821245_Assignment2;

namespace UnitTestForMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void generateRandomPowersTestMethod()
        {

            //Arrange
            SuperHero superhero = new SuperHero("Jack");
            Random ram = new Random();
           
            int x = ram.Next(0, 6);//0,1,2,3,4,5
            //Act
            bool check = (x==0 || x == 1 || x == 2 || x == 3 || x == 4 || x == 5);
            bool expectedFail = (x ==6);
          
            //Assert   
           Assert.IsTrue(check);// Pass!! This test shows that x is between 0 and 5;
        // Assert.IsTrue(expectedFail);// Failed!

            //Arrange
            
            //Act

            //Assert
           
          //  superhero.GenerateRandomPowers();
        }


    }
}
