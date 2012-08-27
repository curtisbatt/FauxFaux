using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Abilities
    {
        protected List<Ability> _abilities;

        public Ability[] All
        {
            get { return _abilities.ToArray(); }
        }

        public Abilities()
        {
        }

        public void Save(Ability ability)
        {
            throw new System.NotImplementedException();
        }
    }
}
