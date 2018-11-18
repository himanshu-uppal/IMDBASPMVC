using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMDB.Domain.Entities;

namespace IMDB.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}