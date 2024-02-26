namespace TopMovies.Models
{
    public class Recommendation
    {
        //consructor
        public Recommendation() { }

        public int ID { get; set; }

        public string Title { get; set; }
        public string Type { get; set; } 
        public string Genre { get; set; }
    }
}
