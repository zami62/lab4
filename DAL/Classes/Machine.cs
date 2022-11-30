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
    public class Machine
    {
        [Key]
        public int ID { get; set; }

        public string Model { get; set; }

        public float MaxWidth { get; set; }
        public float MaxHeight { get; set; }
        public float MaxLength { get; set; }

        public float ProcessingTimeOf1mm3 { get; set; }
        public float PriceOfProcessing1mm3 { get; set; }

        public LinkedList<Part> Parts { get; set; }
    }
}
