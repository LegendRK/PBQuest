using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

/*
 * Created by: Rohit K
 * Purpose: hold all the code for generic game objects
 * Last Edited: 7/13/17
 */
namespace PBQuest
{
    public class GameObject
    {
        // attributes
        private Rectangle hitBox;
        public const double GRAVITY = 9.81f;

        // properties
        public int Width
        {
            get { return hitBox.Width; }
        }

        public int Height
        {
            get { return hitBox.Height; }
        }

        public int XVal
        {
            get { return hitBox.X; }
        }

        public int YVal
        {
            get { return hitBox.Y; }
        }

        // constructor
        public GameObject(bool dynamic = false)
        {

        }

        // methods
    }
}
