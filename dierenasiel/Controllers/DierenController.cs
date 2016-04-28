using System.Web.Mvc;
using Repository;
using Repository.Data;

namespace dierenasiel.Controllers
{
    public class DierenController : Controller
    {
        private readonly Reservation _reservations =
            new Reservation(new AnimalShelterSQLContext());

        private readonly Webshop _webshop = new Webshop();

        public ActionResult Index()
        {
            ViewBag.Animals = _reservations.Animals;

            return View();
        }
    }
}