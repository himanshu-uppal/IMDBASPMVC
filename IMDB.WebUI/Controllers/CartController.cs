using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB.Domain.Entities;
using IMDB.Domain.Abstract;
using IMDB.WebUI.Models;

namespace IMDB.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IActorRepository actorRepository;
        public CartController(IActorRepository actorRepository)
        {
            this.actorRepository = actorRepository;
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(int actorId, string returnUrl)
        {
            Actor actor = actorRepository.Actors
            .FirstOrDefault(a => a.ID == actorId);
            if (actor != null)
            {
                GetCart().AddItem(actor, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(int actorId, string returnUrl)
        {
            Actor actor = actorRepository.Actors
            .FirstOrDefault(a => a.ID == actorId);
            if (actor != null)
            {
                GetCart().RemoveLine(actor);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}