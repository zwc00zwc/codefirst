using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}