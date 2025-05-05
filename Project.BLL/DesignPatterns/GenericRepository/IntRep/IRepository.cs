using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    //BU interface'in görevi teknoloji bagımsız bir şekilde yapılmak istenen eylemlerin imzalarını/baslıklarını sunmasıdır...
    public interface IRepository<T> where T : BaseEntity
    {
        //Queries(Raporlama metotları)


        List<T> GetAll(); //bütün verilerimi getirecek metodum
        T GetById(int id); //benim id'ye göre cagırdıgım veriyi getirecek metodum
        List<T> GetPassives(); //sadece pasif olan verilerimi getirecek metodum
        List<T> GetUpdateds(); //sadece güncellenmiş olan verilerimi getiren metodum
        List<T> GetActives(); //sadece aktif olan (pasif olmayan) verilerimi getirecek metodum

        //Commands (Emir metotlarım)
        void Add(T item);
        void Update(T item);
        void SoftDelete(T item); //Veriyi pasife cekmek


        /// <summary>
        /// Dikkat!! Bu metot veriyi gercekten siler!!
        /// </summary>
        /// <param name="item">Silmek istediginiz veriyi argüman olarak veriniz</param>
        string HardDelete(T item); //Veriyi tamamen yok etmek

    }
}
