using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies = null;
         static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie() { 
                    CategoryId=1,
                    id = 1,
                    Description="<p> " +
                    "In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services "+
                    "and the authorities with his stubborn search for his lost mother. "+
                    "However, in his latest foster home, Billy makes a new friend, "+
                    "Freddy, and finds himself selected by the Wizard Shazam to be his new champion."+
                    "Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, "+
                    "Billy gleefully explores his new powers with Freddy. However,"+
                    "Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, "+
                    "who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead."+
                    "Now pursued by this mad scientist for his own power as well,"+
                    "Billy must face up to the responsibilities of his calling while learning the power of a "+
                    "special magic with his true family that Sivana can never understand. </p>",
                    Name = "Shazam",
                    ShortDescription = "Filmin Konusu", 
                    ImageUrl = "shazam.jpg" 
                },
                new Movie()
                {
                    CategoryId=2,
                    id = 2,
                      Description="<p> " +
                    "In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services "+
                    "and the authorities with his stubborn search for his lost mother. "+
                    "However, in his latest foster home, Billy makes a new friend, "+
                    "Freddy, and finds himself selected by the Wizard Shazam to be his new champion."+
                    "Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, "+
                    "Billy gleefully explores his new powers with Freddy. However,"+
                    "Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, "+
                    "who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead."+
                    "Now pursued by this mad scientist for his own power as well,"+
                    "Billy must face up to the responsibilities of his calling while learning the power of a "+
                    "special magic with his true family that Sivana can never understand. </p>",
                    Name = "Amazing Grace",
                    ShortDescription = "Filmin Konusu",
                    ImageUrl = "amazin_grace.jpg"
                },
                new Movie()
                {
                    CategoryId=2,
                    id = 3,
                    Name = "High Life",
                      Description="<p> " +
                    "In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services "+
                    "and the authorities with his stubborn search for his lost mother. "+
                    "However, in his latest foster home, Billy makes a new friend, "+
                    "Freddy, and finds himself selected by the Wizard Shazam to be his new champion."+
                    "Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, "+
                    "Billy gleefully explores his new powers with Freddy. However,"+
                    "Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, "+
                    "who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead."+
                    "Now pursued by this mad scientist for his own power as well,"+
                    "Billy must face up to the responsibilities of his calling while learning the power of a "+
                    "special magic with his true family that Sivana can never understand. </p>",
                    ShortDescription = "Filmin Konusu",
                    ImageUrl = "high_life.jpg"
                },
                new Movie() {
                    CategoryId=3,
                    id = 4,
                    Name = "Billboard",
                      Description="<p> " +
                    "In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services "+
                    "and the authorities with his stubborn search for his lost mother. "+
                    "However, in his latest foster home, Billy makes a new friend, "+
                    "Freddy, and finds himself selected by the Wizard Shazam to be his new champion."+
                    "Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, "+
                    "Billy gleefully explores his new powers with Freddy. However,"+
                    "Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, "+
                    "who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead."+
                    "Now pursued by this mad scientist for his own power as well,"+
                    "Billy must face up to the responsibilities of his calling while learning the power of a "+
                    "special magic with his true family that Sivana can never understand. </p>",
                    ShortDescription = "Filmin Konusu",
                    ImageUrl = "high_life.jpg" 
                },
                new Movie()
                {
                    CategoryId=1,
                    id = 5,
                    Name = "Storm Boy",
                      Description="<p> " +
                    "In Philadelphia, Billy Batson is an abandoned child who is proving a nuisance to Child Services "+
                    "and the authorities with his stubborn search for his lost mother. "+
                    "However, in his latest foster home, Billy makes a new friend, "+
                    "Freddy, and finds himself selected by the Wizard Shazam to be his new champion."+
                    "Now endowed with the ability to instantly become an adult superhero by speaking the wizard's name, "+
                    "Billy gleefully explores his new powers with Freddy. However,"+
                    "Billy soon learns that he has a deadly enemy, Dr. Thaddeus Sivana, "+
                    "who was previously rejected by the wizard and has accepted the power of the Seven Deadly Sins instead."+
                    "Now pursued by this mad scientist for his own power as well,"+
                    "Billy must face up to the responsibilities of his calling while learning the power of a "+
                    "special magic with his true family that Sivana can never understand. </p>",
                    ShortDescription = "Filmin Konusu",
                    ImageUrl = "storm_boy.jpg"
                },
            }; 

        }

        public static List<Movie> getMovies
        {
            get { return _movies; }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.id == id);
        }
    }
}
