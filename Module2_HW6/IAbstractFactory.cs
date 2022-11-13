using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_HW6
{
    internal interface IAbstractFactory
    {
        public virtual IAbstractMoto CreateMoto(
            string name,
            string manufacturer,
            int power)
        {
            return null;
        }

        public virtual IAbstractCar CreateCar(
            string name,
            string manufacturer,
            int power)
        {
            return null;
        }

        public virtual IAbstractBicycle CreateBicycle(
            string name,
            string manufacturer,
            int power)
        {
            return null;
        }
    }
}
