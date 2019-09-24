using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizza.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }
        //data annotations
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        public int BlogId { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}