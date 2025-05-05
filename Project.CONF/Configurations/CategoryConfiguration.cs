using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");

            Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(100);

            Property(c => c.Description)
                .HasMaxLength(500);
        }

    }
}
