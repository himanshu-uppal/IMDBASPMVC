using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB.Domain.Abstract;
using IMDB.Domain.Entities;

namespace IMDB.WebUI.Controllers
{
    public class ActorController : Controller
    {
        private IActorRepository repository;

        public ActorController(IActorRepository actorRepository)
        {
            this.repository = actorRepository;

        }
        
        public ViewResult List()
        {
            return View(repository.Actors);
        }
    }
}