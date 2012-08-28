using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Triggers : AbstractRepository<Trigger>
    {
        public Triggers(bool isMock = false)
            : base(isMock)
        {
        }

        protected override void InitializeMockData()
        {
            _items = new List<Trigger>()
            {
            };
        }
    }
}
