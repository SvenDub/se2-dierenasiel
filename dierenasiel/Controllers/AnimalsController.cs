using System;
using System.Web.Mvc;
using dierenasiel.Utils;
using Models;
using Repository;
using Repository.Data;

namespace dierenasiel.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly Reservation _reservations =
            new Reservation(new AnimalShelterSqlContext());

        private readonly Webshop _webshop = new Webshop();

        public ActionResult Index() => View(_reservations.Animals);

        public ActionResult CreateCat()
        {
            ViewBag.GenderOptions = GenderUtils.GenderSelectListItems;
            return View(new Cat());
        }

        public ActionResult CreateDog()
        {
            ViewBag.GenderOptions = GenderUtils.GenderSelectListItems;
            return View(new Dog());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCat(Cat cat)
        {
            _reservations.SaveAnimal(cat);

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDog(Dog dog)
        {
            _reservations.SaveAnimal(dog);

            return RedirectToAction("Index");
        }
    }
}