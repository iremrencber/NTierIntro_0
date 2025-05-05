using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Models;

namespace Project.CONF.Configurations
{
    public class LoanConfiguration : EntityTypeConfiguration<Loan>
    {
        public LoanConfiguration()
        {
            ToTable("Loans");

            Property(l => l.BorrowDate)
                .IsRequired();

            Property(l => l.ReturnDate)
                .IsOptional();

            HasRequired(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookID);

            HasRequired(l => l.Member)
                .WithMany(m => m.Loans)
                .HasForeignKey(l => l.MemberID);
        }
    }
}
