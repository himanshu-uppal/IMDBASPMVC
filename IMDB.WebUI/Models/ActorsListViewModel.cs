using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IMDB.Domain.Entities;

namespace IMDB.WebUI.Models
{
    public class ActorsListViewModel
    {
        public IEnumerable<Actor> Actors { get; set; }
        public PagingInfo PagingInformation { get; set; }
        public string CurrentCategory { get; set; }
        
    }
}