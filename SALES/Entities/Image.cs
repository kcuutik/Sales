using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Entities
{
    [Table("Image")]
    public partial class Image
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }
        public string Description { get; set; }

        public bool Ischeck { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }
         
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
