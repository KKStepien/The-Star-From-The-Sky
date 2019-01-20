using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TheStarFromTheSky
{
    abstract class ObjectController : IObjectsController
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double V { get; set; }

       //public abstract int Modifier { get; }

        public ObjectController()
        {
            
        }

        public void Move(double yMove, double V)
        {
            double dy;
            dy = V * yMove;
            Y = Y + dy;
        }

        public double RandomX()
        {
            Random rnd = new Random();
            X = rnd.Next(0 , 1004);
            return X;
        }

        abstract public void Rysuj(Graphics g);
    }
}
