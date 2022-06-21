namespace Tijdslots.Domain
{
    public class Uurslot
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public bool InUit { get; set; }
        public DateTime Date { get; set; }

        public Uurslot(string naam, bool inUit, DateTime date)
        {
            Naam = naam;
            InUit = inUit;
            Date = date;
        }
    }
}
