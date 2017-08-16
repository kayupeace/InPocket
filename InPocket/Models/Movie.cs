using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

// this is a tutorial model class, not realted to the project we going to do
// Reference Link : https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/adding-a-model

// To connect to Database, go to Web.config, located at bottom of the project

namespace InPocket.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
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