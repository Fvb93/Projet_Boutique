using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public int Stock {  get; set; }
        public IEnumerable<OrderProduct> OrderList { get; set; }
        public float TVA { get; set; }
        public ICollection<CategoryProduct>? CategoriesList { get; set; }
        public IEnumerable<FormatProduct> FormatsList { get; set; }
    }
}
