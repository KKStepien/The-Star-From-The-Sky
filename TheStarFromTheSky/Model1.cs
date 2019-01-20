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
        public string Nick { get; set; }
        public int Points { get; set; }
        public string Level { get; set; }
        public DateTime Data { get; set; }
    }
}