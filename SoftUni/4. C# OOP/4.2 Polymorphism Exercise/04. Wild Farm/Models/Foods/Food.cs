﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4.Models
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
