using MarvelGame.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.BusinessLogicLayer
{
    public class DisplayLogic
    {
        public static string _superheroId;
        public static int value = 0;
        public static List<int> FightList = new List<int>();
        public static void Start()
        {
            VillainLogic.VillainDisplay();
            SuperheroLogic.SuperheroDisplay();
            GetSuperhero();
            Fight();
            Console.ReadKey();
        }
        public static void GetSuperhero()
        {
            Console.WriteLine($"Enter a Superhero ID for a superhero that you think can take this villain down:");
            _superheroId = Console.ReadLine();
            FightList.Add(Convert.ToInt32(_superheroId));
            while (!int.TryParse(_superheroId, out value))
            {
                Console.WriteLine("You have entered an incorrect Superhero ID, please enter that again:");
                _superheroId = Console.ReadLine();
                FightList.Add(Convert.ToInt32(_superheroId));
            }
        }
        public static void Fight()
        {
            var superhero = SuperheroLogic.SuperheroList.Find(x => x.Id == Convert.ToInt32(_superheroId));
            var villain = VillainLogic.VillainList.Find(x => x.Id == Convert.ToInt32(VillainLogic.index));
            Console.WriteLine($"\n{superhero.Name} vs {villain.Name}");
            Console.WriteLine($"\n{superhero.Name}'s Strength Rating: {superhero.StrengthRating}");
            Console.WriteLine($"{villain.Name}'s Strength Rating: {villain.StrengthRating}");
            if (superhero.StrengthRating > villain.StrengthRating)
            {
                Console.WriteLine($"\nYou have defeated {villain.Name}");
            }
            else
            {
                Console.WriteLine($"\n{villain.Name} has defeated you :( ....\nK.O");
            }
        }
    }
}
