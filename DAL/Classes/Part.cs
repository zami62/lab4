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
    public class Part
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public float Volume { get; set; }
        public float TotalPrice { get; set; }

        public int MetalBlankID { get; set; }
        public MetalBlank MetalBlank { get; set; }

        public int MachineID { get; set; }
        public Machine Machine { get; set; }

        public LinkedList<ShoppingCart> ShoppingCarts { get; set; } 
    }
}
