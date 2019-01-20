namespace TheStarFromTheSky
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Score> Scores { get; set; }
    }

    public class Score
    {
        public int Id { get; set; }

        public Score()
        {

        }

        public Score(string nick, int points, string level)
        {
            this.Nick = nick;
            this.Points = points;
            this.Level = level;
            this.Data = DateTime.Now;
        }

        public string Nick { get; private set; }
        public int Points { get; private set; }
        public string Level { get; private set; }
        public DateTime Data { get; private set; }
    }

    public class ScoreBuilder
    {
        private string nick;
        private int points;
        private string level;

        public void SetNick(string nick)
        {
            this.nick = nick;
        }

        public void SetPoints(int points) {
            this.points = points;
        }

        public void SetLevel(string level) {
            this.level = level;
        }

        public Score Build()
        {
            return new Score(nick, points, level);
        }
    }
}