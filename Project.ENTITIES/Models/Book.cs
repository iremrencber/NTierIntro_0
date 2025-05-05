using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal UnitPrice { get; set; }
        public int PageCount { get; set; }
        public int CategoryID { get; set; }

        // Relational Properties
        public virtual Category Category { get; set; }
        public virtual ICollection<Loan> Loans { get; set; }

    }
}
