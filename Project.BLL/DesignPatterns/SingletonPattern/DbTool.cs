using Project.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.SingletonPattern
{
    public class DbTool
    {
        DbTool() { }

        //Haydi simdi burada MyContext sınıfım icin bir Singleton Pattern yaratalım...
        //Eger bir sınıfın constructor'ı private olursa o sınıfın dışarıdan instance'ını almanız mümkün olmaz...Bu durumda o sınıfın instance'ını alabilmek için static bir property yaratmamız lazım...Bu property'e de instance adını verelim...
        private static MyContext _dbInstance;
        
        public static MyContext DbInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new MyContext();
                }
                return _dbInstance;
            }
        }
    }


    


}
