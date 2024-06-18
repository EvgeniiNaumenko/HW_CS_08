using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_08_12_06_2024.Oceanarium
{
    public class Creature
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Size { get; set; }
        public Creature(string name, string description, double size)
        {
            Name = name;
            Description = description;
            Size = size;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nSize:{Size}\nDescription: {Description}";
        }
    }
}
