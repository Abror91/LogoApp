using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.UI.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}