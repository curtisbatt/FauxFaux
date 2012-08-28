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

        public Context(bool isMock = false)
        {
            Abilities = new Abilities();
            Actions = new Actions();
            Characteristics = new Characteristics();
            Models = new Models();
            Spells = new Spells();
            Triggers = new Triggers();
            Weapons = new Weapons();
            
            LoadData(isMock);
        }

        private void LoadData(bool isMock)
        {
            if (isMock)
            {
                this.Weapons.Add(new Weapon { Name = "Bag O'Tools", 
                                                Type = WeaponType.Melee, Range = 1, Combat = new SuitedValue<uint> { Suit = Suit.Crows, Value = 5 }, 
                                                Damage = new DamageProfile { Low = 1, Medium = 3, High = 5 } });

                this.Weapons.Add(new Weapon { Name = ".50 Flintlock", 
                                                Type = WeaponType.Ranged, Range = 8, Combat = new SuitedValue<uint> { Suit = Suit.None, Value = 5 }, 
                                                Damage = new DamageProfile { Low = 4, Medium = 6, High = 7 } });

                this.Models.Add(
                    new Model()
                    {
                        Name = "Seamus, The Mad Hatter",
                        Type = ModelType.Master,
                        Walk = 4, Charge = 6, Height = 2, Willpower = 7,
                        Casting = new SuitedValue<uint> { Suit = Suit.Crows, Value = 7 }, Defense = 4, Wounds = 12,

                        Abilities = Abilities.Where(i => new string[]{}.Contains(i.Name)).ToArray(),
                        Actions = Actions.Where(i => new string[]{}.Contains(i.Name)).ToArray(),
                        Characteristics = Characteristics.Where(i => new string[]{}.Contains(i.Name)).ToArray(),
                        Spells = Spells.Where(i => new string[]{}.Contains(i.Name)).ToArray(),
                        Triggers = Triggers.Where(i => new string[]{}.Contains(i.Name)).ToArray(),
                        Weapons = Weapons.Where(i => new string[]{ "Bag O'Tools", ".50 Flintlock" }.Contains(i.Name)).ToArray(),
                    }
                );
            }
        }
    }
}
