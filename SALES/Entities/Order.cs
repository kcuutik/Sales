using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string Quantity { get; set; }
        public string Description { get; set; }

        public bool Ischeck { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }
    }
}
