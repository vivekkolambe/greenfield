﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public int OrderId {  get; set; }
        public DateTime OrderDate { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }


    }
}
