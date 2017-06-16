﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoyTea.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }
        public string Cartid { get; set; }
        public int Quantity { get; set; }
        public System.DateTime DataCreated { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}