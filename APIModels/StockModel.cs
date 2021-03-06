﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APIModels
{
    public class StockModel
    {
        public DateTime TimeStamp { get; set; }

        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public double Volume { get; set; }


        public string GetTimeStamp
        {
            get
            {
                return TimeStamp.ToString("dd MMM yyyy");
            }
        }
    }
}
