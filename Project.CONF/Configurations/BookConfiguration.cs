using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Models;

namespace Project.CONF.Configurations
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            ToTable("Books");

            Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(200);

            Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(150);

            Property(b => b.UnitPrice)
                .IsRequired();

            Property(b => b.PageCount)
                .IsRequired();

            HasRequired(b => b.Category)   // Category ile ilişki
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryID);
        }
    }
}
