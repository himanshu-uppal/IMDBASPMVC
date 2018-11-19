using System;
using System.Collections.Generic;
using System.Text;
using IMDB.Domain.Entities;

namespace IMDB.Domain.Abstract
{
    public interface IActorRepository
    {
        IEnumerable<Actor> Actors { get; }
        public void SaveActor(Actor actor);
    }

    
}
