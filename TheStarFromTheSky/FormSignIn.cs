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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            comboBox1.Items.Add("BEGINNER");
            comboBox1.Items.Add("INTERMEDIATE");
            comboBox1.Items.Add("MASTER");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormSignIn nowy = new FormSignIn();
            nowy.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
