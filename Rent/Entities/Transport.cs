﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transport:StandartdEntity
    {
        public Brand Brand { get; set; }
        public Model Model { get; set; }
        public Color Color { get; set; }
        public int Year { get; set; }
        public DrivingCategory DrivingCategory { get; set; }
        public Parking Parking { get; set; }
        public double Coef { get; set; }
        public double CorrectCoef { get; set; }
    }
}
