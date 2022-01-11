using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20), Required(ErrorMessage = "Title is not valid")]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "Price is not valid")]
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public DateTime CreatedDate { get; set; }
        [Column("ntext")]
        public string About { get; set; }
        public int Count { get; set; }
        public string SKU { get; set; }
    }
}
