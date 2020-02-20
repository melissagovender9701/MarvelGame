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
        public static int index = random.Next(VillainLogic.VillainList.Count);

        public static List<Villain> SetVillains()
        {
            VillainList = new List<Villain>
            {
                new Villain(1, "Doctor Doom", "Mind Transference, Genius-level Intellect, Superhuman Strength, Cosmic powers", 8, "Doombots, Enhanced Strength, Electric Shock, Concussive Blasts, Jet-packs", 7, "Doctor doom is using his powers on a quest for control"),
                new Villain(2, "Green Goblin", "Superhuman Strength, Superhuman Speed, Accelerated Healing, Superhuman Reflexes", 7, "Pumpkin Bombs, Razor Bats, Electricity Generation", 6, "Green Goblin wants to attain more power and wealth. He now realizes that he can use these powers to aid him in criminal endeavors by uniting the underworld of thugs and gangsters under his control."),
                new Villain(3, "Loki", "Magic, Superhuman-Durability, Mind Tricks", 10, "The Scepter", 8, "Loki Obtain the Tesseract & Take over Earth. He wasnts to give the Tesseract to Thanos as payment for helping him dominate and rule Earth.")
            };
            return VillainList;
        }

        public static void VillainDisplay()
        {
            foreach (var villain in VillainList)
            {

                if (villain.Id == index)
                {
                    DisplayLogic.FightList.Add(villain.Id);
                    Console.WriteLine($"Oh No! {villain.Name} is destorying the city!");
                    Console.WriteLine($"\nCheck out his abilities:\nPower: {villain.Power}\nStrength Rating: {villain.Power}\nWeapon: {villain.Weapon}\nWeapon Rating: {villain.WeaponRating}\nAgenda: {villain.Agenda}");
                    Console.WriteLine($"\n\nPress any key to call out to all superheroes to take him down!");
                    Console.ReadKey();
                }
            }
        }
    }
}
