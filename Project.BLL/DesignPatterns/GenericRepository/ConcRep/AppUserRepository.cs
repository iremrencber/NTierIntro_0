using Project.BLL.DesignPatterns.GenericRepository.BaseRep.EF;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class AppUserRepository : BaseRepository<AppUser>
    {
        //EK olarak istiyorsanız ortak görevler dısında AppUser'a has görevleri buraya yazabilirsiniz...
    }
}
