using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SALES.Entities
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("Url")]
        public string Url { get; set; }
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
        [JsonProperty("priceIn")]
        public decimal PriceIn { get; set; }
        [JsonProperty("priceOut")]
        public decimal PriceOut { get; set; }
        [JsonProperty("quantilyIn")]
        public int QuantilyIn { get; set; }
        [JsonProperty("quantilyOut")]
        public int QuantilyOut { get; set; }
        [JsonProperty("discount")]
        public decimal Discount { get; set; }
        [JsonProperty("contentt")]
        public string Contentt { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("keywords")]
        public string Keywords { get; set; }
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
        public bool IsTrend { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CreateUser { get; set; }
        public int UpdateUser { get; set; }
        public Category Category { get; set; }
        public virtual  ICollection<Image> Images { get; set; }


    }
}
