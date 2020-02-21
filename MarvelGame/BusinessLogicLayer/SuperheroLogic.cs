using MarvelGame.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.BusinessLogicLayer
{
    public class SuperheroLogic
    {
        public static List<Superhero> SuperheroList = SetSuperheros();
        public static List<int> HeroIndexes = new List<int>();
        public static List<Superhero> SetSuperheros()
        {
            SuperheroList = new List<Superhero>
            {
                new Superhero(1, "Spiderman", "Spider-Sense, Wall Crawling, Superhuman Sight, Regenerative Healing","Web-Shooters, Utility Belt, Spider-Tracer","Green Goblin"),
                new Superhero(2, "Doctor Strange", "Master Sorcerer, Magical Artifacts","Soul Gem, Dragonfang, Astrial Ring","Baron Mordo"),
                new Superhero(3, "Thor", "Physiology, Superhuman Strength, Weather Control, Earth Control ","Mjolnir, Jarnbjorn, Odinsword", "Loki"),
                new Superhero(4, "Wolverine", "Regenerative Healing Factor, Superhuman Durability","Bone Claw, Daggers, Swords", "Sabretooth"),
                new Superhero(5, "Punisher", "Complete control of his mind and consciousness, Superhuman Durability","4.1 SIG-Sauer 516, 4.8 Colt Law Enforcement Carbine", "Billy Russo"),
            };

            return SuperheroList;
        }

        public static void SuperheroDisplay()
        {
            int temp;
            Console.WriteLine($"\n\nThank you for getting help! Here are the Superheroes that you have called:\n\n");

            for (int i = 0; i < 3; i++)
            {
                temp = Fighter.random.Next(0, SuperheroList.Count - 1);
                if (!HeroIndexes.Contains(temp))
                {
                    HeroIndexes.Add(temp);
                }
                else
                {
                    i--;
                }
            }

            for(int j =0; j<HeroIndexes.Count; j++)
            {
                SuperheroList[HeroIndexes[j]].DisplayFighterDetails();
            }
        }
    }
}
