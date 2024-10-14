using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projet_Boutique.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Boutique.DAL.DataBase.Data
{
    public class DataUser : IEntityTypeConfiguration<User>

    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = "Van Buggenhout", FirstName = "Fabian", BirthDate = new DateTime(1993, 03, 31), Admin = true, Password = "admin", Email = "fabianvanb@proton.me" }
            );
        }
    }
}
