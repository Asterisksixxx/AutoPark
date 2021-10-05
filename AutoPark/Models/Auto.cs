using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPark.Models
{
    public class Auto
    {
        public Guid IDCars { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public decimal Cost { get; set; }
        public int AgeAuto { get; set; }
        public string Color { get; set; }
        public decimal HorsePower { get; set; } 
        public decimal MotorSize { get; set; }

        }
}
