using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime Publishdate { get; set; }
        public decimal BasePrice {  get; set; }
        public int AutherId {  get; set; }
    }
}
