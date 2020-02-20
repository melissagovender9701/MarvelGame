using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.DataAccessLayer
{
    public class Villain : Fighter
    {
        public string Agenda { get; set; }
        public static Random random = new Random();

        public Villain(int id, string name, string power, int strengthRating, string weapon, int weaponRating, string agenda):base(id, name, power, strengthRating, weapon, weaponRating)
        {
            Agenda = agenda;
        }
        public override void DisplayFighterDetails()
        {
            Console.WriteLine(
                $"Villain Name:                      {Name}\n" +
                $"Villain Power:                     {Power}\n" +
                $"Villain Weapon:                    {Weapon}\n" +
                $"Villain Agenda:                    {Agenda}\n");
        }
    }
}
