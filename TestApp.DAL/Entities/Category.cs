using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DAL.Entities
{
    public class Category
    {
        public Category()
        {
            Tags = new List<Tag>();
            Logos = new List<Logo>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Logo> Logos { get; set; }
    }
}
