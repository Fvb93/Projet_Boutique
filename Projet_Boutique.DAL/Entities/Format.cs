using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Entities
{
    public class Format
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<FormatProduct> ProductsList { get; set; }
    }
}
