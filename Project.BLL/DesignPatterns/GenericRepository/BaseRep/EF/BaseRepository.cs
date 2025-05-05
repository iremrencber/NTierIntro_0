using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Enums;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRep.EF
{
    //EF'e göre veritabanı işlemlerimi uygulayan kodlarımızı  yazacagız
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        //Singleton Pattern ile context'imizi ele geciriyoruz...

        protected MyContext _context;

        public BaseRepository()
        {
            _context = DbTool.DbInstance;
        }
        public void Add(T item)
        {
            //Kampanya kodu iş akısı(Profesyonel Manager Patternde yapılır.Ama soft mimarilerde Repository icerisine yazıldıgını gözlemleyebilirsiniz-tavsiye edilmez)
            _context.Set<T>().Add(item); //context(veritabanına) ulas...Kendini T neyse ona göre set et...(ayarla). Sonra o T olarak gelen nesneyi set ettigin (ayarladıgın) yapıya ekle
            _context.SaveChanges();
        }

        public List<T> GetActives()
        {
            return _context.Set<T>().Where(x => x.Status != DataStatus.Deleted).ToList();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetPassives()
        {
            return _context.Set<T>().Where(x => x.Status == DataStatus.Deleted).ToList();   
        }

        public List<T> GetUpdateds()
        {
            return _context.Set<T>().Where(x=>x.Status == DataStatus.Updated).ToList();
        }


    
        public string HardDelete(T item)
        {
            if (item.Status != DataStatus.Deleted) 
            {
                return "Veriyi silebilmeniz icin önce verinin pasif olması gereklidir.Veri silinemedi";
            }
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
            return "Veri basarıyla silindi";
        }

        public void SoftDelete(T item)
        {
            item.Status = DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            _context.SaveChanges(); 
        }

        public void Update(T item)
        {
            item.Status = DataStatus.Updated;
            item.UpdatedDate = DateTime.Now;
            T originalData = GetById(item.Id);

            //Entry metodu veritabanında direkt bir degişiklik (güncelleme degişikligi) yapmak icin direkt verdiginiz bir emirdir...Sizden hicbir şey set etmeden direkt verinin kendisini ister...Orijinal veriyi verirsiniz ve degişmiş olan halini verirsiniz ve degişik olan verinin degişik olan kısımlarını orijinale entegre edersiniz...
            _context.Entry(originalData).CurrentValues.SetValues(item); //Veritabanına git, degişiklik icin bir giriş emrinde bulun...Orijinal verinin mevcut degerlerini yeni gelen verinin degerleriyle replace et(set et)
            _context.SaveChanges();
        }
    }
}
