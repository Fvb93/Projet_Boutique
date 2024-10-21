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
        public decimal Amount { get; set; }
        public User OrderUser { get; set; }
        public ICollection<OrderProduct>? ProductList { get; set; }
        public bool IsFinalized { get; set; } = false;
    }
}
