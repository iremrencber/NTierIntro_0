using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Configurations
{
    //Bu sınıf benim veritabanı tablolarımı temsil eden sınıflarımın paylastıgı ortak özellikleri ayarlama görevini üstlenecektir...Amacı sınıflara özgü ayarlamaları yapan diger ayarlama class'larına bu ortak ayarlama özelliklerini miras vermektir...

    //Generic bir sınıftan miras alıyorsanız ya miras aldıgınız sınıfı cagırırken generic tipini belirlemeniz lazım ya da genericligini devam ettirmesini saglamanız lazım...

    //Bir sınıfın genericligi nasıl devam ettirilir : Öncelikle elinizde hala tip serbestligini ifade eden bir yapı olması lazım...BUnun icin de kendi yarattıgımız class'ı generic olarak yaratıyoruz...Böylece elimize genericliği  ifade eden bir harf geciyor (T) ve biz bu harfi miras aldıgımız sınıfın generic parantezine gönderebiliyoruz...

    //Bizim aynı zamanda miras aldıgımız class'ın kendi generic tipine koydugu constraint(sart)'den dolayı kendi class'ımızın genericligine bir şart vermemiz gerekiyor.... T bir BaseEntity olmalı sartını veriyoruz ki BaseConfiguration cagrıldıgı zaman ona generic olarak BaseEntity olmayan hicbir şey verilemesin...Yani Veritabanında tablo olmayacak hicbir sınıfım ona verilemesin ki onlar üzerinden işlem yapmasın...
    public abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseConfiguration()
        {
            Property(x => x.CreatedDate).HasColumnName("YaratilmaTarihi");
            Property(x => x.UpdatedDate).HasColumnName("GuncellemeTarihi");

        }
    }
}
