namespace FauxFaux.Domain
{
    public struct SuitedValue<T> where T : struct
    {
        public Suit Suit;
        public T Value;
    }
}
