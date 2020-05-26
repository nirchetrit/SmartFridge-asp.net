using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FridgeStockWeb.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Name")]
        public string name { get; set; }
  
        [DisplayName("Last updated date")]
        [DataType(DataType.Date)]
        public DateTime dateOfLastUpdate { get; set; }

        [DisplayName("Priority")]
        public int? priority { get; set; }

        public int Count { get; set; }

        public string UserID { get; set; }
    }
}