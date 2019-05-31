using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.UI.Models
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Logos = new List<LogoViewModel>();
            Tags = new List<TagViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<LogoViewModel> Logos { get; set; }
        public ICollection<TagViewModel> Tags { get; set; }
    }
}