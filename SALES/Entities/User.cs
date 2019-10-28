using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public bool Ischeck { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }
    }
}
