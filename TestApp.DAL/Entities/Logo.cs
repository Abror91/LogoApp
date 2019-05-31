using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DAL.Entities
{
    public class Logo
    {
        public Logo()
        {
            Tags = new List<Tag>();
        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
