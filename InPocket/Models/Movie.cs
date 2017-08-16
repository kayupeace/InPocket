using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

// this is a tutorial model class, not realted to the project we going to do
// Reference Link : https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-model

// To connect to Database, go to Web.config, located at bottom of the project

namespace InPocket.Models
{
    public class Movie
    {
        public int ID { set; get; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        // Reference : https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/examining-the-edit-methods-and-edit-view
        // set data annotations for database model
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        //        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    // in order to use entity framework database context, u need install NuGet Package 
    // To install it
    // From the Tools menu click NuGet Package Manager
    // Click Package Manager Console
    // Enter:   Install-Package EntityFramework

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}