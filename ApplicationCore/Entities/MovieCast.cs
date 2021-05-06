using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class MovieCast
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Guid PurchaseNumber{get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }
        //public int CastId { get; set; }
        //public string Character { get; set; }
        public Movie Movie { get; set; }
        public User Customer { get; set; }
        public object CastId { get; set; }
        //public Cast Cast { get; set; }
    }
}
