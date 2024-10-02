using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public float Amount { get; set; }
        public User OrderUser { get; set; }
        public IEnumerable<OrderProduct>? ProductList { get; set; } 
    }
}
