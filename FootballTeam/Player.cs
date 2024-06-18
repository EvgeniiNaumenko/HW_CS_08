using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_12_06_2024.FootballTeam
{
    internal class Player
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public Player()
        {
            Name = "NoName";
        }
        public Player (string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
    }
}
