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

        public Fighter(int id, string name, string power, int strengthRating, string weapon, int weaponRating)
        {
            Id = id;
            Name = name;
            Power = power;
            StrengthRating = strengthRating;
            Weapon = weapon;
            WeaponRating = weaponRating;
        }

        public abstract void DisplayFighterDetails();
    }
}
