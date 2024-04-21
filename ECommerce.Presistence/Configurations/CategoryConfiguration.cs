using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Elektrik",
                ParentId = 0,
                Priorty = 1,
                isDeleted = false,
                CreatedDate = DateTime.Now
            };

            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                ParentId = 0,
                Priorty = 2,
                isDeleted = false,
                CreatedDate = DateTime.Now
            };

            Category category3 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                ParentId = 1,
                Priorty = 1,
                isDeleted = false,
                CreatedDate = DateTime.Now
            };

            Category category4 = new()
            {
                Id = 4,
                Name = "Kadın",
                ParentId = 2,
                Priorty = 1,
                isDeleted = false,
                CreatedDate = DateTime.Now
            };


            builder.HasData(category1, category2, category3, category4);
        }
    }
}
