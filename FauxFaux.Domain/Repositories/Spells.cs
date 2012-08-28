using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Spells : AbstractRepository<Spell>
    {
        public Spells(bool isMock = false)
            : base(isMock)
        {
        }

        protected override void InitializeMockData()
        {
            _items = new List<Spell>()
            {
            };
        }
    }
}
