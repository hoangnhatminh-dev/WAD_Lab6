using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MvcProduct.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
