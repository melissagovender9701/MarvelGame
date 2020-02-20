using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.DataAccessLayer
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Power { get; set; }
        public double StrengthRating { get; set; }
        public string Weapon { get; set; }
        public double WeaponRating { get; set; }

        public Ability()
        {

        }

        public Ability(int id, string name, string power, double strengthRating, string weapon, double weaponRating)
        {
            Id = id;
            Name = name;
            Power = power;
            StrengthRating = strengthRating;
            Weapon = weapon;
            WeaponRating = weaponRating;
        }
    }
}
