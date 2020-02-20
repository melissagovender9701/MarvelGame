using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.DataAccessLayer
{
    public class Superhero : Ability
    {
        public string ArchNemesis { get; set; }

        public Superhero()
        {

        }

        public Superhero(int id, string name, string power, double strengthRating, string weapon, double weaponPower, string archNemesis):base(id, name, power, strengthRating, weapon, weaponPower)
        {
            ArchNemesis = archNemesis;
        }
    }
}
