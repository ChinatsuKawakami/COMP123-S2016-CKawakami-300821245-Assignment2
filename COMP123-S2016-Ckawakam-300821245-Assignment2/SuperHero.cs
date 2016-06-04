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
    class SuperHero:Hero
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
         * </summary>
         * @constructor SuperHero
         * @extends Hero
         * @params {string}name
         */
        SuperHero(string name)
            :base(name)
        {
            
            _generateRandomPowers();
        }

        //
    }
}
