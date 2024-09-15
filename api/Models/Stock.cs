using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(16,2)")] //Montante monetario
        public decimal Purchase { get; set; } // Deixa apenas 2 decimais apos a virgula
        [Column(TypeName = "decimal(16,2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        
        public List<Comment> Comments { get; set; } = new List<Comment>(); // relacao um pra muitos
        // List permite que tenhamos "muitos" de algo. Quase como um array
    }
}