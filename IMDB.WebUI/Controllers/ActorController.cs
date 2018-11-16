using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB.Domain.Abstract;
using IMDB.Domain.Entities;
using IMDB.WebUI.Models;

namespace IMDB.WebUI.Controllers
{
    public class ActorController : Controller
    {
        private IActorRepository repository;
        public int PageSize = 2;

        public ActorController(IActorRepository actorRepository)
        {
            this.repository = actorRepository;

        }
        
        public ViewResult List(int page=1)
        {
            ActorsListViewModel actorsModel = new ActorsListViewModel
            {
                Actors = repository.Actors.
                OrderBy(p => p.ID).
                Skip((page - 1) * PageSize).
                Take(PageSize),

                PagingInformation = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Actors.Count()
                }
            };

            return View(actorsModel);
        }
    }
}