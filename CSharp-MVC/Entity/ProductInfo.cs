﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MVC.Entity
{
    [Keyless]
    public class ProductInfo
    {
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public string Screen { get; set; }
        public string OS { get; set; }
        public string FrontCam { get; set; }
        public string BackCam { get; set; }
        public string Chip { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string SIM { get; set; }
        public string Battery { get; set; }
        
    }
}
