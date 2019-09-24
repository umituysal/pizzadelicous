using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pizza.MvcWebUI.Entity
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnec")

        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Galery> Galeries { get; set; }
        public DbSet<Carousel> Carousels { get; set; }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DbSet<Seperator> Seperators { get; set; }
    }
}