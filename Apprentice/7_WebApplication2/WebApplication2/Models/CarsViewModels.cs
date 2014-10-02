using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Web;

namespace WebApplication2.Models
{
    // added to facilitate role creation with simple CreateRole view
    public class CarViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Year")]
        public string Year { get; set; }

        [Required]
        [Display(Name = "Make")]
        public string Make { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Picture")]
        public string PicUrl { get; set; }

        [Display(Name = "Book Value")]
        public string BookValue { get; set; }
    }

    // added to initiate a new DB connection and Cars table
    public class CarListerDBContext : DbContext
    {
        public DbSet<CarViewModel> Cars { get; set; }
    }
}