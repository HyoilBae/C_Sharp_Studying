using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    class Rover : IDirectable
    {
        public string Alias
        { get; private set; }

        public int YearLanded
        { get; private set; }

        public Rover(string alias, int yearLanded)
        {
            Alias = alias;
            YearLanded = yearLanded;
        }

        public string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLanded}";
        }

        public virtual string Explore()
        {
            return $"Rover {Alias} is exploring the surface!";
        }

        public virtual string Collect()
        {
            return $"Rover {Alias} is Collecting rocks!";
        }


    }
}
