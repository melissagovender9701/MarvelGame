using System;

namespace MarvelGame.BusinessLogicLayer
{
    public class DisplayLogic
    {
        public static string _superheroId;
        public static int value = 0;

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
            Console.WriteLine($"\n\nEnter a Superhero ID for a superhero that you think can take this villain down:");
            _superheroId = Console.ReadLine();
            while (!int.TryParse(_superheroId, out value) || Convert.ToInt32(_superheroId) > SuperheroLogic.SuperheroList.Count || String.IsNullOrEmpty(_superheroId))
            {
                Console.WriteLine("\nYou have entered an incorrect Superhero ID, please enter that again:");
                _superheroId = Console.ReadLine();
            }
        }

        public static void Fight()
        {
            var superhero = SuperheroLogic.SuperheroList.Find(x => x.Id == Convert.ToInt32(_superheroId));
            var villain = VillainLogic.VillainList.Find(x => x.Id == Convert.ToInt32(VillainLogic.index));
            int superheroTotalPower = superhero.StrengthRating + superhero.WeaponRating;
            int villainTotalPower = villain.StrengthRating + villain.WeaponRating;
            Console.WriteLine($"\n{superhero.Name} vs {villain.Name}\n\n");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"\n{superhero.Name}'s Strength Rating:     {superhero.StrengthRating}\n" +
                                $"{superhero.Name}'s Weapon Rating:       {superhero.WeaponRating}\n" +
                                $"{superhero.Name}'s Total Power Rating:  {superheroTotalPower}");
            Console.WriteLine($"\n{villain.Name}'s Strength Rating:       {villain.StrengthRating}\n" +
                                $"{villain.Name}'s Weapon Rating:         {villain.WeaponRating}\n" +
                                $"{villain.Name}'s Total Power Rating:    {villainTotalPower}");
            Console.WriteLine("--------------------------------\n");

            if (superheroTotalPower > villainTotalPower)
            {
                Console.WriteLine($"\nYou have defeated {villain.Name}!");
            }
            else
            {
                Console.WriteLine($"\n{villain.Name} has defeated you....\nGame Over");
            }
            if (superheroTotalPower == villainTotalPower)
            {
                Console.WriteLine($"\n\nThere was a tie, press any key to verse him again...");
            }
         }
    }
}
