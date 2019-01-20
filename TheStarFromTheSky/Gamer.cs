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
    public partial class Gamer : UserControl
    {
        public double X { get; set; }
        public double dx { get; set; }
        private Color colorGamer = Color.DodgerBlue;
        public Color ColorGamer
        {
            get { return colorGamer; }
            set
            {
                colorGamer = value;
                Refresh();
            }
        }

        private int sizeGamer;
        public int SizeGamer
        {
            get { return sizeGamer; }
            set
            {
                sizeGamer = value;
                Size = new Size(value, value);
                Refresh();
            }
        }

        public Gamer()
        {
            InitializeComponent();
        }

        private void Gamer_Resize(object sender, EventArgs e)
        {
            Height = SizeGamer;
            Width = Height;
        }

        private void Gamer_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float heightGamer = (float)SizeGamer;
            float half = heightGamer / 2;
            e.Graphics.TranslateTransform(Width / 2, Width / 2);
            e.Graphics.FillEllipse(new SolidBrush(ColorGamer), -half, -half, heightGamer, heightGamer);
            e.Graphics.DrawEllipse(new Pen(Color.Black, 1), -half, -half, heightGamer, heightGamer);
            float eye = ((float)SizeGamer) * 0.15f;
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), (-half * 0.5f), (-half * 0.5f), eye, eye);
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), (half * 0.5f - eye), (-half * 0.5f), eye, eye);
            float mouth = ((float)SizeGamer) * 0.3f;
            // e.Graphics.FillEllipse(new SolidBrush(Color.RoyalBlue), 0 - (mouth * 0.5f), 0 + ((float)SizeGamer) * 0.025f, mouth, mouth);
            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), 0 - (mouth * 0.5f), 0 + ((float)SizeGamer) * 0.025f, mouth, mouth);
        }

        private void Gamer_Load(object sender, EventArgs e)
        {

        }
    }
}
