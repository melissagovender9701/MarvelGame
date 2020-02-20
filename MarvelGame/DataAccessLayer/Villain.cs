using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.DataAccessLayer
{
    public class Villain : Ability
    {
        public string Agenda { get; set; }

        public Villain()
        {

        }

        public Villain(int id, string name, string power, double strengthRating, string weapon, double weaponRating, string agenda):base(id, name, power, strengthRating, weapon, weaponRating)
        {
            Agenda = agenda;
        }
    }
}
