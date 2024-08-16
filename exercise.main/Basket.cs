﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    public class Basket
    {
        private Inventory inventory = new Inventory();
        public List<Product> products { get; set; } = new List<Product>();

        public bool AddProduct(string sku)
        {
            Product? item = inventory.Items.Find(item => item.SKU == sku);

            if (item == null)
                return false;
            
            products.Add(item);
            return true;
        }


    }
}
