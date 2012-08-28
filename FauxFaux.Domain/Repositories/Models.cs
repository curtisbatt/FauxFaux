using System.Linq;
using System.Collections.Generic;

namespace FauxFaux.Domain.Repositories
{
    public class Models : AbstractRepository<Model>
    {
        public Models(bool isMock = false)
            : base(isMock)
        {
        }

        protected override void InitializeMockData()
        {
            var repos = new Repositories(isMock:true);

            _items = new List<Model>()
            {
                new Model()
                {
                    Name = "Seamus, The Mad Hatter",
                    Type = ModelType.Master,
                    Walk = 4, Charge = 6, Height = 2, Willpower = 7,
                    Casting = new SuitedValue<uint> { Suit = Suit.Crows, Value = 7 }, Defense = 4, Wounds = 12,

                    Abilities = repos.Abilities.Where(i => new string[]{}.Contains(i.Name)).ToArray(),
                    Actions = repos.Actions.Where(i => new string[]{}.Contains(i.Name)).ToArray(),
                    Weapons = repos.Weapons.Where(i => new string[]{ "Bag O'Tools", ".50 Flintlock" }.Contains(i.Name)).ToArray(),
                }
            };
        }
    }
}
