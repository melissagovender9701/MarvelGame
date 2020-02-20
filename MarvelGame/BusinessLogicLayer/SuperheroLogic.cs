using MarvelGame.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.BusinessLogicLayer
{
    public class SuperheroLogic
    {
        public static List<Superhero> SuperheroList = SetSuperheros();
        public static List<Superhero> SetSuperheros()
        {
            SuperheroList = new List<Superhero>
            {
                new Superhero(1, "Spiderman", "Spider-Sense, Wall Crawling, Superhuman Sight, Regenerative Healing", 9.3, "Web-Shooters, Utility Belt, Spider-Tracer", 8, "Green Goblin"),
                new Superhero(2, "Iron Man", "Master Sorcerer, Magical Artifacts", 7.2, "Soul Gem, Dragonfang, Astrial Ring", 7, "Baron Mordo"),
            };
            return SuperheroList;
        }

        public static void SuperheroDisplay()
        {
            Console.WriteLine($"\n\nThank you for getting help! Here are the Superheroes that you have called:");

            foreach (var superhero in SuperheroList)
            {
                Console.WriteLine($"\n\nSuperhero ID: {superhero.Id}\nSuperhero Name: {superhero.Name}\nSuperhero Powers: {superhero.Power}\nSuperhero Strength Rating: {superhero.StrengthRating}\nSuperhero Weapons: {superhero.Weapon}\nSuperhero Weapon Rating: {superhero.WeaponRating}\nSuperhero Arch-Nemesis: {superhero.ArchNemesis}\n");
            }
        }

        
    }
}
