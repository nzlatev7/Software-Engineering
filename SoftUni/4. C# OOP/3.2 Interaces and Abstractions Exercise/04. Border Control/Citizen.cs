﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    public class Citizen : IIdentified
    {
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
    }
}
