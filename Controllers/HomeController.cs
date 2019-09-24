using Pizza.MvcWebUI.Entity;
using Pizza.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Pizza.MvcWebUI.Controllers
{

    public class HomeController : Controller
    {
        DataContext context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var product = context.Products
                .Where(i => i.IsApproved && i.IsHome)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Title.Length > 50 ? i.Title.Substring(0, 47) + "..." : i.Title,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    CategoryId = i.CategoryId,
                    Image = i.Image ?? "1.jpg"
                }).ToList();


            return View(product);

        }
        public ActionResult BlogList(int? id, string q)
        {
            var blog = context.Blogs
                .Where(i => i.IsApproved || i.IsHome)
                .Select(i => new BlogModel()
                {
                    Id = i.Id,
                    Title = i.Title.Length > 50 ? i.Title.Substring(0, 47) + "..." : i.Title,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Image = i.Image ?? "1.jpg",
                    Date = i.Date,
                    CategoryId = i.CategoryId,
                }).AsQueryable();
            if (id != null || string.IsNullOrEmpty(q) == false)
            {
                blog = blog.Where(i => i.CategoryId == id || i.Title.Contains(q) || i.Description.Contains(q));

                return View(blog);
            }
            
            return View(blog);
        }



        public PartialViewResult GetCategories()
        {
            return PartialView(context.Categories.ToList());
        }

        public PartialViewResult Carousel()
        {
            return PartialView(context.Carousels.ToList());
        }
        public PartialViewResult Galery()
        {
            return PartialView(context.Galeries.ToList());
        }


        public ActionResult Blog()
        {
            var blog = context.Blogs
               .Where(i => i.IsApproved && i.IsHome)
               .Select(i => new BlogModel()
               {
                   Id = i.Id,
                   Title = i.Title.Length > 80 ? i.Title.Substring(0, 87) + "..." : i.Title,
                   Description = i.Description.Length > 80 ? i.Description.Substring(0, 87) + "..." : i.Description,
                   Date = i.Date,
                   CategoryId = i.CategoryId,
                   Image = i.Image ?? "1.jpg"
               }).ToList();

            return View(blog);
        }
        public ActionResult BlogDetail(int id)
        {

            return View(context.Blogs.Where(i => i.Id == id).FirstOrDefault());
        }
        public PartialViewResult Seperator()
        {
            return PartialView(context.Seperators.FirstOrDefault());
        }
        public ActionResult About()
        {
            return View(context.Abouts.FirstOrDefault());
        }

        public ActionResult Contact()
        {
            return View(context.Contacts.FirstOrDefault());
        }
        public PartialViewResult FooterAbout()
        {
            return PartialView(context.Abouts.FirstOrDefault());
        }
        public PartialViewResult FooterBlog()
        {
            var blog = context.Blogs
              .Where(i => i.IsApproved && i.IsHome)
              .Select(i => new BlogModel()
              {
                  Id = i.Id,
                  Title = i.Title.Length > 50 ? i.Title.Substring(0, 47) + "..." : i.Title,
                  Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                  Date = i.Date,
                  CategoryId = i.CategoryId,
                  Image = i.Image ?? "1.jpg"
              }).Take(3);
            return PartialView(blog);
        }
        public PartialViewResult FooterCategory()
        {
            return PartialView(context.Categories.ToList());
        }
        public PartialViewResult FooterContact()
        {
            return PartialView(context.Contacts.FirstOrDefault());
        }
    }
}