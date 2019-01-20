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
    public partial class FormRankLists : Form
    {
        private string level;

        private void Sort(List<User> users)
        {
            User user = new User();
            for (int j = 0; j < users.Count() - 1; j++)
            {
                for (int i = 0; i < users.Count() - 1; i++)
                {
                    if (users[i].Scores < users[i + 1].Scores)
                    {
                        user = users[i];
                        users[i] = users[i + 1];
                        users[i + 1] = user;
                    }
                }
            }
            int k= users.Count();
            if (users.Count() > 10)
            {
                k = 10;
            }
            for (int i = 0; i < k; i++)
            {
                string croops = ".";
                string name = users[i].Nickname;
                int number = name.Length;
                for (int j = 0; j < 75 - (number*2+2); j++)
                {
                    croops = croops + ".";
                }
                string napis = (i + 1) + ". " + users[i].Nickname + croops + users[i].Scores;
                listBox1.Items.Add(napis);
            }
        }

        public FormRankLists(string level)
        {
            InitializeComponent();
            this.level = level;
            if (level == "BEGINNER")
            {
                label1.Text = "BEGINNER";
            }
            else if (level == "INTERMEDIATE")
            {
                label1.Text = "INTERMEDIATE";
            }
            else
            {
                label1.Text = "MASTER";
            }

            using(var db = new Model1())
            {
                var scores = db.Scores;
                List<User> users = new List<User>();
                User user;

                if (level == "BEGINNER")
                {
                    foreach (var item in scores)
                    {
                        if (item.Level == "BEGINNER")
                        {
                            user = new User();
                            user.Nickname = item.Nick;
                            user.Scores = item.Points;
                            users.Add(user);
                        }
                    }
                    Sort(users);
                }
                else if (level == "INTERMEDIATE")
                {
                    foreach (var item in scores)
                    {
                        if (item.Level == "INTERMEDIATE")
                        {
                            user = new User();
                            user.Nickname = item.Nick;
                            user.Scores = item.Points;
                            users.Add(user);
                        }
                    }
                    Sort(users);
                }
                else
                {
                    foreach (var item in scores)
                    {
                        if (item.Level == "MASTER")
                        {
                            user = new User();
                            user.Nickname = item.Nick;
                            user.Scores = item.Points;
                            users.Add(user);
                        }
                    }
                    Sort(users);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FormRankLists_Load(object sender, EventArgs e)
        {

        }
    }
}
