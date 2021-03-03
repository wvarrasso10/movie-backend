using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public string Genre { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName= "decimal(10,2)")]
        [DataType(DataType.Currency)]
        //[Range(1,100)]
        public decimal Price { get; set; }
    }
}
