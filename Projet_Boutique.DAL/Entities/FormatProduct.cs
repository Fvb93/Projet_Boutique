using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Entities
{
    public class FormatProduct
    {
        public int FormatId { get; set; }
        public Format Format { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Stock { get; set; }
    }
}
