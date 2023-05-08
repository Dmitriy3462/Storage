using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Models
{
    public class Car
    {

        public string Id { get; set; }
        public string CarModel { get; set; }
        public int Year { get; set; }
        public string?Image { get; set; }
        public IEnumerable<Category> Categorys { get; set; }



    }
}
