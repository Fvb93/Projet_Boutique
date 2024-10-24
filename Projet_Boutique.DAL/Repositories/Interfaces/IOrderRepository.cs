﻿using Microsoft.EntityFrameworkCore;
using Projet_Boutique.DAL.Entities;
using Projet_Boutique.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.Repositories.Interfaces
{
    public interface IOrderRepository : IRepository<int, Order>
    {
        public bool Update(Order entity, Dictionary<int, int> ListeProduits);
    }
}

