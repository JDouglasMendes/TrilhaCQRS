using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string  CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public IList<Products> Productses { get; set; } 
    }
}
