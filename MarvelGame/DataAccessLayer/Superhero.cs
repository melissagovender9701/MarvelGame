﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelGame.DataAccessLayer
{
    public class Superhero : Fighter
    {
        public string ArchNemesis { get; set; }

        public Superhero(int id, string name, string power, string weapon, string archNemesis) : base(id, name, power, weapon)
        {
            ArchNemesis = archNemesis;
        }

        public override void DisplayFighterDetails()
        {
            Console.WriteLine(
                $"Superhero Id:                      {Id}\n"+
                $"Superhero Name:                    {Name}\n" +
                $"Superhero Power:                   {Power}\n" +
                $"Superhero Strength Rating:         {StrengthRating}\n" +
                $"Superhero Weapon:                  {Weapon}\n" +
                $"Superhero Weapon Rating:           {WeaponRating}\n" +
                $"Superhero Arch Nemesis:            {ArchNemesis}\n");
        }
    }
}
