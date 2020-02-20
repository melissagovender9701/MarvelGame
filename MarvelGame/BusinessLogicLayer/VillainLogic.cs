using MarvelGame.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarvelGame.BusinessLogicLayer
{
    public class VillainLogic
    {
        public static List<Villain> VillainList = SetVillains();
        public static Random random = new Random();
        public static int index = random.Next(1,VillainList.Count);
        public static int strengthRating = random.Next(1, 10);
        public static int weaponRating = random.Next(1, 10);

        public static List<Villain> SetVillains()
        {
            VillainList = new List<Villain>
            {
                new Villain(1, "Doctor Doom", "Mind Transference, Genius-level Intellect, Superhuman Strength, Cosmic powers", strengthRating,"Doombots, Enhanced Strength, Electric Shock, Concussive Blasts, Jet-packs", weaponRating,"Doctor doom is using his powers on a quest for control"),
                new Villain(2, "Green Goblin", "Superhuman Strength, Superhuman Speed, Accelerated Healing, Superhuman Reflexes", strengthRating,"Pumpkin Bombs, Razor Bats, Electricity Generation",weaponRating,"Green Goblin wants to attain more power and wealth."),
                new Villain(3, "Loki", "Magic, Superhuman-Durability, Mind Tricks",strengthRating,"The Scepter",weaponRating,"Loki's goal is to obtain the Tesseract & Take over Earth.")
            };
            return VillainList;
        }

        public static void VillainDisplay()
        {
            var villain = VillainList.Find(x => x.Id == Convert.ToInt32(index));
            villain.StrengthRating = strengthRating++;
            villain.WeaponRating = weaponRating++;
            if (villain.Id == index || index > VillainList.Count)
            {
                Console.WriteLine($"Oh No! {villain.Name} is destorying the city!\n\nCheck out his abilities:");
                villain.DisplayFighterDetails();
                Console.WriteLine($"\n\nPress any key to call out to all superheroes to take him down!\n");
                Console.ReadKey();
            }
        }

    }
}
