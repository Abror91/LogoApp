using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.DAL.Entities
{
    public class Tag
    {
        public Tag()
        {
            Logos = new List<Logo>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Logo> Logos { get; set; }
    }
}
