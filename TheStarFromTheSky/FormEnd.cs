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
    public partial class FormEnd : Form
    {
        User user;
        public FormEnd(User user)
        {
            InitializeComponent();
            Scorelabel2.Text = user.Scores.ToString();
            this.user = user;
        }

        private void FormEndcs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var db = new Model1())
            {
                Score userek = new Score();
                userek.Nick = user.Nickname;
                userek.Level = user.Level;
                userek.Points = user.Scores;
                userek.Data = DateTime.Now;
                db.Scores.Add(userek);
                db.SaveChanges();
            }
        }
    }
}
