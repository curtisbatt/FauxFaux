using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Characteristics : AbstractRepository<Characteristic>
    {
        public Characteristics(bool isMock = false)
            : base(isMock)
        {
        }

        protected override void InitializeMockData()
        {
            _items = new List<Characteristic>()
            {
            };
        }
    }
}
