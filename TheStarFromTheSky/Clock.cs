using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheStarFromTheSky
{
    public partial class Clock : UserControl
    {
        public int Prog { get; set; }

        public delegate void ProgHandler (int przekroczenie);

        public event ProgHandler PrzekroczonoProg;

        private Color kolorWskaznika = Color.Yellow;
        public Color KolorWwskażnika
        {
            get { return kolorWskaznika; }
            set
            {
                kolorWskaznika = value;
                Refresh();
            }
        }
        private Color kolorKolka = Color.White;
        public Color KolorKolka
        {
            get { return kolorKolka; }
            set
            {
                kolorKolka = value;
                Refresh();
            }
        }
        private Color kolorWartosci = Color.Black;
        public Color KolorWartosci
        {
            get { return kolorWartosci; }
            set
            {
                kolorWartosci = value;
                Refresh();
            }
        }

        private int wartosc = 0;
        public int Wartosc
        {
            get { return wartosc; }
            set
            {
                wartosc = value;
                Refresh();
                if (wartosc == Prog && PrzekroczonoProg != null)
                {
                    PrzekroczonoProg(wartosc - Prog);
                }

            }
        }
        /// <summary>
        /// Wielkość kółka maskującego w procentach.
        /// </summary>

        private int wielkoscKolka = 40;
        public int WielkoscKolka
        {
            get { return wielkoscKolka; }
            set
            {
                wielkoscKolka = value;
                Refresh();
            }
        }

        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }

        private void Clock_Resize(object sender, EventArgs e)
        {
            Width = Height;
        }

        private void Clock_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPie(new SolidBrush(Color.FromArgb(KolorWwskażnika.R / 4, KolorWwskażnika.G / 4, KolorWwskażnika.B / 4))
                , 0, 0, Width, Height, -90, 360);
            e.Graphics.FillPie(new SolidBrush(KolorWwskażnika), 0, 0, Width, Height, -90, Wartosc*6);
            //e.Graphics.FillPie(new SolidBrush(Color.Yellow), 0, 0, Width, Height, -180 + Prog, 1);
            float srednicaKolka = Width * WielkoscKolka * 0.01f;
            float promienKolka = srednicaKolka / 2;
            e.Graphics.TranslateTransform(Width / 2, Width / 2);
            e.Graphics.FillEllipse(new SolidBrush(KolorKolka), -promienKolka, -promienKolka, srednicaKolka, srednicaKolka);
            var napis = e.Graphics.MeasureString(Wartosc.ToString(), this.Font);

            e.Graphics.DrawString(Wartosc.ToString(), this.Font, new SolidBrush(KolorWartosci), -napis.Width / 2, -napis.Height / 2);
        }
    }
}
