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
    public class MetalBlank
    {
        [Key]
        public int ID { get; set; }

        public string Material { get; set; }

        public float Width { get; set; }
        public float Height { get; set; }
        public float Length { get; set; }

        public float Density { get; set; }
        public float Weight { get; set; }

        public float PriceOf1kg { get; set; }
        public float Price { get; set; }

        public LinkedList<Part> Parts { get; set; }
    }
}
