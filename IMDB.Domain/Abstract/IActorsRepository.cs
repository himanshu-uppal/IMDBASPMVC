using System;
using System.Collections.Generic;
using System.Text;
using IMDB.Domain.Entities;

namespace IMDB.Domain.Abstract
{
    public interface IActorsRepository
    {
        IEnumerable<Actor> Actors { get; }
    }
}
