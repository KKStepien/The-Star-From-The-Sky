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
        private User user;
        public FormSignIn()
        {
            InitializeComponent();
            user = new User();
            comboBox1.Items.Add("BEGINNER");
            comboBox1.Items.Add("INTERMEDIATE");
            comboBox1.Items.Add("MASTER");

            comboBox1.SelectedIndex = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Ok_button1_Click(object sender, EventArgs e)
        {
            user.Nickname = textBox1.Text;
            user.Level = comboBox1.Text;
            
            this.Close();
            FormGame game = new FormGame(user);
            game.Show();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
