using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;




namespace IMDB.Domain.Entities
{
    public class Actor  //as the domain model is in different VS project, it mut be marked as public
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }
        public string Name { get; set; }
        public char Sex { get; set; }
        public DateTime DOB { get; set; }
        [DataType(DataType.MultilineText)]
        public string Bio { get; set; }
        public string Category { get; set; }
        public decimal ChargePerMovie { get; set; }
        public decimal ChargePerRole { get; set; }

        private class HiddenInputAttribute : Attribute
        {
        }
    }
}
