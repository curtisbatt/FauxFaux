using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FauxFaux.Domain.Repositories
{
    public class Weapons
    {
        protected List<Weapon> _weapons;

        public Weapon[] All
        {
            get { return _weapons.ToArray(); }
        }

        public Weapons()
        {
        }

        public void Save(Weapon weapon)
        {

        }
    }
}
