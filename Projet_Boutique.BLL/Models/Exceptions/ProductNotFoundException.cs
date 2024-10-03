using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.BLL.Models.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base( "Aucune personne n'a été trouvé") 
        {
        }
        public ProductNotFoundException(string message) : base(message) 
        { 
        }
    }
}
