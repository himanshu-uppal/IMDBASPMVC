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
        [Required(ErrorMessage = "Please enter a actor name")]
        public string Name { get; set; }
        public char Sex { get; set; }
        public DateTime DOB { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a bio")]
        public string Bio { get; set; }
        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal ChargePerMovie { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal ChargePerRole { get; set; }

        private class HiddenInputAttribute : Attribute
        {
        }
    }
}
