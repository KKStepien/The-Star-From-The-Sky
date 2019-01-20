using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Thread t = new Thread(ZapiszDoBazy);
            t.Start();
        }

        private void ZapiszDoBazy()
        {
            ScoreBuilder builder = new ScoreBuilder();
            builder.SetNick(user.Nickname);
            builder.SetPoints(user.Scores);
            builder.SetLevel(user.Level);

            Score userek = builder.Build();
            using (var db = new Model1())
            {
                db.Scores.Add(userek);
                db.SaveChanges();
            }       
        }
    }
}
