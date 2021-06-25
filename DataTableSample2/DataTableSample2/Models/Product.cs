using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableSample2.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; } = 0;
        public string ProductName { get; set; } = "";
        public string CategoryId { get; set; } = "";
        public string CategoryName { get; set; } = "";


    }
}
