using Microsoft.AspNetCore.Mvc;
using Tijdslots.Database;
using Tijdslots.Models;

namespace Tijdslots.Controllers
{
    public class UurController : Controller
    {
        private IUurslotDatabase uurslotDatabase;

        public UurController(IUurslotDatabase uurslotDatabase)
        {
            this.uurslotDatabase = uurslotDatabase;
        }

        public IActionResult Index()
        {
            var vm = uurslotDatabase.GetAll().Select(x => new UurslotListViewModel
            {
                Date = x.Date,
                Id = x.Id,
                InUit = x.InUit,
                Naam = x.Naam
            });

            return View(vm);
        }
    }
}
