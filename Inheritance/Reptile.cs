using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            IsAlive = true;
            Age = 0;
            LegCount = 4;
            LandSeaAir = "Land";
        }
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string Habitat { get; set; }
        public bool CanRegenerateTail { get; set; }
    }
}
