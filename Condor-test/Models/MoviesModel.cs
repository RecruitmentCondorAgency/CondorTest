using System;
namespace Condor_test.Models
{
    public class MoviesModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Country { get; set; }
        public string Platform { get; set; }

        public MoviesModel()
        {
            Id = 1;
            Name = "Avengers";
         
            Country = "USA";
            Platform = "Cinema";
        }

        public MoviesModel(int id, string name, string country, string platform)
        {
            Id = id;
            Name = name;
            Country = country;
            Platform = platform;
        }
    }
}
