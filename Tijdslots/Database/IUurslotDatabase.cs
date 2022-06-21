using Tijdslots.Domain;

namespace Tijdslots.Database
{
    public interface IUurslotDatabase
    {
        IEnumerable<Uurslot> GetAll();
        Uurslot Insert(Uurslot uurslot);
    }

    public class UurslotDatabase : IUurslotDatabase
    {
        private int counter = 0;
        private List<Uurslot> uurslots;

        public UurslotDatabase()
        {
            uurslots = new List<Uurslot>();
            Insert(new Uurslot("Ken", true, new DateTime(2022, 06, 19, 09, 05, 0)));
            Insert(new Uurslot("Ken", false, new DateTime(2022, 06, 19, 17, 02, 0)));
            Insert(new Uurslot("Gert", true, new DateTime(2022, 06, 19, 09, 02, 0)));
            Insert(new Uurslot("Gert", false, new DateTime(2022, 06, 19, 17, 05, 0)));
            Insert(new Uurslot("Stef", true, new DateTime(2022, 06, 19, 09, 01, 0)));
            Insert(new Uurslot("Stef", false, new DateTime(2022, 06, 19, 17, 06, 0)));
            Insert(new Uurslot("Ken", true, new DateTime(2022, 06, 20, 09, 05, 0)));
            Insert(new Uurslot("Ken", false, new DateTime(2022, 06, 20, 17, 02, 0)));
            Insert(new Uurslot("Gert", true, new DateTime(2022, 06, 20, 09, 02, 0)));
            Insert(new Uurslot("Gert", false, new DateTime(2022, 06, 20, 17, 05, 0)));
            Insert(new Uurslot("Stef", true, new DateTime(2022, 06, 20, 09, 01, 0)));
            Insert(new Uurslot("Stef", false, new DateTime(2022, 06, 20, 17, 06, 0)));
            Insert(new Uurslot("Ken", true, new DateTime(2022, 06, 21, 09, 04, 0)));
            Insert(new Uurslot("Gert", true, new DateTime(2022, 06, 21, 09, 06, 0)));
            Insert(new Uurslot("Stef", true, new DateTime(2022, 06, 21, 09, 00, 0)));
        }

        public IEnumerable<Uurslot> GetAll()
        {
            return uurslots;
        }

        public Uurslot Insert(Uurslot uurslot)
        {
            uurslot.Id = counter++;
            uurslots.Add(uurslot);
            return uurslot;
        }
    }
}
