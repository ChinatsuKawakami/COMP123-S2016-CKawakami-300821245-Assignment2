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
    class SuperHero : Hero
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
                return _superPowers;
            }
            set
            {
                _superPowers = value;
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

            //this.Name = name;
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

            Random param = new Random();


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
                    Console.WriteLine(_superPowers[i]);
                }

            }
        }
    }
}




/*
 *  string[] list = new string[6];
list[0] = "\nSuper Speed : " + Convert.ToString(superSpeed);
list[1] = "\nSuper Strength : " + Convert.ToString(superStrength);
list[2] ="\nBody Armour : " + Convert.ToString(bodyArmour);
list[3] = "\nFlight : " + Convert.ToString(flight);
list[4] = "\nFire Generation : " + Convert.ToString(fireGeneration);
list[5] = "\nWeather Control : " + Convert.ToString(weatherContorol);
*/
/*
int[] list = new int[6];
list[0] = superSpeed;
list[1] = superStrength;
list[2] =bodyArmour;
list[3] = flight;
list[4] =fireGeneration;
list[5] =weatherContorol;
*/

// List<int> item = new List<int> {list[0],list[1],list[2],list[3],list[4],list[5]};
        /*
         * 
         * int i=0;
            int temp = -1;
            while(i<3)
            {
               
                if (i == 0 || temp != x)
                {
                    switch (x)
                    {
                        case 0:
                            _superPowers[i] = "\nSuper Speed : " + Convert.ToString(superSpeed);
                            break;
                        case 1:
                            _superPowers[i] = "\nSuper Strength : " + Convert.ToString(superStrength);
                            break;
                        case 2:
                            _superPowers[i] = "\nBody Armour : " + Convert.ToString(bodyArmour);
                            break;
                        case 3:
                            _superPowers[i] = "\nFlight : " + Convert.ToString(flight);
                            break;
                        case 4:
                            _superPowers[i] = "\nFire Generation : " + Convert.ToString(fireGeneration);
                            break;
                        case 5:
                            _superPowers[i] = "\nWeather Control : " + Convert.ToString(weatherContorol);
                            break;
  
                    } //close switch
                    temp = x;
                    i++;
                }// close if(i==0 || temp != x)
               


            } //close while loop
            }//close method

         * 
         * 
         * /
        /*

          Random ram = new Random();
                    List<string> item= new List<string>();
                    Random param = new Random();
                    int x = param.Next(0,7);
                        int superSpeed = param.Next(1, 101);
                        int superStrength = param.Next(1, 101);
                        int bodyArmour = param.Next(1, 101);
                        int flight = param.Next(1, 101);
                        int fireGeneration = param.Next(1, 101);
                        int weatherContorol = param.Next(1, 101);
                    int i;
                    for(i=0;i<3;i++){
                    switch(x)
                    {
                                case 0:
                                item[i] = "\nSuper Speed : "+ Convert.ToString(superSpeed);
                                break;
                            case 1:
                                item[i] ="\nSuper Strength : "+ Convert.ToString(superStrength);
                                break;
                            case 2:
                                item[i] = "\nBody Armour : "+Convert.ToString(bodyArmour);
                                break;
                            case 3:
                                item[i] = "\nFlight : " + Convert.ToString(flight);
                                break;
                            case 4:
                                item[i] =  "\nFire Generation : "+Convert.ToString(fireGeneration);
                                break;
                            case 5:
                                item[i] = "\nWeather Control : " + Convert.ToString(weatherContorol);
                                break;
         
                        } //close switch
            
                       // _superPowers[i] = item[i];
                       /// item.Remove(item[x]);//should be X
                

        */
        //*************************************************************
        // int i;
        /*
        for (i = 0; i < 3; i++)
        {
            Random param = new Random();
            int superSpeed = param.Next(1, 101);
            int superStrength = param.Next(1, 101);
            int bodyArmour = param.Next(1, 101);
            int flight = param.Next(1, 101);
            int fireGeneration = param.Next(1, 101);
            int weatherContorol = param.Next(1, 101);

            switch (x)
            {
                //There are 6 parameters for SuperHero
                case 0:
                    SuperPowers[i] = Convert.ToString(superSpeed);
                    break;
                case 1:
                    SuperPowers[i] = Convert.ToString(superStrength);
                    break;
                case 2:
                    SuperPowers[i] = Convert.ToString(bodyArmour);
                    break;
                case 3:
                    SuperPowers[i] = Convert.ToString(flight);
                    break;
                case 4:
                    SuperPowers[i] = Convert.ToString(fireGeneration);
                    break;
                case 5:
                    SuperPowers[i] = Convert.ToString(weatherContorol);
                    break;
            
            } //close switch


        }//close for loop
    }//close _generateRandomPowers()
    */
    

    

