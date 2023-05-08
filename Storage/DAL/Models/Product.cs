using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public bool Availability { get; set; }
        public string?Image { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } ///Спросить у никиты
    }
}
