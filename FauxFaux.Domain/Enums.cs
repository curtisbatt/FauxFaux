namespace FauxFaux.Domain
{
    public enum ModelType
    {
        Minion = 0,
        Henchman,
        Master
    }

    public enum Suit
    {
        Crows = 4, // Spades
        Masks = 2, // Diamonds
        None = 0, // NO SUIT
        Rams = 3, // Hearts
        Tomes = 1 // Clubs
    }

    public enum WeaponType
    {
        Melee,
        Ranged
    }
}
