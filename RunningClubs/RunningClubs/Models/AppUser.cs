﻿namespace RunningClubs.Models
{
    public class AppUser 
    {
        public int? Pace { get; set; }
        public int? Milage { get; set; }
        public Address? Adress { get; set; }
        public  ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
