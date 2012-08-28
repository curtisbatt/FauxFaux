﻿using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Abilities : AbstractRepository<Ability>
    {
        public Abilities(bool isMock = false)
            : base(isMock)
        {
        }

        protected override void InitializeMockData()
        {
            _items = new List<Ability>()
            {
            };
        }
    }
}
