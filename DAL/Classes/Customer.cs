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
    public class Customer
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public LinkedList<Order> Orders { get; set; }
    }
}
