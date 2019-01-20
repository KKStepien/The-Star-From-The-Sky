using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TheStarFromTheSky
{
    interface IObjectsController
    {
        //int Modifier { get; }
        void Move(double yMove, double V);
        double RandomX();
        void Rysuj(Graphics g);
    }
}
