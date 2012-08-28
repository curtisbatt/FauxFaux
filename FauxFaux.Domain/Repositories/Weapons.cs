using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Weapons : AbstractRepository<Weapon>
    {
        public Weapons(bool isMock = false)
            : base(isMock)
        {
        }

        protected override void InitializeMockData()
        {
            _items = new List<Weapon>()
            {
                new Weapon { Name = "Bag O'Tools", Type = WeaponType.Melee, Range = 1, Combat = new SuitedValue<uint> { Suit = Suit.Crows, Value = 5 }, Damage = new DamageProfile { Low = 1, Medium = 3, High = 5 } },
                new Weapon { Name = ".50 Flintlock", Type = WeaponType.Ranged, Range = 8, Combat = new SuitedValue<uint> { Suit = Suit.None, Value = 5 }, Damage = new DamageProfile { Low = 4, Medium = 6, High = 7 } }
            };
        }
    }
}
