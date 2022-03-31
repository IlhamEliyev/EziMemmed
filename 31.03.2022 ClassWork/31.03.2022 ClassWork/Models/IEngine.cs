﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022_ClassWork.Models
{
    interface IEngine
    {
        public int HorsePower { get; set; }
        public double TankSize { get; set; }

        public double CurrentOil { get; set; }

        public string FuelType { get; set; }


        public double LeftFuelAmount()
        {
            return TankSize - CurrentOil;
        }

    }
}
