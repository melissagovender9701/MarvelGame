using MarvelGame.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.BusinessLogicLayer
{
    public class SuperheroLogic
    {
        public static List<Superhero> SuperheroList = SetSuperheros();
        public static Random random = new Random();
        public static int strengthRating = random.Next(1, 10);
        public static int weaponRating = random.Next(1, 10);
        public static List<Superhero> SetSuperheros()
        {

            SuperheroList = new List<Superhero>
            {
                new Superhero(1, "Spiderman", "Spider-Sense, Wall Crawling, Superhuman Sight, Regenerative Healing",strengthRating,"Web-Shooters, Utility Belt, Spider-Tracer",weaponRating,"Green Goblin"),
                new Superhero(2, "Doctor Strange", "Master Sorcerer, Magical Artifacts",strengthRating,"Soul Gem, Dragonfang, Astrial Ring",weaponRating,"Baron Mordo"),
            };
            return SuperheroList;
        }

        public static void SuperheroDisplay()
        {
            Console.WriteLine($"\n\nThank you for getting help! Here are the Superheroes that you have called:\n\n");

            foreach (var superhero in SuperheroList)
            {
                superhero.StrengthRating = strengthRating++;
                superhero.WeaponRating = weaponRating++;
                superhero.DisplayFighterDetails();
            }
        }


    }
}
