using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Actions : AbstractRepository<Action>
    {
        public Actions(bool isMock = false)
            : base(isMock)
        {
        }

        protected override void InitializeMockData()
        {
            _items = new List<Action>()
            {
            };
        }
    }
}
