using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.UI.Models
{
    public class LogoViewModel
    {
        public LogoViewModel()
        {
            Tags = new List<TagViewModel>();
        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
        public ICollection<TagViewModel> Tags { get; set; }
    }
}