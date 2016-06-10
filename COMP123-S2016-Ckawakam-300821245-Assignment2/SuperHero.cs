using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Ckawakam_300821245_Assignment2
{
    /**
     * <summary>
     * This is the SuperHero class it is deriverd from Hero class
     * </summary>
     * @class SuperHero
     * @extends Hero
     */
   public class SuperHero : Hero
    {
        //PRIVATE INSTANCE VARIABLES********************************************
        private string[] _superPowers;


        //PUBLIC PROPERTY*****************************************************
        /**
         * <summary>
         * This property, SuperPowers includes a getter and setter 
         * for the private instance variable _superPowers
         * </summary>
         * @property SuperPowers
         */

        public string[] SuperPowers
        {
            get
            {
                return this._superPowers;
            }
            set
            {
                this._superPowers = value;
            }
        }//close Public Property

        //CONSTRUCTOR****************************************************************************
        /**
         * <summary>
         * This is the empty default Constructor for the SuperHero class
         * This calls the _generateAbilities method
         * </summary>
         * @constructor SuperHero
         * @extends Hero
         * @params {string}name
         * 
         */
        public SuperHero(string name)
            : base(name)
        {

            //this.Name = name; don't need it because this has already done in constructor of base class  
            _generateRandomPowers();
        }


        //Private Method*******************************************************
        /**
         * <summary>
         * This method choose three parameters randomy from 6 parameters 
         * </summary>
         * method _generateRandomPowers
         * return{void}
         */
        private void _generateRandomPowers()
        {
            //This system is to choose only three parameters randomly
            Random ram = new Random();

         


            _superPowers = new string[3];
            List<string> item = new List<string> { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Contorol" };



           
            int x = ram.Next(0, 6);// between 0, 1, 2, 3, 4, 5 
            int i = 0;
            do
            {
                
                
        
             _superPowers[i] = item.ElementAt(x);
                item.RemoveAt(x);
                i++;
                x = ram.Next(0, 6 - i);
                
                
            } while (i < 3);
         

        }//close method




        //Public Method*******************************************************
        /**
         * <summary>
         * This method displays three parameters that was chose from _generateRandomPowers
         * </summary>
         * method ShowPowers
         * return{void}
         */
        public void ShowPowers()
        {

           
            for (int i = 0; i < 3; i++)
            {

                {
               
                    
                        Console.WriteLine("*******************************************************");
                        Console.WriteLine("*              Super Hero's parameters                *");
                        Console.WriteLine("*******************************************************");
                        Console.WriteLine("                     " + _superPowers[i] + "                   ");
                        Console.WriteLine("*******************************************************");
                    
                }

            }
        }



        }//close method



     
    }




    

    

