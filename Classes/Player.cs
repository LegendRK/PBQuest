using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Created by: Rohit K
 * Purpose: To create a class that represents the player character
 * Last Edited: 7/13/17
 */
namespace PBQuest.Classes
{
    public class Player : Character
    {
        // attributes
        private enum Players { Flux, Silk, KRoll, Remedy}
        private Players id;
        private int speed;

        // properties
        // constructor
        public Player(string _name, int _health, int _id):base(_name, _health)
        {
            switch (_id)
            {
                case 0:
                    id = Players.Flux;
                    break;
                case 1:
                    id = Players.Silk;
                    break;
                case 2:
                    id = Players.KRoll;
                    break;
                case 3:
                    id = Players.Remedy;
                    break;
            }
        }

        // methods
        public void UseSkill()
        {
            if(id == Players.KRoll)
            {

            }
            else if(id == Players.Silk)
            {

            }
            else if(id == Players.Remedy)
            {

            }
        }

        public void Jump()
        {

        }



    }
}
