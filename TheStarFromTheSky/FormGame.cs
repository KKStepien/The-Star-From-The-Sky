using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheStarFromTheSky
{
    public partial class FormGame : Form
    {
        //public delegate void ProgLive (int przekroczenie);

        //public event Action<int> EndLive;

        const int SCREEN_HEIGHT = 617;
        const int SCREEN_WEIGHT = 1004;
        const int ICON_PIXEL_HALF = 16;
        private int level = 1;
        public int Level
        {
            get { return level; }
            set
            {
                level = value;
            }
        }
        private int live = 3;
        public int Live
        {
            get { return live; }
            set
            {
                live = value;
                Refresh();
                if (live == 0)
                {
                    this.timer1.Stop();
                    this.timer2.Stop();
                    user.Scores = AllPoints + Points;
                    FormEnd end = new FormEnd(user);
                    end.ShowDialog();
                    this.Close();
                }

            }
        }
        private int points = 0;
        public int Points
        {
            get { return points; }
            set
            {
                points = value;
            }
        }
        private int allPoints = 0;
        public int AllPoints
        {
            get { return allPoints; }
            set
            {
                allPoints = value;
            }
        }
        private int needPoints;

        private List<ObjectController> objects;
        private User user;
        public FormGame(User user)
        {
            InitializeComponent();
            this.user = user;
            objects = new List<ObjectController>();
            objects.Add(new StarController());

            label2.Text = Level.ToString();
            LiveLabel4.Text = Live.ToString();
            AllScoreLabel5.Text = AllPoints.ToString();
            ScoresLabel11.Text = Points.ToString();
            needPoints = Level * 10;
            Needlabel5.Text = needPoints.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock1.Wartosc++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (var obj in objects)
            {
                obj.Move(0.5, 15);
            }
            Refresh();
            int resizer = (gamer1.SizeGamer);
            foreach (var obj in objects)
            {
                if (obj.X >= (gamer1.Location.X-ICON_PIXEL_HALF) && obj.X <= (gamer1.Location.X + resizer+ICON_PIXEL_HALF)
                    && (obj.Y >= gamer1.Location.Y) && obj.Y < SCREEN_HEIGHT)
                {
                    if (obj is StarController)
                    {
                        Points = Points + 1;
                    }
                    else if (obj is MeteorController)
                    {
                        Live = Live - 1;
                    }
                    objects.Remove(obj);
                    LiveLabel4.Text = Live.ToString();
                    ScoresLabel11.Text = Points.ToString();
                    break;
                }
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            objects.Add(new StarController());
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            objects.Add(new MeteorController());
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            objects.Add(new StarController());
        }

        private void clock1_PrzekroczonoProg(int obj)
        {
            clock1.Wartosc = 0;

            if (Live > 0 && Points >= needPoints)
            {
                AllPoints = AllPoints + Points;
                AllScoreLabel5.Text = AllPoints.ToString();
                Level++;
                Points = 0;
                label2.Text = Level.ToString();
                ScoresLabel11.Text = Points.ToString();
                needPoints = Level * 10;
                Needlabel5.Text = needPoints.ToString();
                
            }
            else if(Live > 0 && Points < needPoints)
            {
                Live--;
                LiveLabel4.Text = Live.ToString();
                Points = 0;
                ScoresLabel11.Text = Points.ToString();
            }
            if (Live == 0)
            {
                AllPoints = AllPoints + Points;
                AllScoreLabel5.Text = AllPoints.ToString();
                clock1.KolorWwskażnika = Color.Red;
                this.timer1.Stop();
                this.timer2.Stop();
            }
        }

      

        private void gamer1_Load_1(object sender, EventArgs e)
        {
            if (user.Level == "BEGINNER")
            {
                gamer1.SizeGamer = 70;
            }
            else if (user.Level == "INTERMEDIATE")
            {
                gamer1.SizeGamer = 50;
            }
            else
            {
                gamer1.SizeGamer = 30;
            }

            gamer1.Location = new Point(1, SCREEN_HEIGHT - (gamer1.SizeGamer));

        }

        private void GamePanel6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, SCREEN_WEIGHT-1, SCREEN_HEIGHT);
            foreach (var obj in objects)
            {
                obj.Rysuj(e.Graphics);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if ((gamer1.Location.X - 10) > 0)
                {
                    gamer1.Location = new Point(gamer1.Location.X - 10, gamer1.Location.Y);
                    Refresh();
                }

            }
            else if (keyData == Keys.Right)
            {
                if ((gamer1.Location.X + 10) < (SCREEN_WEIGHT - gamer1.SizeGamer))
                {
                    gamer1.Location = new Point(gamer1.Location.X + 10, gamer1.Location.Y);
                    Refresh();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void LiveLabel4_Click(object sender, EventArgs e)
        {

        }
    }


}
