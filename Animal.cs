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
        public string Name;
        public int Age;
        public string Type;
    }
}
