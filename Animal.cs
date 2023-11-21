﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    public class Animal
    {
        public Animal(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Type { get; private set; }

        public void Feed()
        {
            Console.WriteLine($"{Name} is full!");
        }

        public void Snuggle()
        {
            Console.WriteLine($"{Name} is happy!");
        }

        public void Poop()
        {
            Console.WriteLine($"Oh no! I have to change my shoous!!");
        }
    }
}
