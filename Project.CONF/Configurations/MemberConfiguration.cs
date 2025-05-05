using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Models;

namespace Project.CONF.Configurations
{
    public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            // Member tablosu için konfigürasyon
            ToTable("Members");  // Tablo adı

            Property(m => m.FullName)
                .IsRequired()   // Zorunlu
                .HasMaxLength(100); // Maksimum uzunluk

            Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(m => m.Phone)
                .HasMaxLength(20);
        }
    }
}
