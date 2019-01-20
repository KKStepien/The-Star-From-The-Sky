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
        private int level=1;
        public int Level {
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
            }
        }
        private int points=0;
        public int Points
        {
            get { return points; }
            set
            {
                points = value;
            }
        }
        private int allPoints=0;
        public int AllPoints
        {
            get { return allPoints; }
            set
            {
                allPoints = value;
            }
        }

        private List<ObjectController> objects;
        public FormGame()
        {
            InitializeComponent();

            objects = new List<ObjectController>();
            objects.Add(new StarController());
            objects.Add(new MeteorController());

            label2.Text = Level.ToString();
            LiveLabel4.Text = Live.ToString();
            AllScoreLabel5.Text = AllPoints.ToString();
            ScoresLabel11.Text = Points.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock1.Wartosc++;
            objects.Add(new StarController());
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (var obj in objects)
            {
                obj.Move(0.5, 15);
            }
            Refresh();
        }

        private void clock1_Load(object sender, EventArgs e)
        {

        }

        private void clock1_PrzekroczonoProg(int obj)
        {
            clock1.KolorWwskażnika = Color.Red;
            clock1.Wartosc = 0;
            this.timer1.Stop();
            this.timer2.Stop();
            //stop
        }

        private void gamer1_Load_1(object sender, EventArgs e)
        {
            gamer1.SizeGamer = 30;
            gamer1.Location = new Point(1, 617 - (gamer1.SizeGamer));
        }

        private void GamePanel6_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, 1003, 617);
            foreach (var obj in objects)
            {
                obj.Rysuj(e.Graphics);
            }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        //private void FormGame_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Console.WriteLine("####### dupadpa", e.KeyCode);
        //    if (e.KeyCode == Keys.Left)
        //    {
        //        gamer1.Left();
        //    }
        //    else if (e.KeyCode == Keys.Right)
        //    {
        //        gamer1.Right();
        //    }
        //}

        private void label2_Click(object sender, EventArgs e)
        {
           
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
                if ((gamer1.Location.X + 10) < (1004-gamer1.SizeGamer))
                {
                    gamer1.Location = new Point(gamer1.Location.X + 10, gamer1.Location.Y);
                    Refresh();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }


}
