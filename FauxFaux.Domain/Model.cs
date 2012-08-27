using System.Collections.Generic;

namespace FauxFaux.Domain
{
    public class Model
    {
        // Values
        public string Name { get; set; }
        public ModelType Type { get; set; }

        public uint Walk { get; set; }
        public uint Charge { get; set; }
        public uint Height { get; set; }
        public uint Willpower { get; set; }
        public SuitedValue<uint> Casting { get; set; }
        public uint Defense { get; set; }
        public uint MyProperty { get; set; }
        
        // Collections
        public Ability[] Abilities { get; set; }
        public Action[] Actions { get; set; }
        public Characteristic[] Characteristics { get; set; }
        public Trigger[] Triggers { get; set; }
        public Spell[] Spells { get; set; }
        public Weapon[] Weapons { get; set; }
    }
}
