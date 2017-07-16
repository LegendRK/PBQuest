using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Created by: Rohit K
 * Purpose: To hold the data for generic enemies
 * Last Edited: 7/13/17
 */
namespace PBQuest.Classes
{
    public class Enemy : Character
    {
        // attributes
        private bool isBoss;
        private int aiType;

        // properties


        // constructor
        public Enemy(string nm, int hlth, bool boss, int aiType):base(nm, hlth)
        {

        }
        // methods
    }
}
