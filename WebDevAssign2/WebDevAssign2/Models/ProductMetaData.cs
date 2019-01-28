﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebDevAssign2.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {

    }
    public class ProductMetaData
    {
        [Display(Name = "Product Name")]
        public string Name;
    }
}