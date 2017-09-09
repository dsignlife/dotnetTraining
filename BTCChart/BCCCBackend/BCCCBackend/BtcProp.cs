﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCCBackend
{

    [Table(Name = "BTC")]
    class BtcProp
    {
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public decimal Ask { get; set; }
        public decimal Bid { get; set; }
        
        
    }
}