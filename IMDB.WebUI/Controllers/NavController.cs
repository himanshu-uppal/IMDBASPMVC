using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB.Domain.Abstract;

namespace IMDB.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IActorRepository actorRepository;

        public NavController(IActorRepository actorRepository)
        {
            this.actorRepository = actorRepository;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = actorRepository.Actors.
                Select(x => x.Category).
                Distinct().
                OrderBy(x => x);
            return PartialView(categories);
        }
    }
}