using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    public interface IAbstractBicycle
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Power { get; set; }
        public string BicycleFunction();
    }
}
