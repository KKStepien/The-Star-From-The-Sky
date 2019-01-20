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
    public partial class FormRank : Form
    {
        public FormRank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRankLists beginner = new FormRankLists("BEGINNER");
            beginner.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRankLists beginner = new FormRankLists("INTERMEDIATE");
            beginner.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRankLists beginner = new FormRankLists("MASTER");
            beginner.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
