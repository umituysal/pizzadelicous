using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizza.MvcWebUI.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }

        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }

        public int BlogId { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}