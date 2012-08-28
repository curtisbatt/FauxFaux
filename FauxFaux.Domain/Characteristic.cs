using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauxFaux.Domain
{
    public class Characteristic
    {
        public string Name { get; private set; }

        public Characteristic(string name)
        {
            Name = name;
        }
    }
}
