using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Linq;
using System.Text;
using System.IO;

namespace lab4
{
    public class ShoppingCart
    {
        [Key]
        public int ID { get; set; }

        public int Count { get; set; }
        public float Price { get; set; }
        
        #nullable enable
        public int? OrderID { get; set; }
        public Order? Order { get; set; }
        #nullable disable

        public int PartID { get; set; }
        public Part Part { get; set; }
    }
}
