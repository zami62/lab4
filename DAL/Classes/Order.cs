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
    public class Order
    {
        [Key]
        public int ID { get; set; }

        public DateTime OrderCreationDate { get; set; }
        public float Price { get; set; }
        public string PaymentMethod { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public LinkedList<ShoppingCart> ShoppingCarts { get; set; }
    }
}
