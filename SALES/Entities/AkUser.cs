using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Entities
{
    [Table("AkUser")]
    public class AkUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int Roles { get; set; }
        public bool IsActive { get; set; }
        
    }
}
