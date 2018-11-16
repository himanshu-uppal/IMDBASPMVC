using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDB.Domain.Entities;
using IMDB.Domain.Abstract;

namespace IMDB.Domain.Concrete
{
    public class EFActorRepository : IActorRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Actor> Actors
        {
            get {return context.Actors; }
        }
    }
}
