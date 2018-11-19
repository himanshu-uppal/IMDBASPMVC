using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB.Domain.Abstract;
using IMDB.Domain.Entities;

namespace IMDB.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IActorRepository repository;
        
        public AdminController(IActorRepository repository)
        {
            this.repository = repository;
        }
       public ViewResult Index()
        {
            return View(repository.Actors);
        }
        public ViewResult Edit(int ID)
        {
            Actor actor = repository.Actors
            .FirstOrDefault(a => a.ID == ID);
            return View(actor);
        }
        [HttpPost]
        public ActionResult Edit(Actor actor)
        {
            if (ModelState.IsValid)
            {
                repository.SaveActor(actor);
                TempData["message"] = string.Format("{0} has been saved", actor.Name);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(actor);
            }
        }
    }
}