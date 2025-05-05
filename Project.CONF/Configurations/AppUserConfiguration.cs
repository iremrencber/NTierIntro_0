using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public AppUserConfiguration()
        {
            //Property(x => x.UserName).HasColumnName("KullaniciIsmi");
            //ToTable("Kullanicilar");
            //Property(x => x.Password).HasColumnName("Sifre");

            //İlişki Yapılandırılması
            HasOptional(x => x.AppUserProfile).WithRequired(x => x.AppUser); //Birebir ilişki ayarlanması bu şekilde ikinci fazla tamamlanıyor...
        }
    }
}
