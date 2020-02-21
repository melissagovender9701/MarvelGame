using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.DataAccessLayer
{
    public abstract class Fighter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public int StrengthRating { get; set; }
        public string Weapon { get; set; }
        public int WeaponRating { get; set; }

        public static Random random = new Random();

        public Fighter(int id, string name, string power, string weapon)
        {
            Id = id;
            Name = name;
            Power = power;
            StrengthRating = random.Next(1, 10);
            Weapon = weapon;
            WeaponRating = random.Next(1, 10);
        }

        public abstract void DisplayFighterDetails();
    }
}
