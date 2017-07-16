using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Created by: Rohit K
 * Purpose: To create the necessary character variables
 * Last Edited: 7/13/17
 */
namespace PBQuest.Classes
{
    public class Character : GameObject
    {
        // attributes
        private string name;
        private int health;

        // properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // constructor
        public Character(string nm, int hlth)
        {
            name = nm;
            health = hlth;
        }

        // methods
    }
}
