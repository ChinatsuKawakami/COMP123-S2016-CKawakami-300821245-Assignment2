using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 *This is driver class
 *Author: Chinatsu Kawakami
 *Date :June 4th 2016
 *Date Modified: June 6th 2016
 *Student Id: 300821245
 *Description: This program calls instance variables from Hero class and SuperHero class
 *and print Fight and Show method(They come from Hero class ), and ShowPowers(It comes from SuperHero class).
 *version : 0.0.8- updated the SuperHero class to make _generateRandomPowers method
 *
 */

namespace COMP123_S2016_Ckawakam_300821245_Assignment2
{
    /**
     * This is the driver class for our program , Assignment1
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * The Main method for our driver class program
         * 
         * @constructor: Main
         * @param {string[]}args
         */
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Mike");
            //call Show method
            hero1.Show();
            hero1.Fight();

            SuperHero super = new SuperHero("Jhon");
           
             super.ShowPowers();
           // super.Show();Same parameters appers with hero1 in Hero class


        }






    }
}
