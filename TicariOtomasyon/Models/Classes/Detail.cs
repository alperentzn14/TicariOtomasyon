﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TicariOtomasyon.Models.Classes
{
    public class Detail
    {
        [Key]
        public int DetailID { get; set; }
        [Column(TypeName="Varchar")]
        [StringLength(30)]
        public string   ProductName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(1000)]
        public string   ProductInfo { get; set; }
    }
}