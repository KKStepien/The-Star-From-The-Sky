using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TheStarFromTheSky
{
    class MeteorController : ObjectController
    {
        private Image obraz;

        public MeteorController()
        {
            obraz = Image.FromFile("meteor_32.png");
            X = RandomX();
        }

        public override void Rysuj(Graphics g)
        {
            var m = g.Transform;
            g.TranslateTransform((float)X, (float)Y);
            g.DrawImage(obraz, -obraz.Width / 2, -obraz.Height / 2);
            g.Transform = m;
        }
    }
}
