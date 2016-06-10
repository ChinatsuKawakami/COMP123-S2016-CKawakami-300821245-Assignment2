using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Ckawakam_300821245_Assignment2;
using System.Collections.Generic;

namespace UnitTestForMethod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void generateRandomPowersTestMethod()
        {
/*
            //Arrange
            SuperHero superhero = new SuperHero("Jack");
            Random ram = new Random();

            int x = ram.Next(0, 6);//0,1,2,3,4,5
            //Act
            bool check = (x == 0 || x == 1 || x == 2 || x == 3 || x == 4 || x == 5);
            bool expectedFail = (x == 6);

            //Assert   
            Assert.IsTrue(check);// Pass!! This test shows that x is between 0 and 5;
            */
            //Arrange 
            SuperHero super = new SuperHero("Tom");
            bool hasDuplicatePowers = false; 

            //Act 
            if (super.SuperPowers[0] == super.SuperPowers[1])
            {
                hasDuplicatePowers = true;
            }
            else if  (super.SuperPowers[1] == super.SuperPowers[2])
            {
                hasDuplicatePowers = true;
            }
            else if (super.SuperPowers[0] == super.SuperPowers[2])
            {
                hasDuplicatePowers = true;
            }
        

            //Assert 
          Assert.IsTrue(!hasDuplicatePowers);//Pass!!
            
        }
        [TestMethod]
        public void ShowPowersTestMethod()
        {
            //Arrange
          SuperHero superHero2 = new SuperHero("Jean");
            string [] array = {superHero2.SuperPowers[0],superHero2.SuperPowers[1],superHero2.SuperPowers[2]};
        
            //Act
            int length = superHero2.SuperPowers.Length;
            //Assert


            Assert.AreEqual(length,array.Length);//PASS!! That's shows ShowPowers Test Display Three Parameters of Super hero.
            
           
        }
    }
}
