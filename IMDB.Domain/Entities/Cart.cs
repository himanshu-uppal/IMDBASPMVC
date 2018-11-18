using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDB.Domain.Entities;

namespace IMDB.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Actor actor, int roleCount)
        {
            CartLine line = lineCollection.
                Where(a => a.Actor.ID == actor.ID).
                FirstOrDefault();
            if(line == null)
            {
                lineCollection.Add(new CartLine { Actor = actor, RoleCount = roleCount });

            }
            else
            {
                line.RoleCount += roleCount;
            }
        }

        public void RemoveLine(Actor actor)
        {
            lineCollection.RemoveAll(a => a.Actor.ID == actor.ID);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(a => { if (a.RoleCount == 1) { return a.Actor.ChargePerMovie; } else { return a.Actor.ChargePerMovie + a.Actor.ChargePerRole * a.RoleCount; } } );
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }

    }
    public class CartLine
    {
        public Actor Actor { get; set; }
        public int RoleCount { get; set; }
    }
}
