using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            Age = 0;
            LegCount = 2;
            LandSeaAir = "Air";
        }
        public bool CanFly { get; set; }
        public string WingColor { get; set; }
        public bool DoMigrate { get; set; }
        public double BeakLength { get; set; }
    }
}
