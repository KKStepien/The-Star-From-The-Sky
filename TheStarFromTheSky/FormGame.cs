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
        public FormGame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock1.Wartosc++;
        }

        private void clock1_Load(object sender, EventArgs e)
        {

        }

        private void clock1_PrzekroczonoProg(int obj)
        {
            clock1.KolorWwskażnika = Color.Red;
            clock1.Wartosc = 0;
            //stop
        }
    }
}
