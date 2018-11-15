using System;
using System.Collections.Generic;
using System.Text;

namespace IMDB.Domain.Entities
{
    public class Actor  //as the domain model is in different VS project, it mut be marked as public
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public DateTime DOB { get; set; }
        public string Bio { get; set; }
    }
}
