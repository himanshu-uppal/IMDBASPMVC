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
        public void SaveActor(Actor actor)
        {
            if (actor.ID == 0)
            {
                context.Actors.Add(actor);
            }
            else
            {
                Actor dbEntry = context.Actors.Find(actor.ID);
                if (dbEntry != null)
                {
                    dbEntry.Name = actor.Name;
                    dbEntry.Sex = actor.Sex;
                    dbEntry.DOB = actor.DOB;
                    dbEntry.Bio = actor.Bio;                    
                    dbEntry.Category = actor.Category;
                    dbEntry.ChargePerMovie = actor.ChargePerMovie;
                    dbEntry.ChargePerRole = actor.ChargePerRole;
                }
            }
            context.SaveChanges();
        }
    }
}
