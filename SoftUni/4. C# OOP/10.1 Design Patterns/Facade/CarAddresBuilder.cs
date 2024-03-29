﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CarAddresBuilder : CarBuilderFacade
    {
        public CarAddresBuilder(Car car)
        {
            Car = car;
        }

        public CarAddresBuilder InCity(string city)
        { 
            Car.City = city;
            return this;
        }

        public CarAddresBuilder AtAddress(string address)
        {
            Car.Address = address;
            return this;
        }
    }
}
