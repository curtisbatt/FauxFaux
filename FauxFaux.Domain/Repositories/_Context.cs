using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauxFaux.Domain.Repositories
{
    public class Context
    {
        public Abilities Abilities { get; private set; }
        public Actions Actions { get; private set; }
        public Characteristics Characteristics { get; private set; }
        public Models Models { get; private set; }
        public Spells Spells { get; private set; }
        public Triggers Triggers { get; private set; }
        public Weapons Weapons { get; private set; }

        public Repositories(bool isMock = false)
        {
            Abilities = new Abilities(isMock);
            Actions = new Actions(isMock);
            Characteristics = new Characteristics(isMock);
            Models = new Models(isMock);
            Spells = new Spells(isMock);
            Triggers = new Triggers(isMock);
            Weapons = new Weapons(isMock);
        }
    }
}
