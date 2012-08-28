namespace FauxFaux.Domain
{
    public class Weapon
    {
        public string Name { get; set; }
        public WeaponType Type { get; set; }
        public uint Range { get; set; }
        public SuitedValue<uint> Combat { get; set; }
        public DamageProfile Damage { get; set; }
    }
}
