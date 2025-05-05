using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Loan : BaseEntity
    {
        //Kitabın Odunc Alma Sistemi
         public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        //Relational Properties
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
